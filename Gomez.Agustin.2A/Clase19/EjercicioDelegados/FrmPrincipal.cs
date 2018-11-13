using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioDelegados
{
    public partial class FrmPrincipal : Form
    {
        frmTestDelegados frmTestDelegados;
        frmDatos frmDatos;
        public actualizarNombrePorDelegado delegado;
        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterParent;
            this.frmDatos = new frmDatos();
            this.delegado += this.frmDatos.ActualizarNombre;
        }

        private void testDelegadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.frmDatos.Show(this);
        }

        private void testDelegadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmTestDelegados = new frmTestDelegados();
            this.frmTestDelegados.Show(this);
        }
    }
}
