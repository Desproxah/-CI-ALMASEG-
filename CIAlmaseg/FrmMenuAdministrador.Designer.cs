namespace CIAlmaseg
{
    partial class FrmMenuAdministrador
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlNavegacion = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.pnlAvatar = new System.Windows.Forms.Panel();
            this.lblIniciales = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlMonograma = new System.Windows.Forms.Panel();
            this.lblMonograma = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblMarcaSub = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSubtituloPagina = new System.Windows.Forms.Label();
            this.lblTituloPagina = new System.Windows.Forms.Label();
            this.pnlLineaHeader = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.pnlAvatar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlMonograma.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(42)))), ((int)(((byte)(71)))));
            this.pnlSidebar.Controls.Add(this.pnlNavegacion);
            this.pnlSidebar.Controls.Add(this.lblMenu);
            this.pnlSidebar.Controls.Add(this.pnlUsuario);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 760);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlNavegacion
            // 
            this.pnlNavegacion.AutoScroll = true;
            this.pnlNavegacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNavegacion.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlNavegacion.Location = new System.Drawing.Point(0, 132);
            this.pnlNavegacion.Name = "pnlNavegacion";
            this.pnlNavegacion.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlNavegacion.Size = new System.Drawing.Size(250, 482);
            this.pnlNavegacion.TabIndex = 3;
            this.pnlNavegacion.WrapContents = false;
            // 
            // lblMenu
            // 
            this.lblMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblMenu.Location = new System.Drawing.Point(0, 96);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.lblMenu.Size = new System.Drawing.Size(250, 36);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "MENÚ PRINCIPAL";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.btnCerrarSesion);
            this.pnlUsuario.Controls.Add(this.lblRolUsuario);
            this.pnlUsuario.Controls.Add(this.lblNombreUsuario);
            this.pnlUsuario.Controls.Add(this.pnlAvatar);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUsuario.Location = new System.Drawing.Point(0, 614);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(250, 146);
            this.pnlUsuario.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnCerrarSesion.Location = new System.Drawing.Point(16, 92);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(218, 38);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblRolUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblRolUsuario.Location = new System.Drawing.Point(72, 54);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(88, 13);
            this.lblRolUsuario.TabIndex = 2;
            this.lblRolUsuario.Text = "Administrador";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoEllipsis = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(72, 28);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(162, 22);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Administrador";
            // 
            // pnlAvatar
            // 
            this.pnlAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.pnlAvatar.Controls.Add(this.lblIniciales);
            this.pnlAvatar.Location = new System.Drawing.Point(16, 28);
            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.Size = new System.Drawing.Size(44, 44);
            this.pnlAvatar.TabIndex = 0;
            // 
            // lblIniciales
            // 
            this.lblIniciales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIniciales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIniciales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(42)))), ((int)(((byte)(71)))));
            this.lblIniciales.Location = new System.Drawing.Point(0, 0);
            this.lblIniciales.Name = "lblIniciales";
            this.lblIniciales.Size = new System.Drawing.Size(44, 44);
            this.lblIniciales.TabIndex = 0;
            this.lblIniciales.Text = "CI";
            this.lblIniciales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pnlMonograma);
            this.pnlLogo.Controls.Add(this.lblMarca);
            this.pnlLogo.Controls.Add(this.lblMarcaSub);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(250, 96);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlMonograma
            // 
            this.pnlMonograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.pnlMonograma.Controls.Add(this.lblMonograma);
            this.pnlMonograma.Location = new System.Drawing.Point(20, 26);
            this.pnlMonograma.Name = "pnlMonograma";
            this.pnlMonograma.Size = new System.Drawing.Size(40, 40);
            this.pnlMonograma.TabIndex = 0;
            // 
            // lblMonograma
            // 
            this.lblMonograma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonograma.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMonograma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(42)))), ((int)(((byte)(71)))));
            this.lblMonograma.Location = new System.Drawing.Point(0, 0);
            this.lblMonograma.Name = "lblMonograma";
            this.lblMonograma.Size = new System.Drawing.Size(40, 40);
            this.lblMonograma.TabIndex = 0;
            this.lblMonograma.Text = "CI";
            this.lblMonograma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(70, 28);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(103, 25);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "ALMASEG";
            // 
            // lblMarcaSub
            // 
            this.lblMarcaSub.AutoSize = true;
            this.lblMarcaSub.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold);
            this.lblMarcaSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblMarcaSub.Location = new System.Drawing.Point(72, 54);
            this.lblMarcaSub.Name = "lblMarcaSub";
            this.lblMarcaSub.Size = new System.Drawing.Size(139, 12);
            this.lblMarcaSub.TabIndex = 2;
            this.lblMarcaSub.Text = "FERRETERÍA & SUMINISTROS";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnlPrincipal.Controls.Add(this.pnlContenido);
            this.pnlPrincipal.Controls.Add(this.pnlHeader);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(250, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1030, 760);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // pnlContenido
            // 
            this.pnlContenido.AutoScroll = true;
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 78);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(28, 20, 28, 24);
            this.pnlContenido.Size = new System.Drawing.Size(1030, 682);
            this.pnlContenido.TabIndex = 1;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblFecha);
            this.pnlHeader.Controls.Add(this.lblSubtituloPagina);
            this.pnlHeader.Controls.Add(this.lblTituloPagina);
            this.pnlHeader.Controls.Add(this.pnlLineaHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1030, 78);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblFecha.Location = new System.Drawing.Point(630, 18);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(370, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtituloPagina
            // 
            this.lblSubtituloPagina.AutoSize = true;
            this.lblSubtituloPagina.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtituloPagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSubtituloPagina.Location = new System.Drawing.Point(29, 45);
            this.lblSubtituloPagina.Name = "lblSubtituloPagina";
            this.lblSubtituloPagina.Size = new System.Drawing.Size(260, 17);
            this.lblSubtituloPagina.TabIndex = 1;
            this.lblSubtituloPagina.Text = "Resumen general de la operación";
            // 
            // lblTituloPagina
            // 
            this.lblTituloPagina.AutoSize = true;
            this.lblTituloPagina.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTituloPagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(42)))), ((int)(((byte)(71)))));
            this.lblTituloPagina.Location = new System.Drawing.Point(27, 14);
            this.lblTituloPagina.Name = "lblTituloPagina";
            this.lblTituloPagina.Size = new System.Drawing.Size(250, 31);
            this.lblTituloPagina.TabIndex = 0;
            this.lblTituloPagina.Text = "Panel administrativo";
            // 
            // pnlLineaHeader
            // 
            this.pnlLineaHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlLineaHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLineaHeader.Location = new System.Drawing.Point(0, 77);
            this.pnlLineaHeader.Name = "pnlLineaHeader";
            this.pnlLineaHeader.Size = new System.Drawing.Size(1030, 1);
            this.pnlLineaHeader.TabIndex = 4;
            // 
            // FrmMenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlSidebar);
            this.MinimumSize = new System.Drawing.Size(1150, 700);
            this.Name = "FrmMenuAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CI Almaseg · Panel administrativo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenuAdministrador_Load);
            this.Shown += new System.EventHandler(this.FrmMenuAdministrador_Shown);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.pnlAvatar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlMonograma.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.FlowLayoutPanel pnlNavegacion;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.Label lblIniciales;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlMonograma;
        private System.Windows.Forms.Label lblMonograma;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblMarcaSub;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSubtituloPagina;
        private System.Windows.Forms.Label lblTituloPagina;
        private System.Windows.Forms.Panel pnlLineaHeader;
    }
}
