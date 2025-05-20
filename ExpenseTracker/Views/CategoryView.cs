using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ExpenseTracker.Core.Interfaces;
using ExpenseTracker.Data.Models;
using ExpenseTracker.Services.Implementations;

namespace ExpenseTracker.Views
{
    public partial class CategoryView : UserControl
    {

        private readonly Account _account;

        private readonly ICategoryService _categoryService;

        public CategoryView(Account account)
        {
            InitializeComponent();

            cboType.DataSource = Enum.GetValues(typeof(TransactionType))
                        .Cast<TransactionType>()
                        .ToList();

            _account = account;

            _categoryService = new CategoryService();


        }
        private void CategoryView_Load(object sender, EventArgs e)
        {
            refreshView();
        }

        private async Task LoadCategoriesAsync()
        {
            List<Category> categories = await _categoryService
                .GetForAccountCategoriesAsync(_account.AccountId);


            dataGridViewCategories.AutoGenerateColumns = false;
            dataGridViewCategories.Columns.Clear();

            dataGridViewCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colName",
                HeaderText = "Nazwa",
                DataPropertyName = "Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dataGridViewCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colType",
                HeaderText = "Typ",
                DataPropertyName = "Type",
                Width = 100
            });

            dataGridViewCategories.DataSource = categories;
            dataGridViewCategories.Refresh();
        }


        private async void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (!(cboType.SelectedItem is TransactionType type))
            {
                MessageBox.Show("Wybierz typ kategorii.", "Błąd",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Podaj nazwę kategorii.", "Błąd",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var categoryType = (TransactionType)cboType.SelectedItem;

            var newCategory = new Category
            {
                AccountId = _account.AccountId,
                Name = name,
                Type = categoryType
            };
            await _categoryService.CreateAsync(newCategory);
            await LoadCategoriesAsync();
        }

        private async void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategories.CurrentRow?.DataBoundItem is Category cat)
            {
                await _categoryService.DeleteAsync(cat.CategoryId);
                await LoadCategoriesAsync();
            }
        }

        private async void refreshView()
        {
            await LoadCategoriesAsync();
        }

        private void CategoryView_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                refreshView();
        }
    }
}
