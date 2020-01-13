/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:38:47 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialUnitOfMeasurementRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeFinancialUnitOfMeasurementRefSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialUnitOfMeasurementRef();
            this.AcceptButton = buttonCrudeFinancialUnitOfMeasurementRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeFinancialUnitOfMeasurementRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialUnitOfMeasurementRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialUnitOfMeasurementRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialUnitOfMeasurementRef.CurrentRow.Cells["FinancialUnitOfMeasurementRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialUnitOfMeasurementRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialUnitOfMeasurementRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialUnitOfMeasurementRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialUnitOfMeasurementRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialUnitOfMeasurementRef.CurrentRow.Cells["FinancialUnitOfMeasurementRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialUnitOfMeasurementRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialUnitOfMeasurementRef();
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
        
        public void RefreshCrudeFinancialUnitOfMeasurementRef() {
            var financialUnitOfMeasurementRef = new CrudeFinancialUnitOfMeasurementRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialUnitOfMeasurementRef.FetchWithFilter(
                             textBoxFinancialUnitOfMeasurement.Text
                            ,maskedTextBoxSortSequenceNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortSequenceNumber.Text)
                            ,Convert.ToBoolean(checkBoxChangeFlag.Checked)
                            ,textBoxStatusCode.Text
                            ,textBoxFinancialUnitOfMeasurementName.Text
                            ,textBoxFinancialUnitOfMeasurementCode.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFinancialUnitOfMeasurementRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialUnitOfMeasurementRef.DataSource = bindingSource;
                dataGridViewCrudeFinancialUnitOfMeasurementRef.AutoResizeColumns();
                dataGridViewCrudeFinancialUnitOfMeasurementRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialUnitOfMeasurementRef.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialUnitOfMeasurementRef() {
            try {
                dataGridViewCrudeFinancialUnitOfMeasurementRef.Columns.Clear();
                dataGridViewCrudeFinancialUnitOfMeasurementRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialUnitOfMeasurementRef.Columns.Add("FinancialUnitOfMeasurementName","Financial Unit Of Measurement Name");
                dataGridViewCrudeFinancialUnitOfMeasurementRef.Columns["FinancialUnitOfMeasurementName"].DataPropertyName = "FinancialUnitOfMeasurementName";
                dataGridViewCrudeFinancialUnitOfMeasurementRef.Columns.Add("FinancialUnitOfMeasurementRcd","Financial Unit Of Measurement");
                dataGridViewCrudeFinancialUnitOfMeasurementRef.Columns["FinancialUnitOfMeasurementRcd"].DataPropertyName = "FinancialUnitOfMeasurementRcd";
                dataGridViewCrudeFinancialUnitOfMeasurementRef.Columns.Add("StatusCode","Status Code");
                dataGridViewCrudeFinancialUnitOfMeasurementRef.Columns["StatusCode"].DataPropertyName = "StatusCode";
                dataGridViewCrudeFinancialUnitOfMeasurementRef.Columns.Add("FinancialUnitOfMeasurementCode","Financial Unit Of Measurement Code");
                dataGridViewCrudeFinancialUnitOfMeasurementRef.Columns["FinancialUnitOfMeasurementCode"].DataPropertyName = "FinancialUnitOfMeasurementCode";
                dataGridViewCrudeFinancialUnitOfMeasurementRef.Columns.Add("SortSequenceNumber","Sort Sequence Number");
                dataGridViewCrudeFinancialUnitOfMeasurementRef.Columns["SortSequenceNumber"].DataPropertyName = "SortSequenceNumber";
                dataGridViewCrudeFinancialUnitOfMeasurementRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialUnitOfMeasurementRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialUnitOfMeasurementRef.Columns.Add("ChangeFlag","Change Flag");
                dataGridViewCrudeFinancialUnitOfMeasurementRef.Columns["ChangeFlag"].DataPropertyName = "ChangeFlag";
                dataGridViewCrudeFinancialUnitOfMeasurementRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialUnitOfMeasurementRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialUnitOfMeasurementRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialUnitOfMeasurementRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
