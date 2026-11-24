using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CIAlmaseg.Clases;

namespace CIAlmaseg
{
    public partial class FrmGestionClientes : Form
    {
        private int idClienteSeleccionado = 0;

        public FrmGestionClientes()
        {
            InitializeComponent();
            Tema.AutoAplicar(this);
            dgvClientes.CellClick += dgvClientes_CellClick;
            btnNuevo.Click += btnNuevo_Click;
            btnGuardar.Click += btnGuardar_Click;
            CargarClientes();
        }

        /* El CHECK de tbl.cliente exige estos códigos; en la interfaz se
           muestran los nombres en español. */
        private static string CodigoDesdeDisplay(string display)
        {
            switch (display)
            {
                case "Cédula de ciudadanía": return "CEDULA";
                case "Cédula de extranjería": return "CEDULA_EXTRANJERIA";
                case "NIT": return "NIT";
                case "Pasaporte": return "PASAPORTE";
                default: return null;
            }
        }

        private static string DisplayDesdeCodigo(string codigo)
        {
            switch (codigo)
            {
                case "CEDULA": return "Cédula de ciudadanía";
                case "CEDULA_EXTRANJERIA": return "Cédula de extranjería";
                case "NIT": return "NIT";
                case "PASAPORTE": return "Pasaporte";
                default: return codigo;
            }
        }

        private void CargarClientes()
        {
            try
            {
                using (SqlConnection conexion = new Conexion().AbrirConexion())
                {
                    string consulta = @"
SELECT
    c.id_cliente AS ID,
    CASE c.tipo_documento
        WHEN 'CEDULA' THEN 'Cédula de ciudadanía'
        WHEN 'CEDULA_EXTRANJERIA' THEN 'Cédula de extranjería'
        WHEN 'NIT' THEN 'NIT'
        ELSE 'Pasaporte'
    END AS [Tipo de documento],
    c.numero_documento AS [Número de documento],
    c.nombre AS Nombre,
    c.telefono AS Teléfono,
    c.ciudad AS Ciudad,
    c.direccion AS Dirección,
    CASE c.estado WHEN 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado
FROM tbl.cliente c
ORDER BY c.nombre;";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvClientes.DataSource = tabla;
                    dgvClientes.ClearSelection();
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

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvClientes.CurrentRow == null)
            {
                return;
            }

            DataGridViewRow fila = dgvClientes.CurrentRow;

            idClienteSeleccionado = Convert.ToInt32(fila.Cells["ID"].Value);
            cmbTipoDocumento.Text = fila.Cells["Tipo de documento"].Value.ToString();
            txtNumeroDocumento.Text = fila.Cells["Número de documento"].Value.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtTelefono.Text = fila.Cells["Teléfono"].Value == null
                ? string.Empty
                : fila.Cells["Teléfono"].Value.ToString();
            txtCiudad.Text = fila.Cells["Ciudad"].Value == null
                ? string.Empty
                : fila.Cells["Ciudad"].Value.ToString();
            txtDireccion.Text = fila.Cells["Dirección"].Value == null
                ? string.Empty
                : fila.Cells["Dirección"].Value.ToString();
            chkEstado.Checked = fila.Cells["Estado"].Value.ToString() == "Activo";

            btnGuardar.Text = "Actualizar";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            idClienteSeleccionado = 0;

            cmbTipoDocumento.SelectedIndex = -1;
            txtNumeroDocumento.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCiudad.Clear();
            txtDireccion.Clear();
            chkEstado.Checked = true;

            btnGuardar.Text = "Guardar";
            dgvClientes.ClearSelection();

            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Escriba el nombre completo del cliente.");
                txtNombre.Focus();
                return;
            }

            string codigoTipo = CodigoDesdeDisplay(cmbTipoDocumento.Text);

            if (codigoTipo == null)
            {
                MessageBox.Show("Seleccione el tipo de documento.");
                cmbTipoDocumento.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumeroDocumento.Text))
            {
                MessageBox.Show("Escriba el número de documento.");
                txtNumeroDocumento.Focus();
                return;
            }

            try
            {
                using (SqlConnection conexion = new Conexion().AbrirConexion())
                {
                    string consulta;

                    if (idClienteSeleccionado == 0)
                    {
                        consulta = @"
INSERT INTO tbl.cliente
    (tipo_documento, numero_documento, nombre, telefono, direccion, ciudad, estado)
VALUES
    (@tipo, @documento, @nombre, @telefono, @direccion, @ciudad, @estado);";
                    }
                    else
                    {
                        consulta = @"
UPDATE tbl.cliente
SET tipo_documento = @tipo,
    numero_documento = @documento,
    nombre = @nombre,
    telefono = @telefono,
    direccion = @direccion,
    ciudad = @ciudad,
    estado = @estado
WHERE id_cliente = @idCliente;";
                    }

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@tipo", codigoTipo);
                    comando.Parameters.AddWithValue("@documento", txtNumeroDocumento.Text.Trim());
                    comando.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                    comando.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
                    comando.Parameters.AddWithValue("@direccion", txtDireccion.Text.Trim());
                    comando.Parameters.AddWithValue("@ciudad", txtCiudad.Text.Trim());
                    comando.Parameters.AddWithValue("@estado", chkEstado.Checked);

                    if (idClienteSeleccionado != 0)
                    {
                        comando.Parameters.AddWithValue("@idCliente", idClienteSeleccionado);
                    }

                    comando.ExecuteNonQuery();
                }

                MessageBox.Show(
                    idClienteSeleccionado == 0
                        ? "Cliente guardado correctamente."
                        : "Cliente actualizado correctamente.");

                LimpiarFormulario();
                CargarClientes();
            }
            catch (SqlException error)
            {
                if (error.Number == 2601 || error.Number == 2627)
                {
                    MessageBox.Show("Ya existe un cliente con ese número de documento.");
                }
                else
                {
                    MessageBox.Show(
                        "No fue posible guardar el cliente:\n\n" + error.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
