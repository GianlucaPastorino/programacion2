using System;
using C01_Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(2, "Equipo");
            Jugador jugador = new Jugador(1234, "Lauti", 0, 0);
            Jugador jugador2 = new Jugador(1234, "Lucas", 6, 1);
            Jugador jugador3 = new Jugador(342, "Fede", 3, 3);
            Jugador jugador4 = new Jugador(4463456, "Esteban", 0, 3);

            Console.WriteLine(jugador.MostrarDatos());

            //_ = equipo + jugador; El _ funciona como una variable de descarte. No me va a importar qué me asigne.

            AgregarJugador(equipo, jugador); //Se tiene que agregar
            AgregarJugador(equipo, jugador2); //No se tiene que agregar (mismo dni)
            AgregarJugador(equipo, jugador3); //Se tiene que agregar
            AgregarJugador(equipo, jugador4); //No se tiene que agregar por capacidad.

          
        }

        static void AgregarJugador(Equipo equipo, Jugador jugador)
        {
            if (equipo + jugador)
            {
                Console.WriteLine($"Jugador agregado: {jugador.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"No se pudo agregar el jugador: {jugador.MostrarDatos()}");
            }
        }
    }
}
