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
    public partial class frmAbrirTurno : Form
    {
        public frmAbrirTurno()
        {
            InitializeComponent();
        }

        private void Tecla1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Tecla1_Click(object sender, EventArgs e)
        {
            if (txtCodigoAsistente.Focus()==true)
            {
            Button cl = sender as Button;
            string codigo = cl.Tag.ToString();
            txtCodigoAsistente.Text = txtCodigoAsistente.Text.ToString() + codigo;
            }
            else
            {
            if (txtDinero.Focused==true)
            {
            Button cl = sender as Button;
            string codigo = cl.Tag.ToString();
            txtDinero.Text = txtDinero.Text.ToString() + codigo; 
            }
            }
        }
    }
}
