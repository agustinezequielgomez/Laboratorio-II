using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQL
{
    class Sql<T> : ISql<T>
    {
        public bool Borrar(T obj)
        {
            bool retorno = true;
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("DELETE // WHERE codigo = {0}"); //
            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception)
            {
                retorno = false;
            }
            return retorno;
        }

        public bool Insertar()
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("INSERT INTO // values({0},'{1}',{2},{3},'{4}')"); //
            command.Connection = conexion;
            try
            {
                conexion.Open();
                command.ExecuteNonQuery(); 
                conexion.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Modificar(T obj)
        {
            bool retorno = true;
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("UPDATE // SET // WHERE codigo = {4}"); //
            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                retorno = false;
            }
            return retorno;
        }

        public List<T> TraerTodos()
        {
            List<T> lista = new List<T>();
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM //";//
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                T obj = new T(); //
                lista.Add(televisor);//
            }
            connection.Close();
            return lista;
        }

        public T TraerUno(int id)
        {
            T retorno = null;
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("SELECT * FROM // WHERE // = {0}", id); //
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                retorno = new T();//
            }
            connection.Close();
            return retorno;
        }
    }
}
