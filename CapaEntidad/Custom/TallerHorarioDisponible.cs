using System;

namespace CapaEntidad.Custom
{
    public class TallerHorarioDisponible
    {
        public short IdTaller { get; set; }
        public Taller Taller { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
    }
}
