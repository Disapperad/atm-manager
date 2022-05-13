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
using ATMManager.Database.Search;

namespace ATMManager
{
    public partial class Accounts_Add : Form
    {
        public Accounts_Add()
        {
            InitializeComponent();
        }

        private void Button_Add_Account_Click(object sender, EventArgs e)
        {
            SqlParameter[] Parameters =
            {
                new SqlParameter { ParameterName = "@ACCOUNTNUMBER", Value = TextBox_Add_Accounts_Account.Text},
                new SqlParameter { ParameterName = "@PERSONNAME", Value = TextBox_Add_Accounts_Name.Text},
                new SqlParameter { ParameterName = "@ID", Direction = ParameterDirection.Output, Value = 0}
            };
       
            MethodList.AddRow(CommandsWorker.GetCommandsWithParameters("AddAccount", Parameters));

            Search.SetGridContent((DataGridView)Owner.Controls.Find("Data_Accounts", true)[0], "AccountGet");
            /*
            CommandsWorker.UpdateGrid(Command, Count, (DataGridView)Owner.Controls.Find("Data_Accounts", true)[0],
                new string[] { TextBox_Add_Accounts_Account.Text, TextBox_Add_Accounts_Name.Text, "0"});
            */
        }
    }
}
