/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:20:12 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeLocationCountrySearch : Form {
        
        private System.Guid _userId;
        
        public CrudeLocationCountrySearch() {
            InitializeComponent();
            InitializeGridCrudeLocationCountry();
            this.AcceptButton = buttonCrudeLocationCountrySearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeLocationCountry();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeLocationCountryEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeLocationCountryEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeLocationCountry.CurrentRow.Cells["LocationCountryId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeLocationCountryAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeLocationCountryEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeLocationCountry_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeLocationCountryEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeLocationCountry.CurrentRow.Cells["LocationCountryId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeLocationCountrySearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeLocationCountry();
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
        
        public void RefreshCrudeLocationCountry() {
            var locationCountry = new CrudeLocationCountryServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = locationCountry.FetchWithFilter(
                             Guid.Empty
                            ,textBoxLocationCountryCode.Text
                            ,textBoxLocationCountryName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeLocationCountry.AutoGenerateColumns = false;
                dataGridViewCrudeLocationCountry.DataSource = bindingSource;
                dataGridViewCrudeLocationCountry.AutoResizeColumns();
                dataGridViewCrudeLocationCountry.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                locationCountry.Close();
            }
        }
        
        private void InitializeGridCrudeLocationCountry() {
            try {
                dataGridViewCrudeLocationCountry.Columns.Clear();
                dataGridViewCrudeLocationCountry.AutoGenerateColumns = false;
                dataGridViewCrudeLocationCountry.Columns.Add("LocationCountryName","Location Country Name");
                dataGridViewCrudeLocationCountry.Columns["LocationCountryName"].DataPropertyName = "LocationCountryName";
                dataGridViewCrudeLocationCountry.Columns.Add("LocationCountryCode","Location Country Code");
                dataGridViewCrudeLocationCountry.Columns["LocationCountryCode"].DataPropertyName = "LocationCountryCode";
                dataGridViewCrudeLocationCountry.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeLocationCountry.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeLocationCountry.Columns.Add("LocationCountryId","Location Country");
                dataGridViewCrudeLocationCountry.Columns["LocationCountryId"].DataPropertyName = "LocationCountryId";
                dataGridViewCrudeLocationCountry.Columns["LocationCountryId"].Visible = false;
                dataGridViewCrudeLocationCountry.Columns.Add("ExtensionData", "");
                dataGridViewCrudeLocationCountry.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeLocationCountry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeLocationCountry.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
