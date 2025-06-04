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
            panel1.Location = new Point(39, 19);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1385, 877);
            panel1.TabIndex = 2;
            // 
            // radioButtonAll
            // 
            radioButtonAll.AutoSize = true;
            radioButtonAll.Location = new Point(16, 60);
            radioButtonAll.Margin = new Padding(3, 4, 3, 4);
            radioButtonAll.Name = "radioButtonAll";
            radioButtonAll.Size = new Size(94, 24);
            radioButtonAll.TabIndex = 12;
            radioButtonAll.TabStop = true;
            radioButtonAll.Text = "Wszystkie";
            radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseDate
            // 
            checkBoxUseDate.AutoSize = true;
            checkBoxUseDate.Location = new Point(1004, 43);
            checkBoxUseDate.Margin = new Padding(3, 4, 3, 4);
            checkBoxUseDate.Name = "checkBoxUseDate";
            checkBoxUseDate.Size = new Size(130, 24);
            checkBoxUseDate.TabIndex = 11;
            checkBoxUseDate.Text = "Filtruj po dacie";
            checkBoxUseDate.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(798, 39);
            comboBoxCategory.Margin = new Padding(3, 4, 3, 4);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(194, 28);
            comboBoxCategory.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(637, 46);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 9;
            label4.Text = "Wyszukaj po kategorii";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1140, 40);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // radioButtonExpense
            // 
            radioButtonExpense.AutoSize = true;
            radioButtonExpense.Location = new Point(208, 60);
            radioButtonExpense.Margin = new Padding(3, 4, 3, 4);
            radioButtonExpense.Name = "radioButtonExpense";
            radioButtonExpense.Size = new Size(84, 24);
            radioButtonExpense.TabIndex = 5;
            radioButtonExpense.TabStop = true;
            radioButtonExpense.Text = "Wydatki";
            radioButtonExpense.UseVisualStyleBackColor = true;
            // 
            // radioButtonIncome
            // 
            radioButtonIncome.AutoSize = true;
            radioButtonIncome.Location = new Point(110, 60);
            radioButtonIncome.Margin = new Padding(3, 4, 3, 4);
            radioButtonIncome.Name = "radioButtonIncome";
            radioButtonIncome.Size = new Size(97, 24);
            radioButtonIncome.TabIndex = 4;
            radioButtonIncome.TabStop = true;
            radioButtonIncome.Text = "Przychody";
            radioButtonIncome.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 47);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 3;
            label2.Text = "Wyszukaj po opisie";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(432, 42);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 27);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 13);
            label1.Name = "label1";
            label1.Size = new Size(183, 32);
            label1.TabIndex = 1;
            label1.Text = "Lista transakcji";
            // 
            // dataGridViewTransactions
            // 
            dataGridViewTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTransactions.BackgroundColor = Color.Gainsboro;
            dataGridViewTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransactions.Location = new Point(35, 93);
            dataGridViewTransactions.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.RowHeadersWidth = 51;
            dataGridViewTransactions.Size = new Size(1335, 780);
            dataGridViewTransactions.TabIndex = 0;
            // 
            // TransactionView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TransactionView";
            Size = new Size(1427, 900);
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
