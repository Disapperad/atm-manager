using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Specialized;

namespace ATMManager.Database.Methods
{
    internal static class MethodList
    {
        public static SqlCommand GetCommandsWithParameters(in string CommandText, in SqlParameter[] Parameters)
        {
            SqlCommand Command = new(CommandText);

            Command.CommandType = System.Data.CommandType.StoredProcedure;

            foreach (SqlParameter Param in Parameters)
            {
                Command.Parameters.Add(Param);
            }

            return Command;
        }

        public static (SqlCommand, int) AddRow(SqlCommand Command)
        {
            using SqlConnection Connection = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
            Command.Connection = Connection;
            Connection.Open();

            return (Command, Command.ExecuteNonQuery());
        }

        public static int RemoveRow(SqlCommand Command)
        {
            using SqlConnection Connection = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
            Command.Connection = Connection;
            Connection.Open();

            return Command.ExecuteNonQuery();
        }

        public static int UpdateRow(SqlCommand Command)
        {
            using SqlConnection Connection = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
            Command.Connection = Connection;
            Connection.Open();

            return Command.ExecuteNonQuery();
        }
    }
}
