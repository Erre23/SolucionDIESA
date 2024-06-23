using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Provincia
    {
        public int IdProvincia { get; set; }
        public string Nombre { get; set; }
        public int IdDepartamento { get; set; }
        public List<Distrito> Distritos { get; set; } = new List<Distrito>();
        public Departamento Departamento { get; set; }
    }
}
