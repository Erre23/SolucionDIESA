namespace CapaEntidad
{
    public class Inspector
    {
        public int IdInspector { get; set; }
        public short IdTipoDocumentoIdentidad { get; set; }
        public TipoDocumentoIdentidad TipoDocumentoIdentidad { get; set; }
        public string NumeroDocumentoIdentidad { get; set; }
        public string Nombres { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; } = true;

        public string ApellidosYNombres
        {
            get
            {
                string apellidosYNombres = "";

                apellidosYNombres = Apellido1;
                apellidosYNombres += string.IsNullOrEmpty(Apellido2) ? "" : " " + Apellido2;
                apellidosYNombres += string.IsNullOrEmpty(Nombres) ? "" : " " + Nombres;

                return apellidosYNombres;
            }
        }



    }
}
