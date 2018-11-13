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

namespace Interfaces
{
    public partial class frmPpal : Form
    {
        LosHilos _hilos;

        public frmPpal()
        {
            InitializeComponent();
            this._hilos = new LosHilos();
            _hilos.AvisoFin += MostrarMensajeFin;
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            try
            {
                this._hilos += 2;
            }
            catch (CantidadInvalidaException)
            {
                MessageBox.Show("La cantidad es menor a 1");
            }
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_hilos.Bitacora);
        }

        public void MostrarMensajeFin(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
