/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:16:34 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientAddressSearch : Form {
        
        private string _clientAddressTypeRcd;
        
        private System.Guid _userId;
        
        public CrudeClientAddressSearch() {
            InitializeComponent();
            InitializeGridCrudeClientAddress();
            this.AcceptButton = buttonCrudeClientAddressSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string clientAddressTypeRcd, System.Guid userId) {
            try {
                _clientAddressTypeRcd = clientAddressTypeRcd;
                _userId = userId;
                RefreshCrudeClientAddress();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientAddressEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientAddressEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientAddress.CurrentRow.Cells["ClientAddressId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientAddressAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientAddressEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeClientAddress_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientAddressEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientAddress.CurrentRow.Cells["ClientAddressId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientAddressSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientAddress();
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
        
        public void RefreshCrudeClientAddress() {
            var clientAddress = new CrudeClientAddressServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientAddress.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,clientAddressTypeRefCombo.Text
                            ,textBoxAddressLineOneName.Text
                            ,textBoxAddressLineTwoName.Text
                            ,textBoxAddressLineThreeName.Text
                            ,textBoxCityName.Text
                            ,textBoxStreetName.Text
                            ,textBoxStateName.Text
                            ,textBoxDistrictName.Text
                            ,textBoxProvinceName.Text
                            ,textBoxZipCode.Text
                            ,textBoxPoBox.Text
                            ,textBoxComment.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientAddress.AutoGenerateColumns = false;
                dataGridViewCrudeClientAddress.DataSource = bindingSource;
                dataGridViewCrudeClientAddress.AutoResizeColumns();
                dataGridViewCrudeClientAddress.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientAddress.Close();
            }
        }
        
        private void InitializeGridCrudeClientAddress() {
            try {
                dataGridViewCrudeClientAddress.Columns.Clear();
                dataGridViewCrudeClientAddress.AutoGenerateColumns = false;
                dataGridViewCrudeClientAddress.Columns.Add("AddressLineOneName","Address Line One Name");
                dataGridViewCrudeClientAddress.Columns["AddressLineOneName"].DataPropertyName = "AddressLineOneName";
                dataGridViewCrudeClientAddress.Columns.Add("AddressLineTwoName","Address Line Two Name");
                dataGridViewCrudeClientAddress.Columns["AddressLineTwoName"].DataPropertyName = "AddressLineTwoName";
                dataGridViewCrudeClientAddress.Columns.Add("AddressLineThreeName","Address Line Three Name");
                dataGridViewCrudeClientAddress.Columns["AddressLineThreeName"].DataPropertyName = "AddressLineThreeName";
                dataGridViewCrudeClientAddress.Columns.Add("CityName","City Name");
                dataGridViewCrudeClientAddress.Columns["CityName"].DataPropertyName = "CityName";
                dataGridViewCrudeClientAddress.Columns.Add("StreetName","Street Name");
                dataGridViewCrudeClientAddress.Columns["StreetName"].DataPropertyName = "StreetName";
                dataGridViewCrudeClientAddress.Columns.Add("StateName","State Name");
                dataGridViewCrudeClientAddress.Columns["StateName"].DataPropertyName = "StateName";
                dataGridViewCrudeClientAddress.Columns.Add("DistrictName","District Name");
                dataGridViewCrudeClientAddress.Columns["DistrictName"].DataPropertyName = "DistrictName";
                dataGridViewCrudeClientAddress.Columns.Add("ProvinceName","Province Name");
                dataGridViewCrudeClientAddress.Columns["ProvinceName"].DataPropertyName = "ProvinceName";
                dataGridViewCrudeClientAddress.Columns.Add("ClientAddressTypeRcd","Client Address Type");
                dataGridViewCrudeClientAddress.Columns["ClientAddressTypeRcd"].DataPropertyName = "ClientAddressTypeRcd";
                dataGridViewCrudeClientAddress.Columns.Add("ZipCode","Zip Code");
                dataGridViewCrudeClientAddress.Columns["ZipCode"].DataPropertyName = "ZipCode";
                dataGridViewCrudeClientAddress.Columns.Add("PoBox","Po Box");
                dataGridViewCrudeClientAddress.Columns["PoBox"].DataPropertyName = "PoBox";
                dataGridViewCrudeClientAddress.Columns.Add("Comment","Comment");
                dataGridViewCrudeClientAddress.Columns["Comment"].DataPropertyName = "Comment";
                dataGridViewCrudeClientAddress.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientAddress.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientAddress.Columns.Add("ClientAddressId","Client Address");
                dataGridViewCrudeClientAddress.Columns["ClientAddressId"].DataPropertyName = "ClientAddressId";
                dataGridViewCrudeClientAddress.Columns["ClientAddressId"].Visible = false;
                dataGridViewCrudeClientAddress.Columns.Add("ClientId","Client");
                dataGridViewCrudeClientAddress.Columns["ClientId"].DataPropertyName = "ClientId";
                dataGridViewCrudeClientAddress.Columns["ClientId"].Visible = false;
                dataGridViewCrudeClientAddress.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientAddress.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientAddress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientAddress.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
