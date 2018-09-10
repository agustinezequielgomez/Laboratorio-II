using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClase06WF
{
    public partial class Form1 : Form
    {
        private Tinta _tinta;
        private Pluma _pluma;

        public Form1()
        {
            InitializeComponent();
        }

        private void tintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTinta frmTinta = new FrmTinta();
            frmTinta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
