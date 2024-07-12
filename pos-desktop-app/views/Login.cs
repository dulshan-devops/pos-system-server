using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using pos_system.Models.Responses;
using pos_desktop_app.models;
using pos_desktop_app.views;

namespace pos_desktop_app
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            MetroFramework.Components.MetroStyleManager styleManager;
            styleManager = new MetroFramework.Components.MetroStyleManager();
            styleManager.Owner = this;
            styleManager.Theme = MetroFramework.MetroThemeStyle.Dark; // Choose between Light or Dark
            styleManager.Style = MetroFramework.MetroColorStyle.Green; // Choose a color style
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            string username = tb_email.Text;
            string password = tb_password.Text;

            ApiService apiService = new ApiService();
            HttpResponseMessage loginRes = await apiService.userLogin(username, password);
            string res = await loginRes.Content.ReadAsStringAsync();

            if (loginRes.IsSuccessStatusCode)
            {
                LoginSuccessResponse loginSuccessRes = JsonConvert.DeserializeObject<LoginSuccessResponse>(res);
                //MessageBox.Show(res);
                //MetroFramework.MetroMessageBox.Show(this, $"{loginSuccessRes.accessToken}", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Dashboard dashboardForm = new Dashboard();
                dashboardForm.Show();
            }
            else
            {
                if (username == "" || password == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "You must need enter email and password!", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Clipboard.SetText(errorMessage);
                    // Deserialize the error message JSON into an object
                    ErrorResponse errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(res);

                    // Display specific properties from the errorResponse object in the message box
                    MetroFramework.MetroMessageBox.Show(this, $"{errorResponse.Title}", $"{errorResponse.Status}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }
    }
}
