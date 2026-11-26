using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIAlmaseg.Clases;

namespace CIAlmaseg
{
    public partial class FrmMenuAdministrador : Form
    {
        private readonly List<OpcionNav> opciones = new List<OpcionNav>();
        private OpcionNav opcionInicio;
        private Label lblVentas;
        private Label lblProductos;
        private Label lblStockBajo;
        private Label lblClientes;

        public bool CerrandoSesion { get; private set; }

        public FrmMenuAdministrador()
        {
            InitializeComponent();
        }

        private void FrmMenuAdministrador_Load(object sender, EventArgs e)
        {
            Tema.AplicarFormulario(this);
            Tema.Redondear(pnlMonograma, 10);
            Tema.Redondear(pnlAvatar, 22);
            Tema.Redondear(btnCerrarSesion, 8);

            lblMarca.ForeColor = Color.White;
            lblMarcaSub.ForeColor = Color.FromArgb(148, 163, 184);
            lblMonograma.ForeColor = Tema.Marino;
            lblMenu.ForeColor = Color.FromArgb(100, 116, 139);

            Tema.Titulo(lblTituloPagina);
            lblTituloPagina.Font = Tema.Fuente(17F, FontStyle.Bold);
            Tema.Subtitulo(lblSubtituloPagina);
            lblFecha.ForeColor = Tema.Texto;
            lblFecha.Font = Tema.Fuente(9F, FontStyle.Bold);
            lblFecha.Text = PrimeraMayuscula(Tema.FormatearFecha(DateTime.Now));

            lblNombreUsuario.Text = string.IsNullOrWhiteSpace(SesionActual.Nombre)
                ? "Administrador"
                : SesionActual.Nombre;

            lblRolUsuario.Text = string.IsNullOrWhiteSpace(SesionActual.Rol)
                ? "Administrador"
                : PrimeraMayuscula(SesionActual.Rol.Replace("_", " ").ToLowerInvariant());

            lblIniciales.Text = SesionActual.Iniciales();

            btnCerrarSesion.BackColor = Color.Transparent;
            btnCerrarSesion.ForeColor = Color.FromArgb(252, 165, 165);
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 67, 96);
            btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(57, 82, 110);
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.Font = Tema.Fuente(9F);
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Padding = new Padding(12, 0, 0, 0);

            ConstruirNavegacion();
            ConstruirDashboard();
        }

        private async void FrmMenuAdministrador_Shown(object sender, EventArgs e)
        {
            await CargarResumenAsync();
        }

        private void ConstruirNavegacion()
        {
            AgregarOpcion("\uE80F", "Inicio", null, delegate
            {
                pnlContenido.AutoScrollPosition = new Point(0, 0);
            }, true);

            opcionInicio = opciones[0];

            AgregarOpcion("\uE7BF", "Ventas", new Func<Form>(delegate { return new FrmVentas(); }), null);
            AgregarOpcion("\uE719", "Compras", new Func<Form>(delegate { return new FrmCompras(); }), null);
            AgregarOpcion("\uE7B8", "Productos", new Func<Form>(delegate { return new FrmProductos(); }), null);
            AgregarOpcion("\uE8EC", "Categorías", new Func<Form>(delegate { return new FrmCategorias(); }), null);
            AgregarOpcion("\uE77B", "Clientes", new Func<Form>(delegate { return new FrmGestionClientes(); }), null);
            AgregarOpcion("\uE806", "Proveedores", new Func<Form>(delegate { return new FrmProveedores(); }), null);
            AgregarOpcion("\uE716", "Empleados", new Func<Form>(delegate { return new FrmEmpleados(); }), null);
            AgregarOpcion("\uE9D9", "Reportes", new Func<Form>(delegate { return new FrmReportes(); }), null);
        }

