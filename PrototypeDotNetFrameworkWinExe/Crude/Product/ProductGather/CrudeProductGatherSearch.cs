/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:03:45 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductGatherSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeProductGatherSearch() {
            InitializeComponent();
            InitializeGridCrudeProductGather();
            this.AcceptButton = buttonCrudeProductGatherSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeProductGather();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductGatherEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGather.CurrentRow.Cells["ProductGatherId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductGatherAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductGather_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGather.CurrentRow.Cells["ProductGatherId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductGatherSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductGather();
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
        
        public void RefreshCrudeProductGather() {
            var productGather = new CrudeProductGatherServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productGather.FetchWithFilter(
                             Guid.Empty
                            ,dateTimePickerStartDateTime.Checked ? Convert.ToDateTime(dateTimePickerStartDateTime.Value): DateTime.MinValue
                            ,dateTimePickerFinishDateTime.Checked ? Convert.ToDateTime(dateTimePickerFinishDateTime.Value): DateTime.MinValue
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductGather.AutoGenerateColumns = false;
                dataGridViewCrudeProductGather.DataSource = bindingSource;
                dataGridViewCrudeProductGather.AutoResizeColumns();
                dataGridViewCrudeProductGather.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productGather.Close();
            }
        }
        
        private void InitializeGridCrudeProductGather() {
            try {
                dataGridViewCrudeProductGather.Columns.Clear();
                dataGridViewCrudeProductGather.AutoGenerateColumns = false;
                dataGridViewCrudeProductGather.Columns.Add("StartDateTime","Start Date Time");
                dataGridViewCrudeProductGather.Columns["StartDateTime"].DataPropertyName = "StartDateTime";
                dataGridViewCrudeProductGather.Columns.Add("FinishDateTime","Finish Date Time");
                dataGridViewCrudeProductGather.Columns["FinishDateTime"].DataPropertyName = "FinishDateTime";
                dataGridViewCrudeProductGather.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductGather.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductGather.Columns.Add("ProductGatherId","Product Gather");
                dataGridViewCrudeProductGather.Columns["ProductGatherId"].DataPropertyName = "ProductGatherId";
                dataGridViewCrudeProductGather.Columns["ProductGatherId"].Visible = false;
                dataGridViewCrudeProductGather.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductGather.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductGather.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductGather.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
