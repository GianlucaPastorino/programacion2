/*
Consigna
Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
Validar que el dato ingresado por el usuario sea un número.
Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
Si ingresa "salir", cerrar la consola.
Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
*/

using System;

namespace I03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I03 - Los primos";
            
            int numero = 0;
            string cadNumero = "";
            string respuesta = "si";
            bool esPrimo = true;
            bool hayPrimos = false;

            do
            {
                Console.Write("Ingrese un número o escriba 'salir' para finalizar el programa: ");
                cadNumero = Console.ReadLine();

                while(!int.TryParse(cadNumero, out numero) && cadNumero != "salir")
                {
                    Console.Write("Error. Ingrese un número o escriba 'salir' para finalizar el programa: ");
                    cadNumero = Console.ReadLine();
                }

                if (cadNumero == "salir")
                {
                    Environment.Exit(0);
                }

                Console.WriteLine($"\nNumeros primos hasta el {numero}:");

                for (int i = 2; i <= numero; i++)
                {
                    esPrimo = true;

                    for (int j = 2; j<i; j++)
                    {
                        if(i%j==0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }

                    if(esPrimo)
                    {
                        Console.WriteLine(i);
                        hayPrimos = true;
                    }
                }

                if(!hayPrimos)
                {
                    Console.WriteLine("No se encontraron números primos.");
                }

                Console.WriteLine("");
                Console.Write("Escriba 'si' si desea volver a operar: ");
                respuesta = Console.ReadLine();

            } while (respuesta == "si");
        }
    }
}
