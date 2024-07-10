using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class MetodoPago
    {
        public short IdMetodoPago { get; set; }

        public string Nombre { get; set; }

        public bool Activo { get; set; } = true;
    }
}
