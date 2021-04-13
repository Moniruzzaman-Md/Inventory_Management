using Inventory_Management.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management.View.Notification
{
    public partial class PopUp : Form
    {
        private PopUp.enmAction action;
        private int x, y;
        public PopUp()
        {
            InitializeComponent();
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer.Interval = 5000;
                    action = enmAction.close;
                    break;
                case PopUp.enmAction.start:
                    this.timer.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = PopUp.enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer.Interval = 2;
                    this.Opacity -= 0.2;

                    this.Left += 4;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            timer.Interval = 1;
            action = enmAction.close;
        }

        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                PopUp frm = (PopUp)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case enmType.Success:
                    this.pictureBox.BackgroundImage = global::Inventory_Management.Properties.Resources.success;
                    this.BackColor = Color.SeaGreen;
                    this.Massage.BackColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    this.pictureBox.BackgroundImage = global::Inventory_Management.Properties.Resources.error;
                    this.BackColor = Color.DarkRed;
                    this.Massage.BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    this.pictureBox.BackgroundImage = global::Inventory_Management.Properties.Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    this.Massage.BackColor = Color.RoyalBlue;
                    break;
                case enmType.Warning:
                    this.pictureBox.BackgroundImage = global::Inventory_Management.Properties.Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    this.Massage.BackColor = Color.DarkOrange;
                    break;
            }


            this.Massage.Text = msg;

            this.Show();
            this.action = enmAction.start;
            this.timer.Interval = 1;
            this.timer.Start();
        }
    }
}
