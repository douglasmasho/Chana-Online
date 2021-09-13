
namespace Chana_Online
{
    partial class FormLiqour
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
            this.panelLiqour = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelLiqour.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLiqour
            // 
            this.panelLiqour.Controls.Add(this.button3);
            this.panelLiqour.Controls.Add(this.button4);
            this.panelLiqour.Controls.Add(this.label9);
            this.panelLiqour.Controls.Add(this.label10);
            this.panelLiqour.Location = new System.Drawing.Point(43, 31);
            this.panelLiqour.Name = "panelLiqour";
            this.panelLiqour.Size = new System.Drawing.Size(1195, 788);
            this.panelLiqour.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Product Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(709, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 60);
            this.button3.TabIndex = 23;
            this.button3.Text = "Shop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.showShop);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Product Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(893, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 60);
            this.button4.TabIndex = 22;
            this.button4.Text = "Cart";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseCompatibleTextRendering = true;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.showCart);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Product Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(174, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 46);
            this.label9.TabIndex = 21;
            this.label9.Text = "Liqour";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bulletto Killa¬", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(23, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 56);
            this.label10.TabIndex = 20;
            this.label10.Text = "Chana__";
            // 
            // FormLiqour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 851);
            this.Controls.Add(this.panelLiqour);
            this.Name = "FormLiqour";
            this.Text = "FormLiqour";
            this.panelLiqour.ResumeLayout(false);
            this.panelLiqour.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLiqour;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}