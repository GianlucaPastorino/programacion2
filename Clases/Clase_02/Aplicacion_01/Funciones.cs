using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_01
{
    public static class Funciones //No se puede instanciar.
    {
        /// <summary>
        /// DESCRIPCIÓN DEL METODO
        /// </summary>
        /// <returns>Descripción de que devuelve</returns>
        public static string NombreApp()
        {
            return "UNIVERSIDAD TECNOLOGICA NACIONAL";     
        }

        public static int CantidadAlumnos(string division)
        {
            if (division == "A")
            {
                return 10;
            }
            else if (division == "B")
            {
                return 20;
            }
            else
            {
                return 500;
            }
        }
    }
}
