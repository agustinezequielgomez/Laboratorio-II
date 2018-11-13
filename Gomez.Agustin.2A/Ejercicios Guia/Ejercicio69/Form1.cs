using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio69
{
    public partial class Form1 : Form
    {
        frmTestDelegados frmTestDelegados;
        FrmDatos frmDatos;
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmTestDelegados = new frmTestDelegados();
            frmTestDelegados.Owner = this;
            this.frmTestDelegados.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmDatos = new FrmDatos();
            frmDatos.Owner = this;
            this.frmDatos.Show();
        }
    }
}
