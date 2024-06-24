using CapaEntidad;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                return LogMetodoPago ._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<EntMetodoPago> ListarMetodoPago()
        {
            return DaoMetodoPago.Instancia.ListarMetodoPago();
        }
        public void InsertarMetodoPago(EntMetodoPago MP)
        {
            DaoMetodoPago.Instancia.InsertarMetodoPago(MP);
        }
        public void EditarMetodoPago(EntMetodoPago MP)
        {
            DaoMetodoPago.Instancia.EditarMetodoPago(MP);
        }

        public void DeshabilitarMetodoPago(EntMetodoPago MP)
        {
            DaoMetodoPago.Instancia.DeshabilitarMetodoPago(MP);
        }



        #endregion metodos
    }
}
