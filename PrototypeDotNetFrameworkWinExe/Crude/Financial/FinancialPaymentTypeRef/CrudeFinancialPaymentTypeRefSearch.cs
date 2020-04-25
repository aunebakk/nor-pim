/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:44:25 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialPaymentTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeFinancialPaymentTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialPaymentTypeRef();
            this.AcceptButton = buttonCrudeFinancialPaymentTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeFinancialPaymentTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialPaymentTypeRef.CurrentRow.Cells["FinancialPaymentTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialPaymentTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialPaymentTypeRef.CurrentRow.Cells["FinancialPaymentTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialPaymentTypeRef();
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
        
        public void RefreshCrudeFinancialPaymentTypeRef() {
            var financialPaymentTypeRef = new CrudeFinancialPaymentTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialPaymentTypeRef.FetchWithFilter(
                             textBoxFinancialPaymentType.Text
                            ,textBoxFinancialPaymentTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFinancialPaymentTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialPaymentTypeRef.DataSource = bindingSource;
                dataGridViewCrudeFinancialPaymentTypeRef.AutoResizeColumns();
                dataGridViewCrudeFinancialPaymentTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialPaymentTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialPaymentTypeRef() {
            try {
                dataGridViewCrudeFinancialPaymentTypeRef.Columns.Clear();
                dataGridViewCrudeFinancialPaymentTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialPaymentTypeRef.Columns.Add("FinancialPaymentTypeName","Financial Payment Type Name");
                dataGridViewCrudeFinancialPaymentTypeRef.Columns["FinancialPaymentTypeName"].DataPropertyName = "FinancialPaymentTypeName";
                dataGridViewCrudeFinancialPaymentTypeRef.Columns.Add("FinancialPaymentTypeRcd","Financial Payment Type");
                dataGridViewCrudeFinancialPaymentTypeRef.Columns["FinancialPaymentTypeRcd"].DataPropertyName = "FinancialPaymentTypeRcd";
                dataGridViewCrudeFinancialPaymentTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialPaymentTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialPaymentTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialPaymentTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialPaymentTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialPaymentTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
