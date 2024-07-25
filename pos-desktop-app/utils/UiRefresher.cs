using MetroFramework.Controls;
using Newtonsoft.Json;
using pos_desktop_app.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_desktop_app.utils
{
    public class UiRefresher
    {
        public async void RefreshDgv<T>(HttpResponseMessage response, DataGridView table)
        {
            var data = JsonConvert.DeserializeObject<IEnumerable<T>>(await response.Content.ReadAsStringAsync());
            table.DataSource = data;
        }

        public async void RefreshCombo<T>(HttpResponseMessage response, MetroComboBox comboBox ,string id , string idText)
        {
            try
            {
                // Read the response content as a string
                string responseData = await response.Content.ReadAsStringAsync();

                // Deserialize the response content to a list of T
                List<T> items = JsonConvert.DeserializeObject<List<T>>(responseData);

                // Bind the list to the ComboBox
                comboBox.DataSource = items;

                // Assuming T has properties named "Id" and "Column Name"
                comboBox.DisplayMember = idText;
                comboBox.ValueMember = id;
            }
            catch (Exception ex)
            {
                // Handle deserialization or binding errors
                MessageBox.Show($"Failed to bind combo box: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
