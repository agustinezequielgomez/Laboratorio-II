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

namespace Forms
{
    public partial class FrmPrincipal : Form
    {
        public actualizarString actualizarFotoPorDelegado;
        public actualizarString actualizarNombrePorDelegado;
        public actualizarAlumno mostrarAlumnoPorDelegado;
        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.AutoSize = true;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTestDelegados formDelegados = new FrmTestDelegados();
            formDelegados.Owner = this;
            formDelegados.AutoSize = true;
            formDelegados.Show();
            
        }


        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaAlumno formAlumno = new FrmAltaAlumno();
            formAlumno.Owner = this;
            formAlumno.AutoSize = true;
            formAlumno.Show();
        }

        private void alumnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDatosAlumno formDatos = new FrmDatosAlumno();
            formDatos.MdiParent = this;
            formDatos.AutoSize = true;
            formDatos.Show();
            mostrarAlumnoPorDelegado = formDatos.ActualizarAlumno;

        }

        private void delegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatos formDatos = new FrmDatos();
            formDatos.Owner = this;
            formDatos.AutoSize = true;
            formDatos.Show();
            actualizarNombrePorDelegado = formDatos.ActualizarNombre;
            actualizarFotoPorDelegado = formDatos.ActualizarFoto;
        }
    }
}
