
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstPaymentMethod = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstTip = new System.Windows.Forms.ListBox();
            this.btnPayBill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picRestLogo)).BeginInit();
            this.gbxItemizedBill.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picRestLogo
            // 
            this.picRestLogo.Image = ((System.Drawing.Image)(resources.GetObject("picRestLogo.Image")));
            this.picRestLogo.InitialImage = null;
            this.picRestLogo.Location = new System.Drawing.Point(41, 14);
            this.picRestLogo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.picRestLogo.Name = "picRestLogo";
            this.picRestLogo.Size = new System.Drawing.Size(97, 86);
            this.picRestLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRestLogo.TabIndex = 19;
            this.picRestLogo.TabStop = false;
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.AutoSize = true;
            this.lblRestaurantName.BackColor = System.Drawing.Color.White;
            this.lblRestaurantName.Font = new System.Drawing.Font("Papyrus", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurantName.Location = new System.Drawing.Point(148, 29);
            this.lblRestaurantName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(376, 51);
            this.lblRestaurantName.TabIndex = 18;
            this.lblRestaurantName.Text = "Delicioso E-Ristorante";
            // 
            // gbxItemizedBill
            // 
            this.gbxItemizedBill.Controls.Add(this.lstItemizedBill);
            this.gbxItemizedBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxItemizedBill.Location = new System.Drawing.Point(41, 133);
            this.gbxItemizedBill.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxItemizedBill.Name = "gbxItemizedBill";
            this.gbxItemizedBill.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxItemizedBill.Size = new System.Drawing.Size(483, 558);
            this.gbxItemizedBill.TabIndex = 20;
            this.gbxItemizedBill.TabStop = false;
            this.gbxItemizedBill.Text = "Itemized Bill";
            // 
            // lstItemizedBill
            // 
            this.lstItemizedBill.FormattingEnabled = true;
            this.lstItemizedBill.ItemHeight = 20;
            this.lstItemizedBill.Location = new System.Drawing.Point(32, 50);
            this.lstItemizedBill.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lstItemizedBill.Name = "lstItemizedBill";
            this.lstItemizedBill.Size = new System.Drawing.Size(413, 464);
            this.lstItemizedBill.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstPaymentMethod);
            this.groupBox1.Location = new System.Drawing.Point(546, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 161);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Method Of Payment";
            // 
            // lstPaymentMethod
            // 
            this.lstPaymentMethod.FormattingEnabled = true;
            this.lstPaymentMethod.ItemHeight = 20;
            this.lstPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Debit Card",
            "Credit Card"});
            this.lstPaymentMethod.Location = new System.Drawing.Point(36, 52);
            this.lstPaymentMethod.Name = "lstPaymentMethod";
            this.lstPaymentMethod.Size = new System.Drawing.Size(190, 84);
            this.lstPaymentMethod.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstTip);
            this.groupBox2.Location = new System.Drawing.Point(613, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 156);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add a Tip";
            // 
            // lstTip
            // 
            this.lstTip.FormattingEnabled = true;
            this.lstTip.ItemHeight = 20;
            this.lstTip.Items.AddRange(new object[] {
            "10%",
            "15%",
            "20%",
            "25%"});
            this.lstTip.Location = new System.Drawing.Point(36, 37);
            this.lstTip.Name = "lstTip";
            this.lstTip.Size = new System.Drawing.Size(57, 84);
            this.lstTip.TabIndex = 0;
            // 
            // btnPayBill
            // 
            this.btnPayBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPayBill.Location = new System.Drawing.Point(613, 536);
            this.btnPayBill.Name = "btnPayBill";
            this.btnPayBill.Size = new System.Drawing.Size(128, 79);
            this.btnPayBill.TabIndex = 27;
            this.btnPayBill.Text = "Pay Bill";
            this.btnPayBill.UseVisualStyleBackColor = false;
            // 
            // frmBillAndPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 715);
            this.Controls.Add(this.btnPayBill);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxItemizedBill);
            this.Controls.Add(this.picRestLogo);
            this.Controls.Add(this.lblRestaurantName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmBillAndPayment";
            this.Text = "Itemized Bill";
            ((System.ComponentModel.ISupportInitialize)(this.picRestLogo)).EndInit();
            this.gbxItemizedBill.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRestLogo;
        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.GroupBox gbxItemizedBill;
        private System.Windows.Forms.ListBox lstItemizedBill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstPaymentMethod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstTip;
        private System.Windows.Forms.Button btnPayBill;
    }
}