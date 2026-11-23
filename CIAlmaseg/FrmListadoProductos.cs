using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CIAlmaseg.Clases;

namespace CIAlmaseg
{
    public partial class FrmListadoProductos : Form
    {
        private readonly Timer temporizadorBusqueda = new Timer();
        private bool cargandoCategorias;
        private bool cargandoProductos;

        public FrmListadoProductos()
        {
            InitializeComponent();

            temporizadorBusqueda.Interval = 350;
            temporizadorBusqueda.Tick += delegate
            {
                temporizadorBusqueda.Stop();
                CargarProductos();
            };

            FormClosed += delegate
            {
                temporizadorBusqueda.Stop();
                temporizadorBusqueda.Dispose();
            };
        }

        private void FrmListadoProductos_Load(object sender, EventArgs e)
        {
            Tema.AplicarFormulario(this);
            Tema.Redondear(pnlMonograma, 10);
            Tema.EstilizarBoton(btnVolver, TipoBoton.Secundario);
            Tema.EstilizarEntrada(txtBuscar);
            Tema.EstilizarCombo(cmbCategoria);
            Tema.Placeholder(txtBuscar, "Buscar por nombre o código...");

            Tema.Icono(lblIconoBusqueda, "\uE721", 11F, Tema.TextoSuave);
            Tema.TituloSeccion(lblTituloCatalogo);
            lblTituloCatalogo.Font = Tema.Fuente(16F, FontStyle.Bold);
            Tema.Subtitulo(lblSubtituloCatalogo);
            Tema.Subtitulo(lblContador);
            lblMarca.ForeColor = Tema.Marino;
            lblMarcaSub.ForeColor = Tema.TextoSuave;
            lblMonograma.ForeColor = Tema.Marino;

            CargarCategorias();
            CargarProductos();
        }

        private void CargarCategorias()
        {
            try
            {
                using (SqlConnection conexion = new Conexion().AbrirConexion())
                {
                    const string consulta = @"
SELECT id_categoria, nombre
FROM tbl.categoria
WHERE estado = 1
ORDER BY nombre;";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        DataRow todas = tabla.NewRow();
                        todas["id_categoria"] = 0;
                        todas["nombre"] = "Todas las categorías";
                        tabla.Rows.InsertAt(todas, 0);

                        cargandoCategorias = true;
                        cmbCategoria.DataSource = tabla;
                        cmbCategoria.DisplayMember = "nombre";
                        cmbCategoria.ValueMember = "id_categoria";
                        cmbCategoria.SelectedIndex = 0;
                        cargandoCategorias = false;
                    }
                }
            }
            catch (Exception)
            {
                cargandoCategorias = false;
                cmbCategoria.DataSource = null;
                MostrarEstadoVacio(
                    "No fue posible cargar las categorías",
                    "Verifica que LocalDB esté disponible. Ejecuta scripts\\init-db.ps1 si es necesario.",
                    true);
            }
        }

