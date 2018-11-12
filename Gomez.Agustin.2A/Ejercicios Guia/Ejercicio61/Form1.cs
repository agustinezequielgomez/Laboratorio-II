using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio61
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Persona> lista = PersonaDAO.Leer();
            foreach (Persona item in lista)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Persona persona = (Persona)listBox1.SelectedItem;
            Persona modificada = new Persona(textBox1.Text, textBox2.Text,persona.id);
            PersonaDAO.Modificar(modificada);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(textBox1.Text, textBox2.Text);
            PersonaDAO.Guardar(persona);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Persona persona = (Persona)listBox1.SelectedItem;
            listBox1.Items.Remove(persona);
            PersonaDAO.Borrar(persona);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonaDAO.CrearTabla();
        }
    }
}
