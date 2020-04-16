namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialCouponSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCouponSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCouponAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCouponEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialCoupon;
        
        private System.Windows.Forms.TextBox textBoxCouponDescription;
        
        private System.Windows.Forms.Label labelCouponDescription;
        
        private FinancialCouponTypeRefCombo financialCouponTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialCouponTypeRefCombo;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCouponNumber;
        
        private System.Windows.Forms.Label labelCouponNumber;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValueAmount;
        
        private System.Windows.Forms.Label labelValueAmount;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerValidFromDateTime;
        
        private System.Windows.Forms.Label labelValidFromDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerValidUntilDateTime;
        
        private System.Windows.Forms.Label labelValidUntilDateTime;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialCouponAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialCouponEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialCouponSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialCoupon = new System.Windows.Forms.DataGridView();
            this.labelCouponDescription = new System.Windows.Forms.Label();
            this.textBoxCouponDescription = new System.Windows.Forms.TextBox();
            this.labelFinancialCouponTypeRefCombo = new System.Windows.Forms.Label();
            this.financialCouponTypeRefCombo = new FinancialCouponTypeRefCombo();
            this.labelCouponNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxCouponNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelValueAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxValueAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelValidFromDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerValidFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelValidUntilDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerValidUntilDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialCoupon)).BeginInit();
            this.SuspendLayout();
            //
            // labelCouponDescription
            //
            this.labelCouponDescription.AutoSize = true;
            this.labelCouponDescription.Location = new System.Drawing.Point(11, 13);
            this.labelCouponDescription.Name = "labelCouponDescription";
            this.labelCouponDescription.Size = new System.Drawing.Size(71, 13);
            this.labelCouponDescription.TabIndex = 2;
            this.labelCouponDescription.Text = "Coupon Description:";
            //
            //textBoxCouponDescription
            //
            this.textBoxCouponDescription.Location = new System.Drawing.Point(147, 13);
            this.textBoxCouponDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCouponDescription.Name = "textBoxCouponDescription";
            this.textBoxCouponDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxCouponDescription.TabIndex = 3;
            //
            // labelFinancialCouponTypeRefCombo
            //
            this.labelFinancialCouponTypeRefCombo.AutoSize = true;
            this.labelFinancialCouponTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialCouponTypeRefCombo.Name = "labelFinancialCouponTypeRefCombo";
            this.labelFinancialCouponTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCouponTypeRefCombo.TabIndex = 4;
            this.labelFinancialCouponTypeRefCombo.Text = "Financial Coupon Type:";
            //
            //financialCouponTypeRefCombo
            //
            this.financialCouponTypeRefCombo.Location = new System.Drawing.Point(147, 36);
            this.financialCouponTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCouponTypeRefCombo.Name = "financialCouponTypeRefCombo";
            this.financialCouponTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialCouponTypeRefCombo.TabIndex = 5;
            //
            // labelCouponNumber
            //
            this.labelCouponNumber.AutoSize = true;
            this.labelCouponNumber.Location = new System.Drawing.Point(11, 59);
            this.labelCouponNumber.Name = "labelCouponNumber";
            this.labelCouponNumber.Size = new System.Drawing.Size(71, 13);
            this.labelCouponNumber.TabIndex = 6;
            this.labelCouponNumber.Text = "Coupon Number:";
            //
            //maskedTextBoxCouponNumber
            //
            this.maskedTextBoxCouponNumber.Location = new System.Drawing.Point(147, 59);
            this.maskedTextBoxCouponNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxCouponNumber.Name = "maskedTextBoxCouponNumber";
            this.maskedTextBoxCouponNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxCouponNumber.TabIndex = 7;
            //
            // labelValueAmount
            //
            this.labelValueAmount.AutoSize = true;
            this.labelValueAmount.Location = new System.Drawing.Point(11, 82);
            this.labelValueAmount.Name = "labelValueAmount";
            this.labelValueAmount.Size = new System.Drawing.Size(71, 13);
            this.labelValueAmount.TabIndex = 8;
            this.labelValueAmount.Text = "Value Amount:";
            //
            //maskedTextBoxValueAmount
            //
            this.maskedTextBoxValueAmount.Location = new System.Drawing.Point(147, 82);
            this.maskedTextBoxValueAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxValueAmount.Name = "maskedTextBoxValueAmount";
            this.maskedTextBoxValueAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxValueAmount.TabIndex = 9;
            //
            // labelValidFromDateTime
            //
            this.labelValidFromDateTime.AutoSize = true;
            this.labelValidFromDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelValidFromDateTime.Name = "labelValidFromDateTime";
            this.labelValidFromDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelValidFromDateTime.TabIndex = 10;
            this.labelValidFromDateTime.Text = "Valid From Date Time:";
            //
            //dateTimePickerValidFromDateTime
            //
            this.dateTimePickerValidFromDateTime.Location = new System.Drawing.Point(147, 105);
            this.dateTimePickerValidFromDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerValidFromDateTime.Name = "dateTimePickerValidFromDateTime";
            this.dateTimePickerValidFromDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerValidFromDateTime.TabIndex = 11;
            this.dateTimePickerValidFromDateTime.Checked = false;
            this.dateTimePickerValidFromDateTime.ShowCheckBox = true;
            //
            // labelValidUntilDateTime
            //
            this.labelValidUntilDateTime.AutoSize = true;
            this.labelValidUntilDateTime.Location = new System.Drawing.Point(11, 128);
            this.labelValidUntilDateTime.Name = "labelValidUntilDateTime";
            this.labelValidUntilDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelValidUntilDateTime.TabIndex = 12;
            this.labelValidUntilDateTime.Text = "Valid Until Date Time:";
            //
            //dateTimePickerValidUntilDateTime
            //
            this.dateTimePickerValidUntilDateTime.Location = new System.Drawing.Point(147, 128);
            this.dateTimePickerValidUntilDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerValidUntilDateTime.Name = "dateTimePickerValidUntilDateTime";
            this.dateTimePickerValidUntilDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerValidUntilDateTime.TabIndex = 13;
            this.dateTimePickerValidUntilDateTime.Checked = false;
            this.dateTimePickerValidUntilDateTime.ShowCheckBox = true;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 151);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 14;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(147, 151);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 15;
            // 
            // dataGridViewCrudeFinancialCoupon
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialCoupon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialCoupon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialCoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialCoupon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialCoupon.Location = new System.Drawing.Point(12, 184);
            this.dataGridViewCrudeFinancialCoupon.Name = "dataGridViewCrudeFinancialCoupon";
            this.dataGridViewCrudeFinancialCoupon.Size = new System.Drawing.Size(385, 96);
            this.dataGridViewCrudeFinancialCoupon.TabIndex = 0;
            this.dataGridViewCrudeFinancialCoupon.ReadOnly = true;
            this.dataGridViewCrudeFinancialCoupon.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialCoupon_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(305, 287);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialCouponSearch
            // 
            this.buttonCrudeFinancialCouponSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCouponSearch.Location = new System.Drawing.Point(205, 287);
            this.buttonCrudeFinancialCouponSearch.Name = "buttonCrudeFinancialCouponSearch";
            this.buttonCrudeFinancialCouponSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCouponSearch.TabIndex = 2;
            this.buttonCrudeFinancialCouponSearch.Text = "&Search";
            this.buttonCrudeFinancialCouponSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCouponSearch.Click += new System.EventHandler(this.buttonCrudeFinancialCouponSearch_Click);
            // 
            // buttonCrudeFinancialCouponAdd
            // 
            this.buttonCrudeFinancialCouponAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCouponAdd.Location = new System.Drawing.Point(105, 287);
            this.buttonCrudeFinancialCouponAdd.Name = "buttonCrudeFinancialCouponAdd";
            this.buttonCrudeFinancialCouponAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCouponAdd.TabIndex = 3;
            this.buttonCrudeFinancialCouponAdd.Text = "&Add";
            this.buttonCrudeFinancialCouponAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCouponAdd.Click += new System.EventHandler(this.buttonCrudeFinancialCouponAdd_Click);
            // 
            // buttonCrudeFinancialCouponEdit
            // 
            this.buttonCrudeFinancialCouponEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCouponEdit.Location = new System.Drawing.Point(5, 287);
            this.buttonCrudeFinancialCouponEdit.Name = "buttonCrudeFinancialCouponEdit";
            this.buttonCrudeFinancialCouponEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCouponEdit.TabIndex = 4;
            this.buttonCrudeFinancialCouponEdit.Text = "&Edit";
            this.buttonCrudeFinancialCouponEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCouponEdit.Click += new System.EventHandler(this.buttonCrudeFinancialCouponEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 315);
            this.Controls.Add(this.buttonCrudeFinancialCouponSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialCouponAdd);
            this.Controls.Add(this.buttonCrudeFinancialCouponEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialCoupon);
            this.Name = "CrudeFinancialCouponSearch";
            this.Text = "Financial Coupon Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialCoupon)).EndInit();
            this.Controls.Add(this.labelCouponDescription);
            this.Controls.Add(this.textBoxCouponDescription);
            this.Controls.Add(this.labelFinancialCouponTypeRefCombo);
            this.Controls.Add(this.financialCouponTypeRefCombo);
            this.Controls.Add(this.labelCouponNumber);
            this.Controls.Add(this.maskedTextBoxCouponNumber);
            this.Controls.Add(this.labelValueAmount);
            this.Controls.Add(this.maskedTextBoxValueAmount);
            this.Controls.Add(this.labelValidFromDateTime);
            this.Controls.Add(this.dateTimePickerValidFromDateTime);
            this.Controls.Add(this.labelValidUntilDateTime);
            this.Controls.Add(this.dateTimePickerValidUntilDateTime);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
