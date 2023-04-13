
namespace managePayment
{
    partial class payForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payForm));
            this.lblType = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.grpPaymentMethod = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdoCreditCard = new System.Windows.Forms.RadioButton();
            this.rdoCheque = new System.Windows.Forms.RadioButton();
            this.txtCreditCard = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.lblCVV = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.grpCreditCard = new System.Windows.Forms.GroupBox();
            this.lblCardSupport = new System.Windows.Forms.Label();
            this.grpCheque = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTotalAmout = new System.Windows.Forms.TextBox();
            this.txtPaymentType = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpPaymentMethod.SuspendLayout();
            this.grpCreditCard.SuspendLayout();
            this.grpCheque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.Aqua;
            this.lblType.Location = new System.Drawing.Point(128, 73);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(54, 25);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Aqua;
            this.lblTotalAmount.Location = new System.Drawing.Point(128, 165);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(129, 25);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // grpPaymentMethod
            // 
            this.grpPaymentMethod.Controls.Add(this.radioButton1);
            this.grpPaymentMethod.Controls.Add(this.rdoCreditCard);
            this.grpPaymentMethod.Controls.Add(this.rdoCheque);
            this.grpPaymentMethod.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPaymentMethod.ForeColor = System.Drawing.Color.DarkOrange;
            this.grpPaymentMethod.Location = new System.Drawing.Point(686, 43);
            this.grpPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPaymentMethod.Name = "grpPaymentMethod";
            this.grpPaymentMethod.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPaymentMethod.Size = new System.Drawing.Size(300, 260);
            this.grpPaymentMethod.TabIndex = 2;
            this.grpPaymentMethod.TabStop = false;
            this.grpPaymentMethod.Text = "Payment Method";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Aqua;
            this.radioButton1.Location = new System.Drawing.Point(56, 178);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 29);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "E-payment";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoCreditCard
            // 
            this.rdoCreditCard.AutoSize = true;
            this.rdoCreditCard.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCreditCard.ForeColor = System.Drawing.Color.Aqua;
            this.rdoCreditCard.Location = new System.Drawing.Point(56, 55);
            this.rdoCreditCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoCreditCard.Name = "rdoCreditCard";
            this.rdoCreditCard.Size = new System.Drawing.Size(209, 29);
            this.rdoCreditCard.TabIndex = 0;
            this.rdoCreditCard.TabStop = true;
            this.rdoCreditCard.Text = "Credit Card Payment";
            this.rdoCreditCard.UseVisualStyleBackColor = true;
            // 
            // rdoCheque
            // 
            this.rdoCheque.AutoSize = true;
            this.rdoCheque.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCheque.ForeColor = System.Drawing.Color.Aqua;
            this.rdoCheque.Location = new System.Drawing.Point(56, 115);
            this.rdoCheque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoCheque.Name = "rdoCheque";
            this.rdoCheque.Size = new System.Drawing.Size(178, 29);
            this.rdoCheque.TabIndex = 0;
            this.rdoCheque.TabStop = true;
            this.rdoCheque.Text = "Cheque Payment";
            this.rdoCheque.UseVisualStyleBackColor = true;
            this.rdoCheque.CheckedChanged += new System.EventHandler(this.rdoCheque_CheckedChanged);
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCreditCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.txtCreditCard.Location = new System.Drawing.Point(218, 75);
            this.txtCreditCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCreditCard.MaxLength = 16;
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Size = new System.Drawing.Size(253, 29);
            this.txtCreditCard.TabIndex = 3;
            // 
            // txtCVV
            // 
            this.txtCVV.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCVV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.txtCVV.Location = new System.Drawing.Point(218, 148);
            this.txtCVV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCVV.MaxLength = 3;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(253, 29);
            this.txtCVV.TabIndex = 4;
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCard.ForeColor = System.Drawing.Color.Aqua;
            this.lblCreditCard.Location = new System.Drawing.Point(30, 80);
            this.lblCreditCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(184, 25);
            this.lblCreditCard.TabIndex = 5;
            this.lblCreditCard.Text = "Credit Card Number:";
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVV.ForeColor = System.Drawing.Color.Aqua;
            this.lblCVV.Location = new System.Drawing.Point(30, 148);
            this.lblCVV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(99, 25);
            this.lblCVV.TabIndex = 6;
            this.lblCVV.Text = "CVV Code:";
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUpload.Location = new System.Drawing.Point(123, 72);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(176, 38);
            this.btnUpload.TabIndex = 7;
            this.btnUpload.Text = "Upload Cheque";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.txtFilePath.Location = new System.Drawing.Point(123, 153);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(422, 29);
            this.txtFilePath.TabIndex = 8;
            // 
            // grpCreditCard
            // 
            this.grpCreditCard.Controls.Add(this.pictureBox1);
            this.grpCreditCard.Controls.Add(this.lblCardSupport);
            this.grpCreditCard.Controls.Add(this.lblCVV);
            this.grpCreditCard.Controls.Add(this.lblCreditCard);
            this.grpCreditCard.Controls.Add(this.txtCVV);
            this.grpCreditCard.Controls.Add(this.txtCreditCard);
            this.grpCreditCard.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCreditCard.ForeColor = System.Drawing.Color.DarkOrange;
            this.grpCreditCard.Location = new System.Drawing.Point(57, 378);
            this.grpCreditCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCreditCard.Name = "grpCreditCard";
            this.grpCreditCard.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCreditCard.Size = new System.Drawing.Size(495, 325);
            this.grpCreditCard.TabIndex = 9;
            this.grpCreditCard.TabStop = false;
            this.grpCreditCard.Text = "Credit Card Payment";
            // 
            // lblCardSupport
            // 
            this.lblCardSupport.AutoSize = true;
            this.lblCardSupport.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardSupport.ForeColor = System.Drawing.Color.Aqua;
            this.lblCardSupport.Location = new System.Drawing.Point(9, 277);
            this.lblCardSupport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardSupport.Name = "lblCardSupport";
            this.lblCardSupport.Size = new System.Drawing.Size(287, 25);
            this.lblCardSupport.TabIndex = 7;
            this.lblCardSupport.Text = "Visa / Master Card are supported";
            // 
            // grpCheque
            // 
            this.grpCheque.Controls.Add(this.label1);
            this.grpCheque.Controls.Add(this.txtFilePath);
            this.grpCheque.Controls.Add(this.btnUpload);
            this.grpCheque.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCheque.ForeColor = System.Drawing.Color.DarkOrange;
            this.grpCheque.Location = new System.Drawing.Point(578, 373);
            this.grpCheque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCheque.Name = "grpCheque";
            this.grpCheque.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCheque.Size = new System.Drawing.Size(591, 330);
            this.grpCheque.TabIndex = 10;
            this.grpCheque.TabStop = false;
            this.grpCheque.Text = "Cheque Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(22, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "File path:";
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPay.Location = new System.Drawing.Point(417, 758);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(112, 38);
            this.btnPay.TabIndex = 11;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClear.Location = new System.Drawing.Point(656, 758);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 38);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtTotalAmout
            // 
            this.txtTotalAmout.Enabled = false;
            this.txtTotalAmout.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalAmout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.txtTotalAmout.Location = new System.Drawing.Point(274, 160);
            this.txtTotalAmout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalAmout.Name = "txtTotalAmout";
            this.txtTotalAmout.Size = new System.Drawing.Size(250, 29);
            this.txtTotalAmout.TabIndex = 13;
            this.txtTotalAmout.Text = " ";
            this.txtTotalAmout.TextChanged += new System.EventHandler(this.txtTotalAmout_TextChanged);
            // 
            // txtPaymentType
            // 
            this.txtPaymentType.Enabled = false;
            this.txtPaymentType.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPaymentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.txtPaymentType.Location = new System.Drawing.Point(274, 68);
            this.txtPaymentType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPaymentType.Name = "txtPaymentType";
            this.txtPaymentType.Size = new System.Drawing.Size(250, 29);
            this.txtPaymentType.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(304, 218);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // payForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1200, 867);
            this.Controls.Add(this.txtPaymentType);
            this.Controls.Add(this.txtTotalAmout);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.grpCheque);
            this.Controls.Add(this.grpCreditCard);
            this.Controls.Add(this.grpPaymentMethod);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "payForm";
            this.ShowIcon = false;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.individualPayment_Load);
            this.grpPaymentMethod.ResumeLayout(false);
            this.grpPaymentMethod.PerformLayout();
            this.grpCreditCard.ResumeLayout(false);
            this.grpCreditCard.PerformLayout();
            this.grpCheque.ResumeLayout(false);
            this.grpCheque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.GroupBox grpPaymentMethod;
        private System.Windows.Forms.RadioButton rdoCreditCard;
        private System.Windows.Forms.RadioButton rdoCheque;
        private System.Windows.Forms.TextBox txtCreditCard;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label lblCreditCard;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.GroupBox grpCheque;
        private System.Windows.Forms.GroupBox grpCreditCard;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtTotalAmout;
        private System.Windows.Forms.TextBox txtPaymentType;
        private System.Windows.Forms.Label lblCardSupport;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}