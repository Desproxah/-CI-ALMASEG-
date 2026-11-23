namespace CIAlmaseg
{
    partial class FrmCategorias
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
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlListado = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.pnlEncabezado.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            this.pnlListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.label1);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(984, 75);
            this.pnlEncabezado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Organizar los productos por grupos";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(35, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(277, 29);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Categorías de productos";
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormulario.Controls.Add(this.btnGuardar);
            this.pnlFormulario.Controls.Add(this.btnLimpiar);
            this.pnlFormulario.Controls.Add(this.chkEstado);
            this.pnlFormulario.Controls.Add(this.txtDescripcion);
            this.pnlFormulario.Controls.Add(this.lblDescripcion);
            this.pnlFormulario.Controls.Add(this.txtNombre);
            this.pnlFormulario.Controls.Add(this.lblNombre);
            this.pnlFormulario.Location = new System.Drawing.Point(35, 105);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(360, 400);
            this.pnlFormulario.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(195, 320);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 45);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(30, 320);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(135, 45);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(30, 270);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(105, 17);
            this.chkEstado.TabIndex = 4;
            this.chkEstado.Text = "Categoría activa";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(30, 155);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(300, 90);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(30, 125);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(30, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // pnlListado
            // 
            this.pnlListado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListado.Controls.Add(this.btnCerrar);
            this.pnlListado.Controls.Add(this.btnEditar);
            this.pnlListado.Controls.Add(this.dgvCategorias);
            this.pnlListado.Location = new System.Drawing.Point(425, 105);
            this.pnlListado.Name = "pnlListado";
            this.pnlListado.Size = new System.Drawing.Size(535, 400);
            this.pnlListado.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(345, 335);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(140, 40);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(180, 335);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(140, 40);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(20, 25);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersVisible = false;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(495, 295);
            this.dgvCategorias.TabIndex = 0;
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlListado);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CI Almaseg - Gestión de categorías";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            this.pnlListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlListado;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEditar;
    }
}