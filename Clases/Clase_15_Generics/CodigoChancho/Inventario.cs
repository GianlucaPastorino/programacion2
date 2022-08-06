using System;
using System.Collections.Generic;

namespace Codigo
{
    public class Inventario<T, U>
    where T : class // Restricciones: Me permite limitar el tipo de dato a recibir. Class es tipo referencia.
    // Where U : struct // struct es tipo valor. VER EN LA DIAPO MÁS TIPOS DE RESTRICCIONES.
    where U : MedioTransporte
    {
        List<T> lista;
        List<U> listaMedioTransporte;

        public void Ejemplito()
        {
            foreach (U item in listaMedioTransporte)
            {
                item.nombre = ""; // Me deja acceder a nombre porque se asume que
                                  // item va a ser un medio de transporte porque lo restrinjo con el where.
                item.MostrarNumeroChasis();
            }
        }
    }
}
