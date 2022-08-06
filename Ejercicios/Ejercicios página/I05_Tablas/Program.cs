/*
Consigna
Crear una aplicación de consola que permita al usuario ingresar un número entero.

Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.

Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.

Mostrar en la consola el resultado.
 */

using System;

namespace I05_Tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string continuar = "si";

            while (continuar == "si")
            {
                Console.Clear();

                Console.Write("Ingrese un número entero: ");

                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("Error. Reingrese un número entero: ");
                }

                Console.WriteLine();
                Console.WriteLine(Multiplicador.MultiplicarNumero(numero));

                Console.Write("Escriba \"si\" para ingresar otro número: ");
                continuar = Console.ReadLine();
            }
        }
    }
}
