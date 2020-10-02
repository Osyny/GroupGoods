namespace GroupGoods
{
    partial class Form1
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
            this.Group = new System.Windows.Forms.CheckBox();
            this.checkBoxCountry = new System.Windows.Forms.CheckBox();
            this.checkBoxCity = new System.Windows.Forms.CheckBox();
            this.checkBoxOrganisation = new System.Windows.Forms.CheckBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonGroup = new System.Windows.Forms.Button();
            this.dataGridViewGoods = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridViewGoods);
            this.panel1.Controls.Add(this.Group);
            this.panel1.Controls.Add(this.checkBoxCountry);
            this.panel1.Controls.Add(this.checkBoxCity);
            this.panel1.Controls.Add(this.checkBoxOrganisation);
            this.panel1.Controls.Add(this.checkBoxDate);
            this.panel1.Location = new System.Drawing.Point(53, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 280);
            this.panel1.TabIndex = 3;
            // 
            // Group
            // 
            this.Group.AutoSize = true;
            this.Group.Location = new System.Drawing.Point(465, 32);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(55, 17);
            this.Group.TabIndex = 5;
            this.Group.Text = "Group";
            this.Group.UseVisualStyleBackColor = true;
            // 
            // checkBoxCountry
            // 
            this.checkBoxCountry.AutoSize = true;
            this.checkBoxCountry.Location = new System.Drawing.Point(371, 32);
            this.checkBoxCountry.Name = "checkBoxCountry";
            this.checkBoxCountry.Size = new System.Drawing.Size(55, 17);
            this.checkBoxCountry.TabIndex = 4;
            this.checkBoxCountry.Text = "Group";
            this.checkBoxCountry.UseVisualStyleBackColor = true;
            // 
            // checkBoxCity
            // 
            this.checkBoxCity.AutoSize = true;
            this.checkBoxCity.Location = new System.Drawing.Point(268, 32);
            this.checkBoxCity.Name = "checkBoxCity";
            this.checkBoxCity.Size = new System.Drawing.Size(55, 17);
            this.checkBoxCity.TabIndex = 3;
            this.checkBoxCity.Text = "Group";
            this.checkBoxCity.UseVisualStyleBackColor = true;
            // 
            // checkBoxOrganisation
            // 
            this.checkBoxOrganisation.AutoSize = true;
            this.checkBoxOrganisation.Location = new System.Drawing.Point(170, 32);
            this.checkBoxOrganisation.Name = "checkBoxOrganisation";
            this.checkBoxOrganisation.Size = new System.Drawing.Size(55, 17);
            this.checkBoxOrganisation.TabIndex = 2;
            this.checkBoxOrganisation.Text = "Group";
            this.checkBoxOrganisation.UseVisualStyleBackColor = true;
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Location = new System.Drawing.Point(70, 32);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(55, 17);
            this.checkBoxDate.TabIndex = 1;
            this.checkBoxDate.Text = "Group";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowAll.Location = new System.Drawing.Point(125, 399);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(578, 39);
            this.buttonShowAll.TabIndex = 5;
            this.buttonShowAll.Text = "Show All";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonGroup
            // 
            this.buttonGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGroup.Location = new System.Drawing.Point(125, 338);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(578, 38);
            this.buttonGroup.TabIndex = 4;
            this.buttonGroup.Text = "Show Group";
            this.buttonGroup.UseVisualStyleBackColor = true;
            this.buttonGroup.Click += new System.EventHandler(this.buttonGroup_Click);
            // 
            // dataGridViewGoods
            // 
            this.dataGridViewGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Organisation,
            this.City,
            this.Manager,
            this.Qty,
            this.Price});
            this.dataGridViewGoods.Location = new System.Drawing.Point(28, 55);
            this.dataGridViewGoods.Name = "dataGridViewGoods";
            this.dataGridViewGoods.Size = new System.Drawing.Size(647, 201);
            this.dataGridViewGoods.TabIndex = 6;
            // 
            // Data
            // 
            this.Data.HeaderText = "Дата";
            this.Data.Name = "Data";
            // 
            // Organisation
            // 
            this.Organisation.HeaderText = "Організація";
            this.Organisation.Name = "Organisation";
            // 
            // City
            // 
            this.City.HeaderText = "Місто";
            this.City.Name = "City";
            // 
            // Manager
            // 
            this.Manager.HeaderText = "Менеджер";
            this.Manager.Name = "Manager";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Кількість";
            this.Qty.Name = "Qty";
            // 
            // Price
            // 
            this.Price.HeaderText = "Ціна";
            this.Price.Name = "Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox Group;
        private System.Windows.Forms.CheckBox checkBoxCountry;
        private System.Windows.Forms.CheckBox checkBoxCity;
        private System.Windows.Forms.CheckBox checkBoxOrganisation;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonGroup;
        private System.Windows.Forms.DataGridView dataGridViewGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}

