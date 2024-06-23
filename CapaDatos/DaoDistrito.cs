﻿using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DaoDistrito
    {
        #region sigleton
        private static readonly DaoDistrito _instancia = new DaoDistrito();
        public static DaoDistrito Instancia { get { return _instancia; } }
        #endregion singleton

        #region métodos

        public async Task<Distrito> BuscarPorIdDistrito(int idDistrito)
        {
            var cmd = (SqlCommand)null;
            var Distrito = (Distrito)null;
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDistritoBuscarPorIdDistrito", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(CreateParams.Int("IdDistrito", idDistrito));
                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    Distrito = ReadEntidad(dr);
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

            return Distrito;
        }

        public async Task<List<Distrito>> BuscarPorProvincia(int idProvincia)
        {
            var cmd = (SqlCommand)null;
            var listaDistritos = new List<Distrito>();
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDistritoBuscarPorIdProvincia", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(CreateParams.Int("IdProvincia", idProvincia));
                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    var distrito = ReadEntidad(dr);
                    listaDistritos.Add(distrito);
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

            return listaDistritos;
        }

        public async Task<List<Distrito>> BuscarTodos()
        {
            var cmd = (SqlCommand)null;
            var listaDistritos = new List<Distrito>();
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDistritoBuscarTodos", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    var Distrito = ReadEntidad(dr);
                    listaDistritos.Add(Distrito);
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

            return listaDistritos;
        }

        private Distrito ReadEntidad(SqlDataReader dr)
        {
            try
            {
                var obj = new Distrito();
                obj.IdDistrito = Convert.ToInt32(dr["IdDistrito"]);
                obj.Nombre = Convert.ToString(dr["Nombre"]);
                obj.IdProvincia = Convert.ToInt32(dr["IdProvincia"]);                

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
