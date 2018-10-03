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
            this.comboBox1.Items.Add("");
            this.comboBox1.Items.Add("Marca");
            this.comboBox1.Items.Add("Cantidad");
            this.comboBox1.Items.Add("Color");
            this.comboBox1.SelectedItem = "";
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
            if(resultado == DialogResult.OK)
            {
                miPaleta.Colores.Remove(miPaleta[i]);
                this.textBox1.Clear();
                this.textBox1.Text = (string)miPaleta;
            }
            
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                if (this.comboBox1.Text == "Marca")
                {
                    miPaleta.Colores.Sort(Tempera.CompararNombre);
                }
                else if (this.comboBox1.Text == "Color")
                {
                    miPaleta.Colores.Sort(Tempera.CompararColor);
                }
                else if (this.comboBox1.Text == "Cantidad")
                {
                    miPaleta.Colores.Sort(Tempera.CompararCantidad);
                }
            }
            else if(radioButton2.Checked)
            {
                if (this.comboBox1.Text == "Marca")
                {
                    miPaleta.Colores.Sort(Tempera.CompararNombre);
                    miPaleta.Colores.Reverse();
                }
                else if (this.comboBox1.Text == "Color")
                {
                    miPaleta.Colores.Sort(Tempera.CompararColor);
                    miPaleta.Colores.Reverse();
                }
                else if (this.comboBox1.Text == "Cantidad")
                {
                    miPaleta.Colores.Sort(Tempera.CompararCantidad);
                    miPaleta.Colores.Reverse();
                }
            }
            this.textBox1.Clear();
            this.textBox1.Text = (string)miPaleta;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioButton2.Checked == true)
            {
                this.radioButton2.Checked = false;
                this.radioButton1.Checked = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked == true)
            {
                this.radioButton1.Checked = false;
                this.radioButton2.Checked = true;
            }
        }
    }
}