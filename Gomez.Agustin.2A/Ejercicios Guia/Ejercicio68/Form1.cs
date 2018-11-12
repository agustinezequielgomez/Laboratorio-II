using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio68
{
    public partial class Form1 : Form
    {
        #region Atributos
        private Persona persona;
        private event DelegadoString Evento;
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodo
        public static void NotificarCambio(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Evento += Form1.NotificarCambio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.persona is null)
            {
                this.persona = new Persona(textBox1.Text, textBox2.Text);
                button1.Text = "Actualizar";
                this.Evento(String.Format("Se ha creado la persona {0}",this.persona.Mostrar()));
            }
            else
            {
                this.persona = new Persona(textBox1.Text, textBox2.Text);
                this.Evento(String.Format("Se ha actualizado la persona: {0}",this.persona.Mostrar()));
            }

        }
    }
}
