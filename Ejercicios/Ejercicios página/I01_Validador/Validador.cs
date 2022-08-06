namespace I01_Validador
{
    static class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool respuesta = true;

            if(valor < -100 || valor > 100)
            {
                respuesta = false;
            }

            return respuesta;
        }
    }
}