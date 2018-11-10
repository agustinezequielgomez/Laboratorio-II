using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = "txt";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            richTextBox1.Text = ArchivoTexto.Leer(openFileDialog1.FileName);
            saveFileDialog1.FileName = openFileDialog1.FileName;
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            ArchivoTexto.Guardar(saveFileDialog1.FileName, richTextBox1.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            toolStripStatusLabel1.Text = String.Format("{0} caracteres", richTextBox1.Text.Length);
            statusStrip1.Refresh();
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.FileName == "" && openFileDialog1.FileName == "")
            {
                guardarComoToolStripMenuItem_Click(sender,e);
            }
            else
            {
                ArchivoTexto.Guardar(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }
    }
}
