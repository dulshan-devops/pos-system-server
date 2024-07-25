using MetroFramework;
using MetroFramework.Forms;
using Newtonsoft.Json;
using pos_desktop_app.models;
using pos_desktop_app.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace pos_desktop_app.views
{
    public partial class Categories : MetroForm
    {
        private CategoryService _apiService;
        private UiRefresher refreshUi = new UiRefresher();

        public Categories()
        {
            InitializeComponent();
            _apiService = new CategoryService();
        }

        private async void btn_category_add_Click(object sender, EventArgs e)
        {
            var category = tb_category.Text;
            var desc = tb_category_desc.Text;

            if (category == "" || desc == "")
            {
                MetroMessageBox.Show(this, "You must need enter category with description!", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HttpResponseMessage response = await _apiService.saveCategories(category, desc);
                HttpResponseMessage catResponse = await _apiService.getCategories();
                refreshUi.RefreshDgv<Catergory>(catResponse, dgv_categories);
                MetroMessageBox.Show(this, "Category Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void Categories_Load(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await _apiService.getCategories();
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to get the list of categories
                    //var categories = JsonConvert.DeserializeObject<IEnumerable<Catergory>>(await response.Content.ReadAsStringAsync());
                    // Bind the categories to the DataGridView
                    //dgv_categories.DataSource = categories;

                    refreshUi.RefreshDgv<Catergory>(response, dgv_categories);
                }
                else
                {
                    // Handle the error
                    MetroMessageBox.Show(this, $"Failed to fetch categories: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_categories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_categories.Rows[e.RowIndex];
                tb_category.Text = selectedRow.Cells["Name"].Value.ToString();
                tb_category_desc.Text = selectedRow.Cells["Desc"].Value.ToString();
            }
        }

        private async void btn_category_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_category.Text == "")
                {
                    MetroMessageBox.Show(this, "Please select category to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int selectedRowIndex = dgv_categories.SelectedRows[0].Index;
                    Catergory selectedCategory = (Catergory)dgv_categories.Rows[selectedRowIndex].DataBoundItem;
                    selectedCategory.CategoryId = selectedCategory.CategoryId;
                    selectedCategory.Name = tb_category.Text;
                    selectedCategory.Desc = tb_category_desc.Text;
                    HttpResponseMessage response = await _apiService.updateCategory(selectedCategory);

                    if (response.IsSuccessStatusCode)
                    {
                        MetroMessageBox.Show(this, $"{selectedCategory.Name} Category Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Refresh the DataGridView
                        HttpResponseMessage catResponse = await _apiService.getCategories();
                        refreshUi.RefreshDgv<Catergory>(catResponse, dgv_categories);
                    }
                    else
                    {
                        Clipboard.SetText(response.ReasonPhrase);
                        // Handle the error
                        MetroMessageBox.Show(this, $"{response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Clipboard.SetText(ex.Message);
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_category_delete_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgv_categories.SelectedRows[0].Index;
            Catergory selectedCategory = (Catergory)dgv_categories.Rows[selectedRowIndex].DataBoundItem;
            if (tb_category.Text == "")
            {
                MetroMessageBox.Show(this, "Please select category to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HttpResponseMessage response = await _apiService.deleteCategory(selectedCategory);
                // Refresh the DataGridView
                HttpResponseMessage catResponse = await _apiService.getCategories();
                refreshUi.RefreshDgv<Catergory>(catResponse, dgv_categories);
                MetroMessageBox.Show(this, "Category Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
