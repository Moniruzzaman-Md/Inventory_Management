using Shop_Management.Control;
using Shop_Management.Model;
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
    public partial class Approve_Users : Form
    {
        private Master _master;
        public Approve_Users()
        {
            InitializeComponent();
        }
        public void setResources(Master master)
        {
            _master = master;
        }

        private void Approve_Users_Load(object sender, EventArgs e)
        {
            Admin_Controller aController = new(_master);
            List<User> unApprovedUsers = aController.GetUnapprovedUsers();

            if(unApprovedUsers != null)
            {
                int userCount = 0;
                foreach (User user in unApprovedUsers){
                    Unit unit = new(_master);
                    unit.TopLevel = false;
                    unit.setUserName(user.UserName);
                    unit.setName(user.Name);
                    unit.setID(user.UserID);
                    this.flowLayoutPanel_Content.Controls.Add(unit);
                    unit.Show();
                    userCount++;
                }
                this.label_unapproved_user_count.Text = $"{userCount} Unapproved Employee Account Found";
            }
            else{

            }
        }
    }
}
