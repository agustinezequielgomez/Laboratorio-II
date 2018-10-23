using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio40;

namespace Ejercicio40WF
{
    public partial class FrmMostrar : Form
    {
        TipoLlamada tipo;
        private Centralita centralita;
        public FrmMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
            
        }

        public TipoLlamada miTipoLlamada
        {
            set
            {
                this.tipo = value;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            switch (this.tipo)
            {
                case TipoLlamada.Local:
                    richTextBox1.Text = string.Format("\nRecaudacion total por llamadas locales: {0}", centralita.GananciasPorLocal);
                    break;
                case TipoLlamada.Provinicial:
                    richTextBox1.Text = string.Format("\nRecaudacion total por llamadas provinciales: {0}", centralita.GananciasPorProvincial);
                    break;
                case TipoLlamada.Todas:
                    richTextBox1.Text = string.Format("\nRecaudacion total por todas las llamadas: {0}", centralita.GananciasPorTotal);
                    break;
                default:
                    break;
            }
        }
    }
}
