/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 8:33:33 PM
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
    public partial class CrudeClientAddressTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeClientAddressTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientAddressTypeRef();
            this.AcceptButton = buttonCrudeClientAddressTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeClientAddressTypeRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeClientAddressTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientAddressTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientAddressTypeRef.CurrentRow.Cells["ClientAddressTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeClientAddressTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientAddressTypeRefEdit();
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
        private void dataGridViewCrudeClientAddressTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientAddressTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientAddressTypeRef.CurrentRow.Cells["ClientAddressTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeClientAddressTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientAddressTypeRef();
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
        public void RefreshCrudeClientAddressTypeRef() {
            var clientAddressTypeRef = new CrudeClientAddressTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientAddressTypeRef.FetchWithFilter(
                             textBoxClientAddressType.Text
                            ,textBoxClientAddressTypeName.Text
                            ,textBoxClientAddressTypeDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientAddressTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientAddressTypeRef.DataSource = bindingSource;
                dataGridViewCrudeClientAddressTypeRef.AutoResizeColumns();
                dataGridViewCrudeClientAddressTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientAddressTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeClientAddressTypeRef() {
            try {
                dataGridViewCrudeClientAddressTypeRef.Columns.Clear();
                dataGridViewCrudeClientAddressTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientAddressTypeRef.Columns.Add("ClientAddressTypeName","Client Address Type Name");
                dataGridViewCrudeClientAddressTypeRef.Columns["ClientAddressTypeName"].DataPropertyName = "ClientAddressTypeName";
                dataGridViewCrudeClientAddressTypeRef.Columns.Add("ClientAddressTypeRcd","Client Address Type");
                dataGridViewCrudeClientAddressTypeRef.Columns["ClientAddressTypeRcd"].DataPropertyName = "ClientAddressTypeRcd";
                dataGridViewCrudeClientAddressTypeRef.Columns.Add("ClientAddressTypeDescription","Client Address Type Description");
                dataGridViewCrudeClientAddressTypeRef.Columns["ClientAddressTypeDescription"].DataPropertyName = "ClientAddressTypeDescription";
                dataGridViewCrudeClientAddressTypeRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientAddressTypeRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientAddressTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientAddressTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientAddressTypeRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientAddressTypeRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientAddressTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientAddressTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientAddressTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientAddressTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
