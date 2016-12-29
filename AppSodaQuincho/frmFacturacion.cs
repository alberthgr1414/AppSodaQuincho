using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using System.Globalization;

namespace AppSodaQuincho
{
    public partial class frmFacturacion : Form
    {
        List<Plato> ListaPlatos = new List<Plato>();
        public frmFacturacion()
        {
            
            InitializeComponent();
            timerHora.Enabled = true;
            timerHora.Start();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            PersistenciaSqlServer.Persistencia.Persistencia.getInstance().establecerConexion("sa", "123456");
            llenarMenu(1);
        }

        public void llenarPagoParaLLevar()
        {
            //Limpair Panel
            PanelPlato.Controls.Clear();
            var Btn1000 = new Button();
            Btn1000.Location = new System.Drawing.Point(10, 10);
            Btn1000.Size = new System.Drawing.Size(120, 40);
            Btn1000.Text = "1000";
            Btn1000.Visible = true;
            Btn1000.BackColor = System.Drawing.Color.White;
            Btn1000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            PanelPlato.Controls.Add(Btn1000);
            //Limpair Panel
            //PanelPlato.Controls.Clear();
            var Btn2000 = new Button();
            Btn2000.Location = new System.Drawing.Point(130, 10);
            Btn2000.Size = new System.Drawing.Size(120, 40);
            Btn2000.Text = "2000";
            Btn2000.Visible = true;
            Btn2000.BackColor = System.Drawing.Color.White;
            Btn2000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            PanelPlato.Controls.Add(Btn2000);
        }

        public void llenarMenu(int TipoPlato)
        {
            // Variables de Ancho y Alto de los PictureBox
            // Contador de Rows
            PanelPlato.Controls.Clear();
            int AnchoPictureBox = 6;
            int AltoPictureBox = 6;
            int AnchoLabel = 6;
            int AltoLabel = 99;
            int cont = 0;
            //--------------------------------------------
            //--------Scroll Bar a el Panel---------------
            //PanelPlato.AutoScroll = true;
            //PanelPlato.HorizontalScroll.Enabled = false;
            //PanelPlato.HorizontalScroll.Visible = false;
            //PanelPlato.HorizontalScroll.Maximum = 0;
            //PanelPlato.AutoScroll = true;
            //--------------------------------------------
            //panelTipoPlato.AutoScroll = false;
            //panelTipoPlato.HorizontalScroll.Enabled = false;
            //panelTipoPlato.HorizontalScroll.Visible = false;
            //panelTipoPlato.HorizontalScroll.Maximum = 0;
            //panelTipoPlato.VerticalScroll.Visible = true;
            //--------------------------------------------

            DataTable ds = BLL.PlatoBLL.ListarPlatos(TipoPlato);
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                // Suma para seber cuando ahi que bajar de fila 
                cont += 1;
                // Pregunta si el contador esta preparado para 
                // Dar un salto de linea 
                if (cont < 6)
                {
                    //-----------Creacion de el pictureBox---------
                    var pictbox = new PictureBox();
                    pictbox.Location = new System.Drawing.Point(AnchoPictureBox, AltoPictureBox);
                    pictbox.Size = new System.Drawing.Size(90, 90);
                    pictbox.BackColor = System.Drawing.Color.White;
                    pictbox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictbox.Visible = true;
                    DataRow row = ds.Rows[i];
                    Byte[] FOTO = (Byte[])row["foto"];
                    pictbox.Image = byteArrayToImage(FOTO);
                    //--------------------------------------------

                    //Creacion de Labels 
                    var label = new Label();
                    label.Location = new System.Drawing.Point(AnchoLabel, AltoLabel);
                    label.Size = new System.Drawing.Size(90, 20);
                    string Nombre = row["Nombre_Plato"].ToString();
                    label.Text = Nombre;
                    label.Visible = true;
                    label.BackColor = System.Drawing.Color.White;
                    label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    PanelPlato.Controls.Add(label);
                    // Asignacion de Codigo del Producto
                    pictbox.Tag = row["ID_Plato"].ToString();
                    //--------------------------------------------

                    // Asignacion del PictureBox al Panel y Evento Click
                    PanelPlato.Controls.Add(pictbox);
                    pictbox.Click += new System.EventHandler(this.ptbProducto_Click);
                    //---------------------------------------------------
                    AnchoPictureBox += 100;
                    AnchoLabel += 100;
                    //Limpair Panel
                    //panel1.Controls.Clear();
                }
                else
                {
                    if (cont == 6)
                    {
                        //Para el salto de linea 
                        AnchoPictureBox = 5;
                        AltoPictureBox += 125;
                        AnchoLabel = 5;
                        AltoLabel += 125;
                        cont = 0;
                        i -= 1;
                    }
                }
            }
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private Image CovertirImagen(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void ptbProducto_Click(object sender, EventArgs e)
        {
            string resultado="";
            PictureBox cl = sender as PictureBox;
            cl.BorderStyle= BorderStyle.Fixed3D;
            for (int i = 0; i < 1000000; i++)
            {
                if (i == 999999)
                {
                    cl.BorderStyle = BorderStyle.None;  
                }
            }
            int Codigo = int.Parse(cl.Tag.ToString());
            Plato plato = new Plato();
            plato.ID_Plato = Codigo;
            for (int i = 0; i < ListaPlatos.Count ; i++)
            {
                resultado += ListaPlatos[i].ID_Plato+"/n";
            }
            RefrescarFactura(); 
        }

        public void RefrescarFactura() 
        {
            dgvPlato.DataSource = ListaPlatos;
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // int valor=0;
            //  for (int i = 0; i < listView1.Items.Count; i++)
            //{
            //if (listView1.Items[i].Selected == true)
            //valor= i;
            // }
            // textBox1.Text= valor.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panelTipoPlato.AutoScrollPosition = new Point(0,0);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int cantidad = 100;
            int cont = 0;
            cont += 1;
            panelTipoPlato.AutoScrollPosition = new Point(0,cantidad);
            cantidad = cantidad + 100;
        }

        private void btnMenuRegular_Click(object sender, EventArgs e)
        {
            llenarMenu(1);
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            llenarMenu(2);
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            llenarMenu(3);
        }

        private void btnadicionales_Click(object sender, EventArgs e)
        {
            llenarMenu(5);
        }

        private void Cantidad_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(lblCantidad.Text);
            Button cl = sender as Button;
            if (cantidad < 10)
            {
                if (cantidad==0)
                {
                    lblCantidad.Text = cl.Tag.ToString(); 
                }
                else
                {
                    lblCantidad.Text += cl.Tag.ToString();
                }
            }
            else 
            {
                lblCantidad.Text = "0";
            }
            
        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelPlato_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvPlato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Efectivo_Click(object sender, EventArgs e)
        {

        }

        private void panelCantidad_Paint(object sender, PaintEventArgs e)
        {
            lblCantidad.Text = "0";
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            DateTime date1 = DateTime.Now;
            string fecha = date1.ToString("dddd dd MMMM",
                  CultureInfo.CreateSpecificCulture("es-CR"));
            //date1 = new DateTime(2008, 1, 1, 18, 9, 1);
            label2.Text = date1.ToString("hh:mm:ss tt",
                              CultureInfo.InvariantCulture);
            lblFecha.Text = fecha;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 