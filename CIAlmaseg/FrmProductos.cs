using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIAlmaseg.Clases;
using System.Data.SqlClient;

namespace CIAlmaseg
{
    public partial class FrmProductos : Form
    {
        private int idProductoSeleccionado = 0;
        public FrmProductos()
        {
            InitializeComponent();
            Tema.AutoAplicar(this);
            CargarCategorias();
            CargarProductos();
        }
        private void CargarCategorias()
        {
            try
            {
                Conexion conexionBD = new Conexion();

                using (SqlConnection conexion = conexionBD.AbrirConexion())
                {
                    string consulta = @"
                SELECT id_categoria, nombre
                FROM tbl.categoria
                WHERE estado = 1
                ORDER BY nombre;";

                    SqlDataAdapter adaptador =
                        new SqlDataAdapter(consulta, conexion);

                    DataTable tablaCategorias = new DataTable();
                    adaptador.Fill(tablaCategorias);

                    cmbCategoria.DataSource = tablaCategorias;
                    cmbCategoria.DisplayMember = "nombre";
                    cmbCategoria.ValueMember = "id_categoria";
                    cmbCategoria.SelectedIndex = -1;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "No fue posible cargar las categorías:\n\n" +
                    error.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void CargarProductos()
        {
            try
            {
                Conexion conexionBD = new Conexion();

                using (SqlConnection conexion = conexionBD.AbrirConexion())
                {
                    string consulta = @"
                SELECT
                    p.id_producto AS ID,
                    p.codigo AS Código,
                    p.nombre AS Nombre,
                    c.nombre AS Categoría,
                    p.descripcion AS Descripción,
                    p.precio_compra AS [Precio compra],
                    p.precio_venta AS [Precio venta],
                    p.stock AS Stock,
                    p.stock_minimo AS [Stock mínimo],
                    CASE
                        WHEN p.estado = 1 THEN 'Activo'
                        ELSE 'Inactivo'
                    END AS Estado
                FROM tbl.producto AS p
                INNER JOIN tbl.categoria AS c
                    ON c.id_categoria = p.id_categoria
                ORDER BY p.nombre;";

                    SqlDataAdapter adaptador =
                        new SqlDataAdapter(consulta, conexion);

                    DataTable tablaProductos = new DataTable();
                    adaptador.Fill(tablaProductos);

                    dgvProductos.DataSource = tablaProductos;
                    dgvProductos.ClearSelection();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "No fue posible cargar los productos:\n\n" + error.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
            "¿Desea cerrar la gestión de productos?",
            "Cerrar formulario",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
             );

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            cmbCategoria.SelectedIndex = -1;
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            nudStockMinimo.Value = 0;
            txtDescripcion.Clear();
            chkEstado.Checked = true;

            lblStockActual.Text = "0 unidades";

            txtCodigo.Focus();
        }

        private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
        {
            decimal precioCompra;

            if (decimal.TryParse(txtPrecioCompra.Text, out precioCompra))
            {
                decimal precioVenta = precioCompra * 1.30m;
                txtPrecioVenta.Text = precioVenta.ToString("N0");
            }
            else
            {
                txtPrecioVenta.Clear();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
        string.IsNullOrWhiteSpace(txtNombre.Text) ||
        cmbCategoria.SelectedIndex == -1 ||
        string.IsNullOrWhiteSpace(txtPrecioCompra.Text))
            {
                MessageBox.Show("Complete los campos obligatorios.");
                return;
            }

            decimal precioCompra;

            if (!decimal.TryParse(txtPrecioCompra.Text, out precioCompra))
            {
                MessageBox.Show("El precio de compra no es válido.");
                return;
            }

            try
            {
                Conexion conexionBD = new Conexion();

                using (SqlConnection conexion = conexionBD.AbrirConexion())
                {
                    string consulta;

                    if (idProductoSeleccionado == 0)
                    {
                        consulta = @"
                    INSERT INTO tbl.producto
                    (
                        id_categoria,
                        codigo,
                        nombre,
                        descripcion,
                        precio_compra,
                        porcentaje_ganancia,
                        stock_minimo,
                        estado
                    )
                    VALUES
                    (
                        @idCategoria,
                        @codigo,
                        @nombre,
                        @descripcion,
                        @precioCompra,
                        30,
                        @stockMinimo,
                        @estado
                    );";
                    }
                    else
                    {
                        consulta = @"
                    UPDATE tbl.producto
                    SET
                        id_categoria = @idCategoria,
                        codigo = @codigo,
                        nombre = @nombre,
                        descripcion = @descripcion,
                        precio_compra = @precioCompra,
                        porcentaje_ganancia = 30,
                        stock_minimo = @stockMinimo,
                        estado = @estado
                    WHERE id_producto = @idProducto;";
                    }

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@idCategoria",
                            Convert.ToInt32(cmbCategoria.SelectedValue)
                        );

                        comando.Parameters.AddWithValue(
                            "@codigo",
                            txtCodigo.Text.Trim()
                        );

                        comando.Parameters.AddWithValue(
                            "@nombre",
                            txtNombre.Text.Trim()
                        );

                        comando.Parameters.AddWithValue(
                            "@descripcion",
                            txtDescripcion.Text.Trim()
                        );

                        comando.Parameters.AddWithValue(
                            "@precioCompra",
                            precioCompra
                        );

                        comando.Parameters.AddWithValue(
                            "@stockMinimo",
                            Convert.ToInt32(nudStockMinimo.Value)
                        );

                        comando.Parameters.AddWithValue(
                            "@estado",
                            chkEstado.Checked
                        );

                        if (idProductoSeleccionado != 0)
                        {
                            comando.Parameters.AddWithValue(
                                "@idProducto",
                                idProductoSeleccionado
                            );
                        }

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    idProductoSeleccionado == 0
                        ? "Producto guardado correctamente."
                        : "Producto actualizado correctamente."
                );

                idProductoSeleccionado = 0;
                btnGuardar.Text = "GUARDAR";

                CargarProductos();

                txtCodigo.Clear();
                txtNombre.Clear();
                cmbCategoria.SelectedIndex = -1;
                txtPrecioCompra.Clear();
                txtPrecioVenta.Clear();
                txtDescripcion.Clear();
                nudStockMinimo.Value = 0;
                chkEstado.Checked = true;
                lblStockActual.Text = "0 unidades";
            }
            catch (SqlException error)
            {
                if (error.Number == 2601 || error.Number == 2627)
                {
                    MessageBox.Show("Ya existe otro producto con ese código.");
                }
                else
                {
                    MessageBox.Show(
                        "No fue posible guardar el producto:\n\n" +
                        error.Message
                    );
                }
            }
            

         }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un producto de la tabla.",
                    "Editar producto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            idProductoSeleccionado = Convert.ToInt32(
                dgvProductos.CurrentRow.Cells["ID"].Value
            );

            txtCodigo.Text =
                dgvProductos.CurrentRow.Cells["Código"].Value.ToString();

            txtNombre.Text =
                dgvProductos.CurrentRow.Cells["Nombre"].Value.ToString();

            cmbCategoria.Text =
                dgvProductos.CurrentRow.Cells["Categoría"].Value.ToString();

            txtDescripcion.Text =
                dgvProductos.CurrentRow.Cells["Descripción"].Value.ToString();

            txtPrecioCompra.Text =
                dgvProductos.CurrentRow.Cells["Precio compra"].Value.ToString();

            txtPrecioVenta.Text =
                dgvProductos.CurrentRow.Cells["Precio venta"].Value.ToString();

            nudStockMinimo.Value = Convert.ToDecimal(
                dgvProductos.CurrentRow.Cells["Stock mínimo"].Value
            );

            lblStockActual.Text =
                dgvProductos.CurrentRow.Cells["Stock"].Value + " unidades";

            chkEstado.Checked =
                dgvProductos.CurrentRow.Cells["Estado"].Value.ToString() == "Activo";

            btnGuardar.Text = "ACTUALIZAR";
        }
    }
}
