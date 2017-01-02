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
            Scrolls();
        }

        public void Scrolls()
        {
            //--------Scroll Bar a el Panel---------------
            PanelPlato.HorizontalScroll.Enabled = false;
            PanelPlato.HorizontalScroll.Visible = false;
            //PanelPlato.HorizontalScroll.Maximum = 0;
            PanelPlato.VerticalScroll.Visible = true;
            PanelPlato.Controls.OfType<VScrollBar>().First().Width = 20;
            //--------------------------------------------
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
            int AnchoPictureBox = 5;
            int AltoPictureBox = 5;
            int AnchoLabel = 5;
            int AltoLabel = 99;
            int cont = 0;

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
                    AnchoPictureBox += 95;
                    AnchoLabel += 95;
                }
                else
                {
                    if (cont == 6)
                    {
                        //Para el salto de linea 
                        AnchoPictureBox = 5;
                        AltoPictureBox += 123;
                        AnchoLabel = 5;
                        AltoLabel += 123;
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
            string resultado = "";
            PictureBox cl = sender as PictureBox;
            cl.BorderStyle = BorderStyle.Fixed3D;
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
            for (int i = 0; i < ListaPlatos.Count; i++)
            {
                resultado += ListaPlatos[i].ID_Plato + "/n";
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
                if (cantidad == 0)
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

        private void panelCantidad_Paint(object sender, PaintEventArgs e)
        {
            lblCantidad.Text = "0";
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            DateTime date1 = DateTime.Now;
            tsbHora.Text = date1.ToString("hh:mm:ss tt",
                              CultureInfo.InvariantCulture);
            tsbFecha.Text = date1.ToString("dddd dd MMMM",
                  CultureInfo.CreateSpecificCulture("es-CR"));
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            PersistenciaSqlServer.Persistencia.Persistencia.getInstance().establecerConexion("sa", "123456");
            llenarMenu(1);
        }

        private void btnFuncionesPOS_Click(object sender, EventArgs e)
        {
            //Limpia el panel
            PanelPlato.Controls.Clear();
            //--------------------------------------------

            //Creacion de el pictureBox Ingresar Cajero
            var ptbIngresarCajero = new PictureBox();
            ptbIngresarCajero.Location = new System.Drawing.Point(10, 10);
            ptbIngresarCajero.Size = new System.Drawing.Size(90, 90);
            ptbIngresarCajero.BackColor = System.Drawing.Color.White;
            ptbIngresarCajero.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbIngresarCajero.Visible = true;
            ptbIngresarCajero.Image = global::AppSodaQuincho.Properties.Resources.IngresarCajero;
            PanelPlato.Controls.Add(ptbIngresarCajero);
            ptbIngresarCajero.Click += new System.EventHandler(this.ptbIngresarCajero_Click);
            //--------------------------------------------

            //Creacion de Label Ingresar Cajero
            var lblIngresarCajero = new Label();
            lblIngresarCajero.Location = new System.Drawing.Point(10, 100);
            lblIngresarCajero.Size = new System.Drawing.Size(90, 20);
            lblIngresarCajero.Text = "Ingresar Cajero";
            lblIngresarCajero.Visible = true;
            lblIngresarCajero.BackColor = System.Drawing.Color.White;
            lblIngresarCajero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            PanelPlato.Controls.Add(lblIngresarCajero);
            lblIngresarCajero.Click += new System.EventHandler(this.ptbIngresarCajero_Click);
            //--------------------------------------------

            //Creacion de el pictureBox Cierre Cajero
            var ptbCierreCajero = new PictureBox();
            ptbCierreCajero.Location = new System.Drawing.Point(110,10);
            ptbCierreCajero.Size = new System.Drawing.Size(90, 90);
            ptbCierreCajero.BackColor = System.Drawing.Color.White;
            ptbCierreCajero.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbCierreCajero.Visible = true;
            ptbCierreCajero.Image = global::AppSodaQuincho.Properties.Resources.CierreCajero;
            PanelPlato.Controls.Add(ptbCierreCajero);
            ptbCierreCajero.Click += new System.EventHandler(this.ptbCierreCajero_Click);
            //--------------------------------------------

            //Creacion de Label Cierre Cajero 
            var lblCierreCajero = new Label();
            lblCierreCajero.Location = new System.Drawing.Point(110, 100);
            lblCierreCajero.Size = new System.Drawing.Size(90, 20);
            lblCierreCajero.Text = "Cierre Cajero";
            lblCierreCajero.Visible = true;
            lblCierreCajero.BackColor = System.Drawing.Color.White;
            lblCierreCajero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            PanelPlato.Controls.Add(lblCierreCajero);
            lblCierreCajero.Click += new System.EventHandler(this.ptbCierreCajero_Click);
            //--------------------------------------------

            //Creacion de el pictureBox Estado Caja
            var ptbEstadoCaja = new PictureBox();
            ptbEstadoCaja.Location = new System.Drawing.Point(10, 130);
            ptbEstadoCaja.Size = new System.Drawing.Size(90, 90);
            ptbEstadoCaja.BackColor = System.Drawing.Color.White;
            ptbEstadoCaja.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbEstadoCaja.Visible = true;
            ptbEstadoCaja.Image = global::AppSodaQuincho.Properties.Resources.money;
            PanelPlato.Controls.Add(ptbEstadoCaja);
            ptbEstadoCaja.Click += new System.EventHandler(this.ptbEstadoCaja_Click);
            //--------------------------------------------

            //Creacion de Label Estado Caja
            var lblEstadoCaja = new Label();
            lblEstadoCaja.Location = new System.Drawing.Point(10, 220);
            lblEstadoCaja.Size = new System.Drawing.Size(90, 20);
            lblEstadoCaja.Text = "Estado de Caja";
            lblEstadoCaja.Visible = true;
            lblEstadoCaja.BackColor = System.Drawing.Color.White;
            lblEstadoCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            PanelPlato.Controls.Add(lblEstadoCaja);
            lblEstadoCaja.Click += new System.EventHandler(this.ptbEstadoCaja_Click);
            //--------------------------------------------

            //Creacion de el pictureBox Abrir Gaveta
            var ptbAbrirGaveta = new PictureBox();
            ptbAbrirGaveta.Location = new System.Drawing.Point(110, 130);
            ptbAbrirGaveta.Size = new System.Drawing.Size(90, 90);
            ptbAbrirGaveta.BackColor = System.Drawing.Color.White;
            ptbAbrirGaveta.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbAbrirGaveta.Visible = true;
            ptbAbrirGaveta.Image = global::AppSodaQuincho.Properties.Resources.key;
            PanelPlato.Controls.Add(ptbAbrirGaveta);
            ptbAbrirGaveta.Click += new System.EventHandler(this.ptbAbrirGaveta_Click);
            //--------------------------------------------

            //Creacion de Label Abrir Gaveta 
            var lblAbrirGaveta = new Label();
            lblAbrirGaveta.Location = new System.Drawing.Point(110, 220);
            lblAbrirGaveta.Size = new System.Drawing.Size(90, 20);
            lblAbrirGaveta.Text = "Abrir Gaveta";
            lblAbrirGaveta.Visible = true;
            lblAbrirGaveta.BackColor = System.Drawing.Color.White;
            lblAbrirGaveta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            PanelPlato.Controls.Add(lblAbrirGaveta);
            lblAbrirGaveta.Click += new System.EventHandler(this.ptbAbrirGaveta_Click);
            //--------------------------------------------

            //Creacion de el pictureBox Nulo
            var ptbNulo = new PictureBox();
            ptbNulo.Location = new System.Drawing.Point(210, 130);
            ptbNulo.Size = new System.Drawing.Size(90, 90);
            ptbNulo.BackColor = System.Drawing.Color.White;
            ptbNulo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbNulo.Visible = true;
            ptbNulo.Image = global::AppSodaQuincho.Properties.Resources.erase;
            PanelPlato.Controls.Add(ptbNulo);
            ptbNulo.Click += new System.EventHandler(this.ptbNulo_Click);
            //--------------------------------------------

            //Creacion de Label Nulo 
            var lblNulo = new Label();
            lblNulo.Location = new System.Drawing.Point(210, 220);
            lblNulo.Size = new System.Drawing.Size(90, 20);
            lblNulo.Text = "Nulo";
            lblNulo.Visible = true;
            lblNulo.BackColor = System.Drawing.Color.White;
            lblNulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            PanelPlato.Controls.Add(lblNulo);
            lblNulo.Click += new System.EventHandler(this.ptbNulo_Click);
            //--------------------------------------------

            //Creacion de el pictureBox Ingresar Efectivo
            var ptbIngresarEfectivo = new PictureBox();
            ptbIngresarEfectivo.Location = new System.Drawing.Point(10, 250);
            ptbIngresarEfectivo.Size = new System.Drawing.Size(90, 90);
            ptbIngresarEfectivo.BackColor = System.Drawing.Color.White;
            ptbIngresarEfectivo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbIngresarEfectivo.Visible = true;
            ptbIngresarEfectivo.Image = global::AppSodaQuincho.Properties.Resources.deposite;
            PanelPlato.Controls.Add(ptbIngresarEfectivo);
            ptbIngresarEfectivo.Click += new System.EventHandler(this.ptbIngresarEfectivo_Click);
            //--------------------------------------------

            //Creacion de Label Ingresar Efectivo
            var lblIngresarEfectivo = new Label();
            lblIngresarEfectivo.Location = new System.Drawing.Point(10, 340);
            lblIngresarEfectivo.Size = new System.Drawing.Size(90, 20);
            lblIngresarEfectivo.Text = "Ingresar Efectivo";
            lblIngresarEfectivo.Visible = true;
            lblIngresarEfectivo.BackColor = System.Drawing.Color.White;
            lblIngresarEfectivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            PanelPlato.Controls.Add(lblIngresarEfectivo);
            lblIngresarEfectivo.Click += new System.EventHandler(this.ptbIngresarEfectivo_Click);
            //--------------------------------------------

            //Creacion de el pictureBox Retiro Efectivo
            var ptbRetiroEfectivo = new PictureBox();
            ptbRetiroEfectivo.Location = new System.Drawing.Point(110, 250);
            ptbRetiroEfectivo.Size = new System.Drawing.Size(90, 90);
            ptbRetiroEfectivo.BackColor = System.Drawing.Color.White;
            ptbRetiroEfectivo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbRetiroEfectivo.Visible = true;
            ptbRetiroEfectivo.Image = global::AppSodaQuincho.Properties.Resources.Sacar;
            PanelPlato.Controls.Add(ptbRetiroEfectivo);
            ptbRetiroEfectivo.Click += new System.EventHandler(this.ptbRetiroEfectivo_Click);
            //--------------------------------------------

            //Creacion de Label Retiro Efectivo
            var lblRetiroEfectivo = new Label();
            lblRetiroEfectivo.Location = new System.Drawing.Point(110, 340);
            lblRetiroEfectivo.Size = new System.Drawing.Size(90, 20);
            lblRetiroEfectivo.Text = "Retiro Efectivo";
            lblRetiroEfectivo.Visible = true;
            lblRetiroEfectivo.BackColor = System.Drawing.Color.White;
            lblRetiroEfectivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            PanelPlato.Controls.Add(lblRetiroEfectivo);
            lblRetiroEfectivo.Click += new System.EventHandler(this.ptbRetiroEfectivo_Click);
            //--------------------------------------------


        }

        private void ptbIngresarCajero_Click(object sender, EventArgs e)
        {
            frmIngresarCajero IngresarCajero = new frmIngresarCajero();
            IngresarCajero.ShowDialog();
        }

        private void ptbCierreCajero_Click(object sender, EventArgs e)
        {
            frmIngresarCajero IngresarCajero = new frmIngresarCajero();
            IngresarCajero.ShowDialog();
        }

        private void ptbEstadoCaja_Click(object sender, EventArgs e)
        {
            frmIngresarCajero IngresarCajero = new frmIngresarCajero();
            IngresarCajero.ShowDialog();
        }

        private void ptbAbrirGaveta_Click(object sender, EventArgs e)
        {
            frmIngresarCajero IngresarCajero = new frmIngresarCajero();
            IngresarCajero.ShowDialog();
        }

        private void ptbNulo_Click(object sender, EventArgs e)
        {
            frmIngresarCajero IngresarCajero = new frmIngresarCajero();
            IngresarCajero.ShowDialog();
        }

        private void ptbIngresarEfectivo_Click(object sender, EventArgs e)
        {
            frmIngresarCajero IngresarCajero = new frmIngresarCajero();
            IngresarCajero.ShowDialog();
        }


        private void ptbRetiroEfectivo_Click(object sender, EventArgs e)
        {
            frmIngresarCajero IngresarCajero = new frmIngresarCajero();
            IngresarCajero.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
 