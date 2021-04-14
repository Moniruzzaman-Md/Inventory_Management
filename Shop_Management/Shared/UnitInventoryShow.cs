using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management.Shared
{
    public partial class UnitInventoryShow : Form
    {
        public UnitInventoryShow()
        {
            InitializeComponent();
        }

        public void SetProductID(int id)
        {
            this.label_ProductID.Text = id.ToString();
        }

        public void SetProductName(string name)
        {
            this.label_productName.Text = name;
        }

        public void SetPrice(int price)
        {
            this.label_productPrice.Text = $"{price} Taka";
        }

        public void SetQuantity(int quantity)
        {
            this.label_inStock.Text = $"{quantity} PCS";
        }
    }
}
