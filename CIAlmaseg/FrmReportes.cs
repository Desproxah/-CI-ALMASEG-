using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CIAlmaseg.Clases;

namespace CIAlmaseg
{
    public partial class FrmReportes : Form
    {
        private static readonly string[] Meses =
        {
            "Ene", "Feb", "Mar", "Abr", "May", "Jun",
            "Jul", "Ago", "Sep", "Oct", "Nov", "Dic"
        };

        public FrmReportes()
        {
            InitializeComponent();
            Tema.AutoAplicar(this);

            btnConsultar.Click += btnConsultar_Click;

            ConfigurarGrafico(chtVentasMes);
            ConfigurarGrafico(chtVentasEmpleado);

            dtpFechaInicio.Value = new DateTime(DateTime.Today.Year, 1, 1);
            dtpFechaFin.Value = DateTime.Today;

            CargarEmpleados();
            Consultar();
        }

        private void ConfigurarGrafico(Chart grafico)
        {
            grafico.BackColor = Color.White;
            grafico.BorderlineColor = Tema.Borde;
            grafico.BorderlineDashStyle = ChartDashStyle.Solid;
            grafico.Palette = ChartColorPalette.None;

            ChartArea area = grafico.ChartAreas[0];
            area.BackColor = Color.White;
            area.AxisX.LabelStyle.Font = Tema.Fuente(8.5F);
            area.AxisY.LabelStyle.Font = Tema.Fuente(8.5F);
            area.AxisX.MajorGrid.LineColor = Color.Transparent;
            area.AxisY.MajorGrid.LineColor = Tema.Borde;
            area.AxisX.LineColor = Tema.Borde;
            area.AxisY.LineColor = Tema.Borde;
            area.AxisX.Interval = 1;

            Series serie = grafico.Series[0];
            serie.ChartType = SeriesChartType.Column;
            serie.Color = Tema.Azul;
            serie.IsValueShownAsLabel = true;
            serie["PointWidth"] = "0.65";
            serie.Font = Tema.Fuente(8.5F);
            serie.LabelFormat = "N0";
        }

