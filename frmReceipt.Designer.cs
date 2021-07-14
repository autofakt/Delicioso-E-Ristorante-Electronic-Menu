
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
            this.lblMethodPayment = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotalInfo = new System.Windows.Forms.Label();
            this.lblReceiptNumbers = new System.Windows.Forms.Label();
            this.lblcustomerName = new System.Windows.Forms.Label();
            this.picRestLogo = new System.Windows.Forms.PictureBox();
            this.lblRestaurantName = new System.Windows.Forms.Label();
            this.gbxYourOrder = new System.Windows.Forms.GroupBox();
            this.lstItemsOrdered = new System.Windows.Forms.ListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.picGrazie = new System.Windows.Forms.PictureBox();
            this.lblDateInfo = new System.Windows.Forms.Label();
            this.lblReceiptNumInfo = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTaxInfo = new System.Windows.Forms.Label();
            this.lblTipInfo = new System.Windows.Forms.Label();
            this.lblGrandTotalInfo = new System.Windows.Forms.Label();
            this.lblMethodPymtInfo = new System.Windows.Forms.Label();
            this.lblCustNameInfo = new System.Windows.Forms.Label();
            this.btnSaveReceipt = new System.Windows.Forms.Button();
            this.lblResetPrompt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRestLogo)).BeginInit();
            this.gbxYourOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrazie)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMethodPayment
            // 
            this.lblMethodPayment.AutoSize = true;
            this.lblMethodPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethodPayment.Location = new System.Drawing.Point(576, 317);
            this.lblMethodPayment.Name = "lblMethodPayment";
            this.lblMethodPayment.Size = new System.Drawing.Size(195, 24);
            this.lblMethodPayment.TabIndex = 17;
            this.lblMethodPayment.Text = "Method of Payment:";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(646, 280);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(125, 24);
            this.lblGrandTotal.TabIndex = 16;
            this.lblGrandTotal.Text = "Grand Total:";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(725, 244);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(46, 24);
            this.lblTip.TabIndex = 15;
            this.lblTip.Text = "Tip:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(720, 206);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(51, 24);
            this.lblTax.TabIndex = 14;
            this.lblTax.Text = "Tax:";
            // 
            // lblSubtotalInfo
            // 
            this.lblSubtotalInfo.AutoSize = true;
            this.lblSubtotalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalInfo.Location = new System.Drawing.Point(680, 168);
            this.lblSubtotalInfo.Name = "lblSubtotalInfo";
            this.lblSubtotalInfo.Size = new System.Drawing.Size(91, 24);
            this.lblSubtotalInfo.TabIndex = 13;
            this.lblSubtotalInfo.Text = "Subtotal:";
            // 
            // lblReceiptNumbers
            // 
            this.lblReceiptNumbers.AutoSize = true;
            this.lblReceiptNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptNumbers.Location = new System.Drawing.Point(667, 110);
            this.lblReceiptNumbers.Name = "lblReceiptNumbers";
            this.lblReceiptNumbers.Size = new System.Drawing.Size(104, 24);
            this.lblReceiptNumbers.TabIndex = 18;
            this.lblReceiptNumbers.Text = "Receipt #:";
            // 
            // lblcustomerName
            // 
            this.lblcustomerName.AutoSize = true;
            this.lblcustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomerName.Location = new System.Drawing.Point(44, 102);
            this.lblcustomerName.Name = "lblcustomerName";
            this.lblcustomerName.Size = new System.Drawing.Size(166, 24);
            this.lblcustomerName.TabIndex = 19;
            this.lblcustomerName.Text = "Customer Name:";
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
            // gbxYourOrder
            // 
            this.gbxYourOrder.Controls.Add(this.lstItemsOrdered);
            this.gbxYourOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxYourOrder.Location = new System.Drawing.Point(48, 148);
            this.gbxYourOrder.Name = "gbxYourOrder";
            this.gbxYourOrder.Size = new System.Drawing.Size(439, 542);
            this.gbxYourOrder.TabIndex = 24;
            this.gbxYourOrder.TabStop = false;
            this.gbxYourOrder.Text = "Your Order";
            // 
            // lstItemsOrdered
            // 
            this.lstItemsOrdered.FormattingEnabled = true;
            this.lstItemsOrdered.ItemHeight = 20;
            this.lstItemsOrdered.Location = new System.Drawing.Point(21, 57);
            this.lstItemsOrdered.Name = "lstItemsOrdered";
            this.lstItemsOrdered.Size = new System.Drawing.Size(400, 444);
            this.lstItemsOrdered.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(713, 49);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 24);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = "Date:";
            // 
            // picGrazie
            // 
            this.picGrazie.Image = ((System.Drawing.Image)(resources.GetObject("picGrazie.Image")));
            this.picGrazie.Location = new System.Drawing.Point(579, 358);
            this.picGrazie.Name = "picGrazie";
            this.picGrazie.Size = new System.Drawing.Size(318, 291);
            this.picGrazie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGrazie.TabIndex = 26;
            this.picGrazie.TabStop = false;
            // 
            // lblDateInfo
            // 
            this.lblDateInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateInfo.Location = new System.Drawing.Point(777, 49);
            this.lblDateInfo.Name = "lblDateInfo";
            this.lblDateInfo.Size = new System.Drawing.Size(120, 23);
            this.lblDateInfo.TabIndex = 27;
            this.lblDateInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReceiptNumInfo
            // 
            this.lblReceiptNumInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceiptNumInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptNumInfo.Location = new System.Drawing.Point(777, 112);
            this.lblReceiptNumInfo.Name = "lblReceiptNumInfo";
            this.lblReceiptNumInfo.Size = new System.Drawing.Size(120, 23);
            this.lblReceiptNumInfo.TabIndex = 28;
            this.lblReceiptNumInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(777, 168);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(120, 23);
            this.lblSubtotal.TabIndex = 29;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaxInfo
            // 
            this.lblTaxInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTaxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxInfo.Location = new System.Drawing.Point(777, 205);
            this.lblTaxInfo.Name = "lblTaxInfo";
            this.lblTaxInfo.Size = new System.Drawing.Size(120, 23);
            this.lblTaxInfo.TabIndex = 30;
            this.lblTaxInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTipInfo
            // 
            this.lblTipInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTipInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipInfo.Location = new System.Drawing.Point(777, 244);
            this.lblTipInfo.Name = "lblTipInfo";
            this.lblTipInfo.Size = new System.Drawing.Size(120, 23);
            this.lblTipInfo.TabIndex = 31;
            this.lblTipInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrandTotalInfo
            // 
            this.lblGrandTotalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrandTotalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotalInfo.Location = new System.Drawing.Point(777, 280);
            this.lblGrandTotalInfo.Name = "lblGrandTotalInfo";
            this.lblGrandTotalInfo.Size = new System.Drawing.Size(120, 23);
            this.lblGrandTotalInfo.TabIndex = 32;
            this.lblGrandTotalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMethodPymtInfo
            // 
            this.lblMethodPymtInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMethodPymtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethodPymtInfo.Location = new System.Drawing.Point(777, 319);
            this.lblMethodPymtInfo.Name = "lblMethodPymtInfo";
            this.lblMethodPymtInfo.Size = new System.Drawing.Size(120, 23);
            this.lblMethodPymtInfo.TabIndex = 33;
            this.lblMethodPymtInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustNameInfo
            // 
            this.lblCustNameInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustNameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustNameInfo.Location = new System.Drawing.Point(216, 102);
            this.lblCustNameInfo.Name = "lblCustNameInfo";
            this.lblCustNameInfo.Size = new System.Drawing.Size(145, 23);
            this.lblCustNameInfo.TabIndex = 34;
            this.lblCustNameInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveReceipt
            // 
            this.btnSaveReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveReceipt.Location = new System.Drawing.Point(650, 644);
            this.btnSaveReceipt.Name = "btnSaveReceipt";
            this.btnSaveReceipt.Size = new System.Drawing.Size(193, 37);
            this.btnSaveReceipt.TabIndex = 35;
            this.btnSaveReceipt.Text = "Save Receipt ";
            this.btnSaveReceipt.UseVisualStyleBackColor = true;
            // 
            // lblResetPrompt
            // 
            this.lblResetPrompt.AutoSize = true;
            this.lblResetPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetPrompt.Location = new System.Drawing.Point(646, 684);
            this.lblResetPrompt.Name = "lblResetPrompt";
            this.lblResetPrompt.Size = new System.Drawing.Size(198, 20);
            this.lblResetPrompt.TabIndex = 36;
            this.lblResetPrompt.Text = "And reset electronic menu.";
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lblResetPrompt);
            this.Controls.Add(this.btnSaveReceipt);
            this.Controls.Add(this.lblCustNameInfo);
            this.Controls.Add(this.lblMethodPymtInfo);
            this.Controls.Add(this.lblGrandTotalInfo);
            this.Controls.Add(this.lblTipInfo);
            this.Controls.Add(this.lblTaxInfo);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblReceiptNumInfo);
            this.Controls.Add(this.lblDateInfo);
            this.Controls.Add(this.picGrazie);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.gbxYourOrder);
            this.Controls.Add(this.picRestLogo);
            this.Controls.Add(this.lblRestaurantName);
            this.Controls.Add(this.lblcustomerName);
            this.Controls.Add(this.lblReceiptNumbers);
            this.Controls.Add(this.lblMethodPayment);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotalInfo);
            this.Name = "frmReceipt";
            this.Text = "Receipt";
            ((System.ComponentModel.ISupportInitialize)(this.picRestLogo)).EndInit();
            this.gbxYourOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGrazie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMethodPayment;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotalInfo;
        private System.Windows.Forms.Label lblReceiptNumbers;
        private System.Windows.Forms.Label lblcustomerName;
        private System.Windows.Forms.PictureBox picRestLogo;
        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.GroupBox gbxYourOrder;
        public System.Windows.Forms.ListBox lstItemsOrdered;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox picGrazie;
        private System.Windows.Forms.Label lblDateInfo;
        private System.Windows.Forms.Label lblReceiptNumInfo;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTaxInfo;
        private System.Windows.Forms.Label lblTipInfo;
        private System.Windows.Forms.Label lblGrandTotalInfo;
        private System.Windows.Forms.Label lblMethodPymtInfo;
        private System.Windows.Forms.Label lblCustNameInfo;
        private System.Windows.Forms.Button btnSaveReceipt;
        private System.Windows.Forms.Label lblResetPrompt;
    }
}