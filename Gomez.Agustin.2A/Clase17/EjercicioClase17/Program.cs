using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Xml;
using System.Xml.Serialization;

namespace EjercicioClase17
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Leo de SQL
            List<Televisor> listaTelevisores = new List<Televisor>();
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion2); //Establezco una conexion al SQL Server. Properties.Settings.Default.Conexion -> hace referencia a la conexion establecida en los settings del proyecto.
            SqlCommand comando = new SqlCommand(); //Establezco un comando a ejecutar sobre la base de datos
            comando.CommandType = CommandType.Text; //Establezco el tipo de comando a realizar.
            /*CommandType.StoredProcedure: ejecuta un script creado previamente (Ejemplo una consulta).
             * CommandType.TableDirect: Nombre de la tabla
             * CommandType.Text: Instruccion a ejecutar sobre la base de datos.
             * */
            comando.CommandText = "SELECT * FROM Televisores"; //Establezco el comando en si
            comando.Connection = conexion; //Le asigno al comando la conexion sobre la cual va a trabajar.
            conexion.Open(); //Abro la Conexion
            SqlDataReader lector = comando.ExecuteReader(); //Objeto que lee linea por linea la base de datos
            while(lector.Read()) //Leo una linea y se le asigna al objeto lector
            {
                //Televisor televisor = new Televisor((int)lector["codigo"], (string)lector["marca"], (float)lector["precio"], (int)lector["pulgadas"], (string)lector["pais"]);
                Televisor televisor = new Televisor(lector.GetInt32(0), lector.GetString(1), lector.GetDouble(2), lector.GetInt32(3), lector.GetString(4)); //Leo la base de datos
                listaTelevisores.Add(televisor);
                Console.WriteLine("{0}-{1}-{2}-{3}-{4}",lector["codigo"], lector["marca"], lector["precio"], lector["pulgadas"], lector["pais"]);
            }
            conexion.Close(); //Cierro la conexion al server
            #endregion

            #region XML
            //Serializo la lista de teles en un XML.
            XmlSerializer serializer = new XmlSerializer(typeof(List<Televisor>));
            XmlTextWriter writer = new XmlTextWriter("Televisores.xml", Encoding.UTF8);
            XmlTextReader reader = new XmlTextReader("Televisores.xml");

            serializer.Serialize(writer, listaTelevisores);
            writer.Close();
            List<Televisor> listaDeserializada = (List<Televisor>)serializer.Deserialize(reader);
            reader.Close();
            #endregion

            #region DataTable
            conexion.Open();
            lector = comando.ExecuteReader();
            DataTable dataTable = new DataTable("Televisores"); //Creo una nueva datatable
            dataTable.Load(lector); //Cargo los datos de la base de datos en el DataTable. Recibe un ejercicio SqlDataReader.
            conexion.Close();

            dataTable.WriteXmlSchema("Televisores_esquema.xml"); //Serializo la estructura del datatable en un xml.
            dataTable.WriteXml("Televisores_dt.xml"); //Serializo los datos de un xml en el datatable

            DataTable dataTableRead = new DataTable();
            dataTableRead.ReadXmlSchema("Televisores_esquema.xml"); 
            dataTableRead.ReadXml("Televisores_dt.xml");

            //Agrego tele a la DataTable
            Televisor televisorAgregar = new Televisor(1245, "Samsung", 15000, 32, "Japon");
            Console.WriteLine(televisorAgregar.Insertar());
            #endregion
            Console.ReadKey();
        }
    }
}
