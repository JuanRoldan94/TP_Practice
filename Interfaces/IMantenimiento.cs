using System;
using System.Collections.Generic;
using System.Text;

namespace GestionDeFlotas.Interfaces
{
    public interface IMantenimiento
    {
        public void RealizarService();
        public bool VerificarEstado();

    }
}
