using Inventory_Management.Control;
using Inventory_Management.Model;
using Inventory_Management.View.Admin;
using Inventory_Management.View.Employee;
using Inventory_Management.View.Notification;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management.Shared
{
    public partial class Settings : Form
    {
        private Master _master;
        private User _user;
        private byte[] _newUserImage = null;
        private Employee _employee = null;
        private Admin _admin = null;

        public Settings()
        {
            InitializeComponent();
        }
        public void setResources(Master master, User user, Employee employee)
        {
            _master = master;
            _user = user;
            _employee = employee;
        }

        public void setResources(Master master, User user, Admin admin)
        {
            _master = master;
            _user = user;
            _admin = admin;
        }

        private void label_edit_cancel_username_Click(object sender, EventArgs e)
        {
            if (this.label_edit_cancel_username.Text == "Edit")
            {
                this.label_username.Visible = false;
                this.text_Username.Text = this.label_username.Text;
                this.text_Username.Visible = true;
                this.label_edit_cancel_username.Text = "Cancel";
                this.label_edit_cancel_username.ForeColor = Color.White;
            }
            else
            {
                this.label_username.Visible = true;
                this.text_Username.Visible = false;
                this.label_edit_cancel_username.Text = "Edit";
                this.label_edit_cancel_username.ForeColor = Color.Chartreuse;
                this.text_Username.Text = _user.UserName;
                this.text_Username.ForeColor = Color.Black;
                this.text_Username.BackColor = Color.White;
            }

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.label_username.Text = _user.UserName;
            if (_user.image != null)
            {
                this.pictureBox.Image = ByteToImage(_user.image);
            }
            
            this.label_Name.Text = _user.Name;
        }


        private void label_edit_cancel_Image_Click(object sender, EventArgs e)
        {
            if (this.label_edit_cancel_Image.Text == "Edit")
            {
                this.label_edit_cancel_Image.Text = "Cancel";
                this.label_edit_cancel_Image.ForeColor = Color.White;


                OpenFileDialog openFileDialog = new();
                openFileDialog.Title = "Select an image";
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                //openFileDialog.ShowDialog();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.Drawing.Image img = System.Drawing.Image.FromFile(openFileDialog.FileName);
                    byte[] image = (byte[])(new ImageConverter()).ConvertTo(img, typeof(byte[]));
                    _newUserImage = image;

                    this.pictureBox.Image = ByteToImage(image);

                }

            }
            else
            {
                this.label_edit_cancel_Image.Text = "Edit";
                this.label_edit_cancel_Image.ForeColor = Color.Chartreuse;
                _newUserImage = null;

                this.pictureBox.Image = ByteToImage(_user.image);
            }
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (_newUserImage != null)
            {

                User_Controller uController = new(_master);
                bool success = false;

                await Task.Run(() =>
                {
                    success = uController.SaveUserImage(_newUserImage, _user.UserID);
                });
                if (success)
                {
                    Master.Alert("User Image updated successfully!!", PopUp.enmType.Success);
                    if(_employee != null)
                    {
                        _user = _employee.UpdateUserDetails();
                    }
                    else
                    {
                        _user = _admin.UpdateUserDetails();
                    }
                    
                    this.label_edit_cancel_Image.Text = "Edit";
                    this.label_edit_cancel_Image.ForeColor = Color.Chartreuse;
                    _newUserImage = null;
                }
                else
                {
                    Master.Alert("Error. Could not update image", PopUp.enmType.Error);
                }
            }

            if(text_Username.Text != _user.UserName && text_Username.Visible != false)
            {
                Registration_Controller rController = new(_master);
                if (!rController.UserNameExists(text_Username.Text))
                {
                    if (isUserNameValid(text_Username.Text))
                    {
                        User_Controller uController = new(_master);
                        if(uController.UpdateUserName(text_Username.Text, _user.UserID))
                        {
                            Master.Alert("User Name updated", View.Notification.PopUp.enmType.Success);
                            if (_employee != null)
                            {
                                _user = _employee.UpdateUserDetails();
                            }
                            else
                            {
                                _user = _admin.UpdateUserDetails();
                            }
                            this.label_edit_cancel_username.Text = "Edit";
                            this.label_edit_cancel_username.ForeColor = Color.Chartreuse;
                            this.label_username.Text = _user.UserName;
                            this.text_Username.Visible = false;
                            this.label_username.Visible = true;


                        }
                        else
                        {
                            Master.Alert("Error. Could not updated User Name", View.Notification.PopUp.enmType.Success);
                        }
                    }
                }
                else
                {
                    Master.Alert("User Name already taken by someone else -_-", View.Notification.PopUp.enmType.Warning);
                    this.text_Username.BackColor = System.Drawing.Color.DarkOrange;
                    this.text_Username.ForeColor = System.Drawing.Color.White;
                }
            }


            if(text_name.Text != _user.Name && text_name.Visible != false)
            {
                if (isNameValid(text_name.Text))
                {
                    User_Controller uController = new(_master);
                    if (uController.UpdateName(text_name.Text, _user.UserID))
                    {
                        Master.Alert("Name updated", View.Notification.PopUp.enmType.Success);
                        if (_employee != null)
                        {
                            _user = _employee.UpdateUserDetails();
                        }
                        else
                        {
                            _user = _admin.UpdateUserDetails();
                        }

                        this.label_edit_cancel_name.Text = "Edit";
                        this.label_edit_cancel_name.ForeColor = Color.Chartreuse;
                        this.label_Name.Text = _user.Name;
                        this.text_name.Visible = false;
                        this.label_Name.Visible = true;
                    }
                    else
                    {
                        Master.Alert("Error. Could not updated Name", View.Notification.PopUp.enmType.Error);
                    }
                }
            }

            if(label_edit_cancel_password.Text == "Cancel")
            {
                User_Controller uContrller = new(_master);
                if(uContrller.CheckOldPassowrd(text_oldPassword.Text, _user.UserID))
                {
                    if(isPasswordValid(text_newPassword.Text) && doesPasswordMatch(text_newPassword.Text, text_confirmPassowrd.Text))
                    {
                        if(uContrller.UpdatPassword(text_newPassword.Text, _user.UserID))
                        {
                            Master.Alert("Success. Password Updated", View.Notification.PopUp.enmType.Success);

                            this.label_edit_cancel_password.Text = "Edit";
                            this.label_edit_cancel_password.ForeColor = Color.Chartreuse;

                            this.text_oldPassword.Visible = false;
                            this.text_oldPassword.Text = "Old Password";
                            this.text_oldPassword.PasswordChar = '\0';
                            this.text_oldPassword.BackColor = Color.White;

                            this.text_newPassword.Visible = false;
                            this.text_newPassword.Text = "New Password";
                            this.text_newPassword.PasswordChar = '\0';
                            this.text_newPassword.BackColor = Color.White;

                            this.text_confirmPassowrd.Visible = false;
                            this.text_confirmPassowrd.Text = "Confirm Password";
                            this.text_confirmPassowrd.PasswordChar = '\0';
                            this.text_confirmPassowrd.BackColor = Color.White;
                        }
                        else
                        {
                            Master.Alert("Error. Password could not be Updated", View.Notification.PopUp.enmType.Error);
                        }
                    }
                }
                else
                {
                    this.text_oldPassword.BackColor = Color.DarkRed;
                    Master.Alert("Invalid Old Password", View.Notification.PopUp.enmType.Error);
                }
            }
        }

        private bool isUserNameValid(string userName)
        {
            if (userName.Length >= 5)
            {
                if (userName == "User Name")
                {
                    Master.Alert("Change your User Name", View.Notification.PopUp.enmType.Warning);
                    this.text_Username.BackColor = System.Drawing.Color.DarkOrange;
                    this.text_Username.ForeColor = System.Drawing.Color.White;
                    return false;
                }
                return true;
            }
            else
            {
                Master.Alert("User Name have to be atleast 5 character long!!", View.Notification.PopUp.enmType.Warning);
                this.text_Username.BackColor = System.Drawing.Color.DarkOrange;
                this.text_Username.ForeColor = System.Drawing.Color.White;
                return false;
            }
        }

        private void text_Username_Enter(object sender, EventArgs e)
        {
            this.text_Username.ForeColor = Color.Black;
            this.text_Username.BackColor = Color.White;
        }

        private void label_edit_cancel_name_Click(object sender, EventArgs e)
        {
            if (this.label_edit_cancel_name.Text == "Edit")
            {
                this.label_Name.Visible = false;
                this.text_name.Text = this.label_Name.Text;
                this.text_name.Visible = true;
                this.label_edit_cancel_name.Text = "Cancel";
                this.label_edit_cancel_name.ForeColor = Color.White;
            }
            else
            {
                this.label_Name.Visible = true;
                this.text_name.Visible = false;
                this.label_edit_cancel_name.Text = "Edit";
                this.label_edit_cancel_name.ForeColor = Color.Chartreuse;
                this.text_name.Text = _user.UserName;
                this.text_name.ForeColor = Color.Black;
                this.text_name.BackColor = Color.White;
            }
        }

        private bool isNameValid(string name)
        {
            if (name.Length >= 5)
            {
                if (name == "Full Name")
                {
                    Master.Alert("Change your Name", View.Notification.PopUp.enmType.Warning);
                    this.text_name.BackColor = System.Drawing.Color.DarkOrange;
                    this.text_name.ForeColor = System.Drawing.Color.White;
                    return false;
                }
                return true;
            }
            else
            {
                Master.Alert("Enter your full Name. It have to be atleast 5 character long!!", View.Notification.PopUp.enmType.Warning);
                this.text_name.BackColor = System.Drawing.Color.DarkOrange;
                this.text_name.ForeColor = System.Drawing.Color.White;
                return false;
            }
        }

        private void text_name_Enter(object sender, EventArgs e)
        {
            this.text_name.ForeColor = Color.Black;
            this.text_name.BackColor = Color.White;
        }

        private void label_edit_cancel_password_Click(object sender, EventArgs e)
        {
            if(this.label_edit_cancel_password.Text == "Edit")
            {
                this.label_edit_cancel_password.Text = "Cancel";
                this.label_edit_cancel_password.ForeColor = Color.White;

                this.text_oldPassword.Visible = true;
                this.text_newPassword.Visible = true;
                this.text_confirmPassowrd.Visible = true;
            }
            else
            {
                this.label_edit_cancel_password.Text = "Edit";
                this.label_edit_cancel_password.ForeColor = Color.Chartreuse;

                this.text_oldPassword.Visible = false;
                this.text_oldPassword.Text = "Old Password";
                this.text_oldPassword.PasswordChar = '\0';
                this.text_oldPassword.BackColor = Color.White;

                this.text_newPassword.Visible = false;
                this.text_newPassword.Text = "New Password";
                this.text_newPassword.PasswordChar = '\0';
                this.text_newPassword.BackColor = Color.White;

                this.text_confirmPassowrd.Visible = false;
                this.text_confirmPassowrd.Text = "Confirm Password";
                this.text_confirmPassowrd.PasswordChar = '\0';
                this.text_confirmPassowrd.BackColor = Color.White;

            }
            
        }

        private void text_oldPassword_Enter(object sender, EventArgs e)
        {
            this.text_oldPassword.Text = "";
            this.text_oldPassword.PasswordChar = '*';
            this.text_oldPassword.ForeColor = Color.Black;
            this.text_oldPassword.BackColor = Color.White;
        }

        private void text_newPassword_Enter(object sender, EventArgs e)
        {
            this.text_newPassword.Text = "";
            this.text_newPassword.PasswordChar = '*';
            this.text_newPassword.ForeColor = Color.Black;
            this.text_newPassword.BackColor = Color.White;
        }

        private void text_confirmPassowrd_Enter(object sender, EventArgs e)
        {
            this.text_confirmPassowrd.Text = "";
            this.text_confirmPassowrd.PasswordChar = '*';
            this.text_confirmPassowrd.ForeColor = Color.Black;
            this.text_confirmPassowrd.BackColor = Color.White;
        }

        private bool isPasswordValid(string password)
        {
            if (password.Length >= 8)
            {
                if (password != "New Password" && password != "Password")
                {
                    return true;
                }
                else
                {
                    Master.Alert("Change the Password", View.Notification.PopUp.enmType.Warning);
                    this.text_newPassword.BackColor = System.Drawing.Color.DarkOrange;
                    this.text_newPassword.ForeColor = System.Drawing.Color.White;
                    return false;
                }
            }
            else
            {
                Master.Alert("Password must be atleast 8 character long !!", View.Notification.PopUp.enmType.Error);
                this.text_newPassword.BackColor = System.Drawing.Color.DarkRed;
                this.text_newPassword.ForeColor = System.Drawing.Color.White;
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
                Master.Alert("Oh no!! Confirmed Password messed up!!", View.Notification.PopUp.enmType.Error);
                this.text_confirmPassowrd.BackColor = System.Drawing.Color.DarkRed;
                this.text_confirmPassowrd.ForeColor = System.Drawing.Color.White;
                return false;
            }
        }
    }
}
