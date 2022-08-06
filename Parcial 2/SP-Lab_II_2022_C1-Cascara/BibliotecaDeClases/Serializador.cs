using System;
using System.IO;
using System.Text.Json;

namespace BibliotecaDeClases
{
    public static class Serializador<T>
    {
        public static T Leer(string archivo, Action<string> mostrarElementos)
        {
            T datos = default;
            try
            {
                if (archivo is not null)
                {
                    datos = JsonSerializer.Deserialize<T>(File.ReadAllText(archivo));
                    mostrarElementos.Invoke("Documento deserializado con éxito.");
                }
                return datos;
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {archivo}");
            }
        }
    }
}
