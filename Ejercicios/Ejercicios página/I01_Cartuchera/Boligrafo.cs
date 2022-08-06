using System;
using System.Text;

namespace I01_Cartuchera
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            this.tinta = unidades;
        }

        public ConsoleColor Color
        {
            get => colorTinta;
            set => colorTinta = value;
        }

        public float UnidadesDeEscritura
        {
            get => tinta;
            set => tinta = value;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            this.UnidadesDeEscritura -= 0.3f * texto.Length;
            return new EscrituraWrapper(texto, Color);
        }

        public bool Recargar(int unidades)
        {
            if (unidades > 0)
            {
                this.UnidadesDeEscritura += unidades;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Boligrafo {Color}, {UnidadesDeEscritura}");
            return sb.ToString();
        }
    }
}
