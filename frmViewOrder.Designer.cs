
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
            this.lblEditMenuPrompt = new System.Windows.Forms.Label();
            this.lstItemsOrdered = new System.Windows.Forms.ListBox();
            this.btnOrderMore = new System.Windows.Forms.Button();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.btnRequestCheck = new System.Windows.Forms.Button();
            this.lblReqChkPrompt = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblOrderMorePrompt = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblSubmitOrderPrompt = new System.Windows.Forms.Label();
            this.picItaly = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstTotalItemsOrdered = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRestLogo)).BeginInit();
            this.gbxYourOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItaly)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picRestLogo
            // 
            this.picRestLogo.Image = ((System.Drawing.Image)(resources.GetObject("picRestLogo.Image")));
            this.picRestLogo.InitialImage = null;
            this.picRestLogo.Location = new System.Drawing.Point(12, 12);
            this.picRestLogo.Name = "picRestLogo";
            this.picRestLogo.Size = new System.Drawing.Size(122, 113);
            this.picRestLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRestLogo.TabIndex = 19;
            this.picRestLogo.TabStop = false;
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.BackColor = System.Drawing.Color.Transparent;
            this.lblRestaurantName.Font = new System.Drawing.Font("Papyrus", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurantName.Location = new System.Drawing.Point(160, 34);
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(579, 80);
            this.lblRestaurantName.TabIndex = 18;
            this.lblRestaurantName.Text = "Delicioso E-Ristorante";
            // 
            // gbxYourOrder
            // 
            this.gbxYourOrder.BackColor = System.Drawing.Color.White;
            this.gbxYourOrder.Controls.Add(this.lblEditMenuPrompt);
            this.gbxYourOrder.Controls.Add(this.lstItemsOrdered);
            this.gbxYourOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxYourOrder.Location = new System.Drawing.Point(46, 160);
            this.gbxYourOrder.Name = "gbxYourOrder";
            this.gbxYourOrder.Size = new System.Drawing.Size(439, 506);
            this.gbxYourOrder.TabIndex = 20;
            this.gbxYourOrder.TabStop = false;
            this.gbxYourOrder.Text = "Your Current Order";
            // 
            // lblEditMenuPrompt
            // 
            this.lblEditMenuPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditMenuPrompt.Location = new System.Drawing.Point(21, 469);
            this.lblEditMenuPrompt.Name = "lblEditMenuPrompt";
            this.lblEditMenuPrompt.Size = new System.Drawing.Size(400, 31);
            this.lblEditMenuPrompt.TabIndex = 1;
            this.lblEditMenuPrompt.Text = "*You can edit your order by returning to the Main Menu";
            // 
            // lstItemsOrdered
            // 
            this.lstItemsOrdered.FormattingEnabled = true;
            this.lstItemsOrdered.ItemHeight = 20;
            this.lstItemsOrdered.Location = new System.Drawing.Point(21, 37);
            this.lstItemsOrdered.Name = "lstItemsOrdered";
            this.lstItemsOrdered.Size = new System.Drawing.Size(400, 424);
            this.lstItemsOrdered.TabIndex = 0;
            // 
            // btnOrderMore
            // 
            this.btnOrderMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOrderMore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderMore.ForeColor = System.Drawing.Color.Black;
            this.btnOrderMore.Location = new System.Drawing.Point(1180, 100);
            this.btnOrderMore.Name = "btnOrderMore";
            this.btnOrderMore.Size = new System.Drawing.Size(118, 37);
            this.btnOrderMore.TabIndex = 23;
            this.btnOrderMore.Text = "Main Menu";
            this.btnOrderMore.UseVisualStyleBackColor = false;
            this.btnOrderMore.Click += new System.EventHandler(this.btnOrderMore_Click);
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSubmitOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitOrder.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitOrder.Location = new System.Drawing.Point(877, 78);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(196, 59);
            this.btnSubmitOrder.TabIndex = 22;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = false;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // btnRequestCheck
            // 
            this.btnRequestCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestCheck.Location = new System.Drawing.Point(522, 564);
            this.btnRequestCheck.Name = "btnRequestCheck";
            this.btnRequestCheck.Size = new System.Drawing.Size(298, 57);
            this.btnRequestCheck.TabIndex = 25;
            this.btnRequestCheck.Text = "Request Check";
            this.btnRequestCheck.UseVisualStyleBackColor = true;
            this.btnRequestCheck.Click += new System.EventHandler(this.btnRequestCheck_Click);
            // 
            // lblReqChkPrompt
            // 
            this.lblReqChkPrompt.AutoSize = true;
            this.lblReqChkPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblReqChkPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqChkPrompt.Location = new System.Drawing.Point(505, 629);
            this.lblReqChkPrompt.Name = "lblReqChkPrompt";
            this.lblReqChkPrompt.Size = new System.Drawing.Size(356, 20);
            this.lblReqChkPrompt.TabIndex = 26;
            this.lblReqChkPrompt.Text = "All done eating? Click here to request your check.";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.Location = new System.Drawing.Point(625, 160);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(99, 20);
            this.lblDisplayName.TabIndex = 27;
            this.lblDisplayName.Text = "Order Name:";
            // 
            // lblOrderMorePrompt
            // 
            this.lblOrderMorePrompt.AutoSize = true;
            this.lblOrderMorePrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderMorePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderMorePrompt.Location = new System.Drawing.Point(1176, 69);
            this.lblOrderMorePrompt.Name = "lblOrderMorePrompt";
            this.lblOrderMorePrompt.Size = new System.Drawing.Size(137, 20);
            this.lblOrderMorePrompt.TabIndex = 28;
            this.lblOrderMorePrompt.Text = "Want more Food?";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(613, 197);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(126, 31);
            this.txtCustomerName.TabIndex = 29;
            this.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSubmitOrderPrompt
            // 
            this.lblSubmitOrderPrompt.AutoSize = true;
            this.lblSubmitOrderPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblSubmitOrderPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitOrderPrompt.Location = new System.Drawing.Point(923, 55);
            this.lblSubmitOrderPrompt.Name = "lblSubmitOrderPrompt";
            this.lblSubmitOrderPrompt.Size = new System.Drawing.Size(109, 20);
            this.lblSubmitOrderPrompt.TabIndex = 30;
            this.lblSubmitOrderPrompt.Text = "Ready to eat?";
            // 
            // picItaly
            // 
            this.picItaly.Image = ((System.Drawing.Image)(resources.GetObject("picItaly.Image")));
            this.picItaly.Location = new System.Drawing.Point(522, 237);
            this.picItaly.Name = "picItaly";
            this.picItaly.Size = new System.Drawing.Size(298, 273);
            this.picItaly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItaly.TabIndex = 31;
            this.picItaly.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstTotalItemsOrdered);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(877, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 506);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Complete Order";
            // 
            // lstTotalItemsOrdered
            // 
            this.lstTotalItemsOrdered.FormattingEnabled = true;
            this.lstTotalItemsOrdered.ItemHeight = 20;
            this.lstTotalItemsOrdered.Location = new System.Drawing.Point(21, 34);
            this.lstTotalItemsOrdered.Name = "lstTotalItemsOrdered";
            this.lstTotalItemsOrdered.Size = new System.Drawing.Size(400, 444);
            this.lstTotalItemsOrdered.TabIndex = 0;
            // 
            // frmViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1328, 749);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picItaly);
            this.Controls.Add(this.lblSubmitOrderPrompt);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblOrderMorePrompt);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.lblReqChkPrompt);
            this.Controls.Add(this.btnRequestCheck);
            this.Controls.Add(this.btnOrderMore);
            this.Controls.Add(this.btnSubmitOrder);
            this.Controls.Add(this.gbxYourOrder);
            this.Controls.Add(this.picRestLogo);
            this.Controls.Add(this.lblRestaurantName);
            this.Name = "frmViewOrder";
            this.Text = "View My Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picRestLogo)).EndInit();
            this.gbxYourOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picItaly)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picRestLogo;
        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.GroupBox gbxYourOrder;
        public System.Windows.Forms.ListBox lstItemsOrdered; //made this public
        private System.Windows.Forms.Button btnOrderMore;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Button btnRequestCheck;
        private System.Windows.Forms.Label lblReqChkPrompt;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label lblOrderMorePrompt;
        public System.Windows.Forms.TextBox txtCustomerName;  // made public // Lee
        private System.Windows.Forms.Label lblSubmitOrderPrompt;
        private System.Windows.Forms.PictureBox picItaly;
        private System.Windows.Forms.Label lblEditMenuPrompt;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListBox lstTotalItemsOrdered;
    }
}