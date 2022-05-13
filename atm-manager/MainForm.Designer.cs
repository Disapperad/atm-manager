namespace ATMManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_accounts = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Button_Accounts_AddAccount = new System.Windows.Forms.Button();
            this.combobox_transactionSelect = new System.Windows.Forms.ComboBox();
            this.input_transaction = new System.Windows.Forms.TextBox();
            this.data_transaction = new System.Windows.Forms.DataGridView();
            this.TransactionData_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionData_From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionData_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionData_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionData_To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionData_ATMNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionData_Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_accounts_search = new System.Windows.Forms.TextBox();
            this.Data_Accounts = new System.Windows.Forms.DataGridView();
            this.AccountsData_Tab_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountsData_Tab_AccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountsData_Tab_PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountsData_Tab_Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_atms = new System.Windows.Forms.TabPage();
            this.datagrid_atms = new System.Windows.Forms.DataGridView();
            this.input_banks_search = new System.Windows.Forms.TextBox();
            this.tabPage1_banks = new System.Windows.Forms.TabPage();
            this.tabPage_transaction = new System.Windows.Forms.TabPage();
            this.tabPage_tracsactiontypes = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPage_accounts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_transaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Accounts)).BeginInit();
            this.tabPage_atms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_atms)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_accounts);
            this.tabControl.Controls.Add(this.tabPage_atms);
            this.tabControl.Controls.Add(this.tabPage1_banks);
            this.tabControl.Controls.Add(this.tabPage_transaction);
            this.tabControl.Controls.Add(this.tabPage_tracsactiontypes);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1309, 790);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_accounts
            // 
            this.tabPage_accounts.Controls.Add(this.groupBox1);
            this.tabPage_accounts.Controls.Add(this.combobox_transactionSelect);
            this.tabPage_accounts.Controls.Add(this.input_transaction);
            this.tabPage_accounts.Controls.Add(this.data_transaction);
            this.tabPage_accounts.Controls.Add(this.input_accounts_search);
            this.tabPage_accounts.Controls.Add(this.Data_Accounts);
            this.tabPage_accounts.Location = new System.Drawing.Point(4, 29);
            this.tabPage_accounts.Name = "tabPage_accounts";
            this.tabPage_accounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_accounts.Size = new System.Drawing.Size(1301, 757);
            this.tabPage_accounts.TabIndex = 0;
            this.tabPage_accounts.Text = "Счета пользователей";
            this.tabPage_accounts.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Button_Accounts_AddAccount);
            this.groupBox1.Location = new System.Drawing.Point(8, 426);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 137);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работа со счетами";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(529, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить запись";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(529, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Изменить выбранный счёт";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Button_Accounts_AddAccount
            // 
            this.Button_Accounts_AddAccount.Location = new System.Drawing.Point(6, 26);
            this.Button_Accounts_AddAccount.Name = "Button_Accounts_AddAccount";
            this.Button_Accounts_AddAccount.Size = new System.Drawing.Size(529, 29);
            this.Button_Accounts_AddAccount.TabIndex = 0;
            this.Button_Accounts_AddAccount.Text = "Добавить счёт";
            this.Button_Accounts_AddAccount.UseVisualStyleBackColor = true;
            this.Button_Accounts_AddAccount.Click += new System.EventHandler(this.Button_Accounts_AddAccount_Click);
            // 
            // combobox_transactionSelect
            // 
            this.combobox_transactionSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_transactionSelect.FormattingEnabled = true;
            this.combobox_transactionSelect.Items.AddRange(new object[] {
            "Дата и время, когда была совершена операция",
            "Дата когда была совершена операция",
            "Количество денежных средств",
            "Кому пришли денежные средства",
            "Кто совершил операцию",
            "Номер банкомата",
            "Тип операции"});
            this.combobox_transactionSelect.Location = new System.Drawing.Point(555, 393);
            this.combobox_transactionSelect.Name = "combobox_transactionSelect";
            this.combobox_transactionSelect.Size = new System.Drawing.Size(738, 28);
            this.combobox_transactionSelect.TabIndex = 6;
            // 
            // input_transaction
            // 
            this.input_transaction.Location = new System.Drawing.Point(555, 425);
            this.input_transaction.Name = "input_transaction";
            this.input_transaction.PlaceholderText = "Введите условие поиска";
            this.input_transaction.Size = new System.Drawing.Size(738, 27);
            this.input_transaction.TabIndex = 5;
            // 
            // data_transaction
            // 
            this.data_transaction.AllowUserToAddRows = false;
            this.data_transaction.AllowUserToDeleteRows = false;
            this.data_transaction.AllowUserToResizeColumns = false;
            this.data_transaction.AllowUserToResizeRows = false;
            this.data_transaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_transaction.BackgroundColor = System.Drawing.SystemColors.Info;
            this.data_transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_transaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionData_ID,
            this.TransactionData_From,
            this.TransactionData_Time,
            this.TransactionData_Type,
            this.TransactionData_To,
            this.TransactionData_ATMNum,
            this.TransactionData_Cash});
            this.data_transaction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.data_transaction.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data_transaction.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.data_transaction.Location = new System.Drawing.Point(555, 6);
            this.data_transaction.MultiSelect = false;
            this.data_transaction.Name = "data_transaction";
            this.data_transaction.ReadOnly = true;
            this.data_transaction.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.data_transaction.RowHeadersVisible = false;
            this.data_transaction.RowHeadersWidth = 51;
            this.data_transaction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data_transaction.RowTemplate.Height = 29;
            this.data_transaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_transaction.ShowCellErrors = false;
            this.data_transaction.ShowCellToolTips = false;
            this.data_transaction.ShowEditingIcon = false;
            this.data_transaction.ShowRowErrors = false;
            this.data_transaction.Size = new System.Drawing.Size(738, 381);
            this.data_transaction.TabIndex = 4;
            // 
            // TransactionData_ID
            // 
            this.TransactionData_ID.HeaderText = "Номер транзакции";
            this.TransactionData_ID.MinimumWidth = 6;
            this.TransactionData_ID.Name = "TransactionData_ID";
            this.TransactionData_ID.ReadOnly = true;
            // 
            // TransactionData_From
            // 
            this.TransactionData_From.HeaderText = "От кого";
            this.TransactionData_From.MinimumWidth = 6;
            this.TransactionData_From.Name = "TransactionData_From";
            this.TransactionData_From.ReadOnly = true;
            // 
            // TransactionData_Time
            // 
            this.TransactionData_Time.HeaderText = "Дата/Время";
            this.TransactionData_Time.MinimumWidth = 6;
            this.TransactionData_Time.Name = "TransactionData_Time";
            this.TransactionData_Time.ReadOnly = true;
            // 
            // TransactionData_Type
            // 
            this.TransactionData_Type.HeaderText = "Тип транзакции";
            this.TransactionData_Type.MinimumWidth = 6;
            this.TransactionData_Type.Name = "TransactionData_Type";
            this.TransactionData_Type.ReadOnly = true;
            // 
            // TransactionData_To
            // 
            this.TransactionData_To.HeaderText = "Кому";
            this.TransactionData_To.MinimumWidth = 6;
            this.TransactionData_To.Name = "TransactionData_To";
            this.TransactionData_To.ReadOnly = true;
            // 
            // TransactionData_ATMNum
            // 
            this.TransactionData_ATMNum.HeaderText = "Номер банкомата";
            this.TransactionData_ATMNum.MinimumWidth = 6;
            this.TransactionData_ATMNum.Name = "TransactionData_ATMNum";
            this.TransactionData_ATMNum.ReadOnly = true;
            // 
            // TransactionData_Cash
            // 
            this.TransactionData_Cash.HeaderText = "Количество денег (Руб.)";
            this.TransactionData_Cash.MinimumWidth = 6;
            this.TransactionData_Cash.Name = "TransactionData_Cash";
            this.TransactionData_Cash.ReadOnly = true;
            // 
            // input_accounts_search
            // 
            this.input_accounts_search.Location = new System.Drawing.Point(6, 393);
            this.input_accounts_search.Name = "input_accounts_search";
            this.input_accounts_search.PlaceholderText = "Введите номер счёта";
            this.input_accounts_search.Size = new System.Drawing.Size(543, 27);
            this.input_accounts_search.TabIndex = 3;
            // 
            // Data_Accounts
            // 
            this.Data_Accounts.AllowUserToAddRows = false;
            this.Data_Accounts.AllowUserToDeleteRows = false;
            this.Data_Accounts.AllowUserToResizeRows = false;
            this.Data_Accounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_Accounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Data_Accounts.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_Accounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Data_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Accounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountsData_Tab_ID,
            this.AccountsData_Tab_AccountID,
            this.AccountsData_Tab_PersonName,
            this.AccountsData_Tab_Cash});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_Accounts.DefaultCellStyle = dataGridViewCellStyle2;
            this.Data_Accounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Data_Accounts.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Data_Accounts.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Data_Accounts.Location = new System.Drawing.Point(0, 6);
            this.Data_Accounts.MultiSelect = false;
            this.Data_Accounts.Name = "Data_Accounts";
            this.Data_Accounts.ReadOnly = true;
            this.Data_Accounts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_Accounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Data_Accounts.RowHeadersVisible = false;
            this.Data_Accounts.RowHeadersWidth = 51;
            this.Data_Accounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Data_Accounts.RowTemplate.Height = 29;
            this.Data_Accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data_Accounts.ShowCellErrors = false;
            this.Data_Accounts.ShowCellToolTips = false;
            this.Data_Accounts.ShowEditingIcon = false;
            this.Data_Accounts.ShowRowErrors = false;
            this.Data_Accounts.Size = new System.Drawing.Size(549, 381);
            this.Data_Accounts.TabIndex = 0;
            // 
            // AccountsData_Tab_ID
            // 
            this.AccountsData_Tab_ID.HeaderText = "Номер";
            this.AccountsData_Tab_ID.MinimumWidth = 6;
            this.AccountsData_Tab_ID.Name = "AccountsData_Tab_ID";
            this.AccountsData_Tab_ID.ReadOnly = true;
            // 
            // AccountsData_Tab_AccountID
            // 
            this.AccountsData_Tab_AccountID.HeaderText = "Номер счёта";
            this.AccountsData_Tab_AccountID.MinimumWidth = 6;
            this.AccountsData_Tab_AccountID.Name = "AccountsData_Tab_AccountID";
            this.AccountsData_Tab_AccountID.ReadOnly = true;
            // 
            // AccountsData_Tab_PersonName
            // 
            this.AccountsData_Tab_PersonName.HeaderText = "Имя Фамилия Отчество";
            this.AccountsData_Tab_PersonName.MinimumWidth = 6;
            this.AccountsData_Tab_PersonName.Name = "AccountsData_Tab_PersonName";
            this.AccountsData_Tab_PersonName.ReadOnly = true;
            // 
            // AccountsData_Tab_Cash
            // 
            this.AccountsData_Tab_Cash.HeaderText = "Деньги на счету (Руб.)";
            this.AccountsData_Tab_Cash.MinimumWidth = 6;
            this.AccountsData_Tab_Cash.Name = "AccountsData_Tab_Cash";
            this.AccountsData_Tab_Cash.ReadOnly = true;
            // 
            // tabPage_atms
            // 
            this.tabPage_atms.Controls.Add(this.datagrid_atms);
            this.tabPage_atms.Controls.Add(this.input_banks_search);
            this.tabPage_atms.Location = new System.Drawing.Point(4, 29);
            this.tabPage_atms.Name = "tabPage_atms";
            this.tabPage_atms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_atms.Size = new System.Drawing.Size(1301, 757);
            this.tabPage_atms.TabIndex = 1;
            this.tabPage_atms.Text = "Банкоматы";
            this.tabPage_atms.UseVisualStyleBackColor = true;
            // 
            // datagrid_atms
            // 
            this.datagrid_atms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_atms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_atms.Location = new System.Drawing.Point(3, 6);
            this.datagrid_atms.Name = "datagrid_atms";
            this.datagrid_atms.RowHeadersWidth = 51;
            this.datagrid_atms.RowTemplate.Height = 29;
            this.datagrid_atms.Size = new System.Drawing.Size(971, 381);
            this.datagrid_atms.TabIndex = 4;
            // 
            // input_banks_search
            // 
            this.input_banks_search.Location = new System.Drawing.Point(3, 393);
            this.input_banks_search.Name = "input_banks_search";
            this.input_banks_search.PlaceholderText = "Введите серийный номер";
            this.input_banks_search.Size = new System.Drawing.Size(971, 27);
            this.input_banks_search.TabIndex = 6;
            // 
            // tabPage1_banks
            // 
            this.tabPage1_banks.Location = new System.Drawing.Point(4, 29);
            this.tabPage1_banks.Name = "tabPage1_banks";
            this.tabPage1_banks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1_banks.Size = new System.Drawing.Size(1301, 757);
            this.tabPage1_banks.TabIndex = 2;
            this.tabPage1_banks.Text = "Банки";
            this.tabPage1_banks.UseVisualStyleBackColor = true;
            // 
            // tabPage_transaction
            // 
            this.tabPage_transaction.Location = new System.Drawing.Point(4, 29);
            this.tabPage_transaction.Name = "tabPage_transaction";
            this.tabPage_transaction.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_transaction.Size = new System.Drawing.Size(1301, 757);
            this.tabPage_transaction.TabIndex = 3;
            this.tabPage_transaction.Text = "Операции";
            this.tabPage_transaction.UseVisualStyleBackColor = true;
            // 
            // tabPage_tracsactiontypes
            // 
            this.tabPage_tracsactiontypes.Location = new System.Drawing.Point(4, 29);
            this.tabPage_tracsactiontypes.Name = "tabPage_tracsactiontypes";
            this.tabPage_tracsactiontypes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tracsactiontypes.Size = new System.Drawing.Size(1301, 757);
            this.tabPage_tracsactiontypes.TabIndex = 4;
            this.tabPage_tracsactiontypes.Text = "Типы операций";
            this.tabPage_tracsactiontypes.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 790);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage_accounts.ResumeLayout(false);
            this.tabPage_accounts.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_transaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Accounts)).EndInit();
            this.tabPage_atms.ResumeLayout(false);
            this.tabPage_atms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_atms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage_accounts;
        private TabPage tabPage_atms;
        private TabPage tabPage1_banks;
        private TabPage tabPage_transaction;
        private TabPage tabPage_tracsactiontypes;
        private TextBox input_accounts_search;
        private TextBox input_banks_search;
        private DataGridView datagrid_atms;
        private TextBox input_transaction;
        private DataGridView data_transaction;
        private ComboBox combobox_transactionSelect;
        private DataGridViewTextBoxColumn AccountsData_Tab_ID;
        private DataGridViewTextBoxColumn AccountsData_Tab_AccountID;
        private DataGridViewTextBoxColumn AccountsData_Tab_PersonName;
        private DataGridViewTextBoxColumn AccountsData_Tab_Cash;
        private DataGridViewTextBoxColumn TransactionData_ID;
        private DataGridViewTextBoxColumn TransactionData_From;
        private DataGridViewTextBoxColumn TransactionData_Time;
        private DataGridViewTextBoxColumn TransactionData_Type;
        private DataGridViewTextBoxColumn TransactionData_To;
        private DataGridViewTextBoxColumn TransactionData_ATMNum;
        private DataGridViewTextBoxColumn TransactionData_Cash;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button Button_Accounts_AddAccount;
        public DataGridView Data_Accounts;
    }
}