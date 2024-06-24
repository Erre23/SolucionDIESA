using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
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
        public List<EntTipoInspeccion> ListarTipoInspeccion()
        {
            return DaoTipoInspeccion.Instancia.ListarTipoInspeccion();
        }

        public void InsertarTipoInspeccion(EntTipoInspeccion Ins)
        {
            DaoTipoInspeccion.Instancia.InsertarTipoInspeccion(Ins);
        }
        public void EditarTipoInspeccion(EntTipoInspeccion Ins)
        {
            DaoTipoInspeccion.Instancia.EditarTipoInspeccion(Ins);
        }
        public void InhabilitaTipoInspeccion(EntTipoInspeccion Ins)
        {
            DaoTipoInspeccion.Instancia.InhabilitarTipoInspeccion(Ins);
        }
       
        #endregion metodos

    }
}
