using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using CIAlmaseg.Clases;

namespace CIAlmaseg
{
    public partial class FrmLogin : Form
    {
        private bool modoCliente;
        private bool navegando;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Tema.AplicarFormulario(this);
            Tema.Tarjeta(pnlTarjeta);
            Tema.Redondear(pnlRoles, 12);
            Tema.Redondear(pnlMonograma, 10);

            Tema.EstilizarEntrada(txtCorreo);
            Tema.EstilizarEntrada(txtClave);
            Tema.Placeholder(txtCorreo, "admin@cialmaseg.com");
            Tema.Placeholder(txtClave, "Escribe tu contraseña");

            Tema.EstilizarBoton(btnIngresar, TipoBoton.Primario);
            Tema.EstilizarBoton(btnVerCatalogo, TipoBoton.Primario);
            Tema.EstilizarBoton(btnVerClave, TipoBoton.Fantasma);
            btnVerClave.Left = 324;
            btnVerClave.Width = 56;
            btnVerClave.Height = 25;
            txtClave.Width = 320;

            Tema.Titulo(lblBienvenida);
            Tema.Subtitulo(lblAccesoDescripcion);
            Tema.TituloSeccion(lblClienteTitulo);
            Tema.Subtitulo(lblClienteDescripcion);
            Tema.Subtitulo(lblPie);
            lblPie.ForeColor = Color.FromArgb(148, 163, 184);

            lblMarca.ForeColor = Color.White;
            lblMarcaSub.ForeColor = Color.FromArgb(148, 163, 184);
            lblHero.ForeColor = Color.White;
            lblHeroDescripcion.ForeColor = Color.FromArgb(203, 213, 225);
            lblMarcaPie.ForeColor = Color.FromArgb(148, 163, 184);
            lblMonograma.ForeColor = Tema.Marino;
            lblTextoInventario.ForeColor = Color.White;
            lblTextoVentas.ForeColor = Color.White;
            lblTextoReportes.ForeColor = Color.White;

            Tema.Icono(lblIconoInventario, "\uE7B8", 14F, Tema.Ambar);
            Tema.Icono(lblIconoVentas, "\uE7BF", 14F, Tema.Ambar);
            Tema.Icono(lblIconoReportes, "\uE9D9", 14F, Tema.Ambar);

