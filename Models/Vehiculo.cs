using System;
using System.Collections.Generic;
using System.Text;

namespace GestionDeFlotas.Models
{
    public abstract class Vehiculo
    {
        public string? Patente { get; set; }
        public string? Marca { get; set; }
        private double _kilometraje;
        public Boolean EstadoOperativo { get; set; } = true;

        public double Kilometraje
        {
            get
            {
                return _kilometraje;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("El kilometraje debe ser mayor a 0");
                }
                _kilometraje = value;
            }
        }
        public Vehiculo() { }

        public abstract double CalcularCostoServicio(double distanciaKM);

        public virtual string ObtenerDetalles() { return $"Patente: {Patente}. Marca: {Marca}, Kilometraje: {_kilometraje}. Estado Operativo: {EstadoOperativo} "; }
    }

}
