namespace CIAlmaseg
{
    partial class FrmEmpleados
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
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.pnlEncabezado.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
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
            this.pnlEncabezado.TabIndex = 3;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(37, 50);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(325, 16);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Administrar empleados y responsables de las ventas";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(35, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(265, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de empleados";
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormulario.Controls.Add(this.btnGuardar);
            this.pnlFormulario.Controls.Add(this.btnCancelar);
            this.pnlFormulario.Controls.Add(this.btnNuevo);
            this.pnlFormulario.Controls.Add(this.chkEstado);
            this.pnlFormulario.Controls.Add(this.cmbCargo);
            this.pnlFormulario.Controls.Add(this.txtCorreo);
            this.pnlFormulario.Controls.Add(this.txtTelefono);
            this.pnlFormulario.Controls.Add(this.lblCargo);
            this.pnlFormulario.Controls.Add(this.lblCorreo);
            this.pnlFormulario.Controls.Add(this.lblTelefono);
            this.pnlFormulario.Controls.Add(this.txtNombre);
            this.pnlFormulario.Controls.Add(this.lblNombre);
            this.pnlFormulario.Controls.Add(this.txtNumeroDocumento);
            this.pnlFormulario.Controls.Add(this.lblNumeroDocumento);
            this.pnlFormulario.Controls.Add(this.cmbTipoDocumento);
            this.pnlFormulario.Controls.Add(this.lblTipoDocumento);
            this.pnlFormulario.Location = new System.Drawing.Point(35, 100);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(1080, 330);
            this.pnlFormulario.TabIndex = 4;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(30, 25);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(113, 15);
            this.lblTipoDocumento.TabIndex = 0;
            this.lblTipoDocumento.Text = "Tipo de documento";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Items.AddRange(new object[] {
            "Cédula de ciudadanía",
            "Cédula de extranjería",
            "Pasaporte"});
            this.cmbTipoDocumento.Location = new System.Drawing.Point(30, 50);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(280, 23);
            this.cmbTipoDocumento.TabIndex = 1;
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(350, 25);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(134, 15);
            this.lblNumeroDocumento.TabIndex = 2;
            this.lblNumeroDocumento.Text = "Número de documento";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(350, 50);
            this.txtNumeroDocumento.MaxLength = 30;
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(280, 21);
            this.txtNumeroDocumento.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(670, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(106, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre completo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(670, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(360, 21);
            this.txtNombre.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(30, 110);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 15);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(350, 110);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(107, 15);
            this.lblCorreo.TabIndex = 7;
            this.lblCorreo.Text = "Correo electrónico";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(740, 110);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(40, 15);
            this.lblCargo.TabIndex = 8;
            this.lblCargo.Text = "Cargo";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(30, 135);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(280, 21);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(350, 135);
            this.txtCorreo.MaxLength = 120;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(350, 21);
            this.txtCorreo.TabIndex = 10;
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Administrador",
            "Auxiliar de compras",
            "Vendedor",
            "Encargado de inventario"});
            this.cmbCargo.Location = new System.Drawing.Point(740, 135);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(290, 23);
            this.cmbCargo.TabIndex = 11;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(30, 215);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(117, 19);
            this.chkEstado.TabIndex = 12;
            this.chkEstado.Text = "Empleado activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(500, 245);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(150, 45);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "NUEVO\n";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(670, 245);
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
            this.btnGuardar.Location = new System.Drawing.Point(844, 245);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(190, 45);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(35, 455);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(104, 15);
            this.lblBuscar.TabIndex = 5;
            this.lblBuscar.Text = "Buscar empleado";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(165, 450);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(500, 21);
            this.txtBuscar.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(690, 447);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(130, 35);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos.Location = new System.Drawing.Point(848, 445);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(130, 35);
            this.btnMostrarTodos.TabIndex = 15;
            this.btnMostrarTodos.Text = "MOSTRAR TODOS";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(35, 500);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(1080, 125);
            this.dgvEmpleados.TabIndex = 23;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 740);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(840, 447);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CI Almaseg - Gestión de empleados";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.DataGridView dgvEmpleados;
    }
}