
namespace FinalProjectGUIDraft
{
    partial class frmBillAndPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillAndPayment));
            this.picRestLogo = new System.Windows.Forms.PictureBox();
            this.lblRestaurantName = new System.Windows.Forms.Label();
            this.gbxItemizedBill = new System.Windows.Forms.GroupBox();
            this.tbxGrandTotal = new System.Windows.Forms.TextBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.tbxTip = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.tbxTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.tbxSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lstItemizedBill = new System.Windows.Forms.ListBox();
            this.gbxPaymentMethod = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPayBill = new System.Windows.Forms.Button();
            this.lblPinNum = new System.Windows.Forms.Label();
            this.txtPinNumber = new System.Windows.Forms.TextBox();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblPymtMthdPrompt = new System.Windows.Forms.Label();
            this.rbtnDebitCard = new System.Windows.Forms.RadioButton();
            this.rbtnCreditCard = new System.Windows.Forms.RadioButton();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.gbxAddTip = new System.Windows.Forms.GroupBox();
            this.rbtn0 = new System.Windows.Forms.RadioButton();
            this.rbtn25 = new System.Windows.Forms.RadioButton();
            this.rbtn20 = new System.Windows.Forms.RadioButton();
            this.rbtn15 = new System.Windows.Forms.RadioButton();
            this.rbtn10 = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picRestLogo)).BeginInit();
            this.gbxItemizedBill.SuspendLayout();
            this.gbxPaymentMethod.SuspendLayout();
            this.gbxAddTip.SuspendLayout();
            this.SuspendLayout();
            // 
            // picRestLogo
            // 
            this.picRestLogo.Image = ((System.Drawing.Image)(resources.GetObject("picRestLogo.Image")));
            this.picRestLogo.InitialImage = null;
            this.picRestLogo.Location = new System.Drawing.Point(12, 12);
            this.picRestLogo.Name = "picRestLogo";
            this.picRestLogo.Size = new System.Drawing.Size(111, 106);
            this.picRestLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRestLogo.TabIndex = 21;
            this.picRestLogo.TabStop = false;
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.AutoSize = true;
            this.lblRestaurantName.BackColor = System.Drawing.Color.Transparent;
            this.lblRestaurantName.Font = new System.Drawing.Font("Papyrus", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurantName.Location = new System.Drawing.Point(151, 33);
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(547, 76);
            this.lblRestaurantName.TabIndex = 20;
            this.lblRestaurantName.Text = "Delicioso E-Ristorante";
            // 
            // gbxItemizedBill
            // 
            this.gbxItemizedBill.Controls.Add(this.tbxGrandTotal);
            this.gbxItemizedBill.Controls.Add(this.lblGrandTotal);
            this.gbxItemizedBill.Controls.Add(this.tbxTip);
            this.gbxItemizedBill.Controls.Add(this.lblTip);
            this.gbxItemizedBill.Controls.Add(this.tbxTax);
            this.gbxItemizedBill.Controls.Add(this.lblTax);
            this.gbxItemizedBill.Controls.Add(this.tbxSubTotal);
            this.gbxItemizedBill.Controls.Add(this.lblSubTotal);
            this.gbxItemizedBill.Controls.Add(this.lstItemizedBill);
            this.gbxItemizedBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxItemizedBill.Location = new System.Drawing.Point(243, 166);
            this.gbxItemizedBill.Name = "gbxItemizedBill";
            this.gbxItemizedBill.Size = new System.Drawing.Size(388, 565);
            this.gbxItemizedBill.TabIndex = 22;
            this.gbxItemizedBill.TabStop = false;
            this.gbxItemizedBill.Text = "Itemized Bill";
            // 
            // tbxGrandTotal
            // 
            this.tbxGrandTotal.Location = new System.Drawing.Point(173, 483);
            this.tbxGrandTotal.Name = "tbxGrandTotal";
            this.tbxGrandTotal.ReadOnly = true;
            this.tbxGrandTotal.Size = new System.Drawing.Size(100, 26);
            this.tbxGrandTotal.TabIndex = 32;
            this.tbxGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(76, 486);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(54, 20);
            this.lblGrandTotal.TabIndex = 31;
            this.lblGrandTotal.Text = "Total:";
            // 
            // tbxTip
            // 
            this.tbxTip.Location = new System.Drawing.Point(173, 440);
            this.tbxTip.Name = "tbxTip";
            this.tbxTip.ReadOnly = true;
            this.tbxTip.Size = new System.Drawing.Size(100, 26);
            this.tbxTip.TabIndex = 30;
            this.tbxTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(76, 443);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(38, 20);
            this.lblTip.TabIndex = 29;
            this.lblTip.Text = "Tip:";
            // 
            // tbxTax
            // 
            this.tbxTax.Location = new System.Drawing.Point(173, 396);
            this.tbxTax.Name = "tbxTax";
            this.tbxTax.ReadOnly = true;
            this.tbxTax.Size = new System.Drawing.Size(100, 26);
            this.tbxTax.TabIndex = 28;
            this.tbxTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(76, 399);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(42, 20);
            this.lblTax.TabIndex = 27;
            this.lblTax.Text = "Tax:";
            // 
            // tbxSubTotal
            // 
            this.tbxSubTotal.Location = new System.Drawing.Point(173, 351);
            this.tbxSubTotal.Name = "tbxSubTotal";
            this.tbxSubTotal.ReadOnly = true;
            this.tbxSubTotal.Size = new System.Drawing.Size(100, 26);
            this.tbxSubTotal.TabIndex = 26;
            this.tbxSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(76, 354);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(91, 20);
            this.lblSubTotal.TabIndex = 25;
            this.lblSubTotal.Text = "Sub Total:";
            // 
            // lstItemizedBill
            // 
            this.lstItemizedBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItemizedBill.FormattingEnabled = true;
            this.lstItemizedBill.ItemHeight = 20;
            this.lstItemizedBill.Location = new System.Drawing.Point(6, 41);
            this.lstItemizedBill.Name = "lstItemizedBill";
            this.lstItemizedBill.Size = new System.Drawing.Size(376, 284);
            this.lstItemizedBill.TabIndex = 0;
            // 
            // gbxPaymentMethod
            // 
            this.gbxPaymentMethod.Controls.Add(this.label1);
            this.gbxPaymentMethod.Controls.Add(this.btnPayBill);
            this.gbxPaymentMethod.Controls.Add(this.lblPinNum);
            this.gbxPaymentMethod.Controls.Add(this.txtPinNumber);
            this.gbxPaymentMethod.Controls.Add(this.lblExpDate);
            this.gbxPaymentMethod.Controls.Add(this.txtExpDate);
            this.gbxPaymentMethod.Controls.Add(this.lblCardNumber);
            this.gbxPaymentMethod.Controls.Add(this.txtCardNumber);
            this.gbxPaymentMethod.Controls.Add(this.lblPymtMthdPrompt);
            this.gbxPaymentMethod.Controls.Add(this.rbtnDebitCard);
            this.gbxPaymentMethod.Controls.Add(this.rbtnCreditCard);
            this.gbxPaymentMethod.Controls.Add(this.rbtnCash);
            this.gbxPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPaymentMethod.Location = new System.Drawing.Point(667, 312);
            this.gbxPaymentMethod.Name = "gbxPaymentMethod";
            this.gbxPaymentMethod.Size = new System.Drawing.Size(523, 419);
            this.gbxPaymentMethod.TabIndex = 23;
            this.gbxPaymentMethod.TabStop = false;
            this.gbxPaymentMethod.Text = "Method of Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(407, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "No Checks";
            // 
            // btnPayBill
            // 
            this.btnPayBill.Location = new System.Drawing.Point(158, 322);
            this.btnPayBill.Name = "btnPayBill";
            this.btnPayBill.Size = new System.Drawing.Size(207, 57);
            this.btnPayBill.TabIndex = 13;
            this.btnPayBill.Text = "Pay Bill";
            this.btnPayBill.UseVisualStyleBackColor = true;
            this.btnPayBill.Click += new System.EventHandler(this.btnPayBill_Click);
            // 
            // lblPinNum
            // 
            this.lblPinNum.AutoSize = true;
            this.lblPinNum.Location = new System.Drawing.Point(77, 253);
            this.lblPinNum.Name = "lblPinNum";
            this.lblPinNum.Size = new System.Drawing.Size(111, 20);
            this.lblPinNum.TabIndex = 12;
            this.lblPinNum.Text = "Pin Number: ";
            // 
            // txtPinNumber
            // 
            this.txtPinNumber.Location = new System.Drawing.Point(207, 253);
            this.txtPinNumber.Name = "txtPinNumber";
            this.txtPinNumber.ReadOnly = true;
            this.txtPinNumber.Size = new System.Drawing.Size(97, 26);
            this.txtPinNumber.TabIndex = 11;
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(63, 202);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(138, 20);
            this.lblExpDate.TabIndex = 10;
            this.lblExpDate.Text = "Expiration Date:";
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(207, 202);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.ReadOnly = true;
            this.txtExpDate.Size = new System.Drawing.Size(58, 26);
            this.txtExpDate.TabIndex = 9;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(77, 153);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(124, 20);
            this.lblCardNumber.TabIndex = 8;
            this.lblCardNumber.Text = "Card Number: ";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(207, 153);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.ReadOnly = true;
            this.txtCardNumber.Size = new System.Drawing.Size(223, 26);
            this.txtCardNumber.TabIndex = 7;
            // 
            // lblPymtMthdPrompt
            // 
            this.lblPymtMthdPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPymtMthdPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPymtMthdPrompt.Location = new System.Drawing.Point(28, 94);
            this.lblPymtMthdPrompt.Name = "lblPymtMthdPrompt";
            this.lblPymtMthdPrompt.Size = new System.Drawing.Size(440, 33);
            this.lblPymtMthdPrompt.TabIndex = 6;
            this.lblPymtMthdPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPymtMthdPrompt.Visible = false;
            // 
            // rbtnDebitCard
            // 
            this.rbtnDebitCard.AutoSize = true;
            this.rbtnDebitCard.Location = new System.Drawing.Point(275, 44);
            this.rbtnDebitCard.Name = "rbtnDebitCard";
            this.rbtnDebitCard.Size = new System.Drawing.Size(113, 24);
            this.rbtnDebitCard.TabIndex = 5;
            this.rbtnDebitCard.TabStop = true;
            this.rbtnDebitCard.Text = "Debit Card";
            this.rbtnDebitCard.UseVisualStyleBackColor = true;
            this.rbtnDebitCard.CheckedChanged += new System.EventHandler(this.rbtnDebitCard_CheckedChanged);
            // 
            // rbtnCreditCard
            // 
            this.rbtnCreditCard.AutoSize = true;
            this.rbtnCreditCard.Location = new System.Drawing.Point(122, 44);
            this.rbtnCreditCard.Name = "rbtnCreditCard";
            this.rbtnCreditCard.Size = new System.Drawing.Size(118, 24);
            this.rbtnCreditCard.TabIndex = 4;
            this.rbtnCreditCard.TabStop = true;
            this.rbtnCreditCard.Text = "Credit Card";
            this.rbtnCreditCard.UseVisualStyleBackColor = true;
            this.rbtnCreditCard.CheckedChanged += new System.EventHandler(this.rbtnCreditCard_CheckedChanged);
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.Location = new System.Drawing.Point(28, 44);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(68, 24);
            this.rbtnCash.TabIndex = 3;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "Cash";
            this.rbtnCash.UseVisualStyleBackColor = true;
            this.rbtnCash.CheckedChanged += new System.EventHandler(this.rbtnCash_CheckedChanged);
            // 
            // gbxAddTip
            // 
            this.gbxAddTip.Controls.Add(this.rbtn0);
            this.gbxAddTip.Controls.Add(this.rbtn25);
            this.gbxAddTip.Controls.Add(this.rbtn20);
            this.gbxAddTip.Controls.Add(this.rbtn15);
            this.gbxAddTip.Controls.Add(this.rbtn10);
            this.gbxAddTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddTip.Location = new System.Drawing.Point(667, 166);
            this.gbxAddTip.Name = "gbxAddTip";
            this.gbxAddTip.Size = new System.Drawing.Size(523, 106);
            this.gbxAddTip.TabIndex = 24;
            this.gbxAddTip.TabStop = false;
            this.gbxAddTip.Text = "Add a Tip";
            // 
            // rbtn0
            // 
            this.rbtn0.AutoSize = true;
            this.rbtn0.Location = new System.Drawing.Point(421, 41);
            this.rbtn0.Name = "rbtn0";
            this.rbtn0.Size = new System.Drawing.Size(78, 24);
            this.rbtn0.TabIndex = 4;
            this.rbtn0.TabStop = true;
            this.rbtn0.Text = "No Tip";
            this.rbtn0.UseVisualStyleBackColor = true;
            this.rbtn0.CheckedChanged += new System.EventHandler(this.rbtn0_CheckedChanged);
            // 
            // rbtn25
            // 
            this.rbtn25.AutoSize = true;
            this.rbtn25.Location = new System.Drawing.Point(326, 41);
            this.rbtn25.Name = "rbtn25";
            this.rbtn25.Size = new System.Drawing.Size(62, 24);
            this.rbtn25.TabIndex = 3;
            this.rbtn25.TabStop = true;
            this.rbtn25.Text = "25%";
            this.rbtn25.UseVisualStyleBackColor = true;
            this.rbtn25.CheckedChanged += new System.EventHandler(this.rbtn25_CheckedChanged);
            // 
            // rbtn20
            // 
            this.rbtn20.AutoSize = true;
            this.rbtn20.Location = new System.Drawing.Point(224, 41);
            this.rbtn20.Name = "rbtn20";
            this.rbtn20.Size = new System.Drawing.Size(62, 24);
            this.rbtn20.TabIndex = 2;
            this.rbtn20.TabStop = true;
            this.rbtn20.Text = "20%";
            this.rbtn20.UseVisualStyleBackColor = true;
            this.rbtn20.CheckedChanged += new System.EventHandler(this.rbtn20_CheckedChanged);
            // 
            // rbtn15
            // 
            this.rbtn15.AutoSize = true;
            this.rbtn15.Location = new System.Drawing.Point(126, 41);
            this.rbtn15.Name = "rbtn15";
            this.rbtn15.Size = new System.Drawing.Size(62, 24);
            this.rbtn15.TabIndex = 1;
            this.rbtn15.TabStop = true;
            this.rbtn15.Text = "15%";
            this.rbtn15.UseVisualStyleBackColor = true;
            this.rbtn15.CheckedChanged += new System.EventHandler(this.rbtn15_CheckedChanged);
            // 
            // rbtn10
            // 
            this.rbtn10.AutoSize = true;
            this.rbtn10.Location = new System.Drawing.Point(28, 41);
            this.rbtn10.Name = "rbtn10";
            this.rbtn10.Size = new System.Drawing.Size(62, 24);
            this.rbtn10.TabIndex = 0;
            this.rbtn10.TabStop = true;
            this.rbtn10.Text = "10%";
            this.rbtn10.UseVisualStyleBackColor = true;
            this.rbtn10.CheckedChanged += new System.EventHandler(this.rbtn10_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(1087, 105);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 37);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmBillAndPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 780);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxAddTip);
            this.Controls.Add(this.gbxPaymentMethod);
            this.Controls.Add(this.gbxItemizedBill);
            this.Controls.Add(this.picRestLogo);
            this.Controls.Add(this.lblRestaurantName);
            this.Name = "frmBillAndPayment";
            this.Text = "Itemized Bill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picRestLogo)).EndInit();
            this.gbxItemizedBill.ResumeLayout(false);
            this.gbxItemizedBill.PerformLayout();
            this.gbxPaymentMethod.ResumeLayout(false);
            this.gbxPaymentMethod.PerformLayout();
            this.gbxAddTip.ResumeLayout(false);
            this.gbxAddTip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRestLogo;
        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.GroupBox gbxItemizedBill;
        public System.Windows.Forms.ListBox lstItemizedBill; //made public
        private System.Windows.Forms.GroupBox gbxPaymentMethod;
        private System.Windows.Forms.Label lblPinNum;
        private System.Windows.Forms.TextBox txtPinNumber;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblPymtMthdPrompt;
        private System.Windows.Forms.RadioButton rbtnDebitCard;
        private System.Windows.Forms.RadioButton rbtnCreditCard;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.GroupBox gbxAddTip;
        public System.Windows.Forms.RadioButton rbtn25;
        public System.Windows.Forms.RadioButton rbtn20;
        public System.Windows.Forms.RadioButton rbtn15;
        public System.Windows.Forms.RadioButton rbtn10;
        private System.Windows.Forms.Button btnPayBill;
        public System.Windows.Forms.RadioButton rbtn0;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbxGrandTotal;
        private System.Windows.Forms.Label lblGrandTotal;
        public System.Windows.Forms.TextBox tbxTip;
        private System.Windows.Forms.Label lblTip;
        public System.Windows.Forms.TextBox tbxTax;
        private System.Windows.Forms.Label lblTax;
        public System.Windows.Forms.TextBox tbxSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        internal System.Windows.Forms.Button btnBack;
    }
}