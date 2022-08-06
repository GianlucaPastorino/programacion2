using System;
using System.Threading.Tasks;
using System.Threading;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Task tarea1 = new Task(() =>
                                     {
                                         Thread.Sleep(3000); // Espera 3 segundos
                                         Console.WriteLine("Primera tarea");

                                     }
              ); // "Preparo" la task para ser ejecutada. Le pasé un delegado.     

            tarea1.Start(); // Ejecuto la task

            Console.WriteLine("Segunda tarea");

            Console.WriteLine("Tercera tarea");

            Thread.Sleep(5000); // Hago este sleep para que llegue a mostrarse la primera tarea,
                                // si no lo hago, no aparecería porque no le doy tiempo a que pasen los 3 segundos
        }

        // Primero va a aparecer la segunda, después la tercera y después la primera (por el sleep de 3 segundos).

    }
}
