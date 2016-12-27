using BLL;
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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        private void Tecla1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Tecla1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("1");
            /*if (txtCodigoAsistente.Focus()==true)
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
            */
        }
        private void btnAbrirTurno_Click(object sender, EventArgs e)
        {
            int IdEmpleado = int.Parse(txtCodigoAsistente.Text);
            int monto = int.Parse(txtDinero.Text);
        }

        private void frmAbrirTurno_Load(object sender, EventArgs e)
        {
            frmTeclado tcl = new frmTeclado();
            tcl.Show();
        }
    }
}
