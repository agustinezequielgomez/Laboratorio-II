using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FrmTestDelegados : Form
    {
        private string path;
        public FrmTestDelegados()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ((FrmPrincipal)this.Owner).actualizarNombrePorDelegado(this.textBox1.Text);
            ((FrmPrincipal)this.Owner).actualizarFotoPorDelegado(path);
        }
        private void ConfigurarOpenSaveDialog()
        {
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Filter = "Archivo  de imagen (*.jpg)|*.jpg|All Files (*.*)|*.*";
            this.openFileDialog1.InitialDirectory=Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
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
            this.path = openFileDialog1.FileName;
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            ConfigurarOpenSaveDialog();
        }
    }
}
