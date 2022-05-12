using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMManager.Database.WorkWithCommands
{
    internal static class CommandsWorker
    {
        public static SqlCommand GetCommandsWithParameters(string CommandText, SqlParameter[] Parameters)
        {
            SqlCommand Command = new(CommandText);

            foreach (SqlParameter Param in Parameters)
            {
                Command.Parameters.Add(Param);
            }

            return Command;
        }
    }
}
