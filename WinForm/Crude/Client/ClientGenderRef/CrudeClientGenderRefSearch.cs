/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 3:51:00 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientGenderRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeClientGenderRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientGenderRef();
            this.AcceptButton = buttonCrudeClientGenderRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeClientGenderRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientGenderRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientGenderRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientGenderRef.CurrentRow.Cells["ClientGenderRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientGenderRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientGenderRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeClientGenderRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientGenderRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientGenderRef.CurrentRow.Cells["ClientGenderRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientGenderRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientGenderRef();
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
        
        public void RefreshCrudeClientGenderRef() {
            var clientGenderRef = new CrudeClientGenderRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientGenderRef.FetchWithFilter(
                             textBoxClientGender.Text
                            ,textBoxClientGenderName.Text
                            ,textBoxClientGenderDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientGenderRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientGenderRef.DataSource = bindingSource;
                dataGridViewCrudeClientGenderRef.AutoResizeColumns();
                dataGridViewCrudeClientGenderRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientGenderRef.Close();
            }
        }
        
        private void InitializeGridCrudeClientGenderRef() {
            try {
                dataGridViewCrudeClientGenderRef.Columns.Clear();
                dataGridViewCrudeClientGenderRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientGenderRef.Columns.Add("ClientGenderName","Client Gender Name");
                dataGridViewCrudeClientGenderRef.Columns["ClientGenderName"].DataPropertyName = "ClientGenderName";
                dataGridViewCrudeClientGenderRef.Columns.Add("ClientGenderRcd","Client Gender");
                dataGridViewCrudeClientGenderRef.Columns["ClientGenderRcd"].DataPropertyName = "ClientGenderRcd";
                dataGridViewCrudeClientGenderRef.Columns.Add("ClientGenderDescription","Client Gender Description");
                dataGridViewCrudeClientGenderRef.Columns["ClientGenderDescription"].DataPropertyName = "ClientGenderDescription";
                dataGridViewCrudeClientGenderRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientGenderRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientGenderRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientGenderRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientGenderRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientGenderRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientGenderRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientGenderRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientGenderRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientGenderRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
