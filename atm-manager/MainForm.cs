using System.Data.SqlClient;
using System.Runtime.InteropServices;
using ATMManager.Database.Search;
using ATMManager.Database.Methods;

namespace ATMManager
{
    public partial class MainForm : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public MainForm()
        {
            InitializeComponent();
            AllocConsole();
        }

        private void Button_Accounts_AddAccount_Click(object sender, EventArgs e)
        {
            new Accounts.Add().ShowDialog(this);
        }

        private void Button_Operations_Add_Click(object sender, EventArgs e)
        {
           
        }

        private void Button_Accounts_Remove_Click(object sender, EventArgs e)
        {
            new Accounts.Accounts_Remove().ShowDialog(this);
        }

        private void Button_SearchAccounts_Click(object sender, EventArgs e)
        {
            int ActionID = 0;

            RadioButton? CheckedRadioButton = null;

            if (Account_Radio_CashR.Checked)
                CheckedRadioButton = Account_Radio_CashR;
            else if (Account_Radio_CashM.Checked)
                CheckedRadioButton = Account_Radio_CashM;
            else if (Account_Radio_CashB.Checked)
                CheckedRadioButton = Account_Radio_CashB;

            if (CheckedRadioButton != null)
            {
                switch (CheckedRadioButton.Name.ToString())
                {
                    case "Account_Radio_CashR":
                        ActionID = 3;
                        break;
                    case "Account_Radio_CashB":
                        ActionID = 4;
                        break;
                    case "Account_Radio_CashM":
                        ActionID = 5;
                        break;
                }
            }

            if (ActionID > 2 && (Accounts_Search_TextBox_Cash.Text == string.Empty))
            {
                ActionID = 0;
            }

            SqlParameter[] Parameters =
            {
                new SqlParameter { ParameterName = "@Action", Value = ActionID},
                new SqlParameter { ParameterName = "@AccountNumber", Value = Accounts_Search_TextBox_Account.Text},
                new SqlParameter { ParameterName = "@FIO", Value = Accounts_Search_TextBox_FIO.Text},
                new SqlParameter { ParameterName = "@Cash", Value = Accounts_Search_TextBox_Cash.Text}
            };

            Search.SetGridContent(Data_Accounts, "SearchAccounts", Parameters);
        }
    }
}



