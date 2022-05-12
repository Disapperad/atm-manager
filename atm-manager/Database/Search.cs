using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Collections.Specialized;
using ATMManager.Database.Methods;
using ATMManager.Database.WorkWithCommands;

namespace ATMManager.Database.Search
{
    internal static class Search
    {   
        public static void SetGridContent(DataGridView Grid, string CommandText, SqlParameter[] ParametrList)
        {
            Grid.Rows.Clear();

            using SqlConnection Connection = new(ConfigurationManager.AppSettings.Get("ConnectionString"));
            SqlCommand CurrentCommand = CommandsWorker.GetCommandsWithParameters(CommandText, ParametrList);
            CurrentCommand.Connection = Connection;

            Connection.Open();

            using SqlDataReader Reader = CurrentCommand.ExecuteReader();

            while (Reader.Read())
            {
                int RowIndex = Grid.Rows.Add();

                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    Grid.Rows[RowIndex].Cells[i].Value = Reader.GetValue(i);
                }
            }
        }
    }
}
