namespace CIAlmaseg.Clases
{
    public static class SesionActual
    {
        public static int IdUsuario { get; private set; }
        public static string Nombre { get; private set; }
        public static string Correo { get; private set; }
        public static string Rol { get; private set; }

        public static bool EstaAutenticado
        {
            get { return IdUsuario > 0; }
        }

        public static bool EsAdministrador
        {
            get { return string.Equals(Rol, "ADMINISTRADOR", System.StringComparison.OrdinalIgnoreCase); }
        }

        public static void Iniciar(int idUsuario, string nombre, string correo, string rol)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Correo = correo;
            Rol = rol;
        }

        public static void Cerrar()
        {
            IdUsuario = 0;
            Nombre = null;
            Correo = null;
            Rol = null;
        }

        public static string Iniciales()
        {
            return Tema.Iniciales(Nombre);
        }
    }
}
