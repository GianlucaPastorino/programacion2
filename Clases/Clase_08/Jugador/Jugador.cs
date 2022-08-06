using System;

namespace Entidades
{
    public class Jugador
    {
        private static int ultimoId;

        private int id;
        private string nombre;
        private string posicion;
        private int numeroCamiseta;
        private int edad;
        private string nacionalidad;

        public Jugador(string nombre, string posicion, int numeroCamiseta, int edad, string nacionalidad)
        {
            this.nombre = nombre;
            this.posicion = posicion;
            this.numeroCamiseta = numeroCamiseta;
            this.edad = edad;
            this.nacionalidad = nacionalidad;
        }

        public string Nombre { get { return nombre; } }

        
    }
}
