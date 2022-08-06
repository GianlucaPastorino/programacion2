using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01_Cartuchera
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            ((IAcciones)this).UnidadesDeEscritura = unidades;
        }

        ConsoleColor IAcciones.Color
        {
            get => ConsoleColor.Gray;
            set => throw new NotImplementedException();
        }

        float IAcciones.UnidadesDeEscritura
        {
            get => this.tamanioMina;
            set => this.tamanioMina = value;
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            ((IAcciones)this).UnidadesDeEscritura -= 0.1f * texto.Length;
            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Lápiz {((IAcciones)this).Color}, {((IAcciones)this).UnidadesDeEscritura}");
            return sb.ToString();
        }
    }
}
