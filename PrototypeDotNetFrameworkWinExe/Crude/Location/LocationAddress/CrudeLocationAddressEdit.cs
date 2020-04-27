/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:43:40 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeLocationAddressEdit : Form {
        
        private CrudeLocationAddressContract _contract;
        
        private Boolean _isNew;
        
        public CrudeLocationAddressEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeLocationAddressContract();
                _isNew = true;
                this.Text += " - Not Savable (LocationCountry,User Missing)";
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
                _contract = new CrudeLocationAddressContract();
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
        
        public void ShowAsAdd(string locationAddressTypeRcd, System.Guid locationCountryId, string addressOne, string addressTwo, string addressThree, string city, string street, string state, string district, string province, string zipCode, string poBox, string comment, System.Guid userId) {
            try {
                _contract = new CrudeLocationAddressContract();
                _isNew = true;
                _contract.LocationAddressTypeRcd = locationAddressTypeRcd;
                locationAddressTypeRefCombo.Text = _contract.LocationAddressTypeRcd != null ? _contract.LocationAddressTypeRcd : String.Empty;
                _contract.LocationCountryId = locationCountryId;
                _contract.AddressOne = addressOne;
                textBoxAddressOne.Text = _contract.AddressOne;
                _contract.AddressTwo = addressTwo;
                textBoxAddressTwo.Text = _contract.AddressTwo;
                _contract.AddressThree = addressThree;
                textBoxAddressThree.Text = _contract.AddressThree;
                _contract.City = city;
                textBoxCity.Text = _contract.City;
                _contract.Street = street;
                textBoxStreet.Text = _contract.Street;
                _contract.State = state;
                textBoxState.Text = _contract.State;
                _contract.District = district;
                textBoxDistrict.Text = _contract.District;
                _contract.Province = province;
                textBoxProvince.Text = _contract.Province;
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
        
        public void ShowAsEdit(System.Guid locationAddressId) {
            var service = new CrudeLocationAddressServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByLocationAddressId(locationAddressId);
                locationAddressTypeRefCombo.Text = _contract.LocationAddressTypeRcd != null ? _contract.LocationAddressTypeRcd : String.Empty;
                textBoxAddressOne.Text = _contract.AddressOne;
                textBoxAddressTwo.Text = _contract.AddressTwo;
                textBoxAddressThree.Text = _contract.AddressThree;
                textBoxCity.Text = _contract.City;
                textBoxStreet.Text = _contract.Street;
                textBoxState.Text = _contract.State;
                textBoxDistrict.Text = _contract.District;
                textBoxProvince.Text = _contract.Province;
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
            var service = new CrudeLocationAddressServiceClient();
            try {
                _contract.LocationAddressTypeRcd = locationAddressTypeRefCombo.Text;
                _contract.AddressOne = textBoxAddressOne.Text;
                _contract.AddressTwo = textBoxAddressTwo.Text;
                _contract.AddressThree = textBoxAddressThree.Text;
                _contract.City = textBoxCity.Text;
                _contract.Street = textBoxStreet.Text;
                _contract.State = textBoxState.Text;
                _contract.District = textBoxDistrict.Text;
                _contract.Province = textBoxProvince.Text;
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
