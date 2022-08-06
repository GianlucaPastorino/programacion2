using System;

namespace I04_Clases
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if(tinta + this.tinta <= cantidadTintaMaxima && tinta + this.tinta >= 0)
            {
                this.tinta += tinta;
            }
        }

        public void Recargar()
        {
            this.SetTinta((short)(cantidadTintaMaxima - this.tinta));
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno = false;

            dibujo = "";

            for (int i = gasto; i < 0; i++)
            {
                if(this.tinta == 0)
                {
                    break;
                }

                this.SetTinta(-1);
                dibujo += "*";
                retorno = true;
            }

            return retorno;
        }
    }
}
