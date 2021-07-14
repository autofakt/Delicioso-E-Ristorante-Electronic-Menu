
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
            this.lstCurrentItems = new System.Windows.Forms.ListBox();
            this.lblEditMenuPrompt = new System.Windows.Forms.Label();
            this.gbxCurrentOrder = new System.Windows.Forms.GroupBox();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.btnOrderMore = new System.Windows.Forms.Button();
            this.lblEstimatedTotal = new System.Windows.Forms.Label();
            this.lblNoTaxOrTip = new System.Windows.Forms.Label();
            this.gbxEstTotal = new System.Windows.Forms.GroupBox();
            this.btnRequestCheck = new System.Windows.Forms.Button();
            this.lblReqChkPrompt = new System.Windows.Forms.Label();
            this.lblEnterNamePrompt = new System.Windows.Forms.Label();
            this.lblOrderMorePrompt = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblSubmitOrderPrompt = new System.Windows.Forms.Label();
            this.gbxTotalOrder = new System.Windows.Forms.GroupBox();
            this.lstTotalItems = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRestLogo)).BeginInit();
            this.gbxCurrentOrder.SuspendLayout();
            this.gbxEstTotal.SuspendLayout();
            this.gbxTotalOrder.SuspendLayout();
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
            // lstCurrentItems
            // 
            this.lstCurrentItems.FormattingEnabled = true;
            this.lstCurrentItems.ItemHeight = 20;
            this.lstCurrentItems.Location = new System.Drawing.Point(21, 37);
            this.lstCurrentItems.Name = "lstCurrentItems";
            this.lstCurrentItems.Size = new System.Drawing.Size(400, 244);
            this.lstCurrentItems.TabIndex = 0;
            // 
            // lblEditMenuPrompt
            // 
            this.lblEditMenuPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditMenuPrompt.Location = new System.Drawing.Point(17, 298);
            this.lblEditMenuPrompt.Name = "lblEditMenuPrompt";
            this.lblEditMenuPrompt.Size = new System.Drawing.Size(400, 31);
            this.lblEditMenuPrompt.TabIndex = 1;
            this.lblEditMenuPrompt.Text = "*You can edit your order by returning to the Main Menu";
            // 
            // gbxCurrentOrder
            // 
            this.gbxCurrentOrder.Controls.Add(this.lblEditMenuPrompt);
            this.gbxCurrentOrder.Controls.Add(this.lstCurrentItems);
            this.gbxCurrentOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCurrentOrder.Location = new System.Drawing.Point(52, 112);
            this.gbxCurrentOrder.Name = "gbxCurrentOrder";
            this.gbxCurrentOrder.Size = new System.Drawing.Size(439, 348);
            this.gbxCurrentOrder.TabIndex = 20;
            this.gbxCurrentOrder.TabStop = false;
            this.gbxCurrentOrder.Text = "Your Current Order";
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSubmitOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitOrder.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitOrder.Location = new System.Drawing.Point(203, 609);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(127, 37);
            this.btnSubmitOrder.TabIndex = 22;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = false;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // btnOrderMore
            // 
            this.btnOrderMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOrderMore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderMore.ForeColor = System.Drawing.Color.Black;
            this.btnOrderMore.Location = new System.Drawing.Point(352, 609);
            this.btnOrderMore.Name = "btnOrderMore";
            this.btnOrderMore.Size = new System.Drawing.Size(118, 37);
            this.btnOrderMore.TabIndex = 23;
            this.btnOrderMore.Text = "Main Menu";
            this.btnOrderMore.UseVisualStyleBackColor = false;
            this.btnOrderMore.Click += new System.EventHandler(this.btnOrderMore_Click);
            // 
            // lblEstimatedTotal
            // 
            this.lblEstimatedTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstimatedTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimatedTotal.Location = new System.Drawing.Point(21, 32);
            this.lblEstimatedTotal.Name = "lblEstimatedTotal";
            this.lblEstimatedTotal.Size = new System.Drawing.Size(165, 35);
            this.lblEstimatedTotal.TabIndex = 0;
            this.lblEstimatedTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNoTaxOrTip
            // 
            this.lblNoTaxOrTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTaxOrTip.Location = new System.Drawing.Point(202, 45);
            this.lblNoTaxOrTip.Name = "lblNoTaxOrTip";
            this.lblNoTaxOrTip.Size = new System.Drawing.Size(201, 25);
            this.lblNoTaxOrTip.TabIndex = 1;
            this.lblNoTaxOrTip.Text = "*does not include tax or tip.";
            // 
            // gbxEstTotal
            // 
            this.gbxEstTotal.Controls.Add(this.lblNoTaxOrTip);
            this.gbxEstTotal.Controls.Add(this.lblEstimatedTotal);
            this.gbxEstTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEstTotal.Location = new System.Drawing.Point(540, 490);
            this.gbxEstTotal.Name = "gbxEstTotal";
            this.gbxEstTotal.Size = new System.Drawing.Size(418, 81);
            this.gbxEstTotal.TabIndex = 24;
            this.gbxEstTotal.TabStop = false;
            this.gbxEstTotal.Text = "Estimated Total";
            // 
            // btnRequestCheck
            // 
            this.btnRequestCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestCheck.Location = new System.Drawing.Point(609, 609);
            this.btnRequestCheck.Name = "btnRequestCheck";
            this.btnRequestCheck.Size = new System.Drawing.Size(298, 38);
            this.btnRequestCheck.TabIndex = 25;
            this.btnRequestCheck.Text = "Request Check";
            this.btnRequestCheck.UseVisualStyleBackColor = true;
            this.btnRequestCheck.Click += new System.EventHandler(this.btnRequestCheck_Click);
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
            // lblEnterNamePrompt
            // 
            this.lblEnterNamePrompt.AutoSize = true;
            this.lblEnterNamePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNamePrompt.Location = new System.Drawing.Point(48, 578);
            this.lblEnterNamePrompt.Name = "lblEnterNamePrompt";
            this.lblEnterNamePrompt.Size = new System.Drawing.Size(130, 20);
            this.lblEnterNamePrompt.TabIndex = 27;
            this.lblEnterNamePrompt.Text = "Enter your name:";
            // 
            // lblOrderMorePrompt
            // 
            this.lblOrderMorePrompt.AutoSize = true;
            this.lblOrderMorePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderMorePrompt.Location = new System.Drawing.Point(348, 578);
            this.lblOrderMorePrompt.Name = "lblOrderMorePrompt";
            this.lblOrderMorePrompt.Size = new System.Drawing.Size(137, 20);
            this.lblOrderMorePrompt.TabIndex = 28;
            this.lblOrderMorePrompt.Text = "Want more Food?";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(52, 615);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(126, 27);
            this.txtCustomerName.TabIndex = 29;
            // 
            // lblSubmitOrderPrompt
            // 
            this.lblSubmitOrderPrompt.AutoSize = true;
            this.lblSubmitOrderPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitOrderPrompt.Location = new System.Drawing.Point(210, 578);
            this.lblSubmitOrderPrompt.Name = "lblSubmitOrderPrompt";
            this.lblSubmitOrderPrompt.Size = new System.Drawing.Size(109, 20);
            this.lblSubmitOrderPrompt.TabIndex = 30;
            this.lblSubmitOrderPrompt.Text = "Ready to eat?";
            // 
            // gbxTotalOrder
            // 
            this.gbxTotalOrder.Controls.Add(this.lstTotalItems);
            this.gbxTotalOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTotalOrder.Location = new System.Drawing.Point(541, 79);
            this.gbxTotalOrder.Name = "gbxTotalOrder";
            this.gbxTotalOrder.Size = new System.Drawing.Size(439, 381);
            this.gbxTotalOrder.TabIndex = 31;
            this.gbxTotalOrder.TabStop = false;
            this.gbxTotalOrder.Text = "Your Total Order";
            // 
            // lstTotalItems
            // 
            this.lstTotalItems.FormattingEnabled = true;
            this.lstTotalItems.ItemHeight = 20;
            this.lstTotalItems.Location = new System.Drawing.Point(21, 37);
            this.lstTotalItems.Name = "lstTotalItems";
            this.lstTotalItems.Size = new System.Drawing.Size(400, 324);
            this.lstTotalItems.TabIndex = 0;
            // 
            // frmViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.gbxTotalOrder);
            this.Controls.Add(this.lblSubmitOrderPrompt);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblOrderMorePrompt);
            this.Controls.Add(this.lblEnterNamePrompt);
            this.Controls.Add(this.lblReqChkPrompt);
            this.Controls.Add(this.btnRequestCheck);
            this.Controls.Add(this.gbxEstTotal);
            this.Controls.Add(this.btnOrderMore);
            this.Controls.Add(this.btnSubmitOrder);
            this.Controls.Add(this.gbxCurrentOrder);
            this.Controls.Add(this.picRestLogo);
            this.Controls.Add(this.lblRestaurantName);
            this.Name = "frmViewOrder";
            this.Text = "View My Order";
            ((System.ComponentModel.ISupportInitialize)(this.picRestLogo)).EndInit();
            this.gbxCurrentOrder.ResumeLayout(false);
            this.gbxEstTotal.ResumeLayout(false);
            this.gbxTotalOrder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picRestLogo;
        private System.Windows.Forms.Label lblRestaurantName;
        public System.Windows.Forms.ListBox lstCurrentItems;
        private System.Windows.Forms.Label lblEditMenuPrompt;
        private System.Windows.Forms.GroupBox gbxCurrentOrder;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Button btnOrderMore;
        public System.Windows.Forms.Label lblEstimatedTotal;
        private System.Windows.Forms.Label lblNoTaxOrTip;
        public System.Windows.Forms.GroupBox gbxEstTotal;
        private System.Windows.Forms.Button btnRequestCheck;
        private System.Windows.Forms.Label lblReqChkPrompt;
        private System.Windows.Forms.Label lblEnterNamePrompt;
        private System.Windows.Forms.Label lblOrderMorePrompt;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblSubmitOrderPrompt;
        private System.Windows.Forms.GroupBox gbxTotalOrder;
        public System.Windows.Forms.ListBox lstTotalItems;
    }
}