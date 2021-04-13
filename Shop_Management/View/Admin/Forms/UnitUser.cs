using Inventory_Management.Control;
using Inventory_Management.View.Notification;
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
    public partial class UnitUser : Form
    {
        private int _id;
        private Master _master;
        private Approve_Users _approveUsers;
        public UnitUser(Master master, Approve_Users approveUsers)
        {
            InitializeComponent();
            _master = master;
            _approveUsers = approveUsers;
        }
        public void setUserName(string userName)
        {
            this.label_Username.Text = userName;
        }
        public void setID(int id)
        {
            _id = id;
        }
        public void setName(string name)
        {
            this.label_Name.Text = name;
        }

        private void btn_Approve_Click(object sender, EventArgs e)
        {
            Admin_Controller aController = new(_master);
            if (aController.ApproveUser(_id)){
                _master.Alert("User Approved", PopUp.enmType.Success);
                _approveUsers.setUnapprovedUserCount(_approveUsers.getUnapprovedUserCount() - 1);
                _approveUsers.showUnapprovedUserCount();
                this.Close();
            }
            else
            {
                _master.Alert("Error. Cluld not approve", PopUp.enmType.Error);
            }
        }

        private void btn_Decline_Click(object sender, EventArgs e)
        {
            Admin_Controller aController = new(_master);
            if (aController.RestrictUser(_id))
            {
                _master.Alert("User Restricted", PopUp.enmType.Success);
                _approveUsers.setUnapprovedUserCount(_approveUsers.getUnapprovedUserCount() - 1);
                _approveUsers.showUnapprovedUserCount();
                this.Close();
            }
            else
            {
                _master.Alert("Error. Cluld not restrict", PopUp.enmType.Error);
            }
        }
    }
}
