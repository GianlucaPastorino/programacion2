using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_07
{
    internal class GestorDatos
    {


        public static string TraerRegistros()
        {
            
            return "La cantidad de registros es 2000";
        }

        // El método va a ser async porque como mi hilo principal tiene que esperar algo de otro hilo (con un await),
        // voy a necesitar sí o sí un async para que mi hilo principal pueda seguir corriendo el programa y no se cuelgue todo mientras espera
        // la devolución del otro hilo.
        // Va a ejecutar una task (la que voy a tener que awaitear), y en los <> va el tipo de retorno del método.
        // Es decir, me va a permitir que el thread principal siga corriendo aunque se esté ejecutando este método.
        public static async Task<string> TraerRegistros2Async() // t0
        {
            //t0
            string informacion = await Task.Run(() =>
                                            {
                                                Thread.Sleep(10000); // SIMULO QUE VA A LA BASE
                                            return "La cantidad de registros es 2000";
                                            });
             
            // await sería como "Aguantame que esta task me devuelva algo para continuar con la ejecución de ÉSTE método".

            if(informacion.Length < 0)
            {
                throw new Exception("info vacia");
            }

            return informacion;
        }

    }
}
