using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 }

        protected Franja franjaHoraria;

        public float CostoLlamada { get => this.CalcularCosto(); }

        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : this(miFranja, new Llamada(duracion, destino, origen))
        {

        }

        public new string Mostrar() // El new en este caso se usa para "ocultar" el Mostrar de la clase Llamada.
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: {CostoLlamada}");
            sb.AppendLine($"Franja horaria: {franjaHoraria}");

            return sb.ToString();
        } 

        private float CalcularCosto()
        {
            float costo = 0;

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = duracion * 0.99f;
                    break;
                case Franja.Franja_2:
                    costo = duracion * 1.25f;
                    break;
                case Franja.Franja_3:
                    costo = duracion * 0.66f;
                    break;
            }

            return costo;
        }
    }
}
