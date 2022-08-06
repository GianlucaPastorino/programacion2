/*
Consigna
Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.
Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.
*/
using System;

namespace I07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Recibo de sueldo";
            
            int cantidadEmpleados;
            double valorHora;
            string nombre;
            int antiguedad;
            int horasTrabajadas;
            double sueldoBruto;
            double sueldoNeto;

            Console.Write("Ingrese la cantidad de empleados: ");
            while (!int.TryParse(Console.ReadLine(), out cantidadEmpleados) || cantidadEmpleados <= 0)
            {
                Console.Write("Error. Ingrese una cantidad válida: ");
            }

            for (int i = 0; i < cantidadEmpleados; i++)
            {
                Console.Write("\nIngrese nombre del empleado: ");
                nombre = Console.ReadLine();

                Console.Write("\nIngrese el valor $ hora: ");
                while (!double.TryParse(Console.ReadLine(), out valorHora) || valorHora <= 0)
                {
                    Console.Write("Error. Ingrese un valor $ hora válido: ");
                }

                Console.Write("\nIngrese antiguedad (años) del empleado: ");
                while (!int.TryParse(Console.ReadLine(), out antiguedad) || antiguedad < 0 || antiguedad > 90)
                {
                    Console.Write("Error. Ingrese un número válido: ");
                }

                Console.Write("\nIngrese la cantidad de horas trabajadas del empleado: ");
                while (!int.TryParse(Console.ReadLine(), out horasTrabajadas) || horasTrabajadas < 0)
                {
                    Console.Write("Error. Ingrese una cantidad válida: ");
                }

                sueldoBruto = valorHora * horasTrabajadas + antiguedad * 150;
                sueldoNeto = sueldoBruto * 0.87;

                Console.WriteLine("\n****RECIBO DE SUELDO****");
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Antiguedad: {antiguedad}");
                Console.WriteLine($"Valor hora: ${valorHora}");
                Console.WriteLine($"TOTAL BRUTO: ${sueldoBruto}");
                Console.WriteLine($"TOTAL NETO: ${sueldoNeto}");
                Console.WriteLine("------------------------\n");
            }

            


        }
    }
}
