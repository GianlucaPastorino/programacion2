using System;
using Logica;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            if(Sistema.CheckearUsuario("Pepe", "asd123"))
            {
                Console.WriteLine("Logueado");
            }
            else
            {
                Console.WriteLine("Sin acceso");
            }
        }
    }
}
