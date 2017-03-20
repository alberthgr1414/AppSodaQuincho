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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbVentaRapida = new System.Windows.Forms.ToolStripButton();
            this.tsbOrdenMesa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbExpress = new System.Windows.Forms.ToolStripButton();
            this.tsbAbrirTurno = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrarTurno = new System.Windows.Forms.ToolStripButton();
            this.tsbMantenimientos = new System.Windows.Forms.ToolStripDropDownButton();
            this.mantenimientoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoExpressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.DimGray;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbVentaRapida,
            this.tsbOrdenMesa,
            this.toolStripButton1,
            this.tsbExpress,
            this.tsbAbrirTurno,
            this.tsbCerrarTurno,
            this.tsbMantenimientos,
            this.toolStripButton2});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1024, 70);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            this.toolStripButton2.Text = "Salir";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // frmSodaQuincho
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmSodaQuincho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soda Quincho";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.SodaQuincho_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbVentaRapida;
        private System.Windows.Forms.ToolStripButton tsbAbrirTurno;
        private System.Windows.Forms.ToolStripButton tsbCerrarTurno;
        private System.Windows.Forms.ToolStripDropDownButton tsbMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbExpress;
        private System.Windows.Forms.ToolStripButton tsbOrdenMesa;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoExpressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}