        private void AgregarOpcion(string glifo, string texto, Func<Form> fabrica, EventHandler accion, bool activo = false)
        {
            OpcionNav opcion = new OpcionNav();
            opcion.Panel = new Panel();
            opcion.Panel.Width = 220;
            opcion.Panel.Height = 42;
            opcion.Panel.Margin = new Padding(4, 3, 4, 3);
            opcion.Panel.BackColor = Color.Transparent;
            opcion.Panel.Cursor = Cursors.Hand;

            opcion.Indicador = new Panel();
            opcion.Indicador.Dock = DockStyle.Left;
            opcion.Indicador.Width = 3;
            opcion.Indicador.BackColor = Color.Transparent;

            opcion.Icono = new Label();
            opcion.Icono.Location = new Point(14, 0);
            opcion.Icono.Size = new Size(26, 42);
            opcion.Icono.Cursor = Cursors.Hand;
            Tema.Icono(opcion.Icono, glifo, 12F, Color.FromArgb(148, 163, 184));

            opcion.Texto = new Label();
            opcion.Texto.Location = new Point(44, 0);
            opcion.Texto.Size = new Size(162, 42);
            opcion.Texto.AutoSize = false;
            opcion.Texto.Text = texto;
            opcion.Texto.Font = Tema.Fuente(9.5F, FontStyle.Regular);
            opcion.Texto.ForeColor = Color.FromArgb(203, 213, 225);
            opcion.Texto.TextAlign = ContentAlignment.MiddleLeft;
            opcion.Texto.BackColor = Color.Transparent;
            opcion.Texto.Cursor = Cursors.Hand;

            opcion.Panel.Controls.Add(opcion.Texto);
            opcion.Panel.Controls.Add(opcion.Icono);
            opcion.Panel.Controls.Add(opcion.Indicador);

            EventHandler click = delegate
            {
                ActivarOpcion(opcion);

                if (fabrica != null)
                {
                    AbrirModulo(fabrica, opcion);
                }

                if (accion != null)
                {
                    accion(opcion, EventArgs.Empty);
                }
            };

            opcion.Panel.Click += click;
            opcion.Icono.Click += click;
            opcion.Texto.Click += click;

            EventHandler entrar = delegate { AplicarHover(opcion, true); };
            EventHandler salir = delegate { AplicarHover(opcion, false); };

            opcion.Panel.MouseEnter += entrar;
            opcion.Panel.MouseLeave += salir;
            opcion.Icono.MouseEnter += entrar;
            opcion.Icono.MouseLeave += salir;
            opcion.Texto.MouseEnter += entrar;
            opcion.Texto.MouseLeave += salir;

            opciones.Add(opcion);
            pnlNavegacion.Controls.Add(opcion.Panel);

            if (activo)
            {
                ActivarOpcion(opcion);
            }
        }

        private void AplicarHover(OpcionNav opcion, bool dentro)
        {
            if (opcion.Activo)
            {
                return;
            }

            opcion.Panel.BackColor = dentro
                ? Color.FromArgb(23, 54, 86)
                : Color.Transparent;

            opcion.Icono.ForeColor = dentro
                ? Color.FromArgb(226, 232, 240)
                : Color.FromArgb(148, 163, 184);
        }

        private void ActivarOpcion(OpcionNav opcion)
        {
            foreach (OpcionNav item in opciones)
            {
                item.Activo = item == opcion;
                item.Panel.BackColor = item.Activo ? Color.FromArgb(30, 58, 90) : Color.Transparent;
                item.Indicador.BackColor = item.Activo ? Tema.Ambar : Color.Transparent;
                item.Icono.ForeColor = item.Activo ? Tema.Ambar : Color.FromArgb(148, 163, 184);
                item.Texto.ForeColor = item.Activo ? Color.White : Color.FromArgb(203, 213, 225);
                item.Texto.Font = Tema.Fuente(9.5F, item.Activo ? FontStyle.Bold : FontStyle.Regular);
            }
        }

