using Shop_Management.Control;
using Shop_Management.View.Notification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management.View.Admin.Forms
{
    public partial class Unit : Form
    {
        private int _id;
        private Master _master;
        public Unit(Master master)
        {
            InitializeComponent();
            _master = master;
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
                this.Close();
            }
            else
            {
                _master.Alert("Error. Cluld not approve", PopUp.enmType.Error);
            }
        }
    }
}
