using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entidades;
namespace Forms
{
    public partial class FrmDatosAlumno : Forms.FrmAltaAlumno
    {
        public FrmDatosAlumno()
        {
            InitializeComponent();
            this.txtApellido.ReadOnly = true;
            this.txtDni.ReadOnly = true;
            this.txtFoto.ReadOnly = true;
            this.txtNombre.ReadOnly = true;
            this.btnAceptar.Enabled = false;
            this.btnCancelar.Enabled = false;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void ActualizarAlumno(Alumno sender, EventArgs e)
        {
            this.txtApellido.Text = sender.Apellido;
            this.txtDni.Text = sender.Dni.ToString();
            this.txtNombre.Text = sender.Nombre;
            this.txtFoto.Text = sender.FotoAlumno;
            this.pictureBox1.ImageLocation = sender.FotoAlumno;
        }
    }
}
