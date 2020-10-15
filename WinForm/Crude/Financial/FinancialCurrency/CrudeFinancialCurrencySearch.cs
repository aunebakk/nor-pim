/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 5:30:04 PM
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
    public partial class CrudeFinancialCurrencySearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeFinancialCurrencySearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialCurrency();
            this.AcceptButton = buttonCrudeFinancialCurrencySearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeFinancialCurrency();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeFinancialCurrencyEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCurrencyEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialCurrency.CurrentRow.Cells["FinancialCurrencyId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeFinancialCurrencyAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCurrencyEdit();
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
        private void dataGridViewCrudeFinancialCurrency_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCurrencyEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialCurrency.CurrentRow.Cells["FinancialCurrencyId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeFinancialCurrencySearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialCurrency();
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
        public void RefreshCrudeFinancialCurrency() {
            var financialCurrency = new CrudeFinancialCurrencyServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialCurrency.FetchWithFilter(
                             Guid.Empty
                            ,textBoxFinancialCurrencyType.Text
                            ,textBoxFinancialCurrencyAgainstFinancialCurrencyType.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,dateTimePickerValidFromDateTime.Checked ? Convert.ToDateTime(dateTimePickerValidFromDateTime.Value): DateTime.MinValue
                            ,dateTimePickerValidUntilDateTime.Checked ? Convert.ToDateTime(dateTimePickerValidUntilDateTime.Value): DateTime.MinValue
                            ,maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text)
                            ,maskedTextBoxEqualsAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxEqualsAmount.Text)
                            ,maskedTextBoxDecimalCount.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxDecimalCount.Text)
                            ,textBoxFinancialCurrencyTypeCode.Text
                            ,textBoxFinancialCurrencyTypeName.Text
                            );
                dataGridViewCrudeFinancialCurrency.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialCurrency.DataSource = bindingSource;
                dataGridViewCrudeFinancialCurrency.AutoResizeColumns();
                dataGridViewCrudeFinancialCurrency.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialCurrency.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeFinancialCurrency() {
            try {
                dataGridViewCrudeFinancialCurrency.Columns.Clear();
                dataGridViewCrudeFinancialCurrency.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialCurrency.Columns.Add("FinancialCurrencyTypeName","Financial Currency Type Name");
                dataGridViewCrudeFinancialCurrency.Columns["FinancialCurrencyTypeName"].DataPropertyName = "FinancialCurrencyTypeName";
                dataGridViewCrudeFinancialCurrency.Columns.Add("FinancialCurrencyTypeRcd","Financial Currency Type");
                dataGridViewCrudeFinancialCurrency.Columns["FinancialCurrencyTypeRcd"].DataPropertyName = "FinancialCurrencyTypeRcd";
                dataGridViewCrudeFinancialCurrency.Columns.Add("FinancialCurrencyAgainstFinancialCurrencyTypeRcd","Financial Currency Against Financial Currency Type");
                dataGridViewCrudeFinancialCurrency.Columns["FinancialCurrencyAgainstFinancialCurrencyTypeRcd"].DataPropertyName = "FinancialCurrencyAgainstFinancialCurrencyTypeRcd";
                dataGridViewCrudeFinancialCurrency.Columns.Add("FinancialCurrencyTypeCode","Financial Currency Type Code");
                dataGridViewCrudeFinancialCurrency.Columns["FinancialCurrencyTypeCode"].DataPropertyName = "FinancialCurrencyTypeCode";
                dataGridViewCrudeFinancialCurrency.Columns.Add("Amount","Amount");
                dataGridViewCrudeFinancialCurrency.Columns["Amount"].DataPropertyName = "Amount";
                dataGridViewCrudeFinancialCurrency.Columns.Add("EqualsAmount","Equals Amount");
                dataGridViewCrudeFinancialCurrency.Columns["EqualsAmount"].DataPropertyName = "EqualsAmount";
                dataGridViewCrudeFinancialCurrency.Columns.Add("DecimalCount","Decimal Count");
                dataGridViewCrudeFinancialCurrency.Columns["DecimalCount"].DataPropertyName = "DecimalCount";
                dataGridViewCrudeFinancialCurrency.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialCurrency.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialCurrency.Columns.Add("ValidFromDateTime","Valid From Date Time");
                dataGridViewCrudeFinancialCurrency.Columns["ValidFromDateTime"].DataPropertyName = "ValidFromDateTime";
                dataGridViewCrudeFinancialCurrency.Columns.Add("ValidUntilDateTime","Valid Until Date Time");
                dataGridViewCrudeFinancialCurrency.Columns["ValidUntilDateTime"].DataPropertyName = "ValidUntilDateTime";
                dataGridViewCrudeFinancialCurrency.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeFinancialCurrency.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeFinancialCurrency.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeFinancialCurrency.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialCurrency.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialCurrency.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialCurrency.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
