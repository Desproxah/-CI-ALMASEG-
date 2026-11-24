using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CIAlmaseg.Clases
{
    public enum TipoBoton
    {
        Primario,
        Secundario,
        Peligro,
        Oscuro,
        Claro,
        Ambar,
        Fantasma
    }

    /// <summary>
    /// Paleta, tipografía y utilidades visuales compartidas por todos los formularios.
    /// </summary>
    public static class Tema
    {
        public static readonly Color Marino = Color.FromArgb(14, 42, 71);
        public static readonly Color MarinoClaro = Color.FromArgb(21, 62, 103);
        public static readonly Color Azul = Color.FromArgb(29, 78, 216);
        public static readonly Color AzulHover = Color.FromArgb(30, 64, 175);
        public static readonly Color AzulSuave = Color.FromArgb(219, 234, 254);
        public static readonly Color Ambar = Color.FromArgb(245, 158, 11);
        public static readonly Color AmbarSuave = Color.FromArgb(254, 243, 199);
        public static readonly Color Fondo = Color.FromArgb(244, 246, 250);
        public static readonly Color Blanco = Color.White;
        public static readonly Color Texto = Color.FromArgb(15, 23, 42);
        public static readonly Color TextoSuave = Color.FromArgb(100, 116, 139);
        public static readonly Color Borde = Color.FromArgb(226, 232, 240);
        public static readonly Color Exito = Color.FromArgb(21, 128, 61);
        public static readonly Color ExitoSuave = Color.FromArgb(220, 252, 231);
        public static readonly Color Peligro = Color.FromArgb(185, 28, 28);
        public static readonly Color PeligroSuave = Color.FromArgb(254, 226, 226);
        public static readonly Color FilaAlterna = Color.FromArgb(248, 250, 252);
        public static readonly Color GrisHover = Color.FromArgb(241, 245, 249);

        private const string FuenteBase = "Segoe UI";
        private const string FuenteIconos = "Segoe MDL2 Assets";

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        public static Font Fuente(float tamano, FontStyle estilo)
        {
            return new Font(FuenteBase, tamano, estilo, GraphicsUnit.Point);
        }

        public static Font Fuente(float tamano)
        {
            return Fuente(tamano, FontStyle.Regular);
        }

        public static Font FuenteIcono(float tamano)
        {
            return new Font(FuenteIconos, tamano, FontStyle.Regular, GraphicsUnit.Point);
        }

        public static void AplicarFormulario(Form formulario)
        {
            formulario.Font = Fuente(9.5F);
            formulario.BackColor = Fondo;
            formulario.ForeColor = Texto;
            formulario.AutoScaleMode = AutoScaleMode.Font;

            try
            {
                PropertyInfo dobleBuffer = typeof(Control).GetProperty(
                    "DoubleBuffered",
                    BindingFlags.Instance | BindingFlags.NonPublic);

                if (dobleBuffer != null)
                {
                    dobleBuffer.SetValue(formulario, true, null);
                }
            }
            catch
            {
                // El doble buffer es una mejora visual, no un requisito.
            }

            AplicarTipografia(formulario);
        }

        private static void AplicarTipografia(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (!(control is Form))
                {
                    Font actual = control.Font;
                    control.Font = new Font(FuenteBase, actual.Size, actual.Style, GraphicsUnit.Point);
                }

                if (control.HasChildren)
                {
                    AplicarTipografia(control);
                }
            }
        }

        /// <summary>
        /// Aplica el tema a formularios construidos con el diseñador original sin
        /// modificar su estructura: encabezado blanco, tarjetas, grillas y botones.
        /// </summary>
        public static void AutoAplicar(Form formulario)
        {
            formulario.Load += delegate
            {
                formulario.BackColor = Fondo;
                formulario.ForeColor = Texto;
                EstilizarRecursivo(formulario, formulario);
            };
        }

        private static void EstilizarRecursivo(Control contenedor, Form formulario)
        {
            foreach (Control control in contenedor.Controls)
            {
                Panel panel = control as Panel;

                if (panel != null)
                {
                    string nombrePanel = panel.Name.ToLowerInvariant();
                    bool esEncabezado = nombrePanel.Contains("encabezado") ||
                                        nombrePanel.Contains("header");

                    panel.BackColor = Blanco;

                    if (esEncabezado)
                    {
                        panel.Paint += delegate(object sender, PaintEventArgs e)
                        {
                            Panel actual = (Panel)sender;

                            using (Pen lapiz = new Pen(Borde, 1F))
                            {
                                e.Graphics.DrawLine(
                                    lapiz,
                                    0,
                                    actual.Height - 1,
                                    actual.Width,
                                    actual.Height - 1);
                            }
                        };
                    }
                    else if (panel.Parent == formulario)
                    {
                        if (panel.BorderStyle != BorderStyle.None)
                        {
                            panel.BorderStyle = BorderStyle.None;
                        }

                        Tarjeta(panel);
                    }
                }
                else if (control is Label)
                {
                    EstilizarEtiqueta((Label)control);
                }
                else if (control is TextBox)
                {
                    TextBox caja = (TextBox)control;
                    EstilizarEntrada(caja);

                    if (caja.ReadOnly)
                    {
                        caja.BackColor = Color.FromArgb(248, 250, 252);
                    }
                }
                else if (control is ComboBox)
                {
                    EstilizarCombo((ComboBox)control);
                }
                else if (control is NumericUpDown)
                {
                    control.Font = Fuente(9F);
                }
                else if (control is DateTimePicker)
                {
                    control.Font = Fuente(9F);
                }
                else if (control is CheckBox)
                {
                    control.Font = Fuente(9F);
                    control.ForeColor = Texto;
                }
                else if (control is Button)
                {
                    Button boton = (Button)control;
                    boton.Text = NormalizarTextoBoton(boton.Text);
                    EstilizarBoton(boton, TipoBotonSegunNombre(boton.Name));
                }
                else if (control is DataGridView)
                {
                    EstilizarGrid((DataGridView)control);
                }
                else
                {
                    control.ForeColor = Texto;
                }

                if (control.HasChildren)
                {
                    EstilizarRecursivo(control, formulario);
                }
            }
        }

        private static void EstilizarEtiqueta(Label etiqueta)
        {
            string nombre = etiqueta.Name.ToLowerInvariant();
            float tamano = etiqueta.Font.SizeInPoints;

            // "subtitulo" contiene "titulo": revisar primero.
            if (nombre.Contains("subtitulo") || nombre.StartsWith("label"))
            {
                etiqueta.Font = Fuente(9.5F, FontStyle.Regular);
                etiqueta.ForeColor = TextoSuave;
                return;
            }

            if (nombre.Contains("titulo"))
            {
                // Título principal del formulario (≥15 pt) frente a
                // títulos de sección dentro de pestañas (12 pt).
                if (tamano >= 15F)
                {
                    etiqueta.Font = Fuente(Math.Max(17F, Math.Min(tamano, 22F)), FontStyle.Bold);
                }
                else
                {
                    etiqueta.Font = Fuente(Math.Max(11.5F, tamano), FontStyle.Bold);
                }

                etiqueta.ForeColor = Marino;
                return;
            }

            if (tamano >= 11.5F)
            {
                etiqueta.Font = Fuente(tamano, FontStyle.Bold);
                etiqueta.ForeColor = Marino;
                return;
            }

            etiqueta.Font = Fuente(tamano, FontStyle.Bold);
            etiqueta.ForeColor = Texto;
        }

        private static TipoBoton TipoBotonSegunNombre(string nombre)
        {
            string valor = nombre.ToLowerInvariant();

            if (valor.Contains("eliminar"))
            {
                return TipoBoton.Peligro;
            }

            if (valor.Contains("guardar") ||
                valor.Contains("confirmar") ||
                valor.Contains("agregar"))
            {
                return TipoBoton.Primario;
            }

            if (valor.Contains("cancelar") ||
                valor.Contains("cerrar") ||
                valor.Contains("limpiar") ||
                valor.Contains("nuevo") ||
                valor.Contains("nueva") ||
                valor.Contains("volver") ||
                valor.Contains("buscar") ||
                valor.Contains("editar"))
            {
                return TipoBoton.Secundario;
            }

            return TipoBoton.Primario;
        }

        private static string NormalizarTextoBoton(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return texto;
            }

            bool tieneLetras = false;
            bool soloMayusculas = true;

            foreach (char caracter in texto)
            {
                if (char.IsLetter(caracter))
                {
                    tieneLetras = true;

                    if (char.IsLower(caracter))
                    {
                        soloMayusculas = false;
                        break;
                    }
                }
            }

            if (!tieneLetras || !soloMayusculas)
            {
                return texto;
            }

            string minusculas = texto.ToLowerInvariant();
            return char.ToUpperInvariant(minusculas[0]) + minusculas.Substring(1);
        }

        public static void PrepararVentana(Form formulario, int anchoMinimo, int altoMinimo)
        {
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.FormBorderStyle = FormBorderStyle.Sizable;
            formulario.MinimumSize = new Size(anchoMinimo, altoMinimo);
            formulario.MaximizeBox = true;
        }

        public static void EstilizarBoton(Button boton, TipoBoton tipo)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.UseVisualStyleBackColor = false;
            boton.Cursor = Cursors.Hand;
            boton.FlatAppearance.BorderSize = 0;
            boton.Font = Fuente(Math.Max(9F, boton.Font.SizeInPoints), FontStyle.Regular);

            switch (tipo)
            {
                case TipoBoton.Primario:
                    boton.BackColor = Azul;
                    boton.ForeColor = Color.White;
                    boton.FlatAppearance.MouseOverBackColor = AzulHover;
                    boton.FlatAppearance.MouseDownBackColor = Marino;
                    break;

                case TipoBoton.Secundario:
                    boton.BackColor = Blanco;
                    boton.ForeColor = Texto;
                    boton.FlatAppearance.BorderSize = 1;
                    boton.FlatAppearance.BorderColor = Borde;
                    boton.FlatAppearance.MouseOverBackColor = GrisHover;
                    boton.FlatAppearance.MouseDownBackColor = Borde;
                    break;

                case TipoBoton.Peligro:
                    boton.BackColor = Color.White;
                    boton.ForeColor = Peligro;
                    boton.FlatAppearance.BorderSize = 1;
                    boton.FlatAppearance.BorderColor = Color.FromArgb(252, 165, 165);
                    boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 242, 242);
                    boton.FlatAppearance.MouseDownBackColor = PeligroSuave;
                    break;

                case TipoBoton.Oscuro:
                    boton.BackColor = Marino;
                    boton.ForeColor = Color.White;
                    boton.FlatAppearance.MouseOverBackColor = MarinoClaro;
                    boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 26, 46);
                    break;

                case TipoBoton.Claro:
                    boton.BackColor = Color.FromArgb(226, 232, 240);
                    boton.ForeColor = Texto;
                    boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 213, 225);
                    boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(148, 163, 184);
                    break;

                case TipoBoton.Ambar:
                    boton.BackColor = Ambar;
                    boton.ForeColor = Marino;
                    boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(251, 191, 36);
                    boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(217, 119, 6);
                    boton.Font = Fuente(Math.Max(9F, boton.Font.SizeInPoints), FontStyle.Bold);
                    break;

                case TipoBoton.Fantasma:
                    boton.BackColor = Color.Transparent;
                    boton.ForeColor = TextoSuave;
                    boton.FlatAppearance.MouseOverBackColor = GrisHover;
                    boton.FlatAppearance.MouseDownBackColor = Borde;
                    break;
            }

            Redondear(boton, 8);
            boton.Resize += delegate { Redondear(boton, 8); };
        }

        public static void EstilizarBotones(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                Button boton = control as Button;

                if (boton != null)
                {
                    string nombre = boton.Name.ToLowerInvariant();

                    if (nombre.Contains("eliminar"))
                    {
                        EstilizarBoton(boton, TipoBoton.Peligro);
                    }
                    else if (nombre.Contains("cerrar") ||
                             nombre.Contains("cancelar") ||
                             nombre.Contains("limpiar") ||
                             nombre.Contains("volver") ||
                             nombre.Contains("mostrar"))
                    {
                        EstilizarBoton(boton, TipoBoton.Secundario);
                    }
                    else
                    {
                        EstilizarBoton(boton, TipoBoton.Primario);
                    }
                }

                if (control.HasChildren)
                {
                    EstilizarBotones(control);
                }
            }
        }

        public static void EstilizarGrid(DataGridView grid)
        {
            grid.BackgroundColor = Blanco;
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Borde;
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.EnableHeadersVisualStyles = false;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.ColumnHeadersHeight = 38;
            grid.RowTemplate.Height = 34;
            grid.Font = Fuente(9.25F);

            grid.ColumnHeadersDefaultCellStyle.BackColor = Marino;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Marino;
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = Fuente(9.25F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            grid.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

            grid.DefaultCellStyle.BackColor = Blanco;
            grid.DefaultCellStyle.ForeColor = Texto;
            grid.DefaultCellStyle.SelectionBackColor = AzulSuave;
            grid.DefaultCellStyle.SelectionForeColor = Texto;
            grid.DefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            grid.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            grid.AlternatingRowsDefaultCellStyle.BackColor = FilaAlterna;
            grid.AlternatingRowsDefaultCellStyle.SelectionBackColor = AzulSuave;
            grid.AlternatingRowsDefaultCellStyle.SelectionForeColor = Texto;

            try
            {
                PropertyInfo propiedad = typeof(DataGridView).GetProperty(
                    "DoubleBuffered",
                    BindingFlags.Instance | BindingFlags.NonPublic);

                if (propiedad != null)
                {
                    propiedad.SetValue(grid, true, null);
                }
            }
            catch
            {
                // Si la propiedad interna no está disponible, la grilla sigue funcionando.
            }
        }

        public static void EstilizarEntrada(TextBox caja)
        {
            caja.BorderStyle = BorderStyle.FixedSingle;
            caja.BackColor = Blanco;
            caja.ForeColor = Texto;
            caja.Font = Fuente(9.5F);
        }

        public static void EstilizarCombo(ComboBox combo)
        {
            // FlatStyle.System conserva el borde nativo del combo; con
            // Flat el borde se pinta con el color de fondo y el control
            // parece no tener contorno.
            combo.FlatStyle = FlatStyle.System;
            combo.BackColor = Blanco;
            combo.ForeColor = Texto;
            combo.Font = Fuente(9.5F);
        }

        public static void Titulo(Label etiqueta)
        {
            etiqueta.Font = Fuente(21F, FontStyle.Bold);
            etiqueta.ForeColor = Marino;
        }

        public static void TituloSeccion(Label etiqueta)
        {
            etiqueta.Font = Fuente(12F, FontStyle.Bold);
            etiqueta.ForeColor = Marino;
        }

        public static void Subtitulo(Label etiqueta)
        {
            etiqueta.Font = Fuente(9.5F, FontStyle.Regular);
            etiqueta.ForeColor = TextoSuave;
        }

        public static void Etiqueta(Label etiqueta)
        {
            etiqueta.Font = Fuente(9F, FontStyle.Bold);
            etiqueta.ForeColor = Texto;
        }

        public static void Icono(Label etiqueta, string glifo, float tamano, Color color)
        {
            etiqueta.Font = FuenteIcono(tamano);
            etiqueta.ForeColor = color;
            etiqueta.Text = glifo;
            etiqueta.TextAlign = ContentAlignment.MiddleCenter;
            etiqueta.BackColor = Color.Transparent;
        }

        public static void Tarjeta(Panel panel)
        {
            panel.BackColor = Blanco;
            panel.Paint += delegate(object sender, PaintEventArgs e)
            {
                Panel actual = (Panel)sender;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rectangulo = new Rectangle(0, 0, actual.Width - 1, actual.Height - 1);

                using (GraphicsPath ruta = CrearRuta(rectangulo, 12))
                using (Pen lapiz = new Pen(Borde, 1F))
                {
                    e.Graphics.DrawPath(lapiz, ruta);
                }
            };
            panel.Resize += delegate { Redondear(panel, 12); };
            Redondear(panel, 12);
        }

        public static void Redondear(Control control, int radio)
        {
            if (control.Width <= 0 || control.Height <= 0)
            {
                return;
            }

            Rectangle rectangulo = new Rectangle(0, 0, control.Width, control.Height);

            using (GraphicsPath ruta = CrearRuta(rectangulo, radio))
            {
                Region anterior = control.Region;
                control.Region = new Region(ruta);

                if (anterior != null)
                {
                    anterior.Dispose();
                }
            }
        }

        private static GraphicsPath CrearRuta(Rectangle rectangulo, int radio)
        {
            GraphicsPath ruta = new GraphicsPath();
            int diametro = radio * 2;

            if (diametro <= 0)
            {
                ruta.AddRectangle(rectangulo);
                return ruta;
            }

            Rectangle arco = new Rectangle(rectangulo.Location, new Size(diametro, diametro));
            ruta.AddArc(arco, 180, 90);
            arco.X = rectangulo.Right - diametro;
            ruta.AddArc(arco, 270, 90);
            arco.Y = rectangulo.Bottom - diametro;
            ruta.AddArc(arco, 0, 90);
            arco.X = rectangulo.Left;
            ruta.AddArc(arco, 90, 90);
            ruta.CloseFigure();

            return ruta;
        }

        public static void Placeholder(TextBox caja, string texto)
        {
            if (caja.IsHandleCreated)
            {
                SendMessage(caja.Handle, 0x1501, (IntPtr)1, texto);
            }
            else
            {
                caja.HandleCreated += delegate
                {
                    SendMessage(caja.Handle, 0x1501, (IntPtr)1, texto);
                };
            }
        }

        public static string FormatearMoneda(decimal valor)
        {
            return valor.ToString("C0", CultureInfo.GetCultureInfo("es-CO"));
        }

        public static string FormatearFecha(DateTime fecha)
        {
            return fecha.ToString("dddd, d 'de' MMMM 'de' yyyy", CultureInfo.GetCultureInfo("es-CO"));
        }

        public static string Iniciales(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return "CI";
            }

            string[] partes = nombre.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (partes.Length == 1)
            {
                return partes[0].Substring(0, Math.Min(2, partes[0].Length)).ToUpperInvariant();
            }

            return (partes[0].Substring(0, 1) + partes[1].Substring(0, 1)).ToUpperInvariant();
        }

        public static Label CrearEtiqueta(string texto, float tamano, FontStyle estilo, Color color)
        {
            Label etiqueta = new Label();
            etiqueta.Text = texto;
            etiqueta.AutoSize = true;
            etiqueta.Font = Fuente(tamano, estilo);
            etiqueta.ForeColor = color;
            etiqueta.BackColor = Color.Transparent;
            return etiqueta;
        }

        public static Button CrearBoton(string texto, TipoBoton tipo)
        {
            Button boton = new Button();
            boton.Text = texto;
            boton.Height = 38;
            boton.AutoSize = false;
            EstilizarBoton(boton, tipo);
            return boton;
        }
    }
}
