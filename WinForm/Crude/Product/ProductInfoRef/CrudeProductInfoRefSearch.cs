/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 9:07:08 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductInfoRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeProductInfoRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductInfoRef();
            this.AcceptButton = buttonCrudeProductInfoRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeProductInfoRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductInfoRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductInfoRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductInfoRef.CurrentRow.Cells["ProductInfoRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductInfoRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductInfoRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductInfoRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductInfoRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductInfoRef.CurrentRow.Cells["ProductInfoRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductInfoRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductInfoRef();
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
        
        public void RefreshCrudeProductInfoRef() {
            var productInfoRef = new CrudeProductInfoRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productInfoRef.FetchWithFilter(
                             textBoxProductInfo.Text
                            ,textBoxProductInfoName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductInfoRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductInfoRef.DataSource = bindingSource;
                dataGridViewCrudeProductInfoRef.AutoResizeColumns();
                dataGridViewCrudeProductInfoRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productInfoRef.Close();
            }
        }
        
        private void InitializeGridCrudeProductInfoRef() {
            try {
                dataGridViewCrudeProductInfoRef.Columns.Clear();
                dataGridViewCrudeProductInfoRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductInfoRef.Columns.Add("ProductInfoName","Product Info Name");
                dataGridViewCrudeProductInfoRef.Columns["ProductInfoName"].DataPropertyName = "ProductInfoName";
                dataGridViewCrudeProductInfoRef.Columns.Add("ProductInfoRcd","Product Info");
                dataGridViewCrudeProductInfoRef.Columns["ProductInfoRcd"].DataPropertyName = "ProductInfoRcd";
                dataGridViewCrudeProductInfoRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductInfoRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductInfoRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductInfoRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductInfoRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductInfoRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
