/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 4:09:33 PM
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
    public partial class CrudeClientGenderRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeClientGenderRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientGenderRef();
            this.AcceptButton = buttonCrudeClientGenderRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeClientGenderRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeClientGenderRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientGenderRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientGenderRef.CurrentRow.Cells["ClientGenderRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeClientGenderRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientGenderRefEdit();
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
        private void dataGridViewCrudeClientGenderRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientGenderRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientGenderRef.CurrentRow.Cells["ClientGenderRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeClientGenderRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientGenderRef();
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
        public void RefreshCrudeClientGenderRef() {
            var clientGenderRef = new CrudeClientGenderRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientGenderRef.FetchWithFilter(
                             textBoxClientGender.Text
                            ,textBoxClientGenderName.Text
                            ,textBoxClientGenderDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientGenderRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientGenderRef.DataSource = bindingSource;
                dataGridViewCrudeClientGenderRef.AutoResizeColumns();
                dataGridViewCrudeClientGenderRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientGenderRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeClientGenderRef() {
            try {
                dataGridViewCrudeClientGenderRef.Columns.Clear();
                dataGridViewCrudeClientGenderRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientGenderRef.Columns.Add("ClientGenderName","Client Gender Name");
                dataGridViewCrudeClientGenderRef.Columns["ClientGenderName"].DataPropertyName = "ClientGenderName";
                dataGridViewCrudeClientGenderRef.Columns.Add("ClientGenderRcd","Client Gender");
                dataGridViewCrudeClientGenderRef.Columns["ClientGenderRcd"].DataPropertyName = "ClientGenderRcd";
                dataGridViewCrudeClientGenderRef.Columns.Add("ClientGenderDescription","Client Gender Description");
                dataGridViewCrudeClientGenderRef.Columns["ClientGenderDescription"].DataPropertyName = "ClientGenderDescription";
                dataGridViewCrudeClientGenderRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientGenderRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientGenderRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientGenderRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientGenderRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientGenderRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientGenderRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientGenderRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientGenderRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientGenderRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
