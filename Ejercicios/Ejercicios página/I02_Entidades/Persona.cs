using System;
using System.Text;

namespace I02_Entidades
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre; //SetNombre
            this.fechaDeNacimiento = fechaDeNacimiento; //SetFechaDeNacimiento
            this.dni = dni; //SetDni
        }

        public void SetNombre(string nombre)
        {
            //Validar
            this.nombre = nombre;
        }

        public void SetFechaDeNacimiento(DateTime fechaDeNacimiento)
        {
            //Validar
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public void SetDni(int dni)
        {
            //Validar
            this.dni = dni;
        }

       /* public string GetNombre()
        {
            return this.nombre;
        }

        public DateTime GetFecha()
        {
            return this.fechaDeNacimiento;
        }

        public int GetDni()
        {
            return this.dni;
        }*/

        private int CalcularEdad(DateTime fecha)
        {
            return DateTime.Today.AddTicks(-fecha.Ticks).Year - 1;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Fecha de nacimiento: {this.fechaDeNacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Edad actual: {this.CalcularEdad(this.fechaDeNacimiento)}");

            return sb.ToString();
        }

        public string EsMayorDeEdad()
        {
            string retorno = "Es menor de edad.";

            if(this.CalcularEdad(this.fechaDeNacimiento) >= 18)
            {
                retorno = "Es mayor de edad.";
            }

            return retorno;
        }
    }
}
