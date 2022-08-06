using System;
using System.Text;

namespace CentralTelefonica
{
    public class Llamada
    {
        public enum TipoLlamada { Local, Provincial, Todas }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen; 

        public float Duracion
        { 
            get { return this.duracion; }
        }
        public string NroDestino
        {
            get { return this.nroDestino; }
        }
        public string NroOrigen
        {
            get { return this.nroOrigen; } 
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return (int)(llamada1.duracion - llamada2.duracion);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Número de origen: {nroOrigen}");
            sb.AppendLine($"Número de destino: {nroDestino}");
            sb.AppendLine($"Duración: {duracion}");

            return sb.ToString();
        }
    }
}
