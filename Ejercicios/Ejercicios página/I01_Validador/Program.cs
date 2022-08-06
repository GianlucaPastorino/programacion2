/*
Consigna
Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

bool Validar(int valor, int min, int max)

valor: dato a validar.
min: mínimo valor incluido.
max: máximo valor incluido.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
 */

using System;

namespace I01_Validador
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros = 1;
            int numeroIngresado;
            int menor = int.MaxValue;
            int mayor = int.MinValue;
            int acumulador = 0;
            double promedio;

            while(numeros <= 10)
            {
                Console.Write($"{numeros : 00}- Ingrese un número entero (entre -100 y 100): ");

                while(!int.TryParse(Console.ReadLine(), out numeroIngresado) || !Validador.Validar(numeroIngresado, -100, 100))
                {
                    Console.Write($"{numeros : 00}- Error. Reingrese número: ");
                }

                if(numeroIngresado < menor)
                {
                    menor = numeroIngresado;
                }

                if(numeroIngresado > mayor)
                {
                    mayor = numeroIngresado;
                }

                numeros++;
                acumulador += numeroIngresado;
            }

            promedio = acumulador / 10;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine($"Valor mínimo ingresado: {menor}");
            Console.WriteLine($"Valor máximo ingresado: {mayor}");
            Console.WriteLine($"Promedio: {promedio}");

            Console.ResetColor();
        }
    }
}
