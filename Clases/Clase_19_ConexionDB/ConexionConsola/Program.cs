using System;
using System.Collections.Generic;
using Entidades;

namespace ConexionConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Persona> personas = PersonaAccesoDatos.Leer(); // Me devuelve todas las personas de la tabla en fomra de lista.

                Persona persona = PersonaAccesoDatos.Leer(1); // Me devuelve la persona del índice indicado por parámetro.

                foreach (Persona item in personas)
                {
                    Console.WriteLine(item.ToString());
                }

                //Persona personaAux = new Persona("Joe");

                //PersonaAccesoDatos.Guardar(personaAux.Nombre);

                //PersonaAccesoDatos.Eliminar(6);

                //PersonaAccesoDatos.Modificar("Lautito", 1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
