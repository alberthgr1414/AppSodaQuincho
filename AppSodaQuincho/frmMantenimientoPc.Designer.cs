namespace AppSodaQuincho
{
    partial class frmMantenimientoPc
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdPc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNumCaja = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id del PC";
            // 
            // txtIdPc
            // 
            this.txtIdPc.Location = new System.Drawing.Point(122, 108);
            this.txtIdPc.Name = "txtIdPc";
            this.txtIdPc.Size = new System.Drawing.Size(121, 20);
            this.txtIdPc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de Caja";
            // 
            // cboNumCaja
            // 
            this.cboNumCaja.FormattingEnabled = true;
            this.cboNumCaja.Location = new System.Drawing.Point(122, 143);
            this.cboNumCaja.Name = "cboNumCaja";
            this.cboNumCaja.Size = new System.Drawing.Size(121, 21);
            this.cboNumCaja.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Asignar Numero de Caja";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMantenimientoPc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 278);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboNumCaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdPc);
            this.Controls.Add(this.label1);
            this.Name = "frmMantenimientoPc";
            this.Text = "Mantenimiento PC";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.frmMantenimientoPc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdPc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNumCaja;
        private System.Windows.Forms.Button button1;
    }
}