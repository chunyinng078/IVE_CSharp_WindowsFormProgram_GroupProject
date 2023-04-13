
namespace ShippingExpensesCalculate
{
    partial class CalculateExpenses
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
            this.Calculation_Form = new System.Windows.Forms.GroupBox();
            this.lblKG = new System.Windows.Forms.Label();
            this.lblHKD = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblExpressType = new System.Windows.Forms.Label();
            this.txtExpenses = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.rdoDoc = new System.Windows.Forms.RadioButton();
            this.rdoFreight = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPieces = new System.Windows.Forms.TextBox();
            this.Calculation_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculation_Form
            // 
            this.Calculation_Form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Calculation_Form.Controls.Add(this.label1);
            this.Calculation_Form.Controls.Add(this.txtPieces);
            this.Calculation_Form.Controls.Add(this.lblKG);
            this.Calculation_Form.Controls.Add(this.lblHKD);
            this.Calculation_Form.Controls.Add(this.lblResult);
            this.Calculation_Form.Controls.Add(this.lblCountry);
            this.Calculation_Form.Controls.Add(this.lblWeight);
            this.Calculation_Form.Controls.Add(this.lblExpressType);
            this.Calculation_Form.Controls.Add(this.txtExpenses);
            this.Calculation_Form.Controls.Add(this.btnCalculate);
            this.Calculation_Form.Controls.Add(this.cmbCountry);
            this.Calculation_Form.Controls.Add(this.txtWeight);
            this.Calculation_Form.Controls.Add(this.rdoDoc);
            this.Calculation_Form.Controls.Add(this.rdoFreight);
            this.Calculation_Form.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculation_Form.ForeColor = System.Drawing.Color.DarkOrange;
            this.Calculation_Form.Location = new System.Drawing.Point(214, 54);
            this.Calculation_Form.Name = "Calculation_Form";
            this.Calculation_Form.Size = new System.Drawing.Size(569, 486);
            this.Calculation_Form.TabIndex = 0;
            this.Calculation_Form.TabStop = false;
            this.Calculation_Form.Text = "Calculation Form";
            // 
            // lblKG
            // 
            this.lblKG.Location = new System.Drawing.Point(401, 140);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(66, 30);
            this.lblKG.TabIndex = 12;
            this.lblKG.Text = "(KG)";
            this.lblKG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHKD
            // 
            this.lblHKD.Location = new System.Drawing.Point(401, 391);
            this.lblHKD.Name = "lblHKD";
            this.lblHKD.Size = new System.Drawing.Size(77, 32);
            this.lblHKD.TabIndex = 11;
            this.lblHKD.Text = "(HKD)";
            this.lblHKD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Aqua;
            this.lblResult.Location = new System.Drawing.Point(31, 399);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(78, 21);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Expense :";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.Aqua;
            this.lblCountry.Location = new System.Drawing.Point(31, 256);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(76, 21);
            this.lblCountry.TabIndex = 9;
            this.lblCountry.Text = "Country :";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.Aqua;
            this.lblWeight.Location = new System.Drawing.Point(31, 140);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(71, 21);
            this.lblWeight.TabIndex = 8;
            this.lblWeight.Text = "Weight :";
            this.lblWeight.Click += new System.EventHandler(this.lblWeight_Click);
            // 
            // lblExpressType
            // 
            this.lblExpressType.AutoSize = true;
            this.lblExpressType.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpressType.ForeColor = System.Drawing.Color.Aqua;
            this.lblExpressType.Location = new System.Drawing.Point(31, 64);
            this.lblExpressType.Name = "lblExpressType";
            this.lblExpressType.Size = new System.Drawing.Size(111, 21);
            this.lblExpressType.TabIndex = 6;
            this.lblExpressType.Text = "Express Type :";
            this.lblExpressType.Click += new System.EventHandler(this.lblExpressType_Click);
            // 
            // txtExpenses
            // 
            this.txtExpenses.Enabled = false;
            this.txtExpenses.Location = new System.Drawing.Point(229, 391);
            this.txtExpenses.Name = "txtExpenses";
            this.txtExpenses.Size = new System.Drawing.Size(166, 36);
            this.txtExpenses.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Yu Gothic UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalculate.Location = new System.Drawing.Point(71, 312);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(422, 54);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // cmbCountry
            // 
            this.cmbCountry.AutoCompleteCustomSource.AddRange(new string[] {
            "AUSTRALIA",
            "JAPAN",
            "China SHANGHAI"});
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "AUSTRALIA",
            "JAPAN",
            "China SHANGHAI"});
            this.cmbCountry.Location = new System.Drawing.Point(229, 256);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(166, 38);
            this.cmbCountry.TabIndex = 3;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(229, 140);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(166, 36);
            this.txtWeight.TabIndex = 2;
            // 
            // rdoDoc
            // 
            this.rdoDoc.AutoSize = true;
            this.rdoDoc.ForeColor = System.Drawing.Color.DarkOrange;
            this.rdoDoc.Location = new System.Drawing.Point(155, 83);
            this.rdoDoc.Name = "rdoDoc";
            this.rdoDoc.Size = new System.Drawing.Size(401, 34);
            this.rdoDoc.TabIndex = 1;
            this.rdoDoc.TabStop = true;
            this.rdoDoc.Text = "EDE EXPRESS DOCUMENT ENVELOPE";
            this.rdoDoc.UseVisualStyleBackColor = true;
            this.rdoDoc.CheckedChanged += new System.EventHandler(this.rdoDoc_CheckedChanged);
            // 
            // rdoFreight
            // 
            this.rdoFreight.AutoSize = true;
            this.rdoFreight.ForeColor = System.Drawing.Color.DarkOrange;
            this.rdoFreight.Location = new System.Drawing.Point(155, 43);
            this.rdoFreight.Name = "rdoFreight";
            this.rdoFreight.Size = new System.Drawing.Size(253, 34);
            this.rdoFreight.TabIndex = 0;
            this.rdoFreight.TabStop = true;
            this.rdoFreight.Text = "EDE EXPRESS FREIGHT";
            this.rdoFreight.UseVisualStyleBackColor = true;
            this.rdoFreight.CheckedChanged += new System.EventHandler(this.rdoFreight_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(914, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(31, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pieces";
            // 
            // txtPieces
            // 
            this.txtPieces.Location = new System.Drawing.Point(229, 198);
            this.txtPieces.Name = "txtPieces";
            this.txtPieces.Size = new System.Drawing.Size(166, 36);
            this.txtPieces.TabIndex = 13;
            // 
            // CalculateExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Calculation_Form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculateExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Shipping Expenses";
            this.Calculation_Form.ResumeLayout(false);
            this.Calculation_Form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Calculation_Form;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.RadioButton rdoDoc;
        private System.Windows.Forms.RadioButton rdoFreight;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtExpenses;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblExpressType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblKG;
        private System.Windows.Forms.Label lblHKD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPieces;
    }
}

