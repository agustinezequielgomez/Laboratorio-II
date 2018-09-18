using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Euro euro = new Euro(double.Parse(textBox1.Text));
            Pesos peso = new Pesos(0);
            Dolar dolar = new Dolar(0);
            Euro aux = new Euro(0);
            aux = euro;
            peso = (Pesos)euro;
            dolar = (Dolar)euro;
            textBox6.Text = (aux.getCantidad()).ToString();
            textBox9.Text = (dolar.getCantidad()).ToString();
            textBox12.Text = (peso.getCantidad()).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dolar dolar = new Dolar(double.Parse(textBox2.Text));
            Pesos peso = new Pesos(0);
            Euro euro = new Euro(0);
            Dolar aux = new Dolar(0);
            aux = dolar;
            peso = (Pesos)dolar;
            euro = (Euro)dolar;
            textBox5.Text = (euro.getCantidad()).ToString();
            textBox8.Text = (aux.getCantidad()).ToString();
            textBox11.Text = (peso.getCantidad()).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dolar dolar = new Dolar(0);
            Pesos peso = new Pesos(double.Parse(textBox3.Text));
            Euro euro = new Euro(0);
            Pesos aux = new Pesos(0);
            aux = peso;
            dolar = (Dolar)peso;
            euro = (Euro)peso;
            textBox4.Text = (euro.getCantidad()).ToString();
            textBox10.Text = (aux.getCantidad()).ToString();
            textBox7.Text = (dolar.getCantidad()).ToString();
        }
    }
}
