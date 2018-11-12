using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejercicio61
{
    class PersonaDAO
    {
        public static void CrearTabla()
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("CREATE TABLE Persona(ID int IDENTITY (1,1) NOT NULL, Nombre varchar(50) NOT NULL, Apellido varchar(50) NOT NULL, PRIMARY KEY (ID));");
            command.Connection = conexion;
            try
            {
                conexion.Open();
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch(Exception e)
            {

            }
        }

        public static void Guardar(Persona persona)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("INSERT INTO Persona values('{0}','{1}')", persona.nombre, persona.apellido);
            command.Connection = conexion;
            try
            {
                conexion.Open();
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch(Exception e)
            {

            }
        }

        public static List<Persona> Leer()
        {
            List<Persona> lista = new List<Persona>();
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM Persona";
            command.Connection = conexion;
            conexion.Open();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Persona persona = new Persona(reader.GetString(1), reader.GetString(2), reader.GetInt32(0));
                lista.Add(persona);
            }
            conexion.Close();
            return lista;
        }

        public static Persona LeerPorID(Persona persona)
        {
            Persona retorno;
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("SELECT * FROM Persona WHERE ID ={0}", persona.id);
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            retorno = new Persona(reader.GetString(1), reader.GetString(2), reader.GetInt32(0));
            connection.Close();
            return retorno;
        }

        public static void Modificar(Persona persona)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("UPDATE Persona SET Nombre = '{0}', Apellido = '{1}' WHERE ID = {2}", persona.nombre, persona.apellido, persona.id);
            command.Connection = conexion;
            try
            {
                conexion.Open();
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch(Exception e)
            {

            }
        }

        public static void Borrar(Persona persona)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("DELETE Persona WHERE ID = {0}", persona.id);
            command.Connection = connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception e)
            {

            }
        }
    }
}
