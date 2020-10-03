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
    public partial class CrudeClientTitleRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeClientTitleRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientTitleRef();
            this.AcceptButton = buttonCrudeClientTitleRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeClientTitleRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeClientTitleRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientTitleRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientTitleRef.CurrentRow.Cells["ClientTitleRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeClientTitleRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientTitleRefEdit();
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
        private void dataGridViewCrudeClientTitleRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientTitleRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientTitleRef.CurrentRow.Cells["ClientTitleRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeClientTitleRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientTitleRef();
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
        public void RefreshCrudeClientTitleRef() {
            var clientTitleRef = new CrudeClientTitleRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientTitleRef.FetchWithFilter(
                             textBoxClientTitle.Text
                            ,textBoxClientTitleName.Text
                            ,textBoxClientTitleDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientTitleRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientTitleRef.DataSource = bindingSource;
                dataGridViewCrudeClientTitleRef.AutoResizeColumns();
                dataGridViewCrudeClientTitleRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientTitleRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeClientTitleRef() {
            try {
                dataGridViewCrudeClientTitleRef.Columns.Clear();
                dataGridViewCrudeClientTitleRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientTitleRef.Columns.Add("ClientTitleName","Client Title Name");
                dataGridViewCrudeClientTitleRef.Columns["ClientTitleName"].DataPropertyName = "ClientTitleName";
                dataGridViewCrudeClientTitleRef.Columns.Add("ClientTitleRcd","Client Title");
                dataGridViewCrudeClientTitleRef.Columns["ClientTitleRcd"].DataPropertyName = "ClientTitleRcd";
                dataGridViewCrudeClientTitleRef.Columns.Add("ClientTitleDescription","Client Title Description");
                dataGridViewCrudeClientTitleRef.Columns["ClientTitleDescription"].DataPropertyName = "ClientTitleDescription";
                dataGridViewCrudeClientTitleRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientTitleRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientTitleRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientTitleRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientTitleRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientTitleRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientTitleRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientTitleRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientTitleRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientTitleRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
