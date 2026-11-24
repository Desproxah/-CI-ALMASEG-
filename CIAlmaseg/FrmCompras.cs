using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CIAlmaseg.Clases;

namespace CIAlmaseg
{
    public partial class FrmCompras : Form
    {
        private DataTable detalle;
        private DataTable productos;
        private int idEmpleadoSesion = 0;

        public FrmCompras()
        {
            InitializeComponent();
            Tema.AutoAplicar(this);

            tabCompras.Font = Tema.Fuente(9.5F);
            tabCompras.BackColor = Tema.Fondo;
            paginaNueva.BackColor = Tema.Blanco;
            paginaHistorial.BackColor = Tema.Blanco;
            Tema.Tarjeta(pnlCompra);
            Tema.Tarjeta(pnlDetalle);

            ConstruirDetalle();

            btnAgregarProducto.Click += btnAgregarProducto_Click;
            btnEliminarDetalle.Click += btnEliminarDetalle_Click;
            btnNuevaCompra.Click += btnNuevaCompra_Click;
            btnConfirmarCompra.Click += btnConfirmarCompra_Click;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            dgvHistorial.CellClick += dgvHistorial_CellClick;
            tabCompras.SelectedIndexChanged += tabCompras_SelectedIndexChanged;

            CargarEmpleadoSesion();
            CargarProveedores();
            CargarProductos();
            CargarHistorial();
            LimpiarCompra();
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
        }

