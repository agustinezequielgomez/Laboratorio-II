using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsFormCosa
{
    public partial class Form1 : Form
    {
        private Cosa _miCosa;

        public Form1()
        {
            InitializeComponent();
            this.Text += " ABM";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string cadena = this.txtCadena.Text;
            int entero = int.Parse(this.txtEntero.Text);
            DateTime fecha = DateTime.Parse(this.txtFecha.Text);

            this._miCosa = new Cosa(cadena,fecha,entero);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this._miCosa.Mostrar(),"Atencion",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }




    }
}
