using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClase19
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void MiManejadorClick(object obj, EventArgs e) //Manejador de evento
        {
            MessageBox.Show(((Control)obj).Name);
            ((Control)obj).Click -= this.MiManejadorClick;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //this.button1.Click += this.MiOtroManejadorClick;
            this.button1.Click += this.MiManejadorClick;
            this.button1.Click += this.ManejadorCentral;
            //this.button1.Click += new EventHandler(this.MiManejadorClick);
            //this.button2.Click += new EventHandler(this.MiManejadorClick);
            //this.textBox1.Click += new EventHandler(this.MiManejadorClick);
            //this.Click += new EventHandler(this.MiOtroManejadorClick);
            //this.Click += new EventHandler(this.CambiarFondo);
        }

        public void MiOtroManejadorClick(object sender, EventArgs e)
        {
            this.button2.Click -= new EventHandler(this.MiManejadorClick);
            this.button1.Click += new EventHandler(this.MiManejadorClick); //Agregar dos veces un manejador a un evento hace que se triggeree ese metodo la X cantidad de veces que se agrego al formulario.
        }

        public void CambiarFondo(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Click -= MiOtroManejadorClick;
            this.button1.Click -= this.MiManejadorClick;
            this.button2.Click -= this.MiManejadorClick;
            this.textBox1.Click -= this.MiManejadorClick;
            this.Click -= this.CambiarFondo;
        }

        public void ManejadorCentral(object sender, EventArgs e)
        {
            if(Object.Equals(sender,this.button1))
            {
                this.button1.Click -= this.ManejadorCentral;
                this.button1.Click -= this.MiManejadorClick;
                this.button2.Click += this.MiManejadorClick;
                this.button2.Click += this.ManejadorCentral;
            }
            else if(Object.Equals(sender, this.button2))
            {
                this.button2.Click -= this.ManejadorCentral;
                this.button2.Click -= this.MiManejadorClick;
                this.textBox1.Click += this.MiManejadorClick;
                this.textBox1.Click += this.ManejadorCentral;
            }
            else if(Object.Equals(sender, this.textBox1))
            {
                this.textBox1.Click -= this.MiManejadorClick;
                this.textBox1.Click -= this.ManejadorCentral;
                this.button1.Click += this.ManejadorCentral;
                this.button1.Click += this.MiManejadorClick;
            }
        }
    }
}