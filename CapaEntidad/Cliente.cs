using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public short IdTipoDocumentoIdentidad { get; set; }
        public TipoDocumentoIdentidad TipoDocumentoIdentidad { get; set; }
        public string NumeroDocumentoIdentidad { get; set; }
        public string RazonSocial { get; set; }
        public string Nombres { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; } = true;

        public string RazonSocialOrApellidosYNombres
        {
            get 
            {
                string razonSocialOrApellidosYNombres = "";

                if (!string.IsNullOrEmpty(RazonSocial))
                {
                    razonSocialOrApellidosYNombres = RazonSocial;
                }
                else
                {
                    razonSocialOrApellidosYNombres = Apellido1;
                    razonSocialOrApellidosYNombres += string.IsNullOrEmpty(Apellido2) ? "" : " " + Apellido2;
                    razonSocialOrApellidosYNombres += string.IsNullOrEmpty(Nombres) ? "" : " " + Nombres;
                }

                return razonSocialOrApellidosYNombres;
            }
        }
    }
}
