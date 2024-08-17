using MetroFramework;
using MetroFramework.Forms;
using pos_desktop_app.models;
using pos_desktop_app.services;
using pos_desktop_app.utils;
using pos_system.Models.Custom_Entities;
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
using static MetroFramework.Drawing.Html.CssLength;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace pos_desktop_app.views
{
    public partial class MasterPosConsole : MetroForm
    {
        private ProductService _apiProductService;
        private UiRefresher refreshUi = new UiRefresher();
        public MasterPosConsole()
        {
            InitializeComponent();
            _apiProductService = new ProductService();
        }

        private async void MasterPosConsole_Load(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage prodRes = await _apiProductService.getProducts();

                if (prodRes.IsSuccessStatusCode)
                {
                    //setup table
                    refreshUi.RefreshDgv<ProductV1>(prodRes, dgv_products);
                }
                else
                {
                    // Handle the error
                    MetroMessageBox.Show(this, $"Failed to fetch :\n" +
                        $"Products: {prodRes.StatusCode}\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_products_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedRowIndex = dgv_products.SelectedRows[0].Index;
                ProductV1 selectedProduct = (ProductV1)dgv_products.Rows[selectedRowIndex].DataBoundItem;

                DataGridViewRow selectedRow = dgv_products.Rows[e.RowIndex];
                tb_selected_product.Text = selectedRow.Cells["ProductName"].Value.ToString();
                tb_selected_product_qty.Text = 1.ToString();
            }
        }
    }
}
