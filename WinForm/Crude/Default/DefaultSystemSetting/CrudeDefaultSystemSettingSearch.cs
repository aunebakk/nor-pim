/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 1:21:18 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    public partial class CrudeDefaultSystemSettingSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private string _defaultSystemSettingRcd;
        
        private System.Guid _defaultUserId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultSystemSettingSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultSystemSetting();
            this.AcceptButton = buttonCrudeDefaultSystemSettingSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(string defaultSystemSettingRcd, System.Guid defaultUserId) {
            try {
                _defaultSystemSettingRcd = defaultSystemSettingRcd;
                _defaultUserId = defaultUserId;

                RefreshCrudeDefaultSystemSetting();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeDefaultSystemSettingEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultSystemSettingEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultSystemSetting.CurrentRow.Cells["DefaultSystemSettingId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeDefaultSystemSettingAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultSystemSettingEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void dataGridViewCrudeDefaultSystemSetting_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultSystemSettingEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultSystemSetting.CurrentRow.Cells["DefaultSystemSettingId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeDefaultSystemSettingSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultSystemSetting();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // closes the form
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // refresh the grid
        public void RefreshCrudeDefaultSystemSetting() {
            var defaultSystemSetting = new CrudeDefaultSystemSettingServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultSystemSetting.FetchWithFilter(
                             Guid.Empty
                            ,defaultSystemSettingRefCombo.Text
                            ,textBoxDefaultSystemSettingValue.Text
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultSystemSetting.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultSystemSetting.DataSource = bindingSource;
                dataGridViewCrudeDefaultSystemSetting.AutoResizeColumns();
                dataGridViewCrudeDefaultSystemSetting.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultSystemSetting.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeDefaultSystemSetting() {
            try {
                dataGridViewCrudeDefaultSystemSetting.Columns.Clear();
                dataGridViewCrudeDefaultSystemSetting.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultSystemSetting.Columns.Add("DefaultSystemSettingRcd","Default System Setting");
                dataGridViewCrudeDefaultSystemSetting.Columns["DefaultSystemSettingRcd"].DataPropertyName = "DefaultSystemSettingRcd";
                dataGridViewCrudeDefaultSystemSetting.Columns.Add("DefaultSystemSettingValue","Default System Setting Value");
                dataGridViewCrudeDefaultSystemSetting.Columns["DefaultSystemSettingValue"].DataPropertyName = "DefaultSystemSettingValue";
                dataGridViewCrudeDefaultSystemSetting.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultSystemSetting.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultSystemSetting.Columns.Add("DefaultSystemSettingId","Default System Setting");
                dataGridViewCrudeDefaultSystemSetting.Columns["DefaultSystemSettingId"].DataPropertyName = "DefaultSystemSettingId";
                dataGridViewCrudeDefaultSystemSetting.Columns["DefaultSystemSettingId"].Visible = false;
                dataGridViewCrudeDefaultSystemSetting.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultSystemSetting.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultSystemSetting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultSystemSetting.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
