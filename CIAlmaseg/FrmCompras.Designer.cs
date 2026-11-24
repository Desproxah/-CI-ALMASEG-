namespace CIAlmaseg
{
    partial class FrmCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabCompras = new System.Windows.Forms.TabControl();
            this.paginaNueva = new System.Windows.Forms.TabPage();
            this.paginaHistorial = new System.Windows.Forms.TabPage();
            this.pnlCompra = new System.Windows.Forms.Panel();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtCostoUnitario = new System.Windows.Forms.TextBox();
            this.lblCostoUnitario = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.lblTotalTexto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.btnNuevaCompra = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmarCompra = new System.Windows.Forms.Button();
            this.lblHistorialTitulo = new System.Windows.Forms.Label();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.lblDetalleTitulo = new System.Windows.Forms.Label();
            this.dgvDetalleHistorial = new System.Windows.Forms.DataGridView();
            this.lblResumenHistorial = new System.Windows.Forms.Label();
            this.pnlEncabezado.SuspendLayout();
            this.tabCompras.SuspendLayout();
            this.paginaNueva.SuspendLayout();
            this.paginaHistorial.SuspendLayout();
            this.pnlCompra.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1440, 80);
            this.pnlEncabezado.TabIndex = 2;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(37, 50);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(342, 16);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Registrar productos comprados y actualizar el inventario";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(35, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(237, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de compras";
            // 
            // tabCompras
            // 
            this.tabCompras.Controls.Add(this.paginaNueva);
            this.tabCompras.Controls.Add(this.paginaHistorial);
            this.tabCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCompras.Location = new System.Drawing.Point(0, 80);
            this.tabCompras.Name = "tabCompras";
            this.tabCompras.SelectedIndex = 0;
            this.tabCompras.Size = new System.Drawing.Size(1440, 740);
            this.tabCompras.TabIndex = 3;
            // 
            // paginaNueva
            // 
            this.paginaNueva.Controls.Add(this.btnConfirmarCompra);
            this.paginaNueva.Controls.Add(this.btnCancelar);
            this.paginaNueva.Controls.Add(this.btnNuevaCompra);
            this.paginaNueva.Controls.Add(this.btnEliminarDetalle);
            this.paginaNueva.Controls.Add(this.lblTotal);
            this.paginaNueva.Controls.Add(this.lblTotalTexto);
            this.paginaNueva.Controls.Add(this.dgvDetalleCompra);
            this.paginaNueva.Controls.Add(this.pnlDetalle);
            this.paginaNueva.Controls.Add(this.pnlCompra);
            this.paginaNueva.Location = new System.Drawing.Point(4, 25);
            this.paginaNueva.Name = "paginaNueva";
            this.paginaNueva.Padding = new System.Windows.Forms.Padding(3);
            this.paginaNueva.Size = new System.Drawing.Size(1432, 711);
            this.paginaNueva.TabIndex = 0;
            this.paginaNueva.Text = "Nueva compra";
            this.paginaNueva.UseVisualStyleBackColor = true;
            // 
            // paginaHistorial
            // 
            this.paginaHistorial.Controls.Add(this.lblResumenHistorial);
            this.paginaHistorial.Controls.Add(this.dgvDetalleHistorial);
            this.paginaHistorial.Controls.Add(this.lblDetalleTitulo);
            this.paginaHistorial.Controls.Add(this.dgvHistorial);
            this.paginaHistorial.Controls.Add(this.lblHistorialTitulo);
            this.paginaHistorial.Location = new System.Drawing.Point(4, 25);
            this.paginaHistorial.Name = "paginaHistorial";
            this.paginaHistorial.Padding = new System.Windows.Forms.Padding(3);
            this.paginaHistorial.Size = new System.Drawing.Size(1432, 711);
            this.paginaHistorial.TabIndex = 1;
            this.paginaHistorial.Text = "Historial de compras";
            this.paginaHistorial.UseVisualStyleBackColor = true;
            // 
            // pnlCompra
            // 
            this.pnlCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlCompra.Controls.Add(this.txtObservacion);
            this.pnlCompra.Controls.Add(this.lblObservacion);
            this.pnlCompra.Controls.Add(this.cmbEstado);
            this.pnlCompra.Controls.Add(this.lblEstado);
            this.pnlCompra.Controls.Add(this.dtpFecha);
            this.pnlCompra.Controls.Add(this.lblFecha);
            this.pnlCompra.Controls.Add(this.cmbProveedor);
            this.pnlCompra.Controls.Add(this.lblProveedor);
            this.pnlCompra.Location = new System.Drawing.Point(16, 12);
            this.pnlCompra.Name = "pnlCompra";
            this.pnlCompra.Size = new System.Drawing.Size(1400, 145);
            this.pnlCompra.TabIndex = 4;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(25, 20);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(63, 15);
            this.lblProveedor.TabIndex = 0;
            this.lblProveedor.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(25, 45);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(540, 23);
            this.cmbProveedor.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(600, 20);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 15);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(600, 45);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(230, 21);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(865, 20);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "REGISTRADA",
            "RECIBIDA",
            "CANCELADA"});
            this.cmbEstado.Location = new System.Drawing.Point(865, 45);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(260, 23);
            this.cmbEstado.TabIndex = 5;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(25, 92);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(75, 15);
            this.lblObservacion.TabIndex = 6;
            this.lblObservacion.Text = "Observación";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(130, 89);
            this.txtObservacion.MaxLength = 250;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(1245, 21);
            this.txtObservacion.TabIndex = 7;
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlDetalle.Controls.Add(this.lblStockActual);
            this.pnlDetalle.Controls.Add(this.btnAgregarProducto);
            this.pnlDetalle.Controls.Add(this.txtCostoUnitario);
            this.pnlDetalle.Controls.Add(this.lblCostoUnitario);
            this.pnlDetalle.Controls.Add(this.lblCantidad);
            this.pnlDetalle.Controls.Add(this.nudCantidad);
            this.pnlDetalle.Controls.Add(this.cmbProducto);
            this.pnlDetalle.Controls.Add(this.lblProducto);
            this.pnlDetalle.Location = new System.Drawing.Point(16, 170);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(1400, 130);
            this.pnlDetalle.TabIndex = 5;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(25, 18);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(56, 15);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto";
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(25, 42);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(520, 23);
            this.cmbProducto.TabIndex = 1;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(575, 18);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(56, 15);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(575, 42);
            this.nudCantidad.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(150, 21);
            this.nudCantidad.TabIndex = 3;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCostoUnitario
            // 
            this.lblCostoUnitario.AutoSize = true;
            this.lblCostoUnitario.Location = new System.Drawing.Point(750, 18);
            this.lblCostoUnitario.Name = "lblCostoUnitario";
            this.lblCostoUnitario.Size = new System.Drawing.Size(82, 15);
            this.lblCostoUnitario.TabIndex = 4;
            this.lblCostoUnitario.Text = "Costo unitario";
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.Location = new System.Drawing.Point(750, 42);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(220, 21);
            this.txtCostoUnitario.TabIndex = 5;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Location = new System.Drawing.Point(1185, 36);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(190, 42);
            this.btnAgregarProducto.TabIndex = 6;
            this.btnAgregarProducto.Text = "AGREGAR";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Location = new System.Drawing.Point(25, 92);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(140, 15);
            this.lblStockActual.TabIndex = 7;
            this.lblStockActual.Text = "Stock actual: 0 unidades";
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.AllowUserToAddRows = false;
            this.dgvDetalleCompra.AllowUserToDeleteRows = false;
            this.dgvDetalleCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleCompra.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Location = new System.Drawing.Point(16, 316);
            this.dgvDetalleCompra.MultiSelect = false;
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.ReadOnly = true;
            this.dgvDetalleCompra.RowHeadersVisible = false;
            this.dgvDetalleCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(1400, 180);
            this.dgvDetalleCompra.TabIndex = 6;
            // 
            // lblTotalTexto
            // 
            this.lblTotalTexto.AutoSize = true;
            this.lblTotalTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTexto.Location = new System.Drawing.Point(950, 514);
            this.lblTotalTexto.Name = "lblTotalTexto";
            this.lblTotalTexto.Size = new System.Drawing.Size(143, 20);
            this.lblTotalTexto.TabIndex = 7;
            this.lblTotalTexto.Text = "Total de la compra:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1110, 511);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 24);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "$ 0";
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDetalle.Location = new System.Drawing.Point(16, 552);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(200, 45);
            this.btnEliminarDetalle.TabIndex = 9;
            this.btnEliminarDetalle.Text = "ELIMINAR PRODUCTO";
            this.btnEliminarDetalle.UseVisualStyleBackColor = true;
            // 
            // btnNuevaCompra
            // 
            this.btnNuevaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCompra.Location = new System.Drawing.Point(954, 552);
            this.btnNuevaCompra.Name = "btnNuevaCompra";
            this.btnNuevaCompra.Size = new System.Drawing.Size(130, 45);
            this.btnNuevaCompra.TabIndex = 10;
            this.btnNuevaCompra.Text = "NUEVA";
            this.btnNuevaCompra.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(1094, 552);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 45);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarCompra.Location = new System.Drawing.Point(1234, 552);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(182, 45);
            this.btnConfirmarCompra.TabIndex = 12;
            this.btnConfirmarCompra.Text = "CONFIRMAR COMPRA";
            this.btnConfirmarCompra.UseVisualStyleBackColor = true;
            // 
            // lblHistorialTitulo
            // 
            this.lblHistorialTitulo.AutoSize = true;
            this.lblHistorialTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialTitulo.Location = new System.Drawing.Point(16, 16);
            this.lblHistorialTitulo.Name = "lblHistorialTitulo";
            this.lblHistorialTitulo.Size = new System.Drawing.Size(149, 20);
            this.lblHistorialTitulo.TabIndex = 0;
            this.lblHistorialTitulo.Text = "Compras registradas";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(16, 46);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(1400, 240);
            this.dgvHistorial.TabIndex = 1;
            // 
            // lblDetalleTitulo
            // 
            this.lblDetalleTitulo.AutoSize = true;
            this.lblDetalleTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleTitulo.Location = new System.Drawing.Point(16, 300);
            this.lblDetalleTitulo.Name = "lblDetalleTitulo";
            this.lblDetalleTitulo.Size = new System.Drawing.Size(251, 20);
            this.lblDetalleTitulo.TabIndex = 2;
            this.lblDetalleTitulo.Text = "Detalle de la compra seleccionada";
            // 
            // dgvDetalleHistorial
            // 
            this.dgvDetalleHistorial.AllowUserToAddRows = false;
            this.dgvDetalleHistorial.AllowUserToDeleteRows = false;
            this.dgvDetalleHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleHistorial.Location = new System.Drawing.Point(16, 330);
            this.dgvDetalleHistorial.MultiSelect = false;
            this.dgvDetalleHistorial.Name = "dgvDetalleHistorial";
            this.dgvDetalleHistorial.ReadOnly = true;
            this.dgvDetalleHistorial.RowHeadersVisible = false;
            this.dgvDetalleHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleHistorial.Size = new System.Drawing.Size(1400, 240);
            this.dgvDetalleHistorial.TabIndex = 3;
            // 
            // lblResumenHistorial
            // 
            this.lblResumenHistorial.AutoSize = true;
            this.lblResumenHistorial.Location = new System.Drawing.Point(16, 585);
            this.lblResumenHistorial.Name = "lblResumenHistorial";
            this.lblResumenHistorial.Size = new System.Drawing.Size(156, 15);
            this.lblResumenHistorial.TabIndex = 4;
            this.lblResumenHistorial.Text = "0 compras · $ 0 acumulado";
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 820);
            this.Controls.Add(this.tabCompras);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CI Almaseg - Registro de compras";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.tabCompras.ResumeLayout(false);
            this.paginaNueva.ResumeLayout(false);
            this.paginaNueva.PerformLayout();
            this.paginaHistorial.ResumeLayout(false);
            this.paginaHistorial.PerformLayout();
            this.pnlCompra.ResumeLayout(false);
            this.pnlCompra.PerformLayout();
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabCompras;
        private System.Windows.Forms.TabPage paginaNueva;
        private System.Windows.Forms.TabPage paginaHistorial;
        private System.Windows.Forms.Panel pnlCompra;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox txtCostoUnitario;
        private System.Windows.Forms.Label lblCostoUnitario;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private System.Windows.Forms.Label lblTotalTexto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEliminarDetalle;
        private System.Windows.Forms.Button btnNuevaCompra;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmarCompra;
        private System.Windows.Forms.Label lblHistorialTitulo;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label lblDetalleTitulo;
        private System.Windows.Forms.DataGridView dgvDetalleHistorial;
        private System.Windows.Forms.Label lblResumenHistorial;
    }
}
