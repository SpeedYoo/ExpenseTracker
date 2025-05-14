namespace ExpenseTracker.Forms
{
    partial class AccountCreationForm
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
            txtName = new TextBox();
            txtDescription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            numInitialBalance = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numInitialBalance).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(92, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(209, 33);
            txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(90, 132);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(209, 33);
            txtDescription.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 70);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 2;
            label1.Text = "Nazwa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 132);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 3;
            label2.Text = "Opis";
            // 
            // numInitialBalance
            // 
            numInitialBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numInitialBalance.Location = new Point(90, 193);
            numInitialBalance.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numInitialBalance.Name = "numInitialBalance";
            numInitialBalance.Size = new Size(209, 33);
            numInitialBalance.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 193);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 5;
            label3.Text = "Balans";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SeaGreen;
            label4.Location = new Point(90, 9);
            label4.Name = "label4";
            label4.Size = new Size(154, 32);
            label4.TabIndex = 8;
            label4.Text = "Nowe konto";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SeaGreen;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(25, 287);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(289, 37);
            btnSave.TabIndex = 9;
            btnSave.Text = "Utwórz";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Ivory;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ControlText;
            btnCancel.Location = new Point(25, 340);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(289, 37);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // AccountCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 389);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numInitialBalance);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AccountCreationForm";
            Text = "AccountForm";
            ((System.ComponentModel.ISupportInitialize)numInitialBalance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtDescription;
        private Label label1;
        private Label label2;
        private NumericUpDown numInitialBalance;
        private Label label3;
        private Label label4;
        private Button btnSave;
        private Button btnCancel;
    }
}