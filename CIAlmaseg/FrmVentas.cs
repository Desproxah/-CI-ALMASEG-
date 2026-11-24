using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CIAlmaseg.Clases;

namespace CIAlmaseg
{
    public partial class FrmVentas : Form
    {
        private DataTable detalle;
        private DataTable productos;
        private int idEmpleadoSesion = 0;

        public FrmVentas()
        {
            InitializeComponent();
            Tema.AutoAplicar(this);

            tabVentas.Font = Tema.Fuente(9.5F);
            tabVentas.BackColor = Tema.Fondo;
            paginaNueva.BackColor = Tema.Blanco;
            paginaHistorial.BackColor = Tema.Blanco;
            Tema.Tarjeta(pnlVenta);
            Tema.Tarjeta(pnlProducto);

            ConstruirDetalle();

            btnAgregarProducto.Click += btnAgregarProducto_Click;
            btnEliminarDetalle.Click += btnEliminarDetalle_Click;
            btnNueva.Click += btnNueva_Click;
            btnConfirmarVenta.Click += btnConfirmarVenta_Click;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            dgvHistorial.CellClick += dgvHistorial_CellClick;
            tabVentas.SelectedIndexChanged += tabVentas_SelectedIndexChanged;

            CargarEmpleadoSesion();
            CargarClientes();
            CargarProductos();
            CargarHistorial();
            LimpiarVenta();
        }

        private void ConstruirDetalle()
        {
            detalle = new DataTable();
            detalle.Columns.Add("id_producto", typeof(int));
            detalle.Columns.Add("Código", typeof(string));
            detalle.Columns.Add("Producto", typeof(string));
            detalle.Columns.Add("Cantidad", typeof(int));
            detalle.Columns.Add("Precio unitario", typeof(decimal));
            detalle.Columns.Add("Subtotal", typeof(decimal));

            dgvDetalleVenta.DataSource = detalle;
            dgvDetalleVenta.Columns["id_producto"].Visible = false;
            dgvDetalleVenta.ClearSelection();

            productos = new DataTable();
            productos.Columns.Add("id_producto", typeof(int));
            productos.Columns.Add("codigo", typeof(string));
            productos.Columns.Add("nombre", typeof(string));
            productos.Columns.Add("display", typeof(string));
            productos.Columns.Add("precio", typeof(decimal));
            productos.Columns.Add("stock", typeof(int));
            productos.PrimaryKey = new DataColumn[] { productos.Columns["id_producto"] };
        }

        private void CargarEmpleadoSesion()
        {
            try
            {
                using (SqlConnection conexion = new Conexion().AbrirConexion())
                {
                    SqlCommand comando = new SqlCommand(
                        "SELECT id_empleado FROM tbl.empleado WHERE id_usuario = @idUsuario;",
                        conexion);
                    comando.Parameters.AddWithValue("@idUsuario", SesionActual.IdUsuario);

                    object resultado = comando.ExecuteScalar();

                    idEmpleadoSesion = resultado == null || resultado == DBNull.Value
                        ? 0
                        : Convert.ToInt32(resultado);
                }
            }
            catch
            {
                idEmpleadoSesion = 0;
            }
        }

