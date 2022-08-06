using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Estudiante : Persona
    {
        public int legajo;
        public List<string> materias;

        public Estudiante(string nombre, string apellido, long dni, int legajo) : base(nombre, apellido, dni)
        {
            this.legajo = legajo;
            materias = new List<string>();
        }

        public string Estudiar()
        {
            return "Estoy estudiando...";
        }
    }
}
