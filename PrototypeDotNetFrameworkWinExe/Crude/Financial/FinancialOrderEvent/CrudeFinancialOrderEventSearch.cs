/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:37:50 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderEventSearch : Form {
        
        private string _financialOrderEventTypeRcd;
        
        private System.Guid _financialOrderId;
        
        private System.Guid _userId;
        
        public CrudeFinancialOrderEventSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialOrderEvent();
            this.AcceptButton = buttonCrudeFinancialOrderEventSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string financialOrderEventTypeRcd, System.Guid financialOrderId, System.Guid userId) {
            try {
                _financialOrderEventTypeRcd = financialOrderEventTypeRcd;
                _financialOrderId = financialOrderId;
                _userId = userId;
                RefreshCrudeFinancialOrderEvent();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderEventEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderEventEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialOrderEvent.CurrentRow.Cells["FiancialOrderEventId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderEventAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderEventEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialOrderEvent_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderEventEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialOrderEvent.CurrentRow.Cells["FiancialOrderEventId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderEventSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialOrderEvent();
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
        
        public void RefreshCrudeFinancialOrderEvent() {
            var financialOrderEvent = new CrudeFinancialOrderEventServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialOrderEvent.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,textBoxComment.Text
                            ,financialOrderEventTypeRefCombo.Text
                            );
                dataGridViewCrudeFinancialOrderEvent.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialOrderEvent.DataSource = bindingSource;
                dataGridViewCrudeFinancialOrderEvent.AutoResizeColumns();
                dataGridViewCrudeFinancialOrderEvent.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialOrderEvent.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialOrderEvent() {
            try {
                dataGridViewCrudeFinancialOrderEvent.Columns.Clear();
                dataGridViewCrudeFinancialOrderEvent.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialOrderEvent.Columns.Add("Comment","Comment");
                dataGridViewCrudeFinancialOrderEvent.Columns["Comment"].DataPropertyName = "Comment";
                dataGridViewCrudeFinancialOrderEvent.Columns.Add("FinancialOrderEventTypeRcd","Financial Order Event Type");
                dataGridViewCrudeFinancialOrderEvent.Columns["FinancialOrderEventTypeRcd"].DataPropertyName = "FinancialOrderEventTypeRcd";
                dataGridViewCrudeFinancialOrderEvent.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialOrderEvent.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialOrderEvent.Columns.Add("FiancialOrderEventId","Fiancial Order Event");
                dataGridViewCrudeFinancialOrderEvent.Columns["FiancialOrderEventId"].DataPropertyName = "FiancialOrderEventId";
                dataGridViewCrudeFinancialOrderEvent.Columns["FiancialOrderEventId"].Visible = false;
                dataGridViewCrudeFinancialOrderEvent.Columns.Add("FinancialOrderId","Financial Order");
                dataGridViewCrudeFinancialOrderEvent.Columns["FinancialOrderId"].DataPropertyName = "FinancialOrderId";
                dataGridViewCrudeFinancialOrderEvent.Columns["FinancialOrderId"].Visible = false;
                dataGridViewCrudeFinancialOrderEvent.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialOrderEvent.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialOrderEvent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialOrderEvent.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
