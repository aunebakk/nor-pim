/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:40:48 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeLocationCitySearch : Form {
        
        private System.Guid _locationCountryId;
        
        private System.Guid _userId;
        
        public CrudeLocationCitySearch() {
            InitializeComponent();
            InitializeGridCrudeLocationCity();
            this.AcceptButton = buttonCrudeLocationCitySearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid locationCountryId, System.Guid userId) {
            try {
                _locationCountryId = locationCountryId;
                _userId = userId;
                RefreshCrudeLocationCity();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeLocationCityEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeLocationCityEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeLocationCity.CurrentRow.Cells["LocationCityId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeLocationCityAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeLocationCityEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeLocationCity_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeLocationCityEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeLocationCity.CurrentRow.Cells["LocationCityId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeLocationCitySearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeLocationCity();
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
        
        public void RefreshCrudeLocationCity() {
            var locationCity = new CrudeLocationCityServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = locationCity.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,textBoxLocationCityCode.Text
                            ,textBoxLocationCityName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeLocationCity.AutoGenerateColumns = false;
                dataGridViewCrudeLocationCity.DataSource = bindingSource;
                dataGridViewCrudeLocationCity.AutoResizeColumns();
                dataGridViewCrudeLocationCity.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                locationCity.Close();
            }
        }
        
        private void InitializeGridCrudeLocationCity() {
            try {
                dataGridViewCrudeLocationCity.Columns.Clear();
                dataGridViewCrudeLocationCity.AutoGenerateColumns = false;
                dataGridViewCrudeLocationCity.Columns.Add("LocationCityName","Location City Name");
                dataGridViewCrudeLocationCity.Columns["LocationCityName"].DataPropertyName = "LocationCityName";
                dataGridViewCrudeLocationCity.Columns.Add("LocationCityCode","Location City Code");
                dataGridViewCrudeLocationCity.Columns["LocationCityCode"].DataPropertyName = "LocationCityCode";
                dataGridViewCrudeLocationCity.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeLocationCity.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeLocationCity.Columns.Add("LocationCityId","Location City");
                dataGridViewCrudeLocationCity.Columns["LocationCityId"].DataPropertyName = "LocationCityId";
                dataGridViewCrudeLocationCity.Columns["LocationCityId"].Visible = false;
                dataGridViewCrudeLocationCity.Columns.Add("LocationCountryId","Location Country");
                dataGridViewCrudeLocationCity.Columns["LocationCountryId"].DataPropertyName = "LocationCountryId";
                dataGridViewCrudeLocationCity.Columns["LocationCountryId"].Visible = false;
                dataGridViewCrudeLocationCity.Columns.Add("ExtensionData", "");
                dataGridViewCrudeLocationCity.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeLocationCity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeLocationCity.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
