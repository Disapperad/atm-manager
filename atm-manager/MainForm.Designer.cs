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
            this.tabPage_transaction = new System.Windows.Forms.TabPage();
            this.data_transaction = new System.Windows.Forms.DataGridView();
            this.TransactionData_Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionData_To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionData_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionData_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionData_From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionData_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Button_Operations_Add = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_accounts = new System.Windows.Forms.TabPage();
            this.Data_Accounts = new System.Windows.Forms.DataGridView();
            this.AccountsData_Tab_Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountsData_Tab_PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountsData_Tab_AccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountsData_Tab_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_Accounts_AddAccount = new System.Windows.Forms.Button();
            this.Button_Accounts_Remove = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.GroupBox_MoneySelect = new System.Windows.Forms.GroupBox();
            this.Account_Radio_CashR = new System.Windows.Forms.RadioButton();
            this.Account_Radio_CashM = new System.Windows.Forms.RadioButton();
            this.Account_Radio_CashB = new System.Windows.Forms.RadioButton();
            this.Accounts_Search_TextBox_Cash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Accounts_Search_TextBox_Account = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Accounts_Search_TextBox_FIO = new System.Windows.Forms.TextBox();
            this.Button_SearchAccounts = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_transaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_transaction)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabPage_accounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Accounts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.GroupBox_MoneySelect.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage_transaction
            // 
            this.tabPage_transaction.Controls.Add(this.groupBox4);
            this.tabPage_transaction.Controls.Add(this.groupBox3);
            this.tabPage_transaction.Controls.Add(this.groupBox2);
            this.tabPage_transaction.Controls.Add(this.data_transaction);
            this.tabPage_transaction.Location = new System.Drawing.Point(4, 29);
            this.tabPage_transaction.Name = "tabPage_transaction";
            this.tabPage_transaction.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_transaction.Size = new System.Drawing.Size(1301, 757);
            this.tabPage_transaction.TabIndex = 3;
            this.tabPage_transaction.Text = "Операции";
            this.tabPage_transaction.UseVisualStyleBackColor = true;
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
            this.TransactionData_Cash});
            this.data_transaction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.data_transaction.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data_transaction.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.data_transaction.Location = new System.Drawing.Point(6, 6);
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
            this.data_transaction.Size = new System.Drawing.Size(1287, 381);
            this.data_transaction.TabIndex = 5;
            // 
            // TransactionData_Cash
            // 
            this.TransactionData_Cash.HeaderText = "Количество денег (Руб.)";
            this.TransactionData_Cash.MinimumWidth = 6;
            this.TransactionData_Cash.Name = "TransactionData_Cash";
            this.TransactionData_Cash.ReadOnly = true;
            // 
            // TransactionData_To
            // 
            this.TransactionData_To.HeaderText = "Кому";
            this.TransactionData_To.MinimumWidth = 6;
            this.TransactionData_To.Name = "TransactionData_To";
            this.TransactionData_To.ReadOnly = true;
            // 
            // TransactionData_Type
            // 
            this.TransactionData_Type.HeaderText = "Тип транзакции";
            this.TransactionData_Type.MinimumWidth = 6;
            this.TransactionData_Type.Name = "TransactionData_Type";
            this.TransactionData_Type.ReadOnly = true;
            // 
            // TransactionData_Time
            // 
            this.TransactionData_Time.HeaderText = "Дата/Время";
            this.TransactionData_Time.MinimumWidth = 6;
            this.TransactionData_Time.Name = "TransactionData_Time";
            this.TransactionData_Time.ReadOnly = true;
            // 
            // TransactionData_From
            // 
            this.TransactionData_From.HeaderText = "От кого";
            this.TransactionData_From.MinimumWidth = 6;
            this.TransactionData_From.Name = "TransactionData_From";
            this.TransactionData_From.ReadOnly = true;
            // 
            // TransactionData_ID
            // 
            this.TransactionData_ID.HeaderText = "Номер транзакции";
            this.TransactionData_ID.MinimumWidth = 6;
            this.TransactionData_ID.Name = "TransactionData_ID";
            this.TransactionData_ID.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Button_Operations_Add);
            this.groupBox2.Location = new System.Drawing.Point(8, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 66);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Работа с транзакциями";
            // 
            // Button_Operations_Add
            // 
            this.Button_Operations_Add.Location = new System.Drawing.Point(6, 26);
            this.Button_Operations_Add.Name = "Button_Operations_Add";
            this.Button_Operations_Add.Size = new System.Drawing.Size(238, 29);
            this.Button_Operations_Add.TabIndex = 6;
            this.Button_Operations_Add.Text = "Добавить";
            this.Button_Operations_Add.UseVisualStyleBackColor = true;
            this.Button_Operations_Add.Click += new System.EventHandler(this.Button_Operations_Add_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Location = new System.Drawing.Point(264, 393);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 94);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск на основании выбранной";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 55);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(337, 29);
            this.button7.TabIndex = 10;
            this.button7.Text = "Найти получателя";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(337, 29);
            this.button6.TabIndex = 9;
            this.button6.Text = "Найти отправителя";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.trackBar1);
            this.groupBox4.Controls.Add(this.tabControl1);
            this.groupBox4.Location = new System.Drawing.Point(621, 393);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(672, 320);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поиск транзакций";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(6, 117);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 185);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(650, 152);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Количеству денежных средств";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(650, 152);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "По дате";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(650, 152);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "По отправителю";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(650, 152);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "По номеру";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 55);
            this.trackBar1.Maximum = 75;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(654, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Будет получено записей: 25";
            // 
            // tabPage_accounts
            // 
            this.tabPage_accounts.Controls.Add(this.groupBox5);
            this.tabPage_accounts.Controls.Add(this.groupBox1);
            this.tabPage_accounts.Controls.Add(this.Data_Accounts);
            this.tabPage_accounts.Location = new System.Drawing.Point(4, 29);
            this.tabPage_accounts.Name = "tabPage_accounts";
            this.tabPage_accounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_accounts.Size = new System.Drawing.Size(1301, 757);
            this.tabPage_accounts.TabIndex = 0;
            this.tabPage_accounts.Text = "Счета пользователей";
            this.tabPage_accounts.UseVisualStyleBackColor = true;
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
            this.Data_Accounts.Size = new System.Drawing.Size(906, 381);
            this.Data_Accounts.TabIndex = 0;
            // 
            // AccountsData_Tab_Cash
            // 
            this.AccountsData_Tab_Cash.HeaderText = "Деньги на счету (Руб.)";
            this.AccountsData_Tab_Cash.MinimumWidth = 6;
            this.AccountsData_Tab_Cash.Name = "AccountsData_Tab_Cash";
            this.AccountsData_Tab_Cash.ReadOnly = true;
            // 
            // AccountsData_Tab_PersonName
            // 
            this.AccountsData_Tab_PersonName.HeaderText = "Имя Фамилия Отчество";
            this.AccountsData_Tab_PersonName.MinimumWidth = 6;
            this.AccountsData_Tab_PersonName.Name = "AccountsData_Tab_PersonName";
            this.AccountsData_Tab_PersonName.ReadOnly = true;
            // 
            // AccountsData_Tab_AccountID
            // 
            this.AccountsData_Tab_AccountID.HeaderText = "Номер счёта";
            this.AccountsData_Tab_AccountID.MinimumWidth = 6;
            this.AccountsData_Tab_AccountID.Name = "AccountsData_Tab_AccountID";
            this.AccountsData_Tab_AccountID.ReadOnly = true;
            // 
            // AccountsData_Tab_ID
            // 
            this.AccountsData_Tab_ID.HeaderText = "Номер";
            this.AccountsData_Tab_ID.MinimumWidth = 6;
            this.AccountsData_Tab_ID.Name = "AccountsData_Tab_ID";
            this.AccountsData_Tab_ID.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_Accounts_Remove);
            this.groupBox1.Controls.Add(this.Button_Accounts_AddAccount);
            this.groupBox1.Location = new System.Drawing.Point(8, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 99);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работа со счетами";
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
            // Button_Accounts_Remove
            // 
            this.Button_Accounts_Remove.Location = new System.Drawing.Point(6, 61);
            this.Button_Accounts_Remove.Name = "Button_Accounts_Remove";
            this.Button_Accounts_Remove.Size = new System.Drawing.Size(529, 29);
            this.Button_Accounts_Remove.TabIndex = 2;
            this.Button_Accounts_Remove.Text = "Удалить запись";
            this.Button_Accounts_Remove.UseVisualStyleBackColor = true;
            this.Button_Accounts_Remove.Click += new System.EventHandler(this.Button_Accounts_Remove_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Button_SearchAccounts);
            this.groupBox5.Controls.Add(this.Accounts_Search_TextBox_FIO);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.Accounts_Search_TextBox_Account);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.GroupBox_MoneySelect);
            this.groupBox5.Location = new System.Drawing.Point(912, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(381, 381);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Тип поиска";
            // 
            // GroupBox_MoneySelect
            // 
            this.GroupBox_MoneySelect.Controls.Add(this.Accounts_Search_TextBox_Cash);
            this.GroupBox_MoneySelect.Controls.Add(this.Account_Radio_CashB);
            this.GroupBox_MoneySelect.Controls.Add(this.Account_Radio_CashM);
            this.GroupBox_MoneySelect.Controls.Add(this.Account_Radio_CashR);
            this.GroupBox_MoneySelect.Location = new System.Drawing.Point(6, 135);
            this.GroupBox_MoneySelect.Name = "GroupBox_MoneySelect";
            this.GroupBox_MoneySelect.Size = new System.Drawing.Size(363, 155);
            this.GroupBox_MoneySelect.TabIndex = 9;
            this.GroupBox_MoneySelect.TabStop = false;
            this.GroupBox_MoneySelect.Text = "Денежные средства";
            // 
            // Account_Radio_CashR
            // 
            this.Account_Radio_CashR.AutoSize = true;
            this.Account_Radio_CashR.Location = new System.Drawing.Point(6, 63);
            this.Account_Radio_CashR.Name = "Account_Radio_CashR";
            this.Account_Radio_CashR.Size = new System.Drawing.Size(174, 24);
            this.Account_Radio_CashR.TabIndex = 7;
            this.Account_Radio_CashR.TabStop = true;
            this.Account_Radio_CashR.Text = "= Денежных средств";
            this.Account_Radio_CashR.UseVisualStyleBackColor = true;
            // 
            // Account_Radio_CashM
            // 
            this.Account_Radio_CashM.AutoSize = true;
            this.Account_Radio_CashM.Location = new System.Drawing.Point(6, 123);
            this.Account_Radio_CashM.Name = "Account_Radio_CashM";
            this.Account_Radio_CashM.Size = new System.Drawing.Size(174, 24);
            this.Account_Radio_CashM.TabIndex = 9;
            this.Account_Radio_CashM.TabStop = true;
            this.Account_Radio_CashM.Text = "< Денежных средств";
            this.Account_Radio_CashM.UseVisualStyleBackColor = true;
            // 
            // Account_Radio_CashB
            // 
            this.Account_Radio_CashB.AutoSize = true;
            this.Account_Radio_CashB.Location = new System.Drawing.Point(6, 93);
            this.Account_Radio_CashB.Name = "Account_Radio_CashB";
            this.Account_Radio_CashB.Size = new System.Drawing.Size(174, 24);
            this.Account_Radio_CashB.TabIndex = 8;
            this.Account_Radio_CashB.TabStop = true;
            this.Account_Radio_CashB.Text = "> Денежных средств";
            this.Account_Radio_CashB.UseVisualStyleBackColor = true;
            // 
            // Accounts_Search_TextBox_Cash
            // 
            this.Accounts_Search_TextBox_Cash.Location = new System.Drawing.Point(6, 26);
            this.Accounts_Search_TextBox_Cash.Name = "Accounts_Search_TextBox_Cash";
            this.Accounts_Search_TextBox_Cash.Size = new System.Drawing.Size(351, 27);
            this.Accounts_Search_TextBox_Cash.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Номер счёта";
            // 
            // Accounts_Search_TextBox_Account
            // 
            this.Accounts_Search_TextBox_Account.Location = new System.Drawing.Point(6, 46);
            this.Accounts_Search_TextBox_Account.Name = "Accounts_Search_TextBox_Account";
            this.Accounts_Search_TextBox_Account.Size = new System.Drawing.Size(363, 27);
            this.Accounts_Search_TextBox_Account.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "ФИО";
            // 
            // Accounts_Search_TextBox_FIO
            // 
            this.Accounts_Search_TextBox_FIO.Location = new System.Drawing.Point(6, 102);
            this.Accounts_Search_TextBox_FIO.Name = "Accounts_Search_TextBox_FIO";
            this.Accounts_Search_TextBox_FIO.Size = new System.Drawing.Size(363, 27);
            this.Accounts_Search_TextBox_FIO.TabIndex = 13;
            // 
            // Button_SearchAccounts
            // 
            this.Button_SearchAccounts.Location = new System.Drawing.Point(6, 296);
            this.Button_SearchAccounts.Name = "Button_SearchAccounts";
            this.Button_SearchAccounts.Size = new System.Drawing.Size(363, 29);
            this.Button_SearchAccounts.TabIndex = 14;
            this.Button_SearchAccounts.Text = "Выполнить поиск";
            this.Button_SearchAccounts.UseVisualStyleBackColor = true;
            this.Button_SearchAccounts.Click += new System.EventHandler(this.Button_SearchAccounts_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_accounts);
            this.tabControl.Controls.Add(this.tabPage_transaction);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1309, 790);
            this.tabControl.TabIndex = 0;
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
            this.tabPage_transaction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_transaction)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabPage_accounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Accounts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.GroupBox_MoneySelect.ResumeLayout(false);
            this.GroupBox_MoneySelect.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage_transaction;
        private GroupBox groupBox4;
        private Label label1;
        private TrackBar trackBar1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private GroupBox groupBox3;
        private Button button6;
        private Button button7;
        private GroupBox groupBox2;
        private Button Button_Operations_Add;
        private DataGridView data_transaction;
        private DataGridViewTextBoxColumn TransactionData_ID;
        private DataGridViewTextBoxColumn TransactionData_From;
        private DataGridViewTextBoxColumn TransactionData_Time;
        private DataGridViewTextBoxColumn TransactionData_Type;
        private DataGridViewTextBoxColumn TransactionData_To;
        private DataGridViewTextBoxColumn TransactionData_Cash;
        private TabPage tabPage_accounts;
        private GroupBox groupBox5;
        private Button Button_SearchAccounts;
        private TextBox Accounts_Search_TextBox_FIO;
        private Label label3;
        private TextBox Accounts_Search_TextBox_Account;
        private Label label2;
        private GroupBox GroupBox_MoneySelect;
        private TextBox Accounts_Search_TextBox_Cash;
        private RadioButton Account_Radio_CashB;
        private RadioButton Account_Radio_CashM;
        private RadioButton Account_Radio_CashR;
        private GroupBox groupBox1;
        private Button Button_Accounts_Remove;
        private Button Button_Accounts_AddAccount;
        public DataGridView Data_Accounts;
        private DataGridViewTextBoxColumn AccountsData_Tab_ID;
        private DataGridViewTextBoxColumn AccountsData_Tab_AccountID;
        private DataGridViewTextBoxColumn AccountsData_Tab_PersonName;
        private DataGridViewTextBoxColumn AccountsData_Tab_Cash;
        private TabControl tabControl;
    }
}