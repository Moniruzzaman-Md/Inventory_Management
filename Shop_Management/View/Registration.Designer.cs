

namespace Shop_Management.View
{
    partial class Registration
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
            this.panel_registration = new System.Windows.Forms.Panel();
            this.label_backToLogin = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.text_confirmPassword = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_userName = new System.Windows.Forms.TextBox();
            this.label_registration = new System.Windows.Forms.Label();
            this.panel_right = new System.Windows.Forms.Panel();
            this.panel_confirmPass_showHide = new System.Windows.Forms.Panel();
            this.panel_pass_showHide = new System.Windows.Forms.Panel();
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel_registration.SuspendLayout();
            this.panel_right.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_registration
            // 
            this.panel_registration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_registration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.panel_registration.Controls.Add(this.label_backToLogin);
            this.panel_registration.Controls.Add(this.btn_cancel);
            this.panel_registration.Controls.Add(this.btn_register);
            this.panel_registration.Controls.Add(this.text_confirmPassword);
            this.panel_registration.Controls.Add(this.text_password);
            this.panel_registration.Controls.Add(this.text_name);
            this.panel_registration.Controls.Add(this.text_userName);
            this.panel_registration.Controls.Add(this.label_registration);
            this.panel_registration.Controls.Add(this.panel_right);
            this.panel_registration.Controls.Add(this.panel_left);
            this.panel_registration.Location = new System.Drawing.Point(268, 134);
            this.panel_registration.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel_registration.MaximumSize = new System.Drawing.Size(400, 280);
            this.panel_registration.MinimumSize = new System.Drawing.Size(400, 280);
            this.panel_registration.Name = "panel_registration";
            this.panel_registration.Size = new System.Drawing.Size(400, 280);
            this.panel_registration.TabIndex = 0;
            // 
            // label_backToLogin
            // 
            this.label_backToLogin.AutoSize = true;
            this.label_backToLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_backToLogin.ForeColor = System.Drawing.Color.White;
            this.label_backToLogin.Location = new System.Drawing.Point(89, 247);
            this.label_backToLogin.Name = "label_backToLogin";
            this.label_backToLogin.Size = new System.Drawing.Size(228, 19);
            this.label_backToLogin.TabIndex = 9;
            this.label_backToLogin.Text = "Already have an account? Sign up";
            this.label_backToLogin.Click += new System.EventHandler(this.label_backToLogin_Click);
            this.label_backToLogin.MouseEnter += new System.EventHandler(this.label_backToLogin_MouseEnter);
            this.label_backToLogin.MouseLeave += new System.EventHandler(this.label_backToLogin_MouseLeave);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkRed;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(201, 207);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(126, 35);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(73, 207);
            this.btn_register.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(126, 35);
            this.btn_register.TabIndex = 7;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // text_confirmPassword
            // 
            this.text_confirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.text_confirmPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_confirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.text_confirmPassword.Location = new System.Drawing.Point(72, 165);
            this.text_confirmPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.text_confirmPassword.MaxLength = 60;
            this.text_confirmPassword.Name = "text_confirmPassword";
            this.text_confirmPassword.Size = new System.Drawing.Size(255, 32);
            this.text_confirmPassword.TabIndex = 6;
            this.text_confirmPassword.Text = "Confirm Password";
            this.text_confirmPassword.Enter += new System.EventHandler(this.text_confirmPassword_Enter);
            this.text_confirmPassword.Leave += new System.EventHandler(this.text_confirmPassword_Leave);
            // 
            // text_password
            // 
            this.text_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.text_password.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_password.ForeColor = System.Drawing.Color.Gray;
            this.text_password.Location = new System.Drawing.Point(72, 123);
            this.text_password.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.text_password.MaxLength = 60;
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(255, 32);
            this.text_password.TabIndex = 5;
            this.text_password.Text = "Password";
            this.text_password.Enter += new System.EventHandler(this.text_password_Enter);
            this.text_password.Leave += new System.EventHandler(this.text_password_Leave);
            // 
            // text_name
            // 
            this.text_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.text_name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_name.ForeColor = System.Drawing.Color.Gray;
            this.text_name.Location = new System.Drawing.Point(72, 81);
            this.text_name.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.text_name.MaxLength = 50;
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(255, 32);
            this.text_name.TabIndex = 4;
            this.text_name.Text = "Full Name";
            this.text_name.Enter += new System.EventHandler(this.text_name_Enter);
            this.text_name.Leave += new System.EventHandler(this.text_name_Leave);
            // 
            // text_userName
            // 
            this.text_userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.text_userName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_userName.ForeColor = System.Drawing.Color.Gray;
            this.text_userName.Location = new System.Drawing.Point(72, 39);
            this.text_userName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.text_userName.MaxLength = 50;
            this.text_userName.Name = "text_userName";
            this.text_userName.Size = new System.Drawing.Size(255, 32);
            this.text_userName.TabIndex = 3;
            this.text_userName.Text = "User Name";
            this.text_userName.Enter += new System.EventHandler(this.text_userName_Enter);
            this.text_userName.Leave += new System.EventHandler(this.text_userName_Leave);
            // 
            // label_registration
            // 
            this.label_registration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_registration.AutoSize = true;
            this.label_registration.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_registration.ForeColor = System.Drawing.Color.White;
            this.label_registration.Location = new System.Drawing.Point(108, 10);
            this.label_registration.Name = "label_registration";
            this.label_registration.Size = new System.Drawing.Size(178, 24);
            this.label_registration.TabIndex = 2;
            this.label_registration.Text = "We need some Info";
            // 
            // panel_right
            // 
            this.panel_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.panel_right.Controls.Add(this.panel_confirmPass_showHide);
            this.panel_right.Controls.Add(this.panel_pass_showHide);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_right.Location = new System.Drawing.Point(333, 0);
            this.panel_right.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(67, 280);
            this.panel_right.TabIndex = 1;
            // 
            // panel_confirmPass_showHide
            // 
            this.panel_confirmPass_showHide.BackgroundImage = global::Shop_Management.Properties.Resources.hide_password;
            this.panel_confirmPass_showHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_confirmPass_showHide.Location = new System.Drawing.Point(0, 168);
            this.panel_confirmPass_showHide.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel_confirmPass_showHide.Name = "panel_confirmPass_showHide";
            this.panel_confirmPass_showHide.Size = new System.Drawing.Size(20, 20);
            this.panel_confirmPass_showHide.TabIndex = 1;
            this.panel_confirmPass_showHide.Click += new System.EventHandler(this.panel_confirmPass_showHide_Click);
            // 
            // panel_pass_showHide
            // 
            this.panel_pass_showHide.BackgroundImage = global::Shop_Management.Properties.Resources.hide_password;
            this.panel_pass_showHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_pass_showHide.Location = new System.Drawing.Point(0, 127);
            this.panel_pass_showHide.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel_pass_showHide.Name = "panel_pass_showHide";
            this.panel_pass_showHide.Size = new System.Drawing.Size(20, 20);
            this.panel_pass_showHide.TabIndex = 0;
            this.panel_pass_showHide.Click += new System.EventHandler(this.panel_pass_showHide_Click);
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(67, 280);
            this.panel_left.TabIndex = 0;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panel_registration);
            this.MaximumSize = new System.Drawing.Size(950, 600);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Registration";
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            this.panel_registration.ResumeLayout(false);
            this.panel_registration.PerformLayout();
            this.panel_right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_registration;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Label label_registration;
        private System.Windows.Forms.TextBox text_userName;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.TextBox text_confirmPassword;
        private System.Windows.Forms.Panel panel_pass_showHide;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel panel_confirmPass_showHide;
        private System.Windows.Forms.Label label_backToLogin;
    }
}