﻿namespace CapaEntidad
{
    public class TipoDocumentoIdentidad
    {
        public short IdTipoDocumentoIdentidad { get; set; }

        public string Nombre { get; set; }

        public bool LongitudExacta { get; set; }

        public short LongitudMaxima { get; set; }

        public short LongitudMinima { get; set; }

        public bool Alfanumerico { get; set; }

        public bool Activo { get; set; }
    }
}
