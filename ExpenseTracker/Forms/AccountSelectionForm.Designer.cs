
namespace BudgetManagerApp
{
    partial class AccountSelectionForm
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
            btnProceed = new Button();
            btnNewAccount = new Button();
            label1 = new Label();
            cboAccounts = new ComboBox();
            SuspendLayout();
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.SeaGreen;
            btnProceed.FlatAppearance.BorderSize = 0;
            btnProceed.FlatStyle = FlatStyle.Flat;
            btnProceed.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProceed.ForeColor = Color.White;
            btnProceed.Location = new Point(43, 237);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(289, 37);
            btnProceed.TabIndex = 1;
            btnProceed.Text = "Dalej";
            btnProceed.UseVisualStyleBackColor = false;
            btnProceed.Click += btnProceed_Click;
            // 
            // btnNewAccount
            // 
            btnNewAccount.BackColor = Color.Ivory;
            btnNewAccount.FlatAppearance.BorderColor = Color.LimeGreen;
            btnNewAccount.FlatAppearance.BorderSize = 0;
            btnNewAccount.FlatStyle = FlatStyle.Flat;
            btnNewAccount.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewAccount.ForeColor = SystemColors.ControlText;
            btnNewAccount.Location = new Point(44, 301);
            btnNewAccount.Name = "btnNewAccount";
            btnNewAccount.Size = new Size(289, 37);
            btnNewAccount.TabIndex = 4;
            btnNewAccount.Text = "Utwórz nowe konto";
            btnNewAccount.UseVisualStyleBackColor = false;
            btnNewAccount.Click += btnNewAccount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(45, 24);
            label1.Name = "label1";
            label1.Size = new Size(279, 50);
            label1.TabIndex = 5;
            label1.Text = "Wybierz konto";
            // 
            // cboAccounts
            // 
            cboAccounts.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboAccounts.FormattingEnabled = true;
            cboAccounts.Location = new Point(45, 98);
            cboAccounts.Name = "cboAccounts";
            cboAccounts.Size = new Size(288, 38);
            cboAccounts.TabIndex = 6;
            // 
            // AccountSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(373, 386);
            Controls.Add(cboAccounts);
            Controls.Add(label1);
            Controls.Add(btnNewAccount);
            Controls.Add(btnProceed);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AccountSelectionForm";
            Text = "Logowanie";
            Load += AccountSelectionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion
        private Button btnProceed;
        private Button btnNewAccount;
        private Label label1;
        private ComboBox cboAccounts;
    }
}
