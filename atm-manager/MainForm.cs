using System.Data.SqlClient;
using System.Runtime.InteropServices;
using atm_manager.Database;

namespace atm_manager
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
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter
                {
                    ParameterName = "@NUMBER",
                    Value = input_banks_search.Text
                }
            };

            Search.SetGridContent(datagrid_atms, "EXEC GetAtms @NUMBER", parameters);
        }

        private void Input_accounts_search_TextChanged(object? sender, EventArgs e)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter {ParameterName = "@NUMBER", Value = input_accounts_search.Text}
            };

            Search.SetGridContent(data_accounts, "EXEC AccountGet @NUMBER", parameters);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            datagrid_atms.Columns.Add("AtmsData_Tab_ID", "Номер");
            datagrid_atms.Columns.Add("AtmsData_Tab_SerialNumber", "Серийный номер банкомата");
            datagrid_atms.Columns.Add("AtmsData_Tab_Bank", "Принадлежит банку №");

            Input_accounts_search_TextChanged(sender, e);
            Input_banks_search_TextChanged(sender, e);
        }

        private bool WhileLoad = false;
        private void data_accounts_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!WhileLoad)
            {
                WhileLoad = true;
                return;
            }

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter {ParameterName = "@NUMBER", Value = data_accounts.CurrentRow.Cells[0].Value}
            };

            Search.SetGridContent(data_transaction, "EXEC TransactionByPerson @NUMBER", parameters);
        }
    }
}



