namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultStateRefSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeDefaultStateRefSearch;

        private System.Windows.Forms.Button buttonCrudeDefaultStateRefAdd;

        private System.Windows.Forms.Button buttonCrudeDefaultStateRefEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultStateRef;

        private System.Windows.Forms.TextBox textBoxDefaultStateName;

        private System.Windows.Forms.Label labelDefaultStateName;

        private System.Windows.Forms.TextBox textBoxDefaultState;

        private System.Windows.Forms.Label labelDefaultState;

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
            this.buttonCrudeDefaultStateRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultStateRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultStateRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultStateRef = new System.Windows.Forms.DataGridView();
            this.labelDefaultStateName = new System.Windows.Forms.Label();
            this.textBoxDefaultStateName = new System.Windows.Forms.TextBox();
            this.labelDefaultState = new System.Windows.Forms.Label();
            this.textBoxDefaultState = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultStateRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelDefaultStateName
            //
            this.labelDefaultStateName.AutoSize = true;
            this.labelDefaultStateName.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultStateName.Name = "labelDefaultStateName";
            this.labelDefaultStateName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultStateName.TabIndex = 2;
            this.labelDefaultStateName.Text = "Default State Name:";
            //
            //textBoxDefaultStateName
            //
            this.textBoxDefaultStateName.Location = new System.Drawing.Point(140, 13);
            this.textBoxDefaultStateName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultStateName.Name = "textBoxDefaultStateName";
            this.textBoxDefaultStateName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultStateName.TabIndex = 3;
            //
            // labelDefaultState
            //
            this.labelDefaultState.AutoSize = true;
            this.labelDefaultState.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultState.Name = "labelDefaultState";
            this.labelDefaultState.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultState.TabIndex = 4;
            this.labelDefaultState.Text = "Default State:";
            //
            //textBoxDefaultState
            //
            this.textBoxDefaultState.Location = new System.Drawing.Point(140, 36);
            this.textBoxDefaultState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultState.Name = "textBoxDefaultState";
            this.textBoxDefaultState.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultState.TabIndex = 5;
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
            // dataGridViewCrudeDefaultStateRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultStateRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultStateRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultStateRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultStateRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultStateRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeDefaultStateRef.Name = "dataGridViewCrudeDefaultStateRef";
            this.dataGridViewCrudeDefaultStateRef.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeDefaultStateRef.TabIndex = 0;
            this.dataGridViewCrudeDefaultStateRef.ReadOnly = true;
            this.dataGridViewCrudeDefaultStateRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultStateRef_DoubleClick);
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
            // buttonCrudeDefaultStateRefSearch
            // 
            this.buttonCrudeDefaultStateRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultStateRefSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeDefaultStateRefSearch.Name = "buttonCrudeDefaultStateRefSearch";
            this.buttonCrudeDefaultStateRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultStateRefSearch.TabIndex = 2;
            this.buttonCrudeDefaultStateRefSearch.Text = "&Search";
            this.buttonCrudeDefaultStateRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultStateRefSearch.Click += new System.EventHandler(this.buttonCrudeDefaultStateRefSearch_Click);
            // 
            // buttonCrudeDefaultStateRefAdd
            // 
            this.buttonCrudeDefaultStateRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultStateRefAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeDefaultStateRefAdd.Name = "buttonCrudeDefaultStateRefAdd";
            this.buttonCrudeDefaultStateRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultStateRefAdd.TabIndex = 3;
            this.buttonCrudeDefaultStateRefAdd.Text = "&Add";
            this.buttonCrudeDefaultStateRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultStateRefAdd.Click += new System.EventHandler(this.buttonCrudeDefaultStateRefAdd_Click);
            // 
            // buttonCrudeDefaultStateRefEdit
            // 
            this.buttonCrudeDefaultStateRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultStateRefEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeDefaultStateRefEdit.Name = "buttonCrudeDefaultStateRefEdit";
            this.buttonCrudeDefaultStateRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultStateRefEdit.TabIndex = 4;
            this.buttonCrudeDefaultStateRefEdit.Text = "&Edit";
            this.buttonCrudeDefaultStateRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultStateRefEdit.Click += new System.EventHandler(this.buttonCrudeDefaultStateRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeDefaultStateRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultStateRefAdd);
            this.Controls.Add(this.buttonCrudeDefaultStateRefEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultStateRef);
            this.Name = "CrudeDefaultStateRefSearch";
            this.Text = "Default State Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultStateRef)).EndInit();
            this.Controls.Add(this.labelDefaultStateName);
            this.Controls.Add(this.textBoxDefaultStateName);
            this.Controls.Add(this.labelDefaultState);
            this.Controls.Add(this.textBoxDefaultState);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
