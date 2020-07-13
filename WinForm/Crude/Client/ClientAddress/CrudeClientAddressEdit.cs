/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 4:55:01 PM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientAddressEdit : Form {
        
        private CrudeClientAddressContract _contract;
        
        private Boolean _isNew;
        
        public CrudeClientAddressEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeClientAddressContract();
                _isNew = true;
                this.Text += " - Not Savable (User Missing)";
                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByRules(System.Guid userId) {
            try {
                _contract = new CrudeClientAddressContract();
                _isNew = true;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(System.Guid clientId, string clientAddressTypeRcd, string addressLineOneName, string addressLineTwoName, string addressLineThreeName, string cityName, string streetName, string stateName, string districtName, string provinceName, string zipCode, string poBox, string comment, System.Guid userId) {
            try {
                _contract = new CrudeClientAddressContract();
                _isNew = true;
                _contract.ClientId = clientId;
                _contract.ClientAddressTypeRcd = clientAddressTypeRcd;
                clientAddressTypeRefCombo.Text = _contract.ClientAddressTypeRcd != null ? _contract.ClientAddressTypeRcd : String.Empty;
                _contract.AddressLineOneName = addressLineOneName;
                textBoxAddressLineOneName.Text = _contract.AddressLineOneName;
                _contract.AddressLineTwoName = addressLineTwoName;
                textBoxAddressLineTwoName.Text = _contract.AddressLineTwoName;
                _contract.AddressLineThreeName = addressLineThreeName;
                textBoxAddressLineThreeName.Text = _contract.AddressLineThreeName;
                _contract.CityName = cityName;
                textBoxCityName.Text = _contract.CityName;
                _contract.StreetName = streetName;
                textBoxStreetName.Text = _contract.StreetName;
                _contract.StateName = stateName;
                textBoxStateName.Text = _contract.StateName;
                _contract.DistrictName = districtName;
                textBoxDistrictName.Text = _contract.DistrictName;
                _contract.ProvinceName = provinceName;
                textBoxProvinceName.Text = _contract.ProvinceName;
                _contract.ZipCode = zipCode;
                textBoxZipCode.Text = _contract.ZipCode;
                _contract.PoBox = poBox;
                textBoxPoBox.Text = _contract.PoBox;
                _contract.Comment = comment;
                textBoxComment.Text = _contract.Comment;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsEdit(System.Guid clientAddressId) {
            var service = new CrudeClientAddressServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByClientAddressId(clientAddressId);
                clientAddressTypeRefCombo.Text = _contract.ClientAddressTypeRcd != null ? _contract.ClientAddressTypeRcd : String.Empty;
                textBoxAddressLineOneName.Text = _contract.AddressLineOneName;
                textBoxAddressLineTwoName.Text = _contract.AddressLineTwoName;
                textBoxAddressLineThreeName.Text = _contract.AddressLineThreeName;
                textBoxCityName.Text = _contract.CityName;
                textBoxStreetName.Text = _contract.StreetName;
                textBoxStateName.Text = _contract.StateName;
                textBoxDistrictName.Text = _contract.DistrictName;
                textBoxProvinceName.Text = _contract.ProvinceName;
                textBoxZipCode.Text = _contract.ZipCode;
                textBoxPoBox.Text = _contract.PoBox;
                textBoxComment.Text = _contract.Comment;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                service.Close();
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeClientAddressServiceClient();
            try {
                _contract.ClientAddressTypeRcd = clientAddressTypeRefCombo.Text;
                _contract.AddressLineOneName = textBoxAddressLineOneName.Text;
                _contract.AddressLineTwoName = textBoxAddressLineTwoName.Text;
                _contract.AddressLineThreeName = textBoxAddressLineThreeName.Text;
                _contract.CityName = textBoxCityName.Text;
                _contract.StreetName = textBoxStreetName.Text;
                _contract.StateName = textBoxStateName.Text;
                _contract.DistrictName = textBoxDistrictName.Text;
                _contract.ProvinceName = textBoxProvinceName.Text;
                _contract.ZipCode = textBoxZipCode.Text;
                _contract.PoBox = textBoxPoBox.Text;
                _contract.Comment = textBoxComment.Text;

                if (_isNew)
                    service.Insert(_contract);
                else
                    service.Update(_contract);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                service.Close();
            }

            Close();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