        private void CargarClientes()
        {
            try
            {
                using (SqlConnection conexion = new Conexion().AbrirConexion())
                {
                    string consulta = @"
SELECT id_cliente,
       nombre + '  ·  ' + numero_documento AS display
FROM tbl.cliente
WHERE estado = 1
ORDER BY nombre;";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    cmbCliente.DataSource = tabla;
                    cmbCliente.DisplayMember = "display";
                    cmbCliente.ValueMember = "id_cliente";
                    cmbCliente.SelectedIndex = -1;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "No fue posible cargar los clientes:\n\n" + error.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarProductos()
        {
            try
            {
                using (SqlConnection conexion = new Conexion().AbrirConexion())
                {
                    string consulta = @"
SELECT id_producto,
       codigo,
       nombre,
       codigo + '  ' + nombre AS display,
       precio_venta AS precio,
       stock
FROM tbl.producto
WHERE estado = 1
ORDER BY nombre;";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    adaptador.Fill(productos);

                    cmbProducto.DataSource = productos;
                    cmbProducto.DisplayMember = "display";
                    cmbProducto.ValueMember = "id_producto";
                    cmbProducto.SelectedIndex = -1;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "No fue posible cargar los productos:\n\n" + error.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private DataRow ProductoSeleccionado()
        {
            if (cmbProducto.SelectedValue == null)
            {
                return null;
            }

            return productos.Rows.Find(Convert.ToInt32(cmbProducto.SelectedValue));
        }

        private int StockEnCarrito(int idProducto)
        {
            int cantidad = 0;

            foreach (DataRow fila in detalle.Rows)
            {
                if (Convert.ToInt32(fila["id_producto"]) == idProducto)
                {
                    cantidad += Convert.ToInt32(fila["Cantidad"]);
                }
            }

            return cantidad;
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow producto = ProductoSeleccionado();

            if (producto == null)
            {
                txtValorVenta.Clear();
                lblStockActual.Text = "Stock disponible: 0 unidades";
                return;
            }

            int stock = Convert.ToInt32(producto["stock"]) - StockEnCarrito(
                Convert.ToInt32(producto["id_producto"]));

            txtValorVenta.Text = Tema.FormatearMoneda(Convert.ToDecimal(producto["precio"]));
            lblStockActual.Text = "Stock disponible: " + Math.Max(0, stock) + " unidades";

            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = Math.Max(1, stock);
            nudCantidad.Value = 1;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            DataRow producto = ProductoSeleccionado();

            if (producto == null)
            {
                MessageBox.Show("Seleccione un producto.");
                cmbProducto.Focus();
                return;
            }

            int idProducto = Convert.ToInt32(producto["id_producto"]);
            int stockDisponible = Convert.ToInt32(producto["stock"]) - StockEnCarrito(idProducto);
            int cantidad = (int)nudCantidad.Value;

            if (cantidad > stockDisponible)
            {
                MessageBox.Show(
                    "Stock insuficiente. Solo hay " + Math.Max(0, stockDisponible) +
                    " unidades disponibles de este producto.");
                return;
            }

            DataRow existente = null;

            foreach (DataRow fila in detalle.Rows)
            {
                if (Convert.ToInt32(fila["id_producto"]) == idProducto)
                {
                    existente = fila;
                    break;
                }
            }

            decimal precio = Convert.ToDecimal(producto["precio"]);

            if (existente != null)
            {
                int total = Convert.ToInt32(existente["Cantidad"]) + cantidad;
                existente["Cantidad"] = total;
                existente["Subtotal"] = total * precio;
            }
            else
            {
                detalle.Rows.Add(
                    idProducto,
                    producto["codigo"].ToString(),
                    producto["nombre"].ToString(),
                    cantidad,
                    precio,
                    cantidad * precio);
            }

            ActualizarTotal();
            cmbProducto.SelectedIndex = -1;
            cmbProducto.Focus();
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            if (dgvDetalleVenta.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto de la tabla para eliminarlo.");
                return;
            }

            detalle.Rows.RemoveAt(dgvDetalleVenta.CurrentRow.Index);
            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            decimal total = 0;

            foreach (DataRow fila in detalle.Rows)
            {
                total += Convert.ToDecimal(fila["Subtotal"]);
            }

            lblTotal.Text = Tema.FormatearMoneda(total);
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            LimpiarVenta();
        }

        private void LimpiarVenta()
        {
            detalle.Rows.Clear();
            ActualizarTotal();

            cmbCliente.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;
            txtValorVenta.Clear();
            lblStockActual.Text = "Stock disponible: 0 unidades";
            nudCantidad.Value = 1;
            txtObservacion.Clear();
            dtpFecha.Value = DateTime.Today;

            if (cmbEstado.Items.Count > 1)
            {
                cmbEstado.SelectedIndex = 1;
            }

            dgvDetalleVenta.ClearSelection();
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("Seleccione el cliente.");
                cmbCliente.Focus();
                return;
            }

            if (detalle.Rows.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto a la venta.");
                cmbProducto.Focus();
                return;
            }

            if (idEmpleadoSesion == 0)
            {
                MessageBox.Show(
                    "Este usuario no tiene un empleado asociado. " +
                    "Asócialo desde el módulo de Empleados para registrar ventas.");
                return;
            }

            string estado = string.IsNullOrWhiteSpace(cmbEstado.Text)
                ? "COMPLETADA"
                : cmbEstado.Text;

            try
            {
                int idVenta;

                using (SqlConnection conexion = new Conexion().AbrirConexion())
                using (SqlTransaction transaccion = conexion.BeginTransaction())
                {
                    SqlCommand comandoVenta = new SqlCommand(@"
INSERT INTO tbl.venta (id_cliente, id_empleado, fecha, estado, observacion)
VALUES (@cliente, @empleado, @fecha, @estado, @observacion);
SELECT CAST(SCOPE_IDENTITY() AS INT);", conexion, transaccion);

                    comandoVenta.Parameters.AddWithValue("@cliente", cmbCliente.SelectedValue);
                    comandoVenta.Parameters.AddWithValue("@empleado", idEmpleadoSesion);
                    comandoVenta.Parameters.AddWithValue("@fecha", dtpFecha.Value);
                    comandoVenta.Parameters.AddWithValue("@estado", estado);
                    comandoVenta.Parameters.AddWithValue(
                        "@observacion",
                        string.IsNullOrWhiteSpace(txtObservacion.Text)
                            ? (object)DBNull.Value
                            : txtObservacion.Text.Trim());

                    idVenta = Convert.ToInt32(comandoVenta.ExecuteScalar());

                    /* Una venta cancelada no mueve inventario: se registra sin
                       detalle para no descontar stock. */
                    if (estado != "CANCELADA")
                    {
                        foreach (DataRow fila in detalle.Rows)
                        {
                            SqlCommand comandoDetalle = new SqlCommand(@"
INSERT INTO tbl.detalle_venta (id_venta, id_producto, cantidad, precio_unitario)
VALUES (@venta, @producto, @cantidad, @precio);", conexion, transaccion);

                            comandoDetalle.Parameters.AddWithValue("@venta", idVenta);
                            comandoDetalle.Parameters.AddWithValue(
                                "@producto",
                                Convert.ToInt32(fila["id_producto"]));
                            comandoDetalle.Parameters.AddWithValue(
                                "@cantidad",
                                Convert.ToInt32(fila["Cantidad"]));
                            comandoDetalle.Parameters.AddWithValue(
                                "@precio",
                                Convert.ToDecimal(fila["Precio unitario"]));

                            comandoDetalle.ExecuteNonQuery();
                        }
                    }

                    transaccion.Commit();
                }

                decimal total = 0;

                foreach (DataRow fila in detalle.Rows)
                {
                    total += Convert.ToDecimal(fila["Subtotal"]);
                }

                MessageBox.Show(
                    "Venta #" + idVenta + " registrada correctamente.\n" +
                    (estado == "CANCELADA"
                        ? "Estado: CANCELADA (sin movimiento de inventario)."
                        : "Total: " + Tema.FormatearMoneda(total)),
                    "CI Almaseg",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarVenta();
                CargarHistorial();
            }
            catch (SqlException error)
            {
                if (error.Number == 50002)
                {
                    MessageBox.Show(
                        "No fue posible confirmar la venta: el stock de uno de los " +
                        "productos no alcanza.");
                }
                else
                {
                    MessageBox.Show(
                        "No fue posible registrar la venta:\n\n" + error.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void CargarHistorial()
        {
            try
            {
                using (SqlConnection conexion = new Conexion().AbrirConexion())
                {
                    string consulta = @"
SELECT v.id_venta AS [Venta],
       v.fecha AS Fecha,
       c.nombre AS Cliente,
       e.nombre AS Empleado,
       v.estado AS Estado,
       v.total AS Total,
       v.observacion AS Observación
FROM tbl.venta v
INNER JOIN tbl.cliente c ON c.id_cliente = v.id_cliente
INNER JOIN tbl.empleado e ON e.id_empleado = v.id_empleado
ORDER BY v.fecha DESC, v.id_venta DESC;";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvHistorial.DataSource = tabla;
                    dgvHistorial.ClearSelection();

                    decimal acumulado = 0;

                    foreach (DataRow fila in tabla.Rows)
                    {
                        acumulado += Convert.ToDecimal(fila["Total"]);
                    }

                    lblResumenHistorial.Text =
                        tabla.Rows.Count + " ventas  ·  " +
                        Tema.FormatearMoneda(acumulado) + " acumulado";

                    dgvDetalleHistorial.DataSource = null;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "No fue posible cargar el historial de ventas:\n\n" + error.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvHistorial.CurrentRow == null)
            {
                return;
            }

            int idVenta = Convert.ToInt32(dgvHistorial.CurrentRow.Cells["Venta"].Value);

            try
            {
                using (SqlConnection conexion = new Conexion().AbrirConexion())
                {
                    string consulta = @"
SELECT p.codigo AS Código,
       p.nombre AS Producto,
       d.cantidad AS Cantidad,
       d.precio_unitario AS [Precio unitario],
       d.subtotal AS Subtotal
FROM tbl.detalle_venta d
INNER JOIN tbl.producto p ON p.id_producto = d.id_producto
WHERE d.id_venta = @venta
ORDER BY p.nombre;";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    adaptador.SelectCommand.Parameters.AddWithValue("@venta", idVenta);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvDetalleHistorial.DataSource = tabla;
                    dgvDetalleHistorial.ClearSelection();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "No fue posible cargar el detalle de la venta:\n\n" + error.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void tabVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabVentas.SelectedTab == paginaHistorial)
            {
                CargarHistorial();
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
