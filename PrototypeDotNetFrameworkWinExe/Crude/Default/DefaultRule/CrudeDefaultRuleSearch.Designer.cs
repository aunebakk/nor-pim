namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultRuleSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeDefaultRuleSearch;
        
        private System.Windows.Forms.Button buttonCrudeDefaultRuleAdd;
        
        private System.Windows.Forms.Button buttonCrudeDefaultRuleEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultRule;
        
        private DefaultRuleTypeRefCombo defaultRuleTypeRefCombo;
        
        private System.Windows.Forms.Label labelDefaultRuleTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxAddress;
        
        private System.Windows.Forms.Label labelAddress;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTime;
        
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
            this.buttonCrudeDefaultRuleAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultRuleEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultRuleSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultRule = new System.Windows.Forms.DataGridView();
            this.labelDefaultRuleTypeRefCombo = new System.Windows.Forms.Label();
            this.defaultRuleTypeRefCombo = new DefaultRuleTypeRefCombo();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultRule)).BeginInit();
            this.SuspendLayout();
            //
            // labelDefaultRuleTypeRefCombo
            //
            this.labelDefaultRuleTypeRefCombo.AutoSize = true;
            this.labelDefaultRuleTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultRuleTypeRefCombo.Name = "labelDefaultRuleTypeRefCombo";
            this.labelDefaultRuleTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultRuleTypeRefCombo.TabIndex = 2;
            this.labelDefaultRuleTypeRefCombo.Text = "Default Rule Type:";
            //
            //defaultRuleTypeRefCombo
            //
            this.defaultRuleTypeRefCombo.Location = new System.Drawing.Point(140, 13);
            this.defaultRuleTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultRuleTypeRefCombo.Name = "defaultRuleTypeRefCombo";
            this.defaultRuleTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.defaultRuleTypeRefCombo.TabIndex = 3;
            //
            // labelAddress
            //
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(11, 36);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(71, 13);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Address:";
            //
            //textBoxAddress
            //
            this.textBoxAddress.Location = new System.Drawing.Point(140, 36);
            this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(250, 20);
            this.textBoxAddress.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // dataGridViewCrudeDefaultRule
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultRule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultRule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultRule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultRule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultRule.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeDefaultRule.Name = "dataGridViewCrudeDefaultRule";
            this.dataGridViewCrudeDefaultRule.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeDefaultRule.TabIndex = 0;
            this.dataGridViewCrudeDefaultRule.ReadOnly = true;
            this.dataGridViewCrudeDefaultRule.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultRule_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeDefaultRuleSearch
            // 
            this.buttonCrudeDefaultRuleSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultRuleSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeDefaultRuleSearch.Name = "buttonCrudeDefaultRuleSearch";
            this.buttonCrudeDefaultRuleSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultRuleSearch.TabIndex = 2;
            this.buttonCrudeDefaultRuleSearch.Text = "&Search";
            this.buttonCrudeDefaultRuleSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultRuleSearch.Click += new System.EventHandler(this.buttonCrudeDefaultRuleSearch_Click);
            // 
            // buttonCrudeDefaultRuleAdd
            // 
            this.buttonCrudeDefaultRuleAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultRuleAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeDefaultRuleAdd.Name = "buttonCrudeDefaultRuleAdd";
            this.buttonCrudeDefaultRuleAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultRuleAdd.TabIndex = 3;
            this.buttonCrudeDefaultRuleAdd.Text = "&Add";
            this.buttonCrudeDefaultRuleAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultRuleAdd.Click += new System.EventHandler(this.buttonCrudeDefaultRuleAdd_Click);
            // 
            // buttonCrudeDefaultRuleEdit
            // 
            this.buttonCrudeDefaultRuleEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultRuleEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeDefaultRuleEdit.Name = "buttonCrudeDefaultRuleEdit";
            this.buttonCrudeDefaultRuleEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultRuleEdit.TabIndex = 4;
            this.buttonCrudeDefaultRuleEdit.Text = "&Edit";
            this.buttonCrudeDefaultRuleEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultRuleEdit.Click += new System.EventHandler(this.buttonCrudeDefaultRuleEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeDefaultRuleSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultRuleAdd);
            this.Controls.Add(this.buttonCrudeDefaultRuleEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultRule);
            this.Name = "CrudeDefaultRuleSearch";
            this.Text = "Default Rule Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultRule)).EndInit();
            this.Controls.Add(this.labelDefaultRuleTypeRefCombo);
            this.Controls.Add(this.defaultRuleTypeRefCombo);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
