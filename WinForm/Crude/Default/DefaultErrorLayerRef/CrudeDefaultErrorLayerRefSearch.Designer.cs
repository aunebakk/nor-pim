namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultErrorLayerRefSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeDefaultErrorLayerRefSearch;

        private System.Windows.Forms.Button buttonCrudeDefaultErrorLayerRefAdd;

        private System.Windows.Forms.Button buttonCrudeDefaultErrorLayerRefEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultErrorLayerRef;

        private System.Windows.Forms.TextBox textBoxDefaultErrorLayerName;

        private System.Windows.Forms.Label labelDefaultErrorLayerName;

        private System.Windows.Forms.TextBox textBoxDefaultErrorLayer;

        private System.Windows.Forms.Label labelDefaultErrorLayer;

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
            this.buttonCrudeDefaultErrorLayerRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultErrorLayerRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultErrorLayerRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultErrorLayerRef = new System.Windows.Forms.DataGridView();
            this.labelDefaultErrorLayerName = new System.Windows.Forms.Label();
            this.textBoxDefaultErrorLayerName = new System.Windows.Forms.TextBox();
            this.labelDefaultErrorLayer = new System.Windows.Forms.Label();
            this.textBoxDefaultErrorLayer = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultErrorLayerRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelDefaultErrorLayerName
            //
            this.labelDefaultErrorLayerName.AutoSize = true;
            this.labelDefaultErrorLayerName.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultErrorLayerName.Name = "labelDefaultErrorLayerName";
            this.labelDefaultErrorLayerName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultErrorLayerName.TabIndex = 2;
            this.labelDefaultErrorLayerName.Text = "Default Error Layer Name:";
            //
            //textBoxDefaultErrorLayerName
            //
            this.textBoxDefaultErrorLayerName.Location = new System.Drawing.Point(168, 13);
            this.textBoxDefaultErrorLayerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultErrorLayerName.Name = "textBoxDefaultErrorLayerName";
            this.textBoxDefaultErrorLayerName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultErrorLayerName.TabIndex = 3;
            //
            // labelDefaultErrorLayer
            //
            this.labelDefaultErrorLayer.AutoSize = true;
            this.labelDefaultErrorLayer.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultErrorLayer.Name = "labelDefaultErrorLayer";
            this.labelDefaultErrorLayer.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultErrorLayer.TabIndex = 4;
            this.labelDefaultErrorLayer.Text = "Default Error Layer:";
            //
            //textBoxDefaultErrorLayer
            //
            this.textBoxDefaultErrorLayer.Location = new System.Drawing.Point(168, 36);
            this.textBoxDefaultErrorLayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultErrorLayer.Name = "textBoxDefaultErrorLayer";
            this.textBoxDefaultErrorLayer.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultErrorLayer.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(168, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeDefaultErrorLayerRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultErrorLayerRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultErrorLayerRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultErrorLayerRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultErrorLayerRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultErrorLayerRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeDefaultErrorLayerRef.Name = "dataGridViewCrudeDefaultErrorLayerRef";
            this.dataGridViewCrudeDefaultErrorLayerRef.Size = new System.Drawing.Size(406, 96);
            this.dataGridViewCrudeDefaultErrorLayerRef.TabIndex = 0;
            this.dataGridViewCrudeDefaultErrorLayerRef.ReadOnly = true;
            this.dataGridViewCrudeDefaultErrorLayerRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultErrorLayerRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(326, 195);

            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeDefaultErrorLayerRefSearch
            // 
            this.buttonCrudeDefaultErrorLayerRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultErrorLayerRefSearch.Location = new System.Drawing.Point(226, 195);
            this.buttonCrudeDefaultErrorLayerRefSearch.Name = "buttonCrudeDefaultErrorLayerRefSearch";
            this.buttonCrudeDefaultErrorLayerRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultErrorLayerRefSearch.TabIndex = 2;
            this.buttonCrudeDefaultErrorLayerRefSearch.Text = "&Search";
            this.buttonCrudeDefaultErrorLayerRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultErrorLayerRefSearch.Click += new System.EventHandler(this.buttonCrudeDefaultErrorLayerRefSearch_Click);
            // 
            // buttonCrudeDefaultErrorLayerRefAdd
            // 
            this.buttonCrudeDefaultErrorLayerRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultErrorLayerRefAdd.Location = new System.Drawing.Point(126, 195);
            this.buttonCrudeDefaultErrorLayerRefAdd.Name = "buttonCrudeDefaultErrorLayerRefAdd";
            this.buttonCrudeDefaultErrorLayerRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultErrorLayerRefAdd.TabIndex = 3;
            this.buttonCrudeDefaultErrorLayerRefAdd.Text = "&Add";
            this.buttonCrudeDefaultErrorLayerRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultErrorLayerRefAdd.Click += new System.EventHandler(this.buttonCrudeDefaultErrorLayerRefAdd_Click);
            // 
            // buttonCrudeDefaultErrorLayerRefEdit
            // 
            this.buttonCrudeDefaultErrorLayerRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultErrorLayerRefEdit.Location = new System.Drawing.Point(26, 195);
            this.buttonCrudeDefaultErrorLayerRefEdit.Name = "buttonCrudeDefaultErrorLayerRefEdit";
            this.buttonCrudeDefaultErrorLayerRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultErrorLayerRefEdit.TabIndex = 4;
            this.buttonCrudeDefaultErrorLayerRefEdit.Text = "&Edit";
            this.buttonCrudeDefaultErrorLayerRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultErrorLayerRefEdit.Click += new System.EventHandler(this.buttonCrudeDefaultErrorLayerRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 223);
            this.Controls.Add(this.buttonCrudeDefaultErrorLayerRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultErrorLayerRefAdd);
            this.Controls.Add(this.buttonCrudeDefaultErrorLayerRefEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultErrorLayerRef);
            this.Name = "CrudeDefaultErrorLayerRefSearch";
            this.Text = "Default Error Layer Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultErrorLayerRef)).EndInit();
            this.Controls.Add(this.labelDefaultErrorLayerName);
            this.Controls.Add(this.textBoxDefaultErrorLayerName);
            this.Controls.Add(this.labelDefaultErrorLayer);
            this.Controls.Add(this.textBoxDefaultErrorLayer);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
