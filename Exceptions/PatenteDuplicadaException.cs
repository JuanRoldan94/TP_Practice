using System;
using System.Collections.Generic;
using System.Text;

namespace GestionDeFlotas.Exceptions
{
    public class PatenteDuplicadaException : Exception
    {
        public PatenteDuplicadaException(string mensaje) : base(mensaje)
        {
        }
    }
}
