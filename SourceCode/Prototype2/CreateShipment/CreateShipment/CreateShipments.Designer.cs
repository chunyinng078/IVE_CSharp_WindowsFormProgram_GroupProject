
namespace CreateShipment
{
    partial class CreateShipments
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
            this.lblDocument = new System.Windows.Forms.Label();
            this.lblPackage = new System.Windows.Forms.Label();
            this.btnDocument = new System.Windows.Forms.Button();
            this.btnPackage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pannelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDocument
            // 
            this.lblDocument.AutoSize = true;
            this.lblDocument.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDocument.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblDocument.Location = new System.Drawing.Point(29, 190);
            this.lblDocument.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(368, 38);
            this.lblDocument.TabIndex = 0;
            this.lblDocument.Text = "Create Document Shipment";
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPackage.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblPackage.Location = new System.Drawing.Point(40, 677);
            this.lblPackage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(341, 38);
            this.lblPackage.TabIndex = 1;
            this.lblPackage.Text = "Create Package Shipment";
            // 
            // btnDocument
            // 
            this.btnDocument.FlatAppearance.BorderSize = 10;
            this.btnDocument.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnDocument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDocument.Location = new System.Drawing.Point(118, 262);
            this.btnDocument.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDocument.Name = "btnDocument";
            this.btnDocument.Size = new System.Drawing.Size(180, 165);
            this.btnDocument.TabIndex = 2;
            this.btnDocument.Text = "Create";
            this.btnDocument.UseVisualStyleBackColor = true;
            this.btnDocument.Click += new System.EventHandler(this.btnDocument_Click);
            // 
            // btnPackage
            // 
            this.btnPackage.FlatAppearance.BorderSize = 10;
            this.btnPackage.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnPackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPackage.Location = new System.Drawing.Point(112, 766);
            this.btnPackage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPackage.Name = "btnPackage";
            this.btnPackage.Size = new System.Drawing.Size(180, 165);
            this.btnPackage.TabIndex = 3;
            this.btnPackage.Text = "Create";
            this.btnPackage.UseVisualStyleBackColor = true;
            this.btnPackage.Click += new System.EventHandler(this.btnPackage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblDocument);
            this.panel1.Controls.Add(this.btnPackage);
            this.panel1.Controls.Add(this.btnDocument);
            this.panel1.Controls.Add(this.lblPackage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 1087);
            this.panel1.TabIndex = 4;
            // 
            // pannelChildForm
            // 
            this.pannelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pannelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pannelChildForm.Font = new System.Drawing.Font("PMingLiU", 10.75F, System.Drawing.FontStyle.Bold);
            this.pannelChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pannelChildForm.Location = new System.Drawing.Point(405, 0);
            this.pannelChildForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pannelChildForm.Name = "pannelChildForm";
            this.pannelChildForm.Size = new System.Drawing.Size(1068, 1087);
            this.pannelChildForm.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::CreateShipment.Properties.Resources.package_search_500px;
            this.pictureBox2.Location = new System.Drawing.Point(106, 506);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 157);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::CreateShipment.Properties.Resources.send_letter_500px;
            this.pictureBox1.Location = new System.Drawing.Point(112, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // CreateShipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 1087);
            this.Controls.Add(this.pannelChildForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateShipments";
            this.ShowIcon = false;
            this.Text = "Create Shipment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Button btnDocument;
        private System.Windows.Forms.Button btnPackage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pannelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

