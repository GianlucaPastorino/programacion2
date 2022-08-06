using System;

namespace Entidades
{

    public enum EPosicion
    {
        Arquero = 14,
        Defensor,
        Mediocampista,
        Delantero = 5
    }


    public class Jugador
    {
        private static int ultimoId;

        private int id;
        private string nombre;
        private EPosicion posicion;
        private int numero;
        private int edad;
        private string nacionalidad;


        //private bool estaLesionado;
        //private bool estaSuspendido;

        static Jugador()
        {
            ultimoId = 1;
        }


        public string Nombre
        {
            get { return nombre; } // retornar el valor
            set { nombre = value; } // pisar el valor 
        }


        //public string EstadoParaJugar
        //{
        //    get
        //    {

        //        if (this.estaLesionado)
        //            return "Se lastimo";
        //        else if (this.estaSuspendido)
        //            return "Esta suspendido";
        //        else
        //            return "Jugador apto para jugar";
        //    }
        //}


        //public bool EstaLesionado
        //{
        //    set { this.estaLesionado = value; }
        //}


        public Jugador(string nombre, EPosicion posicion, int numero, int edad, string nacionalidad)
        {
            this.id = ultimoId;
            this.nombre = nombre;
            this.posicion = posicion;
            this.numero = numero;
            this.edad = edad;
            this.nacionalidad = nacionalidad;

            ultimoId++;
        }

    }
}
