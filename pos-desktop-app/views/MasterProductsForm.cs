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
                    MetroMessageBox.Show(this, $"Failed to fetch combo boxes:\n" +
                        $"Departments: {depRes.StatusCode}\n" +
                        $"Suppliers: {supRes.StatusCode}\n" +
                        $"Categories: {catRes.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    /*MessageBox.Show($"Failed to fetch combo boxes:\n" +
                        $"Departments: {depRes.StatusCode}\n" +
                        $"Suppliers: {supRes.StatusCode}\n" +
                        $"Categories: {catRes.StatusCode}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
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
            HttpResponseMessage response;
            if (string.IsNullOrEmpty(tb_product_code.Text) || string.IsNullOrEmpty(tb_cost_price.Text) || string.IsNullOrEmpty(tb_selling_price.Text) || string.IsNullOrEmpty(tb_wholesale_price.Text))
            {
                MetroMessageBox.Show(this, "Please fill the all required fields..!" , "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Cast the selected item to ComboBoxItem
                ComboBoxItem warranty = (ComboBoxItem)cb_warranty.SelectedItem;

                int depId = (cb_department.SelectedItem as Department)?.DepartmentId ?? -1;
                int catId = (cb_category.SelectedItem as Catergory)?.CategoryId ?? -1;
                int supId = (cb_supplier.SelectedItem as Supplier)?.SupplierId ?? -1;
                //int warranty = (cb_warranty.SelectedItem as (List)warrantyItems)?.SupplierId ?? -1;

                Product newProduct = new Product
                {
                    ProductCode = tb_product_code.Text,
                    ProductName = tb_product_name.Text,
                    DepartmentId = depId,
                    CategoryId = catId,
                    SupplierId = supId,
                    CostPrice = decimal.Parse(tb_cost_price.Text),
                    SellingPrice = decimal.Parse(tb_selling_price.Text),
                    WholesalePrice = decimal.Parse(tb_wholesale_price.Text),
                    MarkedPrice = decimal.Parse(tb_marked_price.Text),
                    Warranty = (int)cb_warranty.SelectedValue,
                    Desc = tb_desc.Text,
                    Unit = cb_unit.SelectedValue.ToString(),
                };

                // Check if "No" is selected in the warranty ComboBox
                if (warranty.Value.Equals(0))
                {
                    //no warranty
                    response = await _apiProductService.saveProduct(newProduct, 0);
                }
                else
                {
                    //warranty have
                    response = await _apiProductService.saveProduct(newProduct, int.Parse(tb_warranty_period.Text));
                }

                if(response.IsSuccessStatusCode)
                {
                    HttpResponseMessage prodResponse = await _apiProductService.getProducts();
                    refreshUi.RefreshDgv<Product>(prodResponse, dgv_products);
                    MetroMessageBox.Show(this, "Product Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, $"{response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void dgv_products_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedRowIndex = dgv_products.SelectedRows[0].Index;
                Product selectedProduct = (Product)dgv_products.Rows[selectedRowIndex].DataBoundItem;

                DataGridViewRow selectedRow = dgv_products.Rows[e.RowIndex];
                tb_product_code.Text = selectedRow.Cells["ProductCode"].Value.ToString();
                tb_cost_price.Text = selectedRow.Cells["CostPrice"].Value.ToString();
                tb_selling_price.Text = selectedRow.Cells["SellingPrice"].Value.ToString();
                tb_wholesale_price.Text = selectedRow.Cells["WholesalePrice"].Value.ToString();
                tb_marked_price.Text = selectedRow.Cells["MarkedPrice"].Value.ToString();
                tb_desc.Text = selectedRow.Cells["Desc"].Value.ToString();
                tb_product_name.Text = selectedRow.Cells["ProductName"].Value.ToString();
            }
        }

        private async void btn_product_delete_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgv_products.SelectedRows[0].Index;
            Product selectedProduct = (Product)dgv_products.Rows[selectedRowIndex].DataBoundItem;
            if (selectedProduct.ProductId == null)
            {
                MetroMessageBox.Show(this, "Please select category to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HttpResponseMessage response = await _apiProductService.deleteProduct(selectedProduct);
                // Refresh the DataGridView
                HttpResponseMessage prodResponse = await _apiProductService.getProducts();
                refreshUi.RefreshDgv<Product>(prodResponse, dgv_products);
                MetroMessageBox.Show(this, "Product Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btn_product_update_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = dgv_products.SelectedRows[0].Index;
                Product selectedProduct = (Product)dgv_products.Rows[selectedRowIndex].DataBoundItem;
                int depId = (cb_department.SelectedItem as Department)?.DepartmentId ?? -1;
                int catId = (cb_category.SelectedItem as Catergory)?.CategoryId ?? -1;
                int supId = (cb_supplier.SelectedItem as Supplier)?.SupplierId ?? -1;

                if (tb_product_code.Text == "" || selectedProduct.ProductId == null)
                {
                    MetroMessageBox.Show(this, "Please select product to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    selectedProduct.ProductCode = tb_product_code.Text;
                    selectedProduct.DepartmentId = depId;
                    selectedProduct.CategoryId = catId;
                    selectedProduct.SupplierId = supId;
                    selectedProduct.CostPrice = decimal.Parse(tb_cost_price.Text);
                    selectedProduct.SellingPrice = decimal.Parse(tb_selling_price.Text);
                    selectedProduct.WholesalePrice = decimal.Parse(tb_wholesale_price.Text);
                    selectedProduct.MarkedPrice = decimal.Parse(tb_wholesale_price.Text);
                    selectedProduct.Unit = cb_unit.SelectedValue.ToString();
                    selectedProduct.Warranty = (int)cb_warranty.SelectedValue;
                    selectedProduct.ProductName = tb_product_name.Text;
                    selectedProduct.Desc = tb_desc.Text;

                    HttpResponseMessage response = await _apiProductService.updateProduct(selectedProduct);

                    if (response.IsSuccessStatusCode)
                    {
                        MetroMessageBox.Show(this, $"{selectedProduct.ProductCode} Product Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Refresh the DataGridView
                        HttpResponseMessage prodResponse = await _apiProductService.getProducts();
                        refreshUi.RefreshDgv<Product>(prodResponse, dgv_products);
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
    }
}
