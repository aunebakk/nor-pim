/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:32:41 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderEventTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeFinancialOrderEventTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialOrderEventTypeRef();
            this.AcceptButton = buttonCrudeFinancialOrderEventTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeFinancialOrderEventTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderEventTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderEventTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialOrderEventTypeRef.CurrentRow.Cells["FinancialOrderEventTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderEventTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderEventTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialOrderEventTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderEventTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialOrderEventTypeRef.CurrentRow.Cells["FinancialOrderEventTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderEventTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialOrderEventTypeRef();
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
        
        public void RefreshCrudeFinancialOrderEventTypeRef() {
            var financialOrderEventTypeRef = new CrudeFinancialOrderEventTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialOrderEventTypeRef.FetchWithFilter(
                             textBoxFinancialOrderEventType.Text
                            ,textBoxFinancialOrderEventTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFinancialOrderEventTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialOrderEventTypeRef.DataSource = bindingSource;
                dataGridViewCrudeFinancialOrderEventTypeRef.AutoResizeColumns();
                dataGridViewCrudeFinancialOrderEventTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialOrderEventTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialOrderEventTypeRef() {
            try {
                dataGridViewCrudeFinancialOrderEventTypeRef.Columns.Clear();
                dataGridViewCrudeFinancialOrderEventTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialOrderEventTypeRef.Columns.Add("FinancialOrderEventTypeName","Financial Order Event Type Name");
                dataGridViewCrudeFinancialOrderEventTypeRef.Columns["FinancialOrderEventTypeName"].DataPropertyName = "FinancialOrderEventTypeName";
                dataGridViewCrudeFinancialOrderEventTypeRef.Columns.Add("FinancialOrderEventTypeRcd","Financial Order Event Type");
                dataGridViewCrudeFinancialOrderEventTypeRef.Columns["FinancialOrderEventTypeRcd"].DataPropertyName = "FinancialOrderEventTypeRcd";
                dataGridViewCrudeFinancialOrderEventTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialOrderEventTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialOrderEventTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialOrderEventTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialOrderEventTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialOrderEventTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
