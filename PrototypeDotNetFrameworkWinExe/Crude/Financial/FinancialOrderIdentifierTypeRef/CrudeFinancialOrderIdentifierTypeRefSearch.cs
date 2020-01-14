/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:43:54 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderIdentifierTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeFinancialOrderIdentifierTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialOrderIdentifierTypeRef();
            this.AcceptButton = buttonCrudeFinancialOrderIdentifierTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeFinancialOrderIdentifierTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderIdentifierTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderIdentifierTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialOrderIdentifierTypeRef.CurrentRow.Cells["FinancialOrderIdentifierTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderIdentifierTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderIdentifierTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialOrderIdentifierTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderIdentifierTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialOrderIdentifierTypeRef.CurrentRow.Cells["FinancialOrderIdentifierTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderIdentifierTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialOrderIdentifierTypeRef();
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
        
        public void RefreshCrudeFinancialOrderIdentifierTypeRef() {
            var financialOrderIdentifierTypeRef = new CrudeFinancialOrderIdentifierTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialOrderIdentifierTypeRef.FetchWithFilter(
                             textBoxFinancialOrderIdentifierType.Text
                            ,textBoxFinancialOrderIdentifierTypeCode.Text
                            ,textBoxFinancialOrderIdentifierTypeName.Text
                            ,maskedTextBoxSortSequenceNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortSequenceNumber.Text)
                            ,Convert.ToBoolean(checkBoxChangeFlag.Checked)
                            ,textBoxStatusCode.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.DataSource = bindingSource;
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.AutoResizeColumns();
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialOrderIdentifierTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialOrderIdentifierTypeRef() {
            try {
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.Columns.Clear();
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.Columns.Add("FinancialOrderIdentifierTypeName","Financial Order Identifier Type Name");
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.Columns["FinancialOrderIdentifierTypeName"].DataPropertyName = "FinancialOrderIdentifierTypeName";
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.Columns.Add("FinancialOrderIdentifierTypeRcd","Financial Order Identifier Type");
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.Columns["FinancialOrderIdentifierTypeRcd"].DataPropertyName = "FinancialOrderIdentifierTypeRcd";
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.Columns.Add("FinancialOrderIdentifierTypeCode","Financial Order Identifier Type Code");
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.Columns["FinancialOrderIdentifierTypeCode"].DataPropertyName = "FinancialOrderIdentifierTypeCode";
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.Columns.Add("StatusCode","Status Code");
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.Columns["StatusCode"].DataPropertyName = "StatusCode";
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.Columns.Add("SortSequenceNumber","Sort Sequence Number");
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.Columns["SortSequenceNumber"].DataPropertyName = "SortSequenceNumber";
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.Columns.Add("ChangeFlag","Change Flag");
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.Columns["ChangeFlag"].DataPropertyName = "ChangeFlag";
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialOrderIdentifierTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialOrderIdentifierTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
