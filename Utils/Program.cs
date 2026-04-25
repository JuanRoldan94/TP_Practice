using System.Collections;

namespace GestionDeFlotas.Utils
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar Accion a realizar:\n" +
                "1.Alta de vehiculo: \n" +
                "2. Registrar Servicio: \n" +
                "3. Mandar al taller: \n" +
                "4. Listar Flota: \n" +
                "5. Guardar y Salir:\n");
    
            do
            {
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Opcion Incorrecta. Ingrese una opcion valida");
                        break;
                }
            } while (true);
        }
    }
}
