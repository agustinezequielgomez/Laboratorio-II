using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClase06WF
{
    public partial class FrmTinta : Form
    {
        public FrmTinta()
        {
            InitializeComponent();

            cboColor.Items.Add("Seleccione uno");
            cboColor.SelectedItem = "Seleccione uno";

            cboTipo.Items.Add("Seleccione uno");
            cboTipo.SelectedItem = "Seleccione uno";
            foreach (ConsoleColor colores in Enum.GetValues(typeof(ConsoleColor)))
            {
                cboColor.Items.Add(colores);
            }
           
            foreach(ETipoTinta tipos in ETipoTinta.GetValues(typeof(ETipoTinta)))
            {
                cboTipo.Items.Add(tipos);
            }


            cboColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
