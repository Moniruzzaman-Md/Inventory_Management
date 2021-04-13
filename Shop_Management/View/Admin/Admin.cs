using Inventory_Management.Control;
using Inventory_Management.Model;
using Inventory_Management.View.Admin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }
        public void setResources(Master master)
        {
            _master = master;
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
        }
    }
}
