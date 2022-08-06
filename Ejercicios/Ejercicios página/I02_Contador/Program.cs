using System;

namespace I02_Contador
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ingrese un número: ");
                string strNumero = Console.ReadLine();

                if(Int64.TryParse(strNumero, out Int64 numero))
                {

                    Console.WriteLine("Numero de {0,10} dígitos", numero.ContarCantidadDeDigitos());
                }
                else
                {
                    Console.WriteLine("Valor inválido.");
                }
            }
        }
    }
}
