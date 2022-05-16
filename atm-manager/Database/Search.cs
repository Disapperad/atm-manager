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

namespace ATMManager.Database.Search
{
    internal static class Search
    {   
        public static void SetGridContent(in DataGridView Grid, in string CommandText,
            in SqlParameter[]? ParameterList = null)
        {
            Grid.Rows.Clear();

            using SqlConnection Connection = new(ConfigurationManager.AppSettings.Get("ConnectionString"));

            SqlCommand CurrentCommand;

            if (ParameterList != null)
            {
                CurrentCommand = MethodList.GetCommandsWithParameters(CommandText, ParameterList);
            }
            else
            {
               CurrentCommand = new(CommandText, Connection);
            }
            
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
