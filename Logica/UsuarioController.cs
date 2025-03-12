using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Entities;

namespace Logica
{
    public class UsuarioController
    {
        public string GuardarLibro(string name, string referencia)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarLibro(name, referencia);

            if (filasInsertadas > 0)
            {
                resultado = "Guardado";
            }
            else
            {
                resultado = "No Guardado";
            }
            return resultado;
        }

        public LibroEntity MostrarLibro()
        {
            BaseDatos db = new BaseDatos();
            LibroEntity LibroActual = db.MostrarLibro();
            return LibroActual;

        }
    }
}
