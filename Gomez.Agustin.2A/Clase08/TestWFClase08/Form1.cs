﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesClase08;

namespace TestWFClase08
{
    public partial class Form1 : Form
    {
        Paleta miPaleta;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTempera frm = new frmTempera();
            frm.ShowDialog();
            this.miPaleta += frm.miTempera;
            this.textBox1.Text = (string) miPaleta;
        }

        private void agregarPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
            this.agregarPaletaToolStripMenuItem.Enabled = false;
        }
    }
}