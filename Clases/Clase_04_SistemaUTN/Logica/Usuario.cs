using System;
using System.Text;

namespace Logica
{
    public class Usuario
    {
        private string usuario;
        private string password;

        public Usuario(string usuario, string password)
        {
            this.usuario = usuario;
            this.password = password;
        }

        public string GetNombre()
        {
            return this.usuario;
        }

        public bool ComprobarPass(string pass)
        {
            return this.password == pass;
        }
    }
}
