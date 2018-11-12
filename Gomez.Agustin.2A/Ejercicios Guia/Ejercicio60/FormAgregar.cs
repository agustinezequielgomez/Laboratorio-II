using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio60
{
    public partial class FormAgregar : Form
    {
        public FormAgregar()
        {
            InitializeComponent();
            comboBox1.Items.Add(true);
            comboBox1.Items.Add(false);
            comboBox2.Items.Add(true);
            comboBox2.Items.Add(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(int.Parse(textBox1.Text),
                textBox2.Text, 
                textBox3.Text,
                bool.Parse(comboBox1.Text),
                bool.Parse(comboBox2.Text), 
                textBox4.Text, 
                short.Parse(textBox5.Text), 
                short.Parse(textBox6.Text),
                decimal.Parse(textBox7.Text),
                decimal.Parse(textBox8.Text),
                textBox9.Text,
                textBox10.Text, 
                textBox11.Text, 
                decimal.Parse(textBox12.Text),
                int.Parse(textBox13.Text),
                textBox14.Text,
                textBox15.Text,
                textBox16.Text, 
                int.Parse(textBox17.Text), 
                int.Parse(textBox18.Text),
                DateTime.Now,
                DateTime.Now, 
                DateTime.Now,
                new Guid("12345678-1234-1234-1234-123456789112"),
                DateTime.Now);
            ServerManagement.Agregar(producto);
        }
    }
}
