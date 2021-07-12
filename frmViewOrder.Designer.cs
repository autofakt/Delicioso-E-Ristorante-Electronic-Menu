
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
            this.btnOrderMore = new System.Windows.Forms.Button();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.lblReqChkPrompt = new System.Windows.Forms.Label();
            this.gbxEditOrder = new System.Windows.Forms.GroupBox();
            this.lblEditOrderPrompt = new System.Windows.Forms.Label();
            this.btnIncrease1 = new System.Windows.Forms.Button();
            this.btnDecrease1 = new System.Windows.Forms.Button();
            this.btnRequestCheck = new System.Windows.Forms.Button();
            this.gbxEstTotal = new System.Windows.Forms.GroupBox();
            this.lblEstTotal = new System.Windows.Forms.Label();
            this.gbxOrderItems = new System.Windows.Forms.GroupBox();
            this.lstItemsOrdered = new System.Windows.Forms.ListBox();
            this.lblAddOne = new System.Windows.Forms.Label();
            this.lblRemoveOne = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRestLogo)).BeginInit();
            this.gbxEditOrder.SuspendLayout();
            this.gbxEstTotal.SuspendLayout();
            this.gbxOrderItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // picRestLogo
            // 
            this.picRestLogo.Image = ((System.Drawing.Image)(resources.GetObject("picRestLogo.Image")));
            this.picRestLogo.InitialImage = null;
            this.picRestLogo.Location = new System.Drawing.Point(29, 12);
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
            this.lblRestaurantName.Location = new System.Drawing.Point(99, 13);
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(376, 51);
            this.lblRestaurantName.TabIndex = 18;
            this.lblRestaurantName.Text = "Delicioso E-Ristorante";
            // 
            // btnOrderMore
            // 
            this.btnOrderMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOrderMore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderMore.ForeColor = System.Drawing.Color.Black;
            this.btnOrderMore.Location = new System.Drawing.Point(610, 23);
            this.btnOrderMore.Name = "btnOrderMore";
            this.btnOrderMore.Size = new System.Drawing.Size(117, 37);
            this.btnOrderMore.TabIndex = 22;
            this.btnOrderMore.Text = "Order More";
            this.btnOrderMore.UseVisualStyleBackColor = false;
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSubmitOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitOrder.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitOrder.Location = new System.Drawing.Point(481, 23);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(123, 37);
            this.btnSubmitOrder.TabIndex = 21;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = false;
            // 
            // lblReqChkPrompt
            // 
            this.lblReqChkPrompt.AutoSize = true;
            this.lblReqChkPrompt.Location = new System.Drawing.Point(425, 650);
            this.lblReqChkPrompt.Name = "lblReqChkPrompt";
            this.lblReqChkPrompt.Size = new System.Drawing.Size(262, 13);
            this.lblReqChkPrompt.TabIndex = 28;
            this.lblReqChkPrompt.Text = "All done eating? Click here to request your itemized bill";
            // 
            // gbxEditOrder
            // 
            this.gbxEditOrder.Controls.Add(this.lblRemoveOne);
            this.gbxEditOrder.Controls.Add(this.lblAddOne);
            this.gbxEditOrder.Controls.Add(this.lblEditOrderPrompt);
            this.gbxEditOrder.Controls.Add(this.btnIncrease1);
            this.gbxEditOrder.Controls.Add(this.btnDecrease1);
            this.gbxEditOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEditOrder.Location = new System.Drawing.Point(389, 97);
            this.gbxEditOrder.Name = "gbxEditOrder";
            this.gbxEditOrder.Size = new System.Drawing.Size(321, 316);
            this.gbxEditOrder.TabIndex = 26;
            this.gbxEditOrder.TabStop = false;
            this.gbxEditOrder.Text = "Edit Your Order";
            // 
            // lblEditOrderPrompt
            // 
            this.lblEditOrderPrompt.Location = new System.Drawing.Point(20, 59);
            this.lblEditOrderPrompt.Name = "lblEditOrderPrompt";
            this.lblEditOrderPrompt.Size = new System.Drawing.Size(294, 51);
            this.lblEditOrderPrompt.TabIndex = 3;
            this.lblEditOrderPrompt.Text = "To edit your order, select an item.\r\nThen click the appropriate button:\r\n";
            // 
            // btnIncrease1
            // 
            this.btnIncrease1.Location = new System.Drawing.Point(61, 137);
            this.btnIncrease1.Name = "btnIncrease1";
            this.btnIncrease1.Size = new System.Drawing.Size(53, 44);
            this.btnIncrease1.TabIndex = 1;
            this.btnIncrease1.Text = "+";
            this.btnIncrease1.UseVisualStyleBackColor = true;
            // 
            // btnDecrease1
            // 
            this.btnDecrease1.Location = new System.Drawing.Point(61, 228);
            this.btnDecrease1.Name = "btnDecrease1";
            this.btnDecrease1.Size = new System.Drawing.Size(53, 44);
            this.btnDecrease1.TabIndex = 0;
            this.btnDecrease1.Text = "-";
            this.btnDecrease1.UseVisualStyleBackColor = true;
            // 
            // btnRequestCheck
            // 
            this.btnRequestCheck.BackColor = System.Drawing.Color.Black;
            this.btnRequestCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestCheck.ForeColor = System.Drawing.Color.White;
            this.btnRequestCheck.Location = new System.Drawing.Point(389, 572);
            this.btnRequestCheck.Name = "btnRequestCheck";
            this.btnRequestCheck.Size = new System.Drawing.Size(321, 65);
            this.btnRequestCheck.TabIndex = 25;
            this.btnRequestCheck.Text = "Request Check";
            this.btnRequestCheck.UseVisualStyleBackColor = false;
            // 
            // gbxEstTotal
            // 
            this.gbxEstTotal.Controls.Add(this.lblEstTotal);
            this.gbxEstTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEstTotal.Location = new System.Drawing.Point(389, 451);
            this.gbxEstTotal.Name = "gbxEstTotal";
            this.gbxEstTotal.Size = new System.Drawing.Size(321, 98);
            this.gbxEstTotal.TabIndex = 24;
            this.gbxEstTotal.TabStop = false;
            this.gbxEstTotal.Text = "Estimated Total";
            // 
            // lblEstTotal
            // 
            this.lblEstTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstTotal.Location = new System.Drawing.Point(24, 33);
            this.lblEstTotal.Name = "lblEstTotal";
            this.lblEstTotal.Size = new System.Drawing.Size(256, 40);
            this.lblEstTotal.TabIndex = 0;
            // 
            // gbxOrderItems
            // 
            this.gbxOrderItems.Controls.Add(this.lstItemsOrdered);
            this.gbxOrderItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOrderItems.Location = new System.Drawing.Point(29, 97);
            this.gbxOrderItems.Name = "gbxOrderItems";
            this.gbxOrderItems.Size = new System.Drawing.Size(315, 566);
            this.gbxOrderItems.TabIndex = 23;
            this.gbxOrderItems.TabStop = false;
            this.gbxOrderItems.Text = "Your Order";
            // 
            // lstItemsOrdered
            // 
            this.lstItemsOrdered.FormattingEnabled = true;
            this.lstItemsOrdered.ItemHeight = 20;
            this.lstItemsOrdered.Location = new System.Drawing.Point(26, 36);
            this.lstItemsOrdered.Name = "lstItemsOrdered";
            this.lstItemsOrdered.Size = new System.Drawing.Size(261, 504);
            this.lstItemsOrdered.TabIndex = 0;
            // 
            // lblAddOne
            // 
            this.lblAddOne.AutoSize = true;
            this.lblAddOne.Location = new System.Drawing.Point(131, 149);
            this.lblAddOne.Name = "lblAddOne";
            this.lblAddOne.Size = new System.Drawing.Size(124, 20);
            this.lblAddOne.TabIndex = 4;
            this.lblAddOne.Text = "Add One More";
            // 
            // lblRemoveOne
            // 
            this.lblRemoveOne.AutoSize = true;
            this.lblRemoveOne.Location = new System.Drawing.Point(131, 240);
            this.lblRemoveOne.Name = "lblRemoveOne";
            this.lblRemoveOne.Size = new System.Drawing.Size(112, 20);
            this.lblRemoveOne.TabIndex = 5;
            this.lblRemoveOne.Text = "Remove One";
            // 
            // frmViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 713);
            this.Controls.Add(this.lblReqChkPrompt);
            this.Controls.Add(this.gbxEditOrder);
            this.Controls.Add(this.btnRequestCheck);
            this.Controls.Add(this.gbxEstTotal);
            this.Controls.Add(this.gbxOrderItems);
            this.Controls.Add(this.btnOrderMore);
            this.Controls.Add(this.btnSubmitOrder);
            this.Controls.Add(this.picRestLogo);
            this.Controls.Add(this.lblRestaurantName);
            this.Name = "frmViewOrder";
            this.Text = "View My Order";
            ((System.ComponentModel.ISupportInitialize)(this.picRestLogo)).EndInit();
            this.gbxEditOrder.ResumeLayout(false);
            this.gbxEditOrder.PerformLayout();
            this.gbxEstTotal.ResumeLayout(false);
            this.gbxOrderItems.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picRestLogo;
        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.Button btnOrderMore;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Label lblReqChkPrompt;
        private System.Windows.Forms.GroupBox gbxEditOrder;
        private System.Windows.Forms.Label lblEditOrderPrompt;
        private System.Windows.Forms.Button btnIncrease1;
        private System.Windows.Forms.Button btnDecrease1;
        private System.Windows.Forms.Button btnRequestCheck;
        private System.Windows.Forms.GroupBox gbxEstTotal;
        private System.Windows.Forms.Label lblEstTotal;
        private System.Windows.Forms.GroupBox gbxOrderItems;
        private System.Windows.Forms.ListBox lstItemsOrdered;
        private System.Windows.Forms.Label lblRemoveOne;
        private System.Windows.Forms.Label lblAddOne;
    }
}