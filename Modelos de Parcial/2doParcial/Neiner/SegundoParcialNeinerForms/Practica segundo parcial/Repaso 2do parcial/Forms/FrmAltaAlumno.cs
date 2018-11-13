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
    public partial class FrmAltaAlumno : Form
    {
        public Alumno unAlumno;
        public FrmAltaAlumno()
        {
            InitializeComponent();
            this.txtFoto.DoubleClick += new EventHandler(ConfigurarOpenSaveDialog);
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            unAlumno = new Alumno(this.txtApellido.Text, int.Parse(this.txtDni.Text), this.txtFoto.Text, this.txtNombre.Text);
            try
            {
                ((FrmPrincipal)this.Owner).mostrarAlumnoPorDelegado(unAlumno,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "Error desconocido");
            }
        }
        private void ConfigurarOpenSaveDialog(object sender, EventArgs e)
        {
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Filter = "Archivo  de imagen (*.jpg)|*.jpg|All Files (*.*)|*.*";
            this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            this.openFileDialog1.FileName = "";
            this.openFileDialog1.Title = "Seleccione una foto...";
            this.openFileDialog1.ShowDialog();
            if (!this.openFileDialog1.CheckPathExists)
            {
                MessageBox.Show("Error: El directorio no existe");
            }
            else if (!this.openFileDialog1.CheckFileExists)
            {
                MessageBox.Show("Error: El archivo no existe");
            }
            this.txtFoto.Text = openFileDialog1.FileName;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
