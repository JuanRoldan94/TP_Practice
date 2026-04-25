using System;
using System.Collections.Generic;
using System.Text;
using GestionDeFlotas.Interfaces;

namespace GestionDeFlotas.Models
{
    internal class GruaAuxilio : Vehiculo, IMantenimiento
    {
        public bool TienePlataforma { get; set; } = true;
        public void RealizarService()
        {
            Console.WriteLine("Realizando service a la grua de auxilio...");
        }
        public void VerificarEstado()
        {
            Console.WriteLine("Verificando estado de la grua de auxilio...");
        }

        public override double CalcularCostoServicio(double distanciaKM)
        {
            //El costo por kilometro es de 3.0, pero se le suma un costo fijo de 500 para obtener el costo total del servicio.
            return (distanciaKM * 3.0) + 500;
        }

        bool IMantenimiento.VerificarEstado()
        {
            throw new NotImplementedException();
        }
    }
}
