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
    }
}
