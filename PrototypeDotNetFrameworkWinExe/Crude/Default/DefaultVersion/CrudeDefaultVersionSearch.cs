/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:37:44 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultVersionSearch : Form {
        
        private System.Guid _defaultUserId;
        
        public CrudeDefaultVersionSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultVersion();
            this.AcceptButton = buttonCrudeDefaultVersionSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;
                RefreshCrudeDefaultVersion();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultVersionEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultVersionEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultVersion.CurrentRow.Cells["DefaultVersionId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultVersionAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultVersionEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultVersion_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultVersionEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultVersion.CurrentRow.Cells["DefaultVersionId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultVersionSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultVersion();
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
        
        public void RefreshCrudeDefaultVersion() {
            var defaultVersion = new CrudeDefaultVersionServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultVersion.FetchWithFilter(
                             Guid.Empty
                            ,textBoxFunVersion.Text
                            ,textBoxNumber.Text
                            ,maskedTextBoxMajorNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxMajorNumber.Text)
                            ,maskedTextBoxMinorNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxMinorNumber.Text)
                            ,maskedTextBoxSequenceNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSequenceNumber.Text)
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultVersion.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultVersion.DataSource = bindingSource;
                dataGridViewCrudeDefaultVersion.AutoResizeColumns();
                dataGridViewCrudeDefaultVersion.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultVersion.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultVersion() {
            try {
                dataGridViewCrudeDefaultVersion.Columns.Clear();
                dataGridViewCrudeDefaultVersion.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultVersion.Columns.Add("FunVersion","Fun Version");
                dataGridViewCrudeDefaultVersion.Columns["FunVersion"].DataPropertyName = "FunVersion";
                dataGridViewCrudeDefaultVersion.Columns.Add("Number","Number");
                dataGridViewCrudeDefaultVersion.Columns["Number"].DataPropertyName = "Number";
                dataGridViewCrudeDefaultVersion.Columns.Add("MajorNumber","Major Number");
                dataGridViewCrudeDefaultVersion.Columns["MajorNumber"].DataPropertyName = "MajorNumber";
                dataGridViewCrudeDefaultVersion.Columns.Add("MinorNumber","Minor Number");
                dataGridViewCrudeDefaultVersion.Columns["MinorNumber"].DataPropertyName = "MinorNumber";
                dataGridViewCrudeDefaultVersion.Columns.Add("SequenceNumber","Sequence Number");
                dataGridViewCrudeDefaultVersion.Columns["SequenceNumber"].DataPropertyName = "SequenceNumber";
                dataGridViewCrudeDefaultVersion.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultVersion.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultVersion.Columns.Add("DefaultVersionId","Default Version");
                dataGridViewCrudeDefaultVersion.Columns["DefaultVersionId"].DataPropertyName = "DefaultVersionId";
                dataGridViewCrudeDefaultVersion.Columns["DefaultVersionId"].Visible = false;
                dataGridViewCrudeDefaultVersion.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultVersion.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultVersion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultVersion.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
