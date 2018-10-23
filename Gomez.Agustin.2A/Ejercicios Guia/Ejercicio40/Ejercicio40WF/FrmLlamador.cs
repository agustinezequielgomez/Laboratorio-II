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
    public partial class FrmLlamador : Form
    {
        private Centralita _centralita;
        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            _centralita = centralita;
            this.cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            this.txtNroDestino.Text = "";
            this.txtNroOrigen.Text = "";
        }

        public Centralita MiCentralita
        {
            get
            {
                return this._centralita;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "6";
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "-";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "")
            {
                cmbFranja.Enabled = true;
            }
            txtNroDestino.Text += "#";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = "";
            this.txtNroOrigen.Text = "";
            this.cmbFranja.Enabled = false;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Provincial.Franja franjas;
            Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
            if (cmbFranja.Enabled == true)
            {
                Provincial provincial = new Provincial(txtNroOrigen.Text, franjas, random.Next(1, 50), txtNroDestino.Text);
                this._centralita += provincial;
            }
            else
            {
                Local local = new Local(txtNroOrigen.Text, random.Next(1, 50), txtNroDestino.Text,(float)(random.NextDouble() * (5.6 - 0.5) + 0.5));
                this._centralita += local;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
