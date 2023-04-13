
namespace Statistics
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.lblShipmentType = new System.Windows.Forms.Label();
            this.txtShipmentType = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.statisticsGridView = new System.Windows.Forms.DataGridView();
            this.btnShowChart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblDestinationCountry = new System.Windows.Forms.Label();
            this.btnPieChart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.lblCustomer.ForeColor = System.Drawing.Color.Aqua;
            this.lblCustomer.Location = new System.Drawing.Point(90, 217);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(153, 32);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer ID:";
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(278, 217);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(232, 26);
            this.txtCusID.TabIndex = 1;
            // 
            // lblShipmentType
            // 
            this.lblShipmentType.AutoSize = true;
            this.lblShipmentType.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.lblShipmentType.ForeColor = System.Drawing.Color.Aqua;
            this.lblShipmentType.Location = new System.Drawing.Point(564, 211);
            this.lblShipmentType.Name = "lblShipmentType";
            this.lblShipmentType.Size = new System.Drawing.Size(180, 32);
            this.lblShipmentType.TabIndex = 2;
            this.lblShipmentType.Text = "Shipment Type:";
            // 
            // txtShipmentType
            // 
            this.txtShipmentType.Location = new System.Drawing.Point(775, 217);
            this.txtShipmentType.Name = "txtShipmentType";
            this.txtShipmentType.Size = new System.Drawing.Size(232, 26);
            this.txtShipmentType.TabIndex = 3;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnShow.Location = new System.Drawing.Point(1506, 322);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(200, 51);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show Statistics";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // statisticsGridView
            // 
            this.statisticsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticsGridView.Location = new System.Drawing.Point(94, 286);
            this.statisticsGridView.Name = "statisticsGridView";
            this.statisticsGridView.RowHeadersWidth = 62;
            this.statisticsGridView.RowTemplate.Height = 28;
            this.statisticsGridView.Size = new System.Drawing.Size(1367, 386);
            this.statisticsGridView.TabIndex = 5;
            // 
            // btnShowChart
            // 
            this.btnShowChart.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnShowChart.Location = new System.Drawing.Point(1506, 409);
            this.btnShowChart.Name = "btnShowChart";
            this.btnShowChart.Size = new System.Drawing.Size(200, 51);
            this.btnShowChart.TabIndex = 6;
            this.btnShowChart.Text = "Show Chart";
            this.btnShowChart.UseVisualStyleBackColor = true;
            this.btnShowChart.Visible = false;
            this.btnShowChart.Click += new System.EventHandler(this.btnShowChart_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(94, 692);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Report1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1367, 703);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(1204, 217);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(232, 26);
            this.txtDestination.TabIndex = 9;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.lblDestination.ForeColor = System.Drawing.Color.Aqua;
            this.lblDestination.Location = new System.Drawing.Point(1036, 217);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(142, 32);
            this.lblDestination.TabIndex = 8;
            this.lblDestination.Text = "Destination:";
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblReport.Location = new System.Drawing.Point(85, 32);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(836, 65);
            this.lblReport.TabIndex = 10;
            this.lblReport.Text = "Satistical Report (Approved User Only)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(86, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1375, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "Please refine search criteria (Default Search - Number of shipments made by each " +
    "customer: ";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblService.Location = new System.Drawing.Point(565, 249);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(329, 28);
            this.lblService.TabIndex = 12;
            this.lblService.Text = "Services (0 - document; 1 - freight)";
            // 
            // lblDestinationCountry
            // 
            this.lblDestinationCountry.AutoSize = true;
            this.lblDestinationCountry.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationCountry.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblDestinationCountry.Location = new System.Drawing.Point(1037, 249);
            this.lblDestinationCountry.Name = "lblDestinationCountry";
            this.lblDestinationCountry.Size = new System.Drawing.Size(594, 28);
            this.lblDestinationCountry.TabIndex = 13;
            this.lblDestinationCountry.Text = "Destination (0 - Australia 1 - Hong Kong 2 - Japan 3 - Shanghai)";
            // 
            // btnPieChart
            // 
            this.btnPieChart.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPieChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPieChart.Location = new System.Drawing.Point(1506, 500);
            this.btnPieChart.Name = "btnPieChart";
            this.btnPieChart.Size = new System.Drawing.Size(200, 51);
            this.btnPieChart.TabIndex = 14;
            this.btnPieChart.Text = "Pie Chart";
            this.btnPieChart.UseVisualStyleBackColor = true;
            this.btnPieChart.Visible = false;
            this.btnPieChart.Click += new System.EventHandler(this.btnPieChart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClear.Location = new System.Drawing.Point(1506, 584);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 51);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPrint.Location = new System.Drawing.Point(1506, 692);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(200, 51);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Print as PDF";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Statistics.Properties.Resources.statistics_80px;
            this.pictureBox2.Location = new System.Drawing.Point(1506, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 173);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1877, 1442);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPieChart);
            this.Controls.Add(this.lblDestinationCountry);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnShowChart);
            this.Controls.Add(this.statisticsGridView);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtShipmentType);
            this.Controls.Add(this.lblShipmentType);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.lblCustomer);
            this.Name = "Statistics";
            this.Text = "Statistics Report";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statisticsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.Label lblShipmentType;
        private System.Windows.Forms.TextBox txtShipmentType;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView statisticsGridView;
        private System.Windows.Forms.Button btnShowChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblDestinationCountry;
        private System.Windows.Forms.Button btnPieChart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

