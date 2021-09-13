
namespace Chana_Online
{
    partial class FormCart
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
            this.panelCart = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.GridViewLiqour = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.GridViewButchery = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.GridViewGrocery = new System.Windows.Forms.DataGridView();
            this.NameFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VATFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLiqour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewButchery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGrocery)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCart
            // 
            this.panelCart.Controls.Add(this.button1);
            this.panelCart.Controls.Add(this.label3);
            this.panelCart.Controls.Add(this.GridViewLiqour);
            this.panelCart.Controls.Add(this.label2);
            this.panelCart.Controls.Add(this.GridViewButchery);
            this.panelCart.Controls.Add(this.label1);
            this.panelCart.Controls.Add(this.GridViewGrocery);
            this.panelCart.Controls.Add(this.label13);
            this.panelCart.Controls.Add(this.button6);
            this.panelCart.Controls.Add(this.label14);
            this.panelCart.Location = new System.Drawing.Point(55, 47);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(1209, 946);
            this.panelCart.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(23, 625);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 36);
            this.label3.TabIndex = 33;
            this.label3.Text = "Liqour";
            // 
            // GridViewLiqour
            // 
            this.GridViewLiqour.AllowUserToAddRows = false;
            this.GridViewLiqour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewLiqour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.GridViewLiqour.Location = new System.Drawing.Point(23, 664);
            this.GridViewLiqour.Name = "GridViewLiqour";
            this.GridViewLiqour.ReadOnly = true;
            this.GridViewLiqour.RowHeadersWidth = 62;
            this.GridViewLiqour.RowTemplate.Height = 33;
            this.GridViewLiqour.Size = new System.Drawing.Size(1103, 185);
            this.GridViewLiqour.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "VAT";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Total Cost";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(23, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 36);
            this.label2.TabIndex = 31;
            this.label2.Text = "Butchery";
            // 
            // GridViewButchery
            // 
            this.GridViewButchery.AllowUserToAddRows = false;
            this.GridViewButchery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewButchery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.GridViewButchery.Location = new System.Drawing.Point(23, 415);
            this.GridViewButchery.Name = "GridViewButchery";
            this.GridViewButchery.ReadOnly = true;
            this.GridViewButchery.RowHeadersWidth = 62;
            this.GridViewButchery.RowTemplate.Height = 33;
            this.GridViewButchery.Size = new System.Drawing.Size(1103, 185);
            this.GridViewButchery.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "VAT";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Total Cost";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 36);
            this.label1.TabIndex = 29;
            this.label1.Text = "Grocery";
            // 
            // GridViewGrocery
            // 
            this.GridViewGrocery.AllowUserToAddRows = false;
            this.GridViewGrocery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewGrocery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameFood,
            this.QuantityFood,
            this.VATFood,
            this.TotalFood});
            this.GridViewGrocery.Location = new System.Drawing.Point(23, 159);
            this.GridViewGrocery.Name = "GridViewGrocery";
            this.GridViewGrocery.ReadOnly = true;
            this.GridViewGrocery.RowHeadersWidth = 62;
            this.GridViewGrocery.RowTemplate.Height = 33;
            this.GridViewGrocery.Size = new System.Drawing.Size(1103, 185);
            this.GridViewGrocery.TabIndex = 28;
            // 
            // NameFood
            // 
            this.NameFood.HeaderText = "Name";
            this.NameFood.MinimumWidth = 8;
            this.NameFood.Name = "NameFood";
            this.NameFood.ReadOnly = true;
            this.NameFood.Width = 150;
            // 
            // QuantityFood
            // 
            this.QuantityFood.HeaderText = "Quantity";
            this.QuantityFood.MinimumWidth = 8;
            this.QuantityFood.Name = "QuantityFood";
            this.QuantityFood.ReadOnly = true;
            this.QuantityFood.Width = 150;
            // 
            // VATFood
            // 
            this.VATFood.HeaderText = "VAT";
            this.VATFood.MinimumWidth = 8;
            this.VATFood.Name = "VATFood";
            this.VATFood.ReadOnly = true;
            this.VATFood.Width = 150;
            // 
            // TotalFood
            // 
            this.TotalFood.HeaderText = "Total Cost";
            this.TotalFood.MinimumWidth = 8;
            this.TotalFood.Name = "TotalFood";
            this.TotalFood.ReadOnly = true;
            this.TotalFood.Width = 150;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Product Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(491, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 36);
            this.label13.TabIndex = 27;
            this.label13.Text = "Cart";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Product Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(903, 26);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(158, 60);
            this.button6.TabIndex = 26;
            this.button6.Text = "Shop";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bulletto Killa¬", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(23, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(289, 56);
            this.label14.TabIndex = 24;
            this.label14.Text = "Chana__Online_";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 34;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1299, 1066);
            this.Controls.Add(this.panelCart);
            this.Name = "FormCart";
            this.Text = "FormCart";
            this.Load += new System.EventHandler(this.FormCart_Load);
            this.panelCart.ResumeLayout(false);
            this.panelCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLiqour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewButchery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGrocery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn VATFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFood;
        public System.Windows.Forms.Panel panelCart;
        public System.Windows.Forms.DataGridView GridViewGrocery;
        public System.Windows.Forms.DataGridView GridViewLiqour;
        public System.Windows.Forms.DataGridView GridViewButchery;
        private System.Windows.Forms.Button button1;
    }
}