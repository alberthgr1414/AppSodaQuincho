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
using MetroFramework.Forms;
using System.Threading;

namespace AppSodaQuincho
{
    public partial class frmIngreso :  Form
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
            String usuario = txtUsuario.Text.ToString();
            String pass = txtContrasena.Text.ToString();
            if (usuario =="")
            {
                txtMensaje.Text = "Debe digitar el Usuario";
            }
            else
            {
                if (pass=="")
                {
                    txtMensaje.Text = "Debe digitar el Usuario";
                }
                else
                {
                    //this.timerProgress.Start();
                    //for (int i = 0; i < 5; i++)
                    ///{
                        //this.timerProgress.Start();
                        //Thread.Sleep(1000);
                    //}
                    DataTable data = new DataTable();
                    data = UsuarioBLL.UsuarioLogin(usuario, pass);
                    if (data != null)
                    {
                        if (data.Rows.Count > 0)
                        {

                        DataRow row = data.Rows[0];

                        int tipo = int.Parse(row["ID_TipoUsuario"].ToString());
                        if (tipo==5)
                        {
                                frmSodaQuincho frmParent = this.MdiParent as frmSodaQuincho;
                                frmParent.MenuVisible();
                                frmParent.InicioSessionTecnico();
                            }
                        else
                        {
                                frmSodaQuincho frmParent = this.MdiParent as frmSodaQuincho;
                                frmParent.MenuVisible();
                                frmParent.InicioSession();
                            }
                        }
                    }
                    else
                    {

                    }
                    
                   
                }
            }


        }

        private void frmIngreso_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Validated(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim()=="")
            {
                epError.Clear();
                epError.SetError(txtUsuario,"Introduce Usuario");
            }
            else
            {

                epError.Clear();
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasena_Validated(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Trim() == "")
            {
                epError.Clear();
                epError.SetError(txtContrasena, "Introduce Contraseña");
            }
            else
            {
                epError.Clear();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmSodaQuincho frmParent = this.MdiParent as frmSodaQuincho;
            frmParent.Close();
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            this.pgIngreso.Increment(1);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
