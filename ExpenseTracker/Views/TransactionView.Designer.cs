namespace ExpenseTracker.Views
{
    partial class TransactionView
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
            radioButtonAll = new RadioButton();
            checkBoxUseDate = new CheckBox();
            comboBoxCategory = new ComboBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            radioButtonExpense = new RadioButton();
            radioButtonIncome = new RadioButton();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridViewTransactions = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(radioButtonAll);
            panel1.Controls.Add(checkBoxUseDate);
            panel1.Controls.Add(comboBoxCategory);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(radioButtonExpense);
            panel1.Controls.Add(radioButtonIncome);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridViewTransactions);
            panel1.Location = new Point(34, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(1212, 658);
            panel1.TabIndex = 2;
            // 
            // radioButtonAll
            // 
            radioButtonAll.AutoSize = true;
            radioButtonAll.Location = new Point(14, 45);
            radioButtonAll.Name = "radioButtonAll";
            radioButtonAll.Size = new Size(76, 19);
            radioButtonAll.TabIndex = 12;
            radioButtonAll.TabStop = true;
            radioButtonAll.Text = "Wszystkie";
            radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseDate
            // 
            checkBoxUseDate.AutoSize = true;
            checkBoxUseDate.Location = new Point(887, 31);
            checkBoxUseDate.Name = "checkBoxUseDate";
            checkBoxUseDate.Size = new Size(104, 19);
            checkBoxUseDate.TabIndex = 11;
            checkBoxUseDate.Text = "Filtruj po dacie";
            checkBoxUseDate.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(688, 29);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(170, 23);
            comboBoxCategory.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(560, 35);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 9;
            label4.Text = "Wyszukaj po kategorii";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(997, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(202, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // radioButtonExpense
            // 
            radioButtonExpense.AutoSize = true;
            radioButtonExpense.Location = new Point(182, 45);
            radioButtonExpense.Name = "radioButtonExpense";
            radioButtonExpense.Size = new Size(68, 19);
            radioButtonExpense.TabIndex = 5;
            radioButtonExpense.TabStop = true;
            radioButtonExpense.Text = "Wydatki";
            radioButtonExpense.UseVisualStyleBackColor = true;
            // 
            // radioButtonIncome
            // 
            radioButtonIncome.AutoSize = true;
            radioButtonIncome.Location = new Point(96, 45);
            radioButtonIncome.Name = "radioButtonIncome";
            radioButtonIncome.Size = new Size(80, 19);
            radioButtonIncome.TabIndex = 4;
            radioButtonIncome.TabStop = true;
            radioButtonIncome.Text = "Przychody";
            radioButtonIncome.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 35);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 3;
            label2.Text = "Wyszukaj po opisie";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(369, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 10);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 1;
            label1.Text = "Lista transakcji";
            // 
            // dataGridViewTransactions
            // 
            dataGridViewTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTransactions.BackgroundColor = Color.Gainsboro;
            dataGridViewTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransactions.Location = new Point(31, 70);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.Size = new Size(1168, 585);
            dataGridViewTransactions.TabIndex = 0;
            // 
            // TransactionView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(panel1);
            Name = "TransactionView";
            Size = new Size(1249, 675);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridViewTransactions;
        private Label label2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButtonExpense;
        private RadioButton radioButtonIncome;
        private Label label4;
        private ComboBox comboBoxCategory;
        private CheckBox checkBoxUseDate;
        private RadioButton radioButtonAll;
    }
}
