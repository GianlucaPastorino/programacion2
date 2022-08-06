using System;
using Codigo;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        { 
            Galpon<string> galponPalabras = new Galpon<string>(1, 2, "A");

            Galpon<Juguete> jugueteria = new Galpon<Juguete>(1, 2, "D");

            Galpon<Lacteo> lacteo = new Galpon<Lacteo>(3, 2, "AA");

            Galpon<Avion> hangar = new Galpon<Avion>(5, 2, "asd");

            hangar.PrimerElemento(); // Devuelve algo de tipo Avión
            lacteo.PrimerElemento(); // Devuelve algo de tipo Lacteo

            galponPalabras.GuardarObjeto("Pepe"); // Me pide recibir un string
            jugueteria.GuardarObjeto(new Juguete()); // Me pide recibir un juguete
        }
    }
}
