
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
            this.lstItemizedBill = new System.Windows.Forms.ListBox();
            this.gbxPaymentMethod = new System.Windows.Forms.GroupBox();
            this.gbxAddTip = new System.Windows.Forms.GroupBox();
            this.rbtn10 = new System.Windows.Forms.RadioButton();
            this.rbtn15 = new System.Windows.Forms.RadioButton();
            this.rbtn20 = new System.Windows.Forms.RadioButton();
            this.rbtn25 = new System.Windows.Forms.RadioButton();
            this.rbtnDebitCard = new System.Windows.Forms.RadioButton();
            this.rbtnCreditCard = new System.Windows.Forms.RadioButton();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.lblPymtMthdPrompt = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.lblPinNum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPayBill = new System.Windows.Forms.Button();
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
            this.picRestLogo.Location = new System.Drawing.Point(35, 24);
            this.picRestLogo.Name = "picRestLogo";
            this.picRestLogo.Size = new System.Drawing.Size(64, 56);
            this.picRestLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRestLogo.TabIndex = 21;
            this.picRestLogo.TabStop = false;
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.AutoSize = true;
            this.lblRestaurantName.BackColor = System.Drawing.Color.White;
            this.lblRestaurantName.Font = new System.Drawing.Font("Papyrus", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurantName.Location = new System.Drawing.Point(105, 25);
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(376, 51);
            this.lblRestaurantName.TabIndex = 20;
            this.lblRestaurantName.Text = "Delicioso E-Ristorante";
            // 
            // gbxItemizedBill
            // 
            this.gbxItemizedBill.Controls.Add(this.lstItemizedBill);
            this.gbxItemizedBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxItemizedBill.Location = new System.Drawing.Point(35, 117);
            this.gbxItemizedBill.Name = "gbxItemizedBill";
            this.gbxItemizedBill.Size = new System.Drawing.Size(370, 565);
            this.gbxItemizedBill.TabIndex = 22;
            this.gbxItemizedBill.TabStop = false;
            this.gbxItemizedBill.Text = "Itemized Bill";
            // 
            // lstItemizedBill
            // 
            this.lstItemizedBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItemizedBill.FormattingEnabled = true;
            this.lstItemizedBill.ItemHeight = 20;
            this.lstItemizedBill.Location = new System.Drawing.Point(23, 41);
            this.lstItemizedBill.Name = "lstItemizedBill";
            this.lstItemizedBill.Size = new System.Drawing.Size(321, 484);
            this.lstItemizedBill.TabIndex = 0;
            // 
            // gbxPaymentMethod
            // 
            this.gbxPaymentMethod.Controls.Add(this.btnPayBill);
            this.gbxPaymentMethod.Controls.Add(this.lblPinNum);
            this.gbxPaymentMethod.Controls.Add(this.textBox1);
            this.gbxPaymentMethod.Controls.Add(this.lblExpDate);
            this.gbxPaymentMethod.Controls.Add(this.txtExpDate);
            this.gbxPaymentMethod.Controls.Add(this.lblCardNumber);
            this.gbxPaymentMethod.Controls.Add(this.txtCardNumber);
            this.gbxPaymentMethod.Controls.Add(this.lblPymtMthdPrompt);
            this.gbxPaymentMethod.Controls.Add(this.rbtnDebitCard);
            this.gbxPaymentMethod.Controls.Add(this.rbtnCreditCard);
            this.gbxPaymentMethod.Controls.Add(this.rbtnCash);
            this.gbxPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPaymentMethod.Location = new System.Drawing.Point(440, 263);
            this.gbxPaymentMethod.Name = "gbxPaymentMethod";
            this.gbxPaymentMethod.Size = new System.Drawing.Size(523, 419);
            this.gbxPaymentMethod.TabIndex = 23;
            this.gbxPaymentMethod.TabStop = false;
            this.gbxPaymentMethod.Text = "Method of Payment";
            // 
            // gbxAddTip
            // 
            this.gbxAddTip.Controls.Add(this.rbtn25);
            this.gbxAddTip.Controls.Add(this.rbtn20);
            this.gbxAddTip.Controls.Add(this.rbtn15);
            this.gbxAddTip.Controls.Add(this.rbtn10);
            this.gbxAddTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddTip.Location = new System.Drawing.Point(440, 117);
            this.gbxAddTip.Name = "gbxAddTip";
            this.gbxAddTip.Size = new System.Drawing.Size(523, 106);
            this.gbxAddTip.TabIndex = 24;
            this.gbxAddTip.TabStop = false;
            this.gbxAddTip.Text = "Add a Tip";
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
            // 
            // rbtn15
            // 
            this.rbtn15.AutoSize = true;
            this.rbtn15.Location = new System.Drawing.Point(158, 41);
            this.rbtn15.Name = "rbtn15";
            this.rbtn15.Size = new System.Drawing.Size(62, 24);
            this.rbtn15.TabIndex = 1;
            this.rbtn15.TabStop = true;
            this.rbtn15.Text = "15%";
            this.rbtn15.UseVisualStyleBackColor = true;
            // 
            // rbtn20
            // 
            this.rbtn20.AutoSize = true;
            this.rbtn20.Location = new System.Drawing.Point(290, 41);
            this.rbtn20.Name = "rbtn20";
            this.rbtn20.Size = new System.Drawing.Size(62, 24);
            this.rbtn20.TabIndex = 2;
            this.rbtn20.TabStop = true;
            this.rbtn20.Text = "20%";
            this.rbtn20.UseVisualStyleBackColor = true;
            // 
            // rbtn25
            // 
            this.rbtn25.AutoSize = true;
            this.rbtn25.Location = new System.Drawing.Point(431, 41);
            this.rbtn25.Name = "rbtn25";
            this.rbtn25.Size = new System.Drawing.Size(62, 24);
            this.rbtn25.TabIndex = 3;
            this.rbtn25.TabStop = true;
            this.rbtn25.Text = "25%";
            this.rbtn25.UseVisualStyleBackColor = true;
            // 
            // rbtnDebitCard
            // 
            this.rbtnDebitCard.AutoSize = true;
            this.rbtnDebitCard.Location = new System.Drawing.Point(365, 42);
            this.rbtnDebitCard.Name = "rbtnDebitCard";
            this.rbtnDebitCard.Size = new System.Drawing.Size(113, 24);
            this.rbtnDebitCard.TabIndex = 5;
            this.rbtnDebitCard.TabStop = true;
            this.rbtnDebitCard.Text = "Debit Card";
            this.rbtnDebitCard.UseVisualStyleBackColor = true;
            // 
            // rbtnCreditCard
            // 
            this.rbtnCreditCard.AutoSize = true;
            this.rbtnCreditCard.Location = new System.Drawing.Point(168, 42);
            this.rbtnCreditCard.Name = "rbtnCreditCard";
            this.rbtnCreditCard.Size = new System.Drawing.Size(118, 24);
            this.rbtnCreditCard.TabIndex = 4;
            this.rbtnCreditCard.TabStop = true;
            this.rbtnCreditCard.Text = "Credit Card";
            this.rbtnCreditCard.UseVisualStyleBackColor = true;
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.Location = new System.Drawing.Point(38, 42);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(68, 24);
            this.rbtnCash.TabIndex = 3;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "Cash";
            this.rbtnCash.UseVisualStyleBackColor = true;
            // 
            // lblPymtMthdPrompt
            // 
            this.lblPymtMthdPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPymtMthdPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPymtMthdPrompt.Location = new System.Drawing.Point(38, 94);
            this.lblPymtMthdPrompt.Name = "lblPymtMthdPrompt";
            this.lblPymtMthdPrompt.Size = new System.Drawing.Size(440, 33);
            this.lblPymtMthdPrompt.TabIndex = 6;
            this.lblPymtMthdPrompt.Text = "*if cash, ask them to wait for waiter, if card ask for card info";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(217, 151);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(223, 26);
            this.txtCardNumber.TabIndex = 7;
            this.txtCardNumber.Text = "1111 - 2222 - 3333 - 4444";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(87, 151);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(124, 20);
            this.lblCardNumber.TabIndex = 8;
            this.lblCardNumber.Text = "Card Number: ";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(73, 200);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(138, 20);
            this.lblExpDate.TabIndex = 10;
            this.lblExpDate.Text = "Expiration Date:";
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(217, 200);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(58, 26);
            this.txtExpDate.TabIndex = 9;
            this.txtExpDate.Text = "07/21";
            // 
            // lblPinNum
            // 
            this.lblPinNum.AutoSize = true;
            this.lblPinNum.Location = new System.Drawing.Point(87, 251);
            this.lblPinNum.Name = "lblPinNum";
            this.lblPinNum.Size = new System.Drawing.Size(111, 20);
            this.lblPinNum.TabIndex = 12;
            this.lblPinNum.Text = "Pin Number: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 26);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "1 - 2 - 3 - 4";
            // 
            // btnPayBill
            // 
            this.btnPayBill.Location = new System.Drawing.Point(158, 322);
            this.btnPayBill.Name = "btnPayBill";
            this.btnPayBill.Size = new System.Drawing.Size(207, 57);
            this.btnPayBill.TabIndex = 13;
            this.btnPayBill.Text = "Pay Bill";
            this.btnPayBill.UseVisualStyleBackColor = true;
            // 
            // frmBillAndPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.gbxAddTip);
            this.Controls.Add(this.gbxPaymentMethod);
            this.Controls.Add(this.gbxItemizedBill);
            this.Controls.Add(this.picRestLogo);
            this.Controls.Add(this.lblRestaurantName);
            this.Name = "frmBillAndPayment";
            this.Text = "Itemized Bill";
            ((System.ComponentModel.ISupportInitialize)(this.picRestLogo)).EndInit();
            this.gbxItemizedBill.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox lstItemizedBill;
        private System.Windows.Forms.GroupBox gbxPaymentMethod;
        private System.Windows.Forms.Label lblPinNum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblPymtMthdPrompt;
        private System.Windows.Forms.RadioButton rbtnDebitCard;
        private System.Windows.Forms.RadioButton rbtnCreditCard;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.GroupBox gbxAddTip;
        private System.Windows.Forms.RadioButton rbtn25;
        private System.Windows.Forms.RadioButton rbtn20;
        private System.Windows.Forms.RadioButton rbtn15;
        private System.Windows.Forms.RadioButton rbtn10;
        private System.Windows.Forms.Button btnPayBill;
    }
}