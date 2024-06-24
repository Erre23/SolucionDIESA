using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntMetodoPago
    {

        public int IdMetodoPago { get; set; }
        public string NombreMetodoP { get; set; }
        public string Descripcion { get; set; }
        public string TipoPago { get; set; }
        public string Credito_Debito{ get; set; }

        public string TipoTarjeta { get; set; }

        public string TipoMoneda { get; set; }

        public int TasaComision { get; set; }

        public string Estado{ get; set; }




    }
}
