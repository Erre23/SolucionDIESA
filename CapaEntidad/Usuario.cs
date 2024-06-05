namespace CapaEntidad
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public short IdTipoDocumentoIdentidad { get; set; }

        public string NumeroDocumentoIdentidad { get; set; }

        public string Nombres { get; set; }

        public string Apellido1 { get; set; }

        public string Apellido2 { get; set; }

        public string HashContrasena { get; set; }

        public bool CambioContrasena { get; set; }

        public bool Activo { get; set; }

        public string ApellidosNombres { get { return $"{Apellido1} {Apellido2} {Nombres}".Trim(); } }

        public TipoDocumentoIdentidad TipoDocumentoIdentidad { get; set; }
    }
}
