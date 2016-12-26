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
    public partial class frmSodaQuincho : Form
    {
        public frmSodaQuincho()
        {
            InitializeComponent();
        }

        private void SodaQuincho_Load(object sender, EventArgs e)
        {
            //PersistenciaSqlServer.Persistencia.Persistencia.getInstance().establecerConexion("sa", "123456");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            Facturacion newMDIChild = new Facturacion();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void mantenimientoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmMantenimientoPlato newMDIChild = new frmMantenimientoPlato();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void tsbAbrirTurno_Click(object sender, EventArgs e)
        {
            frmAbrirTurno AbrirTurno = new frmAbrirTurno();
            AbrirTurno.ShowDialog();
        }
    }
}
