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

namespace frmPrincipal
{
    public partial class frmAltaAlumno : Form
    {
        public frmAltaAlumno()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Alumno al = new Alumno(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text),@txtFoto.Text);
            ((frmPrincipal)this.Owner).delAlumno(al,e);
          /*  foreach (Form i in Application.OpenForms)
            {
                if(i is frmDatosAlumno)
                {
                    actualizarAlumno del = ((frmDatosAlumno)i).ActualizarAlumno;
                    del.Invoke(al,e);
                    
                    break;
                }
            }*/
        }

        private void txtFoto_DoubleClick(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            this.openFileDialog1.InitialDirectory = path;
            this.openFileDialog1.DefaultExt = "Seleccione una foto...";
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Filter = "Fotografias|*.jpg";

            if(this.openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                this.txtFoto.Text = this.openFileDialog1.FileName;
            }
            
        }
    }
}
