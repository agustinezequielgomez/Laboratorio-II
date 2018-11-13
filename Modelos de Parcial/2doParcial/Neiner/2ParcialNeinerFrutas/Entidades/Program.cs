using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public delegate string delegadoListadoBD(ISerializable obj);
    public class Program
    {
        private bool Deserializar(ISerializable obj)
        {
            return obj.Deserializar();
        }

        private void Main(string[] args)
        {
            Cajon<Fruta> cajon = new Cajon<Fruta>(10,15);
            Manzana m1 = new Manzana(2, ConsoleColor.Red, "man");
            Manzana m2 = new Manzana(3, ConsoleColor.Red, "manz");
            Platano p1 = new Platano(4, ConsoleColor.Yellow, "ecu");
            Platano p2 = new Platano(5, ConsoleColor.Yellow, "ecua");
            delegadoListadoBD delegado = new delegadoListadoBD(this.ObtenerPreciosBD);
            cajon += m1;
            cajon += p1;
            cajon += m2;
            cajon += p2;
            Console.WriteLine(cajon.ToString());
            this.Serializar(m1);
            this.Deserializar(m1);
            this.Serializar(cajon);
            this.Deserializar(cajon);
            Console.WriteLine(delegado.Invoke(cajon));
        }

        private string ObtenerPreciosBD(ISerializable obj)
        {
            SqlConnection sqlcon = new SqlConnection(Properties.Settings.Default.Setting);
            SqlCommand sqlcomm;
            sqlcomm = new SqlCommand();
            sqlcomm.Connection = sqlcon;
            sqlcomm.CommandType = CommandType.Text;
            sqlcomm.CommandText = "SELECT TOP 1000 * FROM PreciosFruta";
            sqlcon.Open();
            SqlDataReader sqlread = sqlcomm.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (sqlread.Read())
            {
                for (int i = 0; i < 3; i++)
                {
                    sb.Append(sqlread[i] + " | ");
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }

        private bool Serializar(ISerializable obj)
        {
            return obj.SerializarXML();
        }
    }
}
