using MetroFramework;
using MetroFramework.Forms;
using pos_desktop_app.models;
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
    public partial class Suppliers : MetroForm
    {
        private SupplierService _apiService;
        private UiRefresher refreshUi = new UiRefresher();
        public Suppliers()
        {
            InitializeComponent();
            _apiService = new SupplierService();
        }

        private async void Suppliers_Load(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await _apiService.getSuppliers();
                if (response.IsSuccessStatusCode)
                {
                    refreshUi.RefreshDgv<Supplier>(response, dgv_suppliers);
                }
                else
                {
                    // Handle the error
                    MetroMessageBox.Show(this, $"Failed to fetch suppliers : {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_category_add_Click(object sender, EventArgs e)
        {
            if (tb_supplier_code.Text == "" || tb_supplier.Text == "" || tb_contact_person.Text == "" || tb_email.Text == "" || tb_mobile1.Text == "" || tb_mobile2.Text == "" || tb_address.Text == "" || tb_credit_limit.Text == "")
            {
                MetroMessageBox.Show(this, "You must need enter all fields!", "Empty Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var supCode = tb_supplier_code.Text;
                var supName = tb_supplier.Text;
                var contactPerson = tb_contact_person.Text;
                var email = tb_email.Text;
                var mobile1 = tb_mobile1.Text;
                var mobile2 = tb_mobile2.Text;
                var address = tb_address.Text;
                decimal creditLimit = decimal.Parse(tb_credit_limit.Text);

                HttpResponseMessage response = await _apiService.saveSupplier(supCode, supName, contactPerson,email,mobile1, mobile2, address, creditLimit);
                HttpResponseMessage supResponse = await _apiService.getSuppliers();
                refreshUi.RefreshDgv<Supplier>(supResponse, dgv_suppliers);
                MetroMessageBox.Show(this, "Supplier Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_suppliers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            MetroMessageBox.Show(this, "Supplier Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgv_suppliers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_suppliers.Rows[e.RowIndex];

                tb_supplier_code.Text = selectedRow.Cells["SupplierCode"].Value.ToString();
                tb_supplier.Text = selectedRow.Cells["SupplierName"].Value.ToString();
                tb_contact_person.Text = selectedRow.Cells["ContactPerson"].Value.ToString();
                tb_email.Text = selectedRow.Cells["Email"].Value.ToString();
                tb_mobile1.Text = selectedRow.Cells["Mobile1"].Value.ToString();
                tb_mobile2.Text = selectedRow.Cells["Mobile2"].Value.ToString();
                tb_address.Text = selectedRow.Cells["Address"].Value.ToString();
                tb_credit_limit.Text = selectedRow.Cells["CreditLimit"].Value.ToString();

            }
        }

        private async void btn_category_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_supplier_code.Text == "")
                {
                    MetroMessageBox.Show(this, "Please select supplier to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int selectedRowIndex = dgv_suppliers.SelectedRows[0].Index;
                    Supplier selectedSupplier = (Supplier)dgv_suppliers.Rows[selectedRowIndex].DataBoundItem;
                    selectedSupplier.SupplierId = selectedSupplier.SupplierId;
                    selectedSupplier.SupplierCode = tb_supplier_code.Text;
                    selectedSupplier.SupplierName = tb_supplier.Text;
                    selectedSupplier.ContactPerson = tb_contact_person.Text;
                    selectedSupplier.Email = tb_email.Text;
                    selectedSupplier.Mobile1 = tb_mobile1.Text;
                    selectedSupplier.Mobile2 = tb_mobile2.Text;
                    selectedSupplier.Address = tb_address.Text;
                    selectedSupplier.CreditLimit = decimal.Parse(tb_credit_limit.Text);
                    HttpResponseMessage response = await _apiService.updateSupplier(selectedSupplier);

                    if (response.IsSuccessStatusCode)
                    {
                        MetroMessageBox.Show(this, $"{selectedSupplier.SupplierName} Supplier Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Refresh the DataGridView
                        HttpResponseMessage supResponse = await _apiService.getSuppliers();
                        refreshUi.RefreshDgv<Supplier>(supResponse, dgv_suppliers);
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
            int selectedRowIndex = dgv_suppliers.SelectedRows[0].Index;
            Supplier selectedSupplier = (Supplier)dgv_suppliers.Rows[selectedRowIndex].DataBoundItem;
            if (tb_supplier_code.Text == "")
            {
                MetroMessageBox.Show(this, "Please select supplier to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HttpResponseMessage response = await _apiService.deleteSupplier(selectedSupplier);
                // Refresh the DataGridView
                HttpResponseMessage supResponse = await _apiService.getSuppliers();
                refreshUi.RefreshDgv<Supplier>(supResponse, dgv_suppliers);
                MetroMessageBox.Show(this, "Supplier Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
