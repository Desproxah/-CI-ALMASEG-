namespace CIAlmaseg
{
    partial class FrmListadoProductos
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblContador = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblSubtituloCatalogo = new System.Windows.Forms.Label();
            this.lblTituloCatalogo = new System.Windows.Forms.Label();
            this.lblMarcaSub = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.pnlMonograma = new System.Windows.Forms.Panel();
            this.lblMonograma = new System.Windows.Forms.Label();
            this.pnlLinea = new System.Windows.Forms.Panel();
            this.lblIconoBusqueda = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.flpProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader.SuspendLayout();
            this.pnlMonograma.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblContador);
            this.pnlHeader.Controls.Add(this.cmbCategoria);
            this.pnlHeader.Controls.Add(this.txtBuscar);
            this.pnlHeader.Controls.Add(this.lblIconoBusqueda);
            this.pnlHeader.Controls.Add(this.btnVolver);
            this.pnlHeader.Controls.Add(this.lblSubtituloCatalogo);
            this.pnlHeader.Controls.Add(this.lblTituloCatalogo);
            this.pnlHeader.Controls.Add(this.lblMarcaSub);
            this.pnlHeader.Controls.Add(this.lblMarca);
            this.pnlHeader.Controls.Add(this.pnlMonograma);
            this.pnlHeader.Controls.Add(this.pnlLinea);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 142);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblContador
            // 
            this.lblContador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lblContador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblContador.Location = new System.Drawing.Point(816, 96);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(270, 20);
            this.lblContador.TabIndex = 8;
            this.lblContador.Text = "0 productos";
            this.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(476, 89);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(250, 25);
            this.cmbCategoria.TabIndex = 7;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(60, 89);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(390, 25);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolver.Location = new System.Drawing.Point(930, 25);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(156, 38);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver al inicio";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblSubtituloCatalogo
            // 
            this.lblSubtituloCatalogo.AutoSize = true;
            this.lblSubtituloCatalogo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtituloCatalogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSubtituloCatalogo.Location = new System.Drawing.Point(249, 53);
            this.lblSubtituloCatalogo.Name = "lblSubtituloCatalogo";
            this.lblSubtituloCatalogo.Size = new System.Drawing.Size(286, 17);
            this.lblSubtituloCatalogo.TabIndex = 4;
            this.lblSubtituloCatalogo.Text = "Consulta precios y existencias de nuestra ferretería";
            // 
            // lblTituloCatalogo
            // 
            this.lblTituloCatalogo.AutoSize = true;
            this.lblTituloCatalogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTituloCatalogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(42)))), ((int)(((byte)(71)))));
            this.lblTituloCatalogo.Location = new System.Drawing.Point(247, 23);
            this.lblTituloCatalogo.Name = "lblTituloCatalogo";
            this.lblTituloCatalogo.Size = new System.Drawing.Size(219, 30);
            this.lblTituloCatalogo.TabIndex = 3;
            this.lblTituloCatalogo.Text = "Catálogo de productos";
            // 
            // lblMarcaSub
            // 
            this.lblMarcaSub.AutoSize = true;
            this.lblMarcaSub.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold);
            this.lblMarcaSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblMarcaSub.Location = new System.Drawing.Point(78, 54);
            this.lblMarcaSub.Name = "lblMarcaSub";
            this.lblMarcaSub.Size = new System.Drawing.Size(139, 12);
            this.lblMarcaSub.TabIndex = 2;
            this.lblMarcaSub.Text = "FERRETERÍA & SUMINISTROS";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(42)))), ((int)(((byte)(71)))));
            this.lblMarca.Location = new System.Drawing.Point(76, 28);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(103, 25);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "ALMASEG";
            // 
            // pnlMonograma
            // 
            this.pnlMonograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.pnlMonograma.Controls.Add(this.lblMonograma);
            this.pnlMonograma.Location = new System.Drawing.Point(24, 24);
            this.pnlMonograma.Name = "pnlMonograma";
            this.pnlMonograma.Size = new System.Drawing.Size(42, 42);
            this.pnlMonograma.TabIndex = 0;
            // 
            // lblMonograma
            // 
            this.lblMonograma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonograma.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMonograma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(42)))), ((int)(((byte)(71)))));
            this.lblMonograma.Location = new System.Drawing.Point(0, 0);
            this.lblMonograma.Name = "lblMonograma";
            this.lblMonograma.Size = new System.Drawing.Size(42, 42);
            this.lblMonograma.TabIndex = 0;
            this.lblMonograma.Text = "CI";
            this.lblMonograma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLinea
            // 
            this.pnlLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlLinea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLinea.Location = new System.Drawing.Point(0, 141);
            this.pnlLinea.Name = "pnlLinea";
            this.pnlLinea.Size = new System.Drawing.Size(1200, 1);
            this.pnlLinea.TabIndex = 9;
            // 
            // lblIconoBusqueda
            // 
            this.lblIconoBusqueda.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11F);
            this.lblIconoBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblIconoBusqueda.Location = new System.Drawing.Point(28, 89);
            this.lblIconoBusqueda.Name = "lblIconoBusqueda";
            this.lblIconoBusqueda.Size = new System.Drawing.Size(26, 25);
            this.lblIconoBusqueda.TabIndex = 10;
            this.lblIconoBusqueda.Text = "";
            this.lblIconoBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContenido
            // 
            this.pnlContenido.AutoScroll = true;
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnlContenido.Controls.Add(this.flpProductos);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 142);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(18, 12, 18, 18);
            this.pnlContenido.Size = new System.Drawing.Size(1200, 618);
            this.pnlContenido.TabIndex = 1;
            // 
            // flpProductos
            // 
            this.flpProductos.AutoScroll = true;
            this.flpProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.flpProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProductos.Location = new System.Drawing.Point(18, 12);
            this.flpProductos.Name = "flpProductos";
            this.flpProductos.Padding = new System.Windows.Forms.Padding(2);
            this.flpProductos.Size = new System.Drawing.Size(1164, 588);
            this.flpProductos.TabIndex = 0;
            // 
            // FrmListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(1000, 680);
            this.Name = "FrmListadoProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CI Almaseg · Catálogo de productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmListadoProductos_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMonograma.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMonograma;
        private System.Windows.Forms.Label lblMonograma;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblMarcaSub;
        private System.Windows.Forms.Label lblTituloCatalogo;
        private System.Windows.Forms.Label lblSubtituloCatalogo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Panel pnlLinea;
        private System.Windows.Forms.Label lblIconoBusqueda;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.FlowLayoutPanel flpProductos;
    }
}
