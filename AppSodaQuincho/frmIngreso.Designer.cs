namespace AppSodaQuincho
{
    partial class frmIngreso
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngreso));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pgIngreso = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(65, 127);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(174, 29);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.Validated += new System.EventHandler(this.txtUsuario_Validated);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(65, 174);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(174, 29);
            this.txtContrasena.TabIndex = 1;
            this.txtContrasena.Validated += new System.EventHandler(this.txtContrasena_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(116, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Location = new System.Drawing.Point(95, 221);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(114, 40);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.AutoSize = true;
            this.txtMensaje.Location = new System.Drawing.Point(477, 361);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(0, 13);
            this.txtMensaje.TabIndex = 6;
            // 
            // epError
            // 
            this.epError.BlinkRate = 50;
            this.epError.ContainerControl = this;
            this.epError.Icon = ((System.Drawing.Icon)(resources.GetObject("epError.Icon")));
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Controls.Add(this.txtContrasena);
            this.panel2.Controls.Add(this.btnIngresar);
            this.panel2.Location = new System.Drawing.Point(376, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 303);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::AppSodaQuincho.Properties.Resources.padlock;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(123, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(59, 50);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::AppSodaQuincho.Properties.Resources.close;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Location = new System.Drawing.Point(960, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(46, 37);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pgIngreso
            // 
            this.pgIngreso.Location = new System.Drawing.Point(12, 759);
            this.pgIngreso.Name = "pgIngreso";
            this.pgIngreso.Size = new System.Drawing.Size(1000, 8);
            this.pgIngreso.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgIngreso.TabIndex = 11;
            this.pgIngreso.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // frmIngreso
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppSodaQuincho.Properties.Resources.fondo_azul_blue_cuadros_fotorecurso;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 758);
            this.Controls.Add(this.pgIngreso);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIngreso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIngreso";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frmIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.MaskedTextBox txtContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label txtMensaje;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ProgressBar pgIngreso;
    }
}