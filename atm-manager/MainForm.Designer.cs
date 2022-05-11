namespace atm_manager
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_accounts = new System.Windows.Forms.TabPage();
            this.input_accounts_search = new System.Windows.Forms.TextBox();
            this.button_select = new System.Windows.Forms.Button();
            this.data_accounts = new System.Windows.Forms.DataGridView();
            this.tabPage_atms = new System.Windows.Forms.TabPage();
            this.input_banks_search = new System.Windows.Forms.TextBox();
            this.datagrid_atms = new System.Windows.Forms.DataGridView();
            this.tabPage1_banks = new System.Windows.Forms.TabPage();
            this.tabPage_transaction = new System.Windows.Forms.TabPage();
            this.tabPage_tracsactiontypes = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPage_accounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_accounts)).BeginInit();
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
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(988, 528);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_accounts
            // 
            this.tabPage_accounts.Controls.Add(this.input_accounts_search);
            this.tabPage_accounts.Controls.Add(this.button_select);
            this.tabPage_accounts.Controls.Add(this.data_accounts);
            this.tabPage_accounts.Location = new System.Drawing.Point(4, 29);
            this.tabPage_accounts.Name = "tabPage_accounts";
            this.tabPage_accounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_accounts.Size = new System.Drawing.Size(980, 495);
            this.tabPage_accounts.TabIndex = 0;
            this.tabPage_accounts.Text = "Счета пользователей";
            this.tabPage_accounts.UseVisualStyleBackColor = true;
            // 
            // input_accounts_search
            // 
            this.input_accounts_search.Location = new System.Drawing.Point(6, 393);
            this.input_accounts_search.Name = "input_accounts_search";
            this.input_accounts_search.PlaceholderText = "Введите номер счёта";
            this.input_accounts_search.Size = new System.Drawing.Size(968, 27);
            this.input_accounts_search.TabIndex = 3;
            // 
            // button_select
            // 
            this.button_select.Location = new System.Drawing.Point(995, 6);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(249, 29);
            this.button_select.TabIndex = 1;
            this.button_select.Text = "Сбросить";
            this.button_select.UseVisualStyleBackColor = true;
            // 
            // data_accounts
            // 
            this.data_accounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_accounts.Location = new System.Drawing.Point(6, 6);
            this.data_accounts.Name = "data_accounts";
            this.data_accounts.RowHeadersWidth = 51;
            this.data_accounts.RowTemplate.Height = 29;
            this.data_accounts.Size = new System.Drawing.Size(968, 381);
            this.data_accounts.TabIndex = 0;
            // 
            // tabPage_atms
            // 
            this.tabPage_atms.Controls.Add(this.input_banks_search);
            this.tabPage_atms.Controls.Add(this.datagrid_atms);
            this.tabPage_atms.Location = new System.Drawing.Point(4, 29);
            this.tabPage_atms.Name = "tabPage_atms";
            this.tabPage_atms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_atms.Size = new System.Drawing.Size(980, 495);
            this.tabPage_atms.TabIndex = 1;
            this.tabPage_atms.Text = "Банкоматы";
            this.tabPage_atms.UseVisualStyleBackColor = true;
            // 
            // input_banks_search
            // 
            this.input_banks_search.Location = new System.Drawing.Point(3, 393);
            this.input_banks_search.Name = "input_banks_search";
            this.input_banks_search.PlaceholderText = "Введите серийный номер";
            this.input_banks_search.Size = new System.Drawing.Size(971, 27);
            this.input_banks_search.TabIndex = 6;
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
            // tabPage1_banks
            // 
            this.tabPage1_banks.Location = new System.Drawing.Point(4, 29);
            this.tabPage1_banks.Name = "tabPage1_banks";
            this.tabPage1_banks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1_banks.Size = new System.Drawing.Size(980, 495);
            this.tabPage1_banks.TabIndex = 2;
            this.tabPage1_banks.Text = "Банки";
            this.tabPage1_banks.UseVisualStyleBackColor = true;
            // 
            // tabPage_transaction
            // 
            this.tabPage_transaction.Location = new System.Drawing.Point(4, 29);
            this.tabPage_transaction.Name = "tabPage_transaction";
            this.tabPage_transaction.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_transaction.Size = new System.Drawing.Size(980, 495);
            this.tabPage_transaction.TabIndex = 3;
            this.tabPage_transaction.Text = "Операции";
            this.tabPage_transaction.UseVisualStyleBackColor = true;
            // 
            // tabPage_tracsactiontypes
            // 
            this.tabPage_tracsactiontypes.Location = new System.Drawing.Point(4, 29);
            this.tabPage_tracsactiontypes.Name = "tabPage_tracsactiontypes";
            this.tabPage_tracsactiontypes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tracsactiontypes.Size = new System.Drawing.Size(980, 495);
            this.tabPage_tracsactiontypes.TabIndex = 4;
            this.tabPage_tracsactiontypes.Text = "Типы операций";
            this.tabPage_tracsactiontypes.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 552);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage_accounts.ResumeLayout(false);
            this.tabPage_accounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_accounts)).EndInit();
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
        private Button button_select;
        private DataGridView data_accounts;
        private TextBox input_banks_search;
        private DataGridView datagrid_atms;
    }
}