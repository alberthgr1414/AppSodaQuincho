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
    public partial class frmPruebas : Form
    {
        public frmPruebas()
        {
            InitializeComponent();
        }

        private void frmPruebas_Load(object sender, EventArgs e)
        {
            //--------------------------------------------
            //--------Scroll Bar a el Panel---------------
            //PanelPlato.AutoScroll = true;
            //PanelPlato.HorizontalScroll.Enabled = false;
            //PanelPlato.HorizontalScroll.Visible = false;
            //PanelPlato.HorizontalScroll.Maximum = 0;
            //PanelPlato.AutoScroll = true;
            //--------------------------------------------
            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.VerticalScroll.Visible = true;
            //--------------------------------------------
        }
    }
}
