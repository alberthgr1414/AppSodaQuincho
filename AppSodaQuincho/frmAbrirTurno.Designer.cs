﻿namespace AppSodaQuincho
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
            this.txtCodigoAsistente = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.txtDinero = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Asistente";
            // 
            // txtCodigoAsistente
            // 
            this.txtCodigoAsistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAsistente.Location = new System.Drawing.Point(170, 26);
            this.txtCodigoAsistente.Name = "txtCodigoAsistente";
            this.txtCodigoAsistente.Size = new System.Drawing.Size(100, 29);
            this.txtCodigoAsistente.TabIndex = 1;
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
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dinero Inicial";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(39, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Abrir Turno";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(147, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Tecla1);
            this.flowLayoutPanel1.Controls.Add(this.Tecla2);
            this.flowLayoutPanel1.Controls.Add(this.Tecla3);
            this.flowLayoutPanel1.Controls.Add(this.Tecla4);
            this.flowLayoutPanel1.Controls.Add(this.Tecla5);
            this.flowLayoutPanel1.Controls.Add(this.Tecla6);
            this.flowLayoutPanel1.Controls.Add(this.Tecla7);
            this.flowLayoutPanel1.Controls.Add(this.Tecla8);
            this.flowLayoutPanel1.Controls.Add(this.button11);
            this.flowLayoutPanel1.Controls.Add(this.button12);
            this.flowLayoutPanel1.Controls.Add(this.button14);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 121);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(239, 154);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // Tecla1
            // 
            this.Tecla1.Location = new System.Drawing.Point(3, 3);
            this.Tecla1.Name = "Tecla1";
            this.Tecla1.Size = new System.Drawing.Size(53, 41);
            this.Tecla1.TabIndex = 0;
            this.Tecla1.Tag = "1";
            this.Tecla1.Text = "1";
            this.Tecla1.UseVisualStyleBackColor = true;
            this.Tecla1.Click += new System.EventHandler(this.Tecla1_Click);
            this.Tecla1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tecla1_KeyPress);
            // 
            // Tecla2
            // 
            this.Tecla2.Location = new System.Drawing.Point(62, 3);
            this.Tecla2.Name = "Tecla2";
            this.Tecla2.Size = new System.Drawing.Size(53, 41);
            this.Tecla2.TabIndex = 1;
            this.Tecla2.Tag = "2";
            this.Tecla2.Text = "2";
            this.Tecla2.UseVisualStyleBackColor = true;
            this.Tecla2.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // Tecla3
            // 
            this.Tecla3.Location = new System.Drawing.Point(121, 3);
            this.Tecla3.Name = "Tecla3";
            this.Tecla3.Size = new System.Drawing.Size(53, 41);
            this.Tecla3.TabIndex = 2;
            this.Tecla3.Tag = "3";
            this.Tecla3.Text = "3";
            this.Tecla3.UseVisualStyleBackColor = true;
            this.Tecla3.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // Tecla4
            // 
            this.Tecla4.Location = new System.Drawing.Point(180, 3);
            this.Tecla4.Name = "Tecla4";
            this.Tecla4.Size = new System.Drawing.Size(53, 41);
            this.Tecla4.TabIndex = 3;
            this.Tecla4.Tag = "4";
            this.Tecla4.Text = "4";
            this.Tecla4.UseVisualStyleBackColor = true;
            this.Tecla4.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // Tecla5
            // 
            this.Tecla5.Location = new System.Drawing.Point(3, 50);
            this.Tecla5.Name = "Tecla5";
            this.Tecla5.Size = new System.Drawing.Size(53, 41);
            this.Tecla5.TabIndex = 4;
            this.Tecla5.Tag = "5";
            this.Tecla5.Text = "5";
            this.Tecla5.UseVisualStyleBackColor = true;
            this.Tecla5.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // Tecla6
            // 
            this.Tecla6.Location = new System.Drawing.Point(62, 50);
            this.Tecla6.Name = "Tecla6";
            this.Tecla6.Size = new System.Drawing.Size(53, 41);
            this.Tecla6.TabIndex = 5;
            this.Tecla6.Tag = "6";
            this.Tecla6.Text = "6";
            this.Tecla6.UseVisualStyleBackColor = true;
            this.Tecla6.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // Tecla7
            // 
            this.Tecla7.Location = new System.Drawing.Point(121, 50);
            this.Tecla7.Name = "Tecla7";
            this.Tecla7.Size = new System.Drawing.Size(53, 41);
            this.Tecla7.TabIndex = 6;
            this.Tecla7.Tag = "7";
            this.Tecla7.Text = "7";
            this.Tecla7.UseVisualStyleBackColor = true;
            this.Tecla7.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // Tecla8
            // 
            this.Tecla8.Location = new System.Drawing.Point(180, 50);
            this.Tecla8.Name = "Tecla8";
            this.Tecla8.Size = new System.Drawing.Size(53, 41);
            this.Tecla8.TabIndex = 7;
            this.Tecla8.Tag = "8";
            this.Tecla8.Text = "8";
            this.Tecla8.UseVisualStyleBackColor = true;
            this.Tecla8.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(3, 97);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(53, 41);
            this.button11.TabIndex = 8;
            this.button11.Tag = "9";
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(62, 97);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(53, 41);
            this.button12.TabIndex = 9;
            this.button12.Tag = "0";
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // button14
            // 
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.Location = new System.Drawing.Point(121, 97);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(112, 41);
            this.button14.TabIndex = 11;
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Tecla1_Click);
            // 
            // txtDinero
            // 
            this.txtDinero.Location = new System.Drawing.Point(136, 84);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(100, 20);
            this.txtDinero.TabIndex = 7;
            // 
            // frmAbrirTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(288, 333);
            this.Controls.Add(this.txtDinero);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoAsistente);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbrirTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "borrar";
            this.Text = "Abrir Turno";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoAsistente;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
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
        private System.Windows.Forms.TextBox txtDinero;
    }
}