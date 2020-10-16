namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductInfoSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeProductInfoSearch;

        private System.Windows.Forms.Button buttonCrudeProductInfoAdd;

        private System.Windows.Forms.Button buttonCrudeProductInfoEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeProductInfo;

        private ProductInfoRefCombo productInfoRefCombo;

        private System.Windows.Forms.Label labelProductInfoRefCombo;

        private System.Windows.Forms.TextBox textBoxProductInfoValue;

        private System.Windows.Forms.Label labelProductInfoValue;

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
            this.buttonCrudeProductInfoAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductInfoEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductInfoSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductInfo = new System.Windows.Forms.DataGridView();
            this.labelProductInfoRefCombo = new System.Windows.Forms.Label();
            this.productInfoRefCombo = new ProductInfoRefCombo();
            this.labelProductInfoValue = new System.Windows.Forms.Label();
            this.textBoxProductInfoValue = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductInfo)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductInfoRefCombo
            //
            this.labelProductInfoRefCombo.AutoSize = true;
            this.labelProductInfoRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductInfoRefCombo.Name = "labelProductInfoRefCombo";
            this.labelProductInfoRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductInfoRefCombo.TabIndex = 2;
            this.labelProductInfoRefCombo.Text = "Product Info:";
            //
            //productInfoRefCombo
            //
            this.productInfoRefCombo.Location = new System.Drawing.Point(140, 13);
            this.productInfoRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productInfoRefCombo.Name = "productInfoRefCombo";
            this.productInfoRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productInfoRefCombo.TabIndex = 3;
            //
            // labelProductInfoValue
            //
            this.labelProductInfoValue.AutoSize = true;
            this.labelProductInfoValue.Location = new System.Drawing.Point(11, 36);
            this.labelProductInfoValue.Name = "labelProductInfoValue";
            this.labelProductInfoValue.Size = new System.Drawing.Size(71, 13);
            this.labelProductInfoValue.TabIndex = 4;
            this.labelProductInfoValue.Text = "Product Info Value:";
            //
            //textBoxProductInfoValue
            //
            this.textBoxProductInfoValue.Location = new System.Drawing.Point(140, 36);
            this.textBoxProductInfoValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductInfoValue.Name = "textBoxProductInfoValue";
            this.textBoxProductInfoValue.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductInfoValue.TabIndex = 5;
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
            // 
            // dataGridViewCrudeProductInfo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductInfo.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProductInfo.Name = "dataGridViewCrudeProductInfo";
            this.dataGridViewCrudeProductInfo.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeProductInfo.TabIndex = 0;
            this.dataGridViewCrudeProductInfo.ReadOnly = true;
            this.dataGridViewCrudeProductInfo.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductInfo_DoubleClick);
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
            // buttonCrudeProductInfoSearch
            // 
            this.buttonCrudeProductInfoSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductInfoSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeProductInfoSearch.Name = "buttonCrudeProductInfoSearch";
            this.buttonCrudeProductInfoSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductInfoSearch.TabIndex = 2;
            this.buttonCrudeProductInfoSearch.Text = "&Search";
            this.buttonCrudeProductInfoSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductInfoSearch.Click += new System.EventHandler(this.buttonCrudeProductInfoSearch_Click);
            // 
            // buttonCrudeProductInfoAdd
            // 
            this.buttonCrudeProductInfoAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductInfoAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeProductInfoAdd.Name = "buttonCrudeProductInfoAdd";
            this.buttonCrudeProductInfoAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductInfoAdd.TabIndex = 3;
            this.buttonCrudeProductInfoAdd.Text = "&Add";
            this.buttonCrudeProductInfoAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductInfoAdd.Click += new System.EventHandler(this.buttonCrudeProductInfoAdd_Click);
            // 
            // buttonCrudeProductInfoEdit
            // 
            this.buttonCrudeProductInfoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductInfoEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeProductInfoEdit.Name = "buttonCrudeProductInfoEdit";
            this.buttonCrudeProductInfoEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductInfoEdit.TabIndex = 4;
            this.buttonCrudeProductInfoEdit.Text = "&Edit";
            this.buttonCrudeProductInfoEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductInfoEdit.Click += new System.EventHandler(this.buttonCrudeProductInfoEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeProductInfoSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductInfoAdd);
            this.Controls.Add(this.buttonCrudeProductInfoEdit);
            this.Controls.Add(this.dataGridViewCrudeProductInfo);
            this.Name = "CrudeProductInfoSearch";
            this.Text = "Product Info Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductInfo)).EndInit();
            this.Controls.Add(this.labelProductInfoRefCombo);
            this.Controls.Add(this.productInfoRefCombo);
            this.Controls.Add(this.labelProductInfoValue);
            this.Controls.Add(this.textBoxProductInfoValue);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
