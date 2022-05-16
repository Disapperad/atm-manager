namespace ATMManager.Accounts
{
    partial class Accounts_Remove
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
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Yes = new System.Windows.Forms.Button();
            this.Button_No = new System.Windows.Forms.Button();
            this.TextBox_RemoveID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Подтвердите удаление указанного счёта:";
            // 
            // Button_Yes
            // 
            this.Button_Yes.Location = new System.Drawing.Point(12, 73);
            this.Button_Yes.Name = "Button_Yes";
            this.Button_Yes.Size = new System.Drawing.Size(163, 29);
            this.Button_Yes.TabIndex = 3;
            this.Button_Yes.Text = "Подтверждаю";
            this.Button_Yes.UseVisualStyleBackColor = true;
            this.Button_Yes.Click += new System.EventHandler(this.Button_Yes_Click);
            // 
            // Button_No
            // 
            this.Button_No.Location = new System.Drawing.Point(236, 71);
            this.Button_No.Name = "Button_No";
            this.Button_No.Size = new System.Drawing.Size(159, 29);
            this.Button_No.TabIndex = 4;
            this.Button_No.Text = "Отмена";
            this.Button_No.UseVisualStyleBackColor = true;
            // 
            // TextBox_RemoveID
            // 
            this.TextBox_RemoveID.Enabled = false;
            this.TextBox_RemoveID.Location = new System.Drawing.Point(12, 32);
            this.TextBox_RemoveID.Name = "TextBox_RemoveID";
            this.TextBox_RemoveID.Size = new System.Drawing.Size(383, 27);
            this.TextBox_RemoveID.TabIndex = 0;
            // 
            // Accounts_Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 112);
            this.Controls.Add(this.Button_No);
            this.Controls.Add(this.Button_Yes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_RemoveID);
            this.Name = "Accounts_Remove";
            this.Text = "Remove";
            this.Load += new System.EventHandler(this.Accounts_Remove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Button Button_Yes;
        private Button Button_No;
        private TextBox TextBox_RemoveID;
    }
}