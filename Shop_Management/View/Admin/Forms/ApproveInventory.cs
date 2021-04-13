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
    public partial class ApproveInventory : Form
    {
        private int productCount = 0;
        private Master _master;
        public ApproveInventory()
        {
            InitializeComponent();
        }
        public void setResources(Master master)
        {
            _master = master;
        }
        public void setUnapprovedUserCount(int count)
        {
            productCount = count;
        }

        public int getUnapprovedUserCount()
        {
            return productCount;
        }

        public void showUnapprovedProductCount()
        {
            if (productCount > 0)
            {
                this.label_unapproved_Inventory_count.Text = $"{productCount} Unapproved Product Found";
            }
            else
            {
                this.label_unapproved_Inventory_count.Text = "No Unapproved Product Found";
            }
        }

        private void ApproveInventory_Load(object sender, EventArgs e)
        {
            Inventory_Controller iController = new(_master);
            List<Product> products = iController.GetUnapprovedProducts();

            if (products != null)
            {
                int count = 0;
                foreach (Product product in products)
                {
                    UnitProduct unit = new(_master, this);
                    unit.TopLevel = false;
                    unit.setName(product.ProductName);
                    unit.setPrice(product.Price);
                    unit.setID(product.ProductID);
                    this.flowLayoutPanel_Content.Controls.Add(unit);
                    unit.Show();
                    count++;
                }
                setUnapprovedUserCount(count);
                showUnapprovedProductCount();
            }
            else
            {

            }
        }
    }
}
