
using Inventory_Management.Properties;
using System.Drawing;
using System.Security.Policy;

namespace Inventory_Management.View.Employee
{

    //public static Image resizeImage(Image imgToResize, Size size)
    //{
    //    return (Image)(new Bitmap(imgToResize, size));
    //(Image)(new Bitmap(global::Shop_Management.Properties.Resources.store, new Size(25,25)));
    //}

    //yourImage = resizeImage(yourImage, new Size(50,50));

    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.panel_left = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_add_product = new System.Windows.Forms.Button();
            this.btn_showProduct = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.panel_header = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label_header = new System.Windows.Forms.Label();
            this.panel_clildForm = new System.Windows.Forms.Panel();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.panel_left.Controls.Add(this.btn_settings);
            this.panel_left.Controls.Add(this.btn_add_product);
            this.panel_left.Controls.Add(this.btn_showProduct);
            this.panel_left.Controls.Add(this.label_Name);
            this.panel_left.Controls.Add(this.pictureBox_user);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(200, 561);
            this.panel_left.TabIndex = 0;
            // 
            // btn_settings
            // 
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_settings.Image")));
            this.btn_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.Location = new System.Drawing.Point(0, 213);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_settings.Size = new System.Drawing.Size(200, 61);
            this.btn_settings.TabIndex = 4;
            this.btn_settings.Text = "  Settings";
            this.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_add_product
            // 
            this.btn_add_product.FlatAppearance.BorderSize = 0;
            this.btn_add_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_product.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add_product.ForeColor = System.Drawing.Color.White;
            this.btn_add_product.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_product.Image")));
            this.btn_add_product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_product.Location = new System.Drawing.Point(0, 156);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_add_product.Size = new System.Drawing.Size(200, 61);
            this.btn_add_product.TabIndex = 3;
            this.btn_add_product.Text = "  Add New Item";
            this.btn_add_product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add_product.UseVisualStyleBackColor = true;
            this.btn_add_product.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // btn_showProduct
            // 
            this.btn_showProduct.FlatAppearance.BorderSize = 0;
            this.btn_showProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showProduct.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_showProduct.ForeColor = System.Drawing.Color.White;
            this.btn_showProduct.Image = ((System.Drawing.Image)(resources.GetObject("btn_showProduct.Image")));
            this.btn_showProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_showProduct.Location = new System.Drawing.Point(0, 98);
            this.btn_showProduct.Name = "btn_showProduct";
            this.btn_showProduct.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_showProduct.Size = new System.Drawing.Size(200, 61);
            this.btn_showProduct.TabIndex = 2;
            this.btn_showProduct.Text = "  Inventory List";
            this.btn_showProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_showProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_showProduct.UseVisualStyleBackColor = true;
            this.btn_showProduct.Click += new System.EventHandler(this.btn_showProduct_Click);
            // 
            // label_Name
            // 
            this.label_Name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Name.ForeColor = System.Drawing.Color.White;
            this.label_Name.Location = new System.Drawing.Point(0, 55);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(200, 40);
            this.label_Name.TabIndex = 1;
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
            this.pictureBox_user.TabIndex = 0;
            this.pictureBox_user.TabStop = false;
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
            this.panel_header.TabIndex = 1;
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
            this.label_header.Size = new System.Drawing.Size(734, 52);
            this.label_header.TabIndex = 0;
            this.label_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_clildForm
            // 
            this.panel_clildForm.BackColor = System.Drawing.Color.Gray;
            this.panel_clildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_clildForm.Location = new System.Drawing.Point(200, 92);
            this.panel_clildForm.Name = "panel_clildForm";
            this.panel_clildForm.Size = new System.Drawing.Size(734, 469);
            this.panel_clildForm.TabIndex = 2;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panel_clildForm);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel_left);
            this.MaximumSize = new System.Drawing.Size(950, 600);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Employee";
            this.Text = "Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_FormClosing);
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.panel_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel_clildForm;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.PictureBox pictureBox_user;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button btn_showProduct;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_add_product;
    }
}