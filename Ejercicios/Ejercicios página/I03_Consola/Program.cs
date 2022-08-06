//Consigna: https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/objetos/Ejercicios/I03-el-ejemplo-universal/

using System;
using I03_Clases;

namespace I03_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Juan", "Perez", "25856");
            Estudiante e2 = new Estudiante("Carlos", "Baute", "456123");
            Estudiante e3 = new Estudiante("Mariano", "Martinez", "97260");

            e1.SetNotaPrimerParcial(7);
            e1.SetNotaSegundoParcial(9);

            e2.SetNotaPrimerParcial(6);
            e2.SetNotaSegundoParcial(8);

            e3.SetNotaPrimerParcial(6);
            e3.SetNotaSegundoParcial(2);

            Console.WriteLine(e1.Mostrar());
            Console.WriteLine(e2.Mostrar());
            Console.WriteLine(e3.Mostrar());
        }
    }
}
