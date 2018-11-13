using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using Interfaces;
using Entidades;
using EventArgsClases;

namespace Programa {

    class Program {

        static SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Precios);
        static SqlCommand sqlCom;

        static private bool Deserializar(ISerializable obj) {

            return obj.Deserializar();

        }

        static private bool Serializar(ISerializable obj) {

            return obj.SerializarXML();

        }

        private string ObtenerPreciosBD(ISerializable obj) {

            StringBuilder sb = new StringBuilder();

            SqlDataReader sqlRead;
            sqlCom = new SqlCommand();
            sqlCom.Connection = conexion;
            sqlCom.CommandType = CommandType.Text;
            sqlCom.CommandText = "SELECT descripcion,precio FROM PreciosFruta";
            conexion.Open();
            sqlRead = sqlCom.ExecuteReader();

            while (sqlRead.Read()) {
	            
                sb.AppendFormat("{0} --- {1}\n",(string)sqlRead[0],(string)sqlRead[1]);

            }

            return sb.ToString();

        }

        public delegate string ListadoBD(ISerializable obj);

        static void ManejadorCajon(object o, PrecioEventArgs e) {

            StringBuilder escritura = new StringBuilder();
            Cajon<Fruta> cajon = ((Cajon<Fruta>)o);
            cajon.RutaArchivo += "\\Cajon.txt";

            int hora = DateTime.Now.Hour;
            int minuto = DateTime.Now.Minute;
            int segundo = DateTime.Now.Second;

            escritura.AppendFormat("[{0}/{1}/{2}] ", hora, minuto, segundo);
            escritura.AppendFormat("Precio total: {0}", e.PrecioTotal);

            StreamWriter sw = new StreamWriter(cajon.RutaArchivo);

            sw.Write(escritura);
            sw.Close();

        }

        static void Main(string[] args) {

            Program p = new Program();
            Cajon<Fruta> cajon = new Cajon<Fruta>(5, 8.5f);
            

            Platano p1 = new Platano(0.35f, ConsoleColor.Yellow, "Ecuador");
            Platano p2 = new Platano(0.7f, ConsoleColor.Green, "Cuba");
            Platano p3 = new Platano(0.4f, ConsoleColor.Yellow, "Argentina");
            Manzana m1 = new Manzana(0.3f, ConsoleColor.Green, "Apple Factory");
            Manzana m2 = new Manzana(0.4f, ConsoleColor.Red, "Manzanin SA");
            Manzana m3 = new Manzana(0.6f, ConsoleColor.Red, "Apple Factory");

            cajon += p1;
            cajon += p2;
            cajon += p3;
            cajon += m1;
            cajon += m2;
            cajon += m3;
           
            ListadoBD lbd = new ListadoBD(p.ObtenerPreciosBD);

            //Console.WriteLine(lbd.Invoke(cajon));

            cajon.EventoPrecio += new CajonDelegado(ManejadorCajon);
            float a = cajon.PrecioTotal;
            Console.Read();

        }

    }

}
