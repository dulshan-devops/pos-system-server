using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_desktop_app.views
{
    public partial class Categories : MetroForm
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void btn_category_add_Click(object sender, EventArgs e)
        {
            var category = tb_category.Text;
            var desc = tb_category_desc.Text;

            if (category == "" || desc == "")
            {
                MetroMessageBox.Show(this, "You must need enter category with description!", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }
    }
}
