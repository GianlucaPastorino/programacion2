/*
Consigna
Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática.
El método devolverá el resultado de la operación.

Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
Este método devolverá true si el operando es distinto de cero.

Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

El usuario decidirá cuándo finalizar el programa.
 */

using System;

namespace I04_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string operador;
            decimal primerOperando;
            decimal segundoOperando;
            string continuar = "si";

            while(continuar == "si")
            {
                Console.Clear();

                Console.Write("Ingrese el primer operando: ");
                while(!decimal.TryParse(Console.ReadLine(), out primerOperando))
                {
                    Console.Write("Error. Ingrese el primer operando: "); 
                }

                Console.WriteLine();
                Console.Write("Ingrese el segundo operando: ");
                while (!decimal.TryParse(Console.ReadLine(), out segundoOperando))
                {
                    Console.Write("Error. Ingrese el segundo operando: ");
                }

                Console.WriteLine();
                Console.Write("Ingrese el operador (+, -, * o /): ");
                operador = Console.ReadLine();
                while(operador != "+" && operador != "-" && operador != "*" && operador != "/")
                {
                    Console.Write("Error. Ingrese un operador válido: ");
                    operador = Console.ReadLine();
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"El resultado de su operación es: {Calculadora.Calcular(primerOperando, segundoOperando, operador)}");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("Escriba \"si\" para seguir operando: ");
                continuar = Console.ReadLine();
            }    
        }
    }
}
