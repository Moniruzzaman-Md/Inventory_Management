
namespace Shop_Management.View.Admin.Forms
{
    partial class Unit
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
            this.label_Username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Approve = new System.Windows.Forms.Button();
            this.btn_Decline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Username.ForeColor = System.Drawing.Color.White;
            this.label_Username.Location = new System.Drawing.Point(87, 20);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(182, 19);
            this.label_Username.TabIndex = 0;
            this.label_Username.Text = "User Name: User Name abc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Name.ForeColor = System.Drawing.Color.White;
            this.label_Name.Location = new System.Drawing.Point(350, 20);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(138, 19);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "Name: What a Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(275, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Name";
            // 
            // btn_Approve
            // 
            this.btn_Approve.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Approve.FlatAppearance.BorderSize = 0;
            this.btn_Approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Approve.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Approve.ForeColor = System.Drawing.Color.White;
            this.btn_Approve.Location = new System.Drawing.Point(567, -1);
            this.btn_Approve.Name = "btn_Approve";
            this.btn_Approve.Size = new System.Drawing.Size(133, 30);
            this.btn_Approve.TabIndex = 5;
            this.btn_Approve.Text = "Approve";
            this.btn_Approve.UseVisualStyleBackColor = false;
            this.btn_Approve.Click += new System.EventHandler(this.btn_Approve_Click);
            // 
            // btn_Decline
            // 
            this.btn_Decline.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Decline.FlatAppearance.BorderSize = 0;
            this.btn_Decline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Decline.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Decline.ForeColor = System.Drawing.Color.White;
            this.btn_Decline.Location = new System.Drawing.Point(567, 35);
            this.btn_Decline.Name = "btn_Decline";
            this.btn_Decline.Size = new System.Drawing.Size(133, 29);
            this.btn_Decline.TabIndex = 6;
            this.btn_Decline.Text = "Decline";
            this.btn_Decline.UseVisualStyleBackColor = false;
            // 
            // Unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(702, 64);
            this.Controls.Add(this.btn_Decline);
            this.Controls.Add(this.btn_Approve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Unit";
            this.Text = "Unit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Approve;
        private System.Windows.Forms.Button btn_Decline;
    }
}