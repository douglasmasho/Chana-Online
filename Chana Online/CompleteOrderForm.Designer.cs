
namespace Chana_Online
{
    partial class CompleteOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.RichTextBox();
            this.ccNumberBox = new System.Windows.Forms.NumericUpDown();
            this.phoneNumberBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ccNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bulletto Killa¬", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 56);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chana__ Online_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(411, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 64);
            this.label2.TabIndex = 13;
            this.label2.Text = "Complete order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Enter credit card number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(258, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 50);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.Location = new System.Drawing.Point(381, 489);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(61, 30);
            this.labelTotal.TabIndex = 17;
            this.labelTotal.Text = "0000";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(551, 250);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(188, 151);
            this.addressBox.TabIndex = 18;
            this.addressBox.Text = "";
            // 
            // ccNumberBox
            // 
            this.ccNumberBox.Location = new System.Drawing.Point(551, 129);
            this.ccNumberBox.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.ccNumberBox.Name = "ccNumberBox";
            this.ccNumberBox.Size = new System.Drawing.Size(188, 31);
            this.ccNumberBox.TabIndex = 20;
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(551, 182);
            this.phoneNumberBox.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(188, 31);
            this.phoneNumberBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Enter phone number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Enter address";
            // 
            // buttonOrder
            // 
            this.buttonOrder.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOrder.ForeColor = System.Drawing.Color.Red;
            this.buttonOrder.Location = new System.Drawing.Point(538, 466);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(201, 81);
            this.buttonOrder.TabIndex = 24;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // CompleteOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 604);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phoneNumberBox);
            this.Controls.Add(this.ccNumberBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CompleteOrderForm";
            this.Text = "CompleteOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.ccNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.RichTextBox addressBox;
        private System.Windows.Forms.NumericUpDown ccNumberBox;
        private System.Windows.Forms.NumericUpDown phoneNumberBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonOrder;
    }
}