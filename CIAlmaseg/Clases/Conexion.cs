using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CIAlmaseg.Clases
{
    public class Conexion
    {
        public const string NombreCadena = "ConexionCIAlmaseg";
        public const string VariableEntorno = "CIALMASEG_CONNECTION_STRING";

        private readonly string cadenaConexion;

        public Conexion()
        {
            cadenaConexion = ObtenerCadenaConexion();
        }

        public string CadenaConexion
        {
            get { return cadenaConexion; }
        }

        public static string ObtenerCadenaConexion()
        {
            string desdeEntorno = Environment.GetEnvironmentVariable(VariableEntorno);

            if (!string.IsNullOrWhiteSpace(desdeEntorno))
            {
                return desdeEntorno;
            }

            ConnectionStringSettings configuracion =
                ConfigurationManager.ConnectionStrings[NombreCadena];

            if (configuracion == null || string.IsNullOrWhiteSpace(configuracion.ConnectionString))
            {
                throw new ConfigurationErrorsException(
                    "No se encontró la cadena de conexión '" + NombreCadena + "' en App.config.");
            }

            return configuracion.ConnectionString;
        }

        public SqlConnection AbrirConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

        public static bool ProbarConexion(out string mensaje)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ObtenerCadenaConexion()))
                {
                    conexion.Open();
                }

                mensaje = "Conexión establecida correctamente.";
                return true;
            }
            catch (SqlException error)
            {
                if (error.Number == 4060 || error.Number == 911)
                {
                    mensaje = "La base de datos no existe. Ejecuta scripts\\init-db.ps1 para crearla.";
                }
                else if (error.Number == 50 ||
                         error.Message.IndexOf("LocalDB", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    mensaje = "La instancia LocalDB no está disponible. Ejecuta scripts\\init-db.ps1.";
                }
                else
                {
                    mensaje = error.Message;
                }

                return false;
            }
            catch (Exception error)
            {
                mensaje = error.Message;
                return false;
            }
        }

        public static bool ProbarConexion()
        {
            string mensaje;
            return ProbarConexion(out mensaje);
        }
    }
}
