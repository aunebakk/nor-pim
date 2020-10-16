/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 4:12:38 AM
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
    public partial class CrudeDefaultRuleTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _defaultUserId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultRuleTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultRuleTypeRef();
            this.AcceptButton = buttonCrudeDefaultRuleTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;

                RefreshCrudeDefaultRuleTypeRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeDefaultRuleTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultRuleTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultRuleTypeRef.CurrentRow.Cells["DefaultRuleTypeRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeDefaultRuleTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultRuleTypeRefEdit();
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
        private void dataGridViewCrudeDefaultRuleTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultRuleTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultRuleTypeRef.CurrentRow.Cells["DefaultRuleTypeRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeDefaultRuleTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultRuleTypeRef();
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
        public void RefreshCrudeDefaultRuleTypeRef() {
            var defaultRuleTypeRef = new CrudeDefaultRuleTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultRuleTypeRef.FetchWithFilter(
                             textBoxDefaultRuleType.Text
                            ,textBoxDefaultRuleTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeDefaultRuleTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultRuleTypeRef.DataSource = bindingSource;
                dataGridViewCrudeDefaultRuleTypeRef.AutoResizeColumns();
                dataGridViewCrudeDefaultRuleTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultRuleTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeDefaultRuleTypeRef() {
            try {
                dataGridViewCrudeDefaultRuleTypeRef.Columns.Clear();
                dataGridViewCrudeDefaultRuleTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultRuleTypeRef.Columns.Add("DefaultRuleTypeName","Default Rule Type Name");
                dataGridViewCrudeDefaultRuleTypeRef.Columns["DefaultRuleTypeName"].DataPropertyName = "DefaultRuleTypeName";
                dataGridViewCrudeDefaultRuleTypeRef.Columns.Add("DefaultRuleTypeRcd","Default Rule Type");
                dataGridViewCrudeDefaultRuleTypeRef.Columns["DefaultRuleTypeRcd"].DataPropertyName = "DefaultRuleTypeRcd";
                dataGridViewCrudeDefaultRuleTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultRuleTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultRuleTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultRuleTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultRuleTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultRuleTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
