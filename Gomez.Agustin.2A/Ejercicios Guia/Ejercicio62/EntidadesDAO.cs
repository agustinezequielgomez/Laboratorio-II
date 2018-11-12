using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejercicio62
{
    class EntidadesDAO
    {
        public static void CrearTabla()
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("CREATE TABLE Llamadas(ID int IDENTITY (1,1) NOT NULL, Duracion float NOT NULL, Origen varchar(50) NOT NULL, Destino varchar(50) NOT NULL, Costo float NOT NULL, Tipo bit NOT NULL, PRIMARY KEY (ID));");
            command.Connection = conexion;
            try
            {
                conexion.Open();
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception e)
            {

            }
        }
    }

    class LocalDAO
    {
        public static void Guardar(Local local)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("INSERT INTO Llamadas values ({0},'{1}','{2}',{3},{4})", local.Duracion, local.NroOrigen, local.NroDestino, local.CostoLlamada, 0);
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

        public static Local Leer(int duracion, int tipo, string origen, string destino)
        {
            Local retorno= null;
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("SELECT * FROM Llamadas WHERE Duracion = {0} and Tipo = {1} and Origen = '{2}' and Destino = '{3}'", duracion, tipo, origen, destino);
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
            {
                reader.Read();
                retorno = new Local(reader.GetString(2), (float)reader.GetDouble(1), reader.GetString(3), (float)reader.GetDouble(4));
            }
            connection.Close();
            return retorno;
        }
    }

    class ProvincialDAO
    {
        public static void Guardar(Provincial provincial)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("INSERT INTO Llamadas values ({0},'{1}','{2}',{3},{4})", (double)provincial.Duracion, provincial.NroOrigen, provincial.NroDestino, (double)provincial.CostoLlamada, 1);
            command.Connection = connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {

            }
        }

        public static Provincial Leer(float duracion, int tipo, string origen, string destino)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("SELECT * FROM Llamadas WHERE Duracion = {0} and Tipo = {1} and Origen = '{2}' and Destino = '{3}'", duracion, tipo, origen, destino);
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            Provincial retorno = new Provincial(reader.GetString(2), Provincial.Franja.Franja_3, (float)reader.GetDouble(1), reader.GetString(3));
            connection.Close();
            return retorno;
        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   