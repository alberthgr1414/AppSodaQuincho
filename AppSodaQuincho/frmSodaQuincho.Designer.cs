namespace AppSodaQuincho
{
    partial class frmSodaQuincho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSodaQuincho));
            this.tspMenu = new System.Windows.Forms.ToolStrip();
            this.tsbVentaRapida = new System.Windows.Forms.ToolStripButton();
            this.tsbOrdenMesa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbExpress = new System.Windows.Forms.ToolStripButton();
            this.tsbAbrirTurno = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrarTurno = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tspMenuTecnico = new System.Windows.Forms.ToolStrip();
            this.tsbInicio = new System.Windows.Forms.ToolStripButton();
            this.tsbConfigCaja = new System.Windows.Forms.ToolStripButton();
            this.tsbDetalle = new System.Windows.Forms.ToolStripButton();
            this.tsbMantUsuario = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrarSessionTec = new System.Windows.Forms.ToolStripButton();
            this.mantenimientoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoExpressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbMantenimientos = new System.Windows.Forms.ToolStripDropDownButton();
            this.tspMenu.SuspendLayout();
            this.tspMenuTecnico.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspMenu
            // 
            this.tspMenu.AutoSize = false;
            this.tspMenu.BackColor = System.Drawing.Color.DimGray;
            this.tspMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbVentaRapida,
            this.tsbOrdenMesa,
            this.toolStripButton1,
            this.tsbExpress,
            this.tsbAbrirTurno,
            this.tsbCerrarTurno,
            this.tsbMantenimientos,
            this.toolStripButton2});
            this.tspMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tspMenu.Location = new System.Drawing.Point(0, 0);
            this.tspMenu.Name = "tspMenu";
            this.tspMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tspMenu.Size = new System.Drawing.Size(1024, 70);
            this.tspMenu.TabIndex = 0;
            this.tspMenu.Text = "toolStrip1";
            this.tspMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbVentaRapida
            // 
            this.tsbVentaRapida.AutoSize = false;
            this.tsbVentaRapida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbVentaRapida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbVentaRapida.ForeColor = System.Drawing.Color.White;
            this.tsbVentaRapida.Image = ((System.Drawing.Image)(resources.GetObject("tsbVentaRapida.Image")));
            this.tsbVentaRapida.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVentaRapida.Margin = new System.Windows.Forms.Padding(1);
            this.tsbVentaRapida.Name = "tsbVentaRapida";
            this.tsbVentaRapida.Size = new System.Drawing.Size(90, 70);
            this.tsbVentaRapida.Tag = "Facturacion";
            this.tsbVentaRapida.Text = "Venta Rapida";
            this.tsbVentaRapida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbVentaRapida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbVentaRapida.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbOrdenMesa
            // 
            this.tsbOrdenMesa.AutoSize = false;
            this.tsbOrdenMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbOrdenMesa.ForeColor = System.Drawing.Color.White;
            this.tsbOrdenMesa.Image = ((System.Drawing.Image)(resources.GetObject("tsbOrdenMesa.Image")));
            this.tsbOrdenMesa.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbOrdenMesa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOrdenMesa.Margin = new System.Windows.Forms.Padding(1);
            this.tsbOrdenMesa.Name = "tsbOrdenMesa";
            this.tsbOrdenMesa.Size = new System.Drawing.Size(90, 70);
            this.tsbOrdenMesa.Text = "Orden Mesa";
            this.tsbOrdenMesa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbOrdenMesa.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(90, 70);
            this.toolStripButton1.Text = "Ordenes ";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_2);
            // 
            // tsbExpress
            // 
            this.tsbExpress.AutoSize = false;
            this.tsbExpress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbExpress.ForeColor = System.Drawing.Color.White;
            this.tsbExpress.Image = ((System.Drawing.Image)(resources.GetObject("tsbExpress.Image")));
            this.tsbExpress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExpress.Margin = new System.Windows.Forms.Padding(1);
            this.tsbExpress.Name = "tsbExpress";
            this.tsbExpress.Size = new System.Drawing.Size(90, 70);
            this.tsbExpress.Text = "Express";
            this.tsbExpress.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbExpress.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExpress.Click += new System.EventHandler(this.tsbExpress_Click);
            // 
            // tsbAbrirTurno
            // 
            this.tsbAbrirTurno.AutoSize = false;
            this.tsbAbrirTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbAbrirTurno.ForeColor = System.Drawing.Color.White;
            this.tsbAbrirTurno.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbrirTurno.Image")));
            this.tsbAbrirTurno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbrirTurno.Margin = new System.Windows.Forms.Padding(1);
            this.tsbAbrirTurno.Name = "tsbAbrirTurno";
            this.tsbAbrirTurno.Size = new System.Drawing.Size(90, 70);
            this.tsbAbrirTurno.Text = "Abrir Turno";
            this.tsbAbrirTurno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbAbrirTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAbrirTurno.Click += new System.EventHandler(this.tsbAbrirTurno_Click);
            // 
            // tsbCerrarTurno
            // 
            this.tsbCerrarTurno.AutoSize = false;
            this.tsbCerrarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbCerrarTurno.ForeColor = System.Drawing.Color.White;
            this.tsbCerrarTurno.Image = ((System.Drawing.Image)(resources.GetObject("tsbCerrarTurno.Image")));
            this.tsbCerrarTurno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrarTurno.Margin = new System.Windows.Forms.Padding(1);
            this.tsbCerrarTurno.Name = "tsbCerrarTurno";
            this.tsbCerrarTurno.Size = new System.Drawing.Size(90, 70);
            this.tsbCerrarTurno.Text = "Cerrar Turno";
            this.tsbCerrarTurno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbCerrarTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCerrarTurno.Click += new System.EventHandler(this.tsbCerrarTurno_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripButton2.ForeColor = System.Drawing.Color.White;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(260, 1, 1, 1);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(90, 70);
            this.toolStripButton2.Text = "Cerrar Session";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.ToolTipText = "Salir";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // tspMenuTecnico
            // 
            this.tspMenuTecnico.AutoSize = false;
            this.tspMenuTecnico.BackColor = System.Drawing.Color.DimGray;
            this.tspMenuTecnico.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tspMenuTecnico.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInicio,
            this.tsbConfigCaja,
            this.tsbDetalle,
            this.tsbMantUsuario,
            this.tsbCerrarSessionTec});
            this.tspMenuTecnico.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tspMenuTecnico.Location = new System.Drawing.Point(0, 70);
            this.tspMenuTecnico.Name = "tspMenuTecnico";
            this.tspMenuTecnico.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tspMenuTecnico.Size = new System.Drawing.Size(1024, 70);
            this.tspMenuTecnico.TabIndex = 2;
            this.tspMenuTecnico.Text = "toolStrip1";
            // 
            // tsbInicio
            // 
            this.tsbInicio.AutoSize = false;
            this.tsbInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbInicio.ForeColor = System.Drawing.Color.White;
            this.tsbInicio.Image = ((System.Drawing.Image)(resources.GetObject("tsbInicio.Image")));
            this.tsbInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInicio.Margin = new System.Windows.Forms.Padding(1);
            this.tsbInicio.Name = "tsbInicio";
            this.tsbInicio.Size = new System.Drawing.Size(90, 70);
            this.tsbInicio.Tag = "Facturacion";
            this.tsbInicio.Text = "Inicio";
            this.tsbInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbInicio.Click += new System.EventHandler(this.tsbInicio_Click);
            // 
            // tsbConfigCaja
            // 
            this.tsbConfigCaja.AutoSize = false;
            this.tsbConfigCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbConfigCaja.ForeColor = System.Drawing.Color.White;
            this.tsbConfigCaja.Image = ((System.Drawing.Image)(resources.GetObject("tsbConfigCaja.Image")));
            this.tsbConfigCaja.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbConfigCaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConfigCaja.Margin = new System.Windows.Forms.Padding(1);
            this.tsbConfigCaja.Name = "tsbConfigCaja";
            this.tsbConfigCaja.Size = new System.Drawing.Size(120, 70);
            this.tsbConfigCaja.Text = "Configurar Terminal";
            this.tsbConfigCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbConfigCaja.Click += new System.EventHandler(this.tsbConfigCaja_Click);
            // 
            // tsbDetalle
            // 
            this.tsbDetalle.AutoSize = false;
            this.tsbDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbDetalle.ForeColor = System.Drawing.Color.White;
            this.tsbDetalle.Image = ((System.Drawing.Image)(resources.GetObject("tsbDetalle.Image")));
            this.tsbDetalle.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsbDetalle.Name = "tsbDetalle";
            this.tsbDetalle.Size = new System.Drawing.Size(90, 70);
            this.tsbDetalle.Text = "Detalles";
            this.tsbDetalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbMantUsuario
            // 
            this.tsbMantUsuario.AutoSize = false;
            this.tsbMantUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbMantUsuario.ForeColor = System.Drawing.Color.White;
            this.tsbMantUsuario.Image = ((System.Drawing.Image)(resources.GetObject("tsbMantUsuario.Image")));
            this.tsbMantUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMantUsuario.Margin = new System.Windows.Forms.Padding(1);
            this.tsbMantUsuario.Name = "tsbMantUsuario";
            this.tsbMantUsuario.Size = new System.Drawing.Size(140, 70);
            this.tsbMantUsuario.Text = "Mantenimiento Usuario";
            this.tsbMantUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbMantUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbCerrarSessionTec
            // 
            this.tsbCerrarSessionTec.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrarSessionTec.AutoSize = false;
            this.tsbCerrarSessionTec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbCerrarSessionTec.ForeColor = System.Drawing.Color.White;
            this.tsbCerrarSessionTec.Image = ((System.Drawing.Image)(resources.GetObject("tsbCerrarSessionTec.Image")));
            this.tsbCerrarSessionTec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrarSessionTec.Margin = new System.Windows.Forms.Padding(485, 1, 1, 1);
            this.tsbCerrarSessionTec.Name = "tsbCerrarSessionTec";
            this.tsbCerrarSessionTec.Size = new System.Drawing.Size(90, 70);
            this.tsbCerrarSessionTec.Text = "Cerrar Session";
            this.tsbCerrarSessionTec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbCerrarSessionTec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCerrarSessionTec.ToolTipText = "Salir";
            this.tsbCerrarSessionTec.Click += new System.EventHandler(this.tsbCerrarSessionTec_Click);
            // 
            // mantenimientoProductoToolStripMenuItem
            // 
            this.mantenimientoProductoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoProductoToolStripMenuItem.Image")));
            this.mantenimientoProductoToolStripMenuItem.Name = "mantenimientoProductoToolStripMenuItem";
            this.mantenimientoProductoToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.mantenimientoProductoToolStripMenuItem.Text = "Mantenimiento Producto";
            this.mantenimientoProductoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mantenimientoProductoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoProductoToolStripMenuItem_Click);
            // 
            // mantenimientoExpressToolStripMenuItem
            // 
            this.mantenimientoExpressToolStripMenuItem.Name = "mantenimientoExpressToolStripMenuItem";
            this.mantenimientoExpressToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.mantenimientoExpressToolStripMenuItem.Text = "Mantenimiento Express";
            // 
            // mantenimientoUsuariosToolStripMenuItem
            // 
            this.mantenimientoUsuariosToolStripMenuItem.Name = "mantenimientoUsuariosToolStripMenuItem";
            this.mantenimientoUsuariosToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.mantenimientoUsuariosToolStripMenuItem.Text = "Mantenimiento Usuarios";
            // 
            // tsbMantenimientos
            // 
            this.tsbMantenimientos.AutoSize = false;
            this.tsbMantenimientos.AutoToolTip = false;
            this.tsbMantenimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoProductoToolStripMenuItem,
            this.mantenimientoExpressToolStripMenuItem,
            this.mantenimientoUsuariosToolStripMenuItem});
            this.tsbMantenimientos.ForeColor = System.Drawing.Color.White;
            this.tsbMantenimientos.Image = ((System.Drawing.Image)(resources.GetObject("tsbMantenimientos.Image")));
            this.tsbMantenimientos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMantenimientos.Margin = new System.Windows.Forms.Padding(1);
            this.tsbMantenimientos.Name = "tsbMantenimientos";
            this.tsbMantenimientos.Size = new System.Drawing.Size(120, 70);
            this.tsbMantenimientos.Text = "Mantenimientos";
            this.tsbMantenimientos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbMantenimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbMantenimientos.Click += new System.EventHandler(this.tsbMantenimientos_Click);
            // 
            // frmSodaQuincho
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.tspMenuTecnico);
            this.Controls.Add(this.tspMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmSodaQuincho";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soda Quincho";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.SodaQuincho_Load);
            this.tspMenu.ResumeLayout(false);
            this.tspMenu.PerformLayout();
            this.tspMenuTecnico.ResumeLayout(false);
            this.tspMenuTecnico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspMenu;
        private System.Windows.Forms.ToolStripButton tsbVentaRapida;
        private System.Windows.Forms.ToolStripButton tsbAbrirTurno;
        private System.Windows.Forms.ToolStripButton tsbCerrarTurno;
        private System.Windows.Forms.ToolStripButton tsbExpress;
        private System.Windows.Forms.ToolStripButton tsbOrdenMesa;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip tspMenuTecnico;
        private System.Windows.Forms.ToolStripButton tsbInicio;
        private System.Windows.Forms.ToolStripButton tsbConfigCaja;
        private System.Windows.Forms.ToolStripButton tsbDetalle;
        private System.Windows.Forms.ToolStripButton tsbMantUsuario;
        private System.Windows.Forms.ToolStripButton tsbCerrarSessionTec;
        private System.Windows.Forms.ToolStripDropDownButton tsbMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoExpressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoUsuariosToolStripMenuItem;
    }
}