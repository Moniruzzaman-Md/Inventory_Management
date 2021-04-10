
namespace Shop_Management.View.Notification.Admin
{
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
            this.panel_nav = new System.Windows.Forms.Panel();
            this.btn_approveEmployee = new System.Windows.Forms.Button();
            this.panel_nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_nav
            // 
            this.panel_nav.Controls.Add(this.btn_approveEmployee);
            this.panel_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_nav.Location = new System.Drawing.Point(0, 0);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(200, 450);
            this.panel_nav.TabIndex = 0;
            // 
            // btn_approveEmployee
            // 
            this.btn_approveEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.btn_approveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_approveEmployee.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_approveEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_approveEmployee.Location = new System.Drawing.Point(0, 0);
            this.btn_approveEmployee.Name = "btn_approveEmployee";
            this.btn_approveEmployee.Size = new System.Drawing.Size(200, 61);
            this.btn_approveEmployee.TabIndex = 0;
            this.btn_approveEmployee.Text = "Approve User";
            this.btn_approveEmployee.UseVisualStyleBackColor = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_nav);
            this.Name = "Admin";
            this.Text = "Admin";
            this.panel_nav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.Button btn_approveEmployee;
    }
}