        private void AbrirModulo(Func<Form> fabrica, OpcionNav opcion)
        {
            try
            {
                using (Form modulo = fabrica())
                {
                    modulo.StartPosition = FormStartPosition.CenterParent;
                    modulo.ShowDialog(this);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "No fue posible abrir el módulo.\n\n" + error.Message,
                    "CI Almaseg",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (opcionInicio != null)
                {
                    ActivarOpcion(opcionInicio);
                }
            }
        }

        private void ConstruirDashboard()
        {
            pnlContenido.Controls.Clear();

            TableLayoutPanel principal = new TableLayoutPanel();
            principal.Dock = DockStyle.Top;
            principal.AutoSize = true;
            principal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            principal.ColumnCount = 1;
            principal.RowCount = 4;
            principal.BackColor = Color.Transparent;
            principal.Margin = Padding.Empty;
            principal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            principal.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            principal.RowStyles.Add(new RowStyle(SizeType.Absolute, 132F));
            principal.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            principal.RowStyles.Add(new RowStyle(SizeType.Absolute, 306F));

            principal.Controls.Add(CrearBienvenida(), 0, 0);
            principal.Controls.Add(CrearIndicadores(), 0, 1);
            principal.Controls.Add(CrearTituloAccesos(), 0, 2);
            principal.Controls.Add(CrearAccesos(), 0, 3);

            pnlContenido.Controls.Add(principal);
        }

        private Control CrearBienvenida()
        {
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            panel.Height = 68;
            panel.Margin = new Padding(0, 0, 0, 12);
            panel.BackColor = Color.Transparent;

            string primerNombre = string.IsNullOrWhiteSpace(SesionActual.Nombre)
                ? "Administrador"
                : SesionActual.Nombre.Split(' ')[0];

            Label titulo = Tema.CrearEtiqueta(
                "Hola, " + primerNombre,
                23F,
                FontStyle.Bold,
                Tema.Marino);
            titulo.Location = new Point(0, 0);

            Label resumen = Tema.CrearEtiqueta(
                "Este es el estado actual de la operación de CI Almaseg.",
                9.5F,
                FontStyle.Regular,
                Tema.TextoSuave);
            resumen.Location = new Point(2, 40);

            panel.Controls.Add(resumen);
            panel.Controls.Add(titulo);
            return panel;
        }

        private Control CrearIndicadores()
        {
            TableLayoutPanel tabla = new TableLayoutPanel();
            tabla.Dock = DockStyle.Fill;
            tabla.ColumnCount = 4;
            tabla.RowCount = 1;
            tabla.BackColor = Color.Transparent;
            tabla.Margin = Padding.Empty;

            for (int i = 0; i < 4; i++)
            {
                tabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            }

            tabla.Controls.Add(CrearKpi("Ventas acumuladas", "\uE8C7", Tema.Azul, Tema.AzulSuave, out lblVentas), 0, 0);
            tabla.Controls.Add(CrearKpi("Productos activos", "\uE7B8", Tema.Ambar, Tema.AmbarSuave, out lblProductos), 1, 0);
            tabla.Controls.Add(CrearKpi("Stock bajo", "\uE7BA", Tema.Peligro, Tema.PeligroSuave, out lblStockBajo), 2, 0);
            tabla.Controls.Add(CrearKpi("Clientes activos", "\uE77B", Tema.Exito, Tema.ExitoSuave, out lblClientes), 3, 0);

            return tabla;
        }

        private Panel CrearKpi(string titulo, string glifo, Color color, Color fondoIcono, out Label valor)
        {
            Panel tarjeta = new Panel();
            tarjeta.Dock = DockStyle.Fill;
            tarjeta.Margin = new Padding(6);
            Tema.Tarjeta(tarjeta);

            Panel iconoFondo = new Panel();
            iconoFondo.Location = new Point(16, 18);
            iconoFondo.Size = new Size(38, 38);
            iconoFondo.BackColor = fondoIcono;
            Tema.Redondear(iconoFondo, 9);

            Label icono = new Label();
            icono.Dock = DockStyle.Fill;
            Tema.Icono(icono, glifo, 13F, color);

            Label texto = Tema.CrearEtiqueta(titulo, 8.75F, FontStyle.Regular, Tema.TextoSuave);
            texto.Location = new Point(64, 18);
            texto.AutoSize = false;
            texto.Size = new Size(130, 18);

            valor = new Label();
            valor.AutoSize = true;
            valor.MinimumSize = new Size(140, 34);
            valor.Location = new Point(64, 40);
            valor.Font = Tema.Fuente(16F, FontStyle.Bold);
            valor.ForeColor = Tema.Texto;
            valor.Text = "—";
            valor.BackColor = Color.Transparent;
            valor.TextAlign = ContentAlignment.MiddleLeft;

            iconoFondo.Controls.Add(icono);
            tarjeta.Controls.Add(valor);
            tarjeta.Controls.Add(texto);
            tarjeta.Controls.Add(iconoFondo);
            return tarjeta;
        }

        private Control CrearTituloAccesos()
        {
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            panel.Height = 44;
            panel.Margin = new Padding(0, 8, 0, 4);
            panel.BackColor = Color.Transparent;

            Label titulo = Tema.CrearEtiqueta("Accesos rápidos", 15F, FontStyle.Bold, Tema.Marino);
            titulo.Location = new Point(6, 10);
            panel.Controls.Add(titulo);
            return panel;
        }

        private Control CrearAccesos()
        {
            TableLayoutPanel tabla = new TableLayoutPanel();
            tabla.Dock = DockStyle.Fill;
            tabla.ColumnCount = 4;
            tabla.RowCount = 2;
            tabla.BackColor = Color.Transparent;
            tabla.Margin = Padding.Empty;

            for (int i = 0; i < 4; i++)
            {
                tabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            }

            tabla.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tabla.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            tabla.Controls.Add(CrearAcceso("Ventas", "Registra salidas y consulta el historial.", "\uE7BF", Tema.Azul, delegate { new FrmVentas().ShowDialog(this); }), 0, 0);
            tabla.Controls.Add(CrearAcceso("Compras", "Abastece inventario y controla costos.", "\uE719", Tema.Ambar, delegate { new FrmCompras().ShowDialog(this); }), 1, 0);
            tabla.Controls.Add(CrearAcceso("Productos", "Administra precios, stock y categorías.", "\uE7B8", Tema.Azul, delegate { new FrmProductos().ShowDialog(this); }), 2, 0);
            tabla.Controls.Add(CrearAcceso("Reportes", "Analiza ventas por período y empleado.", "\uE9D9", Tema.Exito, delegate { new FrmReportes().ShowDialog(this); }), 3, 0);
            tabla.Controls.Add(CrearAcceso("Clientes", "Gestiona datos de contacto y ubicación.", "\uE77B", Tema.Exito, delegate { new FrmGestionClientes().ShowDialog(this); }), 0, 1);
            tabla.Controls.Add(CrearAcceso("Proveedores", "Centraliza aliados y condiciones.", "\uE806", Tema.Ambar, delegate { new FrmProveedores().ShowDialog(this); }), 1, 1);
            tabla.Controls.Add(CrearAcceso("Empleados", "Organiza el equipo y sus cargos.", "\uE716", Tema.Azul, delegate { new FrmEmpleados().ShowDialog(this); }), 2, 1);
            tabla.Controls.Add(CrearAcceso("Categorías", "Clasifica el catálogo de productos.", "\uE8EC", Tema.Exito, delegate { new FrmCategorias().ShowDialog(this); }), 3, 1);

            return tabla;
        }

        private Panel CrearAcceso(string titulo, string descripcion, string glifo, Color color, EventHandler accion)
        {
            Panel tarjeta = new Panel();
            tarjeta.Dock = DockStyle.Fill;
            tarjeta.Margin = new Padding(6);
            tarjeta.Cursor = Cursors.Hand;
            Tema.Tarjeta(tarjeta);

            Panel iconoFondo = new Panel();
            iconoFondo.Location = new Point(18, 18);
            iconoFondo.Size = new Size(40, 40);
            iconoFondo.BackColor = Tema.AzulSuave;
            Tema.Redondear(iconoFondo, 9);

            Label icono = new Label();
            icono.Dock = DockStyle.Fill;
            Tema.Icono(icono, glifo, 14F, color);

            Label nombre = Tema.CrearEtiqueta(titulo, 11F, FontStyle.Bold, Tema.Marino);
            nombre.Location = new Point(18, 72);

            Label detalle = new Label();
            detalle.AutoSize = false;
            detalle.Location = new Point(18, 98);
            detalle.Size = new Size(180, 36);
            detalle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            detalle.Font = Tema.Fuente(8.5F, FontStyle.Regular);
            detalle.ForeColor = Tema.TextoSuave;
            detalle.Text = descripcion;
            detalle.BackColor = Color.Transparent;

            Label flecha = new Label();
            flecha.Location = new Point(168, 18);
            flecha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flecha.Size = new Size(20, 20);
            flecha.Text = "›";
            flecha.Font = Tema.Fuente(16F, FontStyle.Bold);
            flecha.ForeColor = Color.FromArgb(148, 163, 184);
            flecha.TextAlign = ContentAlignment.MiddleCenter;
            flecha.BackColor = Color.Transparent;

            EventHandler entrar = delegate { tarjeta.BackColor = Color.FromArgb(248, 250, 252); };
            EventHandler salir = delegate { tarjeta.BackColor = Color.White; };

            tarjeta.MouseEnter += entrar;
            tarjeta.MouseLeave += salir;
            iconoFondo.MouseEnter += entrar;
            iconoFondo.MouseLeave += salir;
            icono.MouseEnter += entrar;
            icono.MouseLeave += salir;
            nombre.MouseEnter += entrar;
            nombre.MouseLeave += salir;
            detalle.MouseEnter += entrar;
            detalle.MouseLeave += salir;
            flecha.MouseEnter += entrar;
            flecha.MouseLeave += salir;

            tarjeta.Click += accion;
            iconoFondo.Click += accion;
            icono.Click += accion;
            nombre.Click += accion;
            detalle.Click += accion;
            flecha.Click += accion;

            iconoFondo.Controls.Add(icono);
            tarjeta.Controls.Add(flecha);
            tarjeta.Controls.Add(detalle);
            tarjeta.Controls.Add(nombre);
            tarjeta.Controls.Add(iconoFondo);

            tarjeta.Resize += delegate
            {
                detalle.Width = Math.Max(40, tarjeta.ClientSize.Width - 36);
                flecha.Left = Math.Max(0, tarjeta.ClientSize.Width - 32);
            };

            return tarjeta;
        }

        private async Task CargarResumenAsync()
        {
            try
            {
                DataTable datos = await Task.Run(() => ObtenerResumen());

                if (IsDisposed || datos.Rows.Count == 0)
                {
                    return;
                }

                DataRow fila = datos.Rows[0];

                lblVentas.Text = Tema.FormatearMoneda(Convert.ToDecimal(fila["ventas"]));
                lblProductos.Text = Convert.ToInt32(fila["productos"]).ToString("N0");
                lblStockBajo.Text = Convert.ToInt32(fila["stock_bajo"]).ToString("N0");
                lblClientes.Text = Convert.ToInt32(fila["clientes"]).ToString("N0");
            }
            catch (Exception)
            {
                lblVentas.Text = "—";
                lblProductos.Text = "—";
                lblStockBajo.Text = "—";
                lblClientes.Text = "—";
            }
        }

        private DataTable ObtenerResumen()
        {
            const string consulta = @"
SELECT
    (SELECT ISNULL(SUM(total), 0) FROM tbl.venta WHERE estado = 'COMPLETADA') AS ventas,
    (SELECT COUNT(*) FROM tbl.producto WHERE estado = 1) AS productos,
    (SELECT COUNT(*) FROM tbl.producto WHERE estado = 1 AND stock <= stock_minimo) AS stock_bajo,
    (SELECT COUNT(*) FROM tbl.cliente WHERE estado = 1) AS clientes;";

            using (SqlConnection conexion = new Conexion().AbrirConexion())
            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Deseas cerrar la sesión actual?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                CerrandoSesion = true;
                Close();
            }
        }

        private static string PrimeraMayuscula(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return texto;
            }

            return char.ToUpperInvariant(texto[0]) + texto.Substring(1);
        }

        private sealed class OpcionNav
        {
            public Panel Panel { get; set; }
            public Panel Indicador { get; set; }
            public Label Icono { get; set; }
            public Label Texto { get; set; }
            public bool Activo { get; set; }
        }
    }
}
