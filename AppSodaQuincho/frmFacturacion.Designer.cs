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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCombos = new System.Windows.Forms.Button();
            this.txtPago = new System.Windows.Forms.MaskedTextBox();
            this.btnPedidoEspecial = new System.Windows.Forms.Button();
            this.btnProductosTemporada = new System.Windows.Forms.Button();
            this.btnPrecio = new System.Windows.Forms.Button();
            this.btnBevidas = new System.Windows.Forms.Button();
            this.btnAdicionales = new System.Windows.Forms.Button();
            this.btnPostres = new System.Windows.Forms.Button();
            this.btnMenuRegular = new System.Windows.Forms.Button();
            this.lblTituloCantidad = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnFuncionesPOS = new System.Windows.Forms.Button();
            this.btnMesa = new System.Windows.Forms.Button();
            this.btnComerAqui = new System.Windows.Forms.Button();
            this.btnExpress = new System.Windows.Forms.Button();
            this.btnLlevar = new System.Windows.Forms.Button();
            this.PanelCantidad = new System.Windows.Forms.Panel();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.tlsGerente = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsCajero = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.tsbFecha = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbHora = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tspBarraCarga = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.detFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvPlatos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerFactura = new System.Windows.Forms.Timer(this.components);
            this.timerPicture = new System.Windows.Forms.Timer(this.components);
            this.lblBannerFactura = new System.Windows.Forms.Label();
            this.panelHora = new System.Windows.Forms.Panel();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txtCambio = new System.Windows.Forms.MaskedTextBox();
            this.txtEfectivo = new System.Windows.Forms.MaskedTextBox();
            this.PanelBannerFactura = new System.Windows.Forms.Panel();
            this.txtTotalFactura = new System.Windows.Forms.MaskedTextBox();
            this.Efectivo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTiempoFactura = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelPlato = new System.Windows.Forms.Panel();
            this.PanelCantidad.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tspBarraCarga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).BeginInit();
            this.panelHora.SuspendLayout();
            this.PanelBannerFactura.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCombos
            // 
            this.btnCombos.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCombos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCombos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCombos.Location = new System.Drawing.Point(118, 5);
            this.btnCombos.Margin = new System.Windows.Forms.Padding(1, 5, 1, 1);
            this.btnCombos.Name = "btnCombos";
            this.btnCombos.Size = new System.Drawing.Size(113, 84);
            this.btnCombos.TabIndex = 8;
            this.btnCombos.Text = "Combos";
            this.btnCombos.UseVisualStyleBackColor = false;
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(0, 0);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(100, 20);
            this.txtPago.TabIndex = 0;
            // 
            // btnPedidoEspecial
            // 
            this.btnPedidoEspecial.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnPedidoEspecial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidoEspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPedidoEspecial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPedidoEspecial.Location = new System.Drawing.Point(118, 263);
            this.btnPedidoEspecial.Margin = new System.Windows.Forms.Padding(1);
            this.btnPedidoEspecial.Name = "btnPedidoEspecial";
            this.btnPedidoEspecial.Size = new System.Drawing.Size(113, 84);
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
            this.btnProductosTemporada.Location = new System.Drawing.Point(3, 263);
            this.btnProductosTemporada.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.btnProductosTemporada.Name = "btnProductosTemporada";
            this.btnProductosTemporada.Size = new System.Drawing.Size(113, 84);
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
            this.btnPrecio.Size = new System.Drawing.Size(113, 84);
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
            this.btnBevidas.Location = new System.Drawing.Point(3, 91);
            this.btnBevidas.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.btnBevidas.Name = "btnBevidas";
            this.btnBevidas.Size = new System.Drawing.Size(113, 84);
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
            this.btnAdicionales.Location = new System.Drawing.Point(3, 177);
            this.btnAdicionales.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.btnAdicionales.Name = "btnAdicionales";
            this.btnAdicionales.Size = new System.Drawing.Size(113, 84);
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
            this.btnPostres.Location = new System.Drawing.Point(118, 91);
            this.btnPostres.Margin = new System.Windows.Forms.Padding(1);
            this.btnPostres.Name = "btnPostres";
            this.btnPostres.Size = new System.Drawing.Size(113, 84);
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
            this.btnMenuRegular.Location = new System.Drawing.Point(3, 5);
            this.btnMenuRegular.Margin = new System.Windows.Forms.Padding(3, 5, 1, 1);
            this.btnMenuRegular.Name = "btnMenuRegular";
            this.btnMenuRegular.Size = new System.Drawing.Size(113, 84);
            this.btnMenuRegular.TabIndex = 0;
            this.btnMenuRegular.Text = "Menu Regular";
            this.btnMenuRegular.UseVisualStyleBackColor = false;
            this.btnMenuRegular.Click += new System.EventHandler(this.btnMenuRegular_Click);
            // 
            // lblTituloCantidad
            // 
            this.lblTituloCantidad.AutoSize = true;
            this.lblTituloCantidad.BackColor = System.Drawing.Color.Silver;
            this.lblTituloCantidad.Font = new System.Drawing.Font("Berlin Sans FB", 16F);
            this.lblTituloCantidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTituloCantidad.Location = new System.Drawing.Point(55, 12);
            this.lblTituloCantidad.Name = "lblTituloCantidad";
            this.lblTituloCantidad.Size = new System.Drawing.Size(102, 24);
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
            this.btnEliminar.Location = new System.Drawing.Point(118, 349);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 84);
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
            this.btnFuncionesPOS.Location = new System.Drawing.Point(3, 349);
            this.btnFuncionesPOS.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.btnFuncionesPOS.Name = "btnFuncionesPOS";
            this.btnFuncionesPOS.Size = new System.Drawing.Size(113, 84);
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
            this.btnMesa.Location = new System.Drawing.Point(3, 521);
            this.btnMesa.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.btnMesa.Name = "btnMesa";
            this.btnMesa.Size = new System.Drawing.Size(113, 84);
            this.btnMesa.TabIndex = 3;
            this.btnMesa.Text = "Orden Mesa";
            this.btnMesa.UseVisualStyleBackColor = false;
            this.btnMesa.Click += new System.EventHandler(this.btnMesa_Click);
            // 
            // btnComerAqui
            // 
            this.btnComerAqui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnComerAqui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComerAqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComerAqui.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnComerAqui.Location = new System.Drawing.Point(118, 435);
            this.btnComerAqui.Margin = new System.Windows.Forms.Padding(1);
            this.btnComerAqui.Name = "btnComerAqui";
            this.btnComerAqui.Size = new System.Drawing.Size(113, 84);
            this.btnComerAqui.TabIndex = 2;
            this.btnComerAqui.Text = "Pago para Comer Aqui";
            this.btnComerAqui.UseVisualStyleBackColor = false;
            this.btnComerAqui.Click += new System.EventHandler(this.btnComerAqui_Click);
            // 
            // btnExpress
            // 
            this.btnExpress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExpress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExpress.Location = new System.Drawing.Point(118, 521);
            this.btnExpress.Margin = new System.Windows.Forms.Padding(1);
            this.btnExpress.Name = "btnExpress";
            this.btnExpress.Size = new System.Drawing.Size(113, 84);
            this.btnExpress.TabIndex = 1;
            this.btnExpress.Text = "Express";
            this.btnExpress.UseVisualStyleBackColor = false;
            this.btnExpress.Click += new System.EventHandler(this.btnExpress_Click);
            // 
            // btnLlevar
            // 
            this.btnLlevar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLlevar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLlevar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlevar.Location = new System.Drawing.Point(3, 435);
            this.btnLlevar.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.btnLlevar.Name = "btnLlevar";
            this.btnLlevar.Size = new System.Drawing.Size(113, 84);
            this.btnLlevar.TabIndex = 0;
            this.btnLlevar.Text = "Pago para Llevar";
            this.btnLlevar.UseVisualStyleBackColor = false;
            this.btnLlevar.Click += new System.EventHandler(this.btnLlevar_Click);
            // 
            // PanelCantidad
            // 
            this.PanelCantidad.BackColor = System.Drawing.Color.Silver;
            this.PanelCantidad.Controls.Add(this.txtCantidad);
            this.PanelCantidad.Controls.Add(this.lblTituloCantidad);
            this.PanelCantidad.Location = new System.Drawing.Point(505, 1);
            this.PanelCantidad.Name = "PanelCantidad";
            this.PanelCantidad.Size = new System.Drawing.Size(235, 50);
            this.PanelCantidad.TabIndex = 18;
            this.PanelCantidad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelCantidad_MouseClick);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(153, 12);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(30, 25);
            this.txtCantidad.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Factura";
            // 
            // BtnNum1
            // 
            this.BtnNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnNum1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnNum1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNum1.ForeColor = System.Drawing.Color.Black;
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
            this.BtnNum4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnNum4.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnNum4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNum4.ForeColor = System.Drawing.Color.Black;
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
            this.BtnNum5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnNum5.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnNum5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNum5.ForeColor = System.Drawing.Color.Black;
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
            this.BtnNum6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnNum6.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnNum6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNum6.ForeColor = System.Drawing.Color.Black;
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
            this.BtnNum9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnNum9.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnNum9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNum9.ForeColor = System.Drawing.Color.Black;
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
            this.BtnNum0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnNum0.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnNum0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNum0.ForeColor = System.Drawing.Color.Black;
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
            this.BtnNum7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnNum7.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnNum7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNum7.ForeColor = System.Drawing.Color.Black;
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
            this.BtnNum8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnNum8.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnNum8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNum8.ForeColor = System.Drawing.Color.Black;
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
            this.BtnNum3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnNum3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnNum3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNum3.ForeColor = System.Drawing.Color.Black;
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
            this.BtnNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnNum2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnNum2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNum2.ForeColor = System.Drawing.Color.Black;
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
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
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
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.DimGray;
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
            this.flowLayoutPanel2.Location = new System.Drawing.Point(505, 52);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(235, 613);
            this.flowLayoutPanel2.TabIndex = 27;
            // 
            // tlsGerente
            // 
            this.tlsGerente.Name = "tlsGerente";
            this.tlsGerente.Size = new System.Drawing.Size(113, 21);
            this.tlsGerente.Text = "No ahi Turno Abirto";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 24);
            // 
            // tlsCajero
            // 
            this.tlsCajero.Name = "tlsCajero";
            this.tlsCajero.Size = new System.Drawing.Size(134, 21);
            this.tlsCajero.Text = "No ahi Cajero Ingresado";
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 24);
            // 
            // tspBarraCarga
            // 
            this.tspBarraCarga.AutoSize = false;
            this.tspBarraCarga.BackColor = System.Drawing.Color.Silver;
            this.tspBarraCarga.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspBarraCarga.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel2,
            this.tlsGerente,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripLabel1,
            this.tlsCajero,
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
            this.tspBarraCarga.Size = new System.Drawing.Size(1018, 24);
            this.tspBarraCarga.TabIndex = 24;
            this.tspBarraCarga.Text = "toolStrip1";
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 24);
            // 
            // detFacturaBindingSource
            // 
            this.detFacturaBindingSource.DataMember = "DetFactura";
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
            this.dgvPlatos.Location = new System.Drawing.Point(4, 3);
            this.dgvPlatos.MultiSelect = false;
            this.dgvPlatos.Name = "dgvPlatos";
            this.dgvPlatos.ReadOnly = true;
            this.dgvPlatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlatos.RowHeadersVisible = false;
            this.dgvPlatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvPlatos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlatos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlatos.RowTemplate.Height = 30;
            this.dgvPlatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPlatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlatos.ShowCellErrors = false;
            this.dgvPlatos.ShowCellToolTips = false;
            this.dgvPlatos.ShowEditingIcon = false;
            this.dgvPlatos.ShowRowErrors = false;
            this.dgvPlatos.Size = new System.Drawing.Size(264, 445);
            this.dgvPlatos.TabIndex = 28;
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
            this.Nombre.Width = 165;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Total";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 80;
            // 
            // timerFactura
            // 
            this.timerFactura.Interval = 1000;
            this.timerFactura.Tick += new System.EventHandler(this.timerFactura_Tick);
            // 
            // lblBannerFactura
            // 
            this.lblBannerFactura.AutoSize = true;
            this.lblBannerFactura.BackColor = System.Drawing.Color.Silver;
            this.lblBannerFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBannerFactura.Location = new System.Drawing.Point(64, 3);
            this.lblBannerFactura.Name = "lblBannerFactura";
            this.lblBannerFactura.Size = new System.Drawing.Size(133, 24);
            this.lblBannerFactura.TabIndex = 0;
            this.lblBannerFactura.Text = "Nueva Factura";
            // 
            // panelHora
            // 
            this.panelHora.BackColor = System.Drawing.Color.DimGray;
            this.panelHora.Controls.Add(this.maskedTextBox3);
            this.panelHora.Controls.Add(this.maskedTextBox2);
            this.panelHora.Controls.Add(this.maskedTextBox1);
            this.panelHora.Controls.Add(this.txtCambio);
            this.panelHora.Controls.Add(this.txtEfectivo);
            this.panelHora.Controls.Add(this.PanelBannerFactura);
            this.panelHora.Controls.Add(this.txtTotalFactura);
            this.panelHora.Controls.Add(this.Efectivo);
            this.panelHora.Controls.Add(this.label1);
            this.panelHora.Controls.Add(this.label3);
            this.panelHora.Controls.Add(this.dgvPlatos);
            this.panelHora.Location = new System.Drawing.Point(743, 53);
            this.panelHora.Name = "panelHora";
            this.panelHora.Size = new System.Drawing.Size(274, 612);
            this.panelHora.TabIndex = 19;
            this.panelHora.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHora_Paint);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox3.Location = new System.Drawing.Point(117, 527);
            this.maskedTextBox3.Mask = "₡";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(28, 33);
            this.maskedTextBox3.TabIndex = 40;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(117, 566);
            this.maskedTextBox2.Mask = "₡";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(28, 33);
            this.maskedTextBox2.TabIndex = 39;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(117, 488);
            this.maskedTextBox1.Mask = "₡";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(28, 33);
            this.maskedTextBox1.TabIndex = 38;
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(145, 566);
            this.txtCambio.Mask = "999999";
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(118, 33);
            this.txtCambio.TabIndex = 37;
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.BackColor = System.Drawing.SystemColors.Control;
            this.txtEfectivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtEfectivo.Enabled = false;
            this.txtEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivo.Location = new System.Drawing.Point(145, 527);
            this.txtEfectivo.Mask = "999999";
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.ReadOnly = true;
            this.txtEfectivo.Size = new System.Drawing.Size(118, 33);
            this.txtEfectivo.TabIndex = 36;
            // 
            // PanelBannerFactura
            // 
            this.PanelBannerFactura.BackColor = System.Drawing.Color.Silver;
            this.PanelBannerFactura.Controls.Add(this.lblBannerFactura);
            this.PanelBannerFactura.Location = new System.Drawing.Point(4, 448);
            this.PanelBannerFactura.Name = "PanelBannerFactura";
            this.PanelBannerFactura.Size = new System.Drawing.Size(264, 33);
            this.PanelBannerFactura.TabIndex = 35;
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTotalFactura.Enabled = false;
            this.txtTotalFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFactura.Location = new System.Drawing.Point(145, 488);
            this.txtTotalFactura.Mask = "999999";
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.ReadOnly = true;
            this.txtTotalFactura.Size = new System.Drawing.Size(118, 33);
            this.txtTotalFactura.TabIndex = 34;
            // 
            // Efectivo
            // 
            this.Efectivo.AutoSize = true;
            this.Efectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Efectivo.Location = new System.Drawing.Point(17, 534);
            this.Efectivo.Name = "Efectivo";
            this.Efectivo.Size = new System.Drawing.Size(98, 29);
            this.Efectivo.TabIndex = 33;
            this.Efectivo.Text = "Efectivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 573);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Cambio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Total";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblTiempoFactura);
            this.panel3.Location = new System.Drawing.Point(201, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(41, 26);
            this.panel3.TabIndex = 36;
            // 
            // lblTiempoFactura
            // 
            this.lblTiempoFactura.AutoSize = true;
            this.lblTiempoFactura.BackColor = System.Drawing.Color.White;
            this.lblTiempoFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTiempoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoFactura.ForeColor = System.Drawing.Color.Black;
            this.lblTiempoFactura.Location = new System.Drawing.Point(4, 5);
            this.lblTiempoFactura.Name = "lblTiempoFactura";
            this.lblTiempoFactura.Size = new System.Drawing.Size(34, 19);
            this.lblTiempoFactura.TabIndex = 0;
            this.lblTiempoFactura.Text = "      ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(743, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 50);
            this.panel2.TabIndex = 29;
            // 
            // PanelPlato
            // 
            this.PanelPlato.AutoScroll = true;
            this.PanelPlato.BackColor = System.Drawing.Color.Gray;
            this.PanelPlato.Location = new System.Drawing.Point(2, 52);
            this.PanelPlato.Margin = new System.Windows.Forms.Padding(1);
            this.PanelPlato.Name = "PanelPlato";
            this.PanelPlato.Size = new System.Drawing.Size(500, 610);
            this.PanelPlato.TabIndex = 30;
            // 
            // frmFacturacion
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1018, 692);
            this.Controls.Add(this.PanelPlato);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.tspBarraCarga);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelHora);
            this.Controls.Add(this.PanelCantidad);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFacturacion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.PanelCantidad.ResumeLayout(false);
            this.PanelCantidad.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tspBarraCarga.ResumeLayout(false);
            this.tspBarraCarga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).EndInit();
            this.panelHora.ResumeLayout(false);
            this.panelHora.PerformLayout();
            this.PanelBannerFactura.ResumeLayout(false);
            this.PanelBannerFactura.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTituloCantidad;
        private System.Windows.Forms.Button btnPostres;
        private System.Windows.Forms.Button btnMenuRegular;
        private System.Windows.Forms.Button btnAdicionales;
        private System.Windows.Forms.Button btnBevidas;
        private System.Windows.Forms.Button btnLlevar;
        private System.Windows.Forms.Button btnMesa;
        private System.Windows.Forms.Button btnComerAqui;
        private System.Windows.Forms.Button btnExpress;
        private System.Windows.Forms.Panel PanelCantidad;
        private System.Windows.Forms.Button btnCombos;
        private System.Windows.Forms.MaskedTextBox txtPago;
        private System.Windows.Forms.Button btnPedidoEspecial;
        private System.Windows.Forms.Button btnProductosTemporada;
        private System.Windows.Forms.Button btnPrecio;
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
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnFuncionesPOS;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel tlsGerente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel tlsCajero;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel tsbFecha;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel tsbHora;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip tspBarraCarga;
        private System.Windows.Forms.BindingSource detFacturaBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPlatos;
        private System.Windows.Forms.Timer timerFactura;
        private System.Windows.Forms.Timer timerPicture;
        private System.Windows.Forms.Label lblBannerFactura;
        private System.Windows.Forms.Panel panelHora;
        private System.Windows.Forms.Label lblTiempoFactura;
        private System.Windows.Forms.MaskedTextBox txtTotalFactura;
        private System.Windows.Forms.Label Efectivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelBannerFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelPlato;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.MaskedTextBox txtCambio;
        private System.Windows.Forms.MaskedTextBox txtEfectivo;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

