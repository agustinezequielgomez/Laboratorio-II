using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesClase10;

namespace TestWFClase08
{
    public partial class Form1 : Form
    {
        PaletaColeccion miPaleta;
        public Form1()
        {
            miPaleta = 5;
            InitializeComponent();
            this.groupBox1.Text = "Paleta de colores";
            this.textBox1.Multiline = true;
            this.button1.Text = "+";
            this.button2.Text = "-";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            string tempera = "";
            string seleccionado = "";
            string[] todoElTexto = textBox1.Lines;
            seleccionado = textBox1.SelectedText;
            for(i = 2;i < textBox1.Lines.Count();i++)
            {
                if(todoElTexto[i] == seleccionado)
                {
                    i -= 2;
                    MessageBox.Show("\nTempera seleccionada: " + seleccionado + "\nIndice: " + i);
                    break;
                }
            }
            frmTempera frm = new frmTempera(miPaleta[i]);
            DialogResult resultado = frm.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTempera frm = new frmTempera();
            DialogResult resultado = frm.ShowDialog();
            if(resultado == DialogResult.OK)
            {
                this.miPaleta += frm.miTempera;
                this.textBox1.Text = (string)miPaleta;
            }
        }

        private void agregarPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
            this.agregarPaletaToolStripMenuItem.Enabled = false;
        }
    }
}