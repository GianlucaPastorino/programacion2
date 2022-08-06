using System;

namespace I02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.Write("Ingrese un número: ");
            while(!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
            {
                Console.Write("Error. Reingresar número: ");
            }

            Console.WriteLine();
            Console.WriteLine("Cuadrado: " + Math.Pow(numero, 2));
            Console.WriteLine("Cubo: " + Math.Pow(numero, 3));
        }
    }
}
