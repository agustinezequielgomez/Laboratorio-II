using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public delegate void MiDelegado();
    public delegate void DelegadoTV(Televisor televisor, TVEventArgs args);
    public class Televisor
    {
        #region Atributos
        public int id;
        public string marca;
        public double precio;
        public int pulgadas;
        public string pais;
        public event MiDelegado MiEvento;
        public event DelegadoTV EventoTV;
        #endregion

        #region Constructor
        public Televisor()
        {

        }

        public Televisor(int id, string marca, double precio, int pulgadas, string pais)
        {
            this.id = id;
            this.marca = marca;
            this.precio = precio;
            this.pulgadas = pulgadas;
            this.pais = pais;
        }
        #endregion

        #region Metodos
        public bool Insertar()
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("INSERT INTO Televisores values({0},'{1}',{2},{3},'{4}')", this.id, this.marca, this.precio, this.pulgadas, this.pais);
            command.Connection = conexion;
            //string cadena = "INSERT INTO Televisores values("+this.id+",'"+this.marca+"',"+this.precio+","+this.pulgadas+",'"+this.pais+"')";

            //command.CommandText = cadena;
            try
            {
                conexion.Open();
                command.ExecuteNonQuery(); //Ejecuto consultas que no retornan resultado
                conexion.Close();
                //Eventos
                this.MiEvento();
                this.EventoTV(this,new TVEventArgs());
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool Modificar(Televisor televisor)
        {
            bool retorno = true;
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("UPDATE Televisores SET marca = '{0}', precio = {1}, pulgadas = {2}, pais = '{3}' WHERE codigo = {4}", televisor.marca, televisor.precio, televisor.pulgadas, televisor.pais,televisor.id);
            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception e)
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool Borrar(Televisor televisor)
        {
            bool retorno = true;
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("DELETE Televisores WHERE codigo = {0}", televisor.id);
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

        public static List<Televisor> TraerTodos()
        {
            List<Televisor> lista = new List<Televisor>();
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM TELEVISORES";
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Televisor televisor = new Televisor(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3), reader.GetString(4));
                lista.Add(televisor);
            }
            connection.Close();
            return lista;
        }

        public static Televisor TraerUno(int id)
        {
            Televisor retorno = null;
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("SELECT * FROM Televisores WHERE codigo = {0}", id);
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
            {
                reader.Read();
                retorno = new Televisor(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3), reader.GetString(4));
            }
            connection.Close();
            return retorno;
        }
        #endregion
    }
}
