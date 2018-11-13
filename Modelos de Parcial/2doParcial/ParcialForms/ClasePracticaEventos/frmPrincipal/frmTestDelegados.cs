using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmTestDelegados : Form
    {
        private string _path;
        public frmTestDelegados()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ((frmPrincipal)this.Owner).delNombre(txtNombre.Text);
            ((frmPrincipal)this.Owner).delFoto(this._path);
            /*foreach (Form i in Application.OpenForms)
            {
                 if(i is frmDatos)
                {
                    actualizarNombrePorDelegado del = ((frmDatos)i).ActualizarNombre;
                    del.Invoke(this.txtNombre.Text);
                    actualizarFotoPorDelegado delFoto = ((frmDatos)i).ActualizarFoto;
                    delFoto.Invoke(this._path);
                    break;
                }
            }*/
        }

        private void ConfigurarOpenSaveFileDialog()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            this.openFileDialog1.InitialDirectory = path;
            this.openFileDialog1.DefaultExt = "Seleccione una foto...";
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Filter = "Fotografias|*.jpg";
        }


        private void btnBuscarFoto_Click_1(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this._path = this.openFileDialog1.FileName;
            }
        }
    }
}
