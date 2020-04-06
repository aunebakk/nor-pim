/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:25:30 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeLocationAddressTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeLocationAddressTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeLocationAddressTypeRef();
            this.AcceptButton = buttonCrudeLocationAddressTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeLocationAddressTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeLocationAddressTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeLocationAddressTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeLocationAddressTypeRef.CurrentRow.Cells["LocationAddressTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeLocationAddressTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeLocationAddressTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeLocationAddressTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeLocationAddressTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeLocationAddressTypeRef.CurrentRow.Cells["LocationAddressTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeLocationAddressTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeLocationAddressTypeRef();
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
        
        public void RefreshCrudeLocationAddressTypeRef() {
            var locationAddressTypeRef = new CrudeLocationAddressTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = locationAddressTypeRef.FetchWithFilter(
                             textBoxLocationAddressType.Text
                            ,textBoxLocationAddressTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeLocationAddressTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeLocationAddressTypeRef.DataSource = bindingSource;
                dataGridViewCrudeLocationAddressTypeRef.AutoResizeColumns();
                dataGridViewCrudeLocationAddressTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                locationAddressTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeLocationAddressTypeRef() {
            try {
                dataGridViewCrudeLocationAddressTypeRef.Columns.Clear();
                dataGridViewCrudeLocationAddressTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeLocationAddressTypeRef.Columns.Add("LocationAddressTypeName","Location Address Type Name");
                dataGridViewCrudeLocationAddressTypeRef.Columns["LocationAddressTypeName"].DataPropertyName = "LocationAddressTypeName";
                dataGridViewCrudeLocationAddressTypeRef.Columns.Add("LocationAddressTypeRcd","Location Address Type");
                dataGridViewCrudeLocationAddressTypeRef.Columns["LocationAddressTypeRcd"].DataPropertyName = "LocationAddressTypeRcd";
                dataGridViewCrudeLocationAddressTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeLocationAddressTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeLocationAddressTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeLocationAddressTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeLocationAddressTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeLocationAddressTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
