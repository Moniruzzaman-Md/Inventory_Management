using Inventory_Management.Control;
using Inventory_Management.Model;
using Inventory_Management.Shared;
using Inventory_Management.View.Admin.Forms;
using Inventory_Management.View.Employee.Forms;
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

namespace Inventory_Management.View.Employee
{
    public partial class Employee : Form
    {
        private Master _master;
        private User _user;
        public Employee(User user)
        {
            InitializeComponent();
            _user = user;
            this.label_Name.Text = _user.Name;
            if(_user.image != null)
            {
                Task.Run(() => {
                    this.pictureBox_user.Image = ByteToImage(_user.image);
                });
            }

            Clock clock = new();
            clock.TopLevel = false;
            clock.AutoScroll = true;
            this.panel_clildForm.Controls.Clear();
            this.panel_clildForm.Controls.Add(clock);
            clock.Dock = DockStyle.Fill;
            clock.Show();
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
        public void setResources(Master master)
        {
            _master = master;
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            _master.Login_Page(this.Size, this.Location);
            this.Dispose();
        }

        private void btn_showProduct_Click(object sender, EventArgs e)
        {
            InventoryList inventoryList = new();
            inventoryList.TopLevel = false;
            inventoryList.AutoScroll = true;

            this.panel_clildForm.Controls.Clear();

            this.panel_clildForm.Controls.Add(inventoryList);
            inventoryList.Dock = DockStyle.Fill;
            inventoryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.btn_showProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.label_header.Text = inventoryList.Text;
            inventoryList.setResources(_master);
            inventoryList.Show();


            this.btn_add_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            AddNewInventory addNewInventory = new();
            addNewInventory.TopLevel = false;
            addNewInventory.AutoScroll = true;
            this.panel_clildForm.Controls.Clear();
            this.panel_clildForm.Controls.Add(addNewInventory);
            addNewInventory.Dock = DockStyle.Fill;
            addNewInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.btn_add_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.label_header.Text = addNewInventory.Text;
            addNewInventory.setResources(_master);
            addNewInventory.Show();


            this.btn_showProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Settings settings = new();
            settings.TopLevel = false;
            settings.AutoScroll = true;
            this.panel_clildForm.Controls.Clear();
            this.panel_clildForm.Controls.Add(settings);
            settings.Dock = DockStyle.Fill;
            settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.label_header.Text = settings.Text;
            settings.setResources(_master, _user, this);
            settings.Show();



            this.btn_add_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btn_showProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
        }

        private void btn_time_Click(object sender, EventArgs e)
        {
            Clock clock = new();
            clock.TopLevel = false;
            clock.AutoScroll = true;
            this.panel_clildForm.Controls.Clear();
            this.panel_clildForm.Controls.Add(clock);
            clock.Dock = DockStyle.Fill;
            clock.Show();
        }
    }
}
