
namespace Inventory_Management.Shared
{
    partial class InventoryList
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
            this.label_count = new System.Windows.Forms.Label();
            this.flowLayoutPanel_content = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label_count
            // 
            this.label_count.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_count.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_count.ForeColor = System.Drawing.Color.White;
            this.label_count.Location = new System.Drawing.Point(0, 0);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(800, 54);
            this.label_count.TabIndex = 0;
            this.label_count.Text = "label1";
            this.label_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_content
            // 
            this.flowLayoutPanel_content.AutoScroll = true;
            this.flowLayoutPanel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_content.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_content.Location = new System.Drawing.Point(0, 54);
            this.flowLayoutPanel_content.Name = "flowLayoutPanel_content";
            this.flowLayoutPanel_content.Size = new System.Drawing.Size(800, 396);
            this.flowLayoutPanel_content.TabIndex = 1;
            // 
            // InventoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel_content);
            this.Controls.Add(this.label_count);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryList";
            this.Text = "Inventory List";
            this.Load += new System.EventHandler(this.InventoryList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_content;
    }
}