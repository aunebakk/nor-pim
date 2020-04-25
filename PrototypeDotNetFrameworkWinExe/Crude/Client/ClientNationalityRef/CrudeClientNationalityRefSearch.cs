/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 12:23:56 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientNationalityRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeClientNationalityRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientNationalityRef();
            this.AcceptButton = buttonCrudeClientNationalityRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeClientNationalityRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientNationalityRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientNationalityRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientNationalityRef.CurrentRow.Cells["ClientNationalityRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientNationalityRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientNationalityRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeClientNationalityRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientNationalityRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientNationalityRef.CurrentRow.Cells["ClientNationalityRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientNationalityRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientNationalityRef();
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
        
        public void RefreshCrudeClientNationalityRef() {
            var clientNationalityRef = new CrudeClientNationalityRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientNationalityRef.FetchWithFilter(
                             textBoxClientNationality.Text
                            ,textBoxClientNationalityName.Text
                            ,textBoxClientNationalityDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientNationalityRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientNationalityRef.DataSource = bindingSource;
                dataGridViewCrudeClientNationalityRef.AutoResizeColumns();
                dataGridViewCrudeClientNationalityRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientNationalityRef.Close();
            }
        }
        
        private void InitializeGridCrudeClientNationalityRef() {
            try {
                dataGridViewCrudeClientNationalityRef.Columns.Clear();
                dataGridViewCrudeClientNationalityRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientNationalityRef.Columns.Add("ClientNationalityName","Client Nationality Name");
                dataGridViewCrudeClientNationalityRef.Columns["ClientNationalityName"].DataPropertyName = "ClientNationalityName";
                dataGridViewCrudeClientNationalityRef.Columns.Add("ClientNationalityRcd","Client Nationality");
                dataGridViewCrudeClientNationalityRef.Columns["ClientNationalityRcd"].DataPropertyName = "ClientNationalityRcd";
                dataGridViewCrudeClientNationalityRef.Columns.Add("ClientNationalityDescription","Client Nationality Description");
                dataGridViewCrudeClientNationalityRef.Columns["ClientNationalityDescription"].DataPropertyName = "ClientNationalityDescription";
                dataGridViewCrudeClientNationalityRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientNationalityRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientNationalityRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientNationalityRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientNationalityRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientNationalityRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientNationalityRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientNationalityRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientNationalityRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientNationalityRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
