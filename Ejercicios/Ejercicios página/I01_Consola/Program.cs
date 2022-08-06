// Consigna: https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/sobrecarga/Ejercicios/I01-sumador/

using System;
using I01_Biblio;

namespace I01_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumador1 = new Sumador(5);

            Console.WriteLine(sumador.Sumar(15, 42));
            Console.WriteLine(sumador.Sumar("Hola ", "Manola"));

            Console.WriteLine($"Cantidad de sumas sumador1: {(int)sumador1}");

            long cantidadSumas = sumador + sumador1;
            Console.WriteLine($"Cantidad sumas totales: {cantidadSumas}");

            Console.WriteLine(sumador | sumador1);
        }
    }
}
