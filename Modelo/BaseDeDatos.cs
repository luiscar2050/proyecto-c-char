using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class BaseDatos : ConexionMySql
    {

        public int GuardarLibro(string name, string referencia)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO libro (nombre,referencia) VALUES ('" + name + "','" + referencia + "')";
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public LibroEntity MostrarLibro()
        {
            LibroEntity LibroActual = new LibroEntity();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "select * from libro ";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                LibroActual.Id = reader.GetInt32(0);
                LibroActual.Name = reader.GetString(1);
                LibroActual.Referencia = reader.GetString(2);
            }

            return LibroActual;

        }

    }
}
