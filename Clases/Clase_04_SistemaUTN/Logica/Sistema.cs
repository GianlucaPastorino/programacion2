using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Sistema
    {
        static Usuario[] usuariosRegistrados;

        static Sistema() // Constructor estático
        {
            usuariosRegistrados = new Usuario[8]; // Instancio mi array de usuarios porque Usuario es un objeto.
            CargarUsuariosHardcodeados();
        }

        private static void CargarUsuariosHardcodeados()
        {
            usuariosRegistrados[0] = new Usuario("Pepe", "asd123");
            usuariosRegistrados[1] = new Usuario("Carola", "caro123");
            usuariosRegistrados[2] = new Usuario("Romeo", "miaumiau");
            usuariosRegistrados[3] = new Usuario("Jazmin", "rufosa123");
            usuariosRegistrados[4] = new Usuario("Juana", "rufruf01");
        }

        public static bool CheckearUsuario(string nombre, string pass)
        {
            bool retorno = false;

            for (int i = 0; i < usuariosRegistrados.Length; i++)
            {
                if (usuariosRegistrados[i] is not null)
                {
                    if (nombre == usuariosRegistrados[i].GetNombre() && usuariosRegistrados[i].ComprobarPass(pass))
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }
    }
}
