using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogTipoDocumentoIdentidad
    {
        #region sigleton
        private static readonly LogTipoDocumentoIdentidad _instancia = new LogTipoDocumentoIdentidad();
        public static LogTipoDocumentoIdentidad Instancia { get { return _instancia; } }
        #endregion singleton

        #region metodos
        ///listado
        public async Task<List<TipoDocumentoIdentidad>> TipoDocumentoIdentidaListarActivos()
        {
            return await DaoTipoDocumentoIdentidad.Instancia.ListarActivos();
        }

        #endregion metodos
    }
}
