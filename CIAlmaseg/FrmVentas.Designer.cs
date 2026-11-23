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
            this.pnlVenta = new System.Windows.Forms.Panel();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblStockDisponible = new System.Windows.Forms.Panel();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtValorVenta = new System.Windows.Forms.TextBox();
            this.lblValorVenta = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalTexto = new System.Windows.Forms.Label();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevaCompra = new System.Windows.Forms.Button();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            this.pnlVenta.SuspendLayout();
            this.lblStockDisponible.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
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
            // pnlVenta
            // 
            this.pnlVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVenta.Controls.Add(this.txtObservacion);
            this.pnlVenta.Controls.Add(this.lblObservacion);
            this.pnlVenta.Controls.Add(this.cmbEstado);
            this.pnlVenta.Controls.Add(this.lblEstado);
            this.pnlVenta.Controls.Add(this.dtpFecha);
            this.pnlVenta.Controls.Add(this.lblFecha);
            this.pnlVenta.Controls.Add(this.cmbCliente);
            this.pnlVenta.Controls.Add(this.lblCliente);
            this.pnlVenta.Location = new System.Drawing.Point(35, 100);
            this.pnlVenta.Name = "pnlVenta";
            this.pnlVenta.Size = new System.Drawing.Size(1180, 145);
            this.pnlVenta.TabIndex = 4;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(120, 87);
            this.txtObservacion.MaxLength = 250;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(925, 21);
            this.txtObservacion.TabIndex = 7;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(25, 90);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(75, 15);
            this.lblObservacion.TabIndex = 6;
            this.lblObservacion.Text = "Observación";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "REGISTRADA",
            "",
            "RECIBIDA",
            "",
            "CANCELADA"});
            this.cmbEstado.Location = new System.Drawing.Point(795, 45);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(250, 23);
            this.cmbEstado.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(795, 20);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(540, 45);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(220, 21);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(540, 20);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 15);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(25, 45);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(480, 23);
            this.cmbCliente.TabIndex = 1;
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
            // lblStockDisponible
            // 
            this.lblStockDisponible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStockDisponible.Controls.Add(this.lblStockActual);
            this.lblStockDisponible.Controls.Add(this.btnAgregarProducto);
            this.lblStockDisponible.Controls.Add(this.txtValorVenta);
            this.lblStockDisponible.Controls.Add(this.lblValorVenta);
            this.lblStockDisponible.Controls.Add(this.lblCantidad);
            this.lblStockDisponible.Controls.Add(this.nudCantidad);
            this.lblStockDisponible.Controls.Add(this.cmbProducto);
            this.lblStockDisponible.Controls.Add(this.lblProducto);
            this.lblStockDisponible.Location = new System.Drawing.Point(35, 265);
            this.lblStockDisponible.Name = "lblStockDisponible";
            this.lblStockDisponible.Size = new System.Drawing.Size(1180, 135);
            this.lblStockDisponible.TabIndex = 5;
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Location = new System.Drawing.Point(25, 95);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(164, 15);
            this.lblStockActual.TabIndex = 7;
            this.lblStockActual.Text = "Stock disponible: 0 unidades";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Location = new System.Drawing.Point(940, 40);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(180, 42);
            this.btnAgregarProducto.TabIndex = 6;
            this.btnAgregarProducto.Text = "AGREGAR";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // txtValorVenta
            // 
            this.txtValorVenta.Location = new System.Drawing.Point(700, 45);
            this.txtValorVenta.Name = "txtValorVenta";
            this.txtValorVenta.ReadOnly = true;
            this.txtValorVenta.Size = new System.Drawing.Size(200, 21);
            this.txtValorVenta.TabIndex = 5;
            // 
            // lblValorVenta
            // 
            this.lblValorVenta.AutoSize = true;
            this.lblValorVenta.Location = new System.Drawing.Point(700, 20);
            this.lblValorVenta.Name = "lblValorVenta";
            this.lblValorVenta.Size = new System.Drawing.Size(84, 15);
            this.lblValorVenta.TabIndex = 4;
            this.lblValorVenta.Text = "Valor de venta";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(510, 20);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(56, 15);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(510, 45);
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
            this.nudCantidad.TabIndex = 2;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(25, 45);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(450, 23);
            this.cmbProducto.TabIndex = 1;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(25, 20);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(56, 15);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto";
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.AllowUserToAddRows = false;
            this.dgvDetalleCompra.AllowUserToDeleteRows = false;
            this.dgvDetalleCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleCompra.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Location = new System.Drawing.Point(35, 420);
            this.dgvDetalleCompra.MultiSelect = false;
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.ReadOnly = true;
            this.dgvDetalleCompra.RowHeadersVisible = false;
            this.dgvDetalleCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(1180, 175);
            this.dgvDetalleCompra.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1030, 615);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 24);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "$ 0";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblTotalTexto
            // 
            this.lblTotalTexto.AutoSize = true;
            this.lblTotalTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTexto.Location = new System.Drawing.Point(840, 615);
            this.lblTotalTexto.Name = "lblTotalTexto";
            this.lblTotalTexto.Size = new System.Drawing.Size(129, 20);
            this.lblTotalTexto.TabIndex = 8;
            this.lblTotalTexto.Text = "Total de la venta:";
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarVenta.Location = new System.Drawing.Point(940, 650);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(275, 45);
            this.btnConfirmarVenta.TabIndex = 15;
            this.btnConfirmarVenta.Text = "CONFIRMAR VENTA";
            this.btnConfirmarVenta.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(770, 650);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 45);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevaCompra
            // 
            this.btnNuevaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCompra.Location = new System.Drawing.Point(600, 650);
            this.btnNuevaCompra.Name = "btnNuevaCompra";
            this.btnNuevaCompra.Size = new System.Drawing.Size(150, 45);
            this.btnNuevaCompra.TabIndex = 13;
            this.btnNuevaCompra.Text = "NUEVA";
            this.btnNuevaCompra.UseVisualStyleBackColor = true;
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDetalle.Location = new System.Drawing.Point(35, 650);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(190, 45);
            this.btnEliminarDetalle.TabIndex = 12;
            this.btnEliminarDetalle.Text = "ELIMINAR PRODUCTO";
            this.btnEliminarDetalle.UseVisualStyleBackColor = true;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 820);
            this.Controls.Add(this.btnConfirmarVenta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevaCompra);
            this.Controls.Add(this.btnEliminarDetalle);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalTexto);
            this.Controls.Add(this.dgvDetalleCompra);
            this.Controls.Add(this.lblStockDisponible);
            this.Controls.Add(this.pnlVenta);
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
            this.pnlVenta.ResumeLayout(false);
            this.pnlVenta.PerformLayout();
            this.lblStockDisponible.ResumeLayout(false);
            this.lblStockDisponible.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlVenta;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Panel lblStockDisponible;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox txtValorVenta;
        private System.Windows.Forms.Label lblValorVenta;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalTexto;
        private System.Windows.Forms.Button btnConfirmarVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevaCompra;
        private System.Windows.Forms.Button btnEliminarDetalle;
    }
}