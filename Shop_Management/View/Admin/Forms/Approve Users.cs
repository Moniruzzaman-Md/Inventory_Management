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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Inventory_Management.View.Admin.Forms
{
    public partial class Approve_Users : Form
    {
        private Master _master;
        private int UnApprovedUsers = 0;
        public Approve_Users()
        {
            InitializeComponent();
        }
        public void setResources(Master master)
        {
            _master = master;
        }
        public void setUnapprovedUserCount(int count)
        {
            UnApprovedUsers = count;
        }
        public int getUnapprovedUserCount()
        {
            return UnApprovedUsers;
        }
        public void showUnapprovedUserCount()
        {
            if(UnApprovedUsers > 0)
            {
                this.label_unapproved_user_count.Text = $"{UnApprovedUsers} Unapproved Employee Account Found";
            }
            else
            {
                this.label_unapproved_user_count.Text = "No Unapproved Employee Account Found";
            }
        }

        private void Approve_Users_Load(object sender, EventArgs e)
        {
            Admin_Controller aController = new(_master);
            List<User> unApprovedUsers = aController.GetUnapprovedUsers();

            if (unApprovedUsers != null)
            {
                int userCount = 0;
                foreach (User user in unApprovedUsers)
                {
                    UnitUser unit = new(_master, this);
                    unit.TopLevel = false;
                    unit.setUserName(user.UserName);
                    unit.setName(user.Name);
                    unit.setID(user.UserID);
                    this.flowLayoutPanel_Content.Controls.Add(unit);
                    unit.Show();
                    userCount++;
                }
                setUnapprovedUserCount(userCount);
                showUnapprovedUserCount();
            }
            else
            {

            }
        }
    }
}
