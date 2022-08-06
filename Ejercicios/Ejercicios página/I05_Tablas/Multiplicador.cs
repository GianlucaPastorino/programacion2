using System.Text;

namespace I05_Tablas
{
    static class Multiplicador
    {
        public static string MultiplicarNumero(int numero)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tabla de multiplicar del número {numero}:");

            for (int i = 1; i <= 9; i++)
            {
                sb.AppendLine($"{numero} x {i} = {numero * i}");
            }

            return sb.ToString();
        }    
    }
}
