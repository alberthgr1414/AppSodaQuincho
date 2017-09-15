namespace AppSodaQuincho
{
    partial class frmConfigurarTerminal
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblCaja = new System.Windows.Forms.Label();
            this.lblMac = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAutorizarCaja = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblConfCaja = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAutorizarImpresora = new System.Windows.Forms.Button();
            this.cboImpresoraSecundaria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboImpresoraPrimaria = new System.Windows.Forms.ComboBox();
            this.lblImpresoraPrimaria = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblConfImpresora = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(446, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(446, 163);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(205, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(524, 65);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblEmpresa.TabIndex = 2;
            this.lblEmpresa.Text = "Empresa";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(524, 133);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(48, 13);
            this.lblSucursal.TabIndex = 3;
            this.lblSucursal.Text = "Sucursal";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(488, 231);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 4;
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Location = new System.Drawing.Point(534, 201);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(28, 13);
            this.lblCaja.TabIndex = 5;
            this.lblCaja.Text = "Caja";
            // 
            // lblMac
            // 
            this.lblMac.AutoSize = true;
            this.lblMac.Location = new System.Drawing.Point(516, 269);
            this.lblMac.Name = "lblMac";
            this.lblMac.Size = new System.Drawing.Size(64, 13);
            this.lblMac.TabIndex = 6;
            this.lblMac.Text = "00:00:00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnAutorizarCaja);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblEmpresa);
            this.panel1.Controls.Add(this.lblMac);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblCaja);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.lblSucursal);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 362);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAutorizarCaja
            // 
            this.btnAutorizarCaja.Location = new System.Drawing.Point(488, 299);
            this.btnAutorizarCaja.Name = "btnAutorizarCaja";
            this.btnAutorizarCaja.Size = new System.Drawing.Size(114, 23);
            this.btnAutorizarCaja.TabIndex = 8;
            this.btnAutorizarCaja.Text = "Autorizar Caja";
            this.btnAutorizarCaja.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.lblConfCaja);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1018, 31);
            this.panel3.TabIndex = 7;
            // 
            // lblConfCaja
            // 
            this.lblConfCaja.AutoSize = true;
            this.lblConfCaja.Location = new System.Drawing.Point(499, 8);
            this.lblConfCaja.Name = "lblConfCaja";
            this.lblConfCaja.Size = new System.Drawing.Size(96, 13);
            this.lblConfCaja.TabIndex = 0;
            this.lblConfCaja.Text = "Configuracion Caja";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.btnAutorizarImpresora);
            this.panel2.Controls.Add(this.cboImpresoraSecundaria);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cboImpresoraPrimaria);
            this.panel2.Controls.Add(this.lblImpresoraPrimaria);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(0, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 342);
            this.panel2.TabIndex = 8;
            // 
            // btnAutorizarImpresora
            // 
            this.btnAutorizarImpresora.Location = new System.Drawing.Point(488, 255);
            this.btnAutorizarImpresora.Name = "btnAutorizarImpresora";
            this.btnAutorizarImpresora.Size = new System.Drawing.Size(121, 23);
            this.btnAutorizarImpresora.TabIndex = 13;
            this.btnAutorizarImpresora.Text = "Autorizar Impresora";
            this.btnAutorizarImpresora.UseVisualStyleBackColor = true;
            // 
            // cboImpresoraSecundaria
            // 
            this.cboImpresoraSecundaria.FormattingEnabled = true;
            this.cboImpresoraSecundaria.Location = new System.Drawing.Point(446, 194);
            this.cboImpresoraSecundaria.Name = "cboImpresoraSecundaria";
            this.cboImpresoraSecundaria.Size = new System.Drawing.Size(205, 21);
            this.cboImpresoraSecundaria.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Impresora Primaria";
            // 
            // cboImpresoraPrimaria
            // 
            this.cboImpresoraPrimaria.FormattingEnabled = true;
            this.cboImpresoraPrimaria.Location = new System.Drawing.Point(446, 112);
            this.cboImpresoraPrimaria.Name = "cboImpresoraPrimaria";
            this.cboImpresoraPrimaria.Size = new System.Drawing.Size(205, 21);
            this.cboImpresoraPrimaria.TabIndex = 10;
            // 
            // lblImpresoraPrimaria
            // 
            this.lblImpresoraPrimaria.AutoSize = true;
            this.lblImpresoraPrimaria.Location = new System.Drawing.Point(502, 78);
            this.lblImpresoraPrimaria.Name = "lblImpresoraPrimaria";
            this.lblImpresoraPrimaria.Size = new System.Drawing.Size(93, 13);
            this.lblImpresoraPrimaria.TabIndex = 9;
            this.lblImpresoraPrimaria.Text = "Impresora Primaria";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Controls.Add(this.lblConfImpresora);
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1018, 31);
            this.panel4.TabIndex = 8;
            // 
            // lblConfImpresora
            // 
            this.lblConfImpresora.AutoSize = true;
            this.lblConfImpresora.Location = new System.Drawing.Point(488, 10);
            this.lblConfImpresora.Name = "lblConfImpresora";
            this.lblConfImpresora.Size = new System.Drawing.Size(121, 13);
            this.lblConfImpresora.TabIndex = 0;
            this.lblConfImpresora.Text = "Configuracion Impresora";
            // 
            // frmConfigurarTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 692);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfigurarTerminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfigurarTerminal";
            this.Load += new System.EventHandler(this.frmConfigurarTerminal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.Label lblMac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAutorizarCaja;
        private System.Windows.Forms.Label lblConfCaja;
        private System.Windows.Forms.Button btnAutorizarImpresora;
        private System.Windows.Forms.ComboBox cboImpresoraSecundaria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboImpresoraPrimaria;
        private System.Windows.Forms.Label lblImpresoraPrimaria;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblConfImpresora;
    }
}