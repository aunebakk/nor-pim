namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialCouponTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCouponTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCouponTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCouponTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialCouponTypeRef;
        
        private System.Windows.Forms.TextBox textBoxFinancialCouponTypeName;
        
        private System.Windows.Forms.Label labelFinancialCouponTypeName;
        
        private System.Windows.Forms.TextBox textBoxFinancialCouponType;
        
        private System.Windows.Forms.Label labelFinancialCouponType;
        
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
            this.buttonCrudeFinancialCouponTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialCouponTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialCouponTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialCouponTypeRef = new System.Windows.Forms.DataGridView();
            this.labelFinancialCouponTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialCouponTypeName = new System.Windows.Forms.TextBox();
            this.labelFinancialCouponType = new System.Windows.Forms.Label();
            this.textBoxFinancialCouponType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialCouponTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialCouponTypeName
            //
            this.labelFinancialCouponTypeName.AutoSize = true;
            this.labelFinancialCouponTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialCouponTypeName.Name = "labelFinancialCouponTypeName";
            this.labelFinancialCouponTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCouponTypeName.TabIndex = 2;
            this.labelFinancialCouponTypeName.Text = "Financial Coupon Type Name:";
            //
            //textBoxFinancialCouponTypeName
            //
            this.textBoxFinancialCouponTypeName.Location = new System.Drawing.Point(182, 13);
            this.textBoxFinancialCouponTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCouponTypeName.Name = "textBoxFinancialCouponTypeName";
            this.textBoxFinancialCouponTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCouponTypeName.TabIndex = 3;
            //
            // labelFinancialCouponType
            //
            this.labelFinancialCouponType.AutoSize = true;
            this.labelFinancialCouponType.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialCouponType.Name = "labelFinancialCouponType";
            this.labelFinancialCouponType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCouponType.TabIndex = 4;
            this.labelFinancialCouponType.Text = "Financial Coupon Type:";
            //
            //textBoxFinancialCouponType
            //
            this.textBoxFinancialCouponType.Location = new System.Drawing.Point(182, 36);
            this.textBoxFinancialCouponType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCouponType.Name = "textBoxFinancialCouponType";
            this.textBoxFinancialCouponType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCouponType.TabIndex = 5;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 6;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(182, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeFinancialCouponTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialCouponTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialCouponTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialCouponTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialCouponTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialCouponTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFinancialCouponTypeRef.Name = "dataGridViewCrudeFinancialCouponTypeRef";
            this.dataGridViewCrudeFinancialCouponTypeRef.Size = new System.Drawing.Size(420, 96);
            this.dataGridViewCrudeFinancialCouponTypeRef.TabIndex = 0;
            this.dataGridViewCrudeFinancialCouponTypeRef.ReadOnly = true;
            this.dataGridViewCrudeFinancialCouponTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialCouponTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(340, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialCouponTypeRefSearch
            // 
            this.buttonCrudeFinancialCouponTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCouponTypeRefSearch.Location = new System.Drawing.Point(240, 195);
            this.buttonCrudeFinancialCouponTypeRefSearch.Name = "buttonCrudeFinancialCouponTypeRefSearch";
            this.buttonCrudeFinancialCouponTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCouponTypeRefSearch.TabIndex = 2;
            this.buttonCrudeFinancialCouponTypeRefSearch.Text = "&Search";
            this.buttonCrudeFinancialCouponTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCouponTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeFinancialCouponTypeRefSearch_Click);
            // 
            // buttonCrudeFinancialCouponTypeRefAdd
            // 
            this.buttonCrudeFinancialCouponTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCouponTypeRefAdd.Location = new System.Drawing.Point(140, 195);
            this.buttonCrudeFinancialCouponTypeRefAdd.Name = "buttonCrudeFinancialCouponTypeRefAdd";
            this.buttonCrudeFinancialCouponTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCouponTypeRefAdd.TabIndex = 3;
            this.buttonCrudeFinancialCouponTypeRefAdd.Text = "&Add";
            this.buttonCrudeFinancialCouponTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCouponTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeFinancialCouponTypeRefAdd_Click);
            // 
            // buttonCrudeFinancialCouponTypeRefEdit
            // 
            this.buttonCrudeFinancialCouponTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCouponTypeRefEdit.Location = new System.Drawing.Point(40, 195);
            this.buttonCrudeFinancialCouponTypeRefEdit.Name = "buttonCrudeFinancialCouponTypeRefEdit";
            this.buttonCrudeFinancialCouponTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCouponTypeRefEdit.TabIndex = 4;
            this.buttonCrudeFinancialCouponTypeRefEdit.Text = "&Edit";
            this.buttonCrudeFinancialCouponTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCouponTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeFinancialCouponTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 223);
            this.Controls.Add(this.buttonCrudeFinancialCouponTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialCouponTypeRefAdd);
            this.Controls.Add(this.buttonCrudeFinancialCouponTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialCouponTypeRef);
            this.Name = "CrudeFinancialCouponTypeRefSearch";
            this.Text = "Financial Coupon Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialCouponTypeRef)).EndInit();
            this.Controls.Add(this.labelFinancialCouponTypeName);
            this.Controls.Add(this.textBoxFinancialCouponTypeName);
            this.Controls.Add(this.labelFinancialCouponType);
            this.Controls.Add(this.textBoxFinancialCouponType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
