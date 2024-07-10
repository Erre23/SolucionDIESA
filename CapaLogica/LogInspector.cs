using CapaEntidad;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{


    public class LogInspector
    {
        #region sigleton

        private static readonly LogInspector _instancia = new LogInspector();
        //privado para evitar la instanciación directa
        public static LogInspector Instancia
        {
            get
            {
                return LogInspector._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public async Task<int> InspectorInsertar(Inspector Inspector)
        {
            return await DaoInspector.Instancia.Insertar(Inspector);
        }

        public async Task InspectorActualizar(Inspector Inspector)
        {
            await DaoInspector.Instancia.Actualizar(Inspector);
        }

        public async Task InspectorDeshabilitar(int idInspector)
        {
            await DaoInspector.Instancia.Deshabilitar(idInspector);
        }

        public async Task<Inspector> InspectorBuscarPorIdInspector(int idInspector)
        {
            return await DaoInspector.Instancia.BuscarPorIdInspector(idInspector);
        }

        public async Task<Inspector> InspectorBuscarPorDocumentoIdentidad(short idTipoDocumentoIdentidad, string numeroDocumentoIdentidad)
        {
            return await DaoInspector.Instancia.BuscarPorDocumentoIdentidad(idTipoDocumentoIdentidad, numeroDocumentoIdentidad);
        }

        public async Task<List<Inspector>> InspectorBuscarDisponiblesPorFechaHora(DateTime fecha, DateTime hora)
        {
            var listaInspectores = await DaoInspector.Instancia.ListarActivos();

            var programacionesInspeccion = await DaoProgramacionInspeccion.Instancia.BuscarPorTallerFecha(0, fecha.Date);
            programacionesInspeccion = programacionesInspeccion.FindAll(x => x.InspeccionHora.Hour == hora.Hour);
            programacionesInspeccion.RemoveAll(x => x.Anulado);

            listaInspectores.RemoveAll(x => programacionesInspeccion.Any(p => p.IdInspector == x.IdInspector));

            if (listaInspectores.Count > 0)
            {
                var tiposDocumentoIdentidad = await DaoTipoDocumentoIdentidad.Instancia.ListarTodos();
                foreach (var Inspector in listaInspectores)
                {
                    Inspector.TipoDocumentoIdentidad = tiposDocumentoIdentidad.Find(x => x.IdTipoDocumentoIdentidad == Inspector.IdTipoDocumentoIdentidad);
                }
            }

            return listaInspectores;
        }

        public async Task<List<Inspector>> InspectorBusquedaGeneral(short? idTipoDocumentoIdentidad, string numeroDocumentoIdentidad, string nombres, string apellido1, string apellido2)
        {
            var listaInspectores = await DaoInspector.Instancia.BusquedaGeneral(idTipoDocumentoIdentidad, numeroDocumentoIdentidad, nombres, apellido1, apellido2);
            if (listaInspectores.Count > 0)
            {
                var tiposDocumentoIdentidad = await DaoTipoDocumentoIdentidad.Instancia.ListarTodos();
                foreach (var Inspector in listaInspectores)
                {
                    Inspector.TipoDocumentoIdentidad = tiposDocumentoIdentidad.Find(x => x.IdTipoDocumentoIdentidad == Inspector.IdTipoDocumentoIdentidad);
                }
            }

            return listaInspectores;
        }

        public async Task<List<Inspector>> InspectorListarActivos()
        {
            var listaInspectores = await DaoInspector.Instancia.ListarActivos();
            if (listaInspectores.Count > 0)
            {
                var tiposDocumentoIdentidad = await DaoTipoDocumentoIdentidad.Instancia.ListarTodos();
                foreach (var Inspector in listaInspectores)
                {
                    Inspector.TipoDocumentoIdentidad = tiposDocumentoIdentidad.Find(x => x.IdTipoDocumentoIdentidad == Inspector.IdTipoDocumentoIdentidad);
                }
            }

            return listaInspectores;
        }

        #endregion metodos
    }
}
