using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace CapaLogica
{
    public class LogTipoInspeccion
    {
        #region sigleton

        private static readonly LogTipoInspeccion _instancia = new LogTipoInspeccion();
        //privado para evitar la instanciación directa
        public static LogTipoInspeccion Instancia
        {
            get
            {
                return LogTipoInspeccion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public async Task<List<TipoInspeccion>> TipoInspeccionListarActivos()
        {
            return await DaoTipoInspeccion.Instancia.ListarActivos();
        }

        public async Task<List<TipoInspeccion>> TipoInspeccionListarTodos()
        {
            return await DaoTipoInspeccion.Instancia.ListarTodos();
        }

        public async Task<short> TipoInspeccionInsertar(TipoInspeccion tipoInspeccion)
        {
            return await DaoTipoInspeccion.Instancia.Insertar(tipoInspeccion);
        }
        public async Task TipoInspeccionActualizar(TipoInspeccion tipoInspeccion)
        {
            await DaoTipoInspeccion.Instancia.Actualizar(tipoInspeccion);
        }
        public async Task TipoInspeccionDeshabilitar(short idTipoInspeccion)
        {
            await DaoTipoInspeccion.Instancia.Deshabilitar(idTipoInspeccion);
        }
       
        #endregion metodos

    }
}
