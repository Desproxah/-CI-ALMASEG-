namespace CIAlmaseg
{
    partial class FrmReportes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.pnlTotalVendido = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalVendido = new System.Windows.Forms.Label();
            this.pnlMejorEmpleado = new System.Windows.Forms.Panel();
            this.lblMejorEmpleado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCantidadVentas = new System.Windows.Forms.Panel();
            this.lblCantidadVentas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chtVentasMes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblVentasMes = new System.Windows.Forms.Label();
            this.chtVentasEmpleado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblVentasEmpleado = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.pnlTotalVendido.SuspendLayout();
            this.pnlMejorEmpleado.SuspendLayout();
            this.pnlCantidadVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtVentasMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtVentasEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.btnCerrar);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1381, 80);
            this.pnlEncabezado.TabIndex = 3;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(37, 50);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(300, 16);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Consultar resultados por período y por empleado";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(35, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(221, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Reportes de ventas";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiltros.Controls.Add(this.btnConsultar);
            this.pnlFiltros.Controls.Add(this.cmbEmpleado);
            this.pnlFiltros.Controls.Add(this.lblEmpleado);
            this.pnlFiltros.Controls.Add(this.dtpFechaFin);
            this.pnlFiltros.Controls.Add(this.lblFechaFin);
            this.pnlFiltros.Controls.Add(this.dtpFechaInicio);
            this.pnlFiltros.Controls.Add(this.lblFechaInicio);
            this.pnlFiltros.Location = new System.Drawing.Point(35, 100);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1110, 90);
            this.pnlFiltros.TabIndex = 4;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(25, 15);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(76, 15);
            this.lblFechaInicio.TabIndex = 0;
            this.lblFechaInicio.Text = "Fecha inicial";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(270, 15);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(67, 15);
            this.lblFechaFin.TabIndex = 2;
            this.lblFechaFin.Text = "Fecha final";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(25, 40);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(210, 21);
            this.dtpFechaInicio.TabIndex = 1;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(270, 40);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(210, 21);
            this.dtpFechaFin.TabIndex = 3;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(520, 15);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(64, 15);
            this.lblEmpleado.TabIndex = 4;
            this.lblEmpleado.Text = "Empleado";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(520, 40);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(300, 23);
            this.cmbEmpleado.TabIndex = 5;
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(860, 35);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(200, 40);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // pnlTotalVendido
            // 
            this.pnlTotalVendido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalVendido.Controls.Add(this.lblTotalVendido);
            this.pnlTotalVendido.Controls.Add(this.label1);
            this.pnlTotalVendido.Location = new System.Drawing.Point(35, 210);
            this.pnlTotalVendido.Name = "pnlTotalVendido";
            this.pnlTotalVendido.Size = new System.Drawing.Size(340, 85);
            this.pnlTotalVendido.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total vendido";
            // 
            // lblTotalVendido
            // 
            this.lblTotalVendido.AutoSize = true;
            this.lblTotalVendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVendido.Location = new System.Drawing.Point(20, 43);
            this.lblTotalVendido.Name = "lblTotalVendido";
            this.lblTotalVendido.Size = new System.Drawing.Size(39, 25);
            this.lblTotalVendido.TabIndex = 4;
            this.lblTotalVendido.Text = "$ 0";
            // 
            // pnlMejorEmpleado
            // 
            this.pnlMejorEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMejorEmpleado.Controls.Add(this.lblMejorEmpleado);
            this.pnlMejorEmpleado.Controls.Add(this.label3);
            this.pnlMejorEmpleado.Location = new System.Drawing.Point(775, 210);
            this.pnlMejorEmpleado.Name = "pnlMejorEmpleado";
            this.pnlMejorEmpleado.Size = new System.Drawing.Size(340, 85);
            this.pnlMejorEmpleado.TabIndex = 6;
            // 
            // lblMejorEmpleado
            // 
            this.lblMejorEmpleado.AutoSize = true;
            this.lblMejorEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMejorEmpleado.Location = new System.Drawing.Point(20, 43);
            this.lblMejorEmpleado.Name = "lblMejorEmpleado";
            this.lblMejorEmpleado.Size = new System.Drawing.Size(0, 20);
            this.lblMejorEmpleado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Empleado con mayores ventas";
            // 
            // pnlCantidadVentas
            // 
            this.pnlCantidadVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCantidadVentas.Controls.Add(this.lblCantidadVentas);
            this.pnlCantidadVentas.Controls.Add(this.label5);
            this.pnlCantidadVentas.Location = new System.Drawing.Point(405, 210);
            this.pnlCantidadVentas.Name = "pnlCantidadVentas";
            this.pnlCantidadVentas.Size = new System.Drawing.Size(340, 85);
            this.pnlCantidadVentas.TabIndex = 7;
            // 
            // lblCantidadVentas
            // 
            this.lblCantidadVentas.AutoSize = true;
            this.lblCantidadVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadVentas.Location = new System.Drawing.Point(20, 43);
            this.lblCantidadVentas.Name = "lblCantidadVentas";
            this.lblCantidadVentas.Size = new System.Drawing.Size(23, 25);
            this.lblCantidadVentas.TabIndex = 4;
            this.lblCantidadVentas.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = " Ventas realizadas";
            // 
            // chtVentasMes
            // 
            chartArea3.Name = "ChartArea1";
            this.chtVentasMes.ChartAreas.Add(chartArea3);
            this.chtVentasMes.Location = new System.Drawing.Point(35, 320);
            this.chtVentasMes.Name = "chtVentasMes";
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Name = "Series1";
            this.chtVentasMes.Series.Add(series3);
            this.chtVentasMes.Size = new System.Drawing.Size(540, 280);
            this.chtVentasMes.TabIndex = 8;
            this.chtVentasMes.Text = "chart1";
            // 
            // lblVentasMes
            // 
            this.lblVentasMes.AutoSize = true;
            this.lblVentasMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasMes.Location = new System.Drawing.Point(162, 311);
            this.lblVentasMes.Name = "lblVentasMes";
            this.lblVentasMes.Size = new System.Drawing.Size(121, 20);
            this.lblVentasMes.TabIndex = 9;
            this.lblVentasMes.Text = "Ventas por mes";
            // 
            // chtVentasEmpleado
            // 
            chartArea4.Name = "ChartArea1";
            this.chtVentasEmpleado.ChartAreas.Add(chartArea4);
            this.chtVentasEmpleado.Location = new System.Drawing.Point(605, 320);
            this.chtVentasEmpleado.Name = "chtVentasEmpleado";
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Name = "Series1";
            this.chtVentasEmpleado.Series.Add(series4);
            this.chtVentasEmpleado.Size = new System.Drawing.Size(540, 280);
            this.chtVentasEmpleado.TabIndex = 10;
            this.chtVentasEmpleado.Text = "chart1";
            // 
            // lblVentasEmpleado
            // 
            this.lblVentasEmpleado.AutoSize = true;
            this.lblVentasEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasEmpleado.Location = new System.Drawing.Point(730, 311);
            this.lblVentasEmpleado.Name = "lblVentasEmpleado";
            this.lblVentasEmpleado.Size = new System.Drawing.Size(161, 20);
            this.lblVentasEmpleado.TabIndex = 11;
            this.lblVentasEmpleado.Text = "Ventas por empleado";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(930, 35);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 40);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 763);
            this.Controls.Add(this.lblVentasEmpleado);
            this.Controls.Add(this.chtVentasEmpleado);
            this.Controls.Add(this.lblVentasMes);
            this.Controls.Add(this.chtVentasMes);
            this.Controls.Add(this.pnlCantidadVentas);
            this.Controls.Add(this.pnlMejorEmpleado);
            this.Controls.Add(this.pnlTotalVendido);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CI Almaseg - Reportes de ventas";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.pnlTotalVendido.ResumeLayout(false);
            this.pnlTotalVendido.PerformLayout();
            this.pnlMejorEmpleado.ResumeLayout(false);
            this.pnlMejorEmpleado.PerformLayout();
            this.pnlCantidadVentas.ResumeLayout(false);
            this.pnlCantidadVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtVentasMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtVentasEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel pnlTotalVendido;
        private System.Windows.Forms.Label lblTotalVendido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMejorEmpleado;
        private System.Windows.Forms.Label lblMejorEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCantidadVentas;
        private System.Windows.Forms.Label lblCantidadVentas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtVentasMes;
        private System.Windows.Forms.Label lblVentasMes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtVentasEmpleado;
        private System.Windows.Forms.Label lblVentasEmpleado;
        private System.Windows.Forms.Button btnCerrar;
    }
}