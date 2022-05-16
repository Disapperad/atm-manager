namespace ATMManager.Accounts
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBox_Add_Accounts_Name = new System.Windows.Forms.TextBox();
            this.TextBox_Add_Accounts_Account = new System.Windows.Forms.TextBox();
            this.Button_Add_Account = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBox_Add_Accounts_Name);
            this.groupBox1.Controls.Add(this.TextBox_Add_Accounts_Account);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод нового банковского счёта";
            // 
            // TextBox_Add_Accounts_Name
            // 
            this.TextBox_Add_Accounts_Name.Location = new System.Drawing.Point(6, 59);
            this.TextBox_Add_Accounts_Name.Name = "TextBox_Add_Accounts_Name";
            this.TextBox_Add_Accounts_Name.PlaceholderText = "Введите полное имя (Не более 50 символов) ";
            this.TextBox_Add_Accounts_Name.Size = new System.Drawing.Size(436, 27);
            this.TextBox_Add_Accounts_Name.TabIndex = 1;
            // 
            // TextBox_Add_Accounts_Account
            // 
            this.TextBox_Add_Accounts_Account.Location = new System.Drawing.Point(6, 26);
            this.TextBox_Add_Accounts_Account.MaxLength = 17;
            this.TextBox_Add_Accounts_Account.Name = "TextBox_Add_Accounts_Account";
            this.TextBox_Add_Accounts_Account.PlaceholderText = "Введите номер счёта (17 символов)";
            this.TextBox_Add_Accounts_Account.Size = new System.Drawing.Size(436, 27);
            this.TextBox_Add_Accounts_Account.TabIndex = 0;
            // 
            // Button_Add_Account
            // 
            this.Button_Add_Account.Location = new System.Drawing.Point(12, 112);
            this.Button_Add_Account.Name = "Button_Add_Account";
            this.Button_Add_Account.Size = new System.Drawing.Size(448, 35);
            this.Button_Add_Account.TabIndex = 1;
            this.Button_Add_Account.Text = "Добавить";
            this.Button_Add_Account.UseVisualStyleBackColor = true;
            this.Button_Add_Account.Click += new System.EventHandler(this.Button_Add_Account_Click);
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 158);
            this.Controls.Add(this.Button_Add_Account);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddAccount";
            this.Text = "Форма добавления банковских счетов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TextBox_Add_Accounts_Name;
        private TextBox TextBox_Add_Accounts_Account;
        private Button Button_Add_Account;
    }
}