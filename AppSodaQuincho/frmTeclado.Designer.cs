namespace AppSodaQuincho
{
    partial class frmTeclado
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
            this.vitalityTheme1 = new VitalityTheme();
            this.SuspendLayout();
            // 
            // vitalityTheme1
            // 
            this.vitalityTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.vitalityTheme1.Customization = "/////9PT0//w8PD/";
            this.vitalityTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vitalityTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.vitalityTheme1.Image = null;
            this.vitalityTheme1.Location = new System.Drawing.Point(0, 0);
            this.vitalityTheme1.Movable = true;
            this.vitalityTheme1.Name = "vitalityTheme1";
            this.vitalityTheme1.NoRounding = false;
            this.vitalityTheme1.Sizable = true;
            this.vitalityTheme1.Size = new System.Drawing.Size(768, 416);
            this.vitalityTheme1.SmartBounds = true;
            this.vitalityTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.vitalityTheme1.TabIndex = 0;
            this.vitalityTheme1.Text = "vitalityTheme1";
            this.vitalityTheme1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.vitalityTheme1.Transparent = false;
            // 
            // frmTeclado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 416);
            this.Controls.Add(this.vitalityTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTeclado";
            this.Text = "frmTeclado";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frmTeclado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private VitalityTheme vitalityTheme1;
    }
}