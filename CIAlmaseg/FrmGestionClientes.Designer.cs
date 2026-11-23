namespace CIAlmaseg
{
    partial class FrmGestionClientes
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
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.pnlFormulario.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormulario.Controls.Add(this.btnGuardar);
            this.pnlFormulario.Controls.Add(this.btnCancelar);
            this.pnlFormulario.Controls.Add(this.btnNuevo);
            this.pnlFormulario.Controls.Add(this.chkEstado);
            this.pnlFormulario.Controls.Add(this.lblDireccion);
            this.pnlFormulario.Controls.Add(this.txtDireccion);
            this.pnlFormulario.Controls.Add(this.txtCiudad);
            this.pnlFormulario.Controls.Add(this.lblCiudad);
            this.pnlFormulario.Controls.Add(this.txtTelefono);
            this.pnlFormulario.Controls.Add(this.lblTelefono);
            this.pnlFormulario.Controls.Add(this.txtNombre);
            this.pnlFormulario.Controls.Add(this.lblNombre);
            this.pnlFormulario.Controls.Add(this.txtNumeroDocumento);
            this.pnlFormulario.Controls.Add(this.lblNumeroDocumento);
            this.pnlFormulario.Controls.Add(this.cmbTipoDocumento);
            this.pnlFormulario.Controls.Add(this.lblTipoDocumento);
            this.pnlFormulario.Location = new System.Drawing.Point(35, 100);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(1010, 300);
            this.pnlFormulario.TabIndex = 0;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1084, 80);
            this.pnlEncabezado.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(35, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(227, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de clientes";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(37, 50);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(285, 16);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Crear y actualizar la información de los clientes";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(30, 25);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(99, 13);
            this.lblTipoDocumento.TabIndex = 0;
            this.lblTipoDocumento.Text = "Tipo de documento";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Items.AddRange(new object[] {
            "Cédula de ciudadanía",
            "",
            "Cédula de extranjería",
            "",
            "NIT",
            "",
            "Pasaporte"});
            this.cmbTipoDocumento.Location = new System.Drawing.Point(30, 50);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(280, 21);
            this.cmbTipoDocumento.TabIndex = 1;
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(350, 25);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(115, 13);
            this.lblNumeroDocumento.TabIndex = 2;
            this.lblNumeroDocumento.Text = "Número de documento";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(350, 50);
            this.txtNumeroDocumento.MaxLength = 30;
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(280, 20);
            this.txtNumeroDocumento.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(670, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre completo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(670, 50);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(30, 110);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(30, 135);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(280, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(350, 110);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 8;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(350, 135);
            this.txtCiudad.MaxLength = 80;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(280, 20);
            this.txtCiudad.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(670, 135);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(280, 20);
            this.txtDireccion.TabIndex = 10;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(670, 110);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 11;
            this.lblDireccion.Text = "Dirección";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(30, 210);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(90, 17);
            this.chkEstado.TabIndex = 12;
            this.chkEstado.Text = "Cliente activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(420, 220);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(150, 45);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(590, 220);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 45);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(760, 220);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(190, 45);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(35, 425);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(1010, 160);
            this.dgvClientes.TabIndex = 2;
            // 
            // FrmGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.pnlFormulario);
            this.Name = "FrmGestionClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CI Almaseg - Gestión de clientes";
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}