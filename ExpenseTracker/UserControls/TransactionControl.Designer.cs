namespace ExpenseTracker.Views
{
    partial class TransactionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            radioIncome = new RadioButton();
            radioExpense = new RadioButton();
            txtDescription = new TextBox();
            dateTimePicker = new DateTimePicker();
            comboCategory = new ComboBox();
            txtAmount = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(radioIncome);
            panel1.Controls.Add(radioExpense);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(dateTimePicker);
            panel1.Controls.Add(comboCategory);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(29, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1220, 630);
            panel1.TabIndex = 0;
            // 
            // radioIncome
            // 
            radioIncome.AutoSize = true;
            radioIncome.Location = new Point(541, 221);
            radioIncome.Name = "radioIncome";
            radioIncome.Size = new Size(74, 19);
            radioIncome.TabIndex = 7;
            radioIncome.TabStop = true;
            radioIncome.Text = "Przychód";
            radioIncome.UseVisualStyleBackColor = true;
            // 
            // radioExpense
            // 
            radioExpense.AutoSize = true;
            radioExpense.Location = new Point(464, 221);
            radioExpense.Name = "radioExpense";
            radioExpense.Size = new Size(71, 19);
            radioExpense.TabIndex = 6;
            radioExpense.TabStop = true;
            radioExpense.Text = "Wydatek";
            radioExpense.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(464, 494);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(321, 33);
            txtDescription.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker.Location = new Point(463, 387);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(312, 33);
            dateTimePicker.TabIndex = 3;
            // 
            // comboCategory
            // 
            comboCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboCategory.FormattingEnabled = true;
            comboCategory.Location = new Point(464, 310);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(312, 33);
            comboCategory.TabIndex = 2;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(463, 127);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(312, 33);
            txtAmount.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(425, 0);
            label1.Name = "label1";
            label1.Size = new Size(417, 50);
            label1.TabIndex = 0;
            label1.Text = "Dodaj nową transakcje";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SeaGreen;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(504, 564);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(271, 40);
            btnSave.TabIndex = 8;
            btnSave.Text = "Dodaj";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(464, 99);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 9;
            label2.Text = "Kwota";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(462, 359);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 10;
            label3.Text = "Data";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(463, 457);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 11;
            label4.Text = "Opis";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(464, 193);
            label5.Name = "label5";
            label5.Size = new Size(126, 25);
            label5.TabIndex = 12;
            label5.Text = "Typ transakcji";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(463, 282);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 13;
            label6.Text = "Kategoria";
            // 
            // TransactionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "TransactionControl";
            Size = new Size(1280, 690);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtAmount;
        private ComboBox comboCategory;
        private DateTimePicker dateTimePicker;
        private TextBox txtDescription;
        private RadioButton radioIncome;
        private RadioButton radioExpense;
        private Button btnSave;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
