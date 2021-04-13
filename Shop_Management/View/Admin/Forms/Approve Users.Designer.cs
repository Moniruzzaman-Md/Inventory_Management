
namespace Inventory_Management.View.Admin.Forms
{
    partial class Approve_Users
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
            this.panel_Unapproved_user_count = new System.Windows.Forms.Panel();
            this.label_unapproved_user_count = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Content = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Unapproved_user_count.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Unapproved_user_count
            // 
            this.panel_Unapproved_user_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.panel_Unapproved_user_count.Controls.Add(this.label_unapproved_user_count);
            this.panel_Unapproved_user_count.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Unapproved_user_count.Location = new System.Drawing.Point(0, 0);
            this.panel_Unapproved_user_count.Name = "panel_Unapproved_user_count";
            this.panel_Unapproved_user_count.Size = new System.Drawing.Size(800, 54);
            this.panel_Unapproved_user_count.TabIndex = 0;
            // 
            // label_unapproved_user_count
            // 
            this.label_unapproved_user_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_unapproved_user_count.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_unapproved_user_count.ForeColor = System.Drawing.Color.White;
            this.label_unapproved_user_count.Location = new System.Drawing.Point(0, 0);
            this.label_unapproved_user_count.Name = "label_unapproved_user_count";
            this.label_unapproved_user_count.Size = new System.Drawing.Size(800, 54);
            this.label_unapproved_user_count.TabIndex = 0;
            this.label_unapproved_user_count.Text = "No Unapproved Users found";
            this.label_unapproved_user_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_Content
            // 
            this.flowLayoutPanel_Content.AutoScroll = true;
            this.flowLayoutPanel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Content.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Content.Location = new System.Drawing.Point(0, 54);
            this.flowLayoutPanel_Content.Name = "flowLayoutPanel_Content";
            this.flowLayoutPanel_Content.Size = new System.Drawing.Size(800, 396);
            this.flowLayoutPanel_Content.TabIndex = 1;
            this.flowLayoutPanel_Content.WrapContents = false;
            // 
            // Approve_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel_Content);
            this.Controls.Add(this.panel_Unapproved_user_count);
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Approve_Users";
            this.Text = "Approve Users";
            this.Load += new System.EventHandler(this.Approve_Users_Load);
            this.panel_Unapproved_user_count.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Unapproved_user_count;
        private System.Windows.Forms.Label label_unapproved_user_count;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Content;
    }
}