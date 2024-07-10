using CapaDatos;
using CapaEntidad;
using CapaEntidad.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public async Task<Taller> TallerBuscarPorIdTaller(short idTaller)
        {
            return await DaoTaller.Instancia.BuscarPorIdTaller(idTaller);
        }

        public async Task<List<Taller>> TallerBusquedaGeneral(string nombre, int? idDepartamento, int? idProvincia, int? idDistrito)
        {
            var listaTallers = await DaoTaller.Instancia.BusquedaGeneral(nombre, idDepartamento, idProvincia, idDistrito);
            await LLenarDistrito(listaTallers);

            return listaTallers;
        }

        public async Task<List<Taller>> TallerListarActivos()
        {
            var listaTallers = await DaoTaller.Instancia.ListarActivos();
            await LLenarDistrito(listaTallers);

            return listaTallers;
        }

        public async Task<List<TallerHorarioDisponible>> TallerBuscarDisponiblesPorFecha(short idTaller, DateTime fecha)
        {
            // Listamos todos los talleres disponibles
            var talleres = new List<Taller>();
            if (idTaller != 0)
            {
                var taller = await DaoTaller.Instancia.BuscarPorIdTaller(idTaller);
                if (taller != null) talleres.Add(taller);
            }
            else
            {
                talleres = await DaoTaller.Instancia.ListarActivos();
            }

            // Removemos los tallers que no funcionen en el día de la semana que corresponde a la fecha de búsqueda
            switch (fecha.DayOfWeek)
            {
                case DayOfWeek.Monday: 
                    talleres.RemoveAll(x => x.Lunes == false);
                    break;
                case DayOfWeek.Tuesday:
                    talleres.RemoveAll(x => x.Martes == false);
                    break;
                case DayOfWeek.Wednesday:
                    talleres.RemoveAll(x => x.Miercoles == false);
                    break;
                case DayOfWeek.Thursday:
                    talleres.RemoveAll(x => x.Jueves == false);
                    break;
                case DayOfWeek.Friday:
                    talleres.RemoveAll(x => x.Viernes == false);
                    break;
                case DayOfWeek.Saturday:
                    talleres.RemoveAll(x => x.Sabado == false);
                    break;
                case DayOfWeek.Sunday:
                    talleres.RemoveAll(x => x.Domingo == false);
                    break;
            }

            // Creamos la estructura de horarios disponibles
            var talleresDisponibles = new List<TallerHorarioDisponible>();
            foreach (var taller in talleres)
            {
                var horaInicio = taller.HoraInicio;
                while(horaInicio.Ticks <= taller.HoraFin.Ticks)
                {
                    talleresDisponibles.Add(
                        new TallerHorarioDisponible
                        {
                            IdTaller = taller.IdTaller,
                            Taller = taller,
                            Fecha = fecha.Date,
                            Hora = horaInicio
                        }
                    );
                    horaInicio = horaInicio.AddHours(1);
                }
            }

            // Lista la programaciones de inspecciones existentes en la fecha y eliminamos las anuladas
            var programacionesInpseccion = await DaoProgramacionInspeccion.Instancia.BuscarPorTallerFecha(idTaller, fecha);
            programacionesInpseccion.RemoveAll(x => x.Anulado);

            talleresDisponibles.RemoveAll(t => programacionesInpseccion.Any(p => p.InspeccionFecha.Date == t.Fecha.Date && p.InspeccionHora.Hour == t.Hora.Hour));            

            return talleresDisponibles;
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
