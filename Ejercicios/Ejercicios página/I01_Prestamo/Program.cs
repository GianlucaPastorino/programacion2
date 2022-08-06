using System;
using I01_Entidades;

namespace I01_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("Carlos SRL", 50000);

            Console.WriteLine(cuenta.Mostrar());
            cuenta.Ingresar(20000);
            Console.WriteLine(cuenta.Mostrar());
            cuenta.Retirar(12500);
            Console.WriteLine(cuenta.Mostrar());
        }
    }
}
