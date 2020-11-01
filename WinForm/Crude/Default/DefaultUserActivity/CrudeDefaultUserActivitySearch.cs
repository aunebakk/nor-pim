/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 7:03:22 AM
  From Machine: DESKTOP-9A2DH39
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
    public partial class CrudeDefaultUserActivitySearch : Form {
        
        // the following fields holds initial state for foreign key's
        private string _defaultUserActivityTypeRcd;
        
        private System.Guid _defaultUserId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultUserActivitySearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultUserActivity();
            this.AcceptButton = buttonCrudeDefaultUserActivitySearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(string defaultUserActivityTypeRcd, System.Guid defaultUserId) {
            try {
                _defaultUserActivityTypeRcd = defaultUserActivityTypeRcd;
                _defaultUserId = defaultUserId;

                RefreshCrudeDefaultUserActivity();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeDefaultUserActivityEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultUserActivityEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultUserActivity.CurrentRow.Cells["DefaultUserActivityId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeDefaultUserActivityAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultUserActivityEdit();
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
        private void dataGridViewCrudeDefaultUserActivity_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultUserActivityEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultUserActivity.CurrentRow.Cells["DefaultUserActivityId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeDefaultUserActivitySearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultUserActivity();
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
        public void RefreshCrudeDefaultUserActivity() {
            var defaultUserActivity = new CrudeDefaultUserActivityServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultUserActivity.FetchWithFilter(
                             Guid.Empty
                            ,defaultUserActivityTypeRefCombo.Text
                            ,textBoxUserActivityNote.Text
                            ,textBoxOriginatingAddress.Text
                            ,textBoxReferrer.Text
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultUserActivity.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultUserActivity.DataSource = bindingSource;
                dataGridViewCrudeDefaultUserActivity.AutoResizeColumns();
                dataGridViewCrudeDefaultUserActivity.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultUserActivity.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeDefaultUserActivity() {
            try {
                dataGridViewCrudeDefaultUserActivity.Columns.Clear();
                dataGridViewCrudeDefaultUserActivity.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultUserActivity.Columns.Add("DefaultUserActivityTypeRcd","Default User Activity Type");
                dataGridViewCrudeDefaultUserActivity.Columns["DefaultUserActivityTypeRcd"].DataPropertyName = "DefaultUserActivityTypeRcd";
                dataGridViewCrudeDefaultUserActivity.Columns.Add("UserActivityNote","User Activity Note");
                dataGridViewCrudeDefaultUserActivity.Columns["UserActivityNote"].DataPropertyName = "UserActivityNote";
                dataGridViewCrudeDefaultUserActivity.Columns.Add("OriginatingAddress","Originating Address");
                dataGridViewCrudeDefaultUserActivity.Columns["OriginatingAddress"].DataPropertyName = "OriginatingAddress";
                dataGridViewCrudeDefaultUserActivity.Columns.Add("Referrer","Referrer");
                dataGridViewCrudeDefaultUserActivity.Columns["Referrer"].DataPropertyName = "Referrer";
                dataGridViewCrudeDefaultUserActivity.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultUserActivity.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultUserActivity.Columns.Add("DefaultUserActivityId","Default User Activity");
                dataGridViewCrudeDefaultUserActivity.Columns["DefaultUserActivityId"].DataPropertyName = "DefaultUserActivityId";
                dataGridViewCrudeDefaultUserActivity.Columns["DefaultUserActivityId"].Visible = false;
                dataGridViewCrudeDefaultUserActivity.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultUserActivity.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultUserActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultUserActivity.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
