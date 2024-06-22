﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public static class CreateParams
    {
        public static SqlParameter Int(string paramName, int? value)
        {
            var param = new SqlParameter($"@{paramName}", SqlDbType.Int);
            param.Value = value;
            if (value == null) param.Value = DBNull.Value;
            return param;
        }
        public static SqlParameter TinyInt(string paramName, short? value)
        {
            var param = new SqlParameter($"@{paramName}", SqlDbType.TinyInt);
            param.Value = value;
            if (value == null) param.Value = DBNull.Value;
            return param;
        }

        public static SqlParameter Bit(string paramName, bool? value)
        {
            var param = new SqlParameter($"@{paramName}", SqlDbType.Bit);
            param.Value = value;
            if (value == null) param.Value = DBNull.Value;
            return param;
        }

        public static SqlParameter NVarchar(string paramName, string value, int size)
        {
            var param = new SqlParameter($"@{paramName}", SqlDbType.NVarChar, size);
            param.Value = value;
            if (string.IsNullOrEmpty(value)) param.Value = DBNull.Value;
            return param;
        }
    }
}
