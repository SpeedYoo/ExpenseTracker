namespace ExpenseTracker.Views
{
    partial class DashboardView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            panel4 = new Panel();
            lblCurrent = new Label();
            label3 = new Label();
            panel3 = new Panel();
            lblIncomes = new Label();
            label2 = new Label();
            panel2 = new Panel();
            lblExpenses = new Label();
            label1 = new Label();
            chartIncomeExpense = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartExpenseByCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartIncomeExpense).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartExpenseByCategory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(32, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(1209, 206);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SeaGreen;
            panel4.Controls.Add(lblCurrent);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(863, 30);
            panel4.Name = "panel4";
            panel4.Size = new Size(273, 151);
            panel4.TabIndex = 2;
            // 
            // lblCurrent
            // 
            lblCurrent.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrent.ForeColor = Color.White;
            lblCurrent.Location = new Point(0, 61);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(273, 30);
            lblCurrent.TabIndex = 3;
            lblCurrent.Text = "0";
            lblCurrent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 26);
            label3.Name = "label3";
            label3.Size = new Size(270, 21);
            label3.TabIndex = 2;
            label3.Text = "Saldo";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaGreen;
            panel3.Controls.Add(lblIncomes);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(463, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(273, 151);
            panel3.TabIndex = 1;
            // 
            // lblIncomes
            // 
            lblIncomes.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIncomes.ForeColor = Color.White;
            lblIncomes.Location = new Point(3, 61);
            lblIncomes.Name = "lblIncomes";
            lblIncomes.Size = new Size(267, 30);
            lblIncomes.TabIndex = 2;
            lblIncomes.Text = "0";
            lblIncomes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 26);
            label2.Name = "label2";
            label2.Size = new Size(267, 21);
            label2.TabIndex = 1;
            label2.Text = "Całkowite przychód";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Controls.Add(lblExpenses);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(53, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 151);
            panel2.TabIndex = 0;
            // 
            // lblExpenses
            // 
            lblExpenses.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpenses.ForeColor = Color.White;
            lblExpenses.Location = new Point(3, 61);
            lblExpenses.Name = "lblExpenses";
            lblExpenses.Size = new Size(270, 30);
            lblExpenses.TabIndex = 1;
            lblExpenses.Text = "0";
            lblExpenses.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 26);
            label1.Name = "label1";
            label1.Size = new Size(267, 21);
            label1.TabIndex = 0;
            label1.Text = "Całkowite wydatki";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chartIncomeExpense
            // 
            chartArea1.Name = "Area1";
            chartIncomeExpense.ChartAreas.Add(chartArea1);
            legend1.Name = "L1";
            chartIncomeExpense.Legends.Add(legend1);
            chartIncomeExpense.Location = new Point(32, 308);
            chartIncomeExpense.Name = "chartIncomeExpense";
            series1.ChartArea = "Area1";
            series1.Legend = "L1";
            series1.Name = "Series1";
            chartIncomeExpense.Series.Add(series1);
            chartIncomeExpense.Size = new Size(559, 379);
            chartIncomeExpense.TabIndex = 1;
            chartIncomeExpense.Text = "chart1";
            // 
            // chartExpenseByCategory
            // 
            chartArea2.Name = "Area2";
            chartExpenseByCategory.ChartAreas.Add(chartArea2);
            legend2.Name = "L2";
            chartExpenseByCategory.Legends.Add(legend2);
            chartExpenseByCategory.Location = new Point(673, 308);
            chartExpenseByCategory.Name = "chartExpenseByCategory";
            series2.ChartArea = "Area2";
            series2.Legend = "L2";
            series2.Name = "Series1";
            chartExpenseByCategory.Series.Add(series2);
            chartExpenseByCategory.Size = new Size(568, 379);
            chartExpenseByCategory.TabIndex = 2;
            chartExpenseByCategory.Text = "chart2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SeaGreen;
            label4.Location = new Point(137, 275);
            label4.Name = "label4";
            label4.Size = new Size(332, 30);
            label4.TabIndex = 3;
            label4.Text = "Wykres przychodów i wydatków";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SeaGreen;
            label5.Location = new Point(790, 275);
            label5.Name = "label5";
            label5.Size = new Size(367, 30);
            label5.TabIndex = 4;
            label5.Text = "Wykres wydatków według kategorii";
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(chartExpenseByCategory);
            Controls.Add(chartIncomeExpense);
            Controls.Add(panel1);
            Name = "DashboardView";
            Size = new Size(1280, 690);
            Load += DashboardView_Load;
            VisibleChanged += DashboardView_VisibleChanged;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartIncomeExpense).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartExpenseByCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label lblCurrent;
        private Label lblIncomes;
        private Label lblExpenses;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncomeExpense;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpenseByCategory;
        private Label label4;
        private Label label5;
    }
}
