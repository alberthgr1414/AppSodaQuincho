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
using System.Windows.Documents;

namespace AppSodaQuincho
{
    public partial class frmMesa : Form
    {
        public frmMesa()
        {
            InitializeComponent();
        }

        private void frmMesa_Load(object sender, EventArgs e)
        {
            cargarOrdenes();
            ScrollflpMesa();
        }
        public void ScrollflpMesa()
        {
            //--------Scroll Bar a el Panel---------------
            flpMesa.AutoScroll = true;
        }

        public void cargarOrdenes()
        {
            DataTable mesas = EncFacturaBLL.ListarEncFacturaPorEstado(4); 
            for (int i = 0; i < mesas.Rows.Count; i++)
            {
                int EncFactura = int.Parse(mesas.Rows[i][0].ToString());

                var panelMesa = new Panel();
                panelMesa.Size = new System.Drawing.Size(192, 306);
                panelMesa.BackColor = System.Drawing.Color.Black;
                panelMesa.Visible = true;
                flpMesa.Controls.Add(panelMesa);

                var panelTotal = new Panel();
                panelTotal.Size = new System.Drawing.Size(180, 20);
                panelTotal.Location = new System.Drawing.Point(6, 250);
                panelTotal.BackColor = System.Drawing.Color.White;
                panelTotal.Visible = true;
                panelMesa.Controls.Add(panelTotal);

                double total = double.Parse(DetFacturaBLL.SumDetFactura(EncFactura));

                var lblTotal = new Label();
                lblTotal.Size = new System.Drawing.Size(140, 20);
                lblTotal.Location = new System.Drawing.Point(75, 3);
                lblTotal.Text = "-->   "+"Total: "+"₡ "+total.ToString();
                lblTotal.BackColor = System.Drawing.Color.White;
                panelTotal.Controls.Add(lblTotal);


                var panelNumOrden = new Panel();
                panelNumOrden.Size = new System.Drawing.Size(242, 60);
                panelNumOrden.BackColor = System.Drawing.Color.Red;
                panelNumOrden.Visible = true;
                panelMesa.Controls.Add(panelNumOrden);

                var NFactura = new Label();
                NFactura.Text = EncFactura.ToString();
                panelNumOrden.Controls.Add(NFactura);

                var listox = new ListBox();
                listox.Size = new System.Drawing.Size(182, 190);
                listox.Location = new System.Drawing.Point(5, 65);
                listox.BackColor = System.Drawing.Color.White;
                listox.Visible = true;
                panelMesa.Controls.Add(listox);

                var btnEditar = new Button();
                btnEditar.Text = "Editar Orden";
                btnEditar.BackColor = System.Drawing.Color.Yellow;
                btnEditar.Size = new System.Drawing.Size(91, 30);
                btnEditar.Location = new System.Drawing.Point(5, 270);
                btnEditar.Visible = true;
                panelMesa.Controls.Add(btnEditar);

                var btnEntregado = new Button();
                btnEntregado.Text = "Entregado";
                btnEntregado.BackColor = System.Drawing.Color.Yellow;
                btnEntregado.Size = new System.Drawing.Size(96, 30);
                btnEntregado.Location = new System.Drawing.Point(91, 270);
                btnEntregado.Visible = true;
                panelMesa.Controls.Add(btnEntregado);
               
                DataTable det =  DetFacturaBLL.ListarDetFactura(EncFactura);
                for (int f = 0; f < det.Rows.Count; f++)
                {
                    var Detelles = new Label();
                    Detelles.Text = "-->      " + det.Rows[f][1].ToString()+"   "+ det.Rows[f][2].ToString() + "   " + "₡ " + det.Rows[f][3].ToString();
                    Detelles.Font = new Font("Arial", 16, System.Drawing.FontStyle.Regular);
                    listox.Items.Add(Detelles.Text);
                }
                
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
