using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace atm_manager.Database
{
    internal static class Search
    {
        public static void SetGridContent(DataGridView Grid, string CommandText, List<SqlParameter> ParametrList)
        {
            Grid.Rows.Clear();

            using (SqlConnection Connection = new(@"Server=server-sql1\Students; Integrated Security=true; Database=FedotovPractice"))
            {
                SqlCommand Command = new SqlCommand(CommandText, Connection);

                foreach (SqlParameter param in ParametrList)
                {
                    Command.Parameters.Add(param);
                }

                Connection.Open();

                using (SqlDataReader Reader = Command.ExecuteReader())
                {
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
    }
}
