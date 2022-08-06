using System;
using System.Collections.Generic;

namespace BibliotecaDeClases
{
    public class Universidad
    {
        public event Action<bool> cupoLleno;

        List<Carrera> listaCarreras;//no modificar
        int capacidad;//no modificar

        public List<Carrera> ListaCarreras { get => listaCarreras; }//no modificar

        public Universidad(int cupo) //no modificar metodo
        {
            this.capacidad = cupo;
            listaCarreras = new List<Carrera>();
        }

        // completar metodo
        public List<Carrera> AgregarNuevaCarrera()
        {   
            listaCarreras.Add(GeneradorDeDatos.GetUnaCarrera);
            if(listaCarreras.Count == capacidad)
            {
                cupoLleno.Invoke(true);
            }
            return ListaCarreras;
        }

    }
}
