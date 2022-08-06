/*
Consigna
Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.
El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15.
El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
*/

using System;

namespace I05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int auxNumero = 1;
            bool hayCentros = false;
            
            Console.Title = "Ejercicio 05 - Tirame un centro";
            Console.WriteLine("Ingrese un número:");

            while(!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Error. Ingrese un número:");
            }

            Console.WriteLine("\nCentros numéricos:");

            while(auxNumero <= numero)
            {
                for (int i = 2; i <= auxNumero; i++)
                {
                    int acumulador1 = 0;
                    int acumulador2 = 0;

                    for (int j = 1; j < i; j++)
                    {
                        acumulador1 += j;
                    }

                    for (int k = auxNumero; k > i; k--)
                    {
                        acumulador2 += k;
                    }

                    if (acumulador1 == acumulador2)
                    {
                        Console.WriteLine(i);
                        hayCentros = true;
                    }
                }

                auxNumero++;
            }
            
            if(!hayCentros)
            {
                Console.WriteLine("No se encontró ningún centro numérico.");
            }
        }
    }
}
