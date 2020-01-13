namespace SolutionNorSolutionPim.UserInterface
{
    partial class ProductPreview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.treeViewHierarchy = new System.Windows.Forms.TreeView();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.tabControlProduct = new System.Windows.Forms.TabControl();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.tabPageProductAttribute = new System.Windows.Forms.TabPage();
            this.dataGridViewProductAttribute = new System.Windows.Forms.DataGridView();
            this.tabPageProductIdentifier = new System.Windows.Forms.TabPage();
            this.dataGridViewProductIdentifier = new System.Windows.Forms.DataGridView();
            this.tabPageProductInfo = new System.Windows.Forms.TabPage();
            this.dataGridViewProductInfo = new System.Windows.Forms.DataGridView();
            this.tabPageProductImage = new System.Windows.Forms.TabPage();
            this.dataGridViewProductImage = new System.Windows.Forms.DataGridView();
            this.tabPageProductDocumentation = new System.Windows.Forms.TabPage();
            this.dataGridViewProductDocumentation = new System.Windows.Forms.DataGridView();
            this.dataGridViewProducts1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewProductCategoryDocumentation = new System.Windows.Forms.DataGridView();
            this.textBoxProductCategoryCode = new System.Windows.Forms.TextBox();
            this.textBoxProductCategoryName = new System.Windows.Forms.TextBox();
            this.labelProductCategoryCode = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.splitMain ) ).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBoxImage ) ).BeginInit();
            this.tabControlProduct.SuspendLayout();
            this.tabPageProduct.SuspendLayout();
            this.tabPageProductAttribute.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewProductAttribute ) ).BeginInit();
            this.tabPageProductIdentifier.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewProductIdentifier ) ).BeginInit();
            this.tabPageProductInfo.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewProductInfo ) ).BeginInit();
            this.tabPageProductImage.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewProductImage ) ).BeginInit();
            this.tabPageProductDocumentation.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewProductDocumentation ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewProducts1 ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewProductCategoryDocumentation ) ).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripTextBoxSearch});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(812, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBoxSearch
            // 
            this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            this.toolStripTextBoxSearch.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBoxSearch_KeyPress);
            // 
            // splitMain
            // 
            this.splitMain.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.splitMain.Location = new System.Drawing.Point(0, 28);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.treeViewHierarchy);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.pictureBoxImage);
            this.splitMain.Panel2.Controls.Add(this.tabControlProduct);
            this.splitMain.Panel2.Controls.Add(this.dataGridViewProducts1);
            this.splitMain.Panel2.Controls.Add(this.dataGridViewProductCategoryDocumentation);
            this.splitMain.Panel2.Controls.Add(this.textBoxProductCategoryCode);
            this.splitMain.Panel2.Controls.Add(this.textBoxProductCategoryName);
            this.splitMain.Panel2.Controls.Add(this.labelProductCategoryCode);
            this.splitMain.Size = new System.Drawing.Size(812, 433);
            this.splitMain.SplitterDistance = 131;
            this.splitMain.TabIndex = 3;
            // 
            // treeViewHierarchy
            // 
            this.treeViewHierarchy.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.treeViewHierarchy.Location = new System.Drawing.Point(3, 3);
            this.treeViewHierarchy.Name = "treeViewHierarchy";
            this.treeViewHierarchy.Size = new System.Drawing.Size(125, 427);
            this.treeViewHierarchy.TabIndex = 1;
            this.treeViewHierarchy.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewHierarchy_NodeMouseClick);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.pictureBoxImage.Location = new System.Drawing.Point(382, 32);
            this.pictureBoxImage.MaximumSize = new System.Drawing.Size(291, 101);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(291, 101);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxImage.TabIndex = 34;
            this.pictureBoxImage.TabStop = false;
            // 
            // tabControlProduct
            // 
            this.tabControlProduct.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.tabControlProduct.Controls.Add(this.tabPageProduct);
            this.tabControlProduct.Controls.Add(this.tabPageProductAttribute);
            this.tabControlProduct.Controls.Add(this.tabPageProductIdentifier);
            this.tabControlProduct.Controls.Add(this.tabPageProductInfo);
            this.tabControlProduct.Controls.Add(this.tabPageProductImage);
            this.tabControlProduct.Controls.Add(this.tabPageProductDocumentation);
            this.tabControlProduct.Location = new System.Drawing.Point(6, 258);
            this.tabControlProduct.Name = "tabControlProduct";
            this.tabControlProduct.SelectedIndex = 0;
            this.tabControlProduct.Size = new System.Drawing.Size(671, 172);
            this.tabControlProduct.TabIndex = 0;
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.labelProductName);
            this.tabPageProduct.Controls.Add(this.textBoxProductName);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 22);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(663, 146);
            this.tabPageProduct.TabIndex = 0;
            this.tabPageProduct.Text = "Product";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(6, 12);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(78, 13);
            this.labelProductName.TabIndex = 12;
            this.labelProductName.Text = "Product Name:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(135, 12);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(200, 20);
            this.textBoxProductName.TabIndex = 13;
            // 
            // tabPageProductAttribute
            // 
            this.tabPageProductAttribute.Controls.Add(this.dataGridViewProductAttribute);
            this.tabPageProductAttribute.Location = new System.Drawing.Point(4, 22);
            this.tabPageProductAttribute.Name = "tabPageProductAttribute";
            this.tabPageProductAttribute.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProductAttribute.Size = new System.Drawing.Size(663, 146);
            this.tabPageProductAttribute.TabIndex = 1;
            this.tabPageProductAttribute.Text = "Attributes";
            this.tabPageProductAttribute.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProductAttribute
            // 
            this.dataGridViewProductAttribute.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.dataGridViewProductAttribute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductAttribute.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProductAttribute.Name = "dataGridViewProductAttribute";
            this.dataGridViewProductAttribute.Size = new System.Drawing.Size(661, 137);
            this.dataGridViewProductAttribute.TabIndex = 1;
            // 
            // tabPageProductIdentifier
            // 
            this.tabPageProductIdentifier.Controls.Add(this.dataGridViewProductIdentifier);
            this.tabPageProductIdentifier.Location = new System.Drawing.Point(4, 22);
            this.tabPageProductIdentifier.Name = "tabPageProductIdentifier";
            this.tabPageProductIdentifier.Size = new System.Drawing.Size(663, 146);
            this.tabPageProductIdentifier.TabIndex = 2;
            this.tabPageProductIdentifier.Text = "Identifiers";
            this.tabPageProductIdentifier.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProductIdentifier
            // 
            this.dataGridViewProductIdentifier.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.dataGridViewProductIdentifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductIdentifier.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProductIdentifier.Name = "dataGridViewProductIdentifier";
            this.dataGridViewProductIdentifier.Size = new System.Drawing.Size(657, 138);
            this.dataGridViewProductIdentifier.TabIndex = 2;
            // 
            // tabPageProductInfo
            // 
            this.tabPageProductInfo.Controls.Add(this.dataGridViewProductInfo);
            this.tabPageProductInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageProductInfo.Name = "tabPageProductInfo";
            this.tabPageProductInfo.Size = new System.Drawing.Size(663, 146);
            this.tabPageProductInfo.TabIndex = 3;
            this.tabPageProductInfo.Text = "Info";
            this.tabPageProductInfo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProductInfo
            // 
            this.dataGridViewProductInfo.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.dataGridViewProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductInfo.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProductInfo.Name = "dataGridViewProductInfo";
            this.dataGridViewProductInfo.Size = new System.Drawing.Size(660, 140);
            this.dataGridViewProductInfo.TabIndex = 2;
            // 
            // tabPageProductImage
            // 
            this.tabPageProductImage.Controls.Add(this.dataGridViewProductImage);
            this.tabPageProductImage.Location = new System.Drawing.Point(4, 22);
            this.tabPageProductImage.Name = "tabPageProductImage";
            this.tabPageProductImage.Size = new System.Drawing.Size(663, 146);
            this.tabPageProductImage.TabIndex = 4;
            this.tabPageProductImage.Text = "Images";
            this.tabPageProductImage.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProductImage
            // 
            this.dataGridViewProductImage.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.dataGridViewProductImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductImage.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProductImage.Name = "dataGridViewProductImage";
            this.dataGridViewProductImage.Size = new System.Drawing.Size(657, 138);
            this.dataGridViewProductImage.TabIndex = 2;
            // 
            // tabPageProductDocumentation
            // 
            this.tabPageProductDocumentation.Controls.Add(this.dataGridViewProductDocumentation);
            this.tabPageProductDocumentation.Location = new System.Drawing.Point(4, 22);
            this.tabPageProductDocumentation.Name = "tabPageProductDocumentation";
            this.tabPageProductDocumentation.Size = new System.Drawing.Size(663, 146);
            this.tabPageProductDocumentation.TabIndex = 5;
            this.tabPageProductDocumentation.Text = "Documentation";
            this.tabPageProductDocumentation.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProductDocumentation
            // 
            this.dataGridViewProductDocumentation.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.dataGridViewProductDocumentation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductDocumentation.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProductDocumentation.Name = "dataGridViewProductDocumentation";
            this.dataGridViewProductDocumentation.Size = new System.Drawing.Size(660, 138);
            this.dataGridViewProductDocumentation.TabIndex = 2;
            // 
            // dataGridViewProducts1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(( ( int ) ( ( ( byte ) ( 192 ) ) ) ), ( ( int ) ( ( ( byte ) ( 192 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ));
            this.dataGridViewProducts1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProducts1.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.dataGridViewProducts1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts1.Location = new System.Drawing.Point(6, 137);
            this.dataGridViewProducts1.Name = "dataGridViewProducts1";
            this.dataGridViewProducts1.Size = new System.Drawing.Size(667, 115);
            this.dataGridViewProducts1.TabIndex = 5;
            this.dataGridViewProducts1.SelectionChanged += new System.EventHandler(this.dataGridViewProducts1_SelectionChanged);
            // 
            // dataGridViewProductCategoryDocumentation
            // 
            this.dataGridViewProductCategoryDocumentation.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.dataGridViewProductCategoryDocumentation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductCategoryDocumentation.Location = new System.Drawing.Point(6, 32);
            this.dataGridViewProductCategoryDocumentation.Name = "dataGridViewProductCategoryDocumentation";
            this.dataGridViewProductCategoryDocumentation.Size = new System.Drawing.Size(368, 99);
            this.dataGridViewProductCategoryDocumentation.TabIndex = 0;
            // 
            // textBoxProductCategoryCode
            // 
            this.textBoxProductCategoryCode.Location = new System.Drawing.Point(129, 6);
            this.textBoxProductCategoryCode.Name = "textBoxProductCategoryCode";
            this.textBoxProductCategoryCode.Size = new System.Drawing.Size(128, 20);
            this.textBoxProductCategoryCode.TabIndex = 31;
            // 
            // textBoxProductCategoryName
            // 
            this.textBoxProductCategoryName.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.textBoxProductCategoryName.Location = new System.Drawing.Point(263, 6);
            this.textBoxProductCategoryName.Name = "textBoxProductCategoryName";
            this.textBoxProductCategoryName.Size = new System.Drawing.Size(411, 20);
            this.textBoxProductCategoryName.TabIndex = 33;
            // 
            // labelProductCategoryCode
            // 
            this.labelProductCategoryCode.AutoSize = true;
            this.labelProductCategoryCode.Location = new System.Drawing.Point(3, 6);
            this.labelProductCategoryCode.Name = "labelProductCategoryCode";
            this.labelProductCategoryCode.Size = new System.Drawing.Size(120, 13);
            this.labelProductCategoryCode.TabIndex = 30;
            this.labelProductCategoryCode.Text = "Product Category Code:";
            // 
            // ProductPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 461);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.toolStrip);
            this.Name = "ProductPreview";
            this.Text = "Product Preview";
            this.Load += new System.EventHandler(this.ProductPreview_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            this.splitMain.Panel2.PerformLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.splitMain ) ).EndInit();
            this.splitMain.ResumeLayout(false);
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBoxImage ) ).EndInit();
            this.tabControlProduct.ResumeLayout(false);
            this.tabPageProduct.ResumeLayout(false);
            this.tabPageProduct.PerformLayout();
            this.tabPageProductAttribute.ResumeLayout(false);
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewProductAttribute ) ).EndInit();
            this.tabPageProductIdentifier.ResumeLayout(false);
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewProductIdentifier ) ).EndInit();
            this.tabPageProductInfo.ResumeLayout(false);
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewProductInfo ) ).EndInit();
            this.tabPageProductImage.ResumeLayout(false);
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewProductImage ) ).EndInit();
            this.tabPageProductDocumentation.ResumeLayout(false);
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewProductDocumentation ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewProducts1 ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewProductCategoryDocumentation ) ).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TreeView treeViewHierarchy;
        private System.Windows.Forms.TabControl tabControlProduct;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TabPage tabPageProductAttribute;
        private System.Windows.Forms.DataGridView dataGridViewProductAttribute;
        private System.Windows.Forms.TabPage tabPageProductIdentifier;
        private System.Windows.Forms.DataGridView dataGridViewProductIdentifier;
        private System.Windows.Forms.TabPage tabPageProductInfo;
        private System.Windows.Forms.DataGridView dataGridViewProductInfo;
        private System.Windows.Forms.TabPage tabPageProductImage;
        private System.Windows.Forms.DataGridView dataGridViewProductImage;
        private System.Windows.Forms.TabPage tabPageProductDocumentation;
        private System.Windows.Forms.DataGridView dataGridViewProductDocumentation;
        private System.Windows.Forms.Label labelProductCategoryCode;
        private System.Windows.Forms.TextBox textBoxProductCategoryCode;
        private System.Windows.Forms.TextBox textBoxProductCategoryName;
        private System.Windows.Forms.DataGridView dataGridViewProductCategoryDocumentation;
        private System.Windows.Forms.DataGridView dataGridViewProducts1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxImage;
    }
}
