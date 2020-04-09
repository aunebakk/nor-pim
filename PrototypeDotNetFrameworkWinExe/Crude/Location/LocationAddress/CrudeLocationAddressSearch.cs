/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:22:09 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeLocationAddressSearch : Form {
        
        private string _locationAddressTypeRcd;
        
        private System.Guid _locationCountryId;
        
        private System.Guid _userId;
        
        public CrudeLocationAddressSearch() {
            InitializeComponent();
            InitializeGridCrudeLocationAddress();
            this.AcceptButton = buttonCrudeLocationAddressSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string locationAddressTypeRcd, System.Guid locationCountryId, System.Guid userId) {
            try {
                _locationAddressTypeRcd = locationAddressTypeRcd;
                _locationCountryId = locationCountryId;
                _userId = userId;
                RefreshCrudeLocationAddress();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeLocationAddressEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeLocationAddressEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeLocationAddress.CurrentRow.Cells["LocationAddressId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeLocationAddressAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeLocationAddressEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeLocationAddress_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeLocationAddressEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeLocationAddress.CurrentRow.Cells["LocationAddressId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeLocationAddressSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeLocationAddress();
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
        
        public void RefreshCrudeLocationAddress() {
            var locationAddress = new CrudeLocationAddressServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = locationAddress.FetchWithFilter(
                             Guid.Empty
                            ,locationAddressTypeRefCombo.Text
                            ,Guid.Empty
                            ,textBoxAddressOne.Text
                            ,textBoxAddressTwo.Text
                            ,textBoxAddressThree.Text
                            ,textBoxCity.Text
                            ,textBoxStreet.Text
                            ,textBoxState.Text
                            ,textBoxDistrict.Text
                            ,textBoxProvince.Text
                            ,textBoxZipCode.Text
                            ,textBoxPoBox.Text
                            ,textBoxComment.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeLocationAddress.AutoGenerateColumns = false;
                dataGridViewCrudeLocationAddress.DataSource = bindingSource;
                dataGridViewCrudeLocationAddress.AutoResizeColumns();
                dataGridViewCrudeLocationAddress.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                locationAddress.Close();
            }
        }
        
        private void InitializeGridCrudeLocationAddress() {
            try {
                dataGridViewCrudeLocationAddress.Columns.Clear();
                dataGridViewCrudeLocationAddress.AutoGenerateColumns = false;
                dataGridViewCrudeLocationAddress.Columns.Add("LocationAddressTypeRcd","Location Address Type");
                dataGridViewCrudeLocationAddress.Columns["LocationAddressTypeRcd"].DataPropertyName = "LocationAddressTypeRcd";
                dataGridViewCrudeLocationAddress.Columns.Add("AddressOne","Address One");
                dataGridViewCrudeLocationAddress.Columns["AddressOne"].DataPropertyName = "AddressOne";
                dataGridViewCrudeLocationAddress.Columns.Add("AddressTwo","Address Two");
                dataGridViewCrudeLocationAddress.Columns["AddressTwo"].DataPropertyName = "AddressTwo";
                dataGridViewCrudeLocationAddress.Columns.Add("AddressThree","Address Three");
                dataGridViewCrudeLocationAddress.Columns["AddressThree"].DataPropertyName = "AddressThree";
                dataGridViewCrudeLocationAddress.Columns.Add("City","City");
                dataGridViewCrudeLocationAddress.Columns["City"].DataPropertyName = "City";
                dataGridViewCrudeLocationAddress.Columns.Add("Street","Street");
                dataGridViewCrudeLocationAddress.Columns["Street"].DataPropertyName = "Street";
                dataGridViewCrudeLocationAddress.Columns.Add("State","State");
                dataGridViewCrudeLocationAddress.Columns["State"].DataPropertyName = "State";
                dataGridViewCrudeLocationAddress.Columns.Add("District","District");
                dataGridViewCrudeLocationAddress.Columns["District"].DataPropertyName = "District";
                dataGridViewCrudeLocationAddress.Columns.Add("Province","Province");
                dataGridViewCrudeLocationAddress.Columns["Province"].DataPropertyName = "Province";
                dataGridViewCrudeLocationAddress.Columns.Add("ZipCode","Zip Code");
                dataGridViewCrudeLocationAddress.Columns["ZipCode"].DataPropertyName = "ZipCode";
                dataGridViewCrudeLocationAddress.Columns.Add("PoBox","Po Box");
                dataGridViewCrudeLocationAddress.Columns["PoBox"].DataPropertyName = "PoBox";
                dataGridViewCrudeLocationAddress.Columns.Add("Comment","Comment");
                dataGridViewCrudeLocationAddress.Columns["Comment"].DataPropertyName = "Comment";
                dataGridViewCrudeLocationAddress.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeLocationAddress.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeLocationAddress.Columns.Add("LocationAddressId","Location Address");
                dataGridViewCrudeLocationAddress.Columns["LocationAddressId"].DataPropertyName = "LocationAddressId";
                dataGridViewCrudeLocationAddress.Columns["LocationAddressId"].Visible = false;
                dataGridViewCrudeLocationAddress.Columns.Add("LocationCountryId","Location Country");
                dataGridViewCrudeLocationAddress.Columns["LocationCountryId"].DataPropertyName = "LocationCountryId";
                dataGridViewCrudeLocationAddress.Columns["LocationCountryId"].Visible = false;
                dataGridViewCrudeLocationAddress.Columns.Add("ExtensionData", "");
                dataGridViewCrudeLocationAddress.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeLocationAddress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeLocationAddress.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
