namespace SolutionNorSolutionPim.UserInterface
{

    partial class ProductMaintenance
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
            this.tabControlProduct = new System.Windows.Forms.TabControl();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.labelStateRefCombo = new System.Windows.Forms.Label();
            this.labelDateTimeProduct = new System.Windows.Forms.Label();
            this.dateTimePickerProduct = new System.Windows.Forms.DateTimePicker();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.tabPageProductAttribute = new System.Windows.Forms.TabPage();
            this.buttonProductAttributeAdd = new System.Windows.Forms.Button();
            this.buttonProductAttributeEdit = new System.Windows.Forms.Button();
            this.dataGridViewProductAttribute = new System.Windows.Forms.DataGridView();
            this.tabPageProductIdentifier = new System.Windows.Forms.TabPage();
            this.buttonProductIdentifierAdd = new System.Windows.Forms.Button();
            this.buttonProductIdentifierEdit = new System.Windows.Forms.Button();
            this.dataGridViewProductIdentifier = new System.Windows.Forms.DataGridView();
            this.tabPageProductInfo = new System.Windows.Forms.TabPage();
            this.buttonProductInfoAdd = new System.Windows.Forms.Button();
            this.buttonProductInfoEdit = new System.Windows.Forms.Button();
            this.dataGridViewProductInfo = new System.Windows.Forms.DataGridView();
            this.tabPageProductImage = new System.Windows.Forms.TabPage();
            this.buttonProductImageAdd = new System.Windows.Forms.Button();
            this.buttonProductImageEdit = new System.Windows.Forms.Button();
            this.dataGridViewProductImage = new System.Windows.Forms.DataGridView();
            this.tabPageProductDocumentation = new System.Windows.Forms.TabPage();
            this.buttonProductDocumentationAdd = new System.Windows.Forms.Button();
            this.buttonProductDocumentationEdit = new System.Windows.Forms.Button();
            this.dataGridViewProductDocumentation = new System.Windows.Forms.DataGridView();
            this.tabPageProductHistory = new System.Windows.Forms.TabPage();
            this.dataGridViewProductHistory = new System.Windows.Forms.DataGridView();
            this.buttonProductHistory = new System.Windows.Forms.Button();
            this.buttonProductSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.stateRefComboProduct = new SolutionNorSolutionPim.UserInterface.DefaultStateRefCombo();
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
            this.tabPageProductHistory.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewProductHistory ) ).BeginInit();
            this.SuspendLayout();
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
            this.tabControlProduct.Controls.Add(this.tabPageProductHistory);
            this.tabControlProduct.Location = new System.Drawing.Point(12, 12);
            this.tabControlProduct.Name = "tabControlProduct";
            this.tabControlProduct.SelectedIndex = 0;
            this.tabControlProduct.Size = new System.Drawing.Size(592, 252);
            this.tabControlProduct.TabIndex = 1;
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.stateRefComboProduct);
            this.tabPageProduct.Controls.Add(this.labelStateRefCombo);
            this.tabPageProduct.Controls.Add(this.labelDateTimeProduct);
            this.tabPageProduct.Controls.Add(this.dateTimePickerProduct);
            this.tabPageProduct.Controls.Add(this.labelProductName);
            this.tabPageProduct.Controls.Add(this.textBoxProductName);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 22);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(584, 226);
            this.tabPageProduct.TabIndex = 0;
            this.tabPageProduct.Text = "Product";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // labelStateRefCombo
            // 
            this.labelStateRefCombo.AutoSize = true;
            this.labelStateRefCombo.Location = new System.Drawing.Point(6, 64);
            this.labelStateRefCombo.Name = "labelStateRefCombo";
            this.labelStateRefCombo.Size = new System.Drawing.Size(35, 13);
            this.labelStateRefCombo.TabIndex = 18;
            this.labelStateRefCombo.Text = "State:";
            // 
            // labelDateTimeProduct
            // 
            this.labelDateTimeProduct.AutoSize = true;
            this.labelDateTimeProduct.Location = new System.Drawing.Point(6, 38);
            this.labelDateTimeProduct.Name = "labelDateTimeProduct";
            this.labelDateTimeProduct.Size = new System.Drawing.Size(59, 13);
            this.labelDateTimeProduct.TabIndex = 16;
            this.labelDateTimeProduct.Text = "Date Time:";
            // 
            // dateTimePickerProduct
            // 
            this.dateTimePickerProduct.Checked = false;
            this.dateTimePickerProduct.Location = new System.Drawing.Point(135, 38);
            this.dateTimePickerProduct.Name = "dateTimePickerProduct";
            this.dateTimePickerProduct.ShowCheckBox = true;
            this.dateTimePickerProduct.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerProduct.TabIndex = 17;
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
            this.tabPageProductAttribute.Controls.Add(this.buttonProductAttributeAdd);
            this.tabPageProductAttribute.Controls.Add(this.buttonProductAttributeEdit);
            this.tabPageProductAttribute.Controls.Add(this.dataGridViewProductAttribute);
            this.tabPageProductAttribute.Location = new System.Drawing.Point(4, 22);
            this.tabPageProductAttribute.Name = "tabPageProductAttribute";
            this.tabPageProductAttribute.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProductAttribute.Size = new System.Drawing.Size(584, 226);
            this.tabPageProductAttribute.TabIndex = 1;
            this.tabPageProductAttribute.Text = "Attributes";
            this.tabPageProductAttribute.UseVisualStyleBackColor = true;
            // 
            // buttonProductAttributeAdd
            // 
            this.buttonProductAttributeAdd.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonProductAttributeAdd.Location = new System.Drawing.Point(391, 197);
            this.buttonProductAttributeAdd.Name = "buttonProductAttributeAdd";
            this.buttonProductAttributeAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonProductAttributeAdd.TabIndex = 9;
            this.buttonProductAttributeAdd.Text = "&Add";
            this.buttonProductAttributeAdd.UseVisualStyleBackColor = true;
            this.buttonProductAttributeAdd.Click += new System.EventHandler(this.buttonProductAttributeAdd_Click);
            // 
            // buttonProductAttributeEdit
            // 
            this.buttonProductAttributeEdit.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonProductAttributeEdit.Location = new System.Drawing.Point(489, 197);
            this.buttonProductAttributeEdit.Name = "buttonProductAttributeEdit";
            this.buttonProductAttributeEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonProductAttributeEdit.TabIndex = 10;
            this.buttonProductAttributeEdit.Text = "&Edit";
            this.buttonProductAttributeEdit.UseVisualStyleBackColor = true;
            this.buttonProductAttributeEdit.Click += new System.EventHandler(this.buttonProductAttributeEdit_Click);
            // 
            // dataGridViewProductAttribute
            // 
            this.dataGridViewProductAttribute.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.dataGridViewProductAttribute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductAttribute.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProductAttribute.Name = "dataGridViewProductAttribute";
            this.dataGridViewProductAttribute.Size = new System.Drawing.Size(578, 188);
            this.dataGridViewProductAttribute.TabIndex = 1;
            // 
            // tabPageProductIdentifier
            // 
            this.tabPageProductIdentifier.Controls.Add(this.buttonProductIdentifierAdd);
            this.tabPageProductIdentifier.Controls.Add(this.buttonProductIdentifierEdit);
            this.tabPageProductIdentifier.Controls.Add(this.dataGridViewProductIdentifier);
            this.tabPageProductIdentifier.Location = new System.Drawing.Point(4, 22);
            this.tabPageProductIdentifier.Name = "tabPageProductIdentifier";
            this.tabPageProductIdentifier.Size = new System.Drawing.Size(584, 226);
            this.tabPageProductIdentifier.TabIndex = 2;
            this.tabPageProductIdentifier.Text = "Identifiers";
            this.tabPageProductIdentifier.UseVisualStyleBackColor = true;
            // 
            // buttonProductIdentifierAdd
            // 
            this.buttonProductIdentifierAdd.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonProductIdentifierAdd.Location = new System.Drawing.Point(391, 197);
            this.buttonProductIdentifierAdd.Name = "buttonProductIdentifierAdd";
            this.buttonProductIdentifierAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonProductIdentifierAdd.TabIndex = 7;
            this.buttonProductIdentifierAdd.Text = "&Add";
            this.buttonProductIdentifierAdd.UseVisualStyleBackColor = true;
            this.buttonProductIdentifierAdd.Click += new System.EventHandler(this.buttonProductIdentifierAdd_Click);
            // 
            // buttonProductIdentifierEdit
            // 
            this.buttonProductIdentifierEdit.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonProductIdentifierEdit.Location = new System.Drawing.Point(489, 197);
            this.buttonProductIdentifierEdit.Name = "buttonProductIdentifierEdit";
            this.buttonProductIdentifierEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonProductIdentifierEdit.TabIndex = 8;
            this.buttonProductIdentifierEdit.Text = "&Edit";
            this.buttonProductIdentifierEdit.UseVisualStyleBackColor = true;
            this.buttonProductIdentifierEdit.Click += new System.EventHandler(this.buttonProductIdentifierEdit_Click);
            // 
            // dataGridViewProductIdentifier
            // 
            this.dataGridViewProductIdentifier.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.dataGridViewProductIdentifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductIdentifier.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProductIdentifier.Name = "dataGridViewProductIdentifier";
            this.dataGridViewProductIdentifier.Size = new System.Drawing.Size(578, 188);
            this.dataGridViewProductIdentifier.TabIndex = 2;
            // 
            // tabPageProductInfo
            // 
            this.tabPageProductInfo.Controls.Add(this.buttonProductInfoAdd);
            this.tabPageProductInfo.Controls.Add(this.buttonProductInfoEdit);
            this.tabPageProductInfo.Controls.Add(this.dataGridViewProductInfo);
            this.tabPageProductInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageProductInfo.Name = "tabPageProductInfo";
            this.tabPageProductInfo.Size = new System.Drawing.Size(584, 226);
            this.tabPageProductInfo.TabIndex = 3;
            this.tabPageProductInfo.Text = "Info";
            this.tabPageProductInfo.UseVisualStyleBackColor = true;
            // 
            // buttonProductInfoAdd
            // 
            this.buttonProductInfoAdd.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonProductInfoAdd.Location = new System.Drawing.Point(391, 197);
            this.buttonProductInfoAdd.Name = "buttonProductInfoAdd";
            this.buttonProductInfoAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonProductInfoAdd.TabIndex = 9;
            this.buttonProductInfoAdd.Text = "&Add";
            this.buttonProductInfoAdd.UseVisualStyleBackColor = true;
            this.buttonProductInfoAdd.Click += new System.EventHandler(this.buttonProductInfoAdd_Click);
            // 
            // buttonProductInfoEdit
            // 
            this.buttonProductInfoEdit.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonProductInfoEdit.Location = new System.Drawing.Point(489, 197);
            this.buttonProductInfoEdit.Name = "buttonProductInfoEdit";
            this.buttonProductInfoEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonProductInfoEdit.TabIndex = 10;
            this.buttonProductInfoEdit.Text = "&Edit";
            this.buttonProductInfoEdit.UseVisualStyleBackColor = true;
            this.buttonProductInfoEdit.Click += new System.EventHandler(this.buttonProductInfoEdit_Click);
            // 
            // dataGridViewProductInfo
            // 
            this.dataGridViewProductInfo.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.dataGridViewProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductInfo.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProductInfo.Name = "dataGridViewProductInfo";
            this.dataGridViewProductInfo.Size = new System.Drawing.Size(578, 188);
            this.dataGridViewProductInfo.TabIndex = 2;
            // 
            // tabPageProductImage
            // 
            this.tabPageProductImage.Controls.Add(this.buttonProductImageAdd);
            this.tabPageProductImage.Controls.Add(this.buttonProductImageEdit);
            this.tabPageProductImage.Controls.Add(this.dataGridViewProductImage);
            this.tabPageProductImage.Location = new System.Drawing.Point(4, 22);
            this.tabPageProductImage.Name = "tabPageProductImage";
            this.tabPageProductImage.Size = new System.Drawing.Size(584, 226);
            this.tabPageProductImage.TabIndex = 4;
            this.tabPageProductImage.Text = "Images";
            this.tabPageProductImage.UseVisualStyleBackColor = true;
            // 
            // buttonProductImageAdd
            // 
            this.buttonProductImageAdd.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonProductImageAdd.Location = new System.Drawing.Point(391, 197);
            this.buttonProductImageAdd.Name = "buttonProductImageAdd";
            this.buttonProductImageAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonProductImageAdd.TabIndex = 11;
            this.buttonProductImageAdd.Text = "&Add";
            this.buttonProductImageAdd.UseVisualStyleBackColor = true;
            this.buttonProductImageAdd.Click += new System.EventHandler(this.buttonProductImageAdd_Click);
            // 
            // buttonProductImageEdit
            // 
            this.buttonProductImageEdit.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonProductImageEdit.Location = new System.Drawing.Point(489, 197);
            this.buttonProductImageEdit.Name = "buttonProductImageEdit";
            this.buttonProductImageEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonProductImageEdit.TabIndex = 12;
            this.buttonProductImageEdit.Text = "&Edit";
            this.buttonProductImageEdit.UseVisualStyleBackColor = true;
            this.buttonProductImageEdit.Click += new System.EventHandler(this.buttonProductImageEdit_Click);
            // 
            // dataGridViewProductImage
            // 
            this.dataGridViewProductImage.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.dataGridViewProductImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductImage.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProductImage.Name = "dataGridViewProductImage";
            this.dataGridViewProductImage.Size = new System.Drawing.Size(578, 188);
            this.dataGridViewProductImage.TabIndex = 2;
            // 
            // tabPageProductDocumentation
            // 
            this.tabPageProductDocumentation.Controls.Add(this.buttonProductDocumentationAdd);
            this.tabPageProductDocumentation.Controls.Add(this.buttonProductDocumentationEdit);
            this.tabPageProductDocumentation.Controls.Add(this.dataGridViewProductDocumentation);
            this.tabPageProductDocumentation.Location = new System.Drawing.Point(4, 22);
            this.tabPageProductDocumentation.Name = "tabPageProductDocumentation";
            this.tabPageProductDocumentation.Size = new System.Drawing.Size(584, 226);
            this.tabPageProductDocumentation.TabIndex = 5;
            this.tabPageProductDocumentation.Text = "Documentation";
            this.tabPageProductDocumentation.UseVisualStyleBackColor = true;
            // 
            // buttonProductDocumentationAdd
            // 
            this.buttonProductDocumentationAdd.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonProductDocumentationAdd.Location = new System.Drawing.Point(391, 197);
            this.buttonProductDocumentationAdd.Name = "buttonProductDocumentationAdd";
            this.buttonProductDocumentationAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonProductDocumentationAdd.TabIndex = 13;
            this.buttonProductDocumentationAdd.Text = "&Add";
            this.buttonProductDocumentationAdd.UseVisualStyleBackColor = true;
            this.buttonProductDocumentationAdd.Click += new System.EventHandler(this.buttonProductDocumentationAdd_Click);
            // 
            // buttonProductDocumentationEdit
            // 
            this.buttonProductDocumentationEdit.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonProductDocumentationEdit.Location = new System.Drawing.Point(489, 197);
            this.buttonProductDocumentationEdit.Name = "buttonProductDocumentationEdit";
            this.buttonProductDocumentationEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonProductDocumentationEdit.TabIndex = 14;
            this.buttonProductDocumentationEdit.Text = "&Edit";
            this.buttonProductDocumentationEdit.UseVisualStyleBackColor = true;
            this.buttonProductDocumentationEdit.Click += new System.EventHandler(this.buttonProductDocumentationEdit_Click);
            // 
            // dataGridViewProductDocumentation
            // 
            this.dataGridViewProductDocumentation.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.dataGridViewProductDocumentation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductDocumentation.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProductDocumentation.Name = "dataGridViewProductDocumentation";
            this.dataGridViewProductDocumentation.Size = new System.Drawing.Size(578, 188);
            this.dataGridViewProductDocumentation.TabIndex = 2;
            // 
            // tabPageProductHistory
            // 
            this.tabPageProductHistory.Controls.Add(this.dataGridViewProductHistory);
            this.tabPageProductHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageProductHistory.Name = "tabPageProductHistory";
            this.tabPageProductHistory.Size = new System.Drawing.Size(584, 226);
            this.tabPageProductHistory.TabIndex = 6;
            this.tabPageProductHistory.Text = "History";
            this.tabPageProductHistory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProductHistory
            // 
            this.dataGridViewProductHistory.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.dataGridViewProductHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductHistory.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProductHistory.Name = "dataGridViewProductHistory";
            this.dataGridViewProductHistory.Size = new System.Drawing.Size(582, 228);
            this.dataGridViewProductHistory.TabIndex = 1;
            // 
            // buttonProductHistory
            // 
            this.buttonProductHistory.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonProductHistory.Location = new System.Drawing.Point(316, 270);
            this.buttonProductHistory.Name = "buttonProductHistory";
            this.buttonProductHistory.Size = new System.Drawing.Size(92, 22);
            this.buttonProductHistory.TabIndex = 46;
            this.buttonProductHistory.Text = "&History";
            this.buttonProductHistory.UseVisualStyleBackColor = true;
            this.buttonProductHistory.Click += new System.EventHandler(this.buttonProductHistory_Click);
            // 
            // buttonProductSave
            // 
            this.buttonProductSave.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonProductSave.Location = new System.Drawing.Point(414, 270);
            this.buttonProductSave.Name = "buttonProductSave";
            this.buttonProductSave.Size = new System.Drawing.Size(92, 22);
            this.buttonProductSave.TabIndex = 45;
            this.buttonProductSave.Text = "&Save";
            this.buttonProductSave.UseVisualStyleBackColor = true;
            this.buttonProductSave.Click += new System.EventHandler(this.buttonProductSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonClose.Location = new System.Drawing.Point(512, 270);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 47;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // stateRefComboProduct
            // 
            this.stateRefComboProduct.Location = new System.Drawing.Point(135, 64);
            this.stateRefComboProduct.Name = "stateRefComboProduct";
            this.stateRefComboProduct.Size = new System.Drawing.Size(244, 21);
            this.stateRefComboProduct.TabIndex = 0;
            // 
            // ProductMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 303);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonProductHistory);
            this.Controls.Add(this.buttonProductSave);
            this.Controls.Add(this.tabControlProduct);
            this.Name = "ProductMaintenance";
            this.Text = "Product Maintenance";
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
            this.tabPageProductHistory.ResumeLayout(false);
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewProductHistory ) ).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProduct;
        private System.Windows.Forms.TabPage tabPageProduct;
        private SolutionNorSolutionPim.UserInterface.DefaultStateRefCombo stateRefComboProduct;
        private System.Windows.Forms.Label labelStateRefCombo;
        private System.Windows.Forms.Label labelDateTimeProduct;
        private System.Windows.Forms.DateTimePicker dateTimePickerProduct;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TabPage tabPageProductAttribute;
        private System.Windows.Forms.Button buttonProductAttributeAdd;
        private System.Windows.Forms.Button buttonProductAttributeEdit;
        private System.Windows.Forms.DataGridView dataGridViewProductAttribute;
        private System.Windows.Forms.TabPage tabPageProductIdentifier;
        private System.Windows.Forms.Button buttonProductIdentifierAdd;
        private System.Windows.Forms.Button buttonProductIdentifierEdit;
        private System.Windows.Forms.DataGridView dataGridViewProductIdentifier;
        private System.Windows.Forms.TabPage tabPageProductInfo;
        private System.Windows.Forms.Button buttonProductInfoAdd;
        private System.Windows.Forms.Button buttonProductInfoEdit;
        private System.Windows.Forms.DataGridView dataGridViewProductInfo;
        private System.Windows.Forms.TabPage tabPageProductImage;
        private System.Windows.Forms.Button buttonProductImageAdd;
        private System.Windows.Forms.Button buttonProductImageEdit;
        private System.Windows.Forms.DataGridView dataGridViewProductImage;
        private System.Windows.Forms.TabPage tabPageProductDocumentation;
        private System.Windows.Forms.Button buttonProductDocumentationAdd;
        private System.Windows.Forms.Button buttonProductDocumentationEdit;
        private System.Windows.Forms.DataGridView dataGridViewProductDocumentation;
        private System.Windows.Forms.TabPage tabPageProductHistory;
        private System.Windows.Forms.DataGridView dataGridViewProductHistory;
        private System.Windows.Forms.Button buttonProductHistory;
        private System.Windows.Forms.Button buttonProductSave;
        private System.Windows.Forms.Button buttonClose;
    }
}
