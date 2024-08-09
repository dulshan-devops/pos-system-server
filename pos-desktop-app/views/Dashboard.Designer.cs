namespace pos_desktop_app.views
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tab_master = new System.Windows.Forms.TabPage();
            this.flp_dashboard = new System.Windows.Forms.FlowLayoutPanel();
            this.mt_departments = new MetroFramework.Controls.MetroTile();
            this.mt_users = new MetroFramework.Controls.MetroTile();
            this.mt_suppliers = new MetroFramework.Controls.MetroTile();
            this.mt_categories = new MetroFramework.Controls.MetroTile();
            this.mt_products = new MetroFramework.Controls.MetroTile();
            this.mt_customers = new MetroFramework.Controls.MetroTile();
            this.mt_pos_console = new MetroFramework.Controls.MetroTile();
            this.tab_tools = new System.Windows.Forms.TabPage();
            this.tab_reports = new System.Windows.Forms.TabPage();
            this.metroTabControl1.SuspendLayout();
            this.tab_master.SuspendLayout();
            this.flp_dashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tab_master);
            this.metroTabControl1.Controls.Add(this.tab_tools);
            this.metroTabControl1.Controls.Add(this.tab_reports);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.ShowToolTips = true;
            this.metroTabControl1.Size = new System.Drawing.Size(1067, 675);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tab_master
            // 
            this.tab_master.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tab_master.Controls.Add(this.flp_dashboard);
            this.tab_master.Location = new System.Drawing.Point(4, 38);
            this.tab_master.Name = "tab_master";
            this.tab_master.Size = new System.Drawing.Size(1059, 633);
            this.tab_master.TabIndex = 0;
            this.tab_master.Text = "Master";
            // 
            // flp_dashboard
            // 
            this.flp_dashboard.Controls.Add(this.mt_pos_console);
            this.flp_dashboard.Controls.Add(this.mt_departments);
            this.flp_dashboard.Controls.Add(this.mt_users);
            this.flp_dashboard.Controls.Add(this.mt_suppliers);
            this.flp_dashboard.Controls.Add(this.mt_categories);
            this.flp_dashboard.Controls.Add(this.mt_products);
            this.flp_dashboard.Controls.Add(this.mt_customers);
            this.flp_dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_dashboard.Location = new System.Drawing.Point(0, 0);
            this.flp_dashboard.Name = "flp_dashboard";
            this.flp_dashboard.Size = new System.Drawing.Size(1059, 633);
            this.flp_dashboard.TabIndex = 0;
            // 
            // mt_departments
            // 
            this.mt_departments.ActiveControl = null;
            this.mt_departments.Location = new System.Drawing.Point(154, 3);
            this.mt_departments.Name = "mt_departments";
            this.mt_departments.Size = new System.Drawing.Size(145, 127);
            this.mt_departments.Style = MetroFramework.MetroColorStyle.Green;
            this.mt_departments.TabIndex = 0;
            this.mt_departments.Text = "Departments";
            this.mt_departments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mt_departments.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt_departments.TileImage = ((System.Drawing.Image)(resources.GetObject("mt_departments.TileImage")));
            this.mt_departments.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mt_departments.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt_departments.UseSelectable = true;
            this.mt_departments.UseStyleColors = true;
            this.mt_departments.UseTileImage = true;
            this.mt_departments.Click += new System.EventHandler(this.mt_departments_menu_Click);
            // 
            // mt_users
            // 
            this.mt_users.ActiveControl = null;
            this.mt_users.Location = new System.Drawing.Point(305, 3);
            this.mt_users.Name = "mt_users";
            this.mt_users.Size = new System.Drawing.Size(145, 127);
            this.mt_users.Style = MetroFramework.MetroColorStyle.Green;
            this.mt_users.TabIndex = 6;
            this.mt_users.Text = "Users";
            this.mt_users.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mt_users.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt_users.TileImage = ((System.Drawing.Image)(resources.GetObject("mt_users.TileImage")));
            this.mt_users.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mt_users.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt_users.UseSelectable = true;
            this.mt_users.UseStyleColors = true;
            this.mt_users.UseTileImage = true;
            // 
            // mt_suppliers
            // 
            this.mt_suppliers.ActiveControl = null;
            this.mt_suppliers.Location = new System.Drawing.Point(456, 3);
            this.mt_suppliers.Name = "mt_suppliers";
            this.mt_suppliers.Size = new System.Drawing.Size(145, 127);
            this.mt_suppliers.Style = MetroFramework.MetroColorStyle.Green;
            this.mt_suppliers.TabIndex = 3;
            this.mt_suppliers.Text = "Suppliers";
            this.mt_suppliers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mt_suppliers.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt_suppliers.TileImage = ((System.Drawing.Image)(resources.GetObject("mt_suppliers.TileImage")));
            this.mt_suppliers.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mt_suppliers.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt_suppliers.UseSelectable = true;
            this.mt_suppliers.UseStyleColors = true;
            this.mt_suppliers.UseTileImage = true;
            this.mt_suppliers.Click += new System.EventHandler(this.mt_suppliers_Click);
            // 
            // mt_categories
            // 
            this.mt_categories.ActiveControl = null;
            this.mt_categories.Location = new System.Drawing.Point(607, 3);
            this.mt_categories.Name = "mt_categories";
            this.mt_categories.Size = new System.Drawing.Size(145, 127);
            this.mt_categories.Style = MetroFramework.MetroColorStyle.Green;
            this.mt_categories.TabIndex = 2;
            this.mt_categories.Text = "Categories";
            this.mt_categories.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mt_categories.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt_categories.TileImage = ((System.Drawing.Image)(resources.GetObject("mt_categories.TileImage")));
            this.mt_categories.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mt_categories.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt_categories.UseSelectable = true;
            this.mt_categories.UseStyleColors = true;
            this.mt_categories.UseTileImage = true;
            this.mt_categories.Click += new System.EventHandler(this.mt_categories_Click);
            // 
            // mt_products
            // 
            this.mt_products.ActiveControl = null;
            this.mt_products.Location = new System.Drawing.Point(758, 3);
            this.mt_products.Name = "mt_products";
            this.mt_products.Size = new System.Drawing.Size(145, 127);
            this.mt_products.Style = MetroFramework.MetroColorStyle.Green;
            this.mt_products.TabIndex = 5;
            this.mt_products.Text = "Products";
            this.mt_products.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mt_products.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt_products.TileImage = ((System.Drawing.Image)(resources.GetObject("mt_products.TileImage")));
            this.mt_products.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mt_products.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt_products.UseSelectable = true;
            this.mt_products.UseStyleColors = true;
            this.mt_products.UseTileImage = true;
            this.mt_products.Click += new System.EventHandler(this.mt_products_Click);
            // 
            // mt_customers
            // 
            this.mt_customers.ActiveControl = null;
            this.mt_customers.Location = new System.Drawing.Point(909, 3);
            this.mt_customers.Name = "mt_customers";
            this.mt_customers.Size = new System.Drawing.Size(145, 127);
            this.mt_customers.Style = MetroFramework.MetroColorStyle.Green;
            this.mt_customers.TabIndex = 4;
            this.mt_customers.Text = "Customers";
            this.mt_customers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mt_customers.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt_customers.TileImage = ((System.Drawing.Image)(resources.GetObject("mt_customers.TileImage")));
            this.mt_customers.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mt_customers.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt_customers.UseSelectable = true;
            this.mt_customers.UseStyleColors = true;
            this.mt_customers.UseTileImage = true;
            // 
            // mt_pos_console
            // 
            this.mt_pos_console.ActiveControl = null;
            this.mt_pos_console.Location = new System.Drawing.Point(3, 3);
            this.mt_pos_console.Name = "mt_pos_console";
            this.mt_pos_console.Size = new System.Drawing.Size(145, 127);
            this.mt_pos_console.Style = MetroFramework.MetroColorStyle.Blue;
            this.mt_pos_console.TabIndex = 7;
            this.mt_pos_console.Text = "Pos Console";
            this.mt_pos_console.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mt_pos_console.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt_pos_console.TileImage = ((System.Drawing.Image)(resources.GetObject("mt_pos_console.TileImage")));
            this.mt_pos_console.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mt_pos_console.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt_pos_console.UseSelectable = true;
            this.mt_pos_console.UseStyleColors = true;
            this.mt_pos_console.UseTileImage = true;
            this.mt_pos_console.Click += new System.EventHandler(this.mt_pos_console_Click);
            // 
            // tab_tools
            // 
            this.tab_tools.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tab_tools.Location = new System.Drawing.Point(4, 38);
            this.tab_tools.Name = "tab_tools";
            this.tab_tools.Size = new System.Drawing.Size(1173, 637);
            this.tab_tools.TabIndex = 1;
            this.tab_tools.Text = "Tools";
            // 
            // tab_reports
            // 
            this.tab_reports.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tab_reports.Location = new System.Drawing.Point(4, 38);
            this.tab_reports.Name = "tab_reports";
            this.tab_reports.Size = new System.Drawing.Size(1173, 637);
            this.tab_reports.TabIndex = 2;
            this.tab_reports.Text = "Reports";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 755);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Dashboard";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Dashboard";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.metroTabControl1.ResumeLayout(false);
            this.tab_master.ResumeLayout(false);
            this.flp_dashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tab_master;
        private System.Windows.Forms.TabPage tab_tools;
        private System.Windows.Forms.TabPage tab_reports;
        private System.Windows.Forms.FlowLayoutPanel flp_dashboard;
        private MetroFramework.Controls.MetroTile mt_departments;
        private MetroFramework.Controls.MetroTile mt_categories;
        private MetroFramework.Controls.MetroTile mt_suppliers;
        private MetroFramework.Controls.MetroTile mt_customers;
        private MetroFramework.Controls.MetroTile mt_users;
        private MetroFramework.Controls.MetroTile mt_products;
        private MetroFramework.Controls.MetroTile mt_pos_console;
    }
}