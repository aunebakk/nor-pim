/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:21:29 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultRuleTypeRefSearch : Form {
        
        private System.Guid _defaultUserId;
        
        public CrudeDefaultRuleTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultRuleTypeRef();
            this.AcceptButton = buttonCrudeDefaultRuleTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;
                RefreshCrudeDefaultRuleTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultRuleTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultRuleTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultRuleTypeRef.CurrentRow.Cells["DefaultRuleTypeRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultRuleTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultRuleTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultRuleTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultRuleTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultRuleTypeRef.CurrentRow.Cells["DefaultRuleTypeRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultRuleTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultRuleTypeRef();
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
        
        public void RefreshCrudeDefaultRuleTypeRef() {
            var defaultRuleTypeRef = new CrudeDefaultRuleTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultRuleTypeRef.FetchWithFilter(
                             textBoxDefaultRuleType.Text
                            ,textBoxDefaultRuleTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeDefaultRuleTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultRuleTypeRef.DataSource = bindingSource;
                dataGridViewCrudeDefaultRuleTypeRef.AutoResizeColumns();
                dataGridViewCrudeDefaultRuleTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultRuleTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultRuleTypeRef() {
            try {
                dataGridViewCrudeDefaultRuleTypeRef.Columns.Clear();
                dataGridViewCrudeDefaultRuleTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultRuleTypeRef.Columns.Add("DefaultRuleTypeName","Default Rule Type Name");
                dataGridViewCrudeDefaultRuleTypeRef.Columns["DefaultRuleTypeName"].DataPropertyName = "DefaultRuleTypeName";
                dataGridViewCrudeDefaultRuleTypeRef.Columns.Add("DefaultRuleTypeRcd","Default Rule Type");
                dataGridViewCrudeDefaultRuleTypeRef.Columns["DefaultRuleTypeRcd"].DataPropertyName = "DefaultRuleTypeRcd";
                dataGridViewCrudeDefaultRuleTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultRuleTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultRuleTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultRuleTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultRuleTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultRuleTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
