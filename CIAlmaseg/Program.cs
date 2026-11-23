using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CIAlmaseg
{
    internal static class Program
    {
        [STAThread]
        static void Main()
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

            Application.Run(new FrmLogin());
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
