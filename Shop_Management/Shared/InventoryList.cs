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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Inventory_Management.Shared
{
    public partial class InventoryList : Form
    {
        private Master _master;
        public InventoryList()
        {
            InitializeComponent();
        }
        public void setResources(Master master)
        {
            _master = master;
        }

        private void InventoryList_Load(object sender, EventArgs e)
        {
            Inventory_Controller iController = new(_master);
            List<Product> products = iController.getAllProducts();

            if (products != null)
            {
                int count = 0;
                foreach (Product product in products)
                {
                    UnitInventoryShow unit = new();
                    unit.TopLevel = false;
                    unit.SetProductID(product.ProductID);
                    unit.SetProductName(product.ProductName);
                    unit.SetPrice(product.Price);
                    unit.SetQuantity(product.Quantity);
                    this.flowLayoutPanel_content.Controls.Add(unit);
                    unit.Show();
                    count++;
                }
                this.label_count.Text = $"{count} Product(s) found";
            }
            else
            {
                this.label_count.Text = "No product found";
            }
        }
    }
}
