using System;
using System.Collections.Generic;
using System.Text;

namespace GestionDeFlotas.Exceptions
{
    internal class VehiculoNoOperativoException : Exception
    {
        public VehiculoNoOperativoException(string mensaje) : base(mensaje) { }
    }
}
