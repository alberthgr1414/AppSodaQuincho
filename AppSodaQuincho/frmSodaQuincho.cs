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
            //Thread t = new Thread(new ThreadStart(StartForm));
            //t.Start();
            //t.Abort();
            //Thread.Sleep(10000);
            InitializeComponent(); 
        }

        public void StartForm()
        {
            System.Windows.Forms.Application.Run(new frmSplashScreen());
        }

        //public void SetColores() {
        //    tsbVentaRapida.BackColor = System.Drawing.Color.Gray;
        //    tsbOrdenMesa.BackColor = System.Drawing.Color.Gray;
        //    tsbExpress.BackColor = System.Drawing.Color.Gray;
        //    tsbAbrirTurno.BackColor = System.Drawing.Color.Gray;
        //    tsbCerrarTurno.BackColor = System.Drawing.Color.Gray;
        //    tsbMantenimientos.BackColor = System.Drawing.Color.Gray;
        //}

        private void SodaQuincho_Load(object sender, EventArgs e)
        {
            PersistenciaSqlServer.Persistencia.Persistencia.getInstance().establecerConexion("sa", "123456");
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmIngreso newMDIChild = new frmIngreso();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
            tspMenu.Visible = false;
            tspMenuTecnico.Visible = false;
            Neg_General neg = new Neg_General();
            neg.ResizeForm(this, 768, 1366);
        }

        public void cambio()
        {
            tsbVentaRapida.PerformClick();
        }

        public class Neg_General
        {
            float f_HeightRatio = new float();
            float f_WidthRatio = new float();
            public void ResizeForm(Form ObjForm, int DesignerHeight, int DesignerWidth)
            {
                #region Code for Resizing and Font Change According to Resolution
                //Specify Here the Resolution Y component in which this form is designed
                //For Example if the Form is Designed at 800 * 600 Resolution then DesignerHeight=600
                int i_StandardHeight = DesignerHeight;
                //Specify Here the Resolution X component in which this form is designed
                //For Example if the Form is Designed at 800 * 600 Resolution then DesignerWidth=800
                int i_StandardWidth = DesignerWidth;
                int i_PresentHeight = Screen.PrimaryScreen.Bounds.Height;//Present Resolution Height
                int i_PresentWidth = Screen.PrimaryScreen.Bounds.Width;//Presnet Resolution Width
                f_HeightRatio = (float)((float)i_PresentHeight / (float)i_StandardHeight);
                f_WidthRatio = (float)((float)i_PresentWidth / (float)i_StandardWidth);
                ObjForm.AutoScaleMode = AutoScaleMode.None;//Make the Autoscale Mode=None
                ObjForm.Scale(new SizeF(f_WidthRatio, f_HeightRatio));
                foreach (Control c in ObjForm.Controls)
                {
                    if (c.HasChildren)
                    {
                        ResizeControlStore(c);
                    }
                    else
                    {
                        c.Font = new Font(c.Font.FontFamily, c.Font.Size * f_HeightRatio, c.Font.Style, c.Font.Unit, ((byte)(0)));
                    }
                }
                ObjForm.Font = new Font(ObjForm.Font.FontFamily, ObjForm.Font.Size * f_HeightRatio, ObjForm.Font.Style, ObjForm.Font.Unit, ((byte)(0)));
                #endregion
            }

            private void ResizeControlStore(Control objCtl)
            {
                if (objCtl.HasChildren)
                {
                    foreach (Control cChildren in objCtl.Controls)
                    {
                        if (cChildren.HasChildren)
                        {
                            ResizeControlStore(cChildren);
                        }
                        else
                        {
                            cChildren.Font = new Font(cChildren.Font.FontFamily, cChildren.Font.Size * f_HeightRatio, cChildren.Font.Style, cChildren.Font.Unit, ((byte)(0)));
                        }
                    }
                    objCtl.Font = new Font(objCtl.Font.FontFamily, objCtl.Font.Size * f_HeightRatio, objCtl.Font.Style, objCtl.Font.Unit, ((byte)(0)));
                }
                else
                {
                    objCtl.Font = new Font(objCtl.Font.FontFamily, objCtl.Font.Size * f_HeightRatio, objCtl.Font.Style, objCtl.Font.Unit, ((byte)(0)));
                }

            }
        }

    public void MenuVisible()
        {
            tspMenu.Visible = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //SetColores();
            //tsbVentaRapida.BackColor = System.Drawing.Color.Transparent;
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
            //SetColores();
            //tsbAbrirTurno.BackColor = System.Drawing.Color.Transparent;
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
            //SetColores();
            //tsbCerrarTurno.BackColor = System.Drawing.Color.Transparent;
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
            //SetColores();
            //tsbOrdenMesa.BackColor = System.Drawing.Color.Transparent;
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmMesa newMDIChild = new frmMesa();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();

        }

        public void InicioSession()
        {
            tspMenuTecnico.Visible = false;
            tspMenu.Visible = true;
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmFacturacion newMDIChild = new frmFacturacion();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        public void InicioSessionTecnico()
        {
            tspMenuTecnico.Visible = true;
            tspMenu.Visible = false;
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmTecnico newMDIChild = new frmTecnico();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        public void FinSession()
        {
            tspMenu.Visible = false;
            tspMenuTecnico.Visible = false;
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmIngreso newMDIChild = new frmIngreso();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            if (System.Windows.MessageBox.Show("Desea cerrar session", "Cerrar Session?", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
                    FinSession();
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
            //SetColores();
            //tsbExpress.BackColor = System.Drawing.Color.Transparent;
        }

        private void tsbMantenimientos_Click(object sender, EventArgs e)
        {
            //SetColores();
            //tsbMantenimientos.BackColor = System.Drawing.Color.Transparent;
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void tsbCerrarSessionTec_Click(object sender, EventArgs e)
        {
            if (System.Windows.MessageBox.Show("Desea cerrar session", "Cerrar Session?", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
                    FinSession();
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

        private void tsbInicio_Click(object sender, EventArgs e)
        {

        }

        private void tsbConfigCaja_Click(object sender, EventArgs e)
        {
            //SetColores();
            //tsbVentaRapida.BackColor = System.Drawing.Color.Transparent;
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmConfigurarTerminal newMDIChild = new frmConfigurarTerminal();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }
    }
}
