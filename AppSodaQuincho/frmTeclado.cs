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
    public partial class frmTeclado : Form
    {
        public frmTeclado()
        {
            InitializeComponent();
        }

        private void frmTeclado_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("l");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendKeys.Send("m");
        }
    }
}
