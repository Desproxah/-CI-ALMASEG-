using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CIAlmaseg.Clases;

namespace CIAlmaseg
{
    public partial class FrmEmpleados : Form
    {
        private int idEmpleadoSeleccionado = 0;

        public FrmEmpleados()
        {
            InitializeComponent();
            Tema.AutoAplicar(this);
            dgvEmpleados.CellClick += dgvEmpleados_CellClick;
            btnNuevo.Click += btnNuevo_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnBuscar.Click += btnBuscar_Click;
            btnMostrarTodos.Click += btnMostrarTodos_Click;
            CargarEmpleados(null);
        }

        /* El CHECK de tbl.empleado exige cargos en mayúsculas con guiones;
           en la interfaz se muestran los nombres en español. */
        private static string CargoDesdeDisplay(string display)
        {
            switch (display)
            {
                case "Administrador": return "ADMINISTRADOR";
                case "Auxiliar de compras": return "AUXILIAR_COMPRAS";
                case "Vendedor": return "VENDEDOR";
                case "Encargado de inventario": return "ENCARGADO_INVENTARIO";
                default: return null;
            }
        }

        private static string DisplayDesdeCargo(string cargo)
        {
            switch (cargo)
            {
                case "ADMINISTRADOR": return "Administrador";
                case "AUXILIAR_COMPRAS": return "Auxiliar de compras";
                case "VENDEDOR": return "Vendedor";
                case "ENCARGADO_INVENTARIO": return "Encargado de inventario";
                default: return cargo;
            }
        }

        private static string TipoDesdeDisplay(string display)
        {
            switch (display)
            {
                case "Cédula de ciudadanía": return "CEDULA";
                case "Cédula de extranjería": return "CEDULA_EXTRANJERIA";
                case "Pasaporte": return "PASAPORTE";
                default: return null;
            }
        }

        private static string DisplayDesdeTipo(string tipo)
        {
            switch (tipo)
            {
                case "CEDULA": return "Cédula de ciudadanía";
                case "CEDULA_EXTRANJERIA": return "Cédula de extranjería";
                case "PASAPORTE": return "Pasaporte";
                default: return tipo;
            }
        }

        private void CargarEmpleados(string textoBusqueda)
        {
            try
            {
                using (SqlConnection conexion = new Conexion().AbrirConexion())
                {
                    string consulta = @"
SELECT
    e.id_empleado AS ID,
    CASE e.tipo_documento
        WHEN 'CEDULA' THEN 'Cédula de ciudadanía'
        WHEN 'CEDULA_EXTRANJERIA' THEN 'Cédula de extranjería'
        ELSE 'Pasaporte'
    END AS [Tipo de documento],
    e.numero_documento AS [Número de documento],
    e.nombre AS Nombre,
    e.telefono AS Teléfono,
    e.correo AS Correo,
    CASE e.cargo
        WHEN 'ADMINISTRADOR' THEN 'Administrador'
        WHEN 'AUXILIAR_COMPRAS' THEN 'Auxiliar de compras'
        WHEN 'VENDEDOR' THEN 'Vendedor'
        ELSE 'Encargado de inventario'
    END AS Cargo,
    CASE e.estado WHEN 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado
FROM tbl.empleado e";

                    if (!string.IsNullOrWhiteSpace(textoBusqueda))
                    {
                        consulta += @"
WHERE e.nombre LIKE @busqueda
   OR e.numero_documento LIKE @busqueda
   OR e.correo LIKE @busqueda";
                    }

                    consulta += " ORDER BY e.nombre;";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);

                    if (!string.IsNullOrWhiteSpace(textoBusqueda))
                    {
                        adaptador.SelectCommand.Parameters.AddWithValue(
                            "@busqueda",
                            "%" + textoBusqueda.Trim() + "%");
                    }

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvEmpleados.DataSource = tabla;
                    dgvEmpleados.ClearSelection();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "No fue posible cargar los empleados:\n\n" + error.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarEmpleados(txtBuscar.Text);
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarEmpleados(null);
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvEmpleados.CurrentRow == null)
            {
                return;
            }

            DataGridViewRow fila = dgvEmpleados.CurrentRow;

            idEmpleadoSeleccionado = Convert.ToInt32(fila.Cells["ID"].Value);
            cmbTipoDocumento.Text = fila.Cells["Tipo de documento"].Value.ToString();
            txtNumeroDocumento.Text = fila.Cells["Número de documento"].Value.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtTelefono.Text = fila.Cells["Teléfono"].Value == null
                ? string.Empty
                : fila.Cells["Teléfono"].Value.ToString();
            txtCorreo.Text = fila.Cells["Correo"].Value == null
                ? string.Empty
                : fila.Cells["Correo"].Value.ToString();
            cmbCargo.Text = fila.Cells["Cargo"].Value.ToString();
            chkEstado.Checked = fila.Cells["Estado"].Value.ToString() == "Activo";

            btnGuardar.Text = "Actualizar";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            idEmpleadoSeleccionado = 0;

            cmbTipoDocumento.SelectedIndex = -1;
            txtNumeroDocumento.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            cmbCargo.SelectedIndex = -1;
            chkEstado.Checked = true;

            btnGuardar.Text = "Guardar";
            dgvEmpleados.ClearSelection();

            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Escriba el nombre completo del empleado.");
                txtNombre.Focus();
                return;
            }

