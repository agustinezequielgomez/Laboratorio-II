using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Farenheit far = new Farenheit(double.Parse(textBox1.Text));
            Farenheit aux = new Farenheit(0);
            Celsius cel = new Celsius(0);
            Kelvin kel = new Kelvin(0);
            aux = far;
            cel = (Celsius)far;
            kel = (Kelvin)far;
            textBox6.Text = (aux.getCantidad().ToString());
            textBox9.Text = (cel.getCantidad().ToString());
            textBox12.Text = (kel.getCantidad().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Farenheit far = new Farenheit(0);
            Celsius aux = new Celsius(0);
            Celsius cel = new Celsius(double.Parse(textBox2.Text));
            Kelvin kel = new Kelvin(0);
            aux = cel;
            far = (Farenheit)cel;
            kel = (Kelvin)far;
            textBox5.Text = (far.getCantidad().ToString());
            textBox8.Text = (aux.getCantidad().ToString());
            textBox11.Text = (kel.getCantidad().ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Farenheit far = new Farenheit(0);
            Kelvin aux = new Kelvin(0);
            Celsius cel = new Celsius(0);
            Kelvin kel = new Kelvin(double.Parse(textBox3.Text));
            aux = kel;
            far = (Farenheit)kel;
            cel = (Celsius)kel;
            textBox4.Text = (far.getCantidad().ToString());
            textBox7.Text = (cel.getCantidad().ToString());
            textBox10.Text = (aux.getCantidad().ToString());
        }
    }
}
