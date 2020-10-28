/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 9:23:12 PM
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
    public partial class CrudeFinancialOrderSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeFinancialOrderSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialOrder();
            this.AcceptButton = buttonCrudeFinancialOrderSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeFinancialOrder();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeFinancialOrderEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialOrder.CurrentRow.Cells["FinancialOrderId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeFinancialOrderAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderEdit();
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
        private void dataGridViewCrudeFinancialOrder_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialOrder.CurrentRow.Cells["FinancialOrderId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeFinancialOrderSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialOrder();
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
        public void RefreshCrudeFinancialOrder() {
            var financialOrder = new CrudeFinancialOrderServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialOrder.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,textBoxComment.Text
                            ,Guid.Empty
                            ,Guid.Empty
                            ,textBoxFinancialOrderSource.Text
                            ,Guid.Empty
                            );
                dataGridViewCrudeFinancialOrder.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialOrder.DataSource = bindingSource;
                dataGridViewCrudeFinancialOrder.AutoResizeColumns();
                dataGridViewCrudeFinancialOrder.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialOrder.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeFinancialOrder() {
            try {
                dataGridViewCrudeFinancialOrder.Columns.Clear();
                dataGridViewCrudeFinancialOrder.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialOrder.Columns.Add("Comment","Comment");
                dataGridViewCrudeFinancialOrder.Columns["Comment"].DataPropertyName = "Comment";
                dataGridViewCrudeFinancialOrder.Columns.Add("FinancialOrderSourceRcd","Financial Order Source");
                dataGridViewCrudeFinancialOrder.Columns["FinancialOrderSourceRcd"].DataPropertyName = "FinancialOrderSourceRcd";
                dataGridViewCrudeFinancialOrder.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialOrder.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialOrder.Columns.Add("FinancialOrderId","Financial Order");
                dataGridViewCrudeFinancialOrder.Columns["FinancialOrderId"].DataPropertyName = "FinancialOrderId";
                dataGridViewCrudeFinancialOrder.Columns["FinancialOrderId"].Visible = false;
                dataGridViewCrudeFinancialOrder.Columns.Add("LocationAddressId","Location Address");
                dataGridViewCrudeFinancialOrder.Columns["LocationAddressId"].DataPropertyName = "LocationAddressId";
                dataGridViewCrudeFinancialOrder.Columns["LocationAddressId"].Visible = false;
                dataGridViewCrudeFinancialOrder.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeFinancialOrder.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeFinancialOrder.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeFinancialOrder.Columns.Add("ClientId","Client");
                dataGridViewCrudeFinancialOrder.Columns["ClientId"].DataPropertyName = "ClientId";
                dataGridViewCrudeFinancialOrder.Columns["ClientId"].Visible = false;
                dataGridViewCrudeFinancialOrder.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialOrder.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialOrder.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
