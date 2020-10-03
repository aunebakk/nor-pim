/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/3/2020 3:48:30 PM
  From Machine: DESKTOP-517I8BU
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
    public partial class CrudeClientContactMethodRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeClientContactMethodRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientContactMethodRef();
            this.AcceptButton = buttonCrudeClientContactMethodRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeClientContactMethodRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeClientContactMethodRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientContactMethodRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientContactMethodRef.CurrentRow.Cells["ClientContactMethodRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeClientContactMethodRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientContactMethodRefEdit();
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
        private void dataGridViewCrudeClientContactMethodRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientContactMethodRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientContactMethodRef.CurrentRow.Cells["ClientContactMethodRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeClientContactMethodRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientContactMethodRef();
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
        public void RefreshCrudeClientContactMethodRef() {
            var clientContactMethodRef = new CrudeClientContactMethodRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientContactMethodRef.FetchWithFilter(
                             textBoxClientContactMethod.Text
                            ,textBoxClientContactMethodName.Text
                            ,textBoxClientContactMethodDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientContactMethodRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientContactMethodRef.DataSource = bindingSource;
                dataGridViewCrudeClientContactMethodRef.AutoResizeColumns();
                dataGridViewCrudeClientContactMethodRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientContactMethodRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeClientContactMethodRef() {
            try {
                dataGridViewCrudeClientContactMethodRef.Columns.Clear();
                dataGridViewCrudeClientContactMethodRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientContactMethodRef.Columns.Add("ClientContactMethodName","Client Contact Method Name");
                dataGridViewCrudeClientContactMethodRef.Columns["ClientContactMethodName"].DataPropertyName = "ClientContactMethodName";
                dataGridViewCrudeClientContactMethodRef.Columns.Add("ClientContactMethodRcd","Client Contact Method");
                dataGridViewCrudeClientContactMethodRef.Columns["ClientContactMethodRcd"].DataPropertyName = "ClientContactMethodRcd";
                dataGridViewCrudeClientContactMethodRef.Columns.Add("ClientContactMethodDescription","Client Contact Method Description");
                dataGridViewCrudeClientContactMethodRef.Columns["ClientContactMethodDescription"].DataPropertyName = "ClientContactMethodDescription";
                dataGridViewCrudeClientContactMethodRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientContactMethodRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientContactMethodRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientContactMethodRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientContactMethodRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientContactMethodRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientContactMethodRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientContactMethodRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientContactMethodRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientContactMethodRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
