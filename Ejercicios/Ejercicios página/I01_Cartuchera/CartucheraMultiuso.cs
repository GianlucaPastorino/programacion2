using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01_Cartuchera
{
    class CartucheraMultiuso
    {
        List<IAcciones> cartuchera;

        public bool RecorrerElementos()
        {
            foreach(IAcciones item in cartuchera)
            {
                item.UnidadesDeEscritura -= 1;
            }
            return true;
        }
    }
}
