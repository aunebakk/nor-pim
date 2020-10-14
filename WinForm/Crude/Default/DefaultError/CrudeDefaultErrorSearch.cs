/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 2:45:59 PM
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
    public partial class CrudeDefaultErrorSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private string _defaultErrorLayerRcd;
        
        private string _defaultErrorTypeRcd;
        
        private System.Guid _defaultUserId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultErrorSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultError();
            this.AcceptButton = buttonCrudeDefaultErrorSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(string defaultErrorLayerRcd, string defaultErrorTypeRcd, System.Guid defaultUserId) {
            try {
                _defaultErrorLayerRcd = defaultErrorLayerRcd;
                _defaultErrorTypeRcd = defaultErrorTypeRcd;
                _defaultUserId = defaultUserId;

                RefreshCrudeDefaultError();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeDefaultErrorEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultErrorEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultError.CurrentRow.Cells["DefaultErrorId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeDefaultErrorAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultErrorEdit();
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
        private void dataGridViewCrudeDefaultError_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultErrorEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultError.CurrentRow.Cells["DefaultErrorId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeDefaultErrorSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultError();
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
        public void RefreshCrudeDefaultError() {
            var defaultError = new CrudeDefaultErrorServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultError.FetchWithFilter(
                             Guid.Empty
                            ,defaultErrorLayerRefCombo.Text
                            ,defaultErrorTypeRefCombo.Text
                            ,textBoxLayerAddress.Text
                            ,textBoxErrorMessage.Text
                            ,textBoxStackTrace.Text
                            ,textBoxMethodName.Text
                            ,textBoxDomainName.Text
                            ,textBoxClassName.Text
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultError.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultError.DataSource = bindingSource;
                dataGridViewCrudeDefaultError.AutoResizeColumns();
                dataGridViewCrudeDefaultError.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultError.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeDefaultError() {
            try {
                dataGridViewCrudeDefaultError.Columns.Clear();
                dataGridViewCrudeDefaultError.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultError.Columns.Add("MethodName","Method Name");
                dataGridViewCrudeDefaultError.Columns["MethodName"].DataPropertyName = "MethodName";
                dataGridViewCrudeDefaultError.Columns.Add("DomainName","Domain Name");
                dataGridViewCrudeDefaultError.Columns["DomainName"].DataPropertyName = "DomainName";
                dataGridViewCrudeDefaultError.Columns.Add("ClassName","Class Name");
                dataGridViewCrudeDefaultError.Columns["ClassName"].DataPropertyName = "ClassName";
                dataGridViewCrudeDefaultError.Columns.Add("DefaultErrorLayerRcd","Default Error Layer");
                dataGridViewCrudeDefaultError.Columns["DefaultErrorLayerRcd"].DataPropertyName = "DefaultErrorLayerRcd";
                dataGridViewCrudeDefaultError.Columns.Add("DefaultErrorTypeRcd","Default Error Type");
                dataGridViewCrudeDefaultError.Columns["DefaultErrorTypeRcd"].DataPropertyName = "DefaultErrorTypeRcd";
                dataGridViewCrudeDefaultError.Columns.Add("LayerAddress","Layer Address");
                dataGridViewCrudeDefaultError.Columns["LayerAddress"].DataPropertyName = "LayerAddress";
                dataGridViewCrudeDefaultError.Columns.Add("ErrorMessage","Error Message");
                dataGridViewCrudeDefaultError.Columns["ErrorMessage"].DataPropertyName = "ErrorMessage";
                dataGridViewCrudeDefaultError.Columns.Add("StackTrace","Stack Trace");
                dataGridViewCrudeDefaultError.Columns["StackTrace"].DataPropertyName = "StackTrace";
                dataGridViewCrudeDefaultError.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultError.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultError.Columns.Add("DefaultErrorId","Default Error");
                dataGridViewCrudeDefaultError.Columns["DefaultErrorId"].DataPropertyName = "DefaultErrorId";
                dataGridViewCrudeDefaultError.Columns["DefaultErrorId"].Visible = false;
                dataGridViewCrudeDefaultError.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultError.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultError.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultError.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
