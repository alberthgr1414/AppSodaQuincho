using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using BLL;
using Entidades;
using System.Net.NetworkInformation;

namespace AppSodaQuincho
{
    public partial class frmMantenimientoPlato : Form
    {
        TipoMantenimiento tipo;
        public static int IdPlato;

        public frmMantenimientoPlato()
        {
            InitializeComponent();
        }

       private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                //OpenFileDialog oOpenFile = new OpenFileDialog();
                ofdImagen.Title = "Seleccione la imagen";
                //oOpenFile.SupportMultiDottedExtensions = true;
                ofdImagen.DefaultExt = "*.png";  //Indica extensión inicial de las imágenes a mostrar
                ofdImagen.Filter = "Archivos de Imagenes All files (*.*)|*.*";
                ofdImagen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);//Define el directorio default a abrir
                ofdImagen.FileName = "";
                ofdImagen.InitialDirectory = "C:\\";


                if (ofdImagen.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        ptbFotografia.ImageLocation = ofdImagen.FileName;  //Asigna la fotografía al pictureBox
                        ptbFotografia.SizeMode = PictureBoxSizeMode.StretchImage;

                        //Convierte la imagen a una cadena de bytes
                        byte[] cadenaBytes = File.ReadAllBytes(ofdImagen.FileName);

                        ptbFotografia.Tag = (byte[])cadenaBytes; //Pasa la fotografía en cadena de bytes al tag del picture box para luego enviarla a la bd

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:  " + ex.Message);
                    }

                }

            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void MantenimientoPlato_Load(object sender, EventArgs e)
        {
            LimpiarDatos();
            PersistenciaSqlServer.Persistencia.Persistencia.getInstance().establecerConexion("sa", "123456");
            llenarComboTipoPlato();
            llenarComboTipoPlatoBuscar();
            llenarComboTipoEstado();
            LlenarGridMantePlato(1);
            dgvPlato.AutoGenerateColumns = false;
            DesabilitarDatos();
        }





        private void LlenarGrid(int valor)
        {
            try
            {
                dgvPlato.DataSource = PlatoBLL.ListarPlatos(valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void LlenarGridMantePlato(int valor)
        {
            try
            {
                dgvPlato.DataSource = PlatoBLL.ListarPlatosMantenimiento(valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }


        public void llenarComboTipoPlato() {

            DataTable oDataTable = new DataTable();
            try
            {
                PersistenciaSqlServer.Persistencia.Persistencia.getInstance().establecerConexion("sa", "123456");
                //oDataTable = BLL.BLL.AutorBLL.consultaAutores();
                SqlCommand oCommand = new SqlCommand();
                oCommand.CommandText = "SpTipoPlatoListar";
                oCommand.CommandType = CommandType.StoredProcedure;
                oDataTable = PersistenciaSqlServer.Persistencia.Persistencia.getInstance().EjecutarConsultaDataTable(oCommand);
                cboTipoPlato.DataSource = oDataTable;
                cboTipoPlato.DisplayMember = "Descripcion";
                cboTipoPlato.ValueMember = "ID_TipoPlato";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        
        }


        public void llenarComboTipoPlatoBuscar()
        {

            DataTable oDataTable = new DataTable();
            try
            {
                PersistenciaSqlServer.Persistencia.Persistencia.getInstance().establecerConexion("sa", "123456");
                //oDataTable = BLL.BLL.AutorBLL.consultaAutores();
                SqlCommand oCommand = new SqlCommand();
                oCommand.CommandText = "SpTipoPlatoListar";
                oCommand.CommandType = CommandType.StoredProcedure;
                oDataTable = PersistenciaSqlServer.Persistencia.Persistencia.getInstance().EjecutarConsultaDataTable(oCommand);
                cboBuscarTipoPlato.DataSource = oDataTable;
                cboBuscarTipoPlato.DisplayMember = "Descripcion";
                cboBuscarTipoPlato.ValueMember = "ID_TipoPlato";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        public void llenarComboTipoEstado()
        {

            DataTable oDataTable = new DataTable();
            try
            {
                PersistenciaSqlServer.Persistencia.Persistencia.getInstance().establecerConexion("sa", "123456");
                //oDataTable = BLL.BLL.AutorBLL.consultaAutores();
                SqlCommand oCommand = new SqlCommand();
                oCommand.CommandText = "SpEstadoListar";
                oCommand.CommandType = CommandType.StoredProcedure;
                oDataTable = PersistenciaSqlServer.Persistencia.Persistencia.getInstance().EjecutarConsultaDataTable(oCommand);
                cboEstado.DataSource = oDataTable;
                cboEstado.DisplayMember = "Descripcion";
                cboEstado.ValueMember = "ID_Estado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ptbFotografia.Image == null)
            {
                MessageBox.Show("Debe digitar la imagen del Usuario");
                ptbFotografia.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNombrePlato.Text))
            {
                MessageBox.Show("Debe digitar el Nombre del Plato");
                txtNombrePlato.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Debe digitar el Precio del Plato");
                txtPrecio.Focus();
                return;
            }

            if (tipo == TipoMantenimiento.Modificar)
            {
                try
                {
                    Modificar();
                    DesabilitarDatos();
                    LimpiarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de SQL en Ejecutar sentencia SQL: \n" + ex.Message + "\n", "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }
            else
            {
                try
                {
                    Insertar();
                    DesabilitarDatos();
                    LimpiarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de SQL en Ejecutar sentencia SQL: \n" + ex.Message + "\n", "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }
        }
        

        public void Insertar() 
        {
            try
            {
                // Codigo del Plato
                int ID_TipoPlato = int.Parse(cboTipoPlato.SelectedValue.ToString());
                // Precio del plato 
                double Precio = double.Parse(txtPrecio.Text);
                // Nombre del plato
                string Nombre_Plato = txtNombrePlato.Text;
                // Foto del plato
                byte[] fotografia = (byte[])this.ptbFotografia.Tag;
                // Estado
                int ID_Estado = int.Parse(cboEstado.SelectedValue.ToString());

                PlatoBLL.GuardarPlato(ID_TipoPlato, Nombre_Plato, Precio, fotografia, ID_Estado);
                MessageBox.Show("Datos Insertados correctamente");
                //deshabilitarDatos();
                LlenarGrid(ID_TipoPlato);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Modificar()
        {
            try
            {
                // Codigo del Plato
                int ID_TipoPlato = int.Parse(cboTipoPlato.SelectedValue.ToString());
                // Precio del plato 
                double Precio = double.Parse(txtPrecio.Text);
                // Nombre del plato
                string Nombre_Plato = txtNombrePlato.Text;
                // Foto del plato
                byte[] fotografia = (byte[])this.ptbFotografia.Tag;
                // Codigo del Status
                int ID_Estado = int.Parse(cboEstado.SelectedValue.ToString());

                PlatoBLL.ModificarPlato(IdPlato, ID_TipoPlato, Nombre_Plato, Precio, fotografia, ID_Estado);
                MessageBox.Show("Datos Modificados correctamente");
                deshabilitarDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void deshabilitarDatos()
        {
            // desabilitar los txt
            txtNombrePlato.Enabled = false;
            txtPrecio.Enabled = false;
            cboTipoPlato.Enabled = false;
            // desabilitar los botones
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        public void LimpiarDatos()
        {
            txtNombrePlato.Text = "";
            txtPrecio.Text = "";
            ptbFotografia.Image = null;
        }

        public void DesabilitarDatos()
        {
            txtNombrePlato.Enabled = false;
            txtPrecio.Enabled = false;
            cboEstado.Enabled = false;
            cboTipoPlato.Enabled = false;
            ptbFotografia.Enabled = false;

            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            tsbModificar.Enabled = true;
            tsbInsertar.Enabled = true; 
        }

        public void HabilitarInsertar() 
        {
            txtNombrePlato.Enabled = true;
            txtPrecio.Enabled = true;
            cboEstado.Enabled = true;
            cboTipoPlato.Enabled = true;
            ptbFotografia.Enabled = true;
            tsbModificar.Enabled = false;
            tsbInsertar.Enabled = true;
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;
            txtNombrePlato.Focus();
        }


        public void HabilitarModificar()
        {
            txtNombrePlato.Enabled = true;
            txtPrecio.Enabled = true;
            cboEstado.Enabled = true;
            cboTipoPlato.Enabled = true;
            ptbFotografia.Enabled = true;
            tsbModificar.Enabled = true;
            tsbInsertar.Enabled = false;
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;
            txtNombrePlato.Focus();
        }

        private void tsbInsertar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            HabilitarInsertar();
            tipo = TipoMantenimiento.Insertar;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarDatos();
            LimpiarDatos();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            if (dgvPlato.SelectedRows.Count > 0)
            {
                LimpiarDatos();
                HabilitarModificar();
                Plato oUsuario = this.dgvPlato.SelectedRows[0].DataBoundItem as Plato;


                IdPlato = int.Parse(this.dgvPlato[0, dgvPlato.CurrentRow.Index].Value.ToString());
                txtNombrePlato.Text = this.dgvPlato[1, dgvPlato.CurrentRow.Index].Value.ToString();
                txtPrecio.Text = this.dgvPlato[2, dgvPlato.CurrentRow.Index].Value.ToString();
                cboTipoPlato.Text = this.dgvPlato[3, dgvPlato.CurrentRow.Index].Value.ToString();
                Byte[] FOTO = (Byte[])this.dgvPlato[4, dgvPlato.CurrentRow.Index].Value;

                ptbFotografia.Image = byteArrayToImage(FOTO);
                ptbFotografia.Tag = FOTO;
                txtNombrePlato.Focus();
                tipo = TipoMantenimiento.Modificar;
            }
            else
            {
                MessageBox.Show("Debe seleccionar el estudiante a modificar");
                return;
            }
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void cboBuscarTipoPlato_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int ID_TipoPlato = int.Parse(cboBuscarTipoPlato.SelectedValue.ToString());
                LlenarGridMantePlato(ID_TipoPlato);
            }
            catch (Exception)
            {

            }
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PanelPlato_Enter(object sender, EventArgs e)
        {

        }

        private void cboBuscarTipoPlato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

           
}