            string codigoTipo = TipoDesdeDisplay(cmbTipoDocumento.Text);

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

            string codigoCargo = CargoDesdeDisplay(cmbCargo.Text);

            if (codigoCargo == null)
            {
                MessageBox.Show("Seleccione el cargo.");
                cmbCargo.Focus();
                return;
            }

            string correo = txtCorreo.Text.Trim();

            if (correo.Length > 0 && !correo.Contains("@"))
            {
                MessageBox.Show("Escriba un correo electrónico válido o deje el campo vacío.");
                txtCorreo.Focus();
                return;
            }

            try
            {
                using (SqlConnection conexion = new Conexion().AbrirConexion())
                {
                    string consulta;

                    if (idEmpleadoSeleccionado == 0)
                    {
                        consulta = @"
INSERT INTO tbl.empleado
    (id_usuario, tipo_documento, numero_documento, nombre, telefono, correo, cargo, estado)
VALUES
    (NULL, @tipo, @documento, @nombre, @telefono, @correo, @cargo, @estado);";
                    }
                    else
                    {
                        consulta = @"
UPDATE tbl.empleado
SET tipo_documento = @tipo,
    numero_documento = @documento,
    nombre = @nombre,
    telefono = @telefono,
    correo = @correo,
    cargo = @cargo,
    estado = @estado
WHERE id_empleado = @idEmpleado;";
                    }

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@tipo", codigoTipo);
                    comando.Parameters.AddWithValue("@documento", txtNumeroDocumento.Text.Trim());
                    comando.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                    comando.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
                    comando.Parameters.AddWithValue(
                        "@correo",
                        correo.Length == 0 ? (object)DBNull.Value : correo);
                    comando.Parameters.AddWithValue("@cargo", codigoCargo);
                    comando.Parameters.AddWithValue("@estado", chkEstado.Checked);

                    if (idEmpleadoSeleccionado != 0)
                    {
                        comando.Parameters.AddWithValue("@idEmpleado", idEmpleadoSeleccionado);
                    }

                    comando.ExecuteNonQuery();
                }

                MessageBox.Show(
                    idEmpleadoSeleccionado == 0
                        ? "Empleado guardado correctamente."
                        : "Empleado actualizado correctamente.");

                LimpiarFormulario();
                CargarEmpleados(null);
            }
            catch (SqlException error)
            {
                if (error.Number == 2601 || error.Number == 2627)
                {
                    MessageBox.Show(
                        "Ya existe un empleado con ese número de documento o correo.");
                }
                else if (error.Number == 547)
                {
                    MessageBox.Show(
                        "No fue posible guardar: el empleado está vinculado a un usuario o a registros relacionados.");
                }
                else
                {
                    MessageBox.Show(
                        "No fue posible guardar el empleado:\n\n" + error.Message,
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
