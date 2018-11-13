using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio69
{
    public delegate void TestDelegados(string dato);
    public partial class frmTestDelegados : Form
    {
        public event TestDelegados eventoDelegados;
        FrmDatos frmDatos;

        public string TextBox
        {
            get
            {
                return this.textBox1.Text;
            }
            set
            {
                this.textBox1.Text = value;
            }
        }

        public frmTestDelegados()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.frmDatos = new FrmDatos();
            this.eventoDelegados += new TestDelegados(this.frmDatos.ActualizarNombre);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.eventoDelegados(this.TextBox);
        }
    }
}
