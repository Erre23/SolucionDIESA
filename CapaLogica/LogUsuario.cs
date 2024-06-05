using CapaDatos;
using CapaEntidad;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogUsuario
    {
        #region sigleton
        private static readonly LogUsuario _instancia = new LogUsuario();
        public static LogUsuario Instancia { get { return _instancia; } }
        #endregion singleton

        #region metodos
        
        public async Task<int> UsuarioInsertar(Usuario usuario)
        {
            return await DaoUsuario.Instancia.Insertar(usuario);
        }

        public async Task<Usuario> UsuarioLogin(int idUsuario, string contrasena)
        {
            return await DaoUsuario.Instancia.Login(idUsuario, contrasena);
        }

        public async Task<Usuario> UsuarioBuscarPorDocumentoIdentidad(short idTipoDocumentoIdentidad, string numeroDocumentoIdentidad)
        {
            return await DaoUsuario.Instancia.BuscarPorDocumentoIdentidad(idTipoDocumentoIdentidad, numeroDocumentoIdentidad);
        }

        #endregion metodos
    }
}
