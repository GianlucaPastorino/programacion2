using System;
using System.Text;

namespace I01_Entidades
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public decimal GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DATOS DE LA CUENTA");
            sb.AppendLine($"Titular: {this.GetTitular()}");
            sb.AppendLine($"Dinero en cuenta: ${this.GetCantidad()}");

            return sb.ToString();
        }

        public void Ingresar(decimal monto)
        {
            if(monto > 0)
            {
                this.cantidad += monto;
            }
        }

        public void Retirar(decimal monto)
        {
            if(monto > 0)
            {
                this.cantidad -= monto;
            }
        }
    }
}
