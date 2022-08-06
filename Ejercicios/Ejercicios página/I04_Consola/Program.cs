// Consigna: https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/objetos/Ejercicios/I04-invento-argentino/

using System;
using I04_Clases;

namespace I04_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boliAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boliRojo = new Boligrafo(50, ConsoleColor.Red);
            string dibujo;

            Console.ForegroundColor = ConsoleColor.Blue;
            boliAzul.Pintar(-10, out dibujo);           
            Console.WriteLine(dibujo); // Debe pintar 10 *
            Console.ResetColor();
            
            Console.WriteLine($"Tinta boli azul: {boliAzul.GetTinta()}"); // 90
            Console.WriteLine("RECARGO BOLI AZUL");
            boliAzul.Recargar();
            Console.WriteLine($"Tinta boli azul: {boliAzul.GetTinta()}"); // 100
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            boliRojo.Pintar(-25, out dibujo); 
            Console.WriteLine(dibujo); //Debe pintar 25 *
            boliRojo.Pintar(-50, out dibujo); 
            Console.WriteLine(dibujo); //Debe pintar 25 *
            boliRojo.Pintar(-10, out dibujo);
            Console.WriteLine(dibujo); //Debe pintar 0 *
            Console.ResetColor();
           
            Console.WriteLine($"Tinta boli rojo: {boliRojo.GetTinta()}"); // 0
            Console.WriteLine("RECARGO BOLI ROJO");
            boliRojo.Recargar();
            Console.WriteLine($"Tinta boli rojo: {boliRojo.GetTinta()}"); // 100
        }
    }
}
