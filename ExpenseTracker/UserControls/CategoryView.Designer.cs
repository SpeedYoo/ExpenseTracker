namespace ExpenseTracker.Views
{
    partial class CategoryView
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
            btnDeleteCategory = new Button();
            btnAddCategory = new Button();
            cboType = new ComboBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dataGridViewCategories = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnDeleteCategory);
            panel1.Controls.Add(btnAddCategory);
            panel1.Controls.Add(cboType);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(33, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 629);
            panel1.TabIndex = 0;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.BackColor = Color.SeaGreen;
            btnDeleteCategory.FlatAppearance.BorderSize = 0;
            btnDeleteCategory.FlatStyle = FlatStyle.Flat;
            btnDeleteCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteCategory.ForeColor = Color.White;
            btnDeleteCategory.Location = new Point(40, 414);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(271, 40);
            btnDeleteCategory.TabIndex = 5;
            btnDeleteCategory.Text = "Usuń";
            btnDeleteCategory.UseVisualStyleBackColor = false;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = Color.SeaGreen;
            btnAddCategory.FlatAppearance.BorderSize = 0;
            btnAddCategory.FlatStyle = FlatStyle.Flat;
            btnAddCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCategory.ForeColor = Color.White;
            btnAddCategory.Location = new Point(40, 350);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(271, 40);
            btnAddCategory.TabIndex = 4;
            btnAddCategory.Text = "Dodaj";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // cboType
            // 
            cboType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboType.FormattingEnabled = true;
            cboType.Location = new Point(40, 218);
            cboType.Name = "cboType";
            cboType.Size = new Size(271, 33);
            cboType.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 190);
            label3.Name = "label3";
            label3.Size = new Size(41, 25);
            label3.TabIndex = 2;
            label3.Text = "Typ";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(40, 102);
            txtName.Name = "txtName";
            txtName.Size = new Size(271, 33);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 74);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 0;
            label2.Text = "Nazwa";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridViewCategories);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(458, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(765, 629);
            panel2.TabIndex = 1;
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.BackgroundColor = Color.Gainsboro;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Location = new Point(47, 102);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.Size = new Size(686, 484);
            dataGridViewCategories.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 28);
            label1.Name = "label1";
            label1.Size = new Size(255, 47);
            label1.TabIndex = 0;
            label1.Text = "Lista kategorii";
            // 
            // CategoryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CategoryView";
            Size = new Size(1280, 690);
            Load += CategoryView_Load;
            VisibleChanged += CategoryView_VisibleChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private ComboBox cboType;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
        private DataGridView dataGridViewCategories;
    }
}
