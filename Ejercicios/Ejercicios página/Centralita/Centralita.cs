using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            razonSocial = nombreEmpresa;
        }

        public float GananciasPorLocal { get => CalcularGanancia(Llamada.TipoLlamada.Local); }
        public float GananciasPorProvincial { get => CalcularGanancia(Llamada.TipoLlamada.Provincial); }
        public float GananciasPorTotal { get => CalcularGanancia(Llamada.TipoLlamada.Todas); }
        public List<Llamada> Llamadas { get => listaDeLlamadas; }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0;

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    foreach (Local llamada in listaDeLlamadas)
                    {
                        ganancia += llamada.CostoLlamada;
                    }
                    break;
                case Llamada.TipoLlamada.Provincial:
                    foreach (Provincial llamada in listaDeLlamadas)
                    {
                        ganancia += llamada.CostoLlamada;
                    }
                    break;
                case Llamada.TipoLlamada.Todas: // Repito mucho código, horrible.
                    foreach (Local llamada in listaDeLlamadas)
                    {
                        ganancia += llamada.CostoLlamada;
                    }
                    foreach (Provincial llamada in listaDeLlamadas)
                    {
                        ganancia += llamada.CostoLlamada;
                    }
                    break;
            }

            return ganancia;
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion); //Paso la referencia
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razón social: {razonSocial}");
            sb.AppendLine($"Ganancia llamadas locales: {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancia llamadas provinciales: {this.GananciasPorProvincial}");
            sb.AppendLine($"Ganancia llamadas totales: {this.GananciasPorTotal}");
            sb.AppendLine("Lista de llamadas:");
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                if(llamada is Local llamadaLocal)
                {
                    sb.AppendLine(llamadaLocal.Mostrar());
                }
                else if(llamada is Provincial llamadaProvincial)
                {
                    sb.AppendLine(llamadaProvincial.Mostrar());
                }
            }

            return sb.ToString();
        }
    }
}
