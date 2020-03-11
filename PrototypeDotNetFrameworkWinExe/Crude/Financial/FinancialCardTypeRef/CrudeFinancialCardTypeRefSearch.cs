/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:29:23 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialCardTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeFinancialCardTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialCardTypeRef();
            this.AcceptButton = buttonCrudeFinancialCardTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeFinancialCardTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialCardTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCardTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialCardTypeRef.CurrentRow.Cells["FinancialCardTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialCardTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCardTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialCardTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCardTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialCardTypeRef.CurrentRow.Cells["FinancialCardTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialCardTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialCardTypeRef();
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
        
        public void RefreshCrudeFinancialCardTypeRef() {
            var financialCardTypeRef = new CrudeFinancialCardTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialCardTypeRef.FetchWithFilter(
                             textBoxFinancialCardType.Text
                            ,textBoxFinancialCardTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFinancialCardTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialCardTypeRef.DataSource = bindingSource;
                dataGridViewCrudeFinancialCardTypeRef.AutoResizeColumns();
                dataGridViewCrudeFinancialCardTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialCardTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialCardTypeRef() {
            try {
                dataGridViewCrudeFinancialCardTypeRef.Columns.Clear();
                dataGridViewCrudeFinancialCardTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialCardTypeRef.Columns.Add("FinancialCardTypeName","Financial Card Type Name");
                dataGridViewCrudeFinancialCardTypeRef.Columns["FinancialCardTypeName"].DataPropertyName = "FinancialCardTypeName";
                dataGridViewCrudeFinancialCardTypeRef.Columns.Add("FinancialCardTypeRcd","Financial Card Type");
                dataGridViewCrudeFinancialCardTypeRef.Columns["FinancialCardTypeRcd"].DataPropertyName = "FinancialCardTypeRcd";
                dataGridViewCrudeFinancialCardTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialCardTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialCardTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialCardTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialCardTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialCardTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
