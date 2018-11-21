using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class Extensora
    {
        #region Metodos
        public static string ObtenerDatos(this Externa.Sellada.PersonaExternaSellada persona)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nNombre: {0}\n", persona.Nombre);
            sb.AppendFormat("Apellido: {0}\n", persona.Apellido);
            sb.AppendFormat("Edad: {0}\n", persona.Edad);
            sb.AppendFormat("Sexo: {0}\n", persona.Sexo);
            return sb.ToString();
        }

        public static bool EsNulo(this object obj)
        {
            return (obj is null);
        }

        public static Int32 CantidadDigitos(this Int32 num)
        {
            return (Convert.ToString(num).Length);
        }

        public static bool TieneLaMismaCantidad(this Int32 num1, Int32 num2)
        {
            return (num1.CantidadDigitos() == num2);
        }

        public static List<Persona> TraerDB(this Persona Persona)
        {
            List<Persona> lista = new List<Persona>();
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM Personas";
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Persona persona = new Persona(reader.GetString(1), reader.GetString(2), reader.GetInt32(3), (ESexo)reader.GetInt32(4));
                lista.Add(persona);
            }
            connection.Close();
            return lista;
        }

        public static bool AgregarDB(this Persona persona)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("INSERT INTO Personas values('{0}','{1}',{2},{3})", persona.Nombre,persona.Apellido,persona.Edad,(int)persona.Sexo);
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

        public static bool QuitarDB(this Persona persona, int id)
        {
            bool retorno = true;
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("DELETE Personas WHERE id = {0}", id);
            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool ModificarDB(this Persona persona, int id)
        {
            bool retorno = true;
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("UPDATE Personas SET nombre = '{0}', apellido = '{1}', edad = {2}, sexo = {3} WHERE id = {4}", persona.Nombre,persona.Apellido,persona.Edad,(int)persona.Sexo,id);
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
        #endregion
    }
}