using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using GestionDeFlotas.Utils;

namespace GestionDeFlotas.Models
{
    internal class Servicio
    {
        public List<Vehiculo> Vehiculos { get; set; }

        public Servicio() {
            Vehiculos = new List<Vehiculo>();
        }

        public void AgregarVehiculo() {
            int tipo = ValidarConsola.IngresarEntero("Ingresar tipo de vehiculo:\n" +
                "1. Grua Auxilio\n" +
                "2. Camion Flete", 1, 2);

            string patente = ValidarConsola.PedirPatenteValida("Ingresar patente");

            if (PatenteExiste(patente))
            {
                return;
            }

            string Marca = ValidarConsola.PedirCadena("Ingresar Marca del vehiculo");
            double Kilometraje = double.Parse(Console.ReadLine());

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
            nuevoVehiculo.patente = patente;
            nuevoVehiculo.Marca = Marca;

            Vehiculos.Add(nuevoVehiculo);
        }

        public bool PatenteExiste(string patente)
        {
            foreach (Vehiculo v in Vehiculos)
            {
                if (v.patente == patente)
                {
                    Console.WriteLine("Esa patente ya esta asignada a otro vehiculo.");
                    return true;
                }
            }
            return false;
        }

    }
}
