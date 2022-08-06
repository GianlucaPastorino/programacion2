using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Local : Llamada
    {
        protected float costo;

        public float CostoLlamada { get => this.CalcularCosto(); }

        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo) : this(new Llamada(duracion, destino, origen), costo)
        {
        }

        private float CalcularCosto()
        {
            return this.duracion * this.costo;
        }

        public new string Mostrar() // El new en este caso se usa para "ocultar" el Mostrar de la clase Llamada. 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo por minuto: ${costo}");
            sb.AppendLine($"Costo de llamada: ${this.CostoLlamada}");

            return sb.ToString();
        }
    }
}
