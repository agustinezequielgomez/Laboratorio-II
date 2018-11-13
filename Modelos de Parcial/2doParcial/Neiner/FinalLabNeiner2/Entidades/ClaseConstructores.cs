using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Entidades
{
    public class ClaseConstructores
    {

       
        static ClaseConstructores()
        {
            MessageBox.Show("Estoy en el estatico");
            ClaseConstructores c1=new ClaseConstructores("a", 2);
        }
        private ClaseConstructores(string nombre,int edad)
        {
            MessageBox.Show("Estoy en el de parametros");
            
        }
        public ClaseConstructores()
        {
            
                MessageBox.Show("Estoy en el por defecto.");
                Escritura = 2;
          
            
        }

        public int Escritura
        {
            set
            {
                MessageBox.Show("Estoy en escritura");
                string ahre = Lectura;
            }
        }
        public string Lectura
        {
            get
            {
                MessageBox.Show("Lectura");
                return this.MetodoInstancia().ToString();
            }
        }

        private int MetodoInstancia()
        {
            MessageBox.Show("Estoy en metodo instancia");
            return ClaseConstructores.MetodoEstatico();
        }

        private static int MetodoEstatico()
        {
            MessageBox.Show("Estoy en metodo estatico");
            return 2;
        }
    }
}
