
namespace WindowsFormsApp1
{
    partial class EditPickUp
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
            this.btnClose = new System.Windows.Forms.Button();
            this.edeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edeDataSet = new WindowsFormsApp1.edeDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pickupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickupDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickupcusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickupaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edeDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edeDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(694, -64);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 27);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // edeDataSetBindingSource
            // 
            this.edeDataSetBindingSource.DataSource = this.edeDataSet;
            this.edeDataSetBindingSource.Position = 0;
            // 
            // edeDataSet
            // 
            this.edeDataSet.DataSetName = "edeDataSet";
            this.edeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pickupIDDataGridViewTextBoxColumn,
            this.pickupDateDataGridViewTextBoxColumn,
            this.servicesDataGridViewTextBoxColumn,
            this.pickupcusIDDataGridViewTextBoxColumn,
            this.pickupaddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "pickup";
            this.dataGridView1.DataSource = this.edeDataSetBindingSource1;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridView1.Location = new System.Drawing.Point(199, 118);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(668, 284);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // pickupIDDataGridViewTextBoxColumn
            // 
            this.pickupIDDataGridViewTextBoxColumn.DataPropertyName = "pickupID";
            this.pickupIDDataGridViewTextBoxColumn.HeaderText = "pickupID";
            this.pickupIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pickupIDDataGridViewTextBoxColumn.Name = "pickupIDDataGridViewTextBoxColumn";
            this.pickupIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pickupIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pickupDateDataGridViewTextBoxColumn
            // 
            this.pickupDateDataGridViewTextBoxColumn.DataPropertyName = "pickupDate";
            this.pickupDateDataGridViewTextBoxColumn.HeaderText = "pickupDate";
            this.pickupDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pickupDateDataGridViewTextBoxColumn.Name = "pickupDateDataGridViewTextBoxColumn";
            this.pickupDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.pickupDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // servicesDataGridViewTextBoxColumn
            // 
            this.servicesDataGridViewTextBoxColumn.DataPropertyName = "services";
            this.servicesDataGridViewTextBoxColumn.HeaderText = "services";
            this.servicesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.servicesDataGridViewTextBoxColumn.Name = "servicesDataGridViewTextBoxColumn";
            this.servicesDataGridViewTextBoxColumn.ReadOnly = true;
            this.servicesDataGridViewTextBoxColumn.Width = 125;
            // 
            // pickupcusIDDataGridViewTextBoxColumn
            // 
            this.pickupcusIDDataGridViewTextBoxColumn.DataPropertyName = "pickup_cusID";
            this.pickupcusIDDataGridViewTextBoxColumn.HeaderText = "pickup_cusID";
            this.pickupcusIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pickupcusIDDataGridViewTextBoxColumn.Name = "pickupcusIDDataGridViewTextBoxColumn";
            this.pickupcusIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pickupcusIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pickupaddressDataGridViewTextBoxColumn
            // 
            this.pickupaddressDataGridViewTextBoxColumn.DataPropertyName = "pickup_address";
            this.pickupaddressDataGridViewTextBoxColumn.HeaderText = "pickup_address";
            this.pickupaddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pickupaddressDataGridViewTextBoxColumn.Name = "pickupaddressDataGridViewTextBoxColumn";
            this.pickupaddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.pickupaddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // edeDataSetBindingSource1
            // 
            this.edeDataSetBindingSource1.DataSource = this.edeDataSet;
            this.edeDataSetBindingSource1.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(196, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Click the record to edit the record";
            // 
            // EditPickUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(883, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "EditPickUp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditPickUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edeDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource edeDataSetBindingSource;
        private edeDataSet edeDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickupDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickupcusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickupaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource edeDataSetBindingSource1;
        private System.Windows.Forms.Label label1;
    }
}

