using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ATMManager.Database.Methods;

namespace ATMManager.Accounts
{
    public partial class Accounts_Remove : Form
    {
        public Accounts_Remove()
        {
            InitializeComponent();
        }

        private void Accounts_Remove_Load(object sender, EventArgs e)
        {
            DataGridView Grid = (DataGridView)Owner.Controls.Find("Data_Accounts", true)[0];
            TextBox_RemoveID.Text = Grid.CurrentRow.Cells[1].Value.ToString();
        }

        private void Button_Yes_Click(object sender, EventArgs e)
        {
            DataGridView Grid = (DataGridView)Owner.Controls.Find("Data_Accounts", true)[0];
            SqlParameter[] Parameters =
            {
                new SqlParameter { ParameterName = "@AccountID", Value = Grid.CurrentRow.Cells[0].Value},
            };

            int Success = MethodList.RemoveRow(MethodList.GetCommandsWithParameters("RemoveAccount", Parameters));

            if (Success > 0)
            {
                MessageBox.Show("Удаление выполнено!");
                Grid.Rows.Remove(Grid.CurrentRow);
                Close();
            }
            else
            {
                MessageBox.Show("Запись не найдена!");
                Close();
            }
        }
    }
}
