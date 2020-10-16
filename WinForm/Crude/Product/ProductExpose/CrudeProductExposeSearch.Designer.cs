namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductExposeSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeProductExposeSearch;

        private System.Windows.Forms.Button buttonCrudeProductExposeAdd;

        private System.Windows.Forms.Button buttonCrudeProductExposeEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeProductExpose;

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
            this.buttonCrudeProductExposeAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductExposeEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductExposeSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductExpose = new System.Windows.Forms.DataGridView();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductExpose)).BeginInit();
            this.SuspendLayout();
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 13);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 2;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 13);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 3;
            // 
            // dataGridViewCrudeProductExpose
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductExpose.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductExpose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductExpose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductExpose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductExpose.Location = new System.Drawing.Point(12, 46);
            this.dataGridViewCrudeProductExpose.Name = "dataGridViewCrudeProductExpose";
            this.dataGridViewCrudeProductExpose.Size = new System.Drawing.Size(399, 96);
            this.dataGridViewCrudeProductExpose.TabIndex = 0;
            this.dataGridViewCrudeProductExpose.ReadOnly = true;
            this.dataGridViewCrudeProductExpose.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductExpose_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 149);

            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductExposeSearch
            // 
            this.buttonCrudeProductExposeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductExposeSearch.Location = new System.Drawing.Point(219, 149);
            this.buttonCrudeProductExposeSearch.Name = "buttonCrudeProductExposeSearch";
            this.buttonCrudeProductExposeSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductExposeSearch.TabIndex = 2;
            this.buttonCrudeProductExposeSearch.Text = "&Search";
            this.buttonCrudeProductExposeSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductExposeSearch.Click += new System.EventHandler(this.buttonCrudeProductExposeSearch_Click);
            // 
            // buttonCrudeProductExposeAdd
            // 
            this.buttonCrudeProductExposeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductExposeAdd.Location = new System.Drawing.Point(119, 149);
            this.buttonCrudeProductExposeAdd.Name = "buttonCrudeProductExposeAdd";
            this.buttonCrudeProductExposeAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductExposeAdd.TabIndex = 3;
            this.buttonCrudeProductExposeAdd.Text = "&Add";
            this.buttonCrudeProductExposeAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductExposeAdd.Click += new System.EventHandler(this.buttonCrudeProductExposeAdd_Click);
            // 
            // buttonCrudeProductExposeEdit
            // 
            this.buttonCrudeProductExposeEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductExposeEdit.Location = new System.Drawing.Point(19, 149);
            this.buttonCrudeProductExposeEdit.Name = "buttonCrudeProductExposeEdit";
            this.buttonCrudeProductExposeEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductExposeEdit.TabIndex = 4;
            this.buttonCrudeProductExposeEdit.Text = "&Edit";
            this.buttonCrudeProductExposeEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductExposeEdit.Click += new System.EventHandler(this.buttonCrudeProductExposeEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 177);
            this.Controls.Add(this.buttonCrudeProductExposeSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductExposeAdd);
            this.Controls.Add(this.buttonCrudeProductExposeEdit);
            this.Controls.Add(this.dataGridViewCrudeProductExpose);
            this.Name = "CrudeProductExposeSearch";
            this.Text = "Product Expose Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductExpose)).EndInit();
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
