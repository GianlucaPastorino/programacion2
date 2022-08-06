using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class Gato
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private double peso;

        //Constructor
        public Gato(string nombre, DateTime fechaNacimiento)
        {
            this.AsignarNombre(nombre);
            this.fechaNacimiento = fechaNacimiento;
        }

        public void AsignarNombre(string nombre)
        {
            if (nombre is null)
            {
                nombre = "Sin nombre";
            }

            this.nombre = nombre;
        }

        public void AsignarPeso(double peso)
        {
            this.peso = peso;
        }

        public double ObtenerPeso()
        {
            return this.peso;
        }

        public string ObtenerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos del gato:"); //Pone un salto de linea al final
            sb.AppendLine($"Nombre: {this.nombre}");
            //sb.AppendFormat("Nombre: {0}", this.nombre);
            sb.Append("Fecha de nacimiento: "); //No pone un salto de línea al final
            sb.AppendLine(this.fechaNacimiento.ToString("dd/MM/yyyy"));
            sb.AppendLine($"Peso: {this.peso}"); // String interpolado. Si uso esta forma mejor.

            return sb.ToString();
        }
    }
}
