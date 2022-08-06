using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    sealed class Profesor : Persona
    {
        private string catedra;
        public Profesor(string nombre, string apellido, long dni, string catedra) : base(nombre, apellido, dni)
        {
        }

        public string Catedra { get => catedra; set => catedra = value; }
    }
}
