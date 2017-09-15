namespace AppSodaQuincho
{
    partial class frmMantenimientoPlato
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoPlato));
            this.dgvPlato = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioPlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbInsertar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ofdImagen = new System.Windows.Forms.OpenFileDialog();
            this.txtNombrePlato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipoPlato = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelPlato = new System.Windows.Forms.GroupBox();
            this.ptbFotografia = new System.Windows.Forms.PictureBox();
            this.cboBuscarTipoPlato = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlato)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.PanelPlato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotografia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlato
            // 
            this.dgvPlato.AllowUserToAddRows = false;
            this.dgvPlato.AllowUserToDeleteRows = false;
            this.dgvPlato.AllowUserToResizeColumns = false;
            this.dgvPlato.AllowUserToResizeRows = false;
            this.dgvPlato.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPlato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlato.ColumnHeadersHeight = 30;
            this.dgvPlato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPlato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NombrePlato,
            this.PrecioPlato,
            this.TipoPlato,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlato.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlato.Location = new System.Drawing.Point(367, 93);
            this.dgvPlato.Name = "dgvPlato";
            this.dgvPlato.ReadOnly = true;
            this.dgvPlato.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlato.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlato.RowHeadersWidth = 20;
            this.dgvPlato.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPlato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlato.Size = new System.Drawing.Size(648, 579);
            this.dgvPlato.TabIndex = 1;
            this.dgvPlato.TabStop = false;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "ID_Plato";
            this.Codigo.FillWeight = 101.5228F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NombrePlato
            // 
            this.NombrePlato.DataPropertyName = "Nombre_Plato";
            this.NombrePlato.FillWeight = 99.61929F;
            this.NombrePlato.HeaderText = "Nombre Plato";
            this.NombrePlato.Name = "NombrePlato";
            this.NombrePlato.ReadOnly = true;
            this.NombrePlato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombrePlato.Width = 150;
            // 
            // PrecioPlato
            // 
            this.PrecioPlato.DataPropertyName = "Precio_Plato";
            this.PrecioPlato.FillWeight = 99.61929F;
            this.PrecioPlato.HeaderText = "Precio Plato";
            this.PrecioPlato.Name = "PrecioPlato";
            this.PrecioPlato.ReadOnly = true;
            this.PrecioPlato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PrecioPlato.Width = 124;
            // 
            // TipoPlato
            // 
            this.TipoPlato.DataPropertyName = "Descripcion";
            this.TipoPlato.FillWeight = 99.61929F;
            this.TipoPlato.HeaderText = "Tipo Plato";
            this.TipoPlato.Name = "TipoPlato";
            this.TipoPlato.ReadOnly = true;
            this.TipoPlato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TipoPlato.Width = 124;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "foto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Foto";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Estado";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 60);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 60);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInsertar,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.tsbSalir,
            this.toolStripSeparator2,
            this.tsbModificar,
            this.toolStripSeparator3,
            this.toolStripComboBox1,
            this.toolStripTextBox1,
            this.toolStripButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1020, 60);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbInsertar
            // 
            this.tsbInsertar.AutoSize = false;
            this.tsbInsertar.Image = ((System.Drawing.Image)(resources.GetObject("tsbInsertar.Image")));
            this.tsbInsertar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsertar.Name = "tsbInsertar";
            this.tsbInsertar.Size = new System.Drawing.Size(80, 70);
            this.tsbInsertar.Text = "Insertar";
            this.tsbInsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbInsertar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbInsertar.Click += new System.EventHandler(this.tsbInsertar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 60);
            // 
            // tsbSalir
            // 
            this.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSalir.AutoSize = false;
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(80, 70);
            this.tsbSalir.Text = "   Salir   ";
            this.tsbSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbModificar
            // 
            this.tsbModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbModificar.AutoSize = false;
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(80, 70);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 60);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBox1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripComboBox1.Margin = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 60);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(250, 60);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = global::AppSodaQuincho.Properties.Resources.Search;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 73);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // ofdImagen
            // 
            this.ofdImagen.FileName = "openFileDialog1";
            this.ofdImagen.RestoreDirectory = true;
            // 
            // txtNombrePlato
            // 
            this.txtNombrePlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePlato.Location = new System.Drawing.Point(88, 35);
            this.txtNombrePlato.Name = "txtNombrePlato";
            this.txtNombrePlato.Size = new System.Drawing.Size(228, 30);
            this.txtNombrePlato.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo";
            // 
            // cboTipoPlato
            // 
            this.cboTipoPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoPlato.FormattingEnabled = true;
            this.cboTipoPlato.Location = new System.Drawing.Point(88, 205);
            this.cboTipoPlato.Name = "cboTipoPlato";
            this.cboTipoPlato.Size = new System.Drawing.Size(228, 33);
            this.cboTipoPlato.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAceptar.Location = new System.Drawing.Point(18, 541);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 48);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 10;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(88, 120);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(228, 30);
            this.txtPrecio.TabIndex = 1;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Precio";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLimpiar.Location = new System.Drawing.Point(133, 541);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 48);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Location = new System.Drawing.Point(248, 541);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 48);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(7, 301);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(73, 25);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.Text = "Estado";
            // 
            // cboEstado
            // 
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(88, 293);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(228, 33);
            this.cboEstado.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Foto";
            // 
            // PanelPlato
            // 
            this.PanelPlato.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelPlato.Controls.Add(this.label5);
            this.PanelPlato.Controls.Add(this.cboEstado);
            this.PanelPlato.Controls.Add(this.lblEstado);
            this.PanelPlato.Controls.Add(this.btnCancelar);
            this.PanelPlato.Controls.Add(this.btnLimpiar);
            this.PanelPlato.Controls.Add(this.label4);
            this.PanelPlato.Controls.Add(this.txtPrecio);
            this.PanelPlato.Controls.Add(this.label3);
            this.PanelPlato.Controls.Add(this.btnAceptar);
            this.PanelPlato.Controls.Add(this.cboTipoPlato);
            this.PanelPlato.Controls.Add(this.ptbFotografia);
            this.PanelPlato.Controls.Add(this.label2);
            this.PanelPlato.Controls.Add(this.label1);
            this.PanelPlato.Controls.Add(this.txtNombrePlato);
            this.PanelPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelPlato.Location = new System.Drawing.Point(6, 63);
            this.PanelPlato.Name = "PanelPlato";
            this.PanelPlato.Size = new System.Drawing.Size(356, 625);
            this.PanelPlato.TabIndex = 0;
            this.PanelPlato.TabStop = false;
            this.PanelPlato.Text = "Mantenimiento Plato";
            // 
            // ptbFotografia
            // 
            this.ptbFotografia.BackColor = System.Drawing.Color.White;
            this.ptbFotografia.Location = new System.Drawing.Point(127, 381);
            this.ptbFotografia.Name = "ptbFotografia";
            this.ptbFotografia.Size = new System.Drawing.Size(115, 118);
            this.ptbFotografia.TabIndex = 11;
            this.ptbFotografia.TabStop = false;
            this.ptbFotografia.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cboBuscarTipoPlato
            // 
            this.cboBuscarTipoPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuscarTipoPlato.FormattingEnabled = true;
            this.cboBuscarTipoPlato.Location = new System.Drawing.Point(881, 61);
            this.cboBuscarTipoPlato.Name = "cboBuscarTipoPlato";
            this.cboBuscarTipoPlato.Size = new System.Drawing.Size(133, 28);
            this.cboBuscarTipoPlato.TabIndex = 17;
            this.cboBuscarTipoPlato.SelectedValueChanged += new System.EventHandler(this.cboBuscarTipoPlato_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(799, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mostrar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(944, 675);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cantidad :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(999, 675);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "0";
            // 
            // frmMantenimientoPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1020, 692);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboBuscarTipoPlato);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvPlato);
            this.Controls.Add(this.PanelPlato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMantenimientoPlato";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoPlato";
            this.Load += new System.EventHandler(this.MantenimientoPlato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlato)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PanelPlato.ResumeLayout(false);
            this.PanelPlato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotografia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPlato;
        private System.Windows.Forms.ToolStripButton tsbInsertar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.OpenFileDialog ofdImagen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.TextBox txtNombrePlato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptbFotografia;
        private System.Windows.Forms.ComboBox cboTipoPlato;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox PanelPlato;
        private System.Windows.Forms.ComboBox cboBuscarTipoPlato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePlato;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPlato;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPlato;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}