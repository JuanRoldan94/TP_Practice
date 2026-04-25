using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using GestionDeFlotas.Interfaces;

namespace GestionDeFlotas.Models
{
    public class CamionFlete : Vehiculo, IMantenimiento
    {

        public double CapacidadCarga { get; set; } = 1000;
        public void RealizarService()
        {
            Console.WriteLine("Realizando service al camion de flete...");
        }
        public bool VerificarEstado()
        {
            Console.WriteLine("Verificando estado del camion de flete...");
            return true;
        }
        public override double CalcularCostoServicio(double distanciaKM)
        {
            //Los 1000 que se suman, corresponden a un seguro de carga;
            //El costo por kilometro es de 5.0, pero se le suma el seguro de carga para obtener el costo total del servicio.
            return (distanciaKM* 5.0) + 1000;
        }
        public override string ObtenerDetalles() { return base.ObtenerDetalles() + $"Capacidad carga: {CapacidadCarga} KG."; }

    }
}
