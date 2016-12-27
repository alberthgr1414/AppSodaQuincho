namespace AppSodaQuincho
{
    partial class frmAbrirTurno
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
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.flpTeclado = new System.Windows.Forms.FlowLayoutPanel();
            this.Tecla1 = new System.Windows.Forms.Button();
            this.Tecla2 = new System.Windows.Forms.Button();
            this.Tecla3 = new System.Windows.Forms.Button();
            this.Tecla4 = new System.Windows.Forms.Button();
            this.Tecla5 = new System.Windows.Forms.Button();
            this.Tecla6 = new System.Windows.Forms.Button();
            this.Tecla7 = new System.Windows.Forms.Button();
            this.Tecla8 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.txtDinero = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigoAsistente = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAbrirTurno = new System.Windows.Forms.Button();
            this.flpTeclado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Asistente";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dinero Inicial";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelar.Location = new System.Drawing.Point(215, 329);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 40);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // flpTeclado
            // 
            this.flpTeclado.Controls.Add(this.Tecla1);
            this.flpTeclado.Controls.Add(this.Tecla2);
            this.flpTeclado.Controls.Add(this.Tecla3);
            this.flpTeclado.Controls.Add(this.Tecla4);
            this.flpTeclado.Controls.Add(this.Tecla5);
            this.flpTeclado.Controls.Add(this.Tecla6);
            this.flpTeclado.Controls.Add(this.Tecla7);
            this.flpTeclado.Controls.Add(this.Tecla8);
            this.flpTeclado.Controls.Add(this.button11);
            this.flpTeclado.Controls.Add(this.button12);
            this.flpTeclado.Controls.Add(this.button14);
            this.flpTeclado.Location = new System.Drawing.Point(27, 139);
            this.flpTeclado.Name = "flpTeclado";
            this.flpTeclado.Size = new System.Drawing.Size(282, 187);
            this.flpTeclado.TabIndex = 6;
            // 
            // Tecla1
            // 
            this.Tecla1.Location = new System.Drawing.Point(3, 3);
            this.Tecla1.Name = "Tecla1";
            this.Tecla1.Size = new System.Drawing.Size(64, 55);
            this.Tecla1.TabIndex = 0;
            this.Tecla1.Tag = "1";
            this.Tecla1.Text = "1";
            this.Tecla1.UseVisualStyleBackColor = true;
            this.Tecla1.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // Tecla2
            // 
            this.Tecla2.Location = new System.Drawing.Point(73, 3);
            this.Tecla2.Name = "Tecla2";
            this.Tecla2.Size = new System.Drawing.Size(64, 55);
            this.Tecla2.TabIndex = 1;
            this.Tecla2.Tag = "2";
            this.Tecla2.Text = "2";
            this.Tecla2.UseVisualStyleBackColor = true;
            this.Tecla2.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // Tecla3
            // 
            this.Tecla3.Location = new System.Drawing.Point(143, 3);
            this.Tecla3.Name = "Tecla3";
            this.Tecla3.Size = new System.Drawing.Size(64, 55);
            this.Tecla3.TabIndex = 2;
            this.Tecla3.Tag = "3";
            this.Tecla3.Text = "3";
            this.Tecla3.UseVisualStyleBackColor = true;
            this.Tecla3.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // Tecla4
            // 
            this.Tecla4.Location = new System.Drawing.Point(213, 3);
            this.Tecla4.Name = "Tecla4";
            this.Tecla4.Size = new System.Drawing.Size(64, 55);
            this.Tecla4.TabIndex = 3;
            this.Tecla4.Tag = "4";
            this.Tecla4.Text = "4";
            this.Tecla4.UseVisualStyleBackColor = true;
            this.Tecla4.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // Tecla5
            // 
            this.Tecla5.Location = new System.Drawing.Point(3, 64);
            this.Tecla5.Name = "Tecla5";
            this.Tecla5.Size = new System.Drawing.Size(64, 55);
            this.Tecla5.TabIndex = 4;
            this.Tecla5.Tag = "5";
            this.Tecla5.Text = "5";
            this.Tecla5.UseVisualStyleBackColor = true;
            this.Tecla5.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // Tecla6
            // 
            this.Tecla6.Location = new System.Drawing.Point(73, 64);
            this.Tecla6.Name = "Tecla6";
            this.Tecla6.Size = new System.Drawing.Size(64, 55);
            this.Tecla6.TabIndex = 5;
            this.Tecla6.Tag = "6";
            this.Tecla6.Text = "6";
            this.Tecla6.UseVisualStyleBackColor = true;
            this.Tecla6.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // Tecla7
            // 
            this.Tecla7.Location = new System.Drawing.Point(143, 64);
            this.Tecla7.Name = "Tecla7";
            this.Tecla7.Size = new System.Drawing.Size(64, 55);
            this.Tecla7.TabIndex = 6;
            this.Tecla7.Tag = "7";
            this.Tecla7.Text = "7";
            this.Tecla7.UseVisualStyleBackColor = true;
            this.Tecla7.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // Tecla8
            // 
            this.Tecla8.Location = new System.Drawing.Point(213, 64);
            this.Tecla8.Name = "Tecla8";
            this.Tecla8.Size = new System.Drawing.Size(64, 55);
            this.Tecla8.TabIndex = 7;
            this.Tecla8.Tag = "8";
            this.Tecla8.Text = "8";
            this.Tecla8.UseVisualStyleBackColor = true;
            this.Tecla8.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(3, 125);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(64, 55);
            this.button11.TabIndex = 8;
            this.button11.Tag = "9";
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(73, 125);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(64, 55);
            this.button12.TabIndex = 9;
            this.button12.Tag = "0";
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // button14
            // 
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.Location = new System.Drawing.Point(143, 125);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(134, 55);
            this.button14.TabIndex = 11;
            this.button14.Text = "Borrar";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // txtDinero
            // 
            this.txtDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinero.Location = new System.Drawing.Point(191, 104);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(118, 29);
            this.txtDinero.TabIndex = 8;
            this.txtDinero.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDinero_MaskInputRejected);
            // 
            // txtCodigoAsistente
            // 
            this.txtCodigoAsistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAsistente.Location = new System.Drawing.Point(191, 69);
            this.txtCodigoAsistente.Mask = "999999";
            this.txtCodigoAsistente.Name = "txtCodigoAsistente";
            this.txtCodigoAsistente.Size = new System.Drawing.Size(118, 29);
            this.txtCodigoAsistente.TabIndex = 9;
            this.txtCodigoAsistente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCodigoAsistente_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(121, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "₡";
            // 
            // btnAbrirTurno
            // 
            this.btnAbrirTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAbrirTurno.ForeColor = System.Drawing.Color.Black;
            this.btnAbrirTurno.Location = new System.Drawing.Point(27, 329);
            this.btnAbrirTurno.Name = "btnAbrirTurno";
            this.btnAbrirTurno.Size = new System.Drawing.Size(91, 40);
            this.btnAbrirTurno.TabIndex = 4;
            this.btnAbrirTurno.Text = "Abrir Turno";
            this.btnAbrirTurno.UseVisualStyleBackColor = false;
            this.btnAbrirTurno.Click += new System.EventHandler(this.btnAbrirTurno_Click);
            // 
            // frmAbrirTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 392);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCodigoAsistente);
            this.Controls.Add(this.txtDinero);
            this.Controls.Add(this.flpTeclado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAbrirTurno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbrirTurno";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Tag = "borrar";
            this.Text = "Abrir Turno";
            this.Load += new System.EventHandler(this.frmAbrirTurno_Load);
            this.flpTeclado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.FlowLayoutPanel flpTeclado;
        private System.Windows.Forms.Button Tecla1;
        private System.Windows.Forms.Button Tecla2;
        private System.Windows.Forms.Button Tecla3;
        private System.Windows.Forms.Button Tecla4;
        private System.Windows.Forms.Button Tecla5;
        private System.Windows.Forms.Button Tecla6;
        private System.Windows.Forms.Button Tecla7;
        private System.Windows.Forms.Button Tecla8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.MaskedTextBox txtDinero;
        private System.Windows.Forms.MaskedTextBox txtCodigoAsistente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAbrirTurno;
    }
}