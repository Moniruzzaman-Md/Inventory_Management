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
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.label_HM.Text = DateTime.Now.ToString("HH:mm");
            this.label_S.Text = DateTime.Now.ToString("ss");

            this.label_date.Text = DateTime.Now.ToString("dd MMM yyy");
            this.label_day.Text = DateTime.Now.ToString("dddd");

            this.label_S.Location = new Point(label_HM.Location.X + label_HM.Width, label_HM.Location.Y + label_HM.Height - label_S.Height);
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
