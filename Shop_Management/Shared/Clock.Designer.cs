
namespace Inventory_Management.Shared
{
    partial class Clock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_HM = new System.Windows.Forms.Label();
            this.label_S = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_day = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_HM
            // 
            this.label_HM.AutoSize = true;
            this.label_HM.Font = new System.Drawing.Font("Algerian", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_HM.ForeColor = System.Drawing.Color.White;
            this.label_HM.Location = new System.Drawing.Point(159, 78);
            this.label_HM.Name = "label_HM";
            this.label_HM.Size = new System.Drawing.Size(306, 106);
            this.label_HM.TabIndex = 0;
            this.label_HM.Text = "10:22";
            // 
            // label_S
            // 
            this.label_S.AutoSize = true;
            this.label_S.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_S.ForeColor = System.Drawing.Color.White;
            this.label_S.Location = new System.Drawing.Point(473, 105);
            this.label_S.Name = "label_S";
            this.label_S.Size = new System.Drawing.Size(62, 41);
            this.label_S.TabIndex = 1;
            this.label_S.Text = "52";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(167, 210);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(298, 54);
            this.label_date.TabIndex = 2;
            this.label_date.Text = "25/10/2020";
            // 
            // label_day
            // 
            this.label_day.AutoSize = true;
            this.label_day.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_day.ForeColor = System.Drawing.Color.White;
            this.label_day.Location = new System.Drawing.Point(210, 287);
            this.label_day.Name = "label_day";
            this.label_day.Size = new System.Drawing.Size(210, 54);
            this.label_day.TabIndex = 3;
            this.label_day.Text = "Sunday";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_day);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_S);
            this.Controls.Add(this.label_HM);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clock";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Clock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_HM;
        private System.Windows.Forms.Label label_S;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_day;
        private System.Windows.Forms.Timer timer;
    }
}