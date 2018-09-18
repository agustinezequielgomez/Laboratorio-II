using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Text = Conversion.BinarioDecimal(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = Conversion.DecimalBinario(double.Parse(textBox2.Text));
        }
    }
}