            ActualizarModo(false);
            CentrarTarjeta();
            txtCorreo.Focus();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!navegando)
            {
                Application.Exit();
            }
        }

        private void pnlAcceso_Resize(object sender, EventArgs e)
        {
            CentrarTarjeta();
        }

        private void CentrarTarjeta()
        {
            int x = Math.Max(20, (pnlAcceso.ClientSize.Width - pnlTarjeta.Width) / 2);
            int y = Math.Max(20, (pnlAcceso.ClientSize.Height - pnlTarjeta.Height) / 2);
            pnlTarjeta.Location = new Point(x, y);
        }

        private void pnlMarca_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush fondo = new LinearGradientBrush(
                pnlMarca.ClientRectangle,
                Tema.Marino,
                Tema.MarinoClaro,
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(fondo, pnlMarca.ClientRectangle);
            }

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (SolidBrush halo = new SolidBrush(Color.FromArgb(18, 255, 255, 255)))
            {
                e.Graphics.FillEllipse(halo, pnlMarca.Width - 210, -90, 330, 330);
                e.Graphics.FillEllipse(halo, -120, pnlMarca.Height - 200, 280, 280);
            }

            using (Pen linea = new Pen(Color.FromArgb(28, 255, 255, 255), 1F))
            {
                for (int i = 0; i < 7; i++)
                {
                    int desplazamiento = i * 54;
                    e.Graphics.DrawLine(
                        linea,
                        0,
                        pnlMarca.Height - 120 + desplazamiento,
                        pnlMarca.Width,
                        pnlMarca.Height - 320 + desplazamiento);
                }
            }
        }

        private void btnRolAdministrador_Click(object sender, EventArgs e)
        {
            ActualizarModo(false);
            txtCorreo.Focus();
        }

        private void btnRolCliente_Click(object sender, EventArgs e)
        {
            ActualizarModo(true);
        }

        private void ActualizarModo(bool cliente)
        {
            modoCliente = cliente;

            pnlCredenciales.Visible = !cliente;
            pnlCliente.Visible = cliente;

            btnRolAdministrador.BackColor = cliente ? Color.Transparent : Color.White;
            btnRolAdministrador.ForeColor = cliente ? Tema.TextoSuave : Tema.Marino;
            btnRolAdministrador.Font = Tema.Fuente(9F, cliente ? FontStyle.Regular : FontStyle.Bold);

            btnRolCliente.BackColor = cliente ? Color.White : Color.Transparent;
            btnRolCliente.ForeColor = cliente ? Tema.Marino : Tema.TextoSuave;
            btnRolCliente.Font = Tema.Fuente(9F, cliente ? FontStyle.Bold : FontStyle.Regular);

            Tema.Redondear(btnRolAdministrador, 8);
            Tema.Redondear(btnRolCliente, 8);
            LimpiarError(null, null);
        }

        private void btnVerClave_Click(object sender, EventArgs e)
        {
            bool visible = !txtClave.UseSystemPasswordChar;
            txtClave.UseSystemPasswordChar = visible;
            btnVerClave.Text = visible ? "Ver" : "Ocultar";
        }

        private void LimpiarError(object sender, EventArgs e)
        {
            lblError.Visible = false;
            lblError.Text = string.Empty;
        }

        private void MostrarError(string mensaje)
        {
            lblError.Text = mensaje;
            lblError.Visible = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (modoCliente)
            {
                AbrirCatalogo();
                return;
            }

            string correo = txtCorreo.Text.Trim();
            string clave = txtClave.Text;

            if (string.IsNullOrWhiteSpace(correo) || !correo.Contains("@"))
            {
                MostrarError("Ingresa un correo electrónico válido.");
                txtCorreo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(clave))
            {
                MostrarError("Ingresa tu contraseña.");
                txtClave.Focus();
                return;
            }

            btnIngresar.Enabled = false;
            UseWaitCursor = true;
            LimpiarError(null, null);

            try
            {
                const string consulta = @"
SELECT u.id_usuario,
       u.nombre,
       u.correo,
       r.nombre AS rol
FROM tbl.usuario AS u
INNER JOIN tbl.rol AS r ON r.id_rol = u.id_rol
WHERE u.correo = @correo
  AND u.clave_hash = LOWER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', @clave), 2))
  AND u.estado = 1;";

                using (SqlConnection conexion = new Conexion().AbrirConexion())
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.Add("@correo", SqlDbType.VarChar, 120).Value = correo;
                    comando.Parameters.Add("@clave", SqlDbType.NVarChar, 255).Value = clave;

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (!lector.Read())
                        {
                            MostrarError("El correo o la contraseña no son correctos.");
                            txtClave.SelectAll();
                            txtClave.Focus();
                            return;
                        }

                        int idUsuario = Convert.ToInt32(lector["id_usuario"]);
                        string nombre = lector["nombre"].ToString();
                        string correoUsuario = lector["correo"].ToString();
                        string rol = lector["rol"].ToString();

                        if (!string.Equals(rol, "ADMINISTRADOR", StringComparison.OrdinalIgnoreCase))
                        {
                            MostrarError("Tu rol no tiene acceso al panel administrativo. Puedes consultar el catálogo.");
                            return;
                        }

                        SesionActual.Iniciar(idUsuario, nombre, correoUsuario, rol);
                        AbrirPanelAdministrativo();
                    }
                }
            }
            catch (SqlException)
            {
                MostrarError("No fue posible conectar con la base de datos. Ejecuta scripts\\init-db.ps1 y vuelve a intentar.");
            }
            catch (Exception error)
            {
                MostrarError("Ocurrió un error al iniciar sesión: " + error.Message);
            }
            finally
            {
                UseWaitCursor = false;
                btnIngresar.Enabled = true;
            }
        }

        private void AbrirPanelAdministrativo()
        {
            FrmMenuAdministrador menu = new FrmMenuAdministrador();
            menu.FormClosed += Menu_FormClosed;

            navegando = true;
            Hide();
            menu.Show();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenuAdministrador menu = sender as FrmMenuAdministrador;

            if (menu != null && menu.CerrandoSesion)
            {
                SesionActual.Cerrar();
                navegando = false;
                txtClave.Clear();
                btnIngresar.Enabled = true;
                Show();
                Activate();
                txtCorreo.Focus();
                return;
            }

            navegando = false;
            Close();
        }

        private void btnVerCatalogo_Click(object sender, EventArgs e)
        {
            AbrirCatalogo();
        }

        private void AbrirCatalogo()
        {
            FrmListadoProductos catalogo = new FrmListadoProductos();
            catalogo.FormClosed += delegate
            {
                if (!IsDisposed)
                {
                    navegando = false;
                    Show();
                    Activate();
                }
            };

            navegando = true;
            Hide();
            catalogo.Show();
        }
    }
}
