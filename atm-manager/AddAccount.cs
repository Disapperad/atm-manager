using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATMManager.Database.Methods;
using ATMManager.Database.WorkWithCommands;
using System.Data.SqlClient;

namespace ATMManager
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void Button_Add_Account_Click(object sender, EventArgs e)
        {
            SqlParameter[] Parameters =
            {
                new SqlParameter { ParameterName = "@ACCOUNTNUMBER", Value = TextBox_Add_Accounts_Account.Text},
                new SqlParameter { ParameterName = "@PERSONNAME", Value = TextBox_Add_Accounts_Name.Text},
                new SqlParameter { ParameterName = "@CASH", Value = TextBox_Add_Accounts_Cash.Text },
                new SqlParameter { ParameterName = "@ID", Direction = ParameterDirection.Output, Value = 0}
            };

            (SqlCommand Command, int Count) = MethodList.AddRow(
                CommandsWorker.GetCommandsWithParameters("AddAccount", Parameters));

            foreach (var item in Command.Parameters)
            {
                Console.WriteLine(item);
            }

            CommandsWorker.UpdateGrid(Command, Count, (DataGridView)Owner.Controls.Find("Data_Accounts", true)[0],
                new string[] { TextBox_Add_Accounts_Account.Text, TextBox_Add_Accounts_Name.Text, TextBox_Add_Accounts_Cash.Text});
            
        }
    }
}
