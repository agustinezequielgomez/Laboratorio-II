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
    public partial class FrmDatos : Form
    {
        public FrmDatos()
        {
            InitializeComponent();
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void ActualizarNombre(string nombre)
        {
            this.label1.Text = nombre;
        }
        public void ActualizarFoto(string path)
        {
            this.pictureBox1.ImageLocation = path;
        }
    }
}
