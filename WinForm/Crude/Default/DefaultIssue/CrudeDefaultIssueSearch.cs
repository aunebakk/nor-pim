/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 6:12:29 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultIssueSearch : Form {
        
        private string _defaultIssueTypeRcd;
        
        private string _defaultIssueStatusRcd;
        
        private System.Guid _defaultErrorId;
        
        private System.Guid _defaultUserId;
        
        public CrudeDefaultIssueSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultIssue();
            this.AcceptButton = buttonCrudeDefaultIssueSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string defaultIssueTypeRcd, string defaultIssueStatusRcd, System.Guid defaultErrorId, System.Guid defaultUserId) {
            try {
                _defaultIssueTypeRcd = defaultIssueTypeRcd;
                _defaultIssueStatusRcd = defaultIssueStatusRcd;
                _defaultErrorId = defaultErrorId;
                _defaultUserId = defaultUserId;
                RefreshCrudeDefaultIssue();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultIssueEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultIssueEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultIssue.CurrentRow.Cells["DefaultIssueId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultIssueAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultIssueEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultIssue_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultIssueEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultIssue.CurrentRow.Cells["DefaultIssueId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultIssueSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultIssue();
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
        
        public void RefreshCrudeDefaultIssue() {
            var defaultIssue = new CrudeDefaultIssueServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultIssue.FetchWithFilter(
                             Guid.Empty
                            ,defaultIssueTypeRefCombo.Text
                            ,defaultIssueStatusRefCombo.Text
                            ,Guid.Empty
                            ,textBoxIssueName.Text
                            ,textBoxIssueDescription.Text
                            ,textBoxStepsToReproduce.Text
                            ,textBoxLink.Text
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            ,textBoxFixedNote.Text
                            );
                dataGridViewCrudeDefaultIssue.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultIssue.DataSource = bindingSource;
                dataGridViewCrudeDefaultIssue.AutoResizeColumns();
                dataGridViewCrudeDefaultIssue.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultIssue.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultIssue() {
            try {
                dataGridViewCrudeDefaultIssue.Columns.Clear();
                dataGridViewCrudeDefaultIssue.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultIssue.Columns.Add("IssueName","Issue Name");
                dataGridViewCrudeDefaultIssue.Columns["IssueName"].DataPropertyName = "IssueName";
                dataGridViewCrudeDefaultIssue.Columns.Add("DefaultIssueTypeRcd","Default Issue Type");
                dataGridViewCrudeDefaultIssue.Columns["DefaultIssueTypeRcd"].DataPropertyName = "DefaultIssueTypeRcd";
                dataGridViewCrudeDefaultIssue.Columns.Add("DefaultIssueStatusRcd","Default Issue Status");
                dataGridViewCrudeDefaultIssue.Columns["DefaultIssueStatusRcd"].DataPropertyName = "DefaultIssueStatusRcd";
                dataGridViewCrudeDefaultIssue.Columns.Add("IssueDescription","Issue Description");
                dataGridViewCrudeDefaultIssue.Columns["IssueDescription"].DataPropertyName = "IssueDescription";
                dataGridViewCrudeDefaultIssue.Columns.Add("StepsToReproduce","Steps To Reproduce");
                dataGridViewCrudeDefaultIssue.Columns["StepsToReproduce"].DataPropertyName = "StepsToReproduce";
                dataGridViewCrudeDefaultIssue.Columns.Add("Link","Link");
                dataGridViewCrudeDefaultIssue.Columns["Link"].DataPropertyName = "Link";
                dataGridViewCrudeDefaultIssue.Columns.Add("FixedNote","Fixed Note");
                dataGridViewCrudeDefaultIssue.Columns["FixedNote"].DataPropertyName = "FixedNote";
                dataGridViewCrudeDefaultIssue.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultIssue.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultIssue.Columns.Add("DefaultIssueId","Default Issue");
                dataGridViewCrudeDefaultIssue.Columns["DefaultIssueId"].DataPropertyName = "DefaultIssueId";
                dataGridViewCrudeDefaultIssue.Columns["DefaultIssueId"].Visible = false;
                dataGridViewCrudeDefaultIssue.Columns.Add("DefaultErrorId","Default Error");
                dataGridViewCrudeDefaultIssue.Columns["DefaultErrorId"].DataPropertyName = "DefaultErrorId";
                dataGridViewCrudeDefaultIssue.Columns["DefaultErrorId"].Visible = false;
                dataGridViewCrudeDefaultIssue.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultIssue.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultIssue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultIssue.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
