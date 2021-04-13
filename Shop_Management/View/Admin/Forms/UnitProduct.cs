using Inventory_Management.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management.View.Admin.Forms
{
    public partial class UnitProduct : Form
    {
        private Master _master;
        private ApproveInventory _approveInventory;
        private int _id;
        public UnitProduct(Master master, ApproveInventory approveInventory)
        {
            InitializeComponent();
            _master = master;
            _approveInventory = approveInventory;
        }

        public void setID(int id)
        {
            _id = id;
        }

        public void setName(string name)
        {
            this.label_Name.Text = name;
        }

        public void setPrice(int price)
        {
            this.label_price.Text = $"{price} Taka";
        }

    }
}
