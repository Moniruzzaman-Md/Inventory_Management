using Inventory_Management.Control;
using Inventory_Management.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management.View.Employee.Forms
{
    public partial class AddNewInventory : Form
    {
        private Master _master;
        public AddNewInventory()
        {
            InitializeComponent();
        }
        public void setResources(Master master)
        {
            _master = master;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(CheckProductName() && CheckPrice() && CheckQuantity())
            {
                Product product = new();
                product.ProductName = this.text_productName.Text;
                product.Price = (int)this.numericUpDown_price.Value;
                product.Quantity = (int)this.numericUpDown_quantity.Value;
                product.Approved = false;

                Inventory_Controller iController = new(_master);
                if (!iController.ProductExists(product.ProductName))
                {
                    if (iController.AddInventory(product))
                    {
                        _master.Alert("New Inventory Added Successfully", Notification.PopUp.enmType.Success);
                    }
                    else
                    {
                        _master.Alert("Error. Could not Add", Notification.PopUp.enmType.Error);
                    }
                }
                else
                {
                    this.text_productName.BackColor = Color.DarkOrange;
                    _master.Alert("Product Already Exists!!!", Notification.PopUp.enmType.Warning);
                }
                
            }
        }

        private void text_productName_Enter(object sender, EventArgs e)
        {
            this.text_productName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
        }

        private bool CheckProductName()
        {
            if (this.text_productName.Text == "")
            {
                this.text_productName.BackColor = Color.DarkRed;
                return false;
            }
            return true;
        }
        private bool CheckPrice()
        {
            if(this.numericUpDown_price.Value <= 0)
            {
                this.numericUpDown_price.BackColor = Color.DarkRed;
                return false;
            }
            return true;
        }
        private bool CheckQuantity()
        {
            if (this.numericUpDown_quantity.Value <= 0)
            {
                this.numericUpDown_quantity.BackColor = Color.DarkRed;
                return false;
            }
            return true;
        }

        private void numericUpDown_price_Enter(object sender, EventArgs e)
        {
            this.numericUpDown_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
        }

        private void numericUpDown_quantity_Enter(object sender, EventArgs e)
        {
            this.numericUpDown_quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.text_productName.Text = "";
            this.numericUpDown_price.Value = 0;
            this.numericUpDown_quantity.Value = 0;
        }
    }
}
