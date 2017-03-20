﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Entidades;
using System.Globalization;
using BLL;
using System.Windows;
using System.Collections;
using MetroFramework.Controls;

namespace AppSodaQuincho
{ 
    public partial class frmFacturacion : Form
    {
        // Tiempo de la factura
        public static int Tiempo;
        // Precio del producto
        public bool PrecioProducto=false;
        // Lista los Platos
        List<Plato> ListaPlatos = new List<Plato>();
        // Array que Tiene los billetes
        ArrayList arrayBilletes = new ArrayList();
        // Array con los botones del Teclado
        ArrayList arrayTeclado = new ArrayList();
        public frmFacturacion()
        {
            InitializeComponent();
            //Inicializa el Timer de la Hora
            timerHora.Enabled = true;
            timerHora.Start();

        }                                                                                              
        public void ScrollPanelPlato()
        {
            //--------Scroll Bar a el Panel---------------
            //PanelPlato.AutoScroll = false;
            PanelPlato.VerticalScroll.Visible = true;
            PanelPlato.VerticalScroll.Enabled = true;
            PanelPlato.HorizontalScroll.Enabled = false;
            PanelPlato.HorizontalScroll.Visible = false;
            //--------------------------------------------
        }

        public void NoScrollPanelPlato()
        {
            //--------Scroll Bar a el Panel---------------
            PanelPlato.AutoScroll = true;
            PanelPlato.VerticalScroll.Visible = false;
            PanelPlato.VerticalScroll.Enabled = false;
            //--------------------------------------------
        }

