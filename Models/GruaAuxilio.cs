using System;
using System.Collections.Generic;
using System.Text;
using GestionDeFlotas.Interfaces;

namespace GestionDeFlotas.Models
{
    public class GruaAuxilio : Vehiculo, IMantenimiento
    {
        public bool TienePlataforma { get; set; } = true;
        public void RealizarService()
        {
            Console.WriteLine("Realizando service a la grua de auxilio...");
        }
        public bool VerificarEstado()
        {
            Console.WriteLine("Verificando estado de la grua de auxilio...");
            return true;
        }

        public override double CalcularCostoServicio(double distanciaKM)
        {
            //El costo por kilometro es de 3.0, pero se le suma un costo fijo de 500 para obtener el costo total del servicio.
            return (distanciaKM * 3.0) + 500;
        }
        public override string toString() { return $"Patente: {Patente}. Marca: {Marca}, Kilometraje: {Kilometraje}. Estado Operativo: {EstadoOperativo}"; }

    }
}
