/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 6:15:29 PM
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
    public partial class CrudeClientEventTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeClientEventTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientEventTypeRef();
            this.AcceptButton = buttonCrudeClientEventTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeClientEventTypeRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeClientEventTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientEventTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientEventTypeRef.CurrentRow.Cells["ClientEventTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeClientEventTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientEventTypeRefEdit();
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
        private void dataGridViewCrudeClientEventTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientEventTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientEventTypeRef.CurrentRow.Cells["ClientEventTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeClientEventTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientEventTypeRef();
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
        public void RefreshCrudeClientEventTypeRef() {
            var clientEventTypeRef = new CrudeClientEventTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientEventTypeRef.FetchWithFilter(
                             textBoxClientEventType.Text
                            ,textBoxClientEventTypeName.Text
                            ,textBoxClientEventTypeDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientEventTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientEventTypeRef.DataSource = bindingSource;
                dataGridViewCrudeClientEventTypeRef.AutoResizeColumns();
                dataGridViewCrudeClientEventTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientEventTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeClientEventTypeRef() {
            try {
                dataGridViewCrudeClientEventTypeRef.Columns.Clear();
                dataGridViewCrudeClientEventTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientEventTypeRef.Columns.Add("ClientEventTypeName","Client Event Type Name");
                dataGridViewCrudeClientEventTypeRef.Columns["ClientEventTypeName"].DataPropertyName = "ClientEventTypeName";
                dataGridViewCrudeClientEventTypeRef.Columns.Add("ClientEventTypeRcd","Client Event Type");
                dataGridViewCrudeClientEventTypeRef.Columns["ClientEventTypeRcd"].DataPropertyName = "ClientEventTypeRcd";
                dataGridViewCrudeClientEventTypeRef.Columns.Add("ClientEventTypeDescription","Client Event Type Description");
                dataGridViewCrudeClientEventTypeRef.Columns["ClientEventTypeDescription"].DataPropertyName = "ClientEventTypeDescription";
                dataGridViewCrudeClientEventTypeRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientEventTypeRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientEventTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientEventTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientEventTypeRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientEventTypeRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientEventTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientEventTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientEventTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientEventTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