        public void llenarMenu(int TipoPlato)
        {
            // Variables de Ancho y Alto de los PictureBox
            // Contador de Rows
            PanelPlato.Controls.Clear();
            ScrollPanelPlato();
            int AnchoPictureBox = 5;
            int AltoPictureBox = 5;
            int AnchoLabel = 5;
            int AltoLabel = 95;
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
                    //var pictbox = new PictureBox();
                    //pictbox.Location = new System.Drawing.Point(AnchoPictureBox, AltoPictureBox);
                    //pictbox.Size = new System.Drawing.Size(90, 90);
                    //pictbox.BackColor = System.Drawing.Color.White;
                    //pictbox.SizeMode = PictureBoxSizeMode.StretchImage;
                    //pictbox.Visible = true;
                    //DataRow row = ds.Rows[i];
                    //Byte[] FOTO = (Byte[])row["foto"];
                    //pictbox.Image = byteArrayToImage(FOTO);
                    var pictbox = new Button();
                    pictbox.Location = new System.Drawing.Point(AnchoPictureBox, AltoPictureBox);
                    pictbox.Size = new System.Drawing.Size(90, 90);
                    pictbox.BackColor = System.Drawing.Color.White;
                    pictbox.Visible = true;
                    DataRow row = ds.Rows[i];
                    Byte[] FOTO = (Byte[])row["foto"];
                    pictbox.BackgroundImage = byteArrayToImage(FOTO);
                    pictbox.BackgroundImageLayout = ImageLayout.Stretch;

                    //--------------------------------------------

                    //Creacion de Labels 
                    var label = new Label();
                    label.Location = new System.Drawing.Point(AnchoLabel, AltoLabel);
                    label.Size = new System.Drawing.Size(90, 27);
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
                        AltoPictureBox += 122;
                        AnchoLabel = 5;
                        AltoLabel += 122;
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

        public void RefrescarDataGrid()
        {
            try
            {
                DataTable factura = EncFacturaBLL.ListarEncFactura(6);
                if (factura.Rows.Count == 0)
                {
                    DataTable factura2 = EncFacturaBLL.ListarEncFactura(1);
                    if (factura2.Rows.Count == 0)
                    {
                        this.Refresh();
                        BannerFactura(12);
                    }
                    else
                    {
                        int Numfactura = int.Parse(EncFacturaBLL.EncFactura(1));
                        dgvPlatos.DataSource = DetFacturaBLL.ListarDetFactura(Numfactura);
                        BannerFactura(1);
                    }
                    }
                else
                {
                    int Numfactura = int.Parse(EncFacturaBLL.EncFactura(6));
                    dgvPlatos.DataSource = DetFacturaBLL.ListarDetFactura(Numfactura);
                    BannerFactura(6);
                    //DataTable datos = DetFacturaBLL.ListarDetFactura(Numfactura);
                    //for (int i = 0; i < datos.Rows.Count; i++)
                    //{
                    //    DataRow row = datos.Rows[i];
                    //    for (int f = 0; f < 2; f++)
                    //    {
                    //        dgvPlatos[i, f].Value = "Albertn";
                    //    }

                    //}
                    TotalFactura();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void TotalFactura()
        {
            try
            {
                DataTable factura = EncFacturaBLL.ListarEncFactura(6);
                if (factura.Rows.Count == 0)
                {
                    DataTable factura2 = EncFacturaBLL.ListarEncFactura(1);
                    if (factura.Rows.Count == 0)
                    {

                    }
                    else
                    {
                        int Numfactura = int.Parse(EncFacturaBLL.EncFactura(1));
                        string Suma = DetFacturaBLL.SumDetFactura(Numfactura);
                        if (Suma == "")
                        {
                        }
                        else
                        {
                            double total = double.Parse(Suma);
                            txtTotalFactura.Text = total.ToString();
                        }
                    }
                }
                else
                {
                    int Numfactura = int.Parse(EncFacturaBLL.EncFactura(6));
                    string Suma = DetFacturaBLL.SumDetFactura(Numfactura);
                    if (Suma == "")
                    {
                    }
                    else
                    {
                        double total = double.Parse(Suma);
                        txtTotalFactura.Text = total.ToString();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }


        }

        public void IniciarTimerFactura()
        {
            timerFactura.Enabled = true;
            timerFactura.Start();
        }

        private void ptbProducto_Click(object sender, EventArgs e)
        {
            Button cl = sender as Button;
            if (PrecioProducto == true)
            {   
                DataTable plato = PlatoBLL.ListarPlatoScalar(int.Parse(cl.Tag.ToString()));
                DataRow row = plato.Rows[0];
                MessageBoxTemporal.Show("Nombre: "+ row["Nombre_Plato"].ToString().ToUpper() + "\n"+ "\n"+
                                        "Precio: " + row["Precio_Plato"].ToString(), "Informacion del Producto", 5, false);
                btnPrecio.BackColor = System.Drawing.Color.NavajoWhite;
                PrecioProducto = false;
            }
            else
            {
            //Inicia el tiempo de Facturacion
            IniciarTimerFactura();
            try
            {
                //Verifica si el turno esta abirto
                if (TurnoBLL.VereificarTurnoAbierto() == true)
                {
                    //Verifica si ahi cajero Ingresado
                    if (CajaBLL.VereificarCajaAbierta() == true)
                    {
                        //Verifica si ahi facturas en Edicion 
                        DataTable factura2 = EncFacturaBLL.ListarEncFactura(6);
                            //Si no ahi facturas en edicion Procede a ver 
                            //si ahi facturas en facturacion
                            if (factura2.Rows.Count == 0)
                            {
                                //Trae la factura en edicion
                                DataTable factura = EncFacturaBLL.ListarEncFactura(1);
                                //Si no ahi facturas procede a crear una nueva
                                if (factura.Rows.Count == 0)
                                {
                                    int cantidad = int.Parse(lblCantidad.Text);
                                    int Codigo = int.Parse(cl.Tag.ToString());
                                    int caja = int.Parse(CajaBLL.Caja());
                                    int turno = int.Parse(TurnoBLL.Turno());
                                    EncFacturaBLL.NuevoEncFactura(turno, caja);
                                    int Numfactura = int.Parse(EncFacturaBLL.EncFactura(1));
                                    DetFacturaBLL.NuevoDetFactura(Numfactura, Codigo, cantidad);
                                    RefrescarDataGrid();
                                    TotalFactura();
                                    dgvPlatos.Rows[dgvPlatos.Rows.Count - 1].Selected = true;
                                    BannerFactura(1);
                                }
                                else
                                {
                                    int cantidad = int.Parse(lblCantidad.Text);
                                    int Codigo = int.Parse(cl.Tag.ToString());
                                    int Numfactura = int.Parse(EncFacturaBLL.EncFactura(1));
                                    DetFacturaBLL.NuevoDetFactura(Numfactura, Codigo, cantidad);
                                    RefrescarDataGrid();
                                    //TotalFactura();
                                    dgvPlatos.Rows[dgvPlatos.Rows.Count - 1].Selected = true;
                      
                                }
                            }
                            else
                            {
                                int cantidad = int.Parse(lblCantidad.Text);
                                int Codigo = int.Parse(cl.Tag.ToString());
                                int Numfactura = int.Parse(EncFacturaBLL.EncFactura(6));
                                DetFacturaBLL.NuevoDetFactura(Numfactura, Codigo, cantidad);
                                RefrescarDataGrid();
                                TotalFactura();
                                dgvPlatos.Rows[dgvPlatos.Rows.Count - 1].Selected = true;
                            }

                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No ahi Cajero Ingresado");
                    }
                }
                else
                {
                    System.Windows.MessageBox.Show("No ahi turno abirto");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            }
        }

        public void RefrescarFactura()
        {
            dgvPlatos.DataSource = ListaPlatos;
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
                if (cantidad == 1)
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
                lblCantidad.Text = "1";
            }

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
            StyleDataGrid();
            RefrescarDataGrid();
            ScrollPanelPlato();
        }

        public void StyleDataGrid()
        {
            dgvPlatos.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dgvPlatos.DefaultCellStyle.ForeColor = Color.Black;
            dgvPlatos.DefaultCellStyle.BackColor = Color.White;
            dgvPlatos.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            dgvPlatos.DefaultCellStyle.SelectionBackColor = Color.Gray;
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
            ptbIngresarCajero.Click += new System.EventHandler(this.btnAbrirCaja_Click);
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
            lblIngresarCajero.Click += new System.EventHandler(this.btnAbrirCaja_Click);
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
            ptbCierreCajero.Click += new System.EventHandler(this.btnCerrarCaja_Click);
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
            lblCierreCajero.Click += new System.EventHandler(this.btnCerrarCaja_Click);
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
        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            if (TurnoBLL.VereificarTurnoAbierto() == true)
            {
                if (CajaBLL.VereificarCajaAbierta() == true)
                {

                    System.Windows.MessageBox.Show("Ya ahi cajero Ingresado");
                }
                else
                {
                    frmIngresarCajero AbrirCaja = new frmIngresarCajero();
                    AbrirCaja.ShowDialog();
                }
            }
            else
            {
                System.Windows.MessageBox.Show("No ahi turno Abirto");
            }
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            if (CajaBLL.VereificarCajaAbierta() == false)
            {
                System.Windows.MessageBox.Show("No ahi una Caja para Cerrar");
            }
            else
            {

                if (System.Windows.MessageBox.Show("Desea cerrar la Caja", "Cerrar Caja?", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    try
                    {
                        CajaBLL.CerrarCaja();
                        System.Windows.MessageBox.Show("Caja Cerrado con Exito");
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
                else
                {

                }
            }

        }

        private void lblTituloCantidad_Click(object sender, EventArgs e)
        {
            lblCantidad.Text = "1";
        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {
            lblCantidad.Text = "1";
        }

        public void llenarBilletes()
        {
            arrayBilletes.Add("1000");
            arrayBilletes.Add("2000");
            arrayBilletes.Add("3000");
            arrayBilletes.Add("4000");
            arrayBilletes.Add("5000");
            arrayBilletes.Add("6000");
            arrayBilletes.Add("7000");
            arrayBilletes.Add("8000");
            arrayBilletes.Add("9000");
            arrayBilletes.Add("10 000");
            arrayBilletes.Add("20 000");
            arrayBilletes.Add("50 000");
        }
        public void llenarTeclado()
        {
            arrayTeclado.Add("1");
            arrayTeclado.Add("2");
            arrayTeclado.Add("3");
            arrayTeclado.Add("4");
            arrayTeclado.Add("5");
            arrayTeclado.Add("6");
            arrayTeclado.Add("7");
            arrayTeclado.Add("8");
            arrayTeclado.Add("9");
            arrayTeclado.Add("0");
        }
        public void CambiarColorEstadoVerde()
        {
            lblBannerFactura.BackColor = System.Drawing.Color.Green;
            lblBannerFactura.BackColor = System.Drawing.Color.Green;
            lblBannerFactura.Text = "Facturado";
        }

        private void btnLlevar_Click(object sender, EventArgs e)
        {
            NoScrollPanelPlato();
            //CambiarColorEstadoVerde();
            PanelPlato.Controls.Clear();
            var fplBilletes = new FlowLayoutPanel();
            fplBilletes.Location = new System.Drawing.Point(3, 3);
            fplBilletes.Size = new System.Drawing.Size(496, 198);
            fplBilletes.BackColor = System.Drawing.Color.Gray;
            PanelPlato.Controls.Add(fplBilletes);

            arrayBilletes.Clear();
            llenarBilletes();
            int AnchoBoton = 118;
            int AltoBoton = 60;
            int cont = 0;
            for (int i = 0; i < arrayBilletes.Count; i++)
            {
                // Suma para seber cuando ahi que bajar de fila 
                cont += 1;
                // Pregunta si el contador esta preparado para 
                // Dar un salto de linea 
                if (cont < 5)
                {
                    //Creacion de el pictureBox Nulo
                    var btnBilletes = new Button();
                    btnBilletes.Size = new System.Drawing.Size(AnchoBoton, AltoBoton);
                    btnBilletes.BackColor = System.Drawing.Color.White;
                    btnBilletes.Visible = true;
                    btnBilletes.Text = "₡ " + arrayBilletes[i].ToString();
                    btnBilletes.Tag = arrayBilletes[i].ToString();
                    btnBilletes.Font = new Font("Arial", 12, System.Drawing.FontStyle.Bold);
                    btnBilletes.BackgroundImage = global::AppSodaQuincho.Properties.Resources.Billete;
                    btnBilletes.BackgroundImageLayout = ImageLayout.Stretch;
                    if (arrayBilletes[i].ToString() == "1000")
                    {
                        btnBilletes.ForeColor = System.Drawing.Color.Red;
                    }
                    if (arrayBilletes[i].ToString() == "2000")
                    {
                        btnBilletes.ForeColor = System.Drawing.Color.Blue;
                    }
                    if (arrayBilletes[i].ToString() == "5000")
                    {
                        btnBilletes.ForeColor = System.Drawing.Color.Gold;
                    }
                    if (arrayBilletes[i].ToString() == "10 000")
                    {
                        btnBilletes.ForeColor = System.Drawing.Color.Green;
                    }
                    if (arrayBilletes[i].ToString() == "20 000")
                    {
                        btnBilletes.ForeColor = System.Drawing.Color.Orange;
                    }
                    if (arrayBilletes[i].ToString() == "50 000")
                    {
                        btnBilletes.ForeColor = System.Drawing.Color.Purple;
                    }
                    fplBilletes.Controls.Add(btnBilletes);
                    btnBilletes.Click += new System.EventHandler(this.btnBilletes_Click);
                    //--------------------------------------------
                }
                else
                {
                    cont = 0;
                    i -= 1;
                }
            }
            // Teclado
            var flpTecladoPago = new FlowLayoutPanel();
            flpTecladoPago.Location = new System.Drawing.Point(3, 305);
            flpTecladoPago.Size = new System.Drawing.Size(305,305);
            flpTecladoPago.BackColor = System.Drawing.Color.Gray;
            PanelPlato.Controls.Add(flpTecladoPago);
            arrayTeclado.Clear();
            llenarTeclado();

            //Panel Botones de Pago
            var flpBotonesPago = new FlowLayoutPanel();
            flpBotonesPago.Location = new System.Drawing.Point(310, 305);
            flpBotonesPago.Size = new System.Drawing.Size(188, 305);
            flpBotonesPago.BackColor = System.Drawing.Color.Gray;
            PanelPlato.Controls.Add(flpBotonesPago);
            arrayTeclado.Clear();
            llenarTeclado();

            //Panel Monto Pago
            var PanelMontoPago = new Panel();
            PanelMontoPago.Location = new System.Drawing.Point(3, 205);
            PanelMontoPago.Size = new System.Drawing.Size(305, 97);
            PanelMontoPago.BackColor = System.Drawing.Color.Gray;
            PanelPlato.Controls.Add(PanelMontoPago);

            //Monto a Pagar
            var MontoPago = new TextBox();
            PanelMontoPago.Location = new System.Drawing.Point(20, 40);
            MontoPago.Size = new System.Drawing.Size(250, 80);
            PanelMontoPago.Controls.Add(MontoPago);

            // Titulo Panel Monto Pago
            var PanelMontoPagoTitulo = new FlowLayoutPanel();
            PanelMontoPagoTitulo.Size = new System.Drawing.Size(305, 30);
            PanelMontoPagoTitulo.BackColor = System.Drawing.Color.Blue;
            PanelMontoPago.Controls.Add(PanelMontoPagoTitulo);

            // Total de Pagar
            var PanelTotalPago = new Panel();
            PanelTotalPago.Location = new System.Drawing.Point(310, 205);
            PanelTotalPago.Size = new System.Drawing.Size(188, 97);
            PanelTotalPago.BackColor = System.Drawing.Color.Gray;
            PanelPlato.Controls.Add(PanelTotalPago);

            //Titulo Total de Pago
            var PanelTotalPagoTitulo = new Panel();
            PanelTotalPagoTitulo.Size = new System.Drawing.Size(188, 30);
            PanelTotalPagoTitulo.BackColor = System.Drawing.Color.Blue;
            PanelTotalPago.Controls.Add(PanelTotalPagoTitulo);

            //Label Titulo Total de Pago
            var lblTituloTotalPago = new Label();
            lblTituloTotalPago.Text = "Monto Total";
            lblTituloTotalPago.Font = new Font("Arial", 16, System.Drawing.FontStyle.Regular);
            PanelTotalPagoTitulo.Controls.Add(lblTituloTotalPago);

            //Asignar el valor a el label total de Pago
            var lblTotalPago = new Label();
            lblTotalPago.Font = new Font("Arial", 16, System.Drawing.FontStyle.Bold);
            int Numfactura = int.Parse(EncFacturaBLL.EncFactura(1));
            double total = double.Parse(DetFacturaBLL.SumDetFactura(Numfactura));
            lblTotalPago.Text = "₡ "+ total.ToString();
            lblTotalPago.Location = new System.Drawing.Point(50, 50);
            PanelTotalPago.Controls.Add(lblTotalPago);

            arrayTeclado.Clear();
            llenarTeclado();

            for (int i = 0; i < arrayTeclado.Count; i++)
            {
                    //Creacion de numeros del teclado
                    var btnNumerosTeclado = new Button();
                    btnNumerosTeclado.Size = new System.Drawing.Size(70, 70);
                    btnNumerosTeclado.BackColor = System.Drawing.Color.White;
                    btnNumerosTeclado.Visible = true;
                    btnNumerosTeclado.Text = arrayTeclado[i].ToString();
                    btnNumerosTeclado.Tag = arrayTeclado[i].ToString();
                    btnNumerosTeclado.Font = new Font("Arial",16, System.Drawing.FontStyle.Bold);
                    flpTecladoPago.Controls.Add(btnNumerosTeclado);
                    
                    //btnNumerosTeclado.Click += new System.EventHandler(this.btnBilletes_Click);
                    //--------------------------------------------
            }
            var btnBorrar = new Button();
            btnBorrar.Size = new System.Drawing.Size(145, 70);
            btnBorrar.BackColor = System.Drawing.Color.White;
            btnBorrar.Visible = true;
            btnBorrar.Text = "<---";
            btnBorrar.Tag = "borrar";
            btnBorrar.Font = new Font("Arial", 20, System.Drawing.FontStyle.Bold);
            flpTecladoPago.Controls.Add(btnBorrar);

            var btnLimpiar = new Button();
            btnLimpiar.Size = new System.Drawing.Size(145, 70);
            btnLimpiar.BackColor = System.Drawing.Color.White;
            btnLimpiar.Visible = true;
            btnLimpiar.Text = "CE";
            btnLimpiar.Tag = "limpiar";
            btnLimpiar.Font = new Font("Arial", 20, System.Drawing.FontStyle.Bold);
            flpTecladoPago.Controls.Add(btnLimpiar);

            var btnAceptar = new Button();
            btnAceptar.Size = new System.Drawing.Size(145, 70);
            btnAceptar.BackColor = System.Drawing.Color.White;
            btnAceptar.Visible = true;
            btnAceptar.Text = "Aceptar";
            btnAceptar.Tag = "aceptar";
            btnAceptar.Font = new Font("Arial", 20, System.Drawing.FontStyle.Bold);
            flpTecladoPago.Controls.Add(btnAceptar);

            var btnPagoExacto = new MetroButton();
            btnPagoExacto.Size = new System.Drawing.Size(183, 70);
            btnPagoExacto.BackColor = System.Drawing.Color.White;
            btnPagoExacto.Visible = true;
            btnPagoExacto.Text = "Pago Exacto";
            btnPagoExacto.Tag = "Exacto";
            btnPagoExacto.Font = new Font("Arial",16, System.Drawing.FontStyle.Regular);
            flpBotonesPago.Controls.Add(btnPagoExacto);

            var btnColones = new MetroButton();
            btnColones.Size = new System.Drawing.Size(183, 70);
            btnColones.BackColor = System.Drawing.Color.White;
            btnColones.Visible = true;
            btnColones.Text = "Colones";
            btnColones.Tag = "Exacto";
            btnColones.Font = new Font("Arial", 16, System.Drawing.FontStyle.Regular);
            flpBotonesPago.Controls.Add(btnColones);

            var btnDolares = new MetroButton();
            btnDolares.Size = new System.Drawing.Size(183, 70);
            btnDolares.BackColor = System.Drawing.Color.White;
            btnDolares.Visible = true;
            btnDolares.Text = "Dolares";
            btnDolares.Tag = "Exacto";
            btnDolares.Font = new Font("Arial", 16, System.Drawing.FontStyle.Regular);
            flpBotonesPago.Controls.Add(btnDolares);

            var btnTargeta = new MetroButton();
            btnTargeta.Size = new System.Drawing.Size(183, 70);
            btnTargeta.BackColor = System.Drawing.Color.White;
            btnTargeta.Visible = true;
            btnTargeta.Text = "Targeta Credito";
            btnTargeta.Tag = "Exacto";
            btnTargeta.Font = new Font("Arial", 16, System.Drawing.FontStyle.Regular);
            flpBotonesPago.Controls.Add(btnTargeta);
        }

        private void btnBilletes_Click(object sender, EventArgs e)
        {
            frmIngresarCajero IngresarCajero = new frmIngresarCajero();
            IngresarCajero.ShowDialog();
        }

        private void panelCantidad_MouseClick(object sender, MouseEventArgs e)
        {
            lblCantidad.Text = "1";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
            if (dgvPlatos.CurrentRow.Index >= 0)
            {
                DataTable factura = EncFacturaBLL.ListarEncFactura(6);
                if (factura.Rows.Count == 0)
                {
                    try
                    {
                        DataTable factura2 = EncFacturaBLL.ListarEncFactura(1);
                        int Numfactura = int.Parse(EncFacturaBLL.EncFactura(1));
                        int NumDet = int.Parse(dgvPlatos[0, dgvPlatos.CurrentRow.Index].Value.ToString());
                        DetFacturaBLL.EliminarDetFactura(Numfactura, NumDet);
                        System.Windows.MessageBox.Show("Producto Eliminado");
                        RefrescarDataGrid();
                        dgvPlatos.Rows[dgvPlatos.Rows.Count - 1].Selected = true;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else
                {


                }
            }
            else
            {
                System.Windows.MessageBox.Show("Debe Selecionar un Producto");
            }

            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Debes Agregar otro Producto");
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int indice = dgvPlatos.Rows.Count - 1;
            dgvPlatos.Rows[indice].Selected = false;
        }

        private void panelHora_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerFactura_Tick(object sender, EventArgs e)
        {
            Tiempo++;
            lblTiempoFactura.Text = Tiempo.ToString();
            if (Tiempo==60)
            {
                lblTiempoFactura.ForeColor = System.Drawing.Color.Red;
            }
            if (Tiempo == 999)
            {
                timerFactura.Enabled = false;
                timerFactura.Stop();
            }
        }

        public void PararTimerFactura()
        {
            lblTiempoFactura.Text = "0";
            lblTiempoFactura.ForeColor = System.Drawing.Color.Green;
            timerFactura.Enabled = false;
            timerFactura.Stop();
            Tiempo=0;

        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            if (PrecioProducto == true)
            {
                btnPrecio.BackColor = System.Drawing.Color.NavajoWhite;
                PrecioProducto = false;
            }
            else
            {
                PrecioProducto = true;
                btnPrecio.BackColor = System.Drawing.Color.Coral;
                MessageBoxTemporal.Show("Selecciona un Producto", "Informacion", 1, false);
            }
        }

        private void btnComerAqui_Click(object sender, EventArgs e)
        {
            NoScrollPanelPlato();
        }

        

        private void btnMesa_Click(object sender, EventArgs e)
        {
            PanelPlato.Controls.Clear();

            var flpMesa = new FlowLayoutPanel();
            flpMesa.Location = new System.Drawing.Point(5, 5);
            flpMesa.Size = new System.Drawing.Size(490, 350);
            flpMesa.BackColor = System.Drawing.Color.Gray;
            flpMesa.AutoScroll = true;
            PanelPlato.Controls.Add(flpMesa);

            for (int i = 0; i < 20; i++)
            {
                var btnMesa = new Button();
                btnMesa.Size = new System.Drawing.Size(110, 110);
                btnMesa.Visible = true;
                if (i == 2)
                {
                    btnMesa.BackgroundImage = global::AppSodaQuincho.Properties.Resources.MesaOcupada;
                }
                else
                {
                    btnMesa.BackgroundImage = global::AppSodaQuincho.Properties.Resources.MesaLibre;
                }
                btnMesa.Text = i.ToString();
                btnMesa.Font = new Font(btnMesa.Font.FontFamily, 18);
                btnMesa.BackColor = System.Drawing.Color.White;
                btnMesa.BackgroundImageLayout = ImageLayout.Stretch;
                btnMesa.TextAlign = System.Drawing.ContentAlignment.TopCenter;

                flpMesa.Controls.Add(btnMesa);
            }
          
            NoScrollPanelPlato();
            var btnEstacionarMesa = new Button();
            btnEstacionarMesa.Size = new System.Drawing.Size(200, 200);
            btnEstacionarMesa.Location = new System.Drawing.Point(1,1);
            btnEstacionarMesa.BackColor = System.Drawing.Color.White;
            btnEstacionarMesa.Visible = true;
            btnEstacionarMesa.Text = "Estacionar Mesa";
            btnEstacionarMesa.Font = new Font("Arial", 16, System.Drawing.FontStyle.Regular);
            PanelPlato.Controls.Add(btnEstacionarMesa);
            btnEstacionarMesa.Click += new System.EventHandler(this.btnEstacionarMesa_Click);

        }

        //Cambia el estado de la mesa 
        private void btnEstacionarMesa_Click(object sender, EventArgs e)
        {
            DataTable factura = EncFacturaBLL.ListarEncFactura(6);
            if (factura.Rows.Count == 0)
            {
                DataTable factura2 = EncFacturaBLL.ListarEncFactura(1);
                if (factura2.Rows.Count == 0)
                {

                }
                else
                {
                    int Numfactura = int.Parse(EncFacturaBLL.EncFactura(1));
                    EncFacturaBLL.CambiarEstadoEncFactura(Numfactura,4);
                    btnMenuRegular.PerformClick();
                    RefrescarDataGrid();
                    dgvPlatos.Refresh();
                    BannerFactura(4);
                }
                }
            else
            {
                int Numfactura = int.Parse(EncFacturaBLL.EncFactura(6));
                EncFacturaBLL.CambiarEstadoEncFactura(Numfactura, 4);
                btnMenuRegular.PerformClick();
                RefrescarDataGrid();
                dgvPlatos.Refresh();
                BannerFactura(4);
            }
        }

        private void btnEstacionarMesaExpress_Click(object sender, EventArgs e)
        {
            DataTable factura = EncFacturaBLL.ListarEncFactura(6);
            if (factura.Rows.Count == 0)
            {
                DataTable factura2 = EncFacturaBLL.ListarEncFactura(1);
                if (factura2.Rows.Count == 0)
                {

                }
                else
                {
                    int Numfactura = int.Parse(EncFacturaBLL.EncFactura(1));
                    EncFacturaBLL.CambiarEstadoEncFactura(Numfactura, 7);
                    btnMenuRegular.PerformClick();
                    RefrescarDataGrid();
                    dgvPlatos.Refresh();
                    BannerFactura(4);
                }
            }
            else
            {
                int Numfactura = int.Parse(EncFacturaBLL.EncFactura(6));
                EncFacturaBLL.CambiarEstadoEncFactura(Numfactura, 4);
                btnMenuRegular.PerformClick();
                RefrescarDataGrid();
                dgvPlatos.Refresh();
                BannerFactura(4);
            }
        }

        private void btnExpress_Click(object sender, EventArgs e)
        {
            NoScrollPanelPlato();
            var btnEstacionarMesa = new Button();
            btnEstacionarMesa.Size = new System.Drawing.Size(200, 200);
            btnEstacionarMesa.Location = new System.Drawing.Point(1, 1);
            btnEstacionarMesa.BackColor = System.Drawing.Color.White;
            btnEstacionarMesa.Visible = true;
            btnEstacionarMesa.Text = "Estacionar Mesa";
            btnEstacionarMesa.Font = new Font("Arial", 16, System.Drawing.FontStyle.Regular);
            PanelPlato.Controls.Add(btnEstacionarMesa);
            btnEstacionarMesa.Click += new System.EventHandler(this.btnEstacionarMesa_Click);

        }

        private void BannerFactura(int valor)
        {
            switch (valor)
            {
                case 1:
                    PanelBannerFactura.BackColor = System.Drawing.Color.Green;
                    lblBannerFactura.BackColor = System.Drawing.Color.Green;
                    lblBannerFactura.Text = "En Facturacion"; 
                    break;
                case 2:
                    PanelBannerFactura.BackColor = System.Drawing.Color.Green;
                    lblBannerFactura.BackColor = System.Drawing.Color.Green;
                    lblBannerFactura.Text = "Comer Aca Facturado"; 
                    break;
                case 3:
                    PanelBannerFactura.BackColor = System.Drawing.Color.Green;
                    lblBannerFactura.BackColor = System.Drawing.Color.Green;
                    lblBannerFactura.Text = "Llevar Facturado";
                    break;
                case 4:
                    ;
                    PanelBannerFactura.BackColor = System.Drawing.Color.Green;
                    lblBannerFactura.BackColor = System.Drawing.Color.Green;
                    lblBannerFactura.Text = "En Mesa";
                    break;
                case 5:
                    PanelBannerFactura.BackColor = System.Drawing.Color.Green;
                    lblBannerFactura.BackColor = System.Drawing.Color.Green;
                    lblBannerFactura.Text = "Mesa Facturado";
                    break;
                case 6:
                    PanelBannerFactura.BackColor = System.Drawing.Color.Yellow;
                    lblBannerFactura.BackColor = System.Drawing.Color.Yellow;
                    lblBannerFactura.Text = "En Edicion Mesa";
                    break;
                case 7:
                    PanelBannerFactura.BackColor = System.Drawing.Color.Green;
                    lblBannerFactura.BackColor = System.Drawing.Color.Green;
                    lblBannerFactura.Text = "En Express";
                    break;
                case 8:
                    PanelBannerFactura.BackColor = System.Drawing.Color.Green;
                    lblBannerFactura.BackColor = System.Drawing.Color.Green;
                    lblBannerFactura.Text = "Express Facturado";
                    break;
                case 9:
                    PanelBannerFactura.BackColor = System.Drawing.Color.DarkViolet;
                    lblBannerFactura.BackColor = System.Drawing.Color.DarkViolet;
                    lblBannerFactura.Text = "Comida de Empleado";
                    break;
                case 10:
                    PanelBannerFactura.BackColor = System.Drawing.Color.Fuchsia;
                    lblBannerFactura.BackColor = System.Drawing.Color.Fuchsia;
                    lblBannerFactura.Text = "Promo Todo";
                    break;

                default:
                    PanelBannerFactura.BackColor = System.Drawing.Color.Silver;
                    lblBannerFactura.BackColor = System.Drawing.Color.Silver;
                    lblBannerFactura.Text = "Nueva Factura";
                    break;
            }
            if (valor == 1)
            {
               
            }
            if (valor == 2)
            {

            }
            if (valor == 3)
            {

            }
        }
    }
}
 