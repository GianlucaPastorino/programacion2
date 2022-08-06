/*
Consigna
Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:

public double CalcularAreaCuadrado(double longitudLado) {}

public double CalcularAreaTriangulo(double base, double altura) {}

public double CalcularAreaCirculo(double radio) {}

El ingreso de los datos como la visualización se deberán realizar desde el método Main().
*/
using System;

namespace I06_CalculadoraAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Área de un cuadrado de lado 5: " + CalculadoraDeArea.CalcularAreaCuadrado(5));
            Console.WriteLine("Área de un triangulo de base 3 y altura 4: " + CalculadoraDeArea.CalcularAreaTriangulo(3, 4));
            Console.WriteLine("Área de un circulo de radio 7: " + CalculadoraDeArea.CalcularAreaCirculo(7));
        }
    }
}