        private void ConstruirDetalle()
        {
            detalle = new DataTable();
            detalle.Columns.Add("id_producto", typeof(int));
            detalle.Columns.Add("Código", typeof(string));
            detalle.Columns.Add("Producto", typeof(string));
            detalle.Columns.Add("Cantidad", typeof(int));
            detalle.Columns.Add("Costo unitario", typeof(decimal));
            detalle.Columns.Add("Subtotal", typeof(decimal));

            dgvDetalleCompra.DataSource = detalle;
            dgvDetalleCompra.Columns["id_producto"].Visible = false;
            dgvDetalleCompra.ClearSelection();

            productos = new DataTable();
            productos.Columns.Add("id_producto", typeof(int));
            productos.Columns.Add("codigo", typeof(string));
            productos.Columns.Add("nombre", typeof(string));
            productos.Columns.Add("display", typeof(string));
            productos.Columns.Add("costo", typeof(decimal));
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

        private void CargarProveedores()
        {
            try
            {
                using (SqlConnection conexion = new Conexion().AbrirConexion())
                {
                    string consulta = @"
SELECT id_proveedor,
       razon_social + '  ·  ' + nit AS display
FROM tbl.proveedor
WHERE estado = 1
ORDER BY razon_social;";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    cmbProveedor.DataSource = tabla;
                    cmbProveedor.DisplayMember = "display";
                    cmbProveedor.ValueMember = "id_proveedor";
                    cmbProveedor.SelectedIndex = -1;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "No fue posible cargar los proveedores:\n\n" + error.Message,
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
       precio_compra AS costo,
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

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow producto = ProductoSeleccionado();

            if (producto == null)
            {
                txtCostoUnitario.Clear();
                lblStockActual.Text = "Stock actual: 0 unidades";
                return;
            }

            txtCostoUnitario.Text = Convert.ToDecimal(producto["costo"])
                .ToString("N2", CultureInfo.CurrentCulture);
            lblStockActual.Text = "Stock actual: " +
                Convert.ToInt32(producto["stock"]) + " unidades";
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

            decimal costo;

            if (!decimal.TryParse(txtCostoUnitario.Text, NumberStyles.Number,
                    CultureInfo.CurrentCulture, out costo) || costo < 0)
            {
                MessageBox.Show("Escriba un costo unitario válido.");
                txtCostoUnitario.Focus();
                return;
            }

            int cantidad = (int)nudCantidad.Value;
            int idProducto = Convert.ToInt32(producto["id_producto"]);

            DataRow existente = null;

            foreach (DataRow fila in detalle.Rows)
            {
                if (Convert.ToInt32(fila["id_producto"]) == idProducto)
                {
                    existente = fila;
                    break;
                }
            }

            if (existente != null)
            {
                int total = Convert.ToInt32(existente["Cantidad"]) + cantidad;
                existente["Cantidad"] = total;
                existente["Costo unitario"] = costo;
                existente["Subtotal"] = total * costo;
            }
            else
            {
                detalle.Rows.Add(
                    idProducto,
                    producto["codigo"].ToString(),
                    producto["nombre"].ToString(),
                    cantidad,
                    costo,
                    cantidad * costo);
            }

            ActualizarTotal();
            cmbProducto.SelectedIndex = -1;
            cmbProducto.Focus();
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            if (dgvDetalleCompra.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto de la tabla para eliminarlo.");
                return;
            }

            detalle.Rows.RemoveAt(dgvDetalleCompra.CurrentRow.Index);
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

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            LimpiarCompra();
        }

        private void LimpiarCompra()
        {
            detalle.Rows.Clear();
            ActualizarTotal();

            cmbProveedor.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;
            txtCostoUnitario.Clear();
            lblStockActual.Text = "Stock actual: 0 unidades";
            nudCantidad.Value = 1;
            txtObservacion.Clear();
            dtpFecha.Value = DateTime.Today;

            if (cmbEstado.Items.Count > 1)
            {
                cmbEstado.SelectedIndex = 1;
            }

            dgvDetalleCompra.ClearSelection();
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            if (cmbProveedor.SelectedValue == null)
            {
                MessageBox.Show("Seleccione el proveedor.");
                cmbProveedor.Focus();
                return;
            }

            if (detalle.Rows.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto a la compra.");
                cmbProducto.Focus();
                return;
            }

            if (idEmpleadoSesion == 0)
            {
                MessageBox.Show(
                    "Este usuario no tiene un empleado asociado. " +
                    "Asócialo desde el módulo de Empleados para registrar compras.");
                return;
            }

            string estado = string.IsNullOrWhiteSpace(cmbEstado.Text)
                ? "REGISTRADA"
                : cmbEstado.Text;

            try
            {
                int idCompra;

                using (SqlConnection conexion = new Conexion().AbrirConexion())
                using (SqlTransaction transaccion = conexion.BeginTransaction())
                {
                    SqlCommand comandoCompra = new SqlCommand(@"
INSERT INTO tbl.compra (id_proveedor, id_empleado, fecha, estado, observacion)
VALUES (@proveedor, @empleado, @fecha, @estado, @observacion);
SELECT CAST(SCOPE_IDENTITY() AS INT);", conexion, transaccion);

                    comandoCompra.Parameters.AddWithValue("@proveedor", cmbProveedor.SelectedValue);
                    comandoCompra.Parameters.AddWithValue("@empleado", idEmpleadoSesion);
                    comandoCompra.Parameters.AddWithValue("@fecha", dtpFecha.Value);
                    comandoCompra.Parameters.AddWithValue("@estado", estado);
                    comandoCompra.Parameters.AddWithValue(
                        "@observacion",
                        string.IsNullOrWhiteSpace(txtObservacion.Text)
                            ? (object)DBNull.Value
                            : txtObservacion.Text.Trim());

                    idCompra = Convert.ToInt32(comandoCompra.ExecuteScalar());

                    /* Una compra cancelada se registra sin detalle para no
                       sumar existencias al inventario. */
                    if (estado != "CANCELADA")
                    {
                        foreach (DataRow fila in detalle.Rows)
                        {
                            SqlCommand comandoDetalle = new SqlCommand(@"
INSERT INTO tbl.detalle_compra (id_compra, id_producto, cantidad, costo_unitario)
VALUES (@compra, @producto, @cantidad, @costo);", conexion, transaccion);

                            comandoDetalle.Parameters.AddWithValue("@compra", idCompra);
                            comandoDetalle.Parameters.AddWithValue(
                                "@producto",
                                Convert.ToInt32(fila["id_producto"]));
                            comandoDetalle.Parameters.AddWithValue(
                                "@cantidad",
                                Convert.ToInt32(fila["Cantidad"]));
                            comandoDetalle.Parameters.AddWithValue(
                                "@costo",
                                Convert.ToDecimal(fila["Costo unitario"]));

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
                    "Compra #" + idCompra + " registrada correctamente.\n" +
                    (estado == "CANCELADA"
                        ? "Estado: CANCELADA (sin movimiento de inventario)."
                        : "Total: " + Tema.FormatearMoneda(total) +
                          "\nEl inventario fue actualizado."),
                    "CI Almaseg",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarCompra();
                CargarHistorial();
            }
            catch (SqlException error)
            {
                if (error.Number == 50001)
                {
                    MessageBox.Show(
                        "No fue posible confirmar la compra: dejaría stock negativo.");
                }
                else
                {
                    MessageBox.Show(
                        "No fue posible registrar la compra:\n\n" + error.Message,
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
SELECT k.id_compra AS [Compra],
       k.fecha AS Fecha,
       p.razon_social AS Proveedor,
       e.nombre AS Empleado,
       k.estado AS Estado,
       k.total AS Total,
       k.observacion AS Observación
FROM tbl.compra k
INNER JOIN tbl.proveedor p ON p.id_proveedor = k.id_proveedor
INNER JOIN tbl.empleado e ON e.id_empleado = k.id_empleado
ORDER BY k.fecha DESC, k.id_compra DESC;";

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
                        tabla.Rows.Count + " compras  ·  " +
                        Tema.FormatearMoneda(acumulado) + " acumulado";

                    dgvDetalleHistorial.DataSource = null;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "No fue posible cargar el historial de compras:\n\n" + error.Message,
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

            int idCompra = Convert.ToInt32(dgvHistorial.CurrentRow.Cells["Compra"].Value);

            try
            {
                using (SqlConnection conexion = new Conexion().AbrirConexion())
                {
                    string consulta = @"
SELECT p.codigo AS Código,
       p.nombre AS Producto,
       d.cantidad AS Cantidad,
       d.costo_unitario AS [Costo unitario],
       d.subtotal AS Subtotal
FROM tbl.detalle_compra d
INNER JOIN tbl.producto p ON p.id_producto = d.id_producto
WHERE d.id_compra = @compra
ORDER BY p.nombre;";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    adaptador.SelectCommand.Parameters.AddWithValue("@compra", idCompra);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvDetalleHistorial.DataSource = tabla;
                    dgvDetalleHistorial.ClearSelection();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "No fue posible cargar el detalle de la compra:\n\n" + error.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void tabCompras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCompras.SelectedTab == paginaHistorial)
            {
                CargarHistorial();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
