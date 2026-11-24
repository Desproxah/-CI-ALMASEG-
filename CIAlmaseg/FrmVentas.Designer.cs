namespace CIAlmaseg
{
    partial class FrmVentas
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
            this.tabVentas = new System.Windows.Forms.TabControl();
            this.paginaNueva = new System.Windows.Forms.TabPage();
            this.paginaHistorial = new System.Windows.Forms.TabPage();
            this.pnlVenta = new System.Windows.Forms.Panel();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtValorVenta = new System.Windows.Forms.TextBox();
            this.lblValorVenta = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalTexto = new System.Windows.Forms.Label();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.lblHistorialTitulo = new System.Windows.Forms.Label();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.lblDetalleTitulo = new System.Windows.Forms.Label();
            this.dgvDetalleHistorial = new System.Windows.Forms.DataGridView();
            this.lblResumenHistorial = new System.Windows.Forms.Label();
            this.pnlEncabezado.SuspendLayout();
            this.tabVentas.SuspendLayout();
            this.paginaNueva.SuspendLayout();
            this.paginaHistorial.SuspendLayout();
            this.pnlVenta.SuspendLayout();
            this.pnlProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
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
            this.pnlEncabezado.TabIndex = 3;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(37, 50);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(329, 16);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Registrar productos vendidos y actualizar el inventario";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(35, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(213, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de ventas";
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.paginaNueva);
            this.tabVentas.Controls.Add(this.paginaHistorial);
            this.tabVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVentas.Location = new System.Drawing.Point(0, 80);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.SelectedIndex = 0;
            this.tabVentas.Size = new System.Drawing.Size(1440, 740);
            this.tabVentas.TabIndex = 4;
            // 
            // paginaNueva
            // 
            this.paginaNueva.Controls.Add(this.btnConfirmarVenta);
            this.paginaNueva.Controls.Add(this.btnCancelar);
            this.paginaNueva.Controls.Add(this.btnNueva);
            this.paginaNueva.Controls.Add(this.btnEliminarDetalle);
            this.paginaNueva.Controls.Add(this.lblTotal);
            this.paginaNueva.Controls.Add(this.lblTotalTexto);
            this.paginaNueva.Controls.Add(this.dgvDetalleVenta);
            this.paginaNueva.Controls.Add(this.pnlProducto);
            this.paginaNueva.Controls.Add(this.pnlVenta);
            this.paginaNueva.Location = new System.Drawing.Point(4, 25);
            this.paginaNueva.Name = "paginaNueva";
            this.paginaNueva.Padding = new System.Windows.Forms.Padding(3);
            this.paginaNueva.Size = new System.Drawing.Size(1432, 711);
            this.paginaNueva.TabIndex = 0;
            this.paginaNueva.Text = "Nueva venta";
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
            this.paginaHistorial.Text = "Historial de ventas";
            this.paginaHistorial.UseVisualStyleBackColor = true;
            // 
            // pnlVenta
            // 
            this.pnlVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlVenta.Controls.Add(this.txtObservacion);
            this.pnlVenta.Controls.Add(this.lblObservacion);
            this.pnlVenta.Controls.Add(this.cmbEstado);
            this.pnlVenta.Controls.Add(this.lblEstado);
            this.pnlVenta.Controls.Add(this.dtpFecha);
            this.pnlVenta.Controls.Add(this.lblFecha);
            this.pnlVenta.Controls.Add(this.cmbCliente);
            this.pnlVenta.Controls.Add(this.lblCliente);
            this.pnlVenta.Location = new System.Drawing.Point(16, 12);
            this.pnlVenta.Name = "pnlVenta";
            this.pnlVenta.Size = new System.Drawing.Size(1400, 145);
            this.pnlVenta.TabIndex = 4;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(25, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(45, 15);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(25, 45);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(540, 23);
            this.cmbCliente.TabIndex = 1;
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
            "COMPLETADA",
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
            // pnlProducto
            // 
            this.pnlProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlProducto.Controls.Add(this.lblStockActual);
            this.pnlProducto.Controls.Add(this.btnAgregarProducto);
            this.pnlProducto.Controls.Add(this.txtValorVenta);
            this.pnlProducto.Controls.Add(this.lblValorVenta);
            this.pnlProducto.Controls.Add(this.lblCantidad);
            this.pnlProducto.Controls.Add(this.nudCantidad);
            this.pnlProducto.Controls.Add(this.cmbProducto);
            this.pnlProducto.Controls.Add(this.lblProducto);
            this.pnlProducto.Location = new System.Drawing.Point(16, 170);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(1400, 130);
            this.pnlProducto.TabIndex = 5;
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
            // lblValorVenta
            // 
            this.lblValorVenta.AutoSize = true;
            this.lblValorVenta.Location = new System.Drawing.Point(750, 18);
            this.lblValorVenta.Name = "lblValorVenta";
            this.lblValorVenta.Size = new System.Drawing.Size(84, 15);
            this.lblValorVenta.TabIndex = 4;
            this.lblValorVenta.Text = "Valor de venta";
            // 
            // txtValorVenta
            // 
            this.txtValorVenta.Location = new System.Drawing.Point(750, 42);
            this.txtValorVenta.Name = "txtValorVenta";
            this.txtValorVenta.ReadOnly = true;
            this.txtValorVenta.Size = new System.Drawing.Size(220, 21);
            this.txtValorVenta.TabIndex = 5;
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
            this.lblStockActual.Size = new System.Drawing.Size(164, 15);
            this.lblStockActual.TabIndex = 7;
            this.lblStockActual.Text = "Stock disponible: 0 unidades";
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(16, 316);
            this.dgvDetalleVenta.MultiSelect = false;
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.RowHeadersVisible = false;
            this.dgvDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(1400, 180);
            this.dgvDetalleVenta.TabIndex = 6;
            // 
            // lblTotalTexto
            // 
            this.lblTotalTexto.AutoSize = true;
            this.lblTotalTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTexto.Location = new System.Drawing.Point(960, 514);
            this.lblTotalTexto.Name = "lblTotalTexto";
            this.lblTotalTexto.Size = new System.Drawing.Size(129, 20);
            this.lblTotalTexto.TabIndex = 8;
            this.lblTotalTexto.Text = "Total de la venta:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1110, 511);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 24);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "$ 0";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDetalle.Location = new System.Drawing.Point(16, 552);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(200, 45);
            this.btnEliminarDetalle.TabIndex = 12;
            this.btnEliminarDetalle.Text = "ELIMINAR PRODUCTO";
            this.btnEliminarDetalle.UseVisualStyleBackColor = true;
            // 
            // btnNueva
            // 
            this.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueva.Location = new System.Drawing.Point(954, 552);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(130, 45);
            this.btnNueva.TabIndex = 13;
            this.btnNueva.Text = "NUEVA";
            this.btnNueva.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(1094, 552);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 45);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarVenta.Location = new System.Drawing.Point(1234, 552);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(182, 45);
            this.btnConfirmarVenta.TabIndex = 15;
            this.btnConfirmarVenta.Text = "CONFIRMAR VENTA";
            this.btnConfirmarVenta.UseVisualStyleBackColor = true;
            // 
            // lblHistorialTitulo
            // 
            this.lblHistorialTitulo.AutoSize = true;
            this.lblHistorialTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialTitulo.Location = new System.Drawing.Point(16, 16);
            this.lblHistorialTitulo.Name = "lblHistorialTitulo";
            this.lblHistorialTitulo.Size = new System.Drawing.Size(145, 20);
            this.lblHistorialTitulo.TabIndex = 0;
            this.lblHistorialTitulo.Text = "Ventas registradas";
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
            this.lblDetalleTitulo.Size = new System.Drawing.Size(246, 20);
            this.lblDetalleTitulo.TabIndex = 2;
            this.lblDetalleTitulo.Text = "Detalle de la venta seleccionada";
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
            this.lblResumenHistorial.Size = new System.Drawing.Size(140, 15);
            this.lblResumenHistorial.TabIndex = 4;
            this.lblResumenHistorial.Text = "0 ventas · $ 0 acumulado";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 820);
            this.Controls.Add(this.tabVentas);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CI Almaseg - Registro de ventas";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.tabVentas.ResumeLayout(false);
            this.paginaNueva.ResumeLayout(false);
            this.paginaNueva.PerformLayout();
            this.paginaHistorial.ResumeLayout(false);
            this.paginaHistorial.PerformLayout();
            this.pnlVenta.ResumeLayout(false);
            this.pnlVenta.PerformLayout();
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabVentas;
        private System.Windows.Forms.TabPage paginaNueva;
        private System.Windows.Forms.TabPage paginaHistorial;
        private System.Windows.Forms.Panel pnlVenta;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox txtValorVenta;
        private System.Windows.Forms.Label lblValorVenta;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalTexto;
        private System.Windows.Forms.Button btnConfirmarVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnEliminarDetalle;
        private System.Windows.Forms.Label lblHistorialTitulo;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label lblDetalleTitulo;
        private System.Windows.Forms.DataGridView dgvDetalleHistorial;
        private System.Windows.Forms.Label lblResumenHistorial;
    }
}
