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
        public List<EntInspector> ListarInspector()
        {
            return DaoInspector.Instancia.ListarInspector();
        }
        public void InsertarInspector(EntInspector Ins)
        {
            DaoInspector.Instancia.InsertarInspector(Ins);
        }
        public void EditarInspector(EntInspector Ins)
        {
            DaoInspector.Instancia.EditarInspector(Ins);
        }
        public void InhabilitaInspector(EntInspector Ins)
        {
            DaoInspector.Instancia.InhabilitarInspector(Ins);
        }
        public List<EntInspector> BuscaInspector(EntInspector Ins)
        {
           return DaoInspector.Instancia.BuscarInspector(Ins);
        }

        #endregion metodos




    }
}
