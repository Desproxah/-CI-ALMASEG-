namespace CIAlmaseg
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.pnlAcceso = new System.Windows.Forms.Panel();
            this.pnlTarjeta = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblAccesoDescripcion = new System.Windows.Forms.Label();
            this.pnlRoles = new System.Windows.Forms.Panel();
            this.btnRolAdministrador = new System.Windows.Forms.Button();
            this.btnRolCliente = new System.Windows.Forms.Button();
            this.pnlCredenciales = new System.Windows.Forms.Panel();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnVerClave = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.lblClienteTitulo = new System.Windows.Forms.Label();
            this.lblClienteDescripcion = new System.Windows.Forms.Label();
            this.btnVerCatalogo = new System.Windows.Forms.Button();
            this.lblConexion = new System.Windows.Forms.Label();
            this.lblPie = new System.Windows.Forms.Label();
            this.pnlMarca = new System.Windows.Forms.Panel();
            this.pnlMonograma = new System.Windows.Forms.Panel();
            this.lblMonograma = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblMarcaSub = new System.Windows.Forms.Label();
            this.lblHero = new System.Windows.Forms.Label();
            this.lblHeroDescripcion = new System.Windows.Forms.Label();
            this.lblIconoInventario = new System.Windows.Forms.Label();
            this.lblTextoInventario = new System.Windows.Forms.Label();
            this.lblIconoVentas = new System.Windows.Forms.Label();
            this.lblTextoVentas = new System.Windows.Forms.Label();
            this.lblIconoReportes = new System.Windows.Forms.Label();
            this.lblTextoReportes = new System.Windows.Forms.Label();
            this.lblMarcaPie = new System.Windows.Forms.Label();
            this.pnlAcceso.SuspendLayout();
            this.pnlTarjeta.SuspendLayout();
            this.pnlRoles.SuspendLayout();
            this.pnlCredenciales.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.pnlMarca.SuspendLayout();
            this.pnlMonograma.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAcceso
            // 
            this.pnlAcceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnlAcceso.Controls.Add(this.pnlTarjeta);
            this.pnlAcceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAcceso.Location = new System.Drawing.Point(440, 0);
            this.pnlAcceso.Name = "pnlAcceso";
            this.pnlAcceso.Size = new System.Drawing.Size(640, 680);
            this.pnlAcceso.TabIndex = 1;
            this.pnlAcceso.Resize += new System.EventHandler(this.pnlAcceso_Resize);
            // 
            // pnlTarjeta
            // 
            this.pnlTarjeta.BackColor = System.Drawing.Color.White;
            this.pnlTarjeta.Controls.Add(this.lblBienvenida);
            this.pnlTarjeta.Controls.Add(this.lblAccesoDescripcion);
            this.pnlTarjeta.Controls.Add(this.pnlRoles);
            this.pnlTarjeta.Controls.Add(this.pnlCredenciales);
            this.pnlTarjeta.Controls.Add(this.pnlCliente);
            this.pnlTarjeta.Controls.Add(this.lblConexion);
            this.pnlTarjeta.Controls.Add(this.lblPie);
            this.pnlTarjeta.Location = new System.Drawing.Point(90, 60);
            this.pnlTarjeta.Name = "pnlTarjeta";
            this.pnlTarjeta.Size = new System.Drawing.Size(460, 560);
            this.pnlTarjeta.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(42)))), ((int)(((byte)(71)))));
            this.lblBienvenida.Location = new System.Drawing.Point(36, 34);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(260, 41);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido de nuevo";
            // 
            // lblAccesoDescripcion
            // 
            this.lblAccesoDescripcion.AutoSize = true;
            this.lblAccesoDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAccesoDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAccesoDescripcion.Location = new System.Drawing.Point(38, 82);
            this.lblAccesoDescripcion.Name = "lblAccesoDescripcion";
            this.lblAccesoDescripcion.Size = new System.Drawing.Size(300, 17);
            this.lblAccesoDescripcion.TabIndex = 1;
            this.lblAccesoDescripcion.Text = "Selecciona cómo quieres ingresar al sistema.";
            // 
            // pnlRoles
            // 
            this.pnlRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.pnlRoles.Controls.Add(this.btnRolAdministrador);
            this.pnlRoles.Controls.Add(this.btnRolCliente);
            this.pnlRoles.Location = new System.Drawing.Point(40, 120);
            this.pnlRoles.Name = "pnlRoles";
            this.pnlRoles.Size = new System.Drawing.Size(380, 50);
            this.pnlRoles.TabIndex = 2;
            // 
            // btnRolAdministrador
            // 
            this.btnRolAdministrador.FlatAppearance.BorderSize = 0;
            this.btnRolAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolAdministrador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRolAdministrador.Location = new System.Drawing.Point(4, 4);
            this.btnRolAdministrador.Name = "btnRolAdministrador";
            this.btnRolAdministrador.Size = new System.Drawing.Size(184, 42);
            this.btnRolAdministrador.TabIndex = 0;
            this.btnRolAdministrador.Text = "Administrador";
            this.btnRolAdministrador.UseVisualStyleBackColor = false;
            this.btnRolAdministrador.Click += new System.EventHandler(this.btnRolAdministrador_Click);
            // 
            // btnRolCliente
            // 
            this.btnRolCliente.FlatAppearance.BorderSize = 0;
            this.btnRolCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnRolCliente.Location = new System.Drawing.Point(192, 4);
            this.btnRolCliente.Name = "btnRolCliente";
            this.btnRolCliente.Size = new System.Drawing.Size(184, 42);
            this.btnRolCliente.TabIndex = 1;
            this.btnRolCliente.Text = "Catálogo";
            this.btnRolCliente.UseVisualStyleBackColor = false;
            this.btnRolCliente.Click += new System.EventHandler(this.btnRolCliente_Click);
            // 
            // pnlCredenciales
            // 
            this.pnlCredenciales.Controls.Add(this.lblCorreo);
            this.pnlCredenciales.Controls.Add(this.txtCorreo);
            this.pnlCredenciales.Controls.Add(this.lblClave);
            this.pnlCredenciales.Controls.Add(this.txtClave);
            this.pnlCredenciales.Controls.Add(this.btnVerClave);
            this.pnlCredenciales.Controls.Add(this.lblError);
            this.pnlCredenciales.Controls.Add(this.btnIngresar);
            this.pnlCredenciales.Location = new System.Drawing.Point(40, 196);
            this.pnlCredenciales.Name = "pnlCredenciales";
            this.pnlCredenciales.Size = new System.Drawing.Size(380, 286);
            this.pnlCredenciales.TabIndex = 3;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblCorreo.Location = new System.Drawing.Point(0, 4);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(108, 15);
            this.lblCorreo.TabIndex = 0;
            this.lblCorreo.Text = "Correo electrónico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCorreo.Location = new System.Drawing.Point(0, 25);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(380, 25);
            this.txtCorreo.TabIndex = 1;
            this.txtCorreo.TextChanged += new System.EventHandler(this.LimpiarError);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblClave.Location = new System.Drawing.Point(0, 78);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(66, 15);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Contraseña";
            // 
            // txtClave
            // 
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtClave.Location = new System.Drawing.Point(0, 99);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(330, 25);
            this.txtClave.TabIndex = 3;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.TextChanged += new System.EventHandler(this.LimpiarError);
            // 
            // btnVerClave
            // 
            this.btnVerClave.FlatAppearance.BorderSize = 0;
            this.btnVerClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerClave.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnVerClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnVerClave.Location = new System.Drawing.Point(334, 99);
            this.btnVerClave.Name = "btnVerClave";
            this.btnVerClave.Size = new System.Drawing.Size(46, 25);
            this.btnVerClave.TabIndex = 4;
            this.btnVerClave.Text = "Ver";
            this.btnVerClave.UseVisualStyleBackColor = false;
            this.btnVerClave.Click += new System.EventHandler(this.btnVerClave_Click);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblError.Location = new System.Drawing.Point(0, 142);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(380, 44);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "Mensaje de error";
            this.lblError.Visible = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(0, 205);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(380, 44);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar al panel";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.lblClienteTitulo);
            this.pnlCliente.Controls.Add(this.lblClienteDescripcion);
            this.pnlCliente.Controls.Add(this.btnVerCatalogo);
            this.pnlCliente.Location = new System.Drawing.Point(40, 196);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(380, 286);
            this.pnlCliente.TabIndex = 4;
            this.pnlCliente.Visible = false;
            // 
            // lblClienteTitulo
            // 
            this.lblClienteTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblClienteTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(42)))), ((int)(((byte)(71)))));
            this.lblClienteTitulo.Location = new System.Drawing.Point(0, 22);
            this.lblClienteTitulo.Name = "lblClienteTitulo";
            this.lblClienteTitulo.Size = new System.Drawing.Size(380, 36);
            this.lblClienteTitulo.TabIndex = 0;
            this.lblClienteTitulo.Text = "Explora nuestro catálogo";
            // 
            // lblClienteDescripcion
            // 
            this.lblClienteDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblClienteDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblClienteDescripcion.Location = new System.Drawing.Point(0, 66);
            this.lblClienteDescripcion.Name = "lblClienteDescripcion";
            this.lblClienteDescripcion.Size = new System.Drawing.Size(360, 70);
            this.lblClienteDescripcion.TabIndex = 1;
            this.lblClienteDescripcion.Text = "Consulta precios, descripciones y existencias sin necesidad de iniciar sesión.";
            // 
            // btnVerCatalogo
            // 
            this.btnVerCatalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnVerCatalogo.FlatAppearance.BorderSize = 0;
            this.btnVerCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCatalogo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVerCatalogo.ForeColor = System.Drawing.Color.White;
            this.btnVerCatalogo.Location = new System.Drawing.Point(0, 205);
            this.btnVerCatalogo.Name = "btnVerCatalogo";
            this.btnVerCatalogo.Size = new System.Drawing.Size(380, 44);
            this.btnVerCatalogo.TabIndex = 2;
            this.btnVerCatalogo.Text = "Ver catálogo de productos";
            this.btnVerCatalogo.UseVisualStyleBackColor = false;
            this.btnVerCatalogo.Click += new System.EventHandler(this.btnVerCatalogo_Click);
            // 
            // lblConexion
            // 
            this.lblConexion.AutoSize = true;
            this.lblConexion.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblConexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblConexion.Location = new System.Drawing.Point(40, 500);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(113, 13);
            this.lblConexion.TabIndex = 5;
            this.lblConexion.Text = "● Verificando conexión...";
            // 
            // lblPie
            // 
            this.lblPie.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblPie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblPie.Location = new System.Drawing.Point(40, 522);
            this.lblPie.Name = "lblPie";
            this.lblPie.Size = new System.Drawing.Size(380, 18);
            this.lblPie.TabIndex = 6;
            this.lblPie.Text = "© 2026 CI Almaseg S.A.S. · Todos los derechos reservados.";
            // 
            // pnlMarca
            // 
            this.pnlMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(42)))), ((int)(((byte)(71)))));
            this.pnlMarca.Controls.Add(this.pnlMonograma);
            this.pnlMarca.Controls.Add(this.lblMarca);
            this.pnlMarca.Controls.Add(this.lblMarcaSub);
            this.pnlMarca.Controls.Add(this.lblHero);
            this.pnlMarca.Controls.Add(this.lblHeroDescripcion);
            this.pnlMarca.Controls.Add(this.lblIconoInventario);
            this.pnlMarca.Controls.Add(this.lblTextoInventario);
            this.pnlMarca.Controls.Add(this.lblIconoVentas);
            this.pnlMarca.Controls.Add(this.lblTextoVentas);
            this.pnlMarca.Controls.Add(this.lblIconoReportes);
            this.pnlMarca.Controls.Add(this.lblTextoReportes);
            this.pnlMarca.Controls.Add(this.lblMarcaPie);
            this.pnlMarca.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMarca.Location = new System.Drawing.Point(0, 0);
            this.pnlMarca.Name = "pnlMarca";
            this.pnlMarca.Size = new System.Drawing.Size(440, 680);
            this.pnlMarca.TabIndex = 0;
            this.pnlMarca.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMarca_Paint);
            // 
            // pnlMonograma
            // 
            this.pnlMonograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.pnlMonograma.Controls.Add(this.lblMonograma);
            this.pnlMonograma.Location = new System.Drawing.Point(48, 48);
            this.pnlMonograma.Name = "pnlMonograma";
            this.pnlMonograma.Size = new System.Drawing.Size(46, 46);
            this.pnlMonograma.TabIndex = 0;
            // 
            // lblMonograma
            // 
            this.lblMonograma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonograma.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblMonograma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(42)))), ((int)(((byte)(71)))));
            this.lblMonograma.Location = new System.Drawing.Point(0, 0);
            this.lblMonograma.Name = "lblMonograma";
            this.lblMonograma.Size = new System.Drawing.Size(46, 46);
            this.lblMonograma.TabIndex = 0;
            this.lblMonograma.Text = "CI";
            this.lblMonograma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(108, 46);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(151, 36);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "ALMASEG";
            // 
            // lblMarcaSub
            // 
            this.lblMarcaSub.AutoSize = true;
            this.lblMarcaSub.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblMarcaSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblMarcaSub.Location = new System.Drawing.Point(111, 80);
            this.lblMarcaSub.Name = "lblMarcaSub";
            this.lblMarcaSub.Size = new System.Drawing.Size(150, 12);
            this.lblMarcaSub.TabIndex = 2;
            this.lblMarcaSub.Text = "FERRETERÍA & SUMINISTROS";
            // 
            // lblHero
            // 
            this.lblHero.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Bold);
            this.lblHero.ForeColor = System.Drawing.Color.White;
            this.lblHero.Location = new System.Drawing.Point(44, 196);
            this.lblHero.Name = "lblHero";
            this.lblHero.Size = new System.Drawing.Size(356, 128);
            this.lblHero.TabIndex = 3;
            this.lblHero.Text = "Todo tu negocio,\r\nen un solo lugar.";
            // 
            // lblHeroDescripcion
            // 
            this.lblHeroDescripcion.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblHeroDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblHeroDescripcion.Location = new System.Drawing.Point(48, 326);
            this.lblHeroDescripcion.Name = "lblHeroDescripcion";
            this.lblHeroDescripcion.Size = new System.Drawing.Size(340, 54);
            this.lblHeroDescripcion.TabIndex = 4;
            this.lblHeroDescripcion.Text = "Ventas, compras, inventario y reportes con una experiencia clara y profesional.";
            // 
            // lblIconoInventario
            // 
            this.lblIconoInventario.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F);
            this.lblIconoInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblIconoInventario.Location = new System.Drawing.Point(48, 420);
            this.lblIconoInventario.Name = "lblIconoInventario";
            this.lblIconoInventario.Size = new System.Drawing.Size(28, 28);
            this.lblIconoInventario.TabIndex = 5;
            this.lblIconoInventario.Text = "";
            this.lblIconoInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextoInventario
            // 
            this.lblTextoInventario.AutoSize = true;
            this.lblTextoInventario.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTextoInventario.ForeColor = System.Drawing.Color.White;
            this.lblTextoInventario.Location = new System.Drawing.Point(84, 426);
            this.lblTextoInventario.Name = "lblTextoInventario";
            this.lblTextoInventario.Size = new System.Drawing.Size(157, 17);
            this.lblTextoInventario.TabIndex = 6;
            this.lblTextoInventario.Text = "Control de inventario en tiempo real";
            // 
            // lblIconoVentas
            // 
            this.lblIconoVentas.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F);
            this.lblIconoVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblIconoVentas.Location = new System.Drawing.Point(48, 468);
            this.lblIconoVentas.Name = "lblIconoVentas";
            this.lblIconoVentas.Size = new System.Drawing.Size(28, 28);
            this.lblIconoVentas.TabIndex = 7;
            this.lblIconoVentas.Text = "";
            this.lblIconoVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextoVentas
            // 
            this.lblTextoVentas.AutoSize = true;
            this.lblTextoVentas.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTextoVentas.ForeColor = System.Drawing.Color.White;
            this.lblTextoVentas.Location = new System.Drawing.Point(84, 474);
            this.lblTextoVentas.Name = "lblTextoVentas";
            this.lblTextoVentas.Size = new System.Drawing.Size(205, 17);
            this.lblTextoVentas.TabIndex = 8;
            this.lblTextoVentas.Text = "Ventas y compras siempre conectadas";
            // 
            // lblIconoReportes
            // 
            this.lblIconoReportes.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F);
            this.lblIconoReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblIconoReportes.Location = new System.Drawing.Point(48, 516);
            this.lblIconoReportes.Name = "lblIconoReportes";
            this.lblIconoReportes.Size = new System.Drawing.Size(28, 28);
            this.lblIconoReportes.TabIndex = 9;
            this.lblIconoReportes.Text = "";
            this.lblIconoReportes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextoReportes
            // 
            this.lblTextoReportes.AutoSize = true;
            this.lblTextoReportes.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTextoReportes.ForeColor = System.Drawing.Color.White;
            this.lblTextoReportes.Location = new System.Drawing.Point(84, 522);
            this.lblTextoReportes.Name = "lblTextoReportes";
            this.lblTextoReportes.Size = new System.Drawing.Size(187, 17);
            this.lblTextoReportes.TabIndex = 10;
            this.lblTextoReportes.Text = "Reportes claros para decidir mejor";
            // 
            // lblMarcaPie
            // 
            this.lblMarcaPie.AutoSize = true;
            this.lblMarcaPie.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMarcaPie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblMarcaPie.Location = new System.Drawing.Point(48, 630);
            this.lblMarcaPie.Name = "lblMarcaPie";
            this.lblMarcaPie.Size = new System.Drawing.Size(228, 13);
            this.lblMarcaPie.TabIndex = 11;
            this.lblMarcaPie.Text = "CI ALMASEG S.A.S. · Ferretería y suministros";
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1080, 680);
            this.Controls.Add(this.pnlAcceso);
            this.Controls.Add(this.pnlMarca);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(980, 640);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CI Almaseg · Iniciar sesión";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.Shown += new System.EventHandler(this.FrmLogin_Shown);
            this.pnlAcceso.ResumeLayout(false);
            this.pnlTarjeta.ResumeLayout(false);
            this.pnlTarjeta.PerformLayout();
            this.pnlRoles.ResumeLayout(false);
            this.pnlCredenciales.ResumeLayout(false);
            this.pnlCredenciales.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.pnlMarca.ResumeLayout(false);
            this.pnlMarca.PerformLayout();
            this.pnlMonograma.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAcceso;
        private System.Windows.Forms.Panel pnlTarjeta;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblAccesoDescripcion;
        private System.Windows.Forms.Panel pnlRoles;
        private System.Windows.Forms.Button btnRolAdministrador;
        private System.Windows.Forms.Button btnRolCliente;
        private System.Windows.Forms.Panel pnlCredenciales;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnVerClave;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Label lblClienteTitulo;
        private System.Windows.Forms.Label lblClienteDescripcion;
        private System.Windows.Forms.Button btnVerCatalogo;
        private System.Windows.Forms.Label lblConexion;
        private System.Windows.Forms.Label lblPie;
        private System.Windows.Forms.Panel pnlMarca;
        private System.Windows.Forms.Panel pnlMonograma;
        private System.Windows.Forms.Label lblMonograma;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblMarcaSub;
        private System.Windows.Forms.Label lblHero;
        private System.Windows.Forms.Label lblHeroDescripcion;
        private System.Windows.Forms.Label lblIconoInventario;
        private System.Windows.Forms.Label lblTextoInventario;
        private System.Windows.Forms.Label lblIconoVentas;
        private System.Windows.Forms.Label lblTextoVentas;
        private System.Windows.Forms.Label lblIconoReportes;
        private System.Windows.Forms.Label lblTextoReportes;
        private System.Windows.Forms.Label lblMarcaPie;
    }
}
