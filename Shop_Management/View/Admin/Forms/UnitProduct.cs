using Inventory_Management.Control;
using Inventory_Management.View.Notification;
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

        private void btn_approve_Click(object sender, EventArgs e)
        {
            Inventory_Controller iController = new(_master);
            if (iController.ApproveInventory(_id))
            {
                Master.Alert("Inventory Approved", PopUp.enmType.Success);
                _approveInventory.setUnapprovedUserCount(_approveInventory.getUnapprovedUserCount() - 1);
                _approveInventory.showUnapprovedProductCount();
                this.Close();
            }
            else
            {
                Master.Alert("Error. Cluld not approve", PopUp.enmType.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?","Chose an option", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                Inventory_Controller iController = new(_master);
                if (iController.DeleteInventory(_id))
                {
                    Master.Alert("Inventory Deleted", PopUp.enmType.Success);
                    _approveInventory.setUnapprovedUserCount(_approveInventory.getUnapprovedUserCount() - 1);
                    _approveInventory.showUnapprovedProductCount();
                    this.Close();
                }
                else
                {
                    Master.Alert("Error. Cluld not delete", PopUp.enmType.Error);
                }
            }
        }
    }
}
