
namespace Inventory_Management.Shared
{
    partial class Settings
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_confirmPassowrd = new System.Windows.Forms.TextBox();
            this.text_newPassword = new System.Windows.Forms.TextBox();
            this.text_oldPassword = new System.Windows.Forms.TextBox();
            this.label_edit_cancel_password = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_edit_cancel_name = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_edit_cancel_Image = new System.Windows.Forms.Label();
            this.label_edit_cancel_username = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_Username = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Inventory_Management.Properties.Resources.user;
            this.pictureBox.InitialImage = global::Inventory_Management.Properties.Resources.user;
            this.pictureBox.Location = new System.Drawing.Point(181, 14);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 100);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.text_confirmPassowrd);
            this.panel1.Controls.Add(this.text_newPassword);
            this.panel1.Controls.Add(this.text_oldPassword);
            this.panel1.Controls.Add(this.label_edit_cancel_password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label_edit_cancel_name);
            this.panel1.Controls.Add(this.label_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label_edit_cancel_Image);
            this.panel1.Controls.Add(this.label_edit_cancel_username);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.label_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.text_Username);
            this.panel1.Controls.Add(this.text_name);
            this.panel1.Location = new System.Drawing.Point(98, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 316);
            this.panel1.TabIndex = 1;
            // 
            // text_confirmPassowrd
            // 
            this.text_confirmPassowrd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_confirmPassowrd.Location = new System.Drawing.Point(297, 235);
            this.text_confirmPassowrd.Name = "text_confirmPassowrd";
            this.text_confirmPassowrd.Size = new System.Drawing.Size(154, 29);
            this.text_confirmPassowrd.TabIndex = 15;
            this.text_confirmPassowrd.Text = "Confirm Password";
            this.text_confirmPassowrd.Visible = false;
            this.text_confirmPassowrd.Enter += new System.EventHandler(this.text_confirmPassowrd_Enter);
            // 
            // text_newPassword
            // 
            this.text_newPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_newPassword.Location = new System.Drawing.Point(160, 235);
            this.text_newPassword.Name = "text_newPassword";
            this.text_newPassword.Size = new System.Drawing.Size(131, 29);
            this.text_newPassword.TabIndex = 14;
            this.text_newPassword.Text = "New Password";
            this.text_newPassword.Visible = false;
            this.text_newPassword.Enter += new System.EventHandler(this.text_newPassword_Enter);
            // 
            // text_oldPassword
            // 
            this.text_oldPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_oldPassword.Location = new System.Drawing.Point(23, 235);
            this.text_oldPassword.Name = "text_oldPassword";
            this.text_oldPassword.Size = new System.Drawing.Size(131, 29);
            this.text_oldPassword.TabIndex = 13;
            this.text_oldPassword.Text = "Old Password";
            this.text_oldPassword.Visible = false;
            this.text_oldPassword.Enter += new System.EventHandler(this.text_oldPassword_Enter);
            // 
            // label_edit_cancel_password
            // 
            this.label_edit_cancel_password.AutoSize = true;
            this.label_edit_cancel_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_edit_cancel_password.ForeColor = System.Drawing.Color.Chartreuse;
            this.label_edit_cancel_password.Location = new System.Drawing.Point(160, 207);
            this.label_edit_cancel_password.Name = "label_edit_cancel_password";
            this.label_edit_cancel_password.Size = new System.Drawing.Size(27, 15);
            this.label_edit_cancel_password.TabIndex = 12;
            this.label_edit_cancel_password.Text = "Edit";
            this.label_edit_cancel_password.Click += new System.EventHandler(this.label_edit_cancel_password_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // label_edit_cancel_name
            // 
            this.label_edit_cancel_name.AutoSize = true;
            this.label_edit_cancel_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_edit_cancel_name.ForeColor = System.Drawing.Color.Chartreuse;
            this.label_edit_cancel_name.Location = new System.Drawing.Point(356, 175);
            this.label_edit_cancel_name.Name = "label_edit_cancel_name";
            this.label_edit_cancel_name.Size = new System.Drawing.Size(27, 15);
            this.label_edit_cancel_name.TabIndex = 10;
            this.label_edit_cancel_name.Text = "Edit";
            this.label_edit_cancel_name.Click += new System.EventHandler(this.label_edit_cancel_name_Click);
            // 
            // label_Name
            // 
            this.label_Name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Name.ForeColor = System.Drawing.Color.Aquamarine;
            this.label_Name.Location = new System.Drawing.Point(166, 169);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(181, 25);
            this.label_Name.TabIndex = 8;
            this.label_Name.Text = "Default Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label_edit_cancel_Image
            // 
            this.label_edit_cancel_Image.AutoSize = true;
            this.label_edit_cancel_Image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_edit_cancel_Image.ForeColor = System.Drawing.Color.Chartreuse;
            this.label_edit_cancel_Image.Location = new System.Drawing.Point(287, 99);
            this.label_edit_cancel_Image.Name = "label_edit_cancel_Image";
            this.label_edit_cancel_Image.Size = new System.Drawing.Size(27, 15);
            this.label_edit_cancel_Image.TabIndex = 6;
            this.label_edit_cancel_Image.Text = "Edit";
            this.label_edit_cancel_Image.Click += new System.EventHandler(this.label_edit_cancel_Image_Click);
            // 
            // label_edit_cancel_username
            // 
            this.label_edit_cancel_username.AutoSize = true;
            this.label_edit_cancel_username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_edit_cancel_username.ForeColor = System.Drawing.Color.Chartreuse;
            this.label_edit_cancel_username.Location = new System.Drawing.Point(356, 145);
            this.label_edit_cancel_username.Name = "label_edit_cancel_username";
            this.label_edit_cancel_username.Size = new System.Drawing.Size(27, 15);
            this.label_edit_cancel_username.TabIndex = 5;
            this.label_edit_cancel_username.Text = "Edit";
            this.label_edit_cancel_username.Click += new System.EventHandler(this.label_edit_cancel_username_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(181, 277);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(109, 29);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save Changes";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label_username
            // 
            this.label_username.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_username.ForeColor = System.Drawing.Color.Aquamarine;
            this.label_username.Location = new System.Drawing.Point(166, 134);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(181, 25);
            this.label_username.TabIndex = 2;
            this.label_username.Text = "Default User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // text_Username
            // 
            this.text_Username.BackColor = System.Drawing.Color.White;
            this.text_Username.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_Username.Location = new System.Drawing.Point(166, 131);
            this.text_Username.Name = "text_Username";
            this.text_Username.Size = new System.Drawing.Size(181, 29);
            this.text_Username.TabIndex = 3;
            this.text_Username.Visible = false;
            this.text_Username.Enter += new System.EventHandler(this.text_Username_Enter);
            // 
            // text_name
            // 
            this.text_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_name.Location = new System.Drawing.Point(166, 165);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(181, 29);
            this.text_name.TabIndex = 9;
            this.text_name.Visible = false;
            this.text_name.Enter += new System.EventHandler(this.text_name_Enter);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox text_Username;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label_edit_cancel_username;
        private System.Windows.Forms.Label label_edit_cancel_Image;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label label_edit_cancel_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_edit_cancel_password;
        private System.Windows.Forms.TextBox text_oldPassword;
        private System.Windows.Forms.TextBox text_newPassword;
        private System.Windows.Forms.TextBox text_confirmPassowrd;
    }
}