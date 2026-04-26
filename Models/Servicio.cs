using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.Serialization.Formatters;
using System.Text;
using GestionDeFlotas.Utils;

namespace GestionDeFlotas.Models
{
    public class Servicio
    {
        public List<Vehiculo> Vehiculos { get; set; }

        public Servicio() {
            Vehiculos = new List<Vehiculo>();
        }

        public void AgregarVehiculo() {
            int tipo = ValidarConsola.IngresarEntero("Ingresar tipo de vehiculo:\n" +
                "1. Grua Auxilio\n" +
                "2. Camion Flete");
            string patente = ValidarConsola.PedirPatenteValida("Ingresar patente");

            if (PatenteExiste(patente))
            {
                return;
            }

            string Marca = ValidarConsola.PedirCadena("Ingresar Marca del vehiculo");
            Console.Write("Ingresar Km: ");
            double Kilometraje = ValidarConsola.IngresarDouble("Ingresar km del vehiculo: ");

            Vehiculo nuevoVehiculo;
            if (tipo == 1)
            {
                nuevoVehiculo = new GruaAuxilio();
            }
            else
            {
                nuevoVehiculo = new CamionFlete();
            }

            nuevoVehiculo.Kilometraje = Kilometraje;
            nuevoVehiculo.Patente = patente;
            nuevoVehiculo.Marca = Marca;

            Vehiculos.Add(nuevoVehiculo);
        }

        public void ListarFlota()
        {
            if (Vehiculos.Count == 0)
            {
                Console.WriteLine("La flota está vacía. No hay vehículos registrados.");
                return;
            }

            Console.WriteLine("--- Lista de Vehículos en la Flota ---");
            foreach (Vehiculo v in Vehiculos)
            {
                Console.WriteLine(v.ObtenerDetalles());
            }
        }

        public bool PatenteExiste(string patente)
        {
            foreach (Vehiculo v in Vehiculos)
            {
                if (v.Patente == patente)
                {
                    Console.WriteLine("Esa patente ya esta asignada a otro vehiculo.");
                    return true;
                }
            }
            return false;
        }

    }
}
