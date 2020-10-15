/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 5:30:03 PM
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
    public partial class CrudeClientNationalityRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeClientNationalityRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientNationalityRef();
            this.AcceptButton = buttonCrudeClientNationalityRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeClientNationalityRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeClientNationalityRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientNationalityRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientNationalityRef.CurrentRow.Cells["ClientNationalityRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeClientNationalityRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientNationalityRefEdit();
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
        private void dataGridViewCrudeClientNationalityRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientNationalityRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientNationalityRef.CurrentRow.Cells["ClientNationalityRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeClientNationalityRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientNationalityRef();
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
        public void RefreshCrudeClientNationalityRef() {
            var clientNationalityRef = new CrudeClientNationalityRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientNationalityRef.FetchWithFilter(
                             textBoxClientNationality.Text
                            ,textBoxClientNationalityName.Text
                            ,textBoxClientNationalityDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientNationalityRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientNationalityRef.DataSource = bindingSource;
                dataGridViewCrudeClientNationalityRef.AutoResizeColumns();
                dataGridViewCrudeClientNationalityRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientNationalityRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeClientNationalityRef() {
            try {
                dataGridViewCrudeClientNationalityRef.Columns.Clear();
                dataGridViewCrudeClientNationalityRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientNationalityRef.Columns.Add("ClientNationalityName","Client Nationality Name");
                dataGridViewCrudeClientNationalityRef.Columns["ClientNationalityName"].DataPropertyName = "ClientNationalityName";
                dataGridViewCrudeClientNationalityRef.Columns.Add("ClientNationalityRcd","Client Nationality");
                dataGridViewCrudeClientNationalityRef.Columns["ClientNationalityRcd"].DataPropertyName = "ClientNationalityRcd";
                dataGridViewCrudeClientNationalityRef.Columns.Add("ClientNationalityDescription","Client Nationality Description");
                dataGridViewCrudeClientNationalityRef.Columns["ClientNationalityDescription"].DataPropertyName = "ClientNationalityDescription";
                dataGridViewCrudeClientNationalityRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientNationalityRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientNationalityRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientNationalityRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientNationalityRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientNationalityRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientNationalityRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientNationalityRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientNationalityRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientNationalityRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
