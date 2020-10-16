/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 9:35:19 AM
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
    public partial class CrudeClientTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeClientTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientTypeRef();
            this.AcceptButton = buttonCrudeClientTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeClientTypeRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeClientTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientTypeRef.CurrentRow.Cells["ClientTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeClientTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void dataGridViewCrudeClientTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientTypeRef.CurrentRow.Cells["ClientTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeClientTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientTypeRef();
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
        public void RefreshCrudeClientTypeRef() {
            var clientTypeRef = new CrudeClientTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientTypeRef.FetchWithFilter(
                             textBoxClientType.Text
                            ,textBoxClientTypeName.Text
                            ,textBoxClientTypeDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientTypeRef.DataSource = bindingSource;
                dataGridViewCrudeClientTypeRef.AutoResizeColumns();
                dataGridViewCrudeClientTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeClientTypeRef() {
            try {
                dataGridViewCrudeClientTypeRef.Columns.Clear();
                dataGridViewCrudeClientTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientTypeRef.Columns.Add("ClientTypeName","Client Type Name");
                dataGridViewCrudeClientTypeRef.Columns["ClientTypeName"].DataPropertyName = "ClientTypeName";
                dataGridViewCrudeClientTypeRef.Columns.Add("ClientTypeRcd","Client Type");
                dataGridViewCrudeClientTypeRef.Columns["ClientTypeRcd"].DataPropertyName = "ClientTypeRcd";
                dataGridViewCrudeClientTypeRef.Columns.Add("ClientTypeDescription","Client Type Description");
                dataGridViewCrudeClientTypeRef.Columns["ClientTypeDescription"].DataPropertyName = "ClientTypeDescription";
                dataGridViewCrudeClientTypeRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientTypeRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientTypeRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientTypeRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
