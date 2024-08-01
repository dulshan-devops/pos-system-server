using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Newtonsoft.Json;
using pos_desktop_app.models;
using pos_desktop_app.services;
using pos_desktop_app.utils;
using pos_system.Models.Entities;
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

namespace pos_desktop_app.views
{
    public partial class MasterProductsForm : MetroForm
    {
        private DepartmentService _apiDepartmentService;
        private CategoryService _apiCategoryService;
        private SupplierService _apiSupplierService;
        private ProductService _apiProductService;
        private UiRefresher refreshUi = new UiRefresher();

        List<ComboBoxItem> warrantyItems = new List<ComboBoxItem>
        {
            new ComboBoxItem { DisplayName = "Yes", Value = 1 },
            new ComboBoxItem { DisplayName = "No", Value = 0 }
        };

        List<ComboBoxItem> unitItems = new List<ComboBoxItem>
        {
            new ComboBoxItem { DisplayName = "Peaces", Value = "peaces" },
            new ComboBoxItem { DisplayName = "Kg", Value = "kg" },
            new ComboBoxItem { DisplayName = "G", Value = "g" },
            new ComboBoxItem { DisplayName = "Liter", Value = "l" },
            new ComboBoxItem { DisplayName = "Ml", Value = "ml" }
        };

        public MasterProductsForm()
        {
            InitializeComponent();
            _apiDepartmentService = new DepartmentService();
            _apiCategoryService = new CategoryService();
            _apiSupplierService = new SupplierService();
            _apiProductService = new ProductService();
        }

        private async void MasterProductsForm_Load(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage depRes = await _apiDepartmentService.getDepartment();
                HttpResponseMessage supRes = await _apiSupplierService.getSuppliers();
                HttpResponseMessage catRes = await _apiCategoryService.getCategories();
                HttpResponseMessage prodRes = await _apiProductService.getProducts();

                if (depRes.IsSuccessStatusCode && supRes.IsSuccessStatusCode && catRes.IsSuccessStatusCode && prodRes.IsSuccessStatusCode)
                {
                    refreshUi.RefreshCombo<Department>(depRes, cb_department, "DepartmentId", "DepartmentName");
                    refreshUi.RefreshCombo<Supplier>(supRes, cb_supplier, "SupplierId", "SupplierName");
                    refreshUi.RefreshCombo<Catergory>(catRes, cb_category, "CategoryId", "Name");

                    //units and warranty
                    refreshUi.RefreshComboWithList<ComboBoxItem>(warrantyItems, cb_warranty, "Value" , "DisplayName");
                    refreshUi.RefreshComboWithList<ComboBoxItem>(unitItems, cb_unit, "Value" , "DisplayName");

                    //setup table
                    refreshUi.RefreshDgv<Product>(prodRes, dgv_products);
                }
                else
                {
                    // Handle the error
                    MessageBox.Show($"Failed to fetch combo boxes:\n" +
                        $"Departments: {depRes.StatusCode}\n" +
                        $"Suppliers: {supRes.StatusCode}\n" +
                        $"Categories: {catRes.StatusCode}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_warranty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_warranty.SelectedItem != null)
            {
                // Cast the selected item to ComboBoxItem
                ComboBoxItem selectedItem = (ComboBoxItem)cb_warranty.SelectedItem;

                // Check if "No" is selected in the warranty ComboBox
                if (selectedItem.Value.Equals(0))
                {
                    // Disable the warranty period TextBox
                    tb_warranty_period.Enabled = false;
                    // Clear the text in the TextBox
                    tb_warranty_period.Text = "";
                }
                else
                {
                    // Enable the warranty period TextBox
                    tb_warranty_period.Enabled = true;
                }
            }
            else
            {
                // Enable the warranty period TextBox
                tb_warranty_period.Enabled = true;
            }
        }

        private async void btn_product_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_product_code.Text) || string.IsNullOrEmpty(tb_cost_price.Text) || string.IsNullOrEmpty(tb_selling_price.Text) || string.IsNullOrEmpty(tb_wholesale_price.Text))
            {
                MetroMessageBox.Show(this, "Please fill the all required fields..!" , "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
            }
        }
    }
}
