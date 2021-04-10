using Shop_Management.Control;
using Shop_Management.Model;
using Shop_Management.View.Admin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management.View.Admin
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
            this.panel_clildForm.Controls.Add(approveUsers);
            approveUsers.Dock = DockStyle.Fill;
            approveUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.btn_approveEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.label_header.Text = approveUsers.Text;
            approveUsers.setResources(_master);
            approveUsers.Show();

        }
    }
}
