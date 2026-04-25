using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Java;
using System.Text;
using System.Text.RegularExpressions;

namespace GestionDeFlotas.Utils
{
    public class ValidarConsola
    {
        public static int IngresarEntero(string ingreso, int min, int max) 
        {
            int resultado;
            bool esValido = false;

            while (!esValido)
            {
                Console.WriteLine($"{ingreso} ({min} - {max})");
                string input = Console.ReadLine();

                if (int.TryParse(input, out resultado))
                {
                    if (resultado >= min && resultado <= max)
                    {
                        esValido = true;
                        return resultado;
                    }
                    else
                    {
                        Console.WriteLine($"Error. El numero debe estar entre {min} y {max}");
                    }
                }
            }
            return 0;
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
    }
}
