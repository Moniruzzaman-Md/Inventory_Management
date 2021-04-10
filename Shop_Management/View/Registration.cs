using Shop_Management.Control;
using Shop_Management.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management.View
{
    public partial class Registration : Form
    {
        private Master _master;
        private bool _passShown = true;
        private bool _confirmPassShown = true;
        public Registration()
        {
            InitializeComponent();
        }
        public void setResources(Master master)
        {
            _master = master;
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //
        // panel_pass_showHide
        //
        private void panel_pass_showHide_Click(object sender, EventArgs e)
        {
            if (!_passShown)
            {
                this.text_password.PasswordChar = '\0';
                _passShown = true;
                this.panel_pass_showHide.BackgroundImage = global::Shop_Management.Properties.Resources.hide_password;
            }
            else
            {
                this.panel_pass_showHide.BackgroundImage = global::Shop_Management.Properties.Resources.show_password;
                _passShown = false;
                this.text_password.PasswordChar = '*';
            }
        }
        //
        // panel_confirmPass_showHide
        //
        private void panel_confirmPass_showHide_Click(object sender, EventArgs e)
        {
            if (!_confirmPassShown)
            {
                this.text_confirmPassword.PasswordChar = '\0';
                _confirmPassShown = true;
                this.panel_confirmPass_showHide.BackgroundImage = global::Shop_Management.Properties.Resources.hide_password;
            }
            else
            {
                this.panel_confirmPass_showHide.BackgroundImage = global::Shop_Management.Properties.Resources.show_password;
                _confirmPassShown = false;
                this.text_confirmPassword.PasswordChar = '*';
            }
        }
        //
        // text_userName
        //
        private void text_userName_Enter(object sender, EventArgs e)
        {
            this.text_userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.text_userName.ForeColor = Color.White;
            if (this.text_userName.Text == "User Name")
            {
                this.text_userName.Text = "";
            }
        }

        private void text_userName_Leave(object sender, EventArgs e)
        {
            if (this.text_userName.Text == "")
            {
                this.text_userName.Text = "User Name";
                this.text_userName.ForeColor = System.Drawing.Color.Gray;
            }
        }
        //
        // text_name
        //
        private void text_name_Enter(object sender, EventArgs e)
        {
            this.text_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.text_name.ForeColor = Color.White;
            if (this.text_name.Text == "Full Name")
            {
                this.text_name.Text = "";
            }
        }

        private void text_name_Leave(object sender, EventArgs e)
        {
            if (this.text_name.Text == "")
            {
                this.text_name.Text = "Full Name";
                this.text_name.ForeColor = System.Drawing.Color.Gray;
            }
        }
        //
        // text_password
        //
        private void text_password_Enter(object sender, EventArgs e)
        {
            this.text_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.text_password.ForeColor = Color.White;
            if (this.text_password.Text == "Password")
            {
                this.text_password.Text = "";
                this.text_password.PasswordChar = '*';
                _passShown = false;
                this.panel_pass_showHide.BackgroundImage = global::Shop_Management.Properties.Resources.show_password;
            }
        }

        private void text_password_Leave(object sender, EventArgs e)
        {
            if (this.text_password.Text == "" || this.text_password.Text == "Password")
            {
                this.text_password.Text = "Password";
                this.text_password.PasswordChar = '\0';
                _passShown = true;
                this.panel_pass_showHide.BackgroundImage = global::Shop_Management.Properties.Resources.hide_password;
                this.text_password.ForeColor = System.Drawing.Color.Gray;
            }
        }
        //
        // text_confirmPassword
        //
        private void text_confirmPassword_Enter(object sender, EventArgs e)
        {
            this.text_confirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.text_confirmPassword.ForeColor = Color.White;
            if (this.text_confirmPassword.Text == "Confirm Password")
            {
                this.text_confirmPassword.Text = "";
                this.text_confirmPassword.PasswordChar = '*';
                _confirmPassShown = false;
                this.panel_confirmPass_showHide.BackgroundImage = global::Shop_Management.Properties.Resources.show_password;
            }
        }

        private void text_confirmPassword_Leave(object sender, EventArgs e)
        {
            if (this.text_confirmPassword.Text == "" || this.text_confirmPassword.Text == "Confirm Password")
            {
                this.text_confirmPassword.Text = "Confirm Password";
                this.text_confirmPassword.PasswordChar = '\0';
                _confirmPassShown = true;
                this.panel_confirmPass_showHide.BackgroundImage = global::Shop_Management.Properties.Resources.hide_password;
                this.text_confirmPassword.ForeColor = System.Drawing.Color.Gray;
            }
        }
        //
        // label_backToLogin
        //
        private void label_backToLogin_MouseEnter(object sender, EventArgs e)
        {
            this.label_backToLogin.ForeColor = System.Drawing.Color.OliveDrab;
        }

        private void label_backToLogin_MouseLeave(object sender, EventArgs e)
        {
            this.label_backToLogin.ForeColor = System.Drawing.Color.White;
        }

        private void label_backToLogin_Click(object sender, EventArgs e)
        {
            _master.Login_Page(this.Size, this.Location);
            this.Dispose();
        }
        //
        // btn_cancel
        //
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            _master.Login_Page(this.Size, this.Location);
            this.Dispose();
        }
        //
        // btn_register
        //
        private void btn_register_Click(object sender, EventArgs e)
        {
            string userName = this.text_userName.Text;
            string name = this.text_name.Text;
            string password = this.text_password.Text;
            string confirmPassword = this.text_confirmPassword.Text;

            if (isUserNameValid(userName)
                && isNameValid(name)
                && isPasswordValid(password)
                && doesPasswordMatch(password, confirmPassword))
            {
                User user = new();
                user.UserName = userName;
                user.Name = name;
                user.Password = password;
                user.Approved = false;
                user.Role = false;


                Registration_Controller rController = new(_master);
                if (!rController.UserNameExists(user.UserName)){
                    if (rController.RegisterUser(user))
                    {
                        _master.Alert("Registration Successfull. you can login after approval ^-^", Notification.PopUp.enmType.Success);
                        _master.Login_Page(this.Size, this.Location);
                        this.Dispose();
                    }
                    else
                    {
                        _master.Alert("Unknown Error. Registration failed", Notification.PopUp.enmType.Error);
                    }
                }
                else{
                    _master.Alert("User Name already taken by someone else -_-", Notification.PopUp.enmType.Warning);
                    this.text_userName.BackColor = System.Drawing.Color.DarkOrange;
                    this.text_userName.ForeColor = System.Drawing.Color.White;
                }
                
            }
        }
        //Other
        //Methods
        //are
        //Implemented after this

        private bool isUserNameValid(string userName)
        {
            if (userName.Length >= 5)
            {
                if (userName == "User Name")
                {
                    _master.Alert("Change your User Name", Notification.PopUp.enmType.Warning);
                    this.text_userName.BackColor = System.Drawing.Color.DarkOrange;
                    this.text_userName.ForeColor = System.Drawing.Color.White;
                    return false;
                }
                return true;
            }
            else
            {
                _master.Alert("User Name have to be atleast 5 character long!!", Notification.PopUp.enmType.Warning);
                this.text_userName.BackColor = System.Drawing.Color.DarkOrange;
                this.text_userName.ForeColor = System.Drawing.Color.White;
                return false;
            }
        }

        private bool isNameValid(string name)
        {
            if (name.Length >= 5)
            {
                if (name == "Full Name")
                {
                    _master.Alert("Change your Name", Notification.PopUp.enmType.Warning);
                    this.text_name.BackColor = System.Drawing.Color.DarkOrange;
                    this.text_name.ForeColor = System.Drawing.Color.White;
                    return false;
                }
                return true;
            }
            else
            {
                _master.Alert("Enter your full Name. It have to be atleast 5 character long!!", Notification.PopUp.enmType.Warning);
                this.text_name.BackColor = System.Drawing.Color.DarkOrange;
                this.text_name.ForeColor = System.Drawing.Color.White;
                return false;
            }
        }

        private bool isPasswordValid(string password)
        {
            if (password.Length >= 8)
            {
                if(password != "Password")
                {
                    return true;
                }
                else
                {
                    _master.Alert("Change the Password", Notification.PopUp.enmType.Warning);
                    this.text_password.BackColor = System.Drawing.Color.DarkOrange;
                    this.text_password.ForeColor = System.Drawing.Color.White;
                    return false;
                }
            }
            else
            {
                _master.Alert("Password must be atleast 8 character long !!", Notification.PopUp.enmType.Error);
                this.text_password.BackColor = System.Drawing.Color.DarkRed;
                this.text_password.ForeColor = System.Drawing.Color.White;
                return false;
            }

        }

        private bool doesPasswordMatch(string password, string confirmPassword)
        {
            if (password == confirmPassword)
            {
                return true;
            }
            else
            {
                _master.Alert("Oh no!! Confirmed Password messed up!!", Notification.PopUp.enmType.Error);
                this.text_confirmPassword.BackColor = System.Drawing.Color.DarkRed;
                this.text_confirmPassword.ForeColor = System.Drawing.Color.White;
                return false;
            }
        }
    }
}
