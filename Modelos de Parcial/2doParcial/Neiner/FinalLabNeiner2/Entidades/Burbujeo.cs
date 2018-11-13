using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Entidades
{
    public class Burbujeo
    {
        public static void MetodoClase()
        {
            try
            {
                new Burbujeo().MetodoInstancia();
            }
            catch (MiException)
            {
                using (StreamWriter sw = new StreamWriter("burbujeo.txt", true))
                {
                    sw.WriteLine("Pase por el metodo estatico" + DateTime.Now);
                }
                throw new MiException();
            }
        }
        public void MetodoInstancia()
        {
            using (StreamWriter sw = new StreamWriter("burbujeo.txt", true))
            {
                sw.WriteLine("Pase por el metodo de instancia" + DateTime.Now);
            }
            throw new MiException();

        }
    }
}
