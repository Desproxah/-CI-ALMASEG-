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
    public partial class FrmCategorias : Form
    {
        private int idCategoriaSeleccionada = 0;
        public FrmCategorias()
        {
            InitializeComponent();
            Tema.AutoAplicar(this);
            CargarCategorias();
        }
        private void CargarCategorias()
        {
            try
            {
                Conexion conexionBD = new Conexion();

                using (SqlConnection conexion = conexionBD.AbrirConexion())
                {
                    string consulta = @"
                SELECT
                    id_categoria AS ID,
                    nombre AS Nombre,
                    descripcion AS Descripción,
                    CASE
                        WHEN estado = 1 THEN 'Activo'
                        ELSE 'Inactivo'
                    END AS Estado
                FROM tbl.categoria
                ORDER BY nombre;";

                    SqlDataAdapter adaptador =
                        new SqlDataAdapter(consulta, conexion);

                    DataTable tablaCategorias = new DataTable();
                    adaptador.Fill(tablaCategorias);

                    dgvCategorias.DataSource = tablaCategorias;
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
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Escriba el nombre de la categoría.");
                txtNombre.Focus();
                return;
            }

            try
            {
                Conexion conexionBD = new Conexion();

                using (SqlConnection conexion = conexionBD.AbrirConexion())
                {
                    string consulta;

                    if (idCategoriaSeleccionada == 0)
                    {
                        consulta = @"
                    INSERT INTO tbl.categoria
                        (nombre, descripcion, estado)
                    VALUES
                        (@nombre, @descripcion, @estado);";
                    }
                    else
                    {
                        consulta = @"
                    UPDATE tbl.categoria
                    SET descripcion = @descripcion,
                        estado = @estado
                    WHERE id_categoria = @idCategoria;";
                    }

                    SqlCommand comando = new SqlCommand(consulta, conexion);

                    comando.Parameters.AddWithValue(
                        "@nombre",
                        txtNombre.Text.Trim()
                    );

                    comando.Parameters.AddWithValue(
                        "@descripcion",
                        txtDescripcion.Text.Trim()
                    );

                    comando.Parameters.AddWithValue(
                        "@estado",
                        chkEstado.Checked
                    );

                    if (idCategoriaSeleccionada != 0)
                    {
                        comando.Parameters.AddWithValue(
                            "@idCategoria",
                            idCategoriaSeleccionada
                        );
                    }

                    comando.ExecuteNonQuery();
                }

                if (idCategoriaSeleccionada == 0)
                {
                    MessageBox.Show("Categoría guardada correctamente.");
                }
                else
                {
                    MessageBox.Show("Categoría actualizada correctamente.");
                }

                idCategoriaSeleccionada = 0;

                txtNombre.Clear();
                txtDescripcion.Clear();
                chkEstado.Checked = true;
                btnGuardar.Text = "GUARDAR";

                CargarCategorias();
            }
            catch (SqlException error)
            {
                if (error.Number == 2601 || error.Number == 2627)
                {
                    MessageBox.Show("Ya existe una categoría con ese nombre.");
                }
                else
                {
                    MessageBox.Show(
                        "No fue posible guardar la categoría:\n\n" +
                        error.Message
                    );
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            idCategoriaSeleccionada = 0;

            txtNombre.Clear();
            txtDescripcion.Clear();
            chkEstado.Checked = true;

            btnGuardar.Text = "GUARDAR";
            dgvCategorias.ClearSelection();

            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione una categoría de la tabla.",
                    "Editar categoría",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            idCategoriaSeleccionada = Convert.ToInt32(
                dgvCategorias.CurrentRow.Cells["ID"].Value
            );

            txtNombre.Text =
                dgvCategorias.CurrentRow.Cells["Nombre"].Value.ToString();

            txtDescripcion.Text =
                dgvCategorias.CurrentRow.Cells["Descripción"].Value.ToString();

            chkEstado.Checked =
                dgvCategorias.CurrentRow.Cells["Estado"].Value.ToString() == "Activo";

            btnGuardar.Text = "ACTUALIZAR";
        }
    }
}
