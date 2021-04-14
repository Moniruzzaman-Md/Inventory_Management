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
        }
    }
}
