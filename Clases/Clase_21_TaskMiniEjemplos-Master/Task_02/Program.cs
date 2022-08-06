using System;
using System.Threading.Tasks;
using System.Threading;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Task tarea1 = Task.Run(Tarea01); // No hace falta poner el ".Start()" porque con el ".Run(DelegadoMetodo)" instancio y ejecuto a la vez.
            Task tarea2 = Task.Run(Tarea02);
            Task tarea3 = Task.Run(Tarea03); 

            Thread.Sleep(10000);
        }

        // Tercero
        public static void Tarea01()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Tarea 1");

        }

        // Primero
        public static void Tarea02()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Tarea 2");

        }

        // Segundo
        public static void Tarea03()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Tarea 3");
        }
    }



}
