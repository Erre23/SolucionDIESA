﻿using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DaoCliente
    {
        #region sigleton
        private static readonly DaoCliente _instancia = new DaoCliente();
        public static DaoCliente Instancia { get { return _instancia; } }
        #endregion singleton

        #region métodos
        public async Task<int> Insertar(Cliente cliente)
        {
            var cmd = (SqlCommand)null;
            SqlConnection cnn = Conexion.Instancia.Conectar();
            await cnn.OpenAsync();
            using (var tran = cnn.BeginTransaction())
            { 
                try
                {
                    cmd = new SqlCommand("spClienteInsertar", cnn, tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(CreateParams.TinyInt("IdTipoDocumentoIdentidad", cliente.IdTipoDocumentoIdentidad));
                    cmd.Parameters.Add(CreateParams.NVarchar("NumeroDocumentoIdentidad", cliente.NumeroDocumentoIdentidad, 20));
                    cmd.Parameters.Add(CreateParams.NVarchar("RazonSocial", cliente.RazonSocial, 250));
                    cmd.Parameters.Add(CreateParams.NVarchar("Nombres", cliente.Nombres, 100));
                    cmd.Parameters.Add(CreateParams.NVarchar("Apellido1", cliente.Apellido1, 50));
                    cmd.Parameters.Add(CreateParams.NVarchar("Apellido2", cliente.Apellido2, 50));
                    cmd.Parameters.Add(CreateParams.NVarchar("Celular", cliente.Celular, 50));
                    cmd.Parameters.Add(CreateParams.NVarchar("Email", cliente.Email, 100));

                    cliente.IdCliente = Convert.ToInt32(await cmd.ExecuteScalarAsync());

                    tran.Commit();
                    cmd.Connection.Close();
                    cmd.Dispose();
                }
                catch (Exception e)
                {
                    tran.Rollback();
                    cmd.Connection.Close();
                    cmd.Dispose();
                    throw e;
                }
            }

            return cliente.IdCliente;
        }


        public async Task Actualizar(Cliente cliente)
        {
            var cmd = (SqlCommand)null;
            SqlConnection cnn = Conexion.Instancia.Conectar();
            await cnn.OpenAsync();
            using (var tran = cnn.BeginTransaction())
            {
                try
                {
                    cmd = new SqlCommand("spClienteActualizar", cnn, tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(CreateParams.Int("IdCliente", cliente.IdCliente));
                    cmd.Parameters.Add(CreateParams.TinyInt("IdTipoDocumentoIdentidad", cliente.IdTipoDocumentoIdentidad));
                    cmd.Parameters.Add(CreateParams.NVarchar("NumeroDocumentoIdentidad", cliente.NumeroDocumentoIdentidad, 20));
                    cmd.Parameters.Add(CreateParams.NVarchar("RazonSocial", cliente.RazonSocial, 250));
                    cmd.Parameters.Add(CreateParams.NVarchar("Nombres", cliente.Nombres, 100));
                    cmd.Parameters.Add(CreateParams.NVarchar("Apellido1", cliente.Apellido1, 50));
                    cmd.Parameters.Add(CreateParams.NVarchar("Apellido2", cliente.Apellido2, 50));
                    cmd.Parameters.Add(CreateParams.NVarchar("Celular", cliente.Celular, 50));
                    cmd.Parameters.Add(CreateParams.NVarchar("Email", cliente.Email, 100));

                    cmd.ExecuteNonQuery();
                    tran.Commit();
                    cmd.Connection.Close();
                    cmd.Dispose();
                }
                catch (Exception e)
                {
                    tran.Rollback();
                    cmd.Connection.Close();
                    cmd.Dispose();
                    throw e;
                }
            }
        }


        public async Task Deshabilitar(int idCliente)
        {
            var cmd = (SqlCommand)null;
            SqlConnection cnn = Conexion.Instancia.Conectar();
            await cnn.OpenAsync();
            using (var tran = cnn.BeginTransaction())
            { 
                try
                {
                    cmd = new SqlCommand("spClienteDeshabilitar", cnn, tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(CreateParams.Int("IdCliente", idCliente));

                    cmd.ExecuteNonQuery(); 
                    
                    tran.Commit();
                    cmd.Connection.Close();
                    cmd.Dispose();
                }
                catch (Exception e)
                {
                    tran.Rollback();
                    cmd.Connection.Close();
                    cmd.Dispose();
                    throw e;
                }
            }
        }

        public async Task<Cliente> BuscarPorIdCliente(int idCliente)
        {
            var cmd = (SqlCommand)null;
            var cliente = (Cliente)null;
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spClienteBuscarPorIdCliente", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(CreateParams.Int("IdCliente", idCliente));
                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    cliente = await ReadEntidad(dr);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }

            return cliente;
        }

        public async Task<Cliente> BuscarPorDocumentoIdentidad(short idTipoDocumentoIdentidad, string numeroDocumentoIdentidad)
        {
            var cmd = (SqlCommand)null;
            var cliente = (Cliente)null;
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spClienteBuscarPorDocumentoIdentidad", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(CreateParams.TinyInt("IdTipoDocumentoIdentidad", idTipoDocumentoIdentidad));
                cmd.Parameters.Add(CreateParams.NVarchar("NumeroDocumentoIdentidad", numeroDocumentoIdentidad, 20));
                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    cliente = await ReadEntidad(dr);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }

            return cliente;
        }

        public async Task<List<Cliente>> BusquedaGeneral(short? idTipoDocumentoIdentidad, string numeroDocumentoIdentidad, string rasonSocial, string nombres, string apellido1, string apellido2)
        {
            var cmd = (SqlCommand)null;
            var listaClientes = new List<Cliente>();
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spClienteBusquedaGeneral", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(CreateParams.TinyInt("idTipoDocumentoIdentidad", idTipoDocumentoIdentidad));
                cmd.Parameters.Add(CreateParams.NVarchar("numeroDocumentoIdentidad", numeroDocumentoIdentidad, 20));
                cmd.Parameters.Add(CreateParams.NVarchar("RazonSocial", rasonSocial, 250));
                cmd.Parameters.Add(CreateParams.NVarchar("Nombres", nombres, 100));
                cmd.Parameters.Add(CreateParams.NVarchar("Apellido1", apellido1, 50));
                cmd.Parameters.Add(CreateParams.NVarchar("Apellido2", apellido2, 50));
                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    var cliente = await ReadEntidad(dr);
                    listaClientes.Add(cliente);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }

            return listaClientes;
        }

        private async Task<Cliente> ReadEntidad(SqlDataReader dr, bool traerContraseña = false)
        {
            try
            {
                var obj = new Cliente();
                obj.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                obj.IdTipoDocumentoIdentidad = Convert.ToInt16(dr["IdTipoDocumentoIdentidad"]);
                obj.NumeroDocumentoIdentidad = dr["NumeroDocumentoIdentidad"].ToString();
                if (!(await dr.IsDBNullAsync(dr.GetOrdinal("RazonSocial")))) obj.RazonSocial = dr["RazonSocial"].ToString();
                if (!(await dr.IsDBNullAsync(dr.GetOrdinal("Nombres")))) obj.Nombres = dr["Nombres"].ToString();
                if (!(await dr.IsDBNullAsync(dr.GetOrdinal("Apellido1")))) obj.Apellido1 = dr["Apellido1"].ToString();
                if (!(await dr.IsDBNullAsync(dr.GetOrdinal("Apellido2")))) obj.Apellido2 = dr["Apellido2"].ToString();
                if (!(await dr.IsDBNullAsync(dr.GetOrdinal("Celular")))) obj.Celular = dr["Celular"].ToString();
                if (!(await dr.IsDBNullAsync(dr.GetOrdinal("Email")))) obj.Email = dr["Email"].ToString();
                obj.Activo = Convert.ToBoolean(dr["Activo"]);

                return obj;

            }
            catch(Exception ex)
            {
                dr.Close();
                throw ex;
            }
        }
        #endregion métodos
    }
}
