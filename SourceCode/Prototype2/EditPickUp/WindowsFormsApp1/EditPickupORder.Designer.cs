
namespace WindowsFormsApp1
{
    partial class EditPickupORder
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
            this.components = new System.ComponentModel.Container();
            this.pickupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.MaskedTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblpickupIDS = new System.Windows.Forms.Label();
            this.lblPickupID = new System.Windows.Forms.Label();
            this.lblUserName2 = new System.Windows.Forms.Label();
            this.lblPickupTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnDocument = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblPickUpAddress = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pickupBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pickupBindingSource
            // 
            this.pickupBindingSource.DataMember = "pickup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(225, 343);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "YYYY/MM/DD HH:MM:SS";
            // 
            // txtTime
            // 
            this.txtTime.Culture = new System.Globalization.CultureInfo("zh-HK");
            this.txtTime.Location = new System.Drawing.Point(230, 373);
            this.txtTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTime.Mask = "0000/00/00 00:00:00";
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(291, 50);
            this.txtTime.TabIndex = 21;
            this.txtTime.ValidatingType = typeof(System.DateTime);
            // 
            // btnSubmit
            // 
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSubmit.Location = new System.Drawing.Point(641, 253);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(186, 152);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblpickupIDS);
            this.groupBox1.Controls.Add(this.lblPickupID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.lblUserName2);
            this.groupBox1.Controls.Add(this.lblPickupTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.btnDocument);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.lblPickUpAddress);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(56, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1170, 601);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Pickup Order";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblpickupIDS
            // 
            this.lblpickupIDS.AutoSize = true;
            this.lblpickupIDS.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpickupIDS.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblpickupIDS.Location = new System.Drawing.Point(225, 125);
            this.lblpickupIDS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpickupIDS.Name = "lblpickupIDS";
            this.lblpickupIDS.Size = new System.Drawing.Size(95, 32);
            this.lblpickupIDS.TabIndex = 24;
            this.lblpickupIDS.Text = "ID here";
            // 
            // lblPickupID
            // 
            this.lblPickupID.AutoSize = true;
            this.lblPickupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickupID.ForeColor = System.Drawing.Color.Aqua;
            this.lblPickupID.Location = new System.Drawing.Point(40, 131);
            this.lblPickupID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPickupID.Name = "lblPickupID";
            this.lblPickupID.Size = new System.Drawing.Size(117, 25);
            this.lblPickupID.TabIndex = 23;
            this.lblPickupID.Text = "Pickup ID :";
            // 
            // lblUserName2
            // 
            this.lblUserName2.AutoSize = true;
            this.lblUserName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName2.ForeColor = System.Drawing.Color.Aqua;
            this.lblUserName2.Location = new System.Drawing.Point(40, 69);
            this.lblUserName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName2.Name = "lblUserName2";
            this.lblUserName2.Size = new System.Drawing.Size(145, 25);
            this.lblUserName2.TabIndex = 11;
            this.lblUserName2.Text = "Customer ID :";
            // 
            // lblPickupTime
            // 
            this.lblPickupTime.AutoSize = true;
            this.lblPickupTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickupTime.ForeColor = System.Drawing.Color.Aqua;
            this.lblPickupTime.Location = new System.Drawing.Point(41, 373);
            this.lblPickupTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPickupTime.Name = "lblPickupTime";
            this.lblPickupTime.Size = new System.Drawing.Size(144, 25);
            this.lblPickupTime.TabIndex = 18;
            this.lblPickupTime.Text = "Pickup Time :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(224, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name here";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(230, 200);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(291, 50);
            this.txtAddress.TabIndex = 15;
            // 
            // btnDocument
            // 
            this.btnDocument.AutoSize = true;
            this.btnDocument.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocument.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDocument.Location = new System.Drawing.Point(231, 284);
            this.btnDocument.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDocument.Name = "btnDocument";
            this.btnDocument.Size = new System.Drawing.Size(153, 36);
            this.btnDocument.TabIndex = 14;
            this.btnDocument.TabStop = true;
            this.btnDocument.Text = "Document";
            this.btnDocument.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.DarkOrange;
            this.radioButton1.Location = new System.Drawing.Point(432, 281);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(116, 36);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Freight";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lblPickUpAddress
            // 
            this.lblPickUpAddress.AutoSize = true;
            this.lblPickUpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickUpAddress.ForeColor = System.Drawing.Color.Aqua;
            this.lblPickUpAddress.Location = new System.Drawing.Point(40, 219);
            this.lblPickUpAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPickUpAddress.Name = "lblPickUpAddress";
            this.lblPickUpAddress.Size = new System.Drawing.Size(176, 25);
            this.lblPickUpAddress.TabIndex = 10;
            this.lblPickUpAddress.Text = "Pickup Address :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.Aqua;
            this.lblType.Location = new System.Drawing.Point(40, 292);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(153, 25);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Service Type :";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(990, -40);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 41);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // EditPickupORder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1372, 697);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditPickupORder";
            this.Text = "Edit Pickup Order";
            this.Load += new System.EventHandler(this.EditPickupORder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pickupBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource pickupBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtTime;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUserName2;
        private System.Windows.Forms.Label lblPickupTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RadioButton btnDocument;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblPickUpAddress;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnClose;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblpickupIDS;
        private System.Windows.Forms.Label lblPickupID;
    }
}