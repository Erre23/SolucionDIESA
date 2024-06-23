using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogTaller
    {
        #region sigleton
        private static readonly LogTaller _instancia = new LogTaller();
        public static LogTaller Instancia { get { return _instancia; } }
        #endregion singleton

        #region metodos
        
        public async Task<short> TallerInsertar(Taller Taller)
        {
            return await DaoTaller.Instancia.Insertar(Taller);
        }

        public async Task TallerActualizar(Taller Taller)
        {
            await DaoTaller.Instancia.Actualizar(Taller);
        }

        public async Task TallerDeshabilitar(short idTaller)
        {
            await DaoTaller.Instancia.Deshabilitar(idTaller);
        }

        public async Task<Taller> TallerBuscarPorIdTaller(int idTaller)
        {
            return await DaoTaller.Instancia.BuscarPorIdTaller(idTaller);
        }

        public async Task<List<Taller>> TallerBusquedaGeneral(string nombre, int? idDepartamento, int? idProvincia, int? idDistrito)
        {
            var listaTallers = await DaoTaller.Instancia.BusquedaGeneral(nombre, idDepartamento, idProvincia, idDistrito);
            await LLenarDistrito(listaTallers);

            return listaTallers;
        }

        public async Task<List<Taller>> TallerBuscarDisponiblesPorFecha(DateTime fecha)
        {
            var listaTallers = await DaoTaller.Instancia.BuscarDisponiblesPorFecha(fecha);
            await LLenarDistrito(listaTallers);

            return listaTallers;
        }

        private async Task LLenarDistrito(List<Taller> listaTallers)
        {
            if (listaTallers.Count > 0)
            {
                var distritos = await LogDepartamento.Instancia.DistritoBuscarTodos();
                foreach (var Taller in listaTallers)
                {
                    Taller.Distrito = distritos.Find(x => x.IdDistrito == Taller.IdDistrito);
                }
            }
        }

        #endregion metodos
    }
}
