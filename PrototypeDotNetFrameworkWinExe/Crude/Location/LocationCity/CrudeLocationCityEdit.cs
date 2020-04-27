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
    
    
    public partial class CrudeLocationCityEdit : Form {
        
        private CrudeLocationCityContract _contract;
        
        private Boolean _isNew;
        
        public CrudeLocationCityEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeLocationCityContract();
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
                _contract = new CrudeLocationCityContract();
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
        
        public void ShowAsAddByLocationCountry(System.Guid locationCountryId) {
            try {
                _contract = new CrudeLocationCityContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.LocationCountryId = locationCountryId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(System.Guid locationCountryId, string locationCityCode, string locationCityName, System.Guid userId) {
            try {
                _contract = new CrudeLocationCityContract();
                _isNew = true;
                _contract.LocationCountryId = locationCountryId;
                _contract.LocationCityCode = locationCityCode;
                textBoxLocationCityCode.Text = _contract.LocationCityCode;
                _contract.LocationCityName = locationCityName;
                textBoxLocationCityName.Text = _contract.LocationCityName;
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
        
        public void ShowAsEdit(System.Guid locationCityId) {
            var service = new CrudeLocationCityServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByLocationCityId(locationCityId);
                textBoxLocationCityCode.Text = _contract.LocationCityCode;
                textBoxLocationCityName.Text = _contract.LocationCityName;
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
            var service = new CrudeLocationCityServiceClient();
            try {
                _contract.LocationCityCode = textBoxLocationCityCode.Text;
                _contract.LocationCityName = textBoxLocationCityName.Text;

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
