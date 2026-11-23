namespace CIAlmaseg
{
    partial class FrmMenuCliente
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
            this.lblSistema = new System.Windows.Forms.Label();
            this.lblVista = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.btnVolver);
            this.pnlEncabezado.Controls.Add(this.lblVista);
            this.pnlEncabezado.Controls.Add(this.lblSistema);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1184, 70);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.Location = new System.Drawing.Point(25, 20);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(140, 25);
            this.lblSistema.TabIndex = 0;
            this.lblSistema.Text = "CI ALMASEG";
            // 
            // lblVista
            // 
            this.lblVista.AutoSize = true;
            this.lblVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVista.Location = new System.Drawing.Point(180, 25);
            this.lblVista.Name = "lblVista";
            this.lblVista.Size = new System.Drawing.Size(164, 20);
            this.lblVista.TabIndex = 1;
            this.lblVista.Text = "Productos disponibles";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Controls.Add(this.cmbCategoria);
            this.pnlFiltros.Controls.Add(this.btnBuscar);
            this.pnlFiltros.Controls.Add(this.txtBuscar);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 70);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1184, 75);
            this.pnlFiltros.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(30, 22);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(350, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(800, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 35);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(444, 21);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(250, 21);
            this.cmbCategoria.TabIndex = 2;
            // 
            // pnlProductos
            // 
            this.pnlProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductos.Location = new System.Drawing.Point(0, 145);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(1184, 516);
            this.pnlProductos.TabIndex = 2;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVolver.Location = new System.Drawing.Point(1050, 18);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(110, 35);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmMenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.pnlProductos);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "FrmMenuCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CI Almaseg - Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblVista;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Panel pnlProductos;
    }
}