        private void CargarProductos()
        {
            if (cargandoProductos)
            {
                return;
            }

            cargandoProductos = true;

            try
            {
                flpProductos.SuspendLayout();
                flpProductos.Controls.Clear();

                int idCategoria = 0;

                if (cmbCategoria.SelectedValue != null)
                {
                    int.TryParse(cmbCategoria.SelectedValue.ToString(), out idCategoria);
                }

                string texto = txtBuscar.Text.Trim();

                using (SqlConnection conexion = new Conexion().AbrirConexion())
                {
                    const string consulta = @"
SELECT
    p.codigo,
    p.nombre,
    c.nombre AS categoria,
    p.descripcion,
    p.precio_venta,
    p.stock,
    p.stock_minimo
FROM tbl.producto AS p
INNER JOIN tbl.categoria AS c ON c.id_categoria = p.id_categoria
WHERE p.estado = 1
  AND c.estado = 1
  AND (@idCategoria = 0 OR p.id_categoria = @idCategoria)
  AND (@texto = '' OR p.nombre LIKE '%' + @texto + '%' OR p.codigo LIKE '%' + @texto + '%')
ORDER BY p.nombre;";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.Add("@idCategoria", SqlDbType.Int).Value = idCategoria;
                        comando.Parameters.Add("@texto", SqlDbType.NVarChar, 120).Value = texto;

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            int contador = 0;

                            while (lector.Read())
                            {
                                flpProductos.Controls.Add(CrearTarjetaProducto(lector));
                                contador++;
                            }

                            lblContador.Text = contador == 1
                                ? "1 producto encontrado"
                                : contador.ToString("N0") + " productos encontrados";

                            if (contador == 0)
                            {
                                MostrarEstadoVacio(
                                    "No encontramos productos",
                                    "Prueba con otra búsqueda o selecciona una categoría diferente.",
                                    false);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                lblContador.Text = "Sin resultados";
                MostrarEstadoVacio(
                    "No fue posible cargar el catálogo",
                    "No pudimos conectar con la base de datos. Ejecuta scripts\\init-db.ps1 y vuelve a intentar.",
                    true);
            }
            finally
            {
                flpProductos.ResumeLayout();
                cargandoProductos = false;
            }
        }

        private Panel CrearTarjetaProducto(SqlDataReader lector)
        {
            string codigo = lector["codigo"].ToString();
            string nombre = lector["nombre"].ToString();
            string categoria = lector["categoria"].ToString();
            string descripcion = lector["descripcion"] == DBNull.Value
                ? string.Empty
                : lector["descripcion"].ToString();
            decimal precio = Convert.ToDecimal(lector["precio_venta"]);
            int stock = Convert.ToInt32(lector["stock"]);
            int stockMinimo = Convert.ToInt32(lector["stock_minimo"]);

            Panel tarjeta = new Panel();
            tarjeta.Width = 270;
            tarjeta.Height = 230;
            tarjeta.Margin = new Padding(10);
            tarjeta.BackColor = Color.White;
            Tema.Tarjeta(tarjeta);

            Panel iconoFondo = new Panel();
            iconoFondo.Location = new Point(18, 18);
            iconoFondo.Size = new Size(42, 42);
            iconoFondo.BackColor = Tema.AzulSuave;
            Tema.Redondear(iconoFondo, 9);

            Label icono = new Label();
            icono.Dock = DockStyle.Fill;
            Tema.Icono(icono, "\uE7B8", 15F, Tema.Azul);

            Label codigoEtiqueta = new Label();
            codigoEtiqueta.AutoSize = false;
            codigoEtiqueta.Location = new Point(160, 22);
            codigoEtiqueta.Size = new Size(92, 18);
            codigoEtiqueta.Font = Tema.Fuente(8.25F, FontStyle.Bold);
            codigoEtiqueta.ForeColor = Tema.TextoSuave;
            codigoEtiqueta.Text = codigo;
            codigoEtiqueta.TextAlign = ContentAlignment.TopRight;

            Label categoriaEtiqueta = new Label();
            categoriaEtiqueta.AutoSize = false;
            categoriaEtiqueta.Location = new Point(18, 70);
            categoriaEtiqueta.Size = new Size(234, 16);
            categoriaEtiqueta.Font = Tema.Fuente(7.75F, FontStyle.Bold);
            categoriaEtiqueta.ForeColor = Tema.Azul;
            categoriaEtiqueta.Text = categoria.ToUpperInvariant();
            categoriaEtiqueta.AutoEllipsis = true;

            Label nombreEtiqueta = new Label();
            nombreEtiqueta.AutoSize = false;
            nombreEtiqueta.Location = new Point(18, 90);
            nombreEtiqueta.Size = new Size(234, 42);
            nombreEtiqueta.Font = Tema.Fuente(10.75F, FontStyle.Bold);
            nombreEtiqueta.ForeColor = Tema.Texto;
            nombreEtiqueta.Text = nombre;
            nombreEtiqueta.AutoEllipsis = true;

            Label descripcionEtiqueta = new Label();
            descripcionEtiqueta.AutoSize = false;
            descripcionEtiqueta.Location = new Point(18, 134);
            descripcionEtiqueta.Size = new Size(234, 30);
            descripcionEtiqueta.Font = Tema.Fuente(8.25F, FontStyle.Regular);
            descripcionEtiqueta.ForeColor = Tema.TextoSuave;
            descripcionEtiqueta.Text = descripcion;
            descripcionEtiqueta.AutoEllipsis = true;

            Label precioTitulo = new Label();
            precioTitulo.AutoSize = true;
            precioTitulo.Location = new Point(18, 172);
            precioTitulo.Font = Tema.Fuente(7.75F, FontStyle.Regular);
            precioTitulo.ForeColor = Tema.TextoSuave;
            precioTitulo.Text = "Precio";

            Label precioEtiqueta = new Label();
            precioEtiqueta.AutoSize = false;
            precioEtiqueta.Location = new Point(18, 188);
            precioEtiqueta.Size = new Size(130, 26);
            precioEtiqueta.Font = Tema.Fuente(13.5F, FontStyle.Bold);
            precioEtiqueta.ForeColor = Tema.Marino;
            precioEtiqueta.Text = Tema.FormatearMoneda(precio);

            Color fondoEstado;
            Color colorEstado;
            string textoEstado;

            if (stock <= 0)
            {
                fondoEstado = Tema.PeligroSuave;
                colorEstado = Tema.Peligro;
                textoEstado = "Agotado";
            }
            else if (stock <= stockMinimo)
            {
                fondoEstado = Tema.AmbarSuave;
                colorEstado = Color.FromArgb(180, 83, 9);
                textoEstado = "Bajo: " + stock;
            }
            else
            {
                fondoEstado = Tema.ExitoSuave;
                colorEstado = Tema.Exito;
                textoEstado = stock.ToString("N0") + " disp.";
            }

            Panel estado = new Panel();
            estado.Location = new Point(168, 188);
            estado.Size = new Size(84, 26);
            estado.BackColor = fondoEstado;
            Tema.Redondear(estado, 13);

            Label estadoTexto = new Label();
            estadoTexto.Dock = DockStyle.Fill;
            estadoTexto.Font = Tema.Fuente(7.5F, FontStyle.Bold);
            estadoTexto.ForeColor = colorEstado;
            estadoTexto.Text = textoEstado;
            estadoTexto.TextAlign = ContentAlignment.MiddleCenter;
            estadoTexto.BackColor = Color.Transparent;

            iconoFondo.Controls.Add(icono);
            estado.Controls.Add(estadoTexto);

            tarjeta.Controls.Add(estado);
            tarjeta.Controls.Add(precioEtiqueta);
            tarjeta.Controls.Add(precioTitulo);
            tarjeta.Controls.Add(descripcionEtiqueta);
            tarjeta.Controls.Add(nombreEtiqueta);
            tarjeta.Controls.Add(categoriaEtiqueta);
            tarjeta.Controls.Add(codigoEtiqueta);
            tarjeta.Controls.Add(iconoFondo);

            return tarjeta;
        }

        private void MostrarEstadoVacio(string titulo, string detalle, bool error)
        {
            Panel tarjeta = new Panel();
            tarjeta.Width = 620;
            tarjeta.Height = 180;
            tarjeta.Margin = new Padding(10, 30, 10, 10);
            Tema.Tarjeta(tarjeta);

            Label icono = new Label();
            icono.Location = new Point(24, 26);
            icono.Size = new Size(42, 42);
            Tema.Icono(icono, error ? "\uEA39" : "\uE721", 18F, error ? Tema.Peligro : Tema.TextoSuave);

            Label tituloEtiqueta = new Label();
            tituloEtiqueta.AutoSize = true;
            tituloEtiqueta.Location = new Point(82, 26);
            tituloEtiqueta.Font = Tema.Fuente(12F, FontStyle.Bold);
            tituloEtiqueta.ForeColor = Tema.Marino;
            tituloEtiqueta.Text = titulo;

            Label detalleEtiqueta = new Label();
            detalleEtiqueta.AutoSize = false;
            detalleEtiqueta.Location = new Point(82, 56);
            detalleEtiqueta.Size = new Size(500, 42);
            detalleEtiqueta.Font = Tema.Fuente(9F);
            detalleEtiqueta.ForeColor = Tema.TextoSuave;
            detalleEtiqueta.Text = detalle;

            tarjeta.Controls.Add(detalleEtiqueta);
            tarjeta.Controls.Add(tituloEtiqueta);
            tarjeta.Controls.Add(icono);

            if (error)
            {
                Button reintentar = new Button();
                reintentar.Text = "Reintentar";
                reintentar.Location = new Point(82, 112);
                reintentar.Size = new Size(120, 36);
                Tema.EstilizarBoton(reintentar, TipoBoton.Primario);
                reintentar.Click += delegate
                {
                    CargarCategorias();
                    CargarProductos();
                };
                tarjeta.Controls.Add(reintentar);
            }

            flpProductos.Controls.Add(tarjeta);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            temporizadorBusqueda.Stop();
            temporizadorBusqueda.Start();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cargandoCategorias)
            {
                CargarProductos();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
