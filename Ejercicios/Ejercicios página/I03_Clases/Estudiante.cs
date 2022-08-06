using System;
using System.Text;

namespace I03_Clases
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            if(nota >=0 && nota <=10)
            {
                this.notaPrimerParcial = nota;
            }
        }
        
        public void SetNotaSegundoParcial(int nota)
        {
            if(nota >=0 && nota <=10)
            {
                this.notaSegundoParcial = nota;
            }
        }

        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal()
        {
            double notaFinal = -1;

            if(this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6, 10);
            }

            return notaFinal;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("****ALUMNO****");
            sb.AppendLine($"Nombre y apellido: {this.nombre} {this.apellido}");
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Nota 1er parcial: {this.notaPrimerParcial}");
            sb.AppendLine($"Nota 2do parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {this.CalcularPromedio()}");
            sb.Append($"Nota final: ");
            if(this.CalcularNotaFinal() == -1)
            {
                sb.AppendLine("Alumno desaprobado");
            }
            else
            {
                sb.AppendLine(this.CalcularNotaFinal().ToString());
            }

            return sb.ToString();
        }
    }
}
