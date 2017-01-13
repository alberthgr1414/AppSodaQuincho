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
    public partial class frmIngresarCajero : MetroForm
    {
        public frmIngresarCajero()
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

        private void frmIngresarCajero_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoCajero.Text == "" || txtFondo.Text == "")
                {
                    if (txtCodigoCajero.Text == "")
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
                    int IdEmpleado = int.Parse(txtCodigoCajero.Text);
                    int monto = int.Parse(txtFondo.Text);
                    CajaBLL.AbrirCaja(IdEmpleado, monto);
                    System.Windows.MessageBox.Show("Caja Abierto con Exito");
                    this.Close();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
