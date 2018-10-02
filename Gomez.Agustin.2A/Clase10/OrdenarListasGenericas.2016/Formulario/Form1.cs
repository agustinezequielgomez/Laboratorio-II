using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Libreria;

namespace Formulario
{
    public partial class Form1 : Form
    {
        #region Atributo

        private List<Persona> _lista;

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();

            this._lista = new List<Persona>();
        }
        #endregion

        #region Manejadores de Eventos
        
        private void cargarPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Persona p1 = new Persona("Pérez", "Ricardo", 123);
            Persona p2 = new Persona("Álvarez", "Zulema", 789);
            Persona p3 = new Persona("Fernandez", "Hugo", 456);
            Persona p4 = new Persona("Otero", "Andrés", 951);

            this._lista.Add(p1);
            this._lista.Add(p2);
            this._lista.Add(p3);
            this._lista.Add(p4);

            this.cboOrdenamiento.SelectedIndex = 0;

        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cboOrdenamiento.SelectedIndex)
            {
                case 1://Apellido
                    this._lista.Sort(Persona.OredenaPersonasPorApellido);
                    break;
                case 2://Nombre
                    this._lista.Sort(Persona.OredenaPersonasPorNombre);
                    break;
                case 3://Dni
                    this._lista.Sort(Persona.OredenaPersonasPorDni);
                    break;
                default://Sin orden
                    break;
            }

            this.MostrarListado();
        }
        #endregion

        #region Métodos

        private void MostrarListado()
        {
            this.txtLista.Clear();

            this.txtLista.Text = Persona.MostrarLista(this._lista);
        }
        #endregion
    }
}
