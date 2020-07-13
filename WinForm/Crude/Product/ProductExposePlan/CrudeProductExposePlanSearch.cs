/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 3:51:02 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductExposePlanSearch : Form {
        
        private string _productExposeSetTypeRcd;
        
        private System.Guid _productId;
        
        private System.Guid _userId;
        
        public CrudeProductExposePlanSearch() {
            InitializeComponent();
            InitializeGridCrudeProductExposePlan();
            this.AcceptButton = buttonCrudeProductExposePlanSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string productExposeSetTypeRcd, System.Guid productId, System.Guid userId) {
            try {
                _productExposeSetTypeRcd = productExposeSetTypeRcd;
                _productId = productId;
                _userId = userId;
                RefreshCrudeProductExposePlan();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductExposePlanEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposePlanEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExposePlan.CurrentRow.Cells["ProductExposePlanId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductExposePlanAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposePlanEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductExposePlan_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposePlanEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExposePlan.CurrentRow.Cells["ProductExposePlanId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductExposePlanSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductExposePlan();
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
        
        public void RefreshCrudeProductExposePlan() {
            var productExposePlan = new CrudeProductExposePlanServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productExposePlan.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,productExposeSetTypeRefCombo.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductExposePlan.AutoGenerateColumns = false;
                dataGridViewCrudeProductExposePlan.DataSource = bindingSource;
                dataGridViewCrudeProductExposePlan.AutoResizeColumns();
                dataGridViewCrudeProductExposePlan.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productExposePlan.Close();
            }
        }
        
        private void InitializeGridCrudeProductExposePlan() {
            try {
                dataGridViewCrudeProductExposePlan.Columns.Clear();
                dataGridViewCrudeProductExposePlan.AutoGenerateColumns = false;
                dataGridViewCrudeProductExposePlan.Columns.Add("ProductExposeSetTypeRcd","Product Expose Set Type");
                dataGridViewCrudeProductExposePlan.Columns["ProductExposeSetTypeRcd"].DataPropertyName = "ProductExposeSetTypeRcd";
                dataGridViewCrudeProductExposePlan.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductExposePlan.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductExposePlan.Columns.Add("ProductExposePlanId","Product Expose Plan");
                dataGridViewCrudeProductExposePlan.Columns["ProductExposePlanId"].DataPropertyName = "ProductExposePlanId";
                dataGridViewCrudeProductExposePlan.Columns["ProductExposePlanId"].Visible = false;
                dataGridViewCrudeProductExposePlan.Columns.Add("ProductId","Product");
                dataGridViewCrudeProductExposePlan.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeProductExposePlan.Columns["ProductId"].Visible = false;
                dataGridViewCrudeProductExposePlan.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductExposePlan.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductExposePlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductExposePlan.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
