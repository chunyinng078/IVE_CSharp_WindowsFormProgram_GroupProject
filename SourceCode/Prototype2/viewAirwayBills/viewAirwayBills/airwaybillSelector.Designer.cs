
namespace viewAirwayBills
{
    partial class airwaybillSelector
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
            this.lblairwayBillID = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtairwayBillID = new System.Windows.Forms.TextBox();
            this.tableAdapterManager1 = new viewAirwayBills.edeDataSet2TableAdapters.TableAdapterManager();
            this.airwaybillTableAdapter1 = new viewAirwayBills.edeDataSet2TableAdapters.airwaybillTableAdapter();
            this.airwaybillBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new viewAirwayBills.edeDataSet1TableAdapters.TableAdapterManager();
            this.airwaybillTableAdapter = new viewAirwayBills.edeDataSet1TableAdapters.airwaybillTableAdapter();
            this.airwaybillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edeDataSet1 = new viewAirwayBills.edeDataSet1();
            this.edeDataSet2 = new viewAirwayBills.edeDataSet2();
            this.edeDataSet3 = new viewAirwayBills.edeDataSet3();
            this.airwaybillBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.airwaybillTableAdapter2 = new viewAirwayBills.edeDataSet3TableAdapters.airwaybillTableAdapter();
            this.tableAdapterManager2 = new viewAirwayBills.edeDataSet3TableAdapters.TableAdapterManager();
            this.airwaybillDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.airwaybillBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airwaybillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airwaybillBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airwaybillDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblairwayBillID
            // 
            this.lblairwayBillID.AutoSize = true;
            this.lblairwayBillID.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblairwayBillID.ForeColor = System.Drawing.Color.Aqua;
            this.lblairwayBillID.Location = new System.Drawing.Point(247, 131);
            this.lblairwayBillID.Name = "lblairwayBillID";
            this.lblairwayBillID.Size = new System.Drawing.Size(247, 28);
            this.lblairwayBillID.TabIndex = 14;
            this.lblairwayBillID.Text = "Search with Airway bill ID:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(814, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(700, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtairwayBillID
            // 
            this.txtairwayBillID.Location = new System.Drawing.Point(511, 130);
            this.txtairwayBillID.Name = "txtairwayBillID";
            this.txtairwayBillID.Size = new System.Drawing.Size(116, 29);
            this.txtairwayBillID.TabIndex = 10;
            this.txtairwayBillID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.airwaybillTableAdapter = this.airwaybillTableAdapter1;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = viewAirwayBills.edeDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // airwaybillTableAdapter1
            // 
            this.airwaybillTableAdapter1.ClearBeforeFill = true;
            // 
            // airwaybillBindingSource1
            // 
            this.airwaybillBindingSource1.DataMember = "airwaybill";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.airwaybillTableAdapter = this.airwaybillTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = viewAirwayBills.edeDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // airwaybillTableAdapter
            // 
            this.airwaybillTableAdapter.ClearBeforeFill = true;
            // 
            // airwaybillBindingSource
            // 
            this.airwaybillBindingSource.DataMember = "airwaybill";
            // 
            // edeDataSet1
            // 
            this.edeDataSet1.DataSetName = "edeDataSet1";
            this.edeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // edeDataSet2
            // 
            this.edeDataSet2.DataSetName = "edeDataSet2";
            this.edeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // edeDataSet3
            // 
            this.edeDataSet3.DataSetName = "edeDataSet3";
            this.edeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airwaybillBindingSource2
            // 
            this.airwaybillBindingSource2.DataMember = "airwaybill";
            this.airwaybillBindingSource2.DataSource = this.edeDataSet3;
            // 
            // airwaybillTableAdapter2
            // 
            this.airwaybillTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.airwaybillTableAdapter = this.airwaybillTableAdapter2;
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.UpdateOrder = viewAirwayBills.edeDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // airwaybillDataGridView
            // 
            this.airwaybillDataGridView.AllowUserToAddRows = false;
            this.airwaybillDataGridView.AllowUserToDeleteRows = false;
            this.airwaybillDataGridView.AutoGenerateColumns = false;
            this.airwaybillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airwaybillDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.airwaybillDataGridView.DataSource = this.airwaybillBindingSource2;
            this.airwaybillDataGridView.Location = new System.Drawing.Point(45, 249);
            this.airwaybillDataGridView.Name = "airwaybillDataGridView";
            this.airwaybillDataGridView.ReadOnly = true;
            this.airwaybillDataGridView.RowHeadersWidth = 62;
            this.airwaybillDataGridView.RowTemplate.Height = 24;
            this.airwaybillDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.airwaybillDataGridView.Size = new System.Drawing.Size(1143, 220);
            this.airwaybillDataGridView.TabIndex = 17;
            this.airwaybillDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.airwaybillDataGridView_CellDoubleClick_4);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "airwayBillID";
            this.dataGridViewTextBoxColumn1.HeaderText = "airwayBillID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "services";
            this.dataGridViewTextBoxColumn2.HeaderText = "services";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "destinationCountry";
            this.dataGridViewTextBoxColumn3.HeaderText = "destinationCountry";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "deliveryAddress";
            this.dataGridViewTextBoxColumn4.HeaderText = "deliveryAddress";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "receiverCompany";
            this.dataGridViewTextBoxColumn6.HeaderText = "receiverCompany";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "receiverName";
            this.dataGridViewTextBoxColumn7.HeaderText = "receiverName";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "contentDescription";
            this.dataGridViewTextBoxColumn11.HeaderText = "contentDescription";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn16.HeaderText = "date";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 150;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn17.HeaderText = "status";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 150;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "statusComment";
            this.dataGridViewTextBoxColumn18.HeaderText = "statusComment";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 150;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "cusID";
            this.dataGridViewTextBoxColumn19.HeaderText = "cusID";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(320, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "(Double click on record to open the airway bill form)";
            // 
            // airwaybillSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1267, 630);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.airwaybillDataGridView);
            this.Controls.Add(this.lblairwayBillID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtairwayBillID);
            this.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "airwaybillSelector";
            this.ShowIcon = false;
            this.Text = "Airway Bill Selector";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airwaybillBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airwaybillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airwaybillBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airwaybillDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblairwayBillID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtairwayBillID;
        private edeDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private edeDataSet2TableAdapters.airwaybillTableAdapter airwaybillTableAdapter1;
        private System.Windows.Forms.BindingSource airwaybillBindingSource1;
        private edeDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private edeDataSet1TableAdapters.airwaybillTableAdapter airwaybillTableAdapter;
        private System.Windows.Forms.BindingSource airwaybillBindingSource;
        private edeDataSet1 edeDataSet1;
        private edeDataSet2 edeDataSet2;
        private edeDataSet3 edeDataSet3;
        private System.Windows.Forms.BindingSource airwaybillBindingSource2;
        private edeDataSet3TableAdapters.airwaybillTableAdapter airwaybillTableAdapter2;
        private edeDataSet3TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView airwaybillDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.Label label1;
    }
}

