/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 3:40:19 PM
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
    public partial class CrudeClientLinkTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeClientLinkTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientLinkTypeRef();
            this.AcceptButton = buttonCrudeClientLinkTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeClientLinkTypeRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeClientLinkTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientLinkTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientLinkTypeRef.CurrentRow.Cells["ClientLinkTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeClientLinkTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientLinkTypeRefEdit();
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
        private void dataGridViewCrudeClientLinkTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientLinkTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientLinkTypeRef.CurrentRow.Cells["ClientLinkTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeClientLinkTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientLinkTypeRef();
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
        public void RefreshCrudeClientLinkTypeRef() {
            var clientLinkTypeRef = new CrudeClientLinkTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientLinkTypeRef.FetchWithFilter(
                             textBoxClientLinkType.Text
                            ,textBoxClientLinkTypeName.Text
                            ,textBoxClientLinkTypeDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientLinkTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientLinkTypeRef.DataSource = bindingSource;
                dataGridViewCrudeClientLinkTypeRef.AutoResizeColumns();
                dataGridViewCrudeClientLinkTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientLinkTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeClientLinkTypeRef() {
            try {
                dataGridViewCrudeClientLinkTypeRef.Columns.Clear();
                dataGridViewCrudeClientLinkTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("ClientLinkTypeName","Client Link Type Name");
                dataGridViewCrudeClientLinkTypeRef.Columns["ClientLinkTypeName"].DataPropertyName = "ClientLinkTypeName";
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("ClientLinkTypeRcd","Client Link Type");
                dataGridViewCrudeClientLinkTypeRef.Columns["ClientLinkTypeRcd"].DataPropertyName = "ClientLinkTypeRcd";
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("ClientLinkTypeDescription","Client Link Type Description");
                dataGridViewCrudeClientLinkTypeRef.Columns["ClientLinkTypeDescription"].DataPropertyName = "ClientLinkTypeDescription";
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientLinkTypeRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientLinkTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientLinkTypeRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientLinkTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientLinkTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientLinkTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
