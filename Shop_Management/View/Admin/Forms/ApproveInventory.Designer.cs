
namespace Inventory_Management.View.Admin.Forms
{
    partial class ApproveInventory
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
            this.label_unapproved_Inventory_count = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Content = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label_unapproved_Inventory_count
            // 
            this.label_unapproved_Inventory_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.label_unapproved_Inventory_count.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_unapproved_Inventory_count.Location = new System.Drawing.Point(0, 0);
            this.label_unapproved_Inventory_count.Name = "label_unapproved_Inventory_count";
            this.label_unapproved_Inventory_count.Size = new System.Drawing.Size(800, 54);
            this.label_unapproved_Inventory_count.TabIndex = 0;
            this.label_unapproved_Inventory_count.Text = "No Unapproved Product found";
            this.label_unapproved_Inventory_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_Content
            // 
            this.flowLayoutPanel_Content.AutoScroll = true;
            this.flowLayoutPanel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Content.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Content.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.flowLayoutPanel_Content.Location = new System.Drawing.Point(0, 54);
            this.flowLayoutPanel_Content.Name = "flowLayoutPanel_Content";
            this.flowLayoutPanel_Content.Size = new System.Drawing.Size(800, 396);
            this.flowLayoutPanel_Content.TabIndex = 1;
            // 
            // ApproveInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel_Content);
            this.Controls.Add(this.label_unapproved_Inventory_count);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApproveInventory";
            this.Text = "Approve Inventory";
            this.Load += new System.EventHandler(this.ApproveInventory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_unapproved_Inventory_count;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Content;
    }
}