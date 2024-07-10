using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace CapaLogica
{
    public class LogMetodoPago
    {
        #region sigleton

        private static readonly LogMetodoPago _instancia = new LogMetodoPago();
        //privado para evitar la instanciación directa
        public static LogMetodoPago Instancia
        {
            get
            {
                return LogMetodoPago._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public async Task<List<MetodoPago>> MetodoPagoListarActivos()
        {
            return await DaoMetodoPago.Instancia.ListarActivos();
        }

        public async Task<List<MetodoPago>> MetodoPagoListarTodos()
        {
            return await DaoMetodoPago.Instancia.ListarTodos();
        }

        public async Task<short> MetodoPagoInsertar(MetodoPago MetodoPago)
        {
            return await DaoMetodoPago.Instancia.Insertar(MetodoPago);
        }
        public async Task MetodoPagoActualizar(MetodoPago MetodoPago)
        {
            await DaoMetodoPago.Instancia.Actualizar(MetodoPago);
        }
        public async Task MetodoPagoDeshabilitar(short idMetodoPago)
        {
            await DaoMetodoPago.Instancia.Deshabilitar(idMetodoPago);
        }
       
        #endregion metodos

    }
}
