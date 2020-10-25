/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/25/2020 9:15:07 AM
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
    public partial class CrudeClientDocumentTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeClientDocumentTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientDocumentTypeRef();
            this.AcceptButton = buttonCrudeClientDocumentTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeClientDocumentTypeRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeClientDocumentTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientDocumentTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientDocumentTypeRef.CurrentRow.Cells["ClientDocumentTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeClientDocumentTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientDocumentTypeRefEdit();
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
        private void dataGridViewCrudeClientDocumentTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientDocumentTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientDocumentTypeRef.CurrentRow.Cells["ClientDocumentTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeClientDocumentTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientDocumentTypeRef();
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
        public void RefreshCrudeClientDocumentTypeRef() {
            var clientDocumentTypeRef = new CrudeClientDocumentTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientDocumentTypeRef.FetchWithFilter(
                             textBoxClientDocumentType.Text
                            ,textBoxClientDocumentTypeName.Text
                            ,textBoxClientDocumentTypeDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientDocumentTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientDocumentTypeRef.DataSource = bindingSource;
                dataGridViewCrudeClientDocumentTypeRef.AutoResizeColumns();
                dataGridViewCrudeClientDocumentTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientDocumentTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeClientDocumentTypeRef() {
            try {
                dataGridViewCrudeClientDocumentTypeRef.Columns.Clear();
                dataGridViewCrudeClientDocumentTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientDocumentTypeRef.Columns.Add("ClientDocumentTypeName","Client Document Type Name");
                dataGridViewCrudeClientDocumentTypeRef.Columns["ClientDocumentTypeName"].DataPropertyName = "ClientDocumentTypeName";
                dataGridViewCrudeClientDocumentTypeRef.Columns.Add("ClientDocumentTypeRcd","Client Document Type");
                dataGridViewCrudeClientDocumentTypeRef.Columns["ClientDocumentTypeRcd"].DataPropertyName = "ClientDocumentTypeRcd";
                dataGridViewCrudeClientDocumentTypeRef.Columns.Add("ClientDocumentTypeDescription","Client Document Type Description");
                dataGridViewCrudeClientDocumentTypeRef.Columns["ClientDocumentTypeDescription"].DataPropertyName = "ClientDocumentTypeDescription";
                dataGridViewCrudeClientDocumentTypeRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientDocumentTypeRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientDocumentTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientDocumentTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientDocumentTypeRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientDocumentTypeRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientDocumentTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientDocumentTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientDocumentTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientDocumentTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
