
namespace FinalProjectGUIDraft
{
    partial class frmReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceipt));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReceiptNumber = new System.Windows.Forms.Label();
            this.lblcustomerName = new System.Windows.Forms.Label();
            this.lstDetailOnReceipt = new System.Windows.Forms.ListBox();
            this.picRestLogo = new System.Windows.Forms.PictureBox();
            this.lblRestaurantName = new System.Windows.Forms.Label();
            this.gbxOrderDetailOnReceipt = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRestLogo)).BeginInit();
            this.gbxOrderDetailOnReceipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 615);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Method of Payment:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(367, 578);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Grand Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tip:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(401, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Subtotal:";
            // 
            // lblReceiptNumber
            // 
            this.lblReceiptNumber.AutoSize = true;
            this.lblReceiptNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptNumber.Location = new System.Drawing.Point(287, 114);
            this.lblReceiptNumber.Name = "lblReceiptNumber";
            this.lblReceiptNumber.Size = new System.Drawing.Size(104, 24);
            this.lblReceiptNumber.TabIndex = 18;
            this.lblReceiptNumber.Text = "Receipt #:";
            // 
            // lblcustomerName
            // 
            this.lblcustomerName.AutoSize = true;
            this.lblcustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomerName.Location = new System.Drawing.Point(526, 114);
            this.lblcustomerName.Name = "lblcustomerName";
            this.lblcustomerName.Size = new System.Drawing.Size(166, 24);
            this.lblcustomerName.TabIndex = 19;
            this.lblcustomerName.Text = "Customer Name:";
            // 
            // lstDetailOnReceipt
            // 
            this.lstDetailOnReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDetailOnReceipt.FormattingEnabled = true;
            this.lstDetailOnReceipt.ItemHeight = 24;
            this.lstDetailOnReceipt.Items.AddRange(new object[] {
            "1     Dish1      $32.50",
            "2     Dish2      $32.50",
            "3     Dish3      $32.50",
            "4     Dish4      $32.50"});
            this.lstDetailOnReceipt.Location = new System.Drawing.Point(24, 34);
            this.lstDetailOnReceipt.Name = "lstDetailOnReceipt";
            this.lstDetailOnReceipt.Size = new System.Drawing.Size(469, 244);
            this.lstDetailOnReceipt.TabIndex = 20;
            // 
            // picRestLogo
            // 
            this.picRestLogo.Image = ((System.Drawing.Image)(resources.GetObject("picRestLogo.Image")));
            this.picRestLogo.InitialImage = null;
            this.picRestLogo.Location = new System.Drawing.Point(24, 21);
            this.picRestLogo.Name = "picRestLogo";
            this.picRestLogo.Size = new System.Drawing.Size(64, 56);
            this.picRestLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRestLogo.TabIndex = 23;
            this.picRestLogo.TabStop = false;
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.AutoSize = true;
            this.lblRestaurantName.BackColor = System.Drawing.Color.White;
            this.lblRestaurantName.Font = new System.Drawing.Font("Papyrus", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurantName.Location = new System.Drawing.Point(94, 26);
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(376, 51);
            this.lblRestaurantName.TabIndex = 22;
            this.lblRestaurantName.Text = "Delicioso E-Ristorante";
            // 
            // gbxOrderDetailOnReceipt
            // 
            this.gbxOrderDetailOnReceipt.Controls.Add(this.lstDetailOnReceipt);
            this.gbxOrderDetailOnReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOrderDetailOnReceipt.Location = new System.Drawing.Point(291, 155);
            this.gbxOrderDetailOnReceipt.Name = "gbxOrderDetailOnReceipt";
            this.gbxOrderDetailOnReceipt.Size = new System.Drawing.Size(519, 308);
            this.gbxOrderDetailOnReceipt.TabIndex = 24;
            this.gbxOrderDetailOnReceipt.TabStop = false;
            this.gbxOrderDetailOnReceipt.Text = "Orde Detail:";
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.gbxOrderDetailOnReceipt);
            this.Controls.Add(this.picRestLogo);
            this.Controls.Add(this.lblRestaurantName);
            this.Controls.Add(this.lblcustomerName);
            this.Controls.Add(this.lblReceiptNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "frmReceipt";
            this.Text = "Receipt";
            ((System.ComponentModel.ISupportInitialize)(this.picRestLogo)).EndInit();
            this.gbxOrderDetailOnReceipt.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReceiptNumber;
        private System.Windows.Forms.Label lblcustomerName;
        private System.Windows.Forms.ListBox lstDetailOnReceipt;
        private System.Windows.Forms.PictureBox picRestLogo;
        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.GroupBox gbxOrderDetailOnReceipt;
    }
}