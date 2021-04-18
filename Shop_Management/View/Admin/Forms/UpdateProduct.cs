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

namespace Inventory_Management.View.Admin.Forms
{
    public partial class UpdateProduct : Form
    {
        private Master _master;
        private Product _product;
        public UpdateProduct()
        {
            InitializeComponent();
        }
        public void setResources(Master master)
        {
            _master = master;
        }

        private void UpdateQuantity_Load(object sender, EventArgs e)
        {
            Inventory_Controller iController = new(_master);
            this.comboBox_productList.DataSource = iController.getAllProducts();
            this.comboBox_productList.ValueMember = "ProductID";
            this.comboBox_productList.DisplayMember = "ProductName";
        }

        private void updateComboBox(int id)
        {
            Inventory_Controller iController = new(_master);
            this.comboBox_productList.DataSource = iController.getAllProducts();
            this.comboBox_productList.ValueMember = "ProductID";
            this.comboBox_productList.DisplayMember = "ProductName";
            this.comboBox_productList.SelectedValue = id;
        }

        private void comboBox_productList_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                //int ProductID = (int)this.comboBox_productList.SelectedValue;
                //_product = new Inventory_Controller(_master).GetProductDetails(ProductID);

                //this.label_currenrPrice.Text = _product.Price.ToString();
                //this.label_CurrentQuantity.Text = _product.Quantity.ToString();
                //this.text_productName.Text = _product.ProductName;
                //this.numericUpDown_addQuantity.Value = 0;
                //this.label_newQuantity.Text = "-";
                //this.numericUpDown_newPrice.Value = 0;

                if (comboBox_productList.SelectedValue != null)
                {
                    int ProductID = (int)this.comboBox_productList.SelectedValue;
                    _product = new Inventory_Controller(_master).GetProductDetails(ProductID);

                    this.label_currenrPrice.Text = _product.Price.ToString();
                    this.label_CurrentQuantity.Text = _product.Quantity.ToString();
                    this.text_productName.Text = _product.ProductName;
                    this.numericUpDown_addQuantity.Value = 0;
                    this.label_newQuantity.Text = "-";
                    this.numericUpDown_newPrice.Value = 0;
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {

            }

            
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
            if (this.numericUpDown_newPrice.Value <= 0)
            {
                return false;
            }
            return true;
        }
        private bool CheckQuantity()
        {
            if (this.numericUpDown_addQuantity.Value <= 0)
            {
                return false;
            }
            return true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckProductName() && this.text_productName.Text != _product.ProductName)
            {
                Inventory_Controller iController = new(_master);
                if (!iController.ProductExists(this.text_productName.Text))
                {
                    if (iController.UpdateProductName(this.text_productName.Text, _product.ProductID))
                    {
                        Master.Alert("Product Name Updated Successfully", Notification.PopUp.enmType.Success); 
                    }
                    else
                    {
                        Master.Alert("Error. Could not update Product Name", Notification.PopUp.enmType.Error);
                    }
                }
                else
                {
                    this.text_productName.BackColor = Color.DarkOrange;
                    Master.Alert("Product Already Exists!!!", Notification.PopUp.enmType.Warning);
                }
            }
            if (this.numericUpDown_newPrice.Value > 0)
            {
                Inventory_Controller iController = new(_master);
                if (iController.UpdateProductPrice((int)this.numericUpDown_newPrice.Value, _product.ProductID))
                {
                    Master.Alert("Product Price Updated Successfully", Notification.PopUp.enmType.Success);
                }
                else
                {
                    Master.Alert("Error. Could not update Product Price", Notification.PopUp.enmType.Error);
                }
            }

            if(this.numericUpDown_addQuantity.Value > 0)
            {
                Inventory_Controller iController = new(_master);
                if(iController.UpdateProductQuantity(((int)this.numericUpDown_addQuantity.Value)+_product.Quantity, _product.ProductID))
                {
                    Master.Alert("Product Quantity Updated Successfully", Notification.PopUp.enmType.Success);
                }
                else
                {
                    Master.Alert("Error. Could not update Product Quantity", Notification.PopUp.enmType.Error);
                }
            }
            _product = new Inventory_Controller(_master).GetProductDetails(_product.ProductID);
            updateComboBox(_product.ProductID);
        }

        private void text_productName_Enter(object sender, EventArgs e)
        {
            this.text_productName.ForeColor = Color.Black;
            this.text_productName.BackColor = Color.White;
        }

        private void numericUpDown_addQuantity_ValueChanged(object sender, EventArgs e)
        {
            this.label_newQuantity.Text = (numericUpDown_addQuantity.Value + _product.Quantity).ToString();
        }
    }
}
