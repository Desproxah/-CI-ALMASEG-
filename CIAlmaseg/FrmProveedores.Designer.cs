namespace CIAlmaseg
{
    partial class FrmProveedores
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
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.lblNit = new System.Windows.Forms.Label();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1323, 80);
            this.pnlEncabezado.TabIndex = 2;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(37, 50);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(321, 16);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = " Administrar las empresas que suministran productos";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(35, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(281, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de proveedores";
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormulario.Controls.Add(this.btnEditar);
            this.pnlFormulario.Controls.Add(this.btnGuardar);
            this.pnlFormulario.Controls.Add(this.btnCancelar);
            this.pnlFormulario.Controls.Add(this.btnNuevo);
            this.pnlFormulario.Controls.Add(this.chkEstado);
            this.pnlFormulario.Controls.Add(this.txtDireccion);
            this.pnlFormulario.Controls.Add(this.lblDireccion);
            this.pnlFormulario.Controls.Add(this.txtCiudad);
            this.pnlFormulario.Controls.Add(this.lblCiudad);
            this.pnlFormulario.Controls.Add(this.txtCorreo);
            this.pnlFormulario.Controls.Add(this.lblCorreo);
            this.pnlFormulario.Controls.Add(this.txtTelefono);
            this.pnlFormulario.Controls.Add(this.lblTelefono);
            this.pnlFormulario.Controls.Add(this.txtRazonSocial);
            this.pnlFormulario.Controls.Add(this.lblRazonSocial);
            this.pnlFormulario.Controls.Add(this.txtNit);
            this.pnlFormulario.Controls.Add(this.lblNit);
            this.pnlFormulario.Location = new System.Drawing.Point(35, 100);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(1080, 340);
            this.pnlFormulario.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(870, 275);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(190, 45);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(705, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 45);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(375, 275);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(150, 45);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(30, 285);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(116, 19);
            this.chkEstado.TabIndex = 12;
            this.chkEstado.Text = "Proveedor activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(30, 220);
            this.txtDireccion.MaxLength = 200;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(1000, 21);
            this.txtDireccion.TabIndex = 11;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(30, 195);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(59, 15);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(740, 135);
            this.txtCiudad.MaxLength = 80;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(290, 21);
            this.txtCiudad.TabIndex = 9;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(740, 110);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(46, 15);
            this.lblCiudad.TabIndex = 8;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(350, 135);
            this.txtCorreo.MaxLength = 120;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(350, 21);
            this.txtCorreo.TabIndex = 7;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(350, 110);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(107, 15);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo electrónico";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(30, 135);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(280, 21);
            this.txtTelefono.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(30, 110);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 15);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(350, 50);
            this.txtRazonSocial.MaxLength = 120;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(680, 21);
            this.txtRazonSocial.TabIndex = 3;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(350, 25);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(78, 15);
            this.lblRazonSocial.TabIndex = 2;
            this.lblRazonSocial.Text = "Razón social";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(30, 50);
            this.txtNit.MaxLength = 20;
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(280, 21);
            this.txtNit.TabIndex = 1;
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Location = new System.Drawing.Point(30, 25);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(26, 15);
            this.lblNit.TabIndex = 0;
            this.lblNit.Text = "NIT";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(35, 500);
            this.dgvProveedores.MultiSelect = false;
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.RowHeadersVisible = false;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(1080, 150);
            this.dgvProveedores.TabIndex = 23;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(35, 455);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(103, 15);
            this.lblBuscar.TabIndex = 24;
            this.lblBuscar.Text = "Buscar proveedor";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(165, 450);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(500, 21);
            this.txtBuscar.TabIndex = 25;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(690, 447);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(130, 35);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(540, 275);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 45);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 740);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CI Almaseg - Gestión de proveedores";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
    }
}