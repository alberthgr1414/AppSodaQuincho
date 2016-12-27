using BLL;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSodaQuincho
{
    public partial class frmAbrirTurno : MetroForm
    {
        public frmAbrirTurno()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        private void Tecla1_Click(object sender, EventArgs e)
        {
            //if (txtCodigoAsistente.()==true)
            //{
            //Button cl = sender as Button;
            //string codigo = cl.Tag.ToString();
            //txtCodigoAsistente.Text = txtCodigoAsistente.Text.ToString() + codigo;
            //}
            //else
            //{
            //Button cl = sender as Button;
            //string codigo = cl.Tag.ToString();
            //txtDinero.Text = txtDinero.Text.ToString() + codigo; 
            //}
          
        }
        private void btnAbrirTurno_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoAsistente.Text == "" || txtDinero.Text == "")
                {
                    if (txtCodigoAsistente.Text == "")
                    {
                        System.Windows.MessageBox.Show("Debe Digitar el codigo del Asistente");
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Debe digitar el Fondo del turno");
                    }
                    
                }
                else
                {
                    int IdEmpleado = int.Parse(txtCodigoAsistente.Text);
                    int monto = int.Parse(txtDinero.Text);
                    TurnoBLL.AbrirTurno(IdEmpleado, monto);
                    System.Windows.MessageBox.Show("Turno Abierto con Exito");
                    this.Close();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void frmAbrirTurno_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDinero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtDinero.Focus();
        }

        private void txtCodigoAsistente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtCodigoAsistente.Focus();
        }
    }
}
