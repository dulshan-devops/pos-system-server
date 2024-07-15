namespace pos_desktop_app.views
{
    partial class Categories
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tb_category = new MetroFramework.Controls.MetroTextBox();
            this.btn_category_delete = new MetroFramework.Controls.MetroButton();
            this.btn_category_update = new MetroFramework.Controls.MetroButton();
            this.btn_category_add = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tb_category_desc = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.dgv_categories = new System.Windows.Forms.DataGridView();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categories)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tb_category);
            this.metroPanel1.Controls.Add(this.btn_category_delete);
            this.metroPanel1.Controls.Add(this.btn_category_update);
            this.metroPanel1.Controls.Add(this.btn_category_add);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.tb_category_desc);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1192, 243);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tb_category
            // 
            // 
            // 
            // 
            this.tb_category.CustomButton.Image = null;
            this.tb_category.CustomButton.Location = new System.Drawing.Point(581, 1);
            this.tb_category.CustomButton.Name = "";
            this.tb_category.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.tb_category.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_category.CustomButton.TabIndex = 1;
            this.tb_category.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_category.CustomButton.UseSelectable = true;
            this.tb_category.CustomButton.Visible = false;
            this.tb_category.Lines = new string[0];
            this.tb_category.Location = new System.Drawing.Point(295, 45);
            this.tb_category.MaxLength = 32767;
            this.tb_category.Multiline = true;
            this.tb_category.Name = "tb_category";
            this.tb_category.PasswordChar = '\0';
            this.tb_category.PromptText = "Category";
            this.tb_category.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_category.SelectedText = "";
            this.tb_category.SelectionLength = 0;
            this.tb_category.SelectionStart = 0;
            this.tb_category.ShortcutsEnabled = true;
            this.tb_category.Size = new System.Drawing.Size(611, 31);
            this.tb_category.Style = MetroFramework.MetroColorStyle.Green;
            this.tb_category.TabIndex = 9;
            this.tb_category.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tb_category.UseSelectable = true;
            this.tb_category.UseStyleColors = true;
            this.tb_category.WaterMark = "Category";
            this.tb_category.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_category.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_category_delete
            // 
            this.btn_category_delete.Location = new System.Drawing.Point(721, 199);
            this.btn_category_delete.Name = "btn_category_delete";
            this.btn_category_delete.Size = new System.Drawing.Size(185, 32);
            this.btn_category_delete.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_category_delete.TabIndex = 8;
            this.btn_category_delete.Text = "Delete";
            this.btn_category_delete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_category_delete.UseSelectable = true;
            this.btn_category_delete.UseStyleColors = true;
            this.btn_category_delete.Click += new System.EventHandler(this.btn_category_delete_Click);
            // 
            // btn_category_update
            // 
            this.btn_category_update.Location = new System.Drawing.Point(509, 199);
            this.btn_category_update.Name = "btn_category_update";
            this.btn_category_update.Size = new System.Drawing.Size(185, 32);
            this.btn_category_update.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btn_category_update.TabIndex = 7;
            this.btn_category_update.Text = "Update";
            this.btn_category_update.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_category_update.UseSelectable = true;
            this.btn_category_update.UseStyleColors = true;
            this.btn_category_update.Click += new System.EventHandler(this.btn_category_update_Click);
            // 
            // btn_category_add
            // 
            this.btn_category_add.Location = new System.Drawing.Point(295, 199);
            this.btn_category_add.Name = "btn_category_add";
            this.btn_category_add.Size = new System.Drawing.Size(185, 32);
            this.btn_category_add.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_category_add.TabIndex = 6;
            this.btn_category_add.Text = "Add";
            this.btn_category_add.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_category_add.UseSelectable = true;
            this.btn_category_add.UseStyleColors = true;
            this.btn_category_add.Click += new System.EventHandler(this.btn_category_add_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(530, 84);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(140, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Category Description";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(567, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 20);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Category";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tb_category_desc
            // 
            // 
            // 
            // 
            this.tb_category_desc.CustomButton.Image = null;
            this.tb_category_desc.CustomButton.Location = new System.Drawing.Point(533, 2);
            this.tb_category_desc.CustomButton.Name = "";
            this.tb_category_desc.CustomButton.Size = new System.Drawing.Size(75, 75);
            this.tb_category_desc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_category_desc.CustomButton.TabIndex = 1;
            this.tb_category_desc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_category_desc.CustomButton.UseSelectable = true;
            this.tb_category_desc.CustomButton.Visible = false;
            this.tb_category_desc.Lines = new string[0];
            this.tb_category_desc.Location = new System.Drawing.Point(295, 110);
            this.tb_category_desc.MaxLength = 32767;
            this.tb_category_desc.Multiline = true;
            this.tb_category_desc.Name = "tb_category_desc";
            this.tb_category_desc.PasswordChar = '\0';
            this.tb_category_desc.PromptText = "Description";
            this.tb_category_desc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_category_desc.SelectedText = "";
            this.tb_category_desc.SelectionLength = 0;
            this.tb_category_desc.SelectionStart = 0;
            this.tb_category_desc.ShortcutsEnabled = true;
            this.tb_category_desc.ShowClearButton = true;
            this.tb_category_desc.Size = new System.Drawing.Size(611, 80);
            this.tb_category_desc.Style = MetroFramework.MetroColorStyle.Green;
            this.tb_category_desc.TabIndex = 3;
            this.tb_category_desc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tb_category_desc.UseSelectable = true;
            this.tb_category_desc.UseStyleColors = true;
            this.tb_category_desc.WaterMark = "Description";
            this.tb_category_desc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_category_desc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.dgv_categories);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 303);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1192, 478);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // dgv_categories
            // 
            this.dgv_categories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_categories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_categories.Location = new System.Drawing.Point(0, 0);
            this.dgv_categories.Name = "dgv_categories";
            this.dgv_categories.RowHeadersWidth = 51;
            this.dgv_categories.RowTemplate.Height = 24;
            this.dgv_categories.Size = new System.Drawing.Size(1192, 478);
            this.dgv_categories.TabIndex = 2;
            this.dgv_categories.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_categories_RowHeaderMouseClick);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 801);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Categories";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Categories";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Categories_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox tb_category_desc;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.DataGridView dgv_categories;
        private MetroFramework.Controls.MetroButton btn_category_delete;
        private MetroFramework.Controls.MetroButton btn_category_update;
        private MetroFramework.Controls.MetroButton btn_category_add;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tb_category;
    }
}