/*
Consigna
Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.

El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y

Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

Mostrar el resultado en la consola.
*/
using System;

namespace I07_Pitagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseTriangulo;
            double alturaTriangulo;

            Console.Write("Ingrese medida de la base de un triángulo (cm): ");
            while (!double.TryParse(Console.ReadLine(), out baseTriangulo))
            {
                Console.Write("Error. Reingrese medida: ");
            }

            Console.Write("Ingrese medida de la altura de un triángulo (cm): ");
            while (!double.TryParse(Console.ReadLine(), out alturaTriangulo))
            {
                Console.Write("Error. Reingrese medida: ");
            }

            Console.WriteLine();
            Console.WriteLine($"La hipotenusa del tríangulo es: {CalcularHipotenusa(baseTriangulo, alturaTriangulo)} cm");
        }

        static double CalcularHipotenusa(double baseTriangulo, double alturaTriangulo)
        {
            return Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));   
        }
    }
}
