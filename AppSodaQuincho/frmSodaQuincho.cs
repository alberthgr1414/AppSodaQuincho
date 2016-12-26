﻿using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace AppSodaQuincho
{
    public partial class frmSodaQuincho : Form
    {
        public frmSodaQuincho()
        {
            InitializeComponent();
        }

        private void SodaQuincho_Load(object sender, EventArgs e)
        {
            PersistenciaSqlServer.Persistencia.Persistencia.getInstance().establecerConexion("sa", "123456");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            Facturacion newMDIChild = new Facturacion();
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
            if (TurnoBLL.VereificarTurnoAbierto() == false)
            {
                System.Windows.MessageBox.Show("No ahi un turno para Cerrar");
            }
            else
            {

                if (System.Windows.MessageBox.Show("Desea cerrar el Turno", "Cerrar Turno?", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    System.Windows.MessageBox.Show("Turno Cerrado con Exito");
                }
                else
                {
                    
                }
            }

        }
    }
}
