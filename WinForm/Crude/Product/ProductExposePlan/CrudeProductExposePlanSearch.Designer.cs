namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductExposePlanSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeProductExposePlanSearch;

        private System.Windows.Forms.Button buttonCrudeProductExposePlanAdd;

        private System.Windows.Forms.Button buttonCrudeProductExposePlanEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeProductExposePlan;

        private ProductExposeSetTypeRefCombo productExposeSetTypeRefCombo;

        private System.Windows.Forms.Label labelProductExposeSetTypeRefCombo;

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
            this.buttonCrudeProductExposePlanAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductExposePlanEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductExposePlanSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductExposePlan = new System.Windows.Forms.DataGridView();
            this.labelProductExposeSetTypeRefCombo = new System.Windows.Forms.Label();
            this.productExposeSetTypeRefCombo = new ProductExposeSetTypeRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductExposePlan)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductExposeSetTypeRefCombo
            //
            this.labelProductExposeSetTypeRefCombo.AutoSize = true;
            this.labelProductExposeSetTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductExposeSetTypeRefCombo.Name = "labelProductExposeSetTypeRefCombo";
            this.labelProductExposeSetTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductExposeSetTypeRefCombo.TabIndex = 2;
            this.labelProductExposeSetTypeRefCombo.Text = "Product Expose Set Type:";
            //
            //productExposeSetTypeRefCombo
            //
            this.productExposeSetTypeRefCombo.Location = new System.Drawing.Point(161, 13);
            this.productExposeSetTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productExposeSetTypeRefCombo.Name = "productExposeSetTypeRefCombo";
            this.productExposeSetTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productExposeSetTypeRefCombo.TabIndex = 3;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 36);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 4;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 36);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 5;
            // 
            // dataGridViewCrudeProductExposePlan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductExposePlan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductExposePlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductExposePlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductExposePlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductExposePlan.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewCrudeProductExposePlan.Name = "dataGridViewCrudeProductExposePlan";
            this.dataGridViewCrudeProductExposePlan.Size = new System.Drawing.Size(399, 96);
            this.dataGridViewCrudeProductExposePlan.TabIndex = 0;
            this.dataGridViewCrudeProductExposePlan.ReadOnly = true;
            this.dataGridViewCrudeProductExposePlan.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductExposePlan_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 172);

            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductExposePlanSearch
            // 
            this.buttonCrudeProductExposePlanSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductExposePlanSearch.Location = new System.Drawing.Point(219, 172);
            this.buttonCrudeProductExposePlanSearch.Name = "buttonCrudeProductExposePlanSearch";
            this.buttonCrudeProductExposePlanSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductExposePlanSearch.TabIndex = 2;
            this.buttonCrudeProductExposePlanSearch.Text = "&Search";
            this.buttonCrudeProductExposePlanSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductExposePlanSearch.Click += new System.EventHandler(this.buttonCrudeProductExposePlanSearch_Click);
            // 
            // buttonCrudeProductExposePlanAdd
            // 
            this.buttonCrudeProductExposePlanAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductExposePlanAdd.Location = new System.Drawing.Point(119, 172);
            this.buttonCrudeProductExposePlanAdd.Name = "buttonCrudeProductExposePlanAdd";
            this.buttonCrudeProductExposePlanAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductExposePlanAdd.TabIndex = 3;
            this.buttonCrudeProductExposePlanAdd.Text = "&Add";
            this.buttonCrudeProductExposePlanAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductExposePlanAdd.Click += new System.EventHandler(this.buttonCrudeProductExposePlanAdd_Click);
            // 
            // buttonCrudeProductExposePlanEdit
            // 
            this.buttonCrudeProductExposePlanEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductExposePlanEdit.Location = new System.Drawing.Point(19, 172);
            this.buttonCrudeProductExposePlanEdit.Name = "buttonCrudeProductExposePlanEdit";
            this.buttonCrudeProductExposePlanEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductExposePlanEdit.TabIndex = 4;
            this.buttonCrudeProductExposePlanEdit.Text = "&Edit";
            this.buttonCrudeProductExposePlanEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductExposePlanEdit.Click += new System.EventHandler(this.buttonCrudeProductExposePlanEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 200);
            this.Controls.Add(this.buttonCrudeProductExposePlanSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductExposePlanAdd);
            this.Controls.Add(this.buttonCrudeProductExposePlanEdit);
            this.Controls.Add(this.dataGridViewCrudeProductExposePlan);
            this.Name = "CrudeProductExposePlanSearch";
            this.Text = "Product Expose Plan Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductExposePlan)).EndInit();
            this.Controls.Add(this.labelProductExposeSetTypeRefCombo);
            this.Controls.Add(this.productExposeSetTypeRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
