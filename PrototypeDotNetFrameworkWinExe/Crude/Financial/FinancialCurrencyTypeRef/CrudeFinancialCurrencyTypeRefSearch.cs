/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:43:39 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialCurrencyTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeFinancialCurrencyTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialCurrencyTypeRef();
            this.AcceptButton = buttonCrudeFinancialCurrencyTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeFinancialCurrencyTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialCurrencyTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCurrencyTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialCurrencyTypeRef.CurrentRow.Cells["FinancialCurrencyTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialCurrencyTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCurrencyTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialCurrencyTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCurrencyTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialCurrencyTypeRef.CurrentRow.Cells["FinancialCurrencyTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialCurrencyTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialCurrencyTypeRef();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        public void RefreshCrudeFinancialCurrencyTypeRef() {
            var financialCurrencyTypeRef = new CrudeFinancialCurrencyTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialCurrencyTypeRef.FetchWithFilter(
                             textBoxFinancialCurrencyType.Text
                            ,textBoxFinancialCurrencyTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,maskedTextBoxDecimalCount.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxDecimalCount.Text)
                            ,textBoxFinancialCurrencyTypeCode.Text
                            );
                dataGridViewCrudeFinancialCurrencyTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialCurrencyTypeRef.DataSource = bindingSource;
                dataGridViewCrudeFinancialCurrencyTypeRef.AutoResizeColumns();
                dataGridViewCrudeFinancialCurrencyTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialCurrencyTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialCurrencyTypeRef() {
            try {
                dataGridViewCrudeFinancialCurrencyTypeRef.Columns.Clear();
                dataGridViewCrudeFinancialCurrencyTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialCurrencyTypeRef.Columns.Add("FinancialCurrencyTypeName","Financial Currency Type Name");
                dataGridViewCrudeFinancialCurrencyTypeRef.Columns["FinancialCurrencyTypeName"].DataPropertyName = "FinancialCurrencyTypeName";
                dataGridViewCrudeFinancialCurrencyTypeRef.Columns.Add("FinancialCurrencyTypeRcd","Financial Currency Type");
                dataGridViewCrudeFinancialCurrencyTypeRef.Columns["FinancialCurrencyTypeRcd"].DataPropertyName = "FinancialCurrencyTypeRcd";
                dataGridViewCrudeFinancialCurrencyTypeRef.Columns.Add("FinancialCurrencyTypeCode","Financial Currency Type Code");
                dataGridViewCrudeFinancialCurrencyTypeRef.Columns["FinancialCurrencyTypeCode"].DataPropertyName = "FinancialCurrencyTypeCode";
                dataGridViewCrudeFinancialCurrencyTypeRef.Columns.Add("DecimalCount","Decimal Count");
                dataGridViewCrudeFinancialCurrencyTypeRef.Columns["DecimalCount"].DataPropertyName = "DecimalCount";
                dataGridViewCrudeFinancialCurrencyTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialCurrencyTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialCurrencyTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialCurrencyTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialCurrencyTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialCurrencyTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
