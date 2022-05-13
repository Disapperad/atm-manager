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

            input_accounts_search.TextChanged += Input_accounts_search_TextChanged;
            input_banks_search.TextChanged += Input_banks_search_TextChanged;
        }

        private void Input_banks_search_TextChanged(object? sender, EventArgs e)
        {
            SqlParameter[] parameters = 
            {
                new SqlParameter { ParameterName = "@NUMBER", Value = input_banks_search.Text}
            };

            Search.SetGridContent(datagrid_atms, "GetAtms", parameters);
        }

        private void Input_accounts_search_TextChanged(object? sender, EventArgs e)
        {
            SqlParameter[] parameters = 
            {
                new SqlParameter {ParameterName = "@NUMBER", Value = input_accounts_search.Text}
            };

            Search.SetGridContent(Data_Accounts, "AccountGet", parameters);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Data_Accounts.ClearSelection();
            Input_accounts_search_TextChanged(sender, e);
           // Input_banks_search_TextChanged(sender, e);
        }

        private void Button_Accounts_AddAccount_Click(object sender, EventArgs e)
        {
            AddAccount Form = new AddAccount();
            Form.Owner = this;
            Form.ShowDialog(this);
        }
    }
}



