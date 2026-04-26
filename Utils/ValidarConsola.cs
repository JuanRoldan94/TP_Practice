using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Java;
using System.Text;
using System.Text.RegularExpressions;

namespace GestionDeFlotas.Utils
{
    public class ValidarConsola
    {
        public static int IngresarEntero(string ingreso) 
        {
            while (true)
            {
                try
                {
                    Console.WriteLine($"{ingreso}");
                    int input = int.Parse(Console.ReadLine());
                    return input;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message} Debe ingresar un numero entero");
                }
            }
        }
        

        public static string PedirPatenteValida(string mensaje)
        {
            string patente;
            bool esValida = false;

            // Regex para Formato viejo (AAA123) o Formato Mercosur (AA123AA)
            string patronRegex = @"^(^[a-zA-Z]{3}\d{3}$)|(^[a-zA-Z]{2}\d{3}[a-zA-Z]{2}$)$";

            while (!esValida)
            {
                Console.Write($"{mensaje}: ");
                patente = Console.ReadLine().Trim().ToUpper();

                if (Regex.IsMatch(patente, patronRegex))
                {
                    return patente;
                }
                else
                {
                    Console.WriteLine("Error: Formato de patente inválido (Ej: AAA123 o AA123AA).");
                }
            }
            return string.Empty;
        }

        public static string PedirCadena(string mensaje)
        {
            string input = "";
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write($"{mensaje}: ");
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Error: El campo no puede estar vacío.");
                }
            }
            return input;
        }

        public static double IngresarDouble(string ingreso)
        {
            double resultado;
            Console.Write($"{ingreso}: ");

            while (!double.TryParse(Console.ReadLine(), out resultado))
            {
                Console.WriteLine("Error: Ingrese un valor numérico válido.");
                Console.Write($"{ingreso}: ");
            }
            return resultado;
        }
    }
}
