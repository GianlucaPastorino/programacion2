using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02_Contador
{
    public static class IntExtension
    {
        public static int ContarCantidadDeDigitos(this Int64 numero)
        {
            string numeroString = numero.ToString();
            numeroString = numeroString.Replace("-", "");

            return numeroString.Length;
        }
    }
}
