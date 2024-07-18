using MetroFramework.Controls;
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
    public partial class Dashboard : MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void mt_departments_menu_Click(object sender, EventArgs e)
        {
            MasterDepartmentsForm df = new MasterDepartmentsForm();
            df.Show();
        }

        private void mt_categories_Click(object sender, EventArgs e)
        {
            Categories cf =  new Categories();
            cf.Show();
        }

        private void mt_suppliers_Click(object sender, EventArgs e)
        {
            Suppliers cf = new Suppliers();
            cf.Show();
        }
    }
}
