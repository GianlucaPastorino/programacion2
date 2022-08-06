/*
Consigna
Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.
El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
Escribir una aplicación que encuentre los 4 primeros números perfectos.
 */

using System;

namespace I04
{
    class Program
    {
        static void Main(string[] args)
        {
            int perfectos = 0;
            int acumulador = 0;

            Console.WriteLine("Los primeros 4 números perfectos son: ");

            for (int i = 1; perfectos < 4; i++)
            {
                for (int j = i-1; j > 0; j--)
                {
                    if (i % j == 0)
                    {
                        acumulador += j;
                    }
                }

                if (acumulador == i)
                {
                    Console.WriteLine(acumulador);
                    perfectos++;
                }

                acumulador = 0;
            }

        }
    }
}
