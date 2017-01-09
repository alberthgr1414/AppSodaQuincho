using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace AppSodaQuincho
{
    public partial class frmSodaQuincho : Form
    {
        public frmSodaQuincho()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(10000);
            InitializeComponent();
            t.Abort();
        }

        public void StartForm()
        {
            System.Windows.Forms.Application.Run(new frmSplashScreen());
        }

        public void SetColores() {
            tsbVentaRapida.BackColor = System.Drawing.Color.Gray;
            tsbOrdenMesa.BackColor = System.Drawing.Color.Gray;
            tsbExpress.BackColor = System.Drawing.Color.Gray;
            tsbAbrirTurno.BackColor = System.Drawing.Color.Gray;
            tsbCerrarTurno.BackColor = System.Drawing.Color.Gray;
            tsbMantenimientos.BackColor = System.Drawing.Color.Gray;
        }

        private void SodaQuincho_Load(object sender, EventArgs e)
        {
            PersistenciaSqlServer.Persistencia.Persistencia.getInstance().establecerConexion("sa", "123456");
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmFacturacion newMDIChild = new frmFacturacion();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SetColores();
            tsbVentaRapida.BackColor = System.Drawing.Color.Transparent;
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmFacturacion newMDIChild = new frmFacturacion();
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
            SetColores();
            tsbAbrirTurno.BackColor = System.Drawing.Color.Transparent;
            if (TurnoBLL.VereificarTurnoAbierto() == true)
            {
                System.Windows.MessageBox.Show("Ya ahi un turno abierto");
            }
            else
            {
                frmAbrirTurno AbrirTurno = new frmAbrirTurno();
                AbrirTurno.ShowDialog();
            }

        }
        public bool VerificarTurno()
        {
            return true;
        }

        private void tsbCerrarTurno_Click(object sender, EventArgs e)
        {
            SetColores();
            tsbCerrarTurno.BackColor = System.Drawing.Color.Transparent;
            if (TurnoBLL.VereificarTurnoAbierto() == false)
            {
                System.Windows.MessageBox.Show("No ahi un turno para Cerrar");
            }
            else
            {

                if (System.Windows.MessageBox.Show("Desea cerrar el Turno", "Cerrar Turno?", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    try
                    {
                        TurnoBLL.CerrarTurno();
                        System.Windows.MessageBox.Show("Turno Cerrado con Exito");
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            SetColores();
            tsbOrdenMesa.BackColor = System.Drawing.Color.Transparent;
        }


        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            if (System.Windows.MessageBox.Show("Desea salir del Sistema", "Salir?", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
                    this.Close();
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

        private void tsbExpress_Click(object sender, EventArgs e)
        {
            SetColores();
            tsbExpress.BackColor = System.Drawing.Color.Transparent;
        }

        private void tsbMantenimientos_Click(object sender, EventArgs e)
        {
            SetColores();
            tsbMantenimientos.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
