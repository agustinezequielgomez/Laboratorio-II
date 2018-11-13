using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio69
{
    public partial class FrmDatos : Form
    {
        public FrmDatos()
        {
            InitializeComponent();

        }

        public void ActualizarNombre(string nombre)
        {
            this.label1.Text = nombre;
        }
    }
}
