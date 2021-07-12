
namespace FinalProjectGUIDraft
{
    partial class frmViewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewOrder));
            this.picRestLogo = new System.Windows.Forms.PictureBox();
            this.lblRestaurantName = new System.Windows.Forms.Label();
            this.gbxYourOrder = new System.Windows.Forms.GroupBox();
            this.lstItemsOrdered = new System.Windows.Forms.ListBox();
            this.gbxEditOrder = new System.Windows.Forms.GroupBox();
            this.lblRemoveOne = new System.Windows.Forms.Label();
            this.lblAddOne = new System.Windows.Forms.Label();
            this.btnRemoveOne = new System.Windows.Forms.Button();
            this.btnAddOne = new System.Windows.Forms.Button();
            this.lblEditPrompt = new System.Windows.Forms.Label();
            this.btnOrderMore = new System.Windows.Forms.Button();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.gbxEstTotal = new System.Windows.Forms.GroupBox();
            this.lblEstimatedTotal = new System.Windows.Forms.Label();
            this.lblNoTaxOrTip = new System.Windows.Forms.Label();
            this.btnRequestCheck = new System.Windows.Forms.Button();
            this.lblReqChkPrompt = new System.Windows.Forms.Label();
            this.lblSubmitOrderPrompt = new System.Windows.Forms.Label();
            this.lblOrderMorePrompt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRestLogo)).BeginInit();
            this.gbxYourOrder.SuspendLayout();
            this.gbxEditOrder.SuspendLayout();
            this.gbxEstTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // picRestLogo
            // 
            this.picRestLogo.Image = ((System.Drawing.Image)(resources.GetObject("picRestLogo.Image")));
            this.picRestLogo.InitialImage = null;
            this.picRestLogo.Location = new System.Drawing.Point(27, 29);
            this.picRestLogo.Name = "picRestLogo";
            this.picRestLogo.Size = new System.Drawing.Size(64, 56);
            this.picRestLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRestLogo.TabIndex = 19;
            this.picRestLogo.TabStop = false;
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.AutoSize = true;
            this.lblRestaurantName.BackColor = System.Drawing.Color.White;
            this.lblRestaurantName.Font = new System.Drawing.Font("Papyrus", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurantName.Location = new System.Drawing.Point(97, 30);
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(376, 51);
            this.lblRestaurantName.TabIndex = 18;
            this.lblRestaurantName.Text = "Delicioso E-Ristorante";
            // 
            // gbxYourOrder
            // 
            this.gbxYourOrder.Controls.Add(this.lstItemsOrdered);
            this.gbxYourOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxYourOrder.Location = new System.Drawing.Point(52, 152);
            this.gbxYourOrder.Name = "gbxYourOrder";
            this.gbxYourOrder.Size = new System.Drawing.Size(439, 542);
            this.gbxYourOrder.TabIndex = 20;
            this.gbxYourOrder.TabStop = false;
            this.gbxYourOrder.Text = "Your Order";
            // 
            // lstItemsOrdered
            // 
            this.lstItemsOrdered.FormattingEnabled = true;
            this.lstItemsOrdered.ItemHeight = 20;
            this.lstItemsOrdered.Location = new System.Drawing.Point(40, 57);
            this.lstItemsOrdered.Name = "lstItemsOrdered";
            this.lstItemsOrdered.Size = new System.Drawing.Size(340, 444);
            this.lstItemsOrdered.TabIndex = 0;
            // 
            // gbxEditOrder
            // 
            this.gbxEditOrder.Controls.Add(this.lblRemoveOne);
            this.gbxEditOrder.Controls.Add(this.lblAddOne);
            this.gbxEditOrder.Controls.Add(this.btnRemoveOne);
            this.gbxEditOrder.Controls.Add(this.btnAddOne);
            this.gbxEditOrder.Controls.Add(this.lblEditPrompt);
            this.gbxEditOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEditOrder.Location = new System.Drawing.Point(542, 152);
            this.gbxEditOrder.Name = "gbxEditOrder";
            this.gbxEditOrder.Size = new System.Drawing.Size(419, 253);
            this.gbxEditOrder.TabIndex = 21;
            this.gbxEditOrder.TabStop = false;
            this.gbxEditOrder.Text = "Edit Your Order";
            // 
            // lblRemoveOne
            // 
            this.lblRemoveOne.AutoSize = true;
            this.lblRemoveOne.Location = new System.Drawing.Point(266, 179);
            this.lblRemoveOne.Name = "lblRemoveOne";
            this.lblRemoveOne.Size = new System.Drawing.Size(112, 20);
            this.lblRemoveOne.TabIndex = 4;
            this.lblRemoveOne.Text = "Remove One";
            // 
            // lblAddOne
            // 
            this.lblAddOne.AutoSize = true;
            this.lblAddOne.Location = new System.Drawing.Point(68, 179);
            this.lblAddOne.Name = "lblAddOne";
            this.lblAddOne.Size = new System.Drawing.Size(79, 20);
            this.lblAddOne.TabIndex = 3;
            this.lblAddOne.Text = "Add One";
            // 
            // btnRemoveOne
            // 
            this.btnRemoveOne.Location = new System.Drawing.Point(282, 109);
            this.btnRemoveOne.Name = "btnRemoveOne";
            this.btnRemoveOne.Size = new System.Drawing.Size(83, 67);
            this.btnRemoveOne.TabIndex = 2;
            this.btnRemoveOne.Text = "-1";
            this.btnRemoveOne.UseVisualStyleBackColor = true;
            // 
            // btnAddOne
            // 
            this.btnAddOne.Location = new System.Drawing.Point(67, 109);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(80, 67);
            this.btnAddOne.TabIndex = 1;
            this.btnAddOne.Text = "+1";
            this.btnAddOne.UseVisualStyleBackColor = true;
            // 
            // lblEditPrompt
            // 
            this.lblEditPrompt.AutoSize = true;
            this.lblEditPrompt.Location = new System.Drawing.Point(29, 38);
            this.lblEditPrompt.Name = "lblEditPrompt";
            this.lblEditPrompt.Size = new System.Drawing.Size(364, 40);
            this.lblEditPrompt.TabIndex = 0;
            this.lblEditPrompt.Text = "Select the item you wish to edit from the list.\r\nUse the buttons to change the qu" +
    "antity.";
            // 
            // btnOrderMore
            // 
            this.btnOrderMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOrderMore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderMore.ForeColor = System.Drawing.Color.Black;
            this.btnOrderMore.Location = new System.Drawing.Point(836, 83);
            this.btnOrderMore.Name = "btnOrderMore";
            this.btnOrderMore.Size = new System.Drawing.Size(124, 37);
            this.btnOrderMore.TabIndex = 23;
            this.btnOrderMore.Text = "Order More";
            this.btnOrderMore.UseVisualStyleBackColor = false;
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSubmitOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitOrder.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitOrder.Location = new System.Drawing.Point(542, 75);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(123, 37);
            this.btnSubmitOrder.TabIndex = 22;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = false;
            // 
            // gbxEstTotal
            // 
            this.gbxEstTotal.Controls.Add(this.lblNoTaxOrTip);
            this.gbxEstTotal.Controls.Add(this.lblEstimatedTotal);
            this.gbxEstTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEstTotal.Location = new System.Drawing.Point(542, 431);
            this.gbxEstTotal.Name = "gbxEstTotal";
            this.gbxEstTotal.Size = new System.Drawing.Size(418, 116);
            this.gbxEstTotal.TabIndex = 24;
            this.gbxEstTotal.TabStop = false;
            this.gbxEstTotal.Text = "Estimated Total";
            // 
            // lblEstimatedTotal
            // 
            this.lblEstimatedTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstimatedTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimatedTotal.Location = new System.Drawing.Point(33, 36);
            this.lblEstimatedTotal.Name = "lblEstimatedTotal";
            this.lblEstimatedTotal.Size = new System.Drawing.Size(360, 35);
            this.lblEstimatedTotal.TabIndex = 0;
            // 
            // lblNoTaxOrTip
            // 
            this.lblNoTaxOrTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTaxOrTip.Location = new System.Drawing.Point(199, 71);
            this.lblNoTaxOrTip.Name = "lblNoTaxOrTip";
            this.lblNoTaxOrTip.Size = new System.Drawing.Size(194, 25);
            this.lblNoTaxOrTip.TabIndex = 1;
            this.lblNoTaxOrTip.Text = "does not include tax or tip.";
            // 
            // btnRequestCheck
            // 
            this.btnRequestCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestCheck.Location = new System.Drawing.Point(609, 590);
            this.btnRequestCheck.Name = "btnRequestCheck";
            this.btnRequestCheck.Size = new System.Drawing.Size(298, 57);
            this.btnRequestCheck.TabIndex = 25;
            this.btnRequestCheck.Text = "Request Check";
            this.btnRequestCheck.UseVisualStyleBackColor = true;
            // 
            // lblReqChkPrompt
            // 
            this.lblReqChkPrompt.AutoSize = true;
            this.lblReqChkPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqChkPrompt.Location = new System.Drawing.Point(579, 650);
            this.lblReqChkPrompt.Name = "lblReqChkPrompt";
            this.lblReqChkPrompt.Size = new System.Drawing.Size(356, 20);
            this.lblReqChkPrompt.TabIndex = 26;
            this.lblReqChkPrompt.Text = "All done eating? Click here to request your check.";
            // 
            // lblSubmitOrderPrompt
            // 
            this.lblSubmitOrderPrompt.AutoSize = true;
            this.lblSubmitOrderPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitOrderPrompt.Location = new System.Drawing.Point(552, 52);
            this.lblSubmitOrderPrompt.Name = "lblSubmitOrderPrompt";
            this.lblSubmitOrderPrompt.Size = new System.Drawing.Size(113, 20);
            this.lblSubmitOrderPrompt.TabIndex = 27;
            this.lblSubmitOrderPrompt.Text = "Ready to eat? ";
            // 
            // lblOrderMorePrompt
            // 
            this.lblOrderMorePrompt.AutoSize = true;
            this.lblOrderMorePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderMorePrompt.Location = new System.Drawing.Point(832, 60);
            this.lblOrderMorePrompt.Name = "lblOrderMorePrompt";
            this.lblOrderMorePrompt.Size = new System.Drawing.Size(132, 20);
            this.lblOrderMorePrompt.TabIndex = 28;
            this.lblOrderMorePrompt.Text = "Want more food?";
            // 
            // frmViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lblOrderMorePrompt);
            this.Controls.Add(this.lblSubmitOrderPrompt);
            this.Controls.Add(this.lblReqChkPrompt);
            this.Controls.Add(this.btnRequestCheck);
            this.Controls.Add(this.gbxEstTotal);
            this.Controls.Add(this.btnOrderMore);
            this.Controls.Add(this.btnSubmitOrder);
            this.Controls.Add(this.gbxEditOrder);
            this.Controls.Add(this.gbxYourOrder);
            this.Controls.Add(this.picRestLogo);
            this.Controls.Add(this.lblRestaurantName);
            this.Name = "frmViewOrder";
            this.Text = "View My Order";
            ((System.ComponentModel.ISupportInitialize)(this.picRestLogo)).EndInit();
            this.gbxYourOrder.ResumeLayout(false);
            this.gbxEditOrder.ResumeLayout(false);
            this.gbxEditOrder.PerformLayout();
            this.gbxEstTotal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picRestLogo;
        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.GroupBox gbxYourOrder;
        private System.Windows.Forms.ListBox lstItemsOrdered;
        private System.Windows.Forms.GroupBox gbxEditOrder;
        private System.Windows.Forms.Label lblRemoveOne;
        private System.Windows.Forms.Label lblAddOne;
        private System.Windows.Forms.Button btnRemoveOne;
        private System.Windows.Forms.Button btnAddOne;
        private System.Windows.Forms.Label lblEditPrompt;
        private System.Windows.Forms.Button btnOrderMore;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.GroupBox gbxEstTotal;
        private System.Windows.Forms.Label lblNoTaxOrTip;
        private System.Windows.Forms.Label lblEstimatedTotal;
        private System.Windows.Forms.Button btnRequestCheck;
        private System.Windows.Forms.Label lblReqChkPrompt;
        private System.Windows.Forms.Label lblSubmitOrderPrompt;
        private System.Windows.Forms.Label lblOrderMorePrompt;
    }
}