namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultUserActivityTypeRefSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeDefaultUserActivityTypeRefSearch;

        private System.Windows.Forms.Button buttonCrudeDefaultUserActivityTypeRefAdd;

        private System.Windows.Forms.Button buttonCrudeDefaultUserActivityTypeRefEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultUserActivityTypeRef;

        private System.Windows.Forms.TextBox textBoxDefaultUserActivityTypeName;

        private System.Windows.Forms.Label labelDefaultUserActivityTypeName;

        private System.Windows.Forms.TextBox textBoxDefaultUserActivityType;

        private System.Windows.Forms.Label labelDefaultUserActivityType;

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
            this.buttonCrudeDefaultUserActivityTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultUserActivityTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultUserActivityTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultUserActivityTypeRef = new System.Windows.Forms.DataGridView();
            this.labelDefaultUserActivityTypeName = new System.Windows.Forms.Label();
            this.textBoxDefaultUserActivityTypeName = new System.Windows.Forms.TextBox();
            this.labelDefaultUserActivityType = new System.Windows.Forms.Label();
            this.textBoxDefaultUserActivityType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultUserActivityTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelDefaultUserActivityTypeName
            //
            this.labelDefaultUserActivityTypeName.AutoSize = true;
            this.labelDefaultUserActivityTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultUserActivityTypeName.Name = "labelDefaultUserActivityTypeName";
            this.labelDefaultUserActivityTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultUserActivityTypeName.TabIndex = 2;
            this.labelDefaultUserActivityTypeName.Text = "Default User Activity Type Name:";
            //
            //textBoxDefaultUserActivityTypeName
            //
            this.textBoxDefaultUserActivityTypeName.Location = new System.Drawing.Point(217, 13);
            this.textBoxDefaultUserActivityTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultUserActivityTypeName.Name = "textBoxDefaultUserActivityTypeName";
            this.textBoxDefaultUserActivityTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultUserActivityTypeName.TabIndex = 3;
            //
            // labelDefaultUserActivityType
            //
            this.labelDefaultUserActivityType.AutoSize = true;
            this.labelDefaultUserActivityType.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultUserActivityType.Name = "labelDefaultUserActivityType";
            this.labelDefaultUserActivityType.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultUserActivityType.TabIndex = 4;
            this.labelDefaultUserActivityType.Text = "Default User Activity Type:";
            //
            //textBoxDefaultUserActivityType
            //
            this.textBoxDefaultUserActivityType.Location = new System.Drawing.Point(217, 36);
            this.textBoxDefaultUserActivityType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultUserActivityType.Name = "textBoxDefaultUserActivityType";
            this.textBoxDefaultUserActivityType.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultUserActivityType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(217, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeDefaultUserActivityTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultUserActivityTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultUserActivityTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultUserActivityTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultUserActivityTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultUserActivityTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeDefaultUserActivityTypeRef.Name = "dataGridViewCrudeDefaultUserActivityTypeRef";
            this.dataGridViewCrudeDefaultUserActivityTypeRef.Size = new System.Drawing.Size(455, 96);
            this.dataGridViewCrudeDefaultUserActivityTypeRef.TabIndex = 0;
            this.dataGridViewCrudeDefaultUserActivityTypeRef.ReadOnly = true;
            this.dataGridViewCrudeDefaultUserActivityTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultUserActivityTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(375, 195);

            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeDefaultUserActivityTypeRefSearch
            // 
            this.buttonCrudeDefaultUserActivityTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultUserActivityTypeRefSearch.Location = new System.Drawing.Point(275, 195);
            this.buttonCrudeDefaultUserActivityTypeRefSearch.Name = "buttonCrudeDefaultUserActivityTypeRefSearch";
            this.buttonCrudeDefaultUserActivityTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultUserActivityTypeRefSearch.TabIndex = 2;
            this.buttonCrudeDefaultUserActivityTypeRefSearch.Text = "&Search";
            this.buttonCrudeDefaultUserActivityTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultUserActivityTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeDefaultUserActivityTypeRefSearch_Click);
            // 
            // buttonCrudeDefaultUserActivityTypeRefAdd
            // 
            this.buttonCrudeDefaultUserActivityTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultUserActivityTypeRefAdd.Location = new System.Drawing.Point(175, 195);
            this.buttonCrudeDefaultUserActivityTypeRefAdd.Name = "buttonCrudeDefaultUserActivityTypeRefAdd";
            this.buttonCrudeDefaultUserActivityTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultUserActivityTypeRefAdd.TabIndex = 3;
            this.buttonCrudeDefaultUserActivityTypeRefAdd.Text = "&Add";
            this.buttonCrudeDefaultUserActivityTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultUserActivityTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeDefaultUserActivityTypeRefAdd_Click);
            // 
            // buttonCrudeDefaultUserActivityTypeRefEdit
            // 
            this.buttonCrudeDefaultUserActivityTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultUserActivityTypeRefEdit.Location = new System.Drawing.Point(75, 195);
            this.buttonCrudeDefaultUserActivityTypeRefEdit.Name = "buttonCrudeDefaultUserActivityTypeRefEdit";
            this.buttonCrudeDefaultUserActivityTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultUserActivityTypeRefEdit.TabIndex = 4;
            this.buttonCrudeDefaultUserActivityTypeRefEdit.Text = "&Edit";
            this.buttonCrudeDefaultUserActivityTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultUserActivityTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeDefaultUserActivityTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 223);
            this.Controls.Add(this.buttonCrudeDefaultUserActivityTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultUserActivityTypeRefAdd);
            this.Controls.Add(this.buttonCrudeDefaultUserActivityTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultUserActivityTypeRef);
            this.Name = "CrudeDefaultUserActivityTypeRefSearch";
            this.Text = "Default User Activity Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultUserActivityTypeRef)).EndInit();
            this.Controls.Add(this.labelDefaultUserActivityTypeName);
            this.Controls.Add(this.textBoxDefaultUserActivityTypeName);
            this.Controls.Add(this.labelDefaultUserActivityType);
            this.Controls.Add(this.textBoxDefaultUserActivityType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
