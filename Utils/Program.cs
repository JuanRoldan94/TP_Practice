using GestionDeFlotas.Models;
using System.Collections;

namespace GestionDeFlotas.Utils
{
    public class Program
    {
        static void Main(string[] args)
        {
            Servicio gestorDeFlotas = new Servicio();
            do
            {
                int opcion = ValidarConsola.IngresarEntero("Ingresar Accion a realizar:\n" +
                "1. Alta de vehiculo: \n" +
                "2. Registrar Servicio: \n" +
                "3. Mandar al taller: \n" +
                "4. Listar Flota: \n" +
                "5. Guardar y Salir:\n", 1, 5);
                switch (opcion)
                {
                    case 1:
                        gestorDeFlotas.AgregarVehiculo();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        gestorDeFlotas.ListarFlota();
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
