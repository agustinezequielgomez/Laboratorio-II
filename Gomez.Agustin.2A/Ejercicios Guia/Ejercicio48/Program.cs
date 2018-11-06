using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio48
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();
            Recibo recibo = new Recibo();
            Recibo recibo2 = new Recibo(1);
            Recibo recibo3 = new Recibo(2);

            Factura factura = new Factura(0);
            Factura factura2 = new Factura(1);
            Factura factura3 = new Factura(2);

            contabilidad += recibo;
            contabilidad += recibo2;
            contabilidad += recibo3;

            contabilidad += factura;
            contabilidad += factura2;
            contabilidad += factura3;

            Console.WriteLine(contabilidad.ToString());
            Console.ReadKey();
        }
    }
}
