using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogProgramacionInspeccion
    {
        #region sigleton
        private static readonly LogProgramacionInspeccion _instancia = new LogProgramacionInspeccion();
        public static LogProgramacionInspeccion Instancia { get { return _instancia; } }
        #endregion singleton

        #region metodos
        
        public async Task<int> ProgramacionInspeccionInsertar(ProgramacionInspeccion ProgramacionInspeccion)
        {
            return await DaoProgramacionInspeccion.Instancia.Insertar(ProgramacionInspeccion);
        }

        public async Task ProgramacionInspeccionAnular(int idProgramacionInspeccion)
        {
            await DaoProgramacionInspeccion.Instancia.Anular(idProgramacionInspeccion);
        }

        public async Task<ProgramacionInspeccion> ProgramacionInspeccionBuscarPorIdProgramacionInspeccion(int idProgramacionInspeccion)
        {
            var programacionInspeccion = await DaoProgramacionInspeccion.Instancia.BuscarPorIdProgramacionInspeccion(idProgramacionInspeccion);

            if (programacionInspeccion != null)
            {
                programacionInspeccion.Cliente = await DaoCliente.Instancia.BuscarPorIdCliente(programacionInspeccion.IdCliente);
                programacionInspeccion.TipoInspeccion = await DaoTipoInspeccion.Instancia.BuscarPorIdTipoInspeccion(programacionInspeccion.IdTipoInspeccion);
                programacionInspeccion.Taller = await DaoTaller.Instancia.BuscarPorIdTaller(programacionInspeccion.IdTaller);
                programacionInspeccion.Inspector = await DaoInspector.Instancia.BuscarPorIdInspector(programacionInspeccion.IdInspector);
                programacionInspeccion.MetodoPago = await DaoMetodoPago.Instancia.BuscarPorIdMetodoPago(programacionInspeccion.IdMetodoPago);
            }

            return programacionInspeccion;
        }

        #endregion metodos
    }
}
