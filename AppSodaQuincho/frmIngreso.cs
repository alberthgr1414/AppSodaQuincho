using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace AppSodaQuincho
{
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersistenciaSqlServer.Persistencia.Persistencia.getInstance().establecerConexion("sa", "123456");
            frmSodaQuincho fr = new frmSodaQuincho();
            fr.Show();

        }

        private void frmIngreso_Load(object sender, EventArgs e)
        {

        }
    }
}
