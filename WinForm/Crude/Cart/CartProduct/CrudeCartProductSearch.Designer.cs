namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeCartProductSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeCartProductSearch;

        private System.Windows.Forms.Button buttonCrudeCartProductAdd;

        private System.Windows.Forms.Button buttonCrudeCartProductEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeCartProduct;

        private System.Windows.Forms.TextBox textBoxSessionIdentificator;

        private System.Windows.Forms.Label labelSessionIdentificator;

        private System.Windows.Forms.TextBox textBoxState;

        private System.Windows.Forms.Label labelState;

        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmount;

        private System.Windows.Forms.Label labelAmount;

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
            this.buttonCrudeCartProductAdd = new System.Windows.Forms.Button();
            this.buttonCrudeCartProductEdit = new System.Windows.Forms.Button();
            this.buttonCrudeCartProductSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeCartProduct = new System.Windows.Forms.DataGridView();
            this.labelSessionIdentificator = new System.Windows.Forms.Label();
            this.textBoxSessionIdentificator = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeCartProduct)).BeginInit();
            this.SuspendLayout();
            //
            // labelSessionIdentificator
            //
            this.labelSessionIdentificator.AutoSize = true;
            this.labelSessionIdentificator.Location = new System.Drawing.Point(11, 13);
            this.labelSessionIdentificator.Name = "labelSessionIdentificator";
            this.labelSessionIdentificator.Size = new System.Drawing.Size(71, 13);
            this.labelSessionIdentificator.TabIndex = 2;
            this.labelSessionIdentificator.Text = "Session Identificator:";
            //
            //textBoxSessionIdentificator
            //
            this.textBoxSessionIdentificator.Location = new System.Drawing.Point(147, 13);
            this.textBoxSessionIdentificator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSessionIdentificator.Name = "textBoxSessionIdentificator";
            this.textBoxSessionIdentificator.Size = new System.Drawing.Size(250, 20);
            this.textBoxSessionIdentificator.TabIndex = 3;
            //
            // labelState
            //
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(11, 36);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(71, 13);
            this.labelState.TabIndex = 4;
            this.labelState.Text = "State:";
            //
            //textBoxState
            //
            this.textBoxState.Location = new System.Drawing.Point(147, 36);
            this.textBoxState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(250, 20);
            this.textBoxState.TabIndex = 5;
            //
            // labelAmount
            //
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(11, 59);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 13);
            this.labelAmount.TabIndex = 6;
            this.labelAmount.Text = "Amount:";
            //
            //maskedTextBoxAmount
            //
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(147, 59);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 7;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(147, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // dataGridViewCrudeCartProduct
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeCartProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeCartProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeCartProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeCartProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeCartProduct.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeCartProduct.Name = "dataGridViewCrudeCartProduct";
            this.dataGridViewCrudeCartProduct.Size = new System.Drawing.Size(385, 96);
            this.dataGridViewCrudeCartProduct.TabIndex = 0;
            this.dataGridViewCrudeCartProduct.ReadOnly = true;
            this.dataGridViewCrudeCartProduct.DoubleClick += new System.EventHandler(this.dataGridViewCrudeCartProduct_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(305, 218);

            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeCartProductSearch
            // 
            this.buttonCrudeCartProductSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeCartProductSearch.Location = new System.Drawing.Point(205, 218);
            this.buttonCrudeCartProductSearch.Name = "buttonCrudeCartProductSearch";
            this.buttonCrudeCartProductSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeCartProductSearch.TabIndex = 2;
            this.buttonCrudeCartProductSearch.Text = "&Search";
            this.buttonCrudeCartProductSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeCartProductSearch.Click += new System.EventHandler(this.buttonCrudeCartProductSearch_Click);
            // 
            // buttonCrudeCartProductAdd
            // 
            this.buttonCrudeCartProductAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeCartProductAdd.Location = new System.Drawing.Point(105, 218);
            this.buttonCrudeCartProductAdd.Name = "buttonCrudeCartProductAdd";
            this.buttonCrudeCartProductAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeCartProductAdd.TabIndex = 3;
            this.buttonCrudeCartProductAdd.Text = "&Add";
            this.buttonCrudeCartProductAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeCartProductAdd.Click += new System.EventHandler(this.buttonCrudeCartProductAdd_Click);
            // 
            // buttonCrudeCartProductEdit
            // 
            this.buttonCrudeCartProductEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeCartProductEdit.Location = new System.Drawing.Point(5, 218);
            this.buttonCrudeCartProductEdit.Name = "buttonCrudeCartProductEdit";
            this.buttonCrudeCartProductEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeCartProductEdit.TabIndex = 4;
            this.buttonCrudeCartProductEdit.Text = "&Edit";
            this.buttonCrudeCartProductEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeCartProductEdit.Click += new System.EventHandler(this.buttonCrudeCartProductEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 246);
            this.Controls.Add(this.buttonCrudeCartProductSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeCartProductAdd);
            this.Controls.Add(this.buttonCrudeCartProductEdit);
            this.Controls.Add(this.dataGridViewCrudeCartProduct);
            this.Name = "CrudeCartProductSearch";
            this.Text = "Cart Product Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeCartProduct)).EndInit();
            this.Controls.Add(this.labelSessionIdentificator);
            this.Controls.Add(this.textBoxSessionIdentificator);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
