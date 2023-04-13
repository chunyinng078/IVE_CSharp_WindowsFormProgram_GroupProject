
namespace QuickSearch
{
    partial class QuickSearch
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
            this.lblQuickSearch = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblStaffDept = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffDept = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuickSearch
            // 
            this.lblQuickSearch.AutoSize = true;
            this.lblQuickSearch.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickSearch.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblQuickSearch.Location = new System.Drawing.Point(64, 65);
            this.lblQuickSearch.Name = "lblQuickSearch";
            this.lblQuickSearch.Size = new System.Drawing.Size(642, 65);
            this.lblQuickSearch.TabIndex = 0;
            this.lblQuickSearch.Text = "Staff Directory Quick Search";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStaffName.ForeColor = System.Drawing.Color.Aqua;
            this.lblStaffName.Location = new System.Drawing.Point(81, 184);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(380, 45);
            this.lblStaffName.TabIndex = 1;
            this.lblStaffName.Text = "Please enter Staff Name:";
            // 
            // lblStaffDept
            // 
            this.lblStaffDept.AutoSize = true;
            this.lblStaffDept.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStaffDept.ForeColor = System.Drawing.Color.Aqua;
            this.lblStaffDept.Location = new System.Drawing.Point(81, 270);
            this.lblStaffDept.Name = "lblStaffDept";
            this.lblStaffDept.Size = new System.Drawing.Size(469, 45);
            this.lblStaffDept.TabIndex = 2;
            this.lblStaffDept.Text = "Please enter Staff Department:";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(586, 201);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(292, 26);
            this.txtStaffName.TabIndex = 3;
            this.txtStaffName.Click += new System.EventHandler(this.btnSearch_Click);
            this.txtStaffName.TextChanged += new System.EventHandler(this.txtStaffName_TextChanged);
            // 
            // txtStaffDept
            // 
            this.txtStaffDept.Location = new System.Drawing.Point(586, 287);
            this.txtStaffDept.Name = "txtStaffDept";
            this.txtStaffDept.Size = new System.Drawing.Size(292, 26);
            this.txtStaffDept.TabIndex = 4;
            this.txtStaffDept.TextChanged += new System.EventHandler(this.txtStaffDept_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 438);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1036, 360);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSearch.Location = new System.Drawing.Point(916, 173);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(208, 75);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Start Searching!";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClear.Location = new System.Drawing.Point(916, 270);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(208, 75);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Search";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // QuickSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1182, 865);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtStaffDept);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.lblStaffDept);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.lblQuickSearch);
            this.Name = "QuickSearch";
            this.Text = "Quick Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuickSearch;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblStaffDept;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffDept;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
    }
}

