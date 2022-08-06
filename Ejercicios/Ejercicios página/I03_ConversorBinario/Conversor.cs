namespace I03_ConversorBinario
{
    static class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            
            string retorno = "";

            if (numeroEntero >= 0)
            {
                do
                {
                    if (numeroEntero % 2 == 1)
                    {
                        retorno = "1" + retorno;
                    }
                    else
                    {
                        retorno = "0" + retorno;
                    }
                    numeroEntero /= 2;
                } while (numeroEntero > 0);
            }
            else
            {
                retorno = "Inválido";
            }

            return retorno;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {

        }
    }
}
