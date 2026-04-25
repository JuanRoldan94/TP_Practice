using System;
using System.Collections.Generic;
using System.Text;

namespace GestionDeFlotas.Interfaces
{
    internal interface IMantenimiento
    {
        public void RealizarService();
        public bool VerificarEstado();

    }
}
