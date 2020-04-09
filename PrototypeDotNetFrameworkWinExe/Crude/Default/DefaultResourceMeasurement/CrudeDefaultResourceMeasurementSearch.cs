/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:34:58 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultResourceMeasurementSearch : Form {
        
        private System.Guid _defaultUserId;
        
        public CrudeDefaultResourceMeasurementSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultResourceMeasurement();
            this.AcceptButton = buttonCrudeDefaultResourceMeasurementSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;
                RefreshCrudeDefaultResourceMeasurement();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultResourceMeasurementEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultResourceMeasurementEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultResourceMeasurement.CurrentRow.Cells["DefaultResourceMeasurementId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultResourceMeasurementAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultResourceMeasurementEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultResourceMeasurement_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultResourceMeasurementEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultResourceMeasurement.CurrentRow.Cells["DefaultResourceMeasurementId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultResourceMeasurementSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultResourceMeasurement();
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
        
        public void RefreshCrudeDefaultResourceMeasurement() {
            var defaultResourceMeasurement = new CrudeDefaultResourceMeasurementServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultResourceMeasurement.FetchWithFilter(
                             Guid.Empty
                            ,maskedTextBoxClientWorkingsetBytes.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxClientWorkingsetBytes.Text)
                            ,maskedTextBoxBusinessWorkingsetBytes.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxBusinessWorkingsetBytes.Text)
                            ,maskedTextBoxDatabaseSizeBytes.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxDatabaseSizeBytes.Text)
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultResourceMeasurement.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultResourceMeasurement.DataSource = bindingSource;
                dataGridViewCrudeDefaultResourceMeasurement.AutoResizeColumns();
                dataGridViewCrudeDefaultResourceMeasurement.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultResourceMeasurement.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultResourceMeasurement() {
            try {
                dataGridViewCrudeDefaultResourceMeasurement.Columns.Clear();
                dataGridViewCrudeDefaultResourceMeasurement.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultResourceMeasurement.Columns.Add("ClientWorkingsetBytes","Client Workingset Bytes");
                dataGridViewCrudeDefaultResourceMeasurement.Columns["ClientWorkingsetBytes"].DataPropertyName = "ClientWorkingsetBytes";
                dataGridViewCrudeDefaultResourceMeasurement.Columns.Add("BusinessWorkingsetBytes","Business Workingset Bytes");
                dataGridViewCrudeDefaultResourceMeasurement.Columns["BusinessWorkingsetBytes"].DataPropertyName = "BusinessWorkingsetBytes";
                dataGridViewCrudeDefaultResourceMeasurement.Columns.Add("DatabaseSizeBytes","Database Size Bytes");
                dataGridViewCrudeDefaultResourceMeasurement.Columns["DatabaseSizeBytes"].DataPropertyName = "DatabaseSizeBytes";
                dataGridViewCrudeDefaultResourceMeasurement.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultResourceMeasurement.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultResourceMeasurement.Columns.Add("DefaultResourceMeasurementId","Default Resource Measurement");
                dataGridViewCrudeDefaultResourceMeasurement.Columns["DefaultResourceMeasurementId"].DataPropertyName = "DefaultResourceMeasurementId";
                dataGridViewCrudeDefaultResourceMeasurement.Columns["DefaultResourceMeasurementId"].Visible = false;
                dataGridViewCrudeDefaultResourceMeasurement.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultResourceMeasurement.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultResourceMeasurement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultResourceMeasurement.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
