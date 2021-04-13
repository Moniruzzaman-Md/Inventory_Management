
namespace Inventory_Management.View
{
    partial class Login
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
            this.panel_login = new System.Windows.Forms.Panel();
            this.label_create_account = new System.Windows.Forms.Label();
            this.panel_login_icon = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_password = new System.Windows.Forms.TextBox();
            this.panel_right = new System.Windows.Forms.Panel();
            this.panel_pass_showHide = new System.Windows.Forms.Panel();
            this.text_userName = new System.Windows.Forms.TextBox();
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel_pass_icon = new System.Windows.Forms.Panel();
            this.userImage = new System.Windows.Forms.Panel();
            this.panel_login.SuspendLayout();
            this.panel_right.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_login
            // 
            this.panel_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.panel_login.Controls.Add(this.label_create_account);
            this.panel_login.Controls.Add(this.panel_login_icon);
            this.panel_login.Controls.Add(this.btn_login);
            this.panel_login.Controls.Add(this.label1);
            this.panel_login.Controls.Add(this.text_password);
            this.panel_login.Controls.Add(this.panel_right);
            this.panel_login.Controls.Add(this.text_userName);
            this.panel_login.Controls.Add(this.panel_left);
            this.panel_login.Location = new System.Drawing.Point(268, 133);
            this.panel_login.MaximumSize = new System.Drawing.Size(400, 280);
            this.panel_login.MinimumSize = new System.Drawing.Size(400, 280);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(400, 280);
            this.panel_login.TabIndex = 0;
            // 
            // label_create_account
            // 
            this.label_create_account.AutoSize = true;
            this.label_create_account.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_create_account.ForeColor = System.Drawing.Color.White;
            this.label_create_account.Location = new System.Drawing.Point(118, 228);
            this.label_create_account.Name = "label_create_account";
            this.label_create_account.Size = new System.Drawing.Size(149, 19);
            this.label_create_account.TabIndex = 7;
            this.label_create_account.Text = "Create a new account";
            this.label_create_account.Click += new System.EventHandler(this.label_create_account_Click);
            this.label_create_account.MouseEnter += new System.EventHandler(this.label_create_account_MouseEnter);
            this.label_create_account.MouseLeave += new System.EventHandler(this.label_create_account_MouseLeave);
            // 
            // panel_login_icon
            // 
            this.panel_login_icon.BackColor = System.Drawing.Color.SeaGreen;
            this.panel_login_icon.BackgroundImage = global::Inventory_Management.Properties.Resources.enter;
            this.panel_login_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_login_icon.Location = new System.Drawing.Point(82, 176);
            this.panel_login_icon.Name = "panel_login_icon";
            this.panel_login_icon.Size = new System.Drawing.Size(30, 30);
            this.panel_login_icon.TabIndex = 0;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(73, 171);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(254, 40);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Sign In";
            // 
            // text_password
            // 
            this.text_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.text_password.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_password.ForeColor = System.Drawing.Color.White;
            this.text_password.Location = new System.Drawing.Point(73, 124);
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '*';
            this.text_password.Size = new System.Drawing.Size(254, 32);
            this.text_password.TabIndex = 4;
            this.text_password.Enter += new System.EventHandler(this.text_password_Enter);
            // 
            // panel_right
            // 
            this.panel_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.panel_right.Controls.Add(this.panel_pass_showHide);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_right.Location = new System.Drawing.Point(333, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(67, 280);
            this.panel_right.TabIndex = 3;
            // 
            // panel_pass_showHide
            // 
            this.panel_pass_showHide.BackgroundImage = global::Inventory_Management.Properties.Resources.show_password;
            this.panel_pass_showHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_pass_showHide.Location = new System.Drawing.Point(0, 130);
            this.panel_pass_showHide.Name = "panel_pass_showHide";
            this.panel_pass_showHide.Size = new System.Drawing.Size(20, 20);
            this.panel_pass_showHide.TabIndex = 0;
            this.panel_pass_showHide.Click += new System.EventHandler(this.panel_pass_showHide_Click);
            // 
            // text_userName
            // 
            this.text_userName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.text_userName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_userName.ForeColor = System.Drawing.Color.White;
            this.text_userName.Location = new System.Drawing.Point(73, 78);
            this.text_userName.Name = "text_userName";
            this.text_userName.Size = new System.Drawing.Size(254, 32);
            this.text_userName.TabIndex = 2;
            this.text_userName.Enter += new System.EventHandler(this.text_userName_Enter);
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.panel_left.Controls.Add(this.panel_pass_icon);
            this.panel_left.Controls.Add(this.userImage);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Margin = new System.Windows.Forms.Padding(30);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(67, 280);
            this.panel_left.TabIndex = 1;
            // 
            // panel_pass_icon
            // 
            this.panel_pass_icon.BackgroundImage = global::Inventory_Management.Properties.Resources.password;
            this.panel_pass_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_pass_icon.Location = new System.Drawing.Point(47, 130);
            this.panel_pass_icon.Name = "panel_pass_icon";
            this.panel_pass_icon.Size = new System.Drawing.Size(20, 20);
            this.panel_pass_icon.TabIndex = 0;
            // 
            // userImage
            // 
            this.userImage.BackgroundImage = global::Inventory_Management.Properties.Resources.default_user;
            this.userImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userImage.Location = new System.Drawing.Point(47, 82);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(20, 20);
            this.userImage.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panel_login);
            this.MaximumSize = new System.Drawing.Size(950, 600);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_right.ResumeLayout(false);
            this.panel_left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Panel userImage;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_pass_icon;
        private System.Windows.Forms.TextBox text_userName;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Panel panel_pass_showHide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_login_icon;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label_create_account;
    }
}