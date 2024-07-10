using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ProgramacionInspeccion
    {
        public int IdProgramacionInspeccion { get; set; }
        public DateTime FechaHoraRegistro { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public short IdTipoInspeccion { get; set; }
        public TipoInspeccion TipoInspeccion { get; set; }
        public string Vehiculo { get; set; }
        public short IdTaller { get; set; }
        public Taller Taller { get; set; }
        public DateTime InspeccionFecha { get; set; }
        public DateTime InspeccionHora { get; set; }
        public int IdInspector { get; set; }
        public Inspector Inspector { get; set; }
        public short IdMetodoPago { get; set; }
        public MetodoPago MetodoPago { get; set; }
        public decimal Total { get; set; }
        public bool Anulado { get; set; } = false;
    }
}
