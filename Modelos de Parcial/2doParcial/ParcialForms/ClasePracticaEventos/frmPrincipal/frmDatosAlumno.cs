using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entidades;
namespace frmPrincipal
{
    public partial class frmDatosAlumno : frmAltaAlumno
    {
        public frmDatosAlumno()
        {
            InitializeComponent();
            base.txtApellido.ReadOnly = true;
            base.txtDni.ReadOnly = true;
            base.txtFoto.ReadOnly = true;
            base.txtNombre.ReadOnly = true;
        }

        public void ActualizarAlumno(Alumno alum,EventArgs evento)
        {
            base.txtNombre.Text = alum.Nombre ;
            base.txtFoto.Text = alum.FotoAlumno;
            base.txtDni.Text = alum.DNI.ToString();
            base.txtApellido.Text = alum.Apellido;
            this.pictureBox1.ImageLocation = alum.FotoAlumno;
            
        }
    }
}
