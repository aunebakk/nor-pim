/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 1:46:15 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultRuleSearch : Form {
        
        private string _defaultRuleTypeRcd;
        
        private System.Guid _defaultUserId;
        
        public CrudeDefaultRuleSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultRule();
            this.AcceptButton = buttonCrudeDefaultRuleSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string defaultRuleTypeRcd, System.Guid defaultUserId) {
            try {
                _defaultRuleTypeRcd = defaultRuleTypeRcd;
                _defaultUserId = defaultUserId;
                RefreshCrudeDefaultRule();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultRuleEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultRuleEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultRule.CurrentRow.Cells["DefaultRuleId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultRuleAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultRuleEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultRule_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultRuleEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultRule.CurrentRow.Cells["DefaultRuleId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultRuleSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultRule();
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
        
        public void RefreshCrudeDefaultRule() {
            var defaultRule = new CrudeDefaultRuleServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultRule.FetchWithFilter(
                             Guid.Empty
                            ,defaultRuleTypeRefCombo.Text
                            ,textBoxAddress.Text
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultRule.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultRule.DataSource = bindingSource;
                dataGridViewCrudeDefaultRule.AutoResizeColumns();
                dataGridViewCrudeDefaultRule.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultRule.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultRule() {
            try {
                dataGridViewCrudeDefaultRule.Columns.Clear();
                dataGridViewCrudeDefaultRule.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultRule.Columns.Add("DefaultRuleTypeRcd","Default Rule Type");
                dataGridViewCrudeDefaultRule.Columns["DefaultRuleTypeRcd"].DataPropertyName = "DefaultRuleTypeRcd";
                dataGridViewCrudeDefaultRule.Columns.Add("Address","Address");
                dataGridViewCrudeDefaultRule.Columns["Address"].DataPropertyName = "Address";
                dataGridViewCrudeDefaultRule.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultRule.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultRule.Columns.Add("DefaultRuleId","Default Rule");
                dataGridViewCrudeDefaultRule.Columns["DefaultRuleId"].DataPropertyName = "DefaultRuleId";
                dataGridViewCrudeDefaultRule.Columns["DefaultRuleId"].Visible = false;
                dataGridViewCrudeDefaultRule.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultRule.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultRule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultRule.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
