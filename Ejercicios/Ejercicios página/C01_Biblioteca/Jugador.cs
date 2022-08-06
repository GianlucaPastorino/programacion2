using System;
using System.Text;

namespace C01_Biblioteca
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public float GetPromedioGoles()
        {
            if (partidosJugados == 0)
            {
                return 0;
            }
            
            promedioGoles = (float)totalGoles / partidosJugados;
            return promedioGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Cantidad de partidos jugados: {this.partidosJugados}");
            sb.AppendLine($"Total Goles: {this.totalGoles}");
            sb.AppendLine($"Promedio Goles: {GetPromedioGoles()}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            if(jugador1 is not null && jugador2 is not null)
            {
                return jugador1.dni == jugador2.dni;
            }

            return false;
        }

        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }
    }
}
