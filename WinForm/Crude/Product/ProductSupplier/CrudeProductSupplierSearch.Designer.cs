namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductSupplierSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeProductSupplierSearch;

        private System.Windows.Forms.Button buttonCrudeProductSupplierAdd;

        private System.Windows.Forms.Button buttonCrudeProductSupplierEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeProductSupplier;

        private System.Windows.Forms.TextBox textBoxSupplierName;

        private System.Windows.Forms.Label labelSupplierName;

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
            this.buttonCrudeProductSupplierAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductSupplierEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductSupplierSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductSupplier = new System.Windows.Forms.DataGridView();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.textBoxSupplierName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductSupplier)).BeginInit();
            this.SuspendLayout();
            //
            // labelSupplierName
            //
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Location = new System.Drawing.Point(11, 13);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(71, 13);
            this.labelSupplierName.TabIndex = 2;
            this.labelSupplierName.Text = "Supplier Name:";
            //
            //textBoxSupplierName
            //
            this.textBoxSupplierName.Location = new System.Drawing.Point(140, 13);
            this.textBoxSupplierName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSupplierName.Name = "textBoxSupplierName";
            this.textBoxSupplierName.Size = new System.Drawing.Size(250, 20);
            this.textBoxSupplierName.TabIndex = 3;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 36);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 5;
            // 
            // dataGridViewCrudeProductSupplier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductSupplier.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewCrudeProductSupplier.Name = "dataGridViewCrudeProductSupplier";
            this.dataGridViewCrudeProductSupplier.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeProductSupplier.TabIndex = 0;
            this.dataGridViewCrudeProductSupplier.ReadOnly = true;
            this.dataGridViewCrudeProductSupplier.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductSupplier_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 172);

            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductSupplierSearch
            // 
            this.buttonCrudeProductSupplierSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductSupplierSearch.Location = new System.Drawing.Point(198, 172);
            this.buttonCrudeProductSupplierSearch.Name = "buttonCrudeProductSupplierSearch";
            this.buttonCrudeProductSupplierSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductSupplierSearch.TabIndex = 2;
            this.buttonCrudeProductSupplierSearch.Text = "&Search";
            this.buttonCrudeProductSupplierSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductSupplierSearch.Click += new System.EventHandler(this.buttonCrudeProductSupplierSearch_Click);
            // 
            // buttonCrudeProductSupplierAdd
            // 
            this.buttonCrudeProductSupplierAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductSupplierAdd.Location = new System.Drawing.Point(98, 172);
            this.buttonCrudeProductSupplierAdd.Name = "buttonCrudeProductSupplierAdd";
            this.buttonCrudeProductSupplierAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductSupplierAdd.TabIndex = 3;
            this.buttonCrudeProductSupplierAdd.Text = "&Add";
            this.buttonCrudeProductSupplierAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductSupplierAdd.Click += new System.EventHandler(this.buttonCrudeProductSupplierAdd_Click);
            // 
            // buttonCrudeProductSupplierEdit
            // 
            this.buttonCrudeProductSupplierEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductSupplierEdit.Location = new System.Drawing.Point(-2, 172);
            this.buttonCrudeProductSupplierEdit.Name = "buttonCrudeProductSupplierEdit";
            this.buttonCrudeProductSupplierEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductSupplierEdit.TabIndex = 4;
            this.buttonCrudeProductSupplierEdit.Text = "&Edit";
            this.buttonCrudeProductSupplierEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductSupplierEdit.Click += new System.EventHandler(this.buttonCrudeProductSupplierEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 200);
            this.Controls.Add(this.buttonCrudeProductSupplierSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductSupplierAdd);
            this.Controls.Add(this.buttonCrudeProductSupplierEdit);
            this.Controls.Add(this.dataGridViewCrudeProductSupplier);
            this.Name = "CrudeProductSupplierSearch";
            this.Text = "Product Supplier Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductSupplier)).EndInit();
            this.Controls.Add(this.labelSupplierName);
            this.Controls.Add(this.textBoxSupplierName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
