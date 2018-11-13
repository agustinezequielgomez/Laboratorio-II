using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmPrincipal : Form
    {
        public actualizarNombrePorDelegado delNombre;
        public actualizarFotoPorDelegado delFoto;
        public actualizarAlumno delAlumno;
        public frmPrincipal()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados frmDel = new frmTestDelegados();
            frmDel.Owner = this;
            frmDel.Show();
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos frmDat = new frmDatos();
            frmDat.Owner = this;
            frmDat.Show();
            this.delNombre = frmDat.ActualizarNombre;
            this.delFoto = frmDat.ActualizarFoto;
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaAlumno frmal = new frmAltaAlumno();
            frmal.Owner = this;
            frmal.Show();
         
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosAlumno frmdat = new frmDatosAlumno();
            frmdat.Owner = this;
            frmdat.Show();
            this.delAlumno = frmdat.ActualizarAlumno;
        }
    }
}
