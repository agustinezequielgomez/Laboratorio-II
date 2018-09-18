using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesClase08;
namespace TestWFClase08
{
    public partial class frmTempera : Form
    {
        private Tempera _miTempera;
        public Tempera miTempera { get { return this._miTempera; } }
        public frmTempera()
        {
            InitializeComponent();
            
            this.label1.Text = "Color";
            this.label2.Text = "Marca";
            this.label3.Text = "Cantidad";
            this.button1.Text = "Aceptar";
            this.button2.Text = "Cancelar";
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDown;
            foreach(ConsoleColor colores in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.comboBox2.Items.Add(colores);
            }
            this.comboBox2.Items.Add("Seleccione uno");
            this.comboBox2.SelectedItem = "Seleccione uno";
        }

        public frmTempera(Tempera tmp) : this()
        {
            this._miTempera = tmp;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTempera_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _miTempera = new Tempera(sbyte.Parse(this.textBox2.Text),(ConsoleColor)this.comboBox2.SelectedItem,this.textBox1.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}