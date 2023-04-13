
namespace ProcessShipment
{
    partial class ProcessShipmentStaff
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
            this.txtBoxAirwayBillID = new System.Windows.Forms.TextBox();
            this.txtBoxShipmentStatus = new System.Windows.Forms.TextBox();
            this.btnAirwayBill = new System.Windows.Forms.Button();
            this.lblAirwayBillID = new System.Windows.Forms.Label();
            this.lblShipmentStatus = new System.Windows.Forms.Label();
            this.btnUpdateShipmentStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxAirwayBillID
            // 
            this.txtBoxAirwayBillID.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtBoxAirwayBillID.Location = new System.Drawing.Point(426, 145);
            this.txtBoxAirwayBillID.Name = "txtBoxAirwayBillID";
            this.txtBoxAirwayBillID.Size = new System.Drawing.Size(264, 34);
            this.txtBoxAirwayBillID.TabIndex = 1;
            // 
            // txtBoxShipmentStatus
            // 
            this.txtBoxShipmentStatus.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtBoxShipmentStatus.Location = new System.Drawing.Point(426, 220);
            this.txtBoxShipmentStatus.Multiline = true;
            this.txtBoxShipmentStatus.Name = "txtBoxShipmentStatus";
            this.txtBoxShipmentStatus.Size = new System.Drawing.Size(412, 222);
            this.txtBoxShipmentStatus.TabIndex = 2;
            this.txtBoxShipmentStatus.TextChanged += new System.EventHandler(this.txtBoxShipmentStatus_TextChanged);
            // 
            // btnAirwayBill
            // 
            this.btnAirwayBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAirwayBill.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAirwayBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAirwayBill.Location = new System.Drawing.Point(714, 135);
            this.btnAirwayBill.Name = "btnAirwayBill";
            this.btnAirwayBill.Size = new System.Drawing.Size(122, 43);
            this.btnAirwayBill.TabIndex = 3;
            this.btnAirwayBill.Text = "Go!";
            this.btnAirwayBill.UseVisualStyleBackColor = false;
            this.btnAirwayBill.Click += new System.EventHandler(this.btnAirwayBill_Click);
            // 
            // lblAirwayBillID
            // 
            this.lblAirwayBillID.AutoSize = true;
            this.lblAirwayBillID.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAirwayBillID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAirwayBillID.Location = new System.Drawing.Point(206, 145);
            this.lblAirwayBillID.Name = "lblAirwayBillID";
            this.lblAirwayBillID.Size = new System.Drawing.Size(199, 28);
            this.lblAirwayBillID.TabIndex = 4;
            this.lblAirwayBillID.Text = "Airway Bill Number";
            // 
            // lblShipmentStatus
            // 
            this.lblShipmentStatus.AutoSize = true;
            this.lblShipmentStatus.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblShipmentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblShipmentStatus.Location = new System.Drawing.Point(206, 220);
            this.lblShipmentStatus.Name = "lblShipmentStatus";
            this.lblShipmentStatus.Size = new System.Drawing.Size(166, 28);
            this.lblShipmentStatus.TabIndex = 5;
            this.lblShipmentStatus.Text = "Shipment Status";
            // 
            // btnUpdateShipmentStatus
            // 
            this.btnUpdateShipmentStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUpdateShipmentStatus.Enabled = false;
            this.btnUpdateShipmentStatus.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateShipmentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUpdateShipmentStatus.Location = new System.Drawing.Point(424, 468);
            this.btnUpdateShipmentStatus.Name = "btnUpdateShipmentStatus";
            this.btnUpdateShipmentStatus.Size = new System.Drawing.Size(412, 60);
            this.btnUpdateShipmentStatus.TabIndex = 6;
            this.btnUpdateShipmentStatus.Text = "Update Status and Alert Receiver";
            this.btnUpdateShipmentStatus.UseVisualStyleBackColor = false;
            this.btnUpdateShipmentStatus.Click += new System.EventHandler(this.btnUpdateShipmentStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(212, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 70);
            this.label1.TabIndex = 7;
            this.label1.Text = "Process Shipment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(860, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 80);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "x";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProcessShipment.Properties.Resources.delivery_128px;
            this.pictureBox2.Location = new System.Drawing.Point(708, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // ProcessShipmentStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateShipmentStatus);
            this.Controls.Add(this.lblShipmentStatus);
            this.Controls.Add(this.lblAirwayBillID);
            this.Controls.Add(this.btnAirwayBill);
            this.Controls.Add(this.txtBoxShipmentStatus);
            this.Controls.Add(this.txtBoxAirwayBillID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcessShipmentStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ProcessShipmentStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxAirwayBillID;
        private System.Windows.Forms.TextBox txtBoxShipmentStatus;
        private System.Windows.Forms.Button btnAirwayBill;
        private System.Windows.Forms.Label lblAirwayBillID;
        private System.Windows.Forms.Label lblShipmentStatus;
        private System.Windows.Forms.Button btnUpdateShipmentStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