        private void CargarEmpleados()
        {
            try
            {
                using (SqlConnection conexion = new Conexion().AbrirConexion())
                {
                    string consulta = @"
SELECT id_empleado, nombre
FROM tbl.empleado
WHERE estado = 1
ORDER BY nombre;";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    DataRow todos = tabla.NewRow();
                    todos["id_empleado"] = 0;
                    todos["nombre"] = "Todos los empleados";
                    tabla.Rows.InsertAt(todos, 0);

                    cmbEmpleado.DataSource = tabla;
                    cmbEmpleado.DisplayMember = "nombre";
                    cmbEmpleado.ValueMember = "id_empleado";
                    cmbEmpleado.SelectedIndex = 0;
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Consultar()
        {
            if (dtpFechaFin.Value.Date < dtpFechaInicio.Value.Date)
            {
                MessageBox.Show("La fecha final debe ser mayor o igual a la inicial.");
                return;
            }

            DateTime inicio = dtpFechaInicio.Value.Date;
            DateTime fin = dtpFechaFin.Value.Date;
            int idEmpleado = cmbEmpleado.SelectedValue == null
                ? 0
                : Convert.ToInt32(cmbEmpleado.SelectedValue);

            try
            {
                using (SqlConnection conexion = new Conexion().AbrirConexion())
                {
                    ConsultarResumen(conexion, inicio, fin, idEmpleado);
                    ConsultarVentasPorMes(conexion, inicio, fin, idEmpleado);
                    ConsultarVentasPorEmpleado(conexion, inicio, fin, idEmpleado);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "No fue posible consultar los reportes:\n\n" + error.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConsultarResumen(SqlConnection conexion, DateTime inicio,
            DateTime fin, int idEmpleado)
        {
            string filtroEmpleado = idEmpleado > 0
                ? " AND v.id_empleado = @empleado"
                : string.Empty;

            string consulta = @"
SELECT ISNULL(SUM(v.total), 0) AS total,
       COUNT(v.id_venta) AS cantidad
FROM tbl.venta v
WHERE v.estado = 'COMPLETADA'
  AND v.fecha >= @inicio
  AND v.fecha < DATEADD(DAY, 1, @fin)" + filtroEmpleado + ";";

            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@inicio", inicio);
            comando.Parameters.AddWithValue("@fin", fin);

            if (idEmpleado > 0)
            {
                comando.Parameters.AddWithValue("@empleado", idEmpleado);
            }

            using (SqlDataReader lector = comando.ExecuteReader())
            {
                if (lector.Read())
                {
                    lblTotalVendido.Text = Tema.FormatearMoneda(
                        Convert.ToDecimal(lector["total"]));
                    lblCantidadVentas.Text = Convert.ToInt32(lector["cantidad"])
                        .ToString("N0");
                }
            }

            string consultaMejor = @"
SELECT TOP (1)
       e.nombre,
       SUM(v.total) AS total
FROM tbl.venta v
INNER JOIN tbl.empleado e ON e.id_empleado = v.id_empleado
WHERE v.estado = 'COMPLETADA'
  AND v.fecha >= @inicio
  AND v.fecha < DATEADD(DAY, 1, @fin)" + filtroEmpleado + @"
GROUP BY e.nombre
ORDER BY SUM(v.total) DESC;";

            SqlCommand comandoMejor = new SqlCommand(consultaMejor, conexion);
            comandoMejor.Parameters.AddWithValue("@inicio", inicio);
            comandoMejor.Parameters.AddWithValue("@fin", fin);

            if (idEmpleado > 0)
            {
                comandoMejor.Parameters.AddWithValue("@empleado", idEmpleado);
            }

            object mejor = comandoMejor.ExecuteScalar();

            lblMejorEmpleado.Text = mejor == null || mejor == DBNull.Value
                ? "Sin ventas en el período"
                : mejor.ToString();
        }

        private void ConsultarVentasPorMes(SqlConnection conexion, DateTime inicio,
            DateTime fin, int idEmpleado)
        {
            string filtroEmpleado = idEmpleado > 0
                ? " AND v.id_empleado = @empleado"
                : string.Empty;

            string consulta = @"
SELECT YEAR(v.fecha) AS anio,
       MONTH(v.fecha) AS numero_mes,
       SUM(v.total) AS total
FROM tbl.venta v
WHERE v.estado = 'COMPLETADA'
  AND v.fecha >= @inicio
  AND v.fecha < DATEADD(DAY, 1, @fin)" + filtroEmpleado + @"
GROUP BY YEAR(v.fecha), MONTH(v.fecha)
ORDER BY YEAR(v.fecha), MONTH(v.fecha);";

            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@inicio", inicio);
            comando.Parameters.AddWithValue("@fin", fin);

            if (idEmpleado > 0)
            {
                comando.Parameters.AddWithValue("@empleado", idEmpleado);
            }

            Series serie = chtVentasMes.Series[0];
            serie.Points.Clear();

            using (SqlDataReader lector = comando.ExecuteReader())
            {
                while (lector.Read())
                {
                    int anio = Convert.ToInt32(lector["anio"]);
                    int numeroMes = Convert.ToInt32(lector["numero_mes"]);
                    decimal total = Convert.ToDecimal(lector["total"]);

                    string etiqueta = Meses[numeroMes - 1];

                    if (inicio.Year != fin.Year || anio != inicio.Year)
                    {
                        etiqueta += " " + anio.ToString().Substring(2);
                    }

                    serie.Points.AddXY(etiqueta, total);
                }
            }
        }

        private void ConsultarVentasPorEmpleado(SqlConnection conexion, DateTime inicio,
            DateTime fin, int idEmpleado)
        {
            string filtroEmpleado = idEmpleado > 0
                ? " AND v.id_empleado = @empleado"
                : string.Empty;

            string consulta = @"
SELECT TOP (10)
       e.nombre,
       SUM(v.total) AS total
FROM tbl.venta v
INNER JOIN tbl.empleado e ON e.id_empleado = v.id_empleado
WHERE v.estado = 'COMPLETADA'
  AND v.fecha >= @inicio
  AND v.fecha < DATEADD(DAY, 1, @fin)" + filtroEmpleado + @"
GROUP BY e.nombre
ORDER BY SUM(v.total) DESC;";

            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@inicio", inicio);
            comando.Parameters.AddWithValue("@fin", fin);

            if (idEmpleado > 0)
            {
                comando.Parameters.AddWithValue("@empleado", idEmpleado);
            }

            Series serie = chtVentasEmpleado.Series[0];
            serie.Points.Clear();

            using (SqlDataReader lector = comando.ExecuteReader())
            {
                while (lector.Read())
                {
                    string nombre = lector["nombre"].ToString();
                    decimal total = Convert.ToDecimal(lector["total"]);

                    DataPoint punto = new DataPoint();
                    punto.SetValueXY(nombre, total);
                    punto.Color = Tema.Marino;
                    serie.Points.Add(punto);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
