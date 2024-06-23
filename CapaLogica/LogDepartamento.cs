using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogDepartamento
    {
        #region sigleton
        private static readonly LogDepartamento _instancia = new LogDepartamento();
        public static LogDepartamento Instancia { get { return _instancia; } }
        #endregion singleton

        #region metodos

        public async Task<Departamento> DepartamentoBuscarPorIdDepartamento(int idDepartamento)
        {
            return await DaoDepartamento.Instancia.BuscarPorIdDepartamento(idDepartamento);
        }

        public async Task<List<Departamento>> DepartamentoBuscarTodos()
        {
            var listaDepartamentos = await DaoDepartamento.Instancia.BuscarTodos();
            var listaProvincias = await DaoProvincia.Instancia.BuscarTodos();
            var listaDistritos = await DaoDistrito.Instancia.BuscarTodos();

            foreach (var departamento in listaDepartamentos)
            {
                departamento.Provincias = listaProvincias.FindAll(x => x.IdDepartamento == departamento.IdDepartamento);
            }
                
            foreach (var provincia in listaProvincias)
            {
                provincia.Distritos = listaDistritos.FindAll(x => x.IdProvincia == provincia.IdProvincia);
                provincia.Departamento = listaDepartamentos.Find(x => x.IdDepartamento == provincia.IdDepartamento);
            }

            foreach (var distrito in listaDistritos)
            {
                distrito.Provincia = listaProvincias.Find(x => x.IdProvincia == distrito.IdProvincia);
            }


            return listaDepartamentos;
        }

        public async Task<List<Distrito>> DistritoBuscarTodos()
        {
            var listaDepartamentos = await DaoDepartamento.Instancia.BuscarTodos();
            var listaProvincias = await DaoProvincia.Instancia.BuscarTodos();
            var listaDistritos = await DaoDistrito.Instancia.BuscarTodos();

            foreach (var departamento in listaDepartamentos)
            {
                departamento.Provincias = listaProvincias.FindAll(x => x.IdDepartamento == departamento.IdDepartamento);
            }

            foreach (var provincia in listaProvincias)
            {
                provincia.Distritos = listaDistritos.FindAll(x => x.IdProvincia == provincia.IdProvincia);
                provincia.Departamento = listaDepartamentos.Find(x => x.IdDepartamento == provincia.IdDepartamento);
            }

            foreach (var distrito in listaDistritos)
            {
                distrito.Provincia = listaProvincias.Find(x => x.IdProvincia == distrito.IdProvincia);
            }


            return listaDistritos;
        }

        #endregion metodos
    }
}
