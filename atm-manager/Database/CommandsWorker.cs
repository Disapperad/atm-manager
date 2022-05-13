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

            Command.CommandType = System.Data.CommandType.StoredProcedure;

            foreach (SqlParameter Param in Parameters)
            {
                Command.Parameters.Add(Param);
            }

            return Command;
        }

        public static void UpdateGrid(SqlCommand Command, int Results, DataGridView Grid, string[] Parameters)
        {
            if (Results > 0)
            {
                int RowIndex = Grid.Rows.Add();

                Grid.Rows[RowIndex].Cells[0].Value = Command.Parameters["@ID"].Value;

                for (int i = 1; i < Grid.Columns.Count; i++)
                {
                    Grid.Rows[RowIndex].Cells[i].Value = Parameters[i - 1];
                }
            }
        }
    }
}
