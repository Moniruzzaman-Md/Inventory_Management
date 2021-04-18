
using System.Drawing;
using System.Security.Policy;

namespace Inventory_Management.View.Admin
{

    //public static Image resizeImage(Image imgToResize, Size size)
    //{
    //    return (Image)(new Bitmap(imgToResize, size));
    //(Image)(new Bitmap(global::Inventory_Management.Properties.Resources.inventory, new Size(25,25)));
    //}

    //yourImage = resizeImage(yourImage, new Size(50,50));


    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel_nav = new System.Windows.Forms.Panel();
            this.btn_UpdateProduct = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_ApproveInventory = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.btn_approveEmployee = new System.Windows.Forms.Button();
            this.btn_time = new System.Windows.Forms.Button();
            this.panel_clildForm = new System.Windows.Forms.Panel();
            this.panel_header = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label_header = new System.Windows.Forms.Label();
            this.panel_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_nav
            // 
            this.panel_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.panel_nav.Controls.Add(this.btn_UpdateProduct);
            this.panel_nav.Controls.Add(this.btn_Settings);
            this.panel_nav.Controls.Add(this.btn_ApproveInventory);
            this.panel_nav.Controls.Add(this.label_Name);
            this.panel_nav.Controls.Add(this.pictureBox_user);
            this.panel_nav.Controls.Add(this.btn_approveEmployee);
            this.panel_nav.Controls.Add(this.btn_time);
            this.panel_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_nav.Location = new System.Drawing.Point(0, 0);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(200, 559);
            this.panel_nav.TabIndex = 0;
            // 
            // btn_UpdateProduct
            // 
            this.btn_UpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btn_UpdateProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_UpdateProduct.FlatAppearance.BorderSize = 0;
            this.btn_UpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateProduct.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_UpdateProduct.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateProduct.Image = ((System.Drawing.Image)(resources.GetObject("btn_UpdateProduct.Image")));
            this.btn_UpdateProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UpdateProduct.Location = new System.Drawing.Point(0, 214);
            this.btn_UpdateProduct.Name = "btn_UpdateProduct";
            this.btn_UpdateProduct.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_UpdateProduct.Size = new System.Drawing.Size(200, 61);
            this.btn_UpdateProduct.TabIndex = 8;
            this.btn_UpdateProduct.Text = "  Update Product";
            this.btn_UpdateProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_UpdateProduct.UseVisualStyleBackColor = false;
            this.btn_UpdateProduct.Click += new System.EventHandler(this.btn_UpdateQuantity_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Settings.ForeColor = System.Drawing.Color.White;
            this.btn_Settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_Settings.Image")));
            this.btn_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Settings.Location = new System.Drawing.Point(0, 272);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_Settings.Size = new System.Drawing.Size(200, 61);
            this.btn_Settings.TabIndex = 6;
            this.btn_Settings.Text = "  Settings";
            this.btn_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Settings.UseVisualStyleBackColor = false;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_ApproveInventory
            // 
            this.btn_ApproveInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btn_ApproveInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ApproveInventory.FlatAppearance.BorderSize = 0;
            this.btn_ApproveInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ApproveInventory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ApproveInventory.ForeColor = System.Drawing.Color.White;
            this.btn_ApproveInventory.Image = ((System.Drawing.Image)(resources.GetObject("btn_ApproveInventory.Image")));
            this.btn_ApproveInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ApproveInventory.Location = new System.Drawing.Point(0, 156);
            this.btn_ApproveInventory.Name = "btn_ApproveInventory";
            this.btn_ApproveInventory.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_ApproveInventory.Size = new System.Drawing.Size(200, 61);
            this.btn_ApproveInventory.TabIndex = 4;
            this.btn_ApproveInventory.Text = "  Approve Inventory";
            this.btn_ApproveInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ApproveInventory.UseVisualStyleBackColor = false;
            this.btn_ApproveInventory.Click += new System.EventHandler(this.btn_ApproveInventory_Click);
            // 
            // label_Name
            // 
            this.label_Name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Name.ForeColor = System.Drawing.Color.White;
            this.label_Name.Location = new System.Drawing.Point(0, 55);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(200, 40);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "Moniruzzaman MD";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_user.Image = global::Inventory_Management.Properties.Resources.user;
            this.pictureBox_user.Location = new System.Drawing.Point(75, 12);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_user.TabIndex = 2;
            this.pictureBox_user.TabStop = false;
            // 
            // btn_approveEmployee
            // 
            this.btn_approveEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btn_approveEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_approveEmployee.FlatAppearance.BorderSize = 0;
            this.btn_approveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_approveEmployee.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_approveEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_approveEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btn_approveEmployee.Image")));
            this.btn_approveEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_approveEmployee.Location = new System.Drawing.Point(0, 98);
            this.btn_approveEmployee.Name = "btn_approveEmployee";
            this.btn_approveEmployee.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_approveEmployee.Size = new System.Drawing.Size(200, 61);
            this.btn_approveEmployee.TabIndex = 0;
            this.btn_approveEmployee.Text = "  Approve Users";
            this.btn_approveEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_approveEmployee.UseVisualStyleBackColor = false;
            this.btn_approveEmployee.Click += new System.EventHandler(this.btn_approveEmployee_Click);
            // 
            // btn_time
            // 
            this.btn_time.BackColor = System.Drawing.Color.Transparent;
            this.btn_time.FlatAppearance.BorderSize = 0;
            this.btn_time.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_time.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_time.Location = new System.Drawing.Point(-6, 0);
            this.btn_time.Name = "btn_time";
            this.btn_time.Size = new System.Drawing.Size(200, 95);
            this.btn_time.TabIndex = 0;
            this.btn_time.UseVisualStyleBackColor = false;
            this.btn_time.Click += new System.EventHandler(this.btn_time_Click);
            // 
            // panel_clildForm
            // 
            this.panel_clildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.panel_clildForm.Location = new System.Drawing.Point(200, 90);
            this.panel_clildForm.Name = "panel_clildForm";
            this.panel_clildForm.Size = new System.Drawing.Size(734, 471);
            this.panel_clildForm.TabIndex = 1;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.panel_header.Controls.Add(this.btn_logout);
            this.panel_header.Controls.Add(this.label_header);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(200, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(734, 92);
            this.panel_header.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.DarkRed;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(628, 55);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(94, 29);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "  Logout";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label_header
            // 
            this.label_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_header.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_header.ForeColor = System.Drawing.Color.White;
            this.label_header.Location = new System.Drawing.Point(0, 0);
            this.label_header.Name = "label_header";
            this.label_header.Padding = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.label_header.Size = new System.Drawing.Size(734, 52);
            this.label_header.TabIndex = 0;
            this.label_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(934, 559);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel_clildForm);
            this.Controls.Add(this.panel_nav);
            this.MaximumSize = new System.Drawing.Size(950, 598);
            this.MinimumSize = new System.Drawing.Size(950, 598);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.panel_nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.panel_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.PictureBox pictureBox_user;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_ApproveInventory;
        private System.Windows.Forms.Button btn_approveEmployee;
        private System.Windows.Forms.Panel panel_clildForm;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_UpdateProduct;
        private System.Windows.Forms.Button btn_time;
    }
}