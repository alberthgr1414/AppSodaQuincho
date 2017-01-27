namespace AppSodaQuincho
{
    partial class frmFacturacion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelPlato = new System.Windows.Forms.Panel();
            this.btnCombos = new System.Windows.Forms.Button();
            this.btnPedidoEspecial = new System.Windows.Forms.Button();
            this.btnProductosTemporada = new System.Windows.Forms.Button();
            this.btnPrecio = new System.Windows.Forms.Button();
            this.btnBevidas = new System.Windows.Forms.Button();
            this.btnAdicionales = new System.Windows.Forms.Button();
            this.btnPostres = new System.Windows.Forms.Button();
            this.btnMenuRegular = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTituloCantidad = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnFuncionesPOS = new System.Windows.Forms.Button();
            this.btnMesa = new System.Windows.Forms.Button();
            this.btnComerAqui = new System.Windows.Forms.Button();
            this.btnExpress = new System.Windows.Forms.Button();
            this.btnLlevar = new System.Windows.Forms.Button();
            this.panelCantidad = new System.Windows.Forms.Panel();
            this.panelHora = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotalFactura = new System.Windows.Forms.MaskedTextBox();
            this.Efectivo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnNum1 = new System.Windows.Forms.Button();
            this.BtnNum4 = new System.Windows.Forms.Button();
            this.BtnNum5 = new System.Windows.Forms.Button();
            this.BtnNum6 = new System.Windows.Forms.Button();
            this.BtnNum9 = new System.Windows.Forms.Button();
            this.BtnNum0 = new System.Windows.Forms.Button();
            this.BtnNum7 = new System.Windows.Forms.Button();
            this.BtnNum8 = new System.Windows.Forms.Button();
            this.BtnNum3 = new System.Windows.Forms.Button();
            this.BtnNum2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.tsbFecha = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbHora = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tspBarraCarga = new System.Windows.Forms.ToolStrip();
            this.dBSodaQuinchoDataSet = new AppSodaQuincho.DBSodaQuinchoDataSet();
            this.detFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detFacturaTableAdapter = new AppSodaQuincho.DBSodaQuinchoDataSetTableAdapters.DetFacturaTableAdapter();
            this.PanelEstadoFactura = new System.Windows.Forms.Panel();
            this.lblEstadoFactura = new System.Windows.Forms.Label();
            this.dgvPlatos = new System.Windows.Forms.DataGridView();
            this.PanelTimerFactura = new System.Windows.Forms.Panel();
            this.lblTiempoFactura = new System.Windows.Forms.Label();
            this.timerFactura = new System.Windows.Forms.Timer(this.components);
            this.timerPicture = new System.Windows.Forms.Timer(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCantidad.SuspendLayout();
            this.panelHora.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tspBarraCarga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBSodaQuinchoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detFacturaBindingSource)).BeginInit();
            this.PanelEstadoFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).BeginInit();
            this.PanelTimerFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPlato
            // 
            this.PanelPlato.AutoScroll = true;
            this.PanelPlato.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelPlato.Location = new System.Drawing.Point(1, 53);
            this.PanelPlato.Margin = new System.Windows.Forms.Padding(1);
            this.PanelPlato.Name = "PanelPlato";
            this.PanelPlato.Size = new System.Drawing.Size(502, 615);
            this.PanelPlato.TabIndex = 2;
            // 
            // btnCombos
            // 
            this.btnCombos.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCombos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCombos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCombos.Location = new System.Drawing.Point(118, 1);
            this.btnCombos.Margin = new System.Windows.Forms.Padding(1);
            this.btnCombos.Name = "btnCombos";
            this.btnCombos.Size = new System.Drawing.Size(115, 86);
            this.btnCombos.TabIndex = 8;
            this.btnCombos.Text = "Combos";
            this.btnCombos.UseVisualStyleBackColor = false;
            // 
            // btnPedidoEspecial
            // 
            this.btnPedidoEspecial.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnPedidoEspecial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidoEspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPedidoEspecial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPedidoEspecial.Location = new System.Drawing.Point(118, 265);
            this.btnPedidoEspecial.Margin = new System.Windows.Forms.Padding(1);
            this.btnPedidoEspecial.Name = "btnPedidoEspecial";
            this.btnPedidoEspecial.Size = new System.Drawing.Size(115, 86);
            this.btnPedidoEspecial.TabIndex = 7;
            this.btnPedidoEspecial.Text = "Pedido Especial";
            this.btnPedidoEspecial.UseVisualStyleBackColor = false;
            // 
            // btnProductosTemporada
            // 
            this.btnProductosTemporada.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnProductosTemporada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductosTemporada.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnProductosTemporada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProductosTemporada.Location = new System.Drawing.Point(1, 265);
            this.btnProductosTemporada.Margin = new System.Windows.Forms.Padding(1);
            this.btnProductosTemporada.Name = "btnProductosTemporada";
            this.btnProductosTemporada.Size = new System.Drawing.Size(115, 86);
            this.btnProductosTemporada.TabIndex = 6;
            this.btnProductosTemporada.Text = "Productos de Temporada";
            this.btnProductosTemporada.UseVisualStyleBackColor = false;
            // 
            // btnPrecio
            // 
            this.btnPrecio.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnPrecio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPrecio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrecio.Location = new System.Drawing.Point(118, 177);
            this.btnPrecio.Margin = new System.Windows.Forms.Padding(1);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(115, 86);
            this.btnPrecio.TabIndex = 5;
            this.btnPrecio.Text = "Precio";
            this.btnPrecio.UseVisualStyleBackColor = false;
            this.btnPrecio.Click += new System.EventHandler(this.btnPrecio_Click);
            // 
            // btnBevidas
            // 
            this.btnBevidas.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnBevidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBevidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBevidas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBevidas.Location = new System.Drawing.Point(1, 89);
            this.btnBevidas.Margin = new System.Windows.Forms.Padding(1);
            this.btnBevidas.Name = "btnBevidas";
            this.btnBevidas.Size = new System.Drawing.Size(115, 86);
            this.btnBevidas.TabIndex = 4;
            this.btnBevidas.Text = "Bebidas";
            this.btnBevidas.UseVisualStyleBackColor = false;
            this.btnBevidas.Click += new System.EventHandler(this.btnBebidas_Click);
            // 
            // btnAdicionales
            // 
            this.btnAdicionales.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAdicionales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAdicionales.Location = new System.Drawing.Point(1, 177);
            this.btnAdicionales.Margin = new System.Windows.Forms.Padding(1);
            this.btnAdicionales.Name = "btnAdicionales";
            this.btnAdicionales.Size = new System.Drawing.Size(115, 86);
            this.btnAdicionales.TabIndex = 3;
            this.btnAdicionales.Text = "Adicionales";
            this.btnAdicionales.UseVisualStyleBackColor = false;
            this.btnAdicionales.Click += new System.EventHandler(this.btnadicionales_Click);
            // 
            // btnPostres
            // 
            this.btnPostres.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnPostres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPostres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPostres.Location = new System.Drawing.Point(118, 89);
            this.btnPostres.Margin = new System.Windows.Forms.Padding(1);
            this.btnPostres.Name = "btnPostres";
            this.btnPostres.Size = new System.Drawing.Size(115, 86);
            this.btnPostres.TabIndex = 1;
            this.btnPostres.Text = "Postres";
            this.btnPostres.UseVisualStyleBackColor = false;
            this.btnPostres.Click += new System.EventHandler(this.btnPostres_Click);
            // 
            // btnMenuRegular
            // 
            this.btnMenuRegular.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnMenuRegular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnMenuRegular.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMenuRegular.Location = new System.Drawing.Point(1, 1);
            this.btnMenuRegular.Margin = new System.Windows.Forms.Padding(1);
            this.btnMenuRegular.Name = "btnMenuRegular";
            this.btnMenuRegular.Size = new System.Drawing.Size(115, 86);
            this.btnMenuRegular.TabIndex = 0;
            this.btnMenuRegular.Text = "Menu Regular";
            this.btnMenuRegular.UseVisualStyleBackColor = false;
            this.btnMenuRegular.Click += new System.EventHandler(this.btnMenuRegular_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCantidad.Location = new System.Drawing.Point(163, 8);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(29, 31);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "1";
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // lblTituloCantidad
            // 
            this.lblTituloCantidad.AutoSize = true;
            this.lblTituloCantidad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTituloCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTituloCantidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTituloCantidad.Location = new System.Drawing.Point(39, 8);
            this.lblTituloCantidad.Name = "lblTituloCantidad";
            this.lblTituloCantidad.Size = new System.Drawing.Size(131, 31);
            this.lblTituloCantidad.TabIndex = 10;
            this.lblTituloCantidad.Text = "Cantidad:";
            this.lblTituloCantidad.Click += new System.EventHandler(this.lblTituloCantidad_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEliminar.Location = new System.Drawing.Point(118, 353);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 86);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnFuncionesPOS
            // 
            this.btnFuncionesPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFuncionesPOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionesPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionesPOS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFuncionesPOS.Location = new System.Drawing.Point(1, 353);
            this.btnFuncionesPOS.Margin = new System.Windows.Forms.Padding(1);
            this.btnFuncionesPOS.Name = "btnFuncionesPOS";
            this.btnFuncionesPOS.Size = new System.Drawing.Size(115, 86);
            this.btnFuncionesPOS.TabIndex = 4;
            this.btnFuncionesPOS.Text = "Funciones POS";
            this.btnFuncionesPOS.UseVisualStyleBackColor = false;
            this.btnFuncionesPOS.Click += new System.EventHandler(this.btnFuncionesPOS_Click);
            // 
            // btnMesa
            // 
            this.btnMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMesa.Location = new System.Drawing.Point(1, 529);
            this.btnMesa.Margin = new System.Windows.Forms.Padding(1);
            this.btnMesa.Name = "btnMesa";
            this.btnMesa.Size = new System.Drawing.Size(115, 86);
            this.btnMesa.TabIndex = 3;
            this.btnMesa.Text = "Orden Mesa";
            this.btnMesa.UseVisualStyleBackColor = false;
            // 
            // btnComerAqui
            // 
            this.btnComerAqui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnComerAqui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComerAqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComerAqui.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnComerAqui.Location = new System.Drawing.Point(118, 441);
            this.btnComerAqui.Margin = new System.Windows.Forms.Padding(1);
            this.btnComerAqui.Name = "btnComerAqui";
            this.btnComerAqui.Size = new System.Drawing.Size(115, 86);
            this.btnComerAqui.TabIndex = 2;
            this.btnComerAqui.Text = "Pago para Comer Aqui";
            this.btnComerAqui.UseVisualStyleBackColor = false;
            // 
            // btnExpress
            // 
            this.btnExpress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExpress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExpress.Location = new System.Drawing.Point(118, 529);
            this.btnExpress.Margin = new System.Windows.Forms.Padding(1);
            this.btnExpress.Name = "btnExpress";
            this.btnExpress.Size = new System.Drawing.Size(115, 86);
            this.btnExpress.TabIndex = 1;
            this.btnExpress.Text = "Express";
            this.btnExpress.UseVisualStyleBackColor = false;
            // 
            // btnLlevar
            // 
            this.btnLlevar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLlevar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLlevar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlevar.Location = new System.Drawing.Point(1, 441);
            this.btnLlevar.Margin = new System.Windows.Forms.Padding(1);
            this.btnLlevar.Name = "btnLlevar";
            this.btnLlevar.Size = new System.Drawing.Size(115, 86);
            this.btnLlevar.TabIndex = 0;
            this.btnLlevar.Text = "Pago para Llevar";
            this.btnLlevar.UseVisualStyleBackColor = false;
            this.btnLlevar.Click += new System.EventHandler(this.btnLlevar_Click);
            // 
            // panelCantidad
            // 
            this.panelCantidad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCantidad.Controls.Add(this.lblTituloCantidad);
            this.panelCantidad.Controls.Add(this.lblCantidad);
            this.panelCantidad.Location = new System.Drawing.Point(504, 1);
            this.panelCantidad.Name = "panelCantidad";
            this.panelCantidad.Size = new System.Drawing.Size(235, 50);
            this.panelCantidad.TabIndex = 18;
            this.panelCantidad.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCantidad_Paint);
            this.panelCantidad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelCantidad_MouseClick);
            // 
            // panelHora
            // 
            this.panelHora.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHora.Controls.Add(this.label2);
            this.panelHora.Location = new System.Drawing.Point(740, 1);
            this.panelHora.Name = "panelHora";
            this.panelHora.Size = new System.Drawing.Size(209, 50);
            this.panelHora.TabIndex = 19;
            this.panelHora.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHora_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cambio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.txtTotalFactura);
            this.panel1.Controls.Add(this.Efectivo);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(740, 519);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 149);
            this.panel1.TabIndex = 24;
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTotalFactura.Enabled = false;
            this.txtTotalFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFactura.Location = new System.Drawing.Point(115, 21);
            this.txtTotalFactura.Mask = "₡ 999999";
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.ReadOnly = true;
            this.txtTotalFactura.Size = new System.Drawing.Size(149, 33);
            this.txtTotalFactura.TabIndex = 28;
            // 
            // Efectivo
            // 
            this.Efectivo.AutoSize = true;
            this.Efectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Efectivo.Location = new System.Drawing.Point(16, 64);
            this.Efectivo.Name = "Efectivo";
            this.Efectivo.Size = new System.Drawing.Size(98, 29);
            this.Efectivo.TabIndex = 26;
            this.Efectivo.Text = "Efectivo";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(115, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 33);
            this.textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(115, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 33);
            this.textBox1.TabIndex = 24;
            // 
            // BtnNum1
            // 
            this.BtnNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNum1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnNum1.Location = new System.Drawing.Point(2, 1);
            this.BtnNum1.Margin = new System.Windows.Forms.Padding(2, 1, 1, 1);
            this.BtnNum1.Name = "BtnNum1";
            this.BtnNum1.Size = new System.Drawing.Size(48, 48);
            this.BtnNum1.TabIndex = 0;
            this.BtnNum1.Tag = "1";
            this.BtnNum1.Text = "1";
            this.BtnNum1.UseVisualStyleBackColor = false;
            this.BtnNum1.Click += new System.EventHandler(this.Cantidad_Click);
            // 
            // BtnNum4
            // 
            this.BtnNum4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNum4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnNum4.Location = new System.Drawing.Point(152, 1);
            this.BtnNum4.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNum4.Name = "BtnNum4";
            this.BtnNum4.Size = new System.Drawing.Size(48, 48);
            this.BtnNum4.TabIndex = 1;
            this.BtnNum4.Tag = "4";
            this.BtnNum4.Text = "4";
            this.BtnNum4.UseVisualStyleBackColor = false;
            this.BtnNum4.Click += new System.EventHandler(this.Cantidad_Click);
            // 
            // BtnNum5
            // 
            this.BtnNum5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNum5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnNum5.Location = new System.Drawing.Point(202, 1);
            this.BtnNum5.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNum5.Name = "BtnNum5";
            this.BtnNum5.Size = new System.Drawing.Size(48, 48);
            this.BtnNum5.TabIndex = 2;
            this.BtnNum5.Tag = "5";
            this.BtnNum5.Text = "5";
            this.BtnNum5.UseVisualStyleBackColor = false;
            this.BtnNum5.Click += new System.EventHandler(this.Cantidad_Click);
            // 
            // BtnNum6
            // 
            this.BtnNum6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNum6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnNum6.Location = new System.Drawing.Point(252, 1);
            this.BtnNum6.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNum6.Name = "BtnNum6";
            this.BtnNum6.Size = new System.Drawing.Size(48, 48);
            this.BtnNum6.TabIndex = 5;
            this.BtnNum6.Tag = "6";
            this.BtnNum6.Text = "6";
            this.BtnNum6.UseVisualStyleBackColor = false;
            this.BtnNum6.Click += new System.EventHandler(this.Cantidad_Click);
            // 
            // BtnNum9
            // 
            this.BtnNum9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNum9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnNum9.Location = new System.Drawing.Point(402, 1);
            this.BtnNum9.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNum9.Name = "BtnNum9";
            this.BtnNum9.Size = new System.Drawing.Size(48, 48);
            this.BtnNum9.TabIndex = 3;
            this.BtnNum9.Tag = "9";
            this.BtnNum9.Text = "9";
            this.BtnNum9.UseVisualStyleBackColor = false;
            this.BtnNum9.Click += new System.EventHandler(this.Cantidad_Click);
            // 
            // BtnNum0
            // 
            this.BtnNum0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNum0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnNum0.Location = new System.Drawing.Point(452, 1);
            this.BtnNum0.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNum0.Name = "BtnNum0";
            this.BtnNum0.Size = new System.Drawing.Size(48, 48);
            this.BtnNum0.TabIndex = 4;
            this.BtnNum0.Tag = "0";
            this.BtnNum0.Text = "0";
            this.BtnNum0.UseVisualStyleBackColor = false;
            this.BtnNum0.Click += new System.EventHandler(this.Cantidad_Click);
            // 
            // BtnNum7
            // 
            this.BtnNum7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNum7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnNum7.Location = new System.Drawing.Point(302, 1);
            this.BtnNum7.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNum7.Name = "BtnNum7";
            this.BtnNum7.Size = new System.Drawing.Size(48, 48);
            this.BtnNum7.TabIndex = 6;
            this.BtnNum7.Tag = "7";
            this.BtnNum7.Text = "7";
            this.BtnNum7.UseVisualStyleBackColor = false;
            this.BtnNum7.Click += new System.EventHandler(this.Cantidad_Click);
            // 
            // BtnNum8
            // 
            this.BtnNum8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNum8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnNum8.Location = new System.Drawing.Point(352, 1);
            this.BtnNum8.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNum8.Name = "BtnNum8";
            this.BtnNum8.Size = new System.Drawing.Size(48, 48);
            this.BtnNum8.TabIndex = 7;
            this.BtnNum8.Tag = "8";
            this.BtnNum8.Text = "8";
            this.BtnNum8.UseVisualStyleBackColor = false;
            this.BtnNum8.Click += new System.EventHandler(this.Cantidad_Click);
            // 
            // BtnNum3
            // 
            this.BtnNum3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNum3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnNum3.Location = new System.Drawing.Point(102, 1);
            this.BtnNum3.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNum3.Name = "BtnNum3";
            this.BtnNum3.Size = new System.Drawing.Size(48, 48);
            this.BtnNum3.TabIndex = 8;
            this.BtnNum3.Tag = "3";
            this.BtnNum3.Text = "3";
            this.BtnNum3.UseVisualStyleBackColor = false;
            this.BtnNum3.Click += new System.EventHandler(this.Cantidad_Click);
            // 
            // BtnNum2
            // 
            this.BtnNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNum2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnNum2.Location = new System.Drawing.Point(52, 1);
            this.BtnNum2.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNum2.Name = "BtnNum2";
            this.BtnNum2.Size = new System.Drawing.Size(48, 48);
            this.BtnNum2.TabIndex = 9;
            this.BtnNum2.Tag = "2";
            this.BtnNum2.Text = "2";
            this.BtnNum2.UseVisualStyleBackColor = false;
            this.BtnNum2.Click += new System.EventHandler(this.Cantidad_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Teal;
            this.flowLayoutPanel1.Controls.Add(this.BtnNum1);
            this.flowLayoutPanel1.Controls.Add(this.BtnNum2);
            this.flowLayoutPanel1.Controls.Add(this.BtnNum3);
            this.flowLayoutPanel1.Controls.Add(this.BtnNum4);
            this.flowLayoutPanel1.Controls.Add(this.BtnNum5);
            this.flowLayoutPanel1.Controls.Add(this.BtnNum6);
            this.flowLayoutPanel1.Controls.Add(this.BtnNum7);
            this.flowLayoutPanel1.Controls.Add(this.BtnNum8);
            this.flowLayoutPanel1.Controls.Add(this.BtnNum9);
            this.flowLayoutPanel1.Controls.Add(this.BtnNum0);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(502, 50);
            this.flowLayoutPanel1.TabIndex = 25;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // timerHora
            // 
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel2.Controls.Add(this.btnMenuRegular);
            this.flowLayoutPanel2.Controls.Add(this.btnCombos);
            this.flowLayoutPanel2.Controls.Add(this.btnBevidas);
            this.flowLayoutPanel2.Controls.Add(this.btnPostres);
            this.flowLayoutPanel2.Controls.Add(this.btnAdicionales);
            this.flowLayoutPanel2.Controls.Add(this.btnPrecio);
            this.flowLayoutPanel2.Controls.Add(this.btnProductosTemporada);
            this.flowLayoutPanel2.Controls.Add(this.btnPedidoEspecial);
            this.flowLayoutPanel2.Controls.Add(this.btnFuncionesPOS);
            this.flowLayoutPanel2.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel2.Controls.Add(this.btnLlevar);
            this.flowLayoutPanel2.Controls.Add(this.btnComerAqui);
            this.flowLayoutPanel2.Controls.Add(this.btnMesa);
            this.flowLayoutPanel2.Controls.Add(this.btnExpress);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(504, 52);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(235, 616);
            this.flowLayoutPanel2.TabIndex = 27;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 21);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(51, 21);
            this.toolStripLabel2.Text = "Gerente:";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(122, 21);
            this.toolStripLabel3.Text = "Alberth Garita Retana ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 24);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 21);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 21);
            this.toolStripLabel1.Text = "Cajero: ";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(126, 21);
            this.toolStripLabel4.Text = "Dayanna Garita Retana";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(0, 21);
            // 
            // tsbFecha
            // 
            this.tsbFecha.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbFecha.Name = "tsbFecha";
            this.tsbFecha.Size = new System.Drawing.Size(113, 21);
            this.tsbFecha.Text = "Jueves 29 Diciembre";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::AppSodaQuincho.Properties.Resources.calendar;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 21);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 24);
            // 
            // tsbHora
            // 
            this.tsbHora.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbHora.Name = "tsbHora";
            this.tsbHora.Size = new System.Drawing.Size(70, 21);
            this.tsbHora.Text = "00:00:00 PM";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::AppSodaQuincho.Properties.Resources.clock;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 21);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 24);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 24);
            // 
            // tspBarraCarga
            // 
            this.tspBarraCarga.AutoSize = false;
            this.tspBarraCarga.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspBarraCarga.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripLabel1,
            this.toolStripLabel4,
            this.toolStripLabel5,
            this.tsbFecha,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.tsbHora,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripSeparator3});
            this.tspBarraCarga.Location = new System.Drawing.Point(0, 668);
            this.tspBarraCarga.Name = "tspBarraCarga";
            this.tspBarraCarga.Size = new System.Drawing.Size(1020, 24);
            this.tspBarraCarga.TabIndex = 24;
            this.tspBarraCarga.Text = "toolStrip1";
            // 
            // dBSodaQuinchoDataSet
            // 
            this.dBSodaQuinchoDataSet.DataSetName = "DBSodaQuinchoDataSet";
            this.dBSodaQuinchoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detFacturaBindingSource
            // 
            this.detFacturaBindingSource.DataMember = "DetFactura";
            this.detFacturaBindingSource.DataSource = this.dBSodaQuinchoDataSet;
            // 
            // detFacturaTableAdapter
            // 
            this.detFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // PanelEstadoFactura
            // 
            this.PanelEstadoFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PanelEstadoFactura.Controls.Add(this.lblEstadoFactura);
            this.PanelEstadoFactura.Location = new System.Drawing.Point(739, 497);
            this.PanelEstadoFactura.Name = "PanelEstadoFactura";
            this.PanelEstadoFactura.Size = new System.Drawing.Size(280, 28);
            this.PanelEstadoFactura.TabIndex = 29;
            // 
            // lblEstadoFactura
            // 
            this.lblEstadoFactura.AutoSize = true;
            this.lblEstadoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoFactura.Location = new System.Drawing.Point(85, 3);
            this.lblEstadoFactura.Name = "lblEstadoFactura";
            this.lblEstadoFactura.Size = new System.Drawing.Size(125, 24);
            this.lblEstadoFactura.TabIndex = 0;
            this.lblEstadoFactura.Text = "No Facturado";
            // 
            // dgvPlatos
            // 
            this.dgvPlatos.AllowUserToAddRows = false;
            this.dgvPlatos.AllowUserToDeleteRows = false;
            this.dgvPlatos.AllowUserToResizeColumns = false;
            this.dgvPlatos.AllowUserToResizeRows = false;
            this.dgvPlatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPlatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Cantidad,
            this.Nombre,
            this.Precio});
            this.dgvPlatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPlatos.GridColor = System.Drawing.Color.DarkGray;
            this.dgvPlatos.Location = new System.Drawing.Point(740, 52);
            this.dgvPlatos.MultiSelect = false;
            this.dgvPlatos.Name = "dgvPlatos";
            this.dgvPlatos.ReadOnly = true;
            this.dgvPlatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlatos.RowHeadersVisible = false;
            this.dgvPlatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvPlatos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlatos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlatos.RowTemplate.Height = 30;
            this.dgvPlatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPlatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlatos.ShowCellErrors = false;
            this.dgvPlatos.ShowCellToolTips = false;
            this.dgvPlatos.ShowEditingIcon = false;
            this.dgvPlatos.ShowRowErrors = false;
            this.dgvPlatos.Size = new System.Drawing.Size(279, 445);
            this.dgvPlatos.TabIndex = 28;
            // 
            // PanelTimerFactura
            // 
            this.PanelTimerFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PanelTimerFactura.Controls.Add(this.lblTiempoFactura);
            this.PanelTimerFactura.Location = new System.Drawing.Point(945, 1);
            this.PanelTimerFactura.Name = "PanelTimerFactura";
            this.PanelTimerFactura.Size = new System.Drawing.Size(75, 50);
            this.PanelTimerFactura.TabIndex = 1;
            // 
            // lblTiempoFactura
            // 
            this.lblTiempoFactura.AutoSize = true;
            this.lblTiempoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoFactura.ForeColor = System.Drawing.Color.Black;
            this.lblTiempoFactura.Location = new System.Drawing.Point(19, 14);
            this.lblTiempoFactura.Name = "lblTiempoFactura";
            this.lblTiempoFactura.Size = new System.Drawing.Size(40, 24);
            this.lblTiempoFactura.TabIndex = 0;
            this.lblTiempoFactura.Text = "000";
            // 
            // timerFactura
            // 
            this.timerFactura.Interval = 1000;
            this.timerFactura.Tick += new System.EventHandler(this.timerFactura_Tick);
            // 
            // timerPicture
            // 
            this.timerPicture.Tick += new System.EventHandler(this.timerPicture_Tick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ID_DetFactura";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "#";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre_Plato";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 140;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Total";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 105;
            // 
            // frmFacturacion
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 692);
            this.Controls.Add(this.PanelTimerFactura);
            this.Controls.Add(this.PanelEstadoFactura);
            this.Controls.Add(this.dgvPlatos);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.tspBarraCarga);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHora);
            this.Controls.Add(this.panelCantidad);
            this.Controls.Add(this.PanelPlato);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFacturacion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.panelCantidad.ResumeLayout(false);
            this.panelCantidad.PerformLayout();
            this.panelHora.ResumeLayout(false);
            this.panelHora.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tspBarraCarga.ResumeLayout(false);
            this.tspBarraCarga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBSodaQuinchoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detFacturaBindingSource)).EndInit();
            this.PanelEstadoFactura.ResumeLayout(false);
            this.PanelEstadoFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).EndInit();
            this.PanelTimerFactura.ResumeLayout(false);
            this.PanelTimerFactura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPlato;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTituloCantidad;
        private System.Windows.Forms.Button btnPostres;
        private System.Windows.Forms.Button btnMenuRegular;
        private System.Windows.Forms.Button btnAdicionales;
        private System.Windows.Forms.Button btnBevidas;
        private System.Windows.Forms.Button btnLlevar;
        private System.Windows.Forms.Button btnMesa;
        private System.Windows.Forms.Button btnComerAqui;
        private System.Windows.Forms.Button btnExpress;
        private System.Windows.Forms.Panel panelCantidad;
        private System.Windows.Forms.Panel panelHora;
        private System.Windows.Forms.Button btnCombos;
        private System.Windows.Forms.Button btnPedidoEspecial;
        private System.Windows.Forms.Button btnProductosTemporada;
        private System.Windows.Forms.Button btnPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnNum1;
        private System.Windows.Forms.Button BtnNum4;
        private System.Windows.Forms.Button BtnNum5;
        private System.Windows.Forms.Button BtnNum6;
        private System.Windows.Forms.Button BtnNum9;
        private System.Windows.Forms.Button BtnNum0;
        private System.Windows.Forms.Button BtnNum7;
        private System.Windows.Forms.Button BtnNum8;
        private System.Windows.Forms.Button BtnNum3;
        private System.Windows.Forms.Button BtnNum2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Efectivo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnFuncionesPOS;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel tsbFecha;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel tsbHora;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip tspBarraCarga;
        private DBSodaQuinchoDataSet dBSodaQuinchoDataSet;
        private System.Windows.Forms.BindingSource detFacturaBindingSource;
        private DBSodaQuinchoDataSetTableAdapters.DetFacturaTableAdapter detFacturaTableAdapter;
        private System.Windows.Forms.MaskedTextBox txtTotalFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelEstadoFactura;
        private System.Windows.Forms.Label lblEstadoFactura;
        private System.Windows.Forms.DataGridView dgvPlatos;
        private System.Windows.Forms.Panel PanelTimerFactura;
        private System.Windows.Forms.Label lblTiempoFactura;
        private System.Windows.Forms.Timer timerFactura;
        private System.Windows.Forms.Timer timerPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}

