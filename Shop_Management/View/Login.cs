using Inventory_Management.Control;
using Inventory_Management.Model;
using Inventory_Management.View.Notification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management.View
{
    public partial class Login : Form
    {
        private Master _master;
        private bool _shown = false;

        public Login()
        {
            InitializeComponent();
        }
        public void setResources(Master master)
        {
            _master = master;
        }

        private void panel_pass_showHide_Click(object sender, EventArgs e)
        {
            if (!_shown)
            {
                this.panel_pass_showHide.BackgroundImage = global::Inventory_Management.Properties.Resources.hide_password;
                _shown = true;
                this.text_password.PasswordChar = '\0';
            }
            else
            {
                this.panel_pass_showHide.BackgroundImage = global::Inventory_Management.Properties.Resources.show_password;
                _shown = false;
                this.text_password.PasswordChar = '*';
            }
        }

        private void label_create_account_MouseEnter(object sender, EventArgs e)
        {
            this.label_create_account.ForeColor = System.Drawing.Color.OliveDrab;
        }

        private void label_create_account_MouseLeave(object sender, EventArgs e)
        {
            this.label_create_account.ForeColor = System.Drawing.Color.White;
        }

        private void label_create_account_Click(object sender, EventArgs e)
        {
            _master.Registration_Page(this.Size, this.Location);
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
#if DEBUG
            this.text_userName.Text = "Monir";
            this.text_password.Text = "aaaaaaaa";

            //this.text_userName.Text = "Admin";
            //this.text_password.Text = "Admin";
#endif
            if (this.text_userName.Text == "")
            {
                this.text_userName.BackColor = Color.DarkRed;
            }
            else
            {
                if (this.text_password.Text == "")
                {
                    this.text_password.BackColor = Color.DarkRed;
                }
                else
                {
                    Login_Controller lController = new(_master);
                    User user = new();
                    user.UserName = this.text_userName.Text;
                    user.Password = this.text_password.Text;
                    User userFromDB = lController.IsUserValid(user);
                    if (userFromDB != null)
                    {
                        if (userFromDB.Approved == "Approved")
                        {
                            if (userFromDB.Role)
                            {
                                //MessageBox.Show(user.Name);
                                _master.Admin_Page(userFromDB, this.Size, this.Location);
                                this.text_userName.Text = "";
                                this.text_password.Text = "";
                                this.Hide();
                            }
                            else
                            {
                                _master.Employee_Page(userFromDB, this.Size, this.Location);
                                this.text_userName.Text = "";
                                this.text_password.Text = "";
                                this.Hide();
                            }
                        }
                        else if(userFromDB.Approved == "Unapproved")
                        {
                            new Modal("Your Account has not been approved by admin yet. \r\nContact an admin").ShowDialog();
                        }
                        else if(userFromDB.Approved == "Restricted")
                        {
                            new Modal("Your Account has not been restricted").ShowDialog();
                        }
                    }
                    else
                    {
                        _master.Alert("Incorrect User Name or Password", View.Notification.PopUp.enmType.Error);
                    }
                }
            }
        }

        private void text_userName_Enter(object sender, EventArgs e)
        {
            this.text_userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
        }

        private void text_password_Enter(object sender, EventArgs e)
        {
            this.text_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
        }
    }
}
