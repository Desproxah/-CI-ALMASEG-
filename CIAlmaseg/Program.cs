using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CIAlmaseg.Clases;

namespace CIAlmaseg
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            CultureInfo cultura = new CultureInfo("es-CO");
            Thread.CurrentThread.CurrentCulture = cultura;
            Thread.CurrentThread.CurrentUICulture = cultura;
            CultureInfo.DefaultThreadCurrentCulture = cultura;
            CultureInfo.DefaultThreadCurrentUICulture = cultura;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += delegate(object sender, ThreadExceptionEventArgs e)
            {
                RegistrarError(e.Exception);
            };
            AppDomain.CurrentDomain.UnhandledException += delegate(object sender, UnhandledExceptionEventArgs e)
            {
                RegistrarError(e.ExceptionObject as Exception);
            };

            /* Modo de prueba: CIAlmaseg.exe --form ventas
               Abre un módulo directamente con la sesión del administrador
               demo, sin pasar por el login. Sirve para revisar y capturar
               cada pantalla. */
            if (args != null && args.Length >= 2 &&
                string.Equals(args[0], "--form", StringComparison.OrdinalIgnoreCase))
            {
                // La sesión debe estar iniciada ANTES de crear el
                // formulario: los constructores leen SesionActual.
                if (!ExisteFormularioPrueba(args[1]))
                {
                    MessageBox.Show(
                        "Formulario de prueba no reconocido: " + args[1],
                        "CI Almaseg",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                SesionActual.Iniciar(
                    1,
                    "Administrador CI Almaseg",
                    "admin@cialmaseg.com",
                    "ADMINISTRADOR");

                Application.Run(CrearFormularioPrueba(args[1]));
                return;
            }

            Application.Run(new FrmLogin());
        }

        private static bool ExisteFormularioPrueba(string nombre)
        {
            switch (nombre.ToLowerInvariant())
            {
                case "ventas":
                case "compras":
                case "productos":
                case "categorias":
                case "clientes":
                case "proveedores":
                case "empleados":
                case "reportes":
                case "catalogo":
                case "login":
                    return true;
                default:
                    return false;
            }
        }

        private static Form CrearFormularioPrueba(string nombre)
        {
            switch (nombre.ToLowerInvariant())
            {
                case "ventas": return new FrmVentas();
                case "compras": return new FrmCompras();
                case "productos": return new FrmProductos();
                case "categorias": return new FrmCategorias();
                case "clientes": return new FrmGestionClientes();
                case "proveedores": return new FrmProveedores();
                case "empleados": return new FrmEmpleados();
                case "reportes": return new FrmReportes();
                case "catalogo": return new FrmListadoProductos();
                case "login": return new FrmLogin();
                default: return null;
            }
        }

        private static void RegistrarError(Exception error)
        {
            if (error == null)
            {
                return;
            }

            string rutaLog = null;

            try
            {
                string carpeta = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "CIAlmaseg",
                    "logs");

                Directory.CreateDirectory(carpeta);

                rutaLog = Path.Combine(carpeta, "error.log");

                StringBuilder mensaje = new StringBuilder();
                mensaje.AppendLine("============================================================");
                mensaje.AppendLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                mensaje.AppendLine(error.ToString());
                mensaje.AppendLine();

                File.AppendAllText(rutaLog, mensaje.ToString(), Encoding.UTF8);
            }
            catch
            {
                // Si no es posible escribir el registro, no se interrumpe la aplicación.
            }

            string detalle = rutaLog == null
                ? "No fue posible guardar el detalle del error."
                : "Se guardó el detalle en:\n" + rutaLog;

            MessageBox.Show(
                "Ocurrió un error inesperado en la aplicación.\n\n" + detalle,
                "CI Almaseg",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
