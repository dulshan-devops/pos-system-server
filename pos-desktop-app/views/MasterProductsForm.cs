using MetroFramework;
using MetroFramework.Forms;
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

                if (depRes.IsSuccessStatusCode && supRes.IsSuccessStatusCode && catRes.IsSuccessStatusCode)
                {
                    refreshUi.RefreshCombo<Department>(depRes , cb_department , "DepartmentId", "DepartmentName");
                    refreshUi.RefreshCombo<Supplier>(supRes, cb_supplier , "SupplierId", "SupplierName");
                    refreshUi.RefreshCombo<Catergory>(catRes, cb_category , "CategoryId", "Name");
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
    }
}
