﻿namespace ExpenseTracker.Forms
{
    partial class MainForm
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
            panel2 = new Panel();
            addtransaction_btn = new Button();
            transaction_btn = new Button();
            logout_btn = new Button();
            user_name = new Label();
            category_btn = new Button();
            dashboard_btn = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel_main = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Controls.Add(addtransaction_btn);
            panel2.Controls.Add(transaction_btn);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(user_name);
            panel2.Controls.Add(category_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 996);
            panel2.TabIndex = 1;
            // 
            // addtransaction_btn
            // 
            addtransaction_btn.BackColor = Color.SeaGreen;
            addtransaction_btn.FlatAppearance.BorderSize = 0;
            addtransaction_btn.FlatStyle = FlatStyle.Flat;
            addtransaction_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addtransaction_btn.ForeColor = Color.White;
            addtransaction_btn.Location = new Point(14, 597);
            addtransaction_btn.Margin = new Padding(3, 4, 3, 4);
            addtransaction_btn.Name = "addtransaction_btn";
            addtransaction_btn.Size = new Size(242, 59);
            addtransaction_btn.TabIndex = 10;
            addtransaction_btn.Text = "Dodaj transakcje";
            addtransaction_btn.UseVisualStyleBackColor = false;
            addtransaction_btn.Click += addtransaction_btn_Click;
            // 
            // transaction_btn
            // 
            transaction_btn.BackColor = Color.SeaGreen;
            transaction_btn.FlatAppearance.BorderSize = 0;
            transaction_btn.FlatStyle = FlatStyle.Flat;
            transaction_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transaction_btn.ForeColor = Color.White;
            transaction_btn.Location = new Point(14, 531);
            transaction_btn.Margin = new Padding(3, 4, 3, 4);
            transaction_btn.Name = "transaction_btn";
            transaction_btn.Size = new Size(242, 59);
            transaction_btn.TabIndex = 9;
            transaction_btn.Text = "Lista transakcji";
            transaction_btn.UseVisualStyleBackColor = false;
            transaction_btn.Click += button1_Click;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.SeaGreen;
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = Color.White;
            logout_btn.Location = new Point(14, 921);
            logout_btn.Margin = new Padding(3, 4, 3, 4);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(242, 59);
            logout_btn.TabIndex = 8;
            logout_btn.Text = "Wyloguj się";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // user_name
            // 
            user_name.AutoSize = true;
            user_name.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_name.ForeColor = Color.White;
            user_name.Location = new Point(105, 227);
            user_name.Name = "user_name";
            user_name.Size = new Size(71, 37);
            user_name.TabIndex = 7;
            user_name.Text = "user";
            // 
            // category_btn
            // 
            category_btn.BackColor = Color.SeaGreen;
            category_btn.FlatAppearance.BorderSize = 0;
            category_btn.FlatStyle = FlatStyle.Flat;
            category_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            category_btn.ForeColor = Color.White;
            category_btn.Location = new Point(14, 464);
            category_btn.Margin = new Padding(3, 4, 3, 4);
            category_btn.Name = "category_btn";
            category_btn.Size = new Size(242, 59);
            category_btn.TabIndex = 5;
            category_btn.Text = "Kategorie";
            category_btn.UseVisualStyleBackColor = false;
            category_btn.Click += category_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.SeaGreen;
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Location = new Point(14, 397);
            dashboard_btn.Margin = new Padding(3, 4, 3, 4);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(242, 59);
            dashboard_btn.TabIndex = 2;
            dashboard_btn.Text = "Strona główna";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 227);
            label2.Name = "label2";
            label2.Size = new Size(100, 37);
            label2.TabIndex = 1;
            label2.Text = "Witaj, ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.salary;
            pictureBox1.Location = new Point(55, 33);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel_main
            // 
            panel_main.AutoSize = true;
            panel_main.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_main.Location = new Point(271, 0);
            panel_main.Margin = new Padding(3, 4, 3, 4);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(0, 0);
            panel_main.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1734, 996);
            Controls.Add(panel_main);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Menadżer budżetu";
            Load += MainForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Button category_btn;
        private Button dashboard_btn;
        private Panel panel_main;
        private Label user_name;
        private Button logout_btn;
        private Button transaction_btn;
        private Button addtransaction_btn;
    }
}