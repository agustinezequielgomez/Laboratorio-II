using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio40;

namespace Ejercicio40WF
{
    public partial class FrmMenu : Form
    {
        Centralita centralita;
        public FrmMenu()
        {
            InitializeComponent();
            centralita = new Centralita();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamador = new FrmLlamador(this.centralita);
            frmLlamador.ShowDialog();
            MessageBox.Show(centralita.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMostrar frm = new FrmMostrar(this.centralita);
            frm.miTipoLlamada = TipoLlamada.Provinicial;
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMostrar frm = new FrmMostrar(this.centralita);
            frm.miTipoLlamada = TipoLlamada.Todas;
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMostrar frm = new FrmMostrar(this.centralita);
            frm.miTipoLlamada = TipoLlamada.Local;
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
