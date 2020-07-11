namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientEventSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeClientEventSearch;
        
        private System.Windows.Forms.Button buttonCrudeClientEventAdd;
        
        private System.Windows.Forms.Button buttonCrudeClientEventEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeClientEvent;
        
        private ClientEventTypeRefCombo clientEventTypeRefCombo;
        
        private System.Windows.Forms.Label labelClientEventTypeRefCombo;
        
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
            this.buttonCrudeClientEventAdd = new System.Windows.Forms.Button();
            this.buttonCrudeClientEventEdit = new System.Windows.Forms.Button();
            this.buttonCrudeClientEventSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeClientEvent = new System.Windows.Forms.DataGridView();
            this.labelClientEventTypeRefCombo = new System.Windows.Forms.Label();
            this.clientEventTypeRefCombo = new ClientEventTypeRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientEvent)).BeginInit();
            this.SuspendLayout();
            //
            // labelClientEventTypeRefCombo
            //
            this.labelClientEventTypeRefCombo.AutoSize = true;
            this.labelClientEventTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelClientEventTypeRefCombo.Name = "labelClientEventTypeRefCombo";
            this.labelClientEventTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelClientEventTypeRefCombo.TabIndex = 2;
            this.labelClientEventTypeRefCombo.Text = "Client Event Type:";
            //
            //clientEventTypeRefCombo
            //
            this.clientEventTypeRefCombo.Location = new System.Drawing.Point(140, 13);
            this.clientEventTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientEventTypeRefCombo.Name = "clientEventTypeRefCombo";
            this.clientEventTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.clientEventTypeRefCombo.TabIndex = 3;
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
            // dataGridViewCrudeClientEvent
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeClientEvent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeClientEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeClientEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeClientEvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeClientEvent.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewCrudeClientEvent.Name = "dataGridViewCrudeClientEvent";
            this.dataGridViewCrudeClientEvent.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeClientEvent.TabIndex = 0;
            this.dataGridViewCrudeClientEvent.ReadOnly = true;
            this.dataGridViewCrudeClientEvent.DoubleClick += new System.EventHandler(this.dataGridViewCrudeClientEvent_DoubleClick);
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
            // buttonCrudeClientEventSearch
            // 
            this.buttonCrudeClientEventSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientEventSearch.Location = new System.Drawing.Point(198, 172);
            this.buttonCrudeClientEventSearch.Name = "buttonCrudeClientEventSearch";
            this.buttonCrudeClientEventSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientEventSearch.TabIndex = 2;
            this.buttonCrudeClientEventSearch.Text = "&Search";
            this.buttonCrudeClientEventSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeClientEventSearch.Click += new System.EventHandler(this.buttonCrudeClientEventSearch_Click);
            // 
            // buttonCrudeClientEventAdd
            // 
            this.buttonCrudeClientEventAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientEventAdd.Location = new System.Drawing.Point(98, 172);
            this.buttonCrudeClientEventAdd.Name = "buttonCrudeClientEventAdd";
            this.buttonCrudeClientEventAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientEventAdd.TabIndex = 3;
            this.buttonCrudeClientEventAdd.Text = "&Add";
            this.buttonCrudeClientEventAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeClientEventAdd.Click += new System.EventHandler(this.buttonCrudeClientEventAdd_Click);
            // 
            // buttonCrudeClientEventEdit
            // 
            this.buttonCrudeClientEventEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientEventEdit.Location = new System.Drawing.Point(-2, 172);
            this.buttonCrudeClientEventEdit.Name = "buttonCrudeClientEventEdit";
            this.buttonCrudeClientEventEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientEventEdit.TabIndex = 4;
            this.buttonCrudeClientEventEdit.Text = "&Edit";
            this.buttonCrudeClientEventEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeClientEventEdit.Click += new System.EventHandler(this.buttonCrudeClientEventEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 200);
            this.Controls.Add(this.buttonCrudeClientEventSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeClientEventAdd);
            this.Controls.Add(this.buttonCrudeClientEventEdit);
            this.Controls.Add(this.dataGridViewCrudeClientEvent);
            this.Name = "CrudeClientEventSearch";
            this.Text = "Client Event Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientEvent)).EndInit();
            this.Controls.Add(this.labelClientEventTypeRefCombo);
            this.Controls.Add(this.clientEventTypeRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
