namespace ExpenseTracker.Views
{
    partial class ExpenseView
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
            label1 = new Label();
            ExpenseDataView = new DataGridView();
            panel2 = new Panel();
            update_btn = new Button();
            delete_btn = new Button();
            add_btn = new Button();
            dateTimePickerOccurredAt = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            txtDescription = new RichTextBox();
            comboBoxCategory = new ComboBox();
            label3 = new Label();
            AmoutField = new NumericUpDown();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExpenseDataView).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AmoutField).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ExpenseDataView);
            panel1.Location = new Point(30, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(1212, 300);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 17);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 1;
            label1.Text = "Lista wydatków";
            // 
            // ExpenseDataView
            // 
            ExpenseDataView.BackgroundColor = Color.Gainsboro;
            ExpenseDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExpenseDataView.Location = new Point(21, 59);
            ExpenseDataView.Name = "ExpenseDataView";
            ExpenseDataView.Size = new Size(1168, 229);
            ExpenseDataView.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(update_btn);
            panel2.Controls.Add(delete_btn);
            panel2.Controls.Add(add_btn);
            panel2.Controls.Add(dateTimePickerOccurredAt);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtDescription);
            panel2.Controls.Add(comboBoxCategory);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(AmoutField);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(30, 365);
            panel2.Name = "panel2";
            panel2.Size = new Size(1212, 271);
            panel2.TabIndex = 3;
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.SeaGreen;
            update_btn.FlatAppearance.BorderSize = 0;
            update_btn.FlatStyle = FlatStyle.Flat;
            update_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_btn.ForeColor = Color.White;
            update_btn.Location = new Point(752, 202);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(226, 37);
            update_btn.TabIndex = 11;
            update_btn.Text = "Modyfikuj";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.SeaGreen;
            delete_btn.FlatAppearance.BorderSize = 0;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.ForeColor = Color.White;
            delete_btn.Location = new Point(491, 202);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(226, 37);
            delete_btn.TabIndex = 10;
            delete_btn.Text = "Usuń";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.SeaGreen;
            add_btn.FlatAppearance.BorderSize = 0;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(233, 202);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(226, 37);
            add_btn.TabIndex = 9;
            add_btn.Text = "Dodaj";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // dateTimePickerOccurredAt
            // 
            dateTimePickerOccurredAt.Location = new Point(648, 104);
            dateTimePickerOccurredAt.Name = "dateTimePickerOccurredAt";
            dateTimePickerOccurredAt.Size = new Size(228, 23);
            dateTimePickerOccurredAt.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(556, 102);
            label5.Name = "label5";
            label5.Size = new Size(51, 25);
            label5.TabIndex = 7;
            label5.Text = "Data";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(556, 42);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 6;
            label4.Text = "Opis";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(648, 42);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(383, 41);
            txtDescription.TabIndex = 5;
            txtDescription.Text = "";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(139, 102);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(179, 23);
            comboBoxCategory.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 97);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 3;
            label3.Text = "Kategoria";
            // 
            // AmoutField
            // 
            AmoutField.BorderStyle = BorderStyle.None;
            AmoutField.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmoutField.Location = new Point(139, 43);
            AmoutField.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            AmoutField.Name = "AmoutField";
            AmoutField.Size = new Size(179, 29);
            AmoutField.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 43);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Kwota";
            // 
            // ExpenseView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "ExpenseView";
            Size = new Size(1280, 690);
            Load += ExpenseView_Load;
            VisibleChanged += ExpenseView_VisibleChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExpenseDataView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AmoutField).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView ExpenseDataView;
        private Panel panel2;
        private Button update_btn;
        private Button delete_btn;
        private Button add_btn;
        private DateTimePicker dateTimePickerOccurredAt;
        private Label label5;
        private Label label4;
        private RichTextBox txtDescription;
        private ComboBox comboBoxCategory;
        private Label label3;
        private NumericUpDown AmoutField;
        private Label label2;
    }
}
