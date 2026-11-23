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
    public partial class FrmProveedores : Form
    {
        private int idProveedorSeleccionado = 0;
        public FrmProveedores()
        {
            InitializeComponent();
            Tema.AutoAplicar(this);
            CargarProveedores();
        }
        private void CargarProveedores()
        {
            try
            {
                Conexion conexionBD = new Conexion();

                using (SqlConnection conexion = conexionBD.AbrirConexion())
                {
                    string consulta = @"
                SELECT
                    id_proveedor AS ID,
                    nit AS NIT,
                    razon_social AS [Razón social],
                    telefono AS Teléfono,
                    correo AS Correo,
                    ciudad AS Ciudad,
                    direccion AS Dirección,
                    CASE
                        WHEN estado = 1 THEN 'Activo'
                        ELSE 'Inactivo'
                    END AS Estado
                FROM tbl.proveedor
                ORDER BY razon_social;";

                    SqlDataAdapter adaptador =
                        new SqlDataAdapter(consulta, conexion);

                    DataTable tablaProveedores = new DataTable();
                    adaptador.Fill(tablaProveedores);

                    dgvProveedores.DataSource = tablaProveedores;
                    dgvProveedores.ClearSelection();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "No fue posible cargar los proveedores:\n\n" +
                    error.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
       "¿Desea cerrar la gestión de proveedores?",
       "Cerrar formulario",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void LimpiarFormulario()
        {
            idProveedorSeleccionado = 0;

            txtNit.Clear();
            txtRazonSocial.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtCiudad.Clear();

            chkEstado.Checked = true;
            btnGuardar.Text = "GUARDAR";

            dgvProveedores.ClearSelection();
            txtNit.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNit.Text) ||
        string.IsNullOrWhiteSpace(txtRazonSocial.Text))
            {
                MessageBox.Show(
                    "Complete el NIT y la razón social.",
                    "Campos obligatorios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                Conexion conexionBD = new Conexion();

                using (SqlConnection conexion = conexionBD.AbrirConexion())
                {
                    string consulta;

                    if (idProveedorSeleccionado == 0)
                    {
                        consulta = @"
                    INSERT INTO tbl.proveedor
                    (
                        nit,
                        razon_social,
                        telefono,
                        correo,
                        direccion,
                        ciudad,
                        estado
                    )
                    VALUES
                    (
                        @nit,
                        @razonSocial,
                        @telefono,
                        @correo,
                        @direccion,
                        @ciudad,
                        @estado
                    );";
                    }
                    else
                    {
                        consulta = @"
                    UPDATE tbl.proveedor
                    SET
                        nit = @nit,
                        razon_social = @razonSocial,
                        telefono = @telefono,
                        correo = @correo,
                        direccion = @direccion,
                        ciudad = @ciudad,
                        estado = @estado
                    WHERE id_proveedor = @idProveedor;";
                    }

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@nit",
                            txtNit.Text.Trim()
                        );

                        comando.Parameters.AddWithValue(
                            "@razonSocial",
                            txtRazonSocial.Text.Trim()
                        );

                        comando.Parameters.AddWithValue(
                            "@telefono",
                            txtTelefono.Text.Trim()
                        );

                        comando.Parameters.AddWithValue(
                            "@correo",
                            txtCorreo.Text.Trim()
                        );

                        comando.Parameters.AddWithValue(
                            "@direccion",
                            txtDireccion.Text.Trim()
                        );

                        comando.Parameters.AddWithValue(
                            "@ciudad",
                            txtCiudad.Text.Trim()
                        );

                        comando.Parameters.AddWithValue(
                            "@estado",
                            chkEstado.Checked
                        );

                        if (idProveedorSeleccionado != 0)
                        {
                            comando.Parameters.AddWithValue(
                                "@idProveedor",
                                idProveedorSeleccionado
                            );
                        }

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    idProveedorSeleccionado == 0
                        ? "Proveedor guardado correctamente."
                        : "Proveedor actualizado correctamente.",
                    "CI Almaseg",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LimpiarFormulario();
                CargarProveedores();
            }
            catch (SqlException error)
            {
                if (error.Number == 2601 || error.Number == 2627)
                {
                    MessageBox.Show(
                        "Ya existe otro proveedor con ese NIT.",
                        "Proveedor duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "No fue posible guardar el proveedor:\n\n" +
                        error.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un proveedor de la tabla.",
                    "Editar proveedor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            idProveedorSeleccionado = Convert.ToInt32(
                dgvProveedores.CurrentRow.Cells["ID"].Value
            );

            txtNit.Text =
                dgvProveedores.CurrentRow.Cells["NIT"].Value?.ToString();

            txtRazonSocial.Text =
                dgvProveedores.CurrentRow.Cells["Razón social"].Value?.ToString();

            txtTelefono.Text =
                dgvProveedores.CurrentRow.Cells["Teléfono"].Value?.ToString();

            txtCorreo.Text =
                dgvProveedores.CurrentRow.Cells["Correo"].Value?.ToString();

            txtCiudad.Text =
                dgvProveedores.CurrentRow.Cells["Ciudad"].Value?.ToString();

            txtDireccion.Text =
                dgvProveedores.CurrentRow.Cells["Dirección"].Value?.ToString();

            chkEstado.Checked =
                dgvProveedores.CurrentRow.Cells["Estado"].Value?.ToString()
                == "Activo";

            btnGuardar.Text = "ACTUALIZAR";
            txtNit.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBuscar = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(textoBuscar))
            {
                CargarProveedores();
                return;
            }

            try
            {
                Conexion conexionBD = new Conexion();

                using (SqlConnection conexion = conexionBD.AbrirConexion())
                {
                    string consulta = @"
                SELECT
                    id_proveedor AS ID,
                    nit AS NIT,
                    razon_social AS [Razón social],
                    telefono AS Teléfono,
                    correo AS Correo,
                    ciudad AS Ciudad,
                    direccion AS Dirección,
                    CASE
                        WHEN estado = 1 THEN 'Activo'
                        ELSE 'Inactivo'
                    END AS Estado
                FROM tbl.proveedor
                WHERE nit LIKE @buscar
                   OR razon_social LIKE @buscar
                ORDER BY razon_social;";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@buscar",
                            "%" + textoBuscar + "%"
                        );

                        SqlDataAdapter adaptador =
                            new SqlDataAdapter(comando);

                        DataTable tablaProveedores = new DataTable();
                        adaptador.Fill(tablaProveedores);

                        dgvProveedores.DataSource = tablaProveedores;
                        dgvProveedores.ClearSelection();

                        if (tablaProveedores.Rows.Count == 0)
                        {
                            MessageBox.Show(
                                "No se encontraron proveedores.",
                                "Buscar proveedor",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "No fue posible buscar proveedores:\n\n" + error.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
