/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 4:28:18 AM
  From Machine: DESKTOP-9A2DH39
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
    public partial class CrudeDefaultVersionSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _defaultUserId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultVersionSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultVersion();
            this.AcceptButton = buttonCrudeDefaultVersionSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;

                RefreshCrudeDefaultVersion();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeDefaultVersionEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultVersionEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultVersion.CurrentRow.Cells["DefaultVersionId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeDefaultVersionAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultVersionEdit();
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
        private void dataGridViewCrudeDefaultVersion_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultVersionEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultVersion.CurrentRow.Cells["DefaultVersionId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeDefaultVersionSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultVersion();
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
        public void RefreshCrudeDefaultVersion() {
            var defaultVersion = new CrudeDefaultVersionServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultVersion.FetchWithFilter(
                             Guid.Empty
                            ,textBoxFunVersion.Text
                            ,textBoxNumber.Text
                            ,maskedTextBoxMajorNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxMajorNumber.Text)
                            ,maskedTextBoxMinorNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxMinorNumber.Text)
                            ,maskedTextBoxSequenceNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSequenceNumber.Text)
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultVersion.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultVersion.DataSource = bindingSource;
                dataGridViewCrudeDefaultVersion.AutoResizeColumns();
                dataGridViewCrudeDefaultVersion.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultVersion.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeDefaultVersion() {
            try {
                dataGridViewCrudeDefaultVersion.Columns.Clear();
                dataGridViewCrudeDefaultVersion.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultVersion.Columns.Add("FunVersion","Fun Version");
                dataGridViewCrudeDefaultVersion.Columns["FunVersion"].DataPropertyName = "FunVersion";
                dataGridViewCrudeDefaultVersion.Columns.Add("Number","Number");
                dataGridViewCrudeDefaultVersion.Columns["Number"].DataPropertyName = "Number";
                dataGridViewCrudeDefaultVersion.Columns.Add("MajorNumber","Major Number");
                dataGridViewCrudeDefaultVersion.Columns["MajorNumber"].DataPropertyName = "MajorNumber";
                dataGridViewCrudeDefaultVersion.Columns.Add("MinorNumber","Minor Number");
                dataGridViewCrudeDefaultVersion.Columns["MinorNumber"].DataPropertyName = "MinorNumber";
                dataGridViewCrudeDefaultVersion.Columns.Add("SequenceNumber","Sequence Number");
                dataGridViewCrudeDefaultVersion.Columns["SequenceNumber"].DataPropertyName = "SequenceNumber";
                dataGridViewCrudeDefaultVersion.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultVersion.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultVersion.Columns.Add("DefaultVersionId","Default Version");
                dataGridViewCrudeDefaultVersion.Columns["DefaultVersionId"].DataPropertyName = "DefaultVersionId";
                dataGridViewCrudeDefaultVersion.Columns["DefaultVersionId"].Visible = false;
                dataGridViewCrudeDefaultVersion.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultVersion.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultVersion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultVersion.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
