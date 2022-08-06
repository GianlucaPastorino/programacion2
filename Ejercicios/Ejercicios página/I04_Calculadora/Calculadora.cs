namespace I04_Calculadora
{
    static class Calculadora
    {
        public static string Calcular(decimal primerOperando, decimal segundoOperando, string operador)
        {
            string resultado = "No se puede dividir por 0.";

            switch (operador)
            {
                case "+":
                    resultado = (primerOperando + segundoOperando).ToString();
                    break;
                case "-":
                    resultado = (primerOperando - segundoOperando).ToString();
                    break;
                case "*":
                    resultado = (primerOperando * segundoOperando).ToString();
                    break;
                case "/":
                    if (Validar(segundoOperando))
                    {
                        resultado = (primerOperando / segundoOperando).ToString();
                    }
                    break;
            }

            return resultado;
        }

        private static bool Validar(decimal divisor)
        {
            bool validez = true;

            if (divisor == 0)
            {
                validez = false;
            }

            return validez;
        }
    }
}
