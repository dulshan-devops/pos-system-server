namespace pos_desktop_app.views
{
    partial class MasterPosConsole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterPosConsole));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flp_top_bar = new System.Windows.Forms.FlowLayoutPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dgv_products = new MetroFramework.Controls.MetroGrid();
            this.tb_selected_product_qty = new MetroFramework.Controls.MetroTextBox();
            this.btn_add_to_cart = new MetroFramework.Controls.MetroButton();
            this.tb_selected_product = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.lbl_total_of_bill = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dgv_product_in_cart = new MetroFramework.Controls.MetroGrid();
            this.flp_top_bar.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product_in_cart)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_top_bar
            // 
            this.flp_top_bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_top_bar.Controls.Add(this.metroTile1);
            this.flp_top_bar.Controls.Add(this.metroTile2);
            this.flp_top_bar.Controls.Add(this.metroTile3);
            this.flp_top_bar.Controls.Add(this.metroTile4);
            this.flp_top_bar.Controls.Add(this.metroTile5);
            this.flp_top_bar.Location = new System.Drawing.Point(11, 62);
            this.flp_top_bar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flp_top_bar.Name = "flp_top_bar";
            this.flp_top_bar.Size = new System.Drawing.Size(1756, 140);
            this.flp_top_bar.TabIndex = 0;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroTile1.Location = new System.Drawing.Point(8, 7);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(271, 122);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Total Orders";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile1.TileCount = 5;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroTile2.Location = new System.Drawing.Point(295, 7);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(271, 122);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Total Income";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile2.TileCount = 5;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.metroTile3.Location = new System.Drawing.Point(582, 7);
            this.metroTile3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(271, 122);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "Total Profit";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile3.TileCount = 5;
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseCustomBackColor = true;
            this.metroTile3.UseCustomForeColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroTile4.Location = new System.Drawing.Point(869, 7);
            this.metroTile4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(271, 122);
            this.metroTile4.TabIndex = 3;
            this.metroTile4.Text = "Total Return";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile4.TileCount = 5;
            this.metroTile4.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile4.TileImage")));
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile4.UseCustomBackColor = true;
            this.metroTile4.UseCustomForeColor = true;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroTile5.Location = new System.Drawing.Point(1156, 7);
            this.metroTile5.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(271, 122);
            this.metroTile5.TabIndex = 4;
            this.metroTile5.Text = "Expired Products";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile5.TileCount = 5;
            this.metroTile5.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile5.TileImage")));
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile5.UseCustomBackColor = true;
            this.metroTile5.UseCustomForeColor = true;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseTileImage = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.dgv_products);
            this.metroPanel1.Controls.Add(this.tb_selected_product_qty);
            this.metroPanel1.Controls.Add(this.btn_add_to_cart);
            this.metroPanel1.Controls.Add(this.tb_selected_product);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(11, 207);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(688, 1248);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 11;
            // 
            // dgv_products
            // 
            this.dgv_products.AllowUserToResizeRows = false;
            this.dgv_products.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_products.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_products.EnableHeadersVisualStyles = false;
            this.dgv_products.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_products.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_products.Location = new System.Drawing.Point(4, 59);
            this.dgv_products.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_products.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_products.RowHeadersWidth = 51;
            this.dgv_products.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_products.RowTemplate.Height = 24;
            this.dgv_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_products.Size = new System.Drawing.Size(681, 660);
            this.dgv_products.TabIndex = 9;
            this.dgv_products.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_products_RowHeaderMouseClick);
            // 
            // tb_selected_product_qty
            // 
            this.tb_selected_product_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_selected_product_qty.CustomButton.Image = null;
            this.tb_selected_product_qty.CustomButton.Location = new System.Drawing.Point(80, 2);
            this.tb_selected_product_qty.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_selected_product_qty.CustomButton.Name = "";
            this.tb_selected_product_qty.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tb_selected_product_qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_selected_product_qty.CustomButton.TabIndex = 1;
            this.tb_selected_product_qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_selected_product_qty.CustomButton.UseSelectable = true;
            this.tb_selected_product_qty.CustomButton.Visible = false;
            this.tb_selected_product_qty.DisplayIcon = true;
            this.tb_selected_product_qty.Lines = new string[0];
            this.tb_selected_product_qty.Location = new System.Drawing.Point(403, 12);
            this.tb_selected_product_qty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_selected_product_qty.MaxLength = 32767;
            this.tb_selected_product_qty.Multiline = true;
            this.tb_selected_product_qty.Name = "tb_selected_product_qty";
            this.tb_selected_product_qty.PasswordChar = '\0';
            this.tb_selected_product_qty.PromptText = "Quantity";
            this.tb_selected_product_qty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_selected_product_qty.SelectedText = "";
            this.tb_selected_product_qty.SelectionLength = 0;
            this.tb_selected_product_qty.SelectionStart = 0;
            this.tb_selected_product_qty.ShortcutsEnabled = true;
            this.tb_selected_product_qty.Size = new System.Drawing.Size(108, 30);
            this.tb_selected_product_qty.Style = MetroFramework.MetroColorStyle.Green;
            this.tb_selected_product_qty.TabIndex = 8;
            this.tb_selected_product_qty.UseSelectable = true;
            this.tb_selected_product_qty.UseStyleColors = true;
            this.tb_selected_product_qty.WaterMark = "Quantity";
            this.tb_selected_product_qty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_selected_product_qty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_add_to_cart
            // 
            this.btn_add_to_cart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_add_to_cart.Location = new System.Drawing.Point(517, 12);
            this.btn_add_to_cart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add_to_cart.Name = "btn_add_to_cart";
            this.btn_add_to_cart.Size = new System.Drawing.Size(155, 30);
            this.btn_add_to_cart.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_add_to_cart.TabIndex = 6;
            this.btn_add_to_cart.Text = "Add";
            this.btn_add_to_cart.UseSelectable = true;
            this.btn_add_to_cart.UseStyleColors = true;
            this.btn_add_to_cart.Click += new System.EventHandler(this.btn_add_to_cart_Click);
            // 
            // tb_selected_product
            // 
            this.tb_selected_product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_selected_product.CustomButton.Image = null;
            this.tb_selected_product.CustomButton.Location = new System.Drawing.Point(365, 2);
            this.tb_selected_product.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_selected_product.CustomButton.Name = "";
            this.tb_selected_product.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tb_selected_product.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_selected_product.CustomButton.TabIndex = 1;
            this.tb_selected_product.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_selected_product.CustomButton.UseSelectable = true;
            this.tb_selected_product.CustomButton.Visible = false;
            this.tb_selected_product.DisplayIcon = true;
            this.tb_selected_product.Lines = new string[0];
            this.tb_selected_product.Location = new System.Drawing.Point(4, 12);
            this.tb_selected_product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_selected_product.MaxLength = 32767;
            this.tb_selected_product.Multiline = true;
            this.tb_selected_product.Name = "tb_selected_product";
            this.tb_selected_product.PasswordChar = '\0';
            this.tb_selected_product.PromptText = "Find your product";
            this.tb_selected_product.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_selected_product.SelectedText = "";
            this.tb_selected_product.SelectionLength = 0;
            this.tb_selected_product.SelectionStart = 0;
            this.tb_selected_product.ShortcutsEnabled = true;
            this.tb_selected_product.Size = new System.Drawing.Size(393, 30);
            this.tb_selected_product.Style = MetroFramework.MetroColorStyle.Green;
            this.tb_selected_product.TabIndex = 5;
            this.tb_selected_product.UseSelectable = true;
            this.tb_selected_product.UseStyleColors = true;
            this.tb_selected_product.WaterMark = "Find your product";
            this.tb_selected_product.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_selected_product.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.Controls.Add(this.lbl_total_of_bill);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.metroButton2);
            this.metroPanel2.Controls.Add(this.metroButton1);
            this.metroPanel2.Controls.Add(this.dgv_product_in_cart);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(705, 207);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(764, 728);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // lbl_total_of_bill
            // 
            this.lbl_total_of_bill.AutoSize = true;
            this.lbl_total_of_bill.Location = new System.Drawing.Point(545, 628);
            this.lbl_total_of_bill.Name = "lbl_total_of_bill";
            this.lbl_total_of_bill.Size = new System.Drawing.Size(36, 20);
            this.lbl_total_of_bill.TabIndex = 14;
            this.lbl_total_of_bill.Text = "0.00";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(470, 628);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 20);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Bill Total : ";
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroButton2.Location = new System.Drawing.Point(193, 619);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(155, 41);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.TabIndex = 12;
            this.metroButton2.Text = "Print Bill";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroButton1.Location = new System.Drawing.Point(20, 618);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(155, 41);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Create Sale";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            // 
            // dgv_product_in_cart
            // 
            this.dgv_product_in_cart.AllowUserToResizeRows = false;
            this.dgv_product_in_cart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_product_in_cart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_product_in_cart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_product_in_cart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_product_in_cart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_product_in_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_product_in_cart.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_product_in_cart.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_product_in_cart.EnableHeadersVisualStyles = false;
            this.dgv_product_in_cart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_product_in_cart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_product_in_cart.Location = new System.Drawing.Point(0, 0);
            this.dgv_product_in_cart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_product_in_cart.Name = "dgv_product_in_cart";
            this.dgv_product_in_cart.ReadOnly = true;
            this.dgv_product_in_cart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_product_in_cart.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_product_in_cart.RowHeadersWidth = 51;
            this.dgv_product_in_cart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_product_in_cart.RowTemplate.Height = 24;
            this.dgv_product_in_cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_product_in_cart.Size = new System.Drawing.Size(764, 468);
            this.dgv_product_in_cart.Style = MetroFramework.MetroColorStyle.Silver;
            this.dgv_product_in_cart.TabIndex = 10;
            this.dgv_product_in_cart.UseStyleColors = true;
            // 
            // MasterPosConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 935);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.flp_top_bar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MasterPosConsole";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "POS Console";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.MasterPosConsole_Load);
            this.flp_top_bar.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product_in_cart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_top_bar;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btn_add_to_cart;
        private MetroFramework.Controls.MetroTextBox tb_selected_product;
        private MetroFramework.Controls.MetroTextBox tb_selected_product_qty;
        private MetroFramework.Controls.MetroGrid dgv_products;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid dgv_product_in_cart;
        private MetroFramework.Controls.MetroLabel lbl_total_of_bill;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}