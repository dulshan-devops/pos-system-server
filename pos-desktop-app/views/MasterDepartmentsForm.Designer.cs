namespace pos_desktop_app.views
{
    partial class MasterDepartmentsForm
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
            this.mlv_departments = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // mlv_departments
            // 
            this.mlv_departments.BackColor = System.Drawing.Color.Black;
            this.mlv_departments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlv_departments.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlv_departments.FullRowSelect = true;
            this.mlv_departments.HoverSelection = true;
            this.mlv_departments.Location = new System.Drawing.Point(20, 60);
            this.mlv_departments.Name = "mlv_departments";
            this.mlv_departments.OwnerDraw = true;
            this.mlv_departments.Size = new System.Drawing.Size(824, 517);
            this.mlv_departments.Style = MetroFramework.MetroColorStyle.Green;
            this.mlv_departments.TabIndex = 0;
            this.mlv_departments.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mlv_departments.UseCompatibleStateImageBehavior = false;
            this.mlv_departments.UseSelectable = true;
            this.mlv_departments.UseStyleColors = true;
            // 
            // MasterDepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 597);
            this.Controls.Add(this.mlv_departments);
            this.Name = "MasterDepartmentsForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Departments";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView mlv_departments;
    }
}