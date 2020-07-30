/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/30/2020 6:40:43 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductGatherAttributeTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeProductGatherAttributeTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductGatherAttributeTypeRef();
            this.AcceptButton = buttonCrudeProductGatherAttributeTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeProductGatherAttributeTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductGatherAttributeTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherAttributeTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductGatherAttributeTypeRef.CurrentRow.Cells["ProductGatherAttributeTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductGatherAttributeTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherAttributeTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductGatherAttributeTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherAttributeTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductGatherAttributeTypeRef.CurrentRow.Cells["ProductGatherAttributeTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductGatherAttributeTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductGatherAttributeTypeRef();
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
        
        public void RefreshCrudeProductGatherAttributeTypeRef() {
            var productGatherAttributeTypeRef = new CrudeProductGatherAttributeTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productGatherAttributeTypeRef.FetchWithFilter(
                             textBoxProductGatherAttributeType.Text
                            ,textBoxProductGatherAttributeTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductGatherAttributeTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherAttributeTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductGatherAttributeTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductGatherAttributeTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productGatherAttributeTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeProductGatherAttributeTypeRef() {
            try {
                dataGridViewCrudeProductGatherAttributeTypeRef.Columns.Clear();
                dataGridViewCrudeProductGatherAttributeTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherAttributeTypeRef.Columns.Add("ProductGatherAttributeTypeName","Product Gather Attribute Type Name");
                dataGridViewCrudeProductGatherAttributeTypeRef.Columns["ProductGatherAttributeTypeName"].DataPropertyName = "ProductGatherAttributeTypeName";
                dataGridViewCrudeProductGatherAttributeTypeRef.Columns.Add("ProductGatherAttributeTypeRcd","Product Gather Attribute Type");
                dataGridViewCrudeProductGatherAttributeTypeRef.Columns["ProductGatherAttributeTypeRcd"].DataPropertyName = "ProductGatherAttributeTypeRcd";
                dataGridViewCrudeProductGatherAttributeTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductGatherAttributeTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductGatherAttributeTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductGatherAttributeTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductGatherAttributeTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductGatherAttributeTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
