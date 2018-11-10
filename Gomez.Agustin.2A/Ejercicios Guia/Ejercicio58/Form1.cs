using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio58
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Format("{0} caracteres", richTextBox1.Text.Length);
            statusStrip1.Refresh();
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                if(Path.GetExtension(saveFileDialog1.FileName) == ".dat")
                {
                    PuntoDat dat = new PuntoDat();
                    dat.Contenido = richTextBox1.Text;
                    dat.Guardar(saveFileDialog1.FileName, dat);
                }
                else if(Path.GetExtension(saveFileDialog1.FileName) == ".txt")
                {
                    PuntoTxt txt = new PuntoTxt();
                    txt.Guardar(saveFileDialog1.FileName, richTextBox1.Text);
                }
        }

        private void abrirArchivostxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuntoTxt txt = new PuntoTxt();
            saveFileDialog1.Filter = "Archivos de texto(*.txt) | *.txt";
            DialogResult = openFileDialog1.ShowDialog();
            if(DialogResult == DialogResult.OK)
            {
                richTextBox1.Text = txt.Leer(openFileDialog1.FileName);
                saveFileDialog1.FileName = openFileDialog1.FileName;
                guardarToolStripMenuItem1.Enabled = true;
            }
        }

        private void abrirArchivosdatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuntoDat dat = new PuntoDat();
            saveFileDialog1.Filter = "Archivos binarios(*.dat) | *.dat";
            DialogResult = openFileDialog1.ShowDialog();
            if(DialogResult == DialogResult.OK)
            {
                PuntoDat dat2 = dat.Leer(openFileDialog1.FileName);
                richTextBox1.Text = dat2.Contenido;
                saveFileDialog1.FileName = openFileDialog1.FileName;
                guardarToolStripMenuItem1.Enabled = true;
            }
        }

        private void archivosDeTextotxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuntoTxt txt = new PuntoTxt();
            saveFileDialog1.Filter = "Archivos de texto(*.txt) | *.txt";
            DialogResult = saveFileDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                txt.Guardar(saveFileDialog1.FileName, richTextBox1.Text);
                guardarToolStripMenuItem1.Enabled = true;
            }
        }

        private void archivosDeDatosdatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuntoDat dat = new PuntoDat();
            saveFileDialog1.Filter = "Archivos binarios(*.dat) | *.dat";
            DialogResult = saveFileDialog1.ShowDialog();
            if(DialogResult == DialogResult.OK)
            {
                dat.Contenido = richTextBox1.Text;
                dat.Guardar(saveFileDialog1.FileName, dat);
                guardarToolStripMenuItem1.Enabled = true;
            }
        }
    }
}
