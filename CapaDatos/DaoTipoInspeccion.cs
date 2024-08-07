﻿using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DaoTipoInspeccion
    {
        #region sigleton
        private static readonly DaoTipoInspeccion _instancia = new DaoTipoInspeccion();
        public static DaoTipoInspeccion Instancia { get { return _instancia; } }
        #endregion singleton

        #region métodos
        public async Task<short> Insertar(TipoInspeccion TipoInspeccion)
        {
            var cmd = (SqlCommand)null;
            SqlConnection cnn = Conexion.Instancia.Conectar();
            await cnn.OpenAsync();
            using (var tran = cnn.BeginTransaction())
            { 
                try
                {
                    cmd = new SqlCommand("spTipoInspeccionInsertar", cnn, tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(CreateParams.NVarchar("Nombre", TipoInspeccion.Nombre, 50));
                    cmd.Parameters.Add(CreateParams.Decimal("Precio", TipoInspeccion.Precio, 10, 2));

                    TipoInspeccion.IdTipoInspeccion = Convert.ToInt16(await cmd.ExecuteScalarAsync());

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

            return TipoInspeccion.IdTipoInspeccion;
        }


        public async Task Actualizar(TipoInspeccion TipoInspeccion)
        {
            var cmd = (SqlCommand)null;
            SqlConnection cnn = Conexion.Instancia.Conectar();
            await cnn.OpenAsync();
            using (var tran = cnn.BeginTransaction())
            {
                try
                {
                    cmd = new SqlCommand("spTipoInspeccionActualizar", cnn, tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(CreateParams.SmallInt("IdTipoInspeccion", TipoInspeccion.IdTipoInspeccion));
                    cmd.Parameters.Add(CreateParams.NVarchar("Nombre", TipoInspeccion.Nombre, 50));
                    cmd.Parameters.Add(CreateParams.Decimal("Precio", TipoInspeccion.Precio, 10, 2));

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


        public async Task Deshabilitar(short idTipoInspeccion)
        {
            var cmd = (SqlCommand)null;
            SqlConnection cnn = Conexion.Instancia.Conectar();
            await cnn.OpenAsync();
            using (var tran = cnn.BeginTransaction())
            { 
                try
                {
                    cmd = new SqlCommand("spTipoInspeccionDeshabilitar", cnn, tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(CreateParams.SmallInt("IdTipoInspeccion", idTipoInspeccion));

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

        public async Task<TipoInspeccion> BuscarPorIdTipoInspeccion(short idTipoInspeccion)
        {
            var cmd = (SqlCommand)null;
            var TipoInspeccion = (TipoInspeccion)null;
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spTipoInspeccionBuscarPorIdTipoInspeccion", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(CreateParams.SmallInt("IdTipoInspeccion", idTipoInspeccion));
                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    TipoInspeccion = ReadEntidad(dr);
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

            return TipoInspeccion;
        }

        public async Task<List<TipoInspeccion>> ListarActivos()
        {
            var cmd = (SqlCommand)null;
            var listaTipoInspeccions = new List<TipoInspeccion>();
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spTipoInspeccionListarActivos", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    var TipoInspeccion = ReadEntidad(dr);
                    listaTipoInspeccions.Add(TipoInspeccion);
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

            return listaTipoInspeccions;
        }

        public async Task<List<TipoInspeccion>> ListarTodos()
        {
            var cmd = (SqlCommand)null;
            var listaTipoInspeccions = new List<TipoInspeccion>();
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spTipoInspeccionListarTodos", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    var TipoInspeccion = ReadEntidad(dr);
                    listaTipoInspeccions.Add(TipoInspeccion);
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

            return listaTipoInspeccions;
        }

        private TipoInspeccion ReadEntidad(SqlDataReader dr)
        {
            try
            {
                var obj = new TipoInspeccion();
                obj.IdTipoInspeccion = Convert.ToInt16(dr["IdTipoInspeccion"]);
                obj.Nombre = Convert.ToString(dr["Nombre"]);
                obj.Precio = Convert.ToDecimal(dr["Precio"]);
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
