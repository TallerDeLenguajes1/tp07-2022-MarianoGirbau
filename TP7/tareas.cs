using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7
{
    internal class tarea
    {
        public int tareaID;//autoincremental

        public string? descripcion;

        public int duracion;//entre 10 y 100

        public void mostrarTareas()
        {
            Console.WriteLine("\n ID de la tarea: " + tareaID.ToString());
            Console.WriteLine("\n Descripcion de la tarea: " + descripcion);
            Console.WriteLine("\n Duracion de la tarea:" + duracion.ToString());

        }
    }
}
