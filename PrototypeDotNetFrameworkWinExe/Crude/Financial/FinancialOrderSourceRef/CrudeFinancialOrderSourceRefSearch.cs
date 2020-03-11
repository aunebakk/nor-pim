/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:29:51 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderSourceRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeFinancialOrderSourceRefSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialOrderSourceRef();
            this.AcceptButton = buttonCrudeFinancialOrderSourceRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeFinancialOrderSourceRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderSourceRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderSourceRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialOrderSourceRef.CurrentRow.Cells["FinancialOrderSourceRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderSourceRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderSourceRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialOrderSourceRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderSourceRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialOrderSourceRef.CurrentRow.Cells["FinancialOrderSourceRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderSourceRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialOrderSourceRef();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        public void RefreshCrudeFinancialOrderSourceRef() {
            var financialOrderSourceRef = new CrudeFinancialOrderSourceRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialOrderSourceRef.FetchWithFilter(
                             textBoxFinancialOrderSource.Text
                            ,textBoxFinancialOrderSourceName.Text
                            ,textBoxFinancialOrderSourceCode.Text
                            ,maskedTextBoxSortSequenceNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortSequenceNumber.Text)
                            ,Convert.ToBoolean(checkBoxChangeFlag.Checked)
                            ,textBoxStatusCode.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFinancialOrderSourceRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialOrderSourceRef.DataSource = bindingSource;
                dataGridViewCrudeFinancialOrderSourceRef.AutoResizeColumns();
                dataGridViewCrudeFinancialOrderSourceRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialOrderSourceRef.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialOrderSourceRef() {
            try {
                dataGridViewCrudeFinancialOrderSourceRef.Columns.Clear();
                dataGridViewCrudeFinancialOrderSourceRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialOrderSourceRef.Columns.Add("FinancialOrderSourceName","Financial Order Source Name");
                dataGridViewCrudeFinancialOrderSourceRef.Columns["FinancialOrderSourceName"].DataPropertyName = "FinancialOrderSourceName";
                dataGridViewCrudeFinancialOrderSourceRef.Columns.Add("FinancialOrderSourceRcd","Financial Order Source");
                dataGridViewCrudeFinancialOrderSourceRef.Columns["FinancialOrderSourceRcd"].DataPropertyName = "FinancialOrderSourceRcd";
                dataGridViewCrudeFinancialOrderSourceRef.Columns.Add("FinancialOrderSourceCode","Financial Order Source Code");
                dataGridViewCrudeFinancialOrderSourceRef.Columns["FinancialOrderSourceCode"].DataPropertyName = "FinancialOrderSourceCode";
                dataGridViewCrudeFinancialOrderSourceRef.Columns.Add("StatusCode","Status Code");
                dataGridViewCrudeFinancialOrderSourceRef.Columns["StatusCode"].DataPropertyName = "StatusCode";
                dataGridViewCrudeFinancialOrderSourceRef.Columns.Add("SortSequenceNumber","Sort Sequence Number");
                dataGridViewCrudeFinancialOrderSourceRef.Columns["SortSequenceNumber"].DataPropertyName = "SortSequenceNumber";
                dataGridViewCrudeFinancialOrderSourceRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialOrderSourceRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialOrderSourceRef.Columns.Add("ChangeFlag","Change Flag");
                dataGridViewCrudeFinancialOrderSourceRef.Columns["ChangeFlag"].DataPropertyName = "ChangeFlag";
                dataGridViewCrudeFinancialOrderSourceRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialOrderSourceRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialOrderSourceRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialOrderSourceRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
