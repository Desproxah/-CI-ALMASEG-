namespace CIAlmaseg
{
    partial class FrmProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.nudStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.lblStockActualTexto = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMinimo)).BeginInit();
            this.pnlFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.label1);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1184, 75);
            this.pnlEncabezado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registrar información comercial y controlar existencias";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(35, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(251, 29);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Registro de productos";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(30, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(30, 50);
            this.txtCodigo.MaxLength = 30;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(250, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(310, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(310, 50);
            this.txtNombre.MaxLength = 120;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(430, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(770, 25);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(770, 50);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(290, 21);
            this.cmbCategoria.TabIndex = 5;
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Location = new System.Drawing.Point(30, 110);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(90, 13);
            this.lblPrecioCompra.TabIndex = 6;
            this.lblPrecioCompra.Text = "Precio de compra";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(365, 135);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.ReadOnly = true;
            this.txtPrecioVenta.Size = new System.Drawing.Size(300, 20);
            this.txtPrecioVenta.TabIndex = 7;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(30, 135);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(300, 20);
            this.txtPrecioCompra.TabIndex = 8;
            this.txtPrecioCompra.TextChanged += new System.EventHandler(this.txtPrecioCompra_TextChanged);
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(365, 110);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(82, 13);
            this.lblPrecioVenta.TabIndex = 9;
            this.lblPrecioVenta.Text = "Precio de venta";
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Location = new System.Drawing.Point(700, 110);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(72, 13);
            this.lblStockMinimo.TabIndex = 10;
            this.lblStockMinimo.Text = "Stock mínimo";
            // 
            // nudStockMinimo
            // 
            this.nudStockMinimo.Location = new System.Drawing.Point(700, 135);
            this.nudStockMinimo.Name = "nudStockMinimo";
            this.nudStockMinimo.Size = new System.Drawing.Size(200, 20);
            this.nudStockMinimo.TabIndex = 11;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(30, 195);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(30, 220);
            this.txtDescripcion.MaxLength = 500;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(650, 75);
            this.txtDescripcion.TabIndex = 15;
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormulario.Controls.Add(this.btnEditar);
            this.pnlFormulario.Controls.Add(this.lblStockActual);
            this.pnlFormulario.Controls.Add(this.lblStockActualTexto);
            this.pnlFormulario.Controls.Add(this.chkEstado);
            this.pnlFormulario.Controls.Add(this.txtDescripcion);
            this.pnlFormulario.Controls.Add(this.lblDescripcion);
            this.pnlFormulario.Controls.Add(this.nudStockMinimo);
            this.pnlFormulario.Controls.Add(this.lblStockMinimo);
            this.pnlFormulario.Controls.Add(this.lblPrecioVenta);
            this.pnlFormulario.Controls.Add(this.txtPrecioCompra);
            this.pnlFormulario.Controls.Add(this.txtPrecioVenta);
            this.pnlFormulario.Controls.Add(this.lblPrecioCompra);
            this.pnlFormulario.Controls.Add(this.cmbCategoria);
            this.pnlFormulario.Controls.Add(this.lblCategoria);
            this.pnlFormulario.Controls.Add(this.txtNombre);
            this.pnlFormulario.Controls.Add(this.lblNombre);
            this.pnlFormulario.Controls.Add(this.txtCodigo);
            this.pnlFormulario.Controls.Add(this.lblCodigo);
            this.pnlFormulario.Location = new System.Drawing.Point(35, 100);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(1110, 350);
            this.pnlFormulario.TabIndex = 3;
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockActual.Location = new System.Drawing.Point(330, 312);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(76, 16);
            this.lblStockActual.TabIndex = 18;
            this.lblStockActual.Text = " 0 unidades";
            // 
            // lblStockActualTexto
            // 
            this.lblStockActualTexto.AutoSize = true;
            this.lblStockActualTexto.Location = new System.Drawing.Point(230, 312);
            this.lblStockActualTexto.Name = "lblStockActualTexto";
            this.lblStockActualTexto.Size = new System.Drawing.Size(70, 13);
            this.lblStockActualTexto.TabIndex = 17;
            this.lblStockActualTexto.Text = "Stock actual:";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(30, 310);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(101, 17);
            this.chkEstado.TabIndex = 16;
            this.chkEstado.Text = "Producto activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(540, 470);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(150, 45);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(710, 470);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 45);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(880, 470);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 45);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(35, 535);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(1110, 124);
            this.dgvProductos.TabIndex = 22;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(844, 250);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 45);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CI Almaseg - Gestión de productos";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMinimo)).EndInit();
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.NumericUpDown nudStockMinimo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.Label lblStockActualTexto;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnEditar;
    }
}