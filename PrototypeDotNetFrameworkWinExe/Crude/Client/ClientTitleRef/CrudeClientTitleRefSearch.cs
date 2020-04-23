/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 11:44:28 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientTitleRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeClientTitleRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientTitleRef();
            this.AcceptButton = buttonCrudeClientTitleRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeClientTitleRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientTitleRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientTitleRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientTitleRef.CurrentRow.Cells["ClientTitleRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientTitleRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientTitleRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeClientTitleRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientTitleRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientTitleRef.CurrentRow.Cells["ClientTitleRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientTitleRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientTitleRef();
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
        
        public void RefreshCrudeClientTitleRef() {
            var clientTitleRef = new CrudeClientTitleRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientTitleRef.FetchWithFilter(
                             textBoxClientTitle.Text
                            ,textBoxClientTitleName.Text
                            ,textBoxClientTitleDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientTitleRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientTitleRef.DataSource = bindingSource;
                dataGridViewCrudeClientTitleRef.AutoResizeColumns();
                dataGridViewCrudeClientTitleRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientTitleRef.Close();
            }
        }
        
        private void InitializeGridCrudeClientTitleRef() {
            try {
                dataGridViewCrudeClientTitleRef.Columns.Clear();
                dataGridViewCrudeClientTitleRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientTitleRef.Columns.Add("ClientTitleName","Client Title Name");
                dataGridViewCrudeClientTitleRef.Columns["ClientTitleName"].DataPropertyName = "ClientTitleName";
                dataGridViewCrudeClientTitleRef.Columns.Add("ClientTitleRcd","Client Title");
                dataGridViewCrudeClientTitleRef.Columns["ClientTitleRcd"].DataPropertyName = "ClientTitleRcd";
                dataGridViewCrudeClientTitleRef.Columns.Add("ClientTitleDescription","Client Title Description");
                dataGridViewCrudeClientTitleRef.Columns["ClientTitleDescription"].DataPropertyName = "ClientTitleDescription";
                dataGridViewCrudeClientTitleRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientTitleRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientTitleRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientTitleRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientTitleRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientTitleRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientTitleRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientTitleRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientTitleRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientTitleRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
