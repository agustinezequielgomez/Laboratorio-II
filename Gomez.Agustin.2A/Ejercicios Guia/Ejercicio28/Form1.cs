using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio28
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> diccionario = new Dictionary<string, int>();
        string texto;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int masUsada = 0;
            int SegMasUsada = 0;
            int TerMasUsada = 0;
            string palMasUsada = "";
            string segPal = "";
            string terPal = "";
            bool flag = true;
            texto = richTextBox1.Text;
            String[] palabras = texto.Split(' ');
            foreach (string item in palabras)
            {
                if(diccionario.ContainsKey(item))
                {
                    diccionario[item] += 1;
                }
                else
                {
                    diccionario.Add(item, 1);
                }
            }
            foreach (string item in diccionario.Keys)
            {
                if(flag == true)
                {
                    masUsada = diccionario[item];
                    SegMasUsada = diccionario[item];
                    TerMasUsada = diccionario[item];
                    palMasUsada = item;
                    segPal = item;
                    terPal = item;
                    flag = false;
                }
                else
                {
                    if(diccionario[item] > masUsada)
                    {
                        masUsada = diccionario[item];
                        palMasUsada = item;
                    }
                    else if(diccionario[item] > SegMasUsada)
                    {
                        SegMasUsada = diccionario[item];
                        segPal = item;
                    }
                    else if(diccionario[item] > TerMasUsada)
                    {
                        TerMasUsada = diccionario[item];
                        terPal = item;
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nPalabras mas usadas:\n1- {0}. Cantidad de usos: {1}", palMasUsada, masUsada);
            sb.AppendFormat("\n2- {0}. Cantidad de usos: {1}", segPal, SegMasUsada);
            sb.AppendFormat("\n3- {0}. Cantidad de usos: {1}", terPal, TerMasUsada);
            MessageBox.Show(sb.ToString());
            
        }
    }
}
