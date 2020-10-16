namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientContactMethodRefSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeClientContactMethodRefSearch;

        private System.Windows.Forms.Button buttonCrudeClientContactMethodRefAdd;

        private System.Windows.Forms.Button buttonCrudeClientContactMethodRefEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeClientContactMethodRef;

        private System.Windows.Forms.TextBox textBoxClientContactMethodName;

        private System.Windows.Forms.Label labelClientContactMethodName;

        private System.Windows.Forms.TextBox textBoxClientContactMethod;

        private System.Windows.Forms.Label labelClientContactMethod;

        private System.Windows.Forms.TextBox textBoxClientContactMethodDescription;

        private System.Windows.Forms.Label labelClientContactMethodDescription;

        private System.Windows.Forms.MaskedTextBox maskedTextBoxSortOrder;

        private System.Windows.Forms.Label labelSortOrder;

        private System.Windows.Forms.TextBox dateTimePickerDateTime;

        private System.Windows.Forms.Label labelDateTime;

        private System.Windows.Forms.CheckBox checkBoxActiveFlag;

        private System.Windows.Forms.Label labelActiveFlag;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeClientContactMethodRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeClientContactMethodRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeClientContactMethodRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeClientContactMethodRef = new System.Windows.Forms.DataGridView();
            this.labelClientContactMethodName = new System.Windows.Forms.Label();
            this.textBoxClientContactMethodName = new System.Windows.Forms.TextBox();
            this.labelClientContactMethod = new System.Windows.Forms.Label();
            this.textBoxClientContactMethod = new System.Windows.Forms.TextBox();
            this.labelClientContactMethodDescription = new System.Windows.Forms.Label();
            this.textBoxClientContactMethodDescription = new System.Windows.Forms.TextBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientContactMethodRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelClientContactMethodName
            //
            this.labelClientContactMethodName.AutoSize = true;
            this.labelClientContactMethodName.Location = new System.Drawing.Point(11, 13);
            this.labelClientContactMethodName.Name = "labelClientContactMethodName";
            this.labelClientContactMethodName.Size = new System.Drawing.Size(71, 13);
            this.labelClientContactMethodName.TabIndex = 2;
            this.labelClientContactMethodName.Text = "Client Contact Method Name:";
            //
            //textBoxClientContactMethodName
            //
            this.textBoxClientContactMethodName.Location = new System.Drawing.Point(231, 13);
            this.textBoxClientContactMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientContactMethodName.Name = "textBoxClientContactMethodName";
            this.textBoxClientContactMethodName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientContactMethodName.TabIndex = 3;
            //
            // labelClientContactMethod
            //
            this.labelClientContactMethod.AutoSize = true;
            this.labelClientContactMethod.Location = new System.Drawing.Point(11, 36);
            this.labelClientContactMethod.Name = "labelClientContactMethod";
            this.labelClientContactMethod.Size = new System.Drawing.Size(71, 13);
            this.labelClientContactMethod.TabIndex = 4;
            this.labelClientContactMethod.Text = "Client Contact Method:";
            //
            //textBoxClientContactMethod
            //
            this.textBoxClientContactMethod.Location = new System.Drawing.Point(231, 36);
            this.textBoxClientContactMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientContactMethod.Name = "textBoxClientContactMethod";
            this.textBoxClientContactMethod.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientContactMethod.TabIndex = 5;
            //
            // labelClientContactMethodDescription
            //
            this.labelClientContactMethodDescription.AutoSize = true;
            this.labelClientContactMethodDescription.Location = new System.Drawing.Point(11, 59);
            this.labelClientContactMethodDescription.Name = "labelClientContactMethodDescription";
            this.labelClientContactMethodDescription.Size = new System.Drawing.Size(71, 13);
            this.labelClientContactMethodDescription.TabIndex = 6;
            this.labelClientContactMethodDescription.Text = "Client Contact Method Description:";
            //
            //textBoxClientContactMethodDescription
            //
            this.textBoxClientContactMethodDescription.Location = new System.Drawing.Point(231, 59);
            this.textBoxClientContactMethodDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientContactMethodDescription.Name = "textBoxClientContactMethodDescription";
            this.textBoxClientContactMethodDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientContactMethodDescription.TabIndex = 7;
            //
            // labelSortOrder
            //
            this.labelSortOrder.AutoSize = true;
            this.labelSortOrder.Location = new System.Drawing.Point(11, 82);
            this.labelSortOrder.Name = "labelSortOrder";
            this.labelSortOrder.Size = new System.Drawing.Size(71, 13);
            this.labelSortOrder.TabIndex = 8;
            this.labelSortOrder.Text = "Sort Order:";
            //
            //maskedTextBoxSortOrder
            //
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(231, 82);
            this.maskedTextBoxSortOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxSortOrder.Name = "maskedTextBoxSortOrder";
            this.maskedTextBoxSortOrder.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxSortOrder.TabIndex = 9;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 10;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(231, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            //
            // labelActiveFlag
            //
            this.labelActiveFlag.AutoSize = true;
            this.labelActiveFlag.Location = new System.Drawing.Point(11, 128);
            this.labelActiveFlag.Name = "labelActiveFlag";
            this.labelActiveFlag.Size = new System.Drawing.Size(71, 13);
            this.labelActiveFlag.TabIndex = 12;
            this.labelActiveFlag.Text = "Active Flag:";
            //
            //checkBoxActiveFlag
            //
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(231, 128);
            this.checkBoxActiveFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxActiveFlag.Name = "checkBoxActiveFlag";
            this.checkBoxActiveFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxActiveFlag.TabIndex = 13;
            // 
            // dataGridViewCrudeClientContactMethodRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeClientContactMethodRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeClientContactMethodRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeClientContactMethodRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeClientContactMethodRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeClientContactMethodRef.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeClientContactMethodRef.Name = "dataGridViewCrudeClientContactMethodRef";
            this.dataGridViewCrudeClientContactMethodRef.Size = new System.Drawing.Size(469, 96);
            this.dataGridViewCrudeClientContactMethodRef.TabIndex = 0;
            this.dataGridViewCrudeClientContactMethodRef.ReadOnly = true;
            this.dataGridViewCrudeClientContactMethodRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeClientContactMethodRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(389, 264);

            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeClientContactMethodRefSearch
            // 
            this.buttonCrudeClientContactMethodRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientContactMethodRefSearch.Location = new System.Drawing.Point(289, 264);
            this.buttonCrudeClientContactMethodRefSearch.Name = "buttonCrudeClientContactMethodRefSearch";
            this.buttonCrudeClientContactMethodRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientContactMethodRefSearch.TabIndex = 2;
            this.buttonCrudeClientContactMethodRefSearch.Text = "&Search";
            this.buttonCrudeClientContactMethodRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeClientContactMethodRefSearch.Click += new System.EventHandler(this.buttonCrudeClientContactMethodRefSearch_Click);
            // 
            // buttonCrudeClientContactMethodRefAdd
            // 
            this.buttonCrudeClientContactMethodRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientContactMethodRefAdd.Location = new System.Drawing.Point(189, 264);
            this.buttonCrudeClientContactMethodRefAdd.Name = "buttonCrudeClientContactMethodRefAdd";
            this.buttonCrudeClientContactMethodRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientContactMethodRefAdd.TabIndex = 3;
            this.buttonCrudeClientContactMethodRefAdd.Text = "&Add";
            this.buttonCrudeClientContactMethodRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeClientContactMethodRefAdd.Click += new System.EventHandler(this.buttonCrudeClientContactMethodRefAdd_Click);
            // 
            // buttonCrudeClientContactMethodRefEdit
            // 
            this.buttonCrudeClientContactMethodRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientContactMethodRefEdit.Location = new System.Drawing.Point(89, 264);
            this.buttonCrudeClientContactMethodRefEdit.Name = "buttonCrudeClientContactMethodRefEdit";
            this.buttonCrudeClientContactMethodRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientContactMethodRefEdit.TabIndex = 4;
            this.buttonCrudeClientContactMethodRefEdit.Text = "&Edit";
            this.buttonCrudeClientContactMethodRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeClientContactMethodRefEdit.Click += new System.EventHandler(this.buttonCrudeClientContactMethodRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 292);
            this.Controls.Add(this.buttonCrudeClientContactMethodRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeClientContactMethodRefAdd);
            this.Controls.Add(this.buttonCrudeClientContactMethodRefEdit);
            this.Controls.Add(this.dataGridViewCrudeClientContactMethodRef);
            this.Name = "CrudeClientContactMethodRefSearch";
            this.Text = "Client Contact Method Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientContactMethodRef)).EndInit();
            this.Controls.Add(this.labelClientContactMethodName);
            this.Controls.Add(this.textBoxClientContactMethodName);
            this.Controls.Add(this.labelClientContactMethod);
            this.Controls.Add(this.textBoxClientContactMethod);
            this.Controls.Add(this.labelClientContactMethodDescription);
            this.Controls.Add(this.textBoxClientContactMethodDescription);
            this.Controls.Add(this.labelSortOrder);
            this.Controls.Add(this.maskedTextBoxSortOrder);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelActiveFlag);
            this.Controls.Add(this.checkBoxActiveFlag);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
