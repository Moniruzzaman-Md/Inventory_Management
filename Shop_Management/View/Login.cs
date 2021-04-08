using Shop_Management.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management.View
{
    public partial class Login : Form
    {
        private Master _master;
        private bool _shown = false;

        public Login()
        {
            InitializeComponent();
        }
        public void setResources(Master master)
        {
            _master = master;
        }

        private void panel_pass_showHide_Click(object sender, EventArgs e)
        {
            if (!_shown)
            {
                this.panel_pass_showHide.BackgroundImage = global::Shop_Management.Properties.Resources.hide_password;
                _shown = true;
                this.text_password.PasswordChar = '\0';
            }
            else
            {
                this.panel_pass_showHide.BackgroundImage = global::Shop_Management.Properties.Resources.show_password;
                _shown = false;
                this.text_password.PasswordChar = '*';
            }
        }

        private void label_create_account_MouseEnter(object sender, EventArgs e)
        {
            this.label_create_account.ForeColor = System.Drawing.Color.OliveDrab;
        }

        private void label_create_account_MouseLeave(object sender, EventArgs e)
        {
            this.label_create_account.ForeColor = System.Drawing.Color.White;
        }

        private void label_create_account_Click(object sender, EventArgs e)
        {
            _master.Registration_Page();
            this.Hide();
        }
    }
}
