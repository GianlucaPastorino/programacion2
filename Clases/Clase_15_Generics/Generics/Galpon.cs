using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Galpon<T> // Galpón de tipo T (del tipo que le pase)
    {
        int idGondola;
        int cantidadEstante;
        string sector;
        List<T> listaDeElementos;

        private Galpon()
        {
            listaDeElementos = new List<T>();
        }

        public Galpon(int idGondola, int cantidadEstante, string sector) : this()
        {
            this.idGondola = idGondola;
            this.cantidadEstante = cantidadEstante;
            this.sector = sector;
        }

        public int CantidadElementos
        {
            get { return listaDeElementos.Count; }
        }

        public T PrimerElemento() // Va a devolver algo del tipo que reciba la clase
        {
            return listaDeElementos[0];
        }

        public bool GuardarObjeto(T objetoAGuardar)
        {
            return true;
        }
    }
}
