using Inventory_Management.Control;
using Inventory_Management.Model;
using Inventory_Management.Shared;
using Inventory_Management.View.Admin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management.View.Admin
{
    public partial class Admin : Form
    {
        private Master _master;
        private User _user;
        public Admin(User user)
        {
            InitializeComponent();
            _user = user;
            this.label_Name.Text = _user.Name;
            if (_user.image != null)
            {
                Task.Run(() => {
                    this.pictureBox_user.Image = ByteToImage(_user.image);
                });
            }
        }
        public void setResources(Master master)
        {
            _master = master;
        }

        public User UpdateUserDetails()
        {
            _user = new User_Controller(_master).GetUserDetails(_user.UserID);
            this.label_Name.Text = _user.Name;
            if (_user.image != null)
            {
                Task.Run(() => {
                    this.pictureBox_user.Image = ByteToImage(_user.image);
                });
            }
            return _user;
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

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_approveEmployee_Click(object sender, EventArgs e)
        {
            Approve_Users approveUsers = new();
            approveUsers.TopLevel = false;
            approveUsers.AutoScroll = true;
            this.panel_clildForm.Controls.Clear();
            this.panel_clildForm.Controls.Add(approveUsers);
            approveUsers.Dock = DockStyle.Fill;
            approveUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.btn_approveEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.label_header.Text = approveUsers.Text;
            approveUsers.setResources(_master);
            approveUsers.Show();


            this.btn_ApproveInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btn_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btn_UpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            _master.Login_Page(this.Size, this.Location);
            this.Dispose();
        }

        private void btn_ApproveInventory_Click(object sender, EventArgs e)
        {
            ApproveInventory approveInventory = new();
            approveInventory.TopLevel = false;
            approveInventory.AutoScroll = true;
            this.panel_clildForm.Controls.Clear();
            this.panel_clildForm.Controls.Add(approveInventory);
            approveInventory.Dock = DockStyle.Fill;
            approveInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.btn_ApproveInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.label_header.Text = approveInventory.Text;
            approveInventory.setResources(_master);
            approveInventory.Show();

            this.btn_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btn_approveEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btn_UpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            Settings settings = new();
            settings.TopLevel = false;
            settings.AutoScroll = true;
            this.panel_clildForm.Controls.Clear();
            this.panel_clildForm.Controls.Add(settings);
            settings.Dock = DockStyle.Fill;
            settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.btn_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.label_header.Text = settings.Text;
            settings.setResources(_master, _user, this);
            settings.Show();

            this.btn_ApproveInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btn_approveEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btn_UpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
        }

        private void btn_UpdateQuantity_Click(object sender, EventArgs e)
        {
            UpdateProduct updatequantity = new();
            updatequantity.TopLevel = false;
            updatequantity.AutoScroll = true;
            this.panel_clildForm.Controls.Clear();
            this.panel_clildForm.Controls.Add(updatequantity);
            updatequantity.Dock = DockStyle.Fill;
            updatequantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.btn_UpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.label_header.Text = updatequantity.Text;
            updatequantity.setResources(_master);
            updatequantity.Show();

            this.btn_ApproveInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btn_approveEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btn_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));

        }
    }
}
