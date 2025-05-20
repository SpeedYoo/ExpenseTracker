namespace ExpenseTracker.Views
{
    partial class IncomeView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            label1 = new Label();
            IncomeDataView = new DataGridView();
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
            amountField = new NumericUpDown();
            label2 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IncomeDataView).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(chart1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(IncomeDataView);
            panel1.Location = new Point(30, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(1212, 300);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 17);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 1;
            label1.Text = "Lista Przychodów";
            // 
            // IncomeDataView
            // 
            IncomeDataView.BackgroundColor = Color.Gainsboro;
            IncomeDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IncomeDataView.Location = new Point(21, 59);
            IncomeDataView.Name = "IncomeDataView";
            IncomeDataView.Size = new Size(1168, 229);
            IncomeDataView.TabIndex = 0;
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
            panel2.Controls.Add(amountField);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(30, 365);
            panel2.Name = "panel2";
            panel2.Size = new Size(1212, 271);
            panel2.TabIndex = 1;
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
            // amountField
            // 
            amountField.BorderStyle = BorderStyle.None;
            amountField.DecimalPlaces = 2;
            amountField.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountField.Location = new Point(139, 43);
            amountField.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            amountField.Name = "amountField";
            amountField.Size = new Size(179, 29);
            amountField.TabIndex = 2;
            amountField.ThousandsSeparator = true;
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(339, 37);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(8, 8);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // IncomeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IncomeView";
            Size = new Size(1280, 690);
            Load += IncomeView_Load;
            VisibleChanged += IncomeView_VisibleChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IncomeDataView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amountField).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView IncomeDataView;
        private Panel panel2;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Label label3;
        private Button button3;
        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label4;
        private RichTextBox richTextBox1;
        private Button update_btn;
        private Button delete_btn;
        private Button add_btn;
        private NumericUpDown amountField;
        private ComboBox comboBoxCategory;
        private RichTextBox txtDescription;
        private DateTimePicker dateTimePickerOccurredAt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
