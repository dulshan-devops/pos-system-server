using MetroFramework;
using MetroFramework.Forms;
using Newtonsoft.Json;
using pos_system.Models.Entities;
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
using pos_desktop_app.models;

namespace pos_desktop_app.views
{
    public partial class MasterDepartmentsForm : MetroForm
    {
        private DepartmentService _apiService;
        private UiRefresher refreshUi = new UiRefresher();
        public MasterDepartmentsForm()
        {
            InitializeComponent();
            _apiService = new DepartmentService();
        }

        private async void MasterDepartmentsForm_Load(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await _apiService.getDepartment();
                if (response.IsSuccessStatusCode)
                {
                    refreshUi.RefreshDgv<Department>(response, dgv_departments);
                }
                else
                {
                    // Handle the error
                    MetroMessageBox.Show(this, $"Failed to fetch Departments : {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
