/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 5:34:14 PM
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
    public partial class CrudeDefaultRuleSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private string _defaultRuleTypeRcd;
        
        private System.Guid _defaultUserId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultRuleSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultRule();
            this.AcceptButton = buttonCrudeDefaultRuleSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(string defaultRuleTypeRcd, System.Guid defaultUserId) {
            try {
                _defaultRuleTypeRcd = defaultRuleTypeRcd;
                _defaultUserId = defaultUserId;

                RefreshCrudeDefaultRule();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeDefaultRuleEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultRuleEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultRule.CurrentRow.Cells["DefaultRuleId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeDefaultRuleAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultRuleEdit();
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
        private void dataGridViewCrudeDefaultRule_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultRuleEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultRule.CurrentRow.Cells["DefaultRuleId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeDefaultRuleSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultRule();
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
        public void RefreshCrudeDefaultRule() {
            var defaultRule = new CrudeDefaultRuleServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultRule.FetchWithFilter(
                             Guid.Empty
                            ,defaultRuleTypeRefCombo.Text
                            ,textBoxAddress.Text
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultRule.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultRule.DataSource = bindingSource;
                dataGridViewCrudeDefaultRule.AutoResizeColumns();
                dataGridViewCrudeDefaultRule.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultRule.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeDefaultRule() {
            try {
                dataGridViewCrudeDefaultRule.Columns.Clear();
                dataGridViewCrudeDefaultRule.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultRule.Columns.Add("DefaultRuleTypeRcd","Default Rule Type");
                dataGridViewCrudeDefaultRule.Columns["DefaultRuleTypeRcd"].DataPropertyName = "DefaultRuleTypeRcd";
                dataGridViewCrudeDefaultRule.Columns.Add("Address","Address");
                dataGridViewCrudeDefaultRule.Columns["Address"].DataPropertyName = "Address";
                dataGridViewCrudeDefaultRule.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultRule.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultRule.Columns.Add("DefaultRuleId","Default Rule");
                dataGridViewCrudeDefaultRule.Columns["DefaultRuleId"].DataPropertyName = "DefaultRuleId";
                dataGridViewCrudeDefaultRule.Columns["DefaultRuleId"].Visible = false;
                dataGridViewCrudeDefaultRule.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultRule.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultRule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultRule.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
