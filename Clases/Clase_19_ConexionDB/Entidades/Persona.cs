using System;

namespace Entidades
{
    public class Persona
    {
        // Los nombres de los atributos NO hace falta que coincidan con los de las tablas. Debería coincidir los tipos de datos.
        string nombre;
        int id;

        public Persona(string nombre) : this(nombre, 0)
        {
        }

        public Persona(string nombre, int id)
        {
            this.Nombre = nombre;
            this.Id = id;
        }

        public string Nombre 
        { 
            get => nombre; 
            set => nombre = value; 
        }

        public int Id 
        { 
            get => id; 
            set => id = value;
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}";
        }
    }
}
