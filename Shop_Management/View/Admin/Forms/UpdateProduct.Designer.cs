
namespace Inventory_Management.View.Admin.Forms
{
    partial class UpdateProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.numericUpDown_newPrice = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label_currenrPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_newQuantity = new System.Windows.Forms.Label();
            this.label_new = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_addQuantity = new System.Windows.Forms.NumericUpDown();
            this.label_CurrentQuantity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_productName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_productList = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_newPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_addQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.numericUpDown_newPrice);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label_currenrPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label_newQuantity);
            this.panel1.Controls.Add(this.label_new);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numericUpDown_addQuantity);
            this.panel1.Controls.Add(this.label_CurrentQuantity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.text_productName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox_productList);
            this.panel1.Location = new System.Drawing.Point(40, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 355);
            this.panel1.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkRed;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(442, 279);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(124, 35);
            this.btn_cancel.TabIndex = 16;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(284, 279);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(135, 35);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // numericUpDown_newPrice
            // 
            this.numericUpDown_newPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_newPrice.Location = new System.Drawing.Point(494, 210);
            this.numericUpDown_newPrice.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numericUpDown_newPrice.Name = "numericUpDown_newPrice";
            this.numericUpDown_newPrice.Size = new System.Drawing.Size(72, 29);
            this.numericUpDown_newPrice.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(401, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "New Price";
            // 
            // label_currenrPrice
            // 
            this.label_currenrPrice.AutoSize = true;
            this.label_currenrPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_currenrPrice.ForeColor = System.Drawing.Color.Chartreuse;
            this.label_currenrPrice.Location = new System.Drawing.Point(264, 212);
            this.label_currenrPrice.Name = "label_currenrPrice";
            this.label_currenrPrice.Size = new System.Drawing.Size(46, 21);
            this.label_currenrPrice.TabIndex = 12;
            this.label_currenrPrice.Text = "9999";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(149, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Current Price";
            // 
            // label_newQuantity
            // 
            this.label_newQuantity.AutoSize = true;
            this.label_newQuantity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_newQuantity.ForeColor = System.Drawing.Color.Chartreuse;
            this.label_newQuantity.Location = new System.Drawing.Point(529, 171);
            this.label_newQuantity.Name = "label_newQuantity";
            this.label_newQuantity.Size = new System.Drawing.Size(16, 21);
            this.label_newQuantity.TabIndex = 10;
            this.label_newQuantity.Text = "-";
            // 
            // label_new
            // 
            this.label_new.AutoSize = true;
            this.label_new.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_new.ForeColor = System.Drawing.Color.White;
            this.label_new.Location = new System.Drawing.Point(411, 169);
            this.label_new.Name = "label_new";
            this.label_new.Size = new System.Drawing.Size(112, 21);
            this.label_new.TabIndex = 9;
            this.label_new.Text = "New Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(275, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Add";
            // 
            // numericUpDown_addQuantity
            // 
            this.numericUpDown_addQuantity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_addQuantity.Location = new System.Drawing.Point(324, 167);
            this.numericUpDown_addQuantity.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numericUpDown_addQuantity.Name = "numericUpDown_addQuantity";
            this.numericUpDown_addQuantity.Size = new System.Drawing.Size(72, 29);
            this.numericUpDown_addQuantity.TabIndex = 7;
            this.numericUpDown_addQuantity.ValueChanged += new System.EventHandler(this.numericUpDown_addQuantity_ValueChanged);
            // 
            // label_CurrentQuantity
            // 
            this.label_CurrentQuantity.AutoSize = true;
            this.label_CurrentQuantity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_CurrentQuantity.ForeColor = System.Drawing.Color.Chartreuse;
            this.label_CurrentQuantity.Location = new System.Drawing.Point(193, 171);
            this.label_CurrentQuantity.Name = "label_CurrentQuantity";
            this.label_CurrentQuantity.Size = new System.Drawing.Size(46, 21);
            this.label_CurrentQuantity.TabIndex = 6;
            this.label_CurrentQuantity.Text = "9999";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current Quantity";
            // 
            // text_productName
            // 
            this.text_productName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_productName.Location = new System.Drawing.Point(284, 118);
            this.text_productName.Name = "text_productName";
            this.text_productName.Size = new System.Drawing.Size(282, 29);
            this.text_productName.TabIndex = 3;
            this.text_productName.Enter += new System.EventHandler(this.text_productName_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(149, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Select a Product";
            // 
            // comboBox_productList
            // 
            this.comboBox_productList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.comboBox_productList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_productList.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_productList.ForeColor = System.Drawing.Color.White;
            this.comboBox_productList.FormattingEnabled = true;
            this.comboBox_productList.Location = new System.Drawing.Point(284, 34);
            this.comboBox_productList.Name = "comboBox_productList";
            this.comboBox_productList.Size = new System.Drawing.Size(282, 29);
            this.comboBox_productList.TabIndex = 0;
            this.comboBox_productList.SelectedValueChanged += new System.EventHandler(this.comboBox_productList_SelectedValueChanged);
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateProduct";
            this.Text = "Update Product";
            this.Load += new System.EventHandler(this.UpdateQuantity_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_newPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_addQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_productList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_productName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_CurrentQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDown_addQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_new;
        private System.Windows.Forms.Label label_newQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_currenrPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_newPrice;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_cancel;
    }
}