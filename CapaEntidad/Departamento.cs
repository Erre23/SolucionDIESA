using System.Collections.Generic;

namespace CapaEntidad
{
    public class Departamento
    {
        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }
        public List<Provincia> Provincias { get; set; } = new List<Provincia>();
    }
}
