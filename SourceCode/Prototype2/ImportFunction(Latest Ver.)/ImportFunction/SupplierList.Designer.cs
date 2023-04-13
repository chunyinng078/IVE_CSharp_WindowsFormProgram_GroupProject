
namespace ImportFunction
{
    partial class SupplierList
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
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edeDataSet = new ImportFunction.edeDataSet();
            this.edeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regularproductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regularproductTableAdapter = new ImportFunction.edeDataSetTableAdapters.regularproductTableAdapter();
            this.tableAdapterManager = new ImportFunction.edeDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regularproductBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.edeDataSet1 = new ImportFunction.edeDataSet1();
            this.regularproductTableAdapter1 = new ImportFunction.edeDataSet1TableAdapters.regularproductTableAdapter();
            this.tableAdapterManager1 = new ImportFunction.edeDataSet1TableAdapters.TableAdapterManager();
            this.lblairwayBillID = new System.Windows.Forms.Label();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regularproductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regularproductBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Yu Gothic UI", 11F);
            this.lblName.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblName.Location = new System.Drawing.Point(35, 116);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(629, 30);
            this.lblName.TabIndex = 58;
            this.lblName.Text = "The following is a list of products you created for regular supply";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(35, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 32);
            this.label1.TabIndex = 59;
            this.label1.Text = "Double Click any column to edit product details";
            // 
            // edeDataSet
            // 
            this.edeDataSet.DataSetName = "edeDataSet";
            this.edeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // edeDataSetBindingSource
            // 
            this.edeDataSetBindingSource.DataSource = this.edeDataSet;
            this.edeDataSetBindingSource.Position = 0;
            // 
            // regularproductBindingSource
            // 
            this.regularproductBindingSource.DataMember = "regularproduct";
            this.regularproductBindingSource.DataSource = this.edeDataSet;
            // 
            // regularproductTableAdapter
            // 
            this.regularproductTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.airwaybillTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.feeTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.officesTableAdapter = null;
            this.tableAdapterManager.orderdetailsTableAdapter = null;
            this.tableAdapterManager.paymentTableAdapter = null;
            this.tableAdapterManager.pickupTableAdapter = null;
            this.tableAdapterManager.productlinesTableAdapter = null;
            this.tableAdapterManager.regularproductTableAdapter = this.regularproductTableAdapter;
            this.tableAdapterManager.shipmentTableAdapter = null;
            this.tableAdapterManager.staffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ImportFunction.edeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.unitValueDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.cusIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.regularproductBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(39, 164);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(912, 415);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Frozen = true;
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.Frozen = true;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitValueDataGridViewTextBoxColumn
            // 
            this.unitValueDataGridViewTextBoxColumn.DataPropertyName = "UnitValue";
            this.unitValueDataGridViewTextBoxColumn.HeaderText = "UnitValue";
            this.unitValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitValueDataGridViewTextBoxColumn.Name = "unitValueDataGridViewTextBoxColumn";
            this.unitValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            this.reasonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.reasonDataGridViewTextBoxColumn.Width = 125;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
            this.weightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightDataGridViewTextBoxColumn.Width = 125;
            // 
            // cusIDDataGridViewTextBoxColumn
            // 
            this.cusIDDataGridViewTextBoxColumn.DataPropertyName = "cusID";
            this.cusIDDataGridViewTextBoxColumn.HeaderText = "cusID";
            this.cusIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusIDDataGridViewTextBoxColumn.Name = "cusIDDataGridViewTextBoxColumn";
            this.cusIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // regularproductBindingSource1
            // 
            this.regularproductBindingSource1.DataMember = "regularproduct";
            this.regularproductBindingSource1.DataSource = this.edeDataSet1;
            // 
            // edeDataSet1
            // 
            this.edeDataSet1.DataSetName = "edeDataSet1";
            this.edeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regularproductTableAdapter1
            // 
            this.regularproductTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.airwaybillTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.customerTableAdapter = null;
            this.tableAdapterManager1.feeTableAdapter = null;
            this.tableAdapterManager1.itemTableAdapter = null;
            this.tableAdapterManager1.officesTableAdapter = null;
            this.tableAdapterManager1.orderdetailsTableAdapter = null;
            this.tableAdapterManager1.paymentTableAdapter = null;
            this.tableAdapterManager1.pickupTableAdapter = null;
            this.tableAdapterManager1.productlinesTableAdapter = null;
            this.tableAdapterManager1.regularproductTableAdapter = this.regularproductTableAdapter1;
            this.tableAdapterManager1.shipmentTableAdapter = null;
            this.tableAdapterManager1.staffTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ImportFunction.edeDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblairwayBillID
            // 
            this.lblairwayBillID.AutoSize = true;
            this.lblairwayBillID.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.lblairwayBillID.ForeColor = System.Drawing.Color.Aqua;
            this.lblairwayBillID.Location = new System.Drawing.Point(35, 40);
            this.lblairwayBillID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblairwayBillID.Name = "lblairwayBillID";
            this.lblairwayBillID.Size = new System.Drawing.Size(289, 32);
            this.lblairwayBillID.TabIndex = 62;
            this.lblairwayBillID.Text = "Search with Airway bill ID:";
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(332, 40);
            this.tbsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(172, 26);
            this.tbsearch.TabIndex = 61;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(704, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 56);
            this.button1.TabIndex = 63;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button2.Location = new System.Drawing.Point(833, 91);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 55);
            this.button2.TabIndex = 64;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SupplierList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(989, 747);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblairwayBillID);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SupplierList";
            this.Text = "Regular supplies list";
            this.Load += new System.EventHandler(this.SupplierList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regularproductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regularproductBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edeDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource edeDataSetBindingSource;
        private edeDataSet edeDataSet;
        private System.Windows.Forms.BindingSource regularproductBindingSource;
        private edeDataSetTableAdapters.regularproductTableAdapter regularproductTableAdapter;
        private edeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private edeDataSet1 edeDataSet1;
        private System.Windows.Forms.BindingSource regularproductBindingSource1;
        private edeDataSet1TableAdapters.regularproductTableAdapter regularproductTableAdapter1;
        private edeDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblairwayBillID;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}