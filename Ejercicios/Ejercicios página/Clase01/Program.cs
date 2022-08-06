/*
Consigna
Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
*/

using System;

namespace I01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int mayor = int.MinValue;
            int menor = int.MaxValue;
            float acumulador = 0;
            float promedio;

            while (i < 6)
            {
                Console.Write("{0}- Ingrese un número: ", i);

                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    acumulador += numero;
                    if (numero < menor)
                    {
                        menor = numero;
                    }

                    if (numero > mayor)
                    {
                        mayor = numero;
                    }

                    i++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR!");
                    Console.ResetColor();
                }
            }

            promedio = acumulador / 5;

            Console.WriteLine();
            Console.WriteLine("Menor: " + menor);
            Console.WriteLine("Mayor: " + mayor);
            Console.WriteLine("Promedio: " + promedio);
        }
    }
}
