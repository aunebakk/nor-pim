/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/12/2020 10:41:21 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultTestEdit : Form {
        
        private CrudeDefaultTestContract _contract;
        
        private Boolean _isNew;
        
        public CrudeDefaultTestEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultTestContract();
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
        
        public void ShowAsAdd(string systemName, string testArea, string testSubArea, string testAddress, System.Guid userId, System.DateTime dateTime) {
            try {
                _contract = new CrudeDefaultTestContract();
                _isNew = true;
                _contract.SystemName = systemName;
                textBoxSystemName.Text = _contract.SystemName;
                _contract.TestArea = testArea;
                textBoxTestArea.Text = _contract.TestArea;
                _contract.TestSubArea = testSubArea;
                textBoxTestSubArea.Text = _contract.TestSubArea;
                _contract.TestAddress = testAddress;
                textBoxTestAddress.Text = _contract.TestAddress;
                _contract.UserId = userId;
                _contract.DateTime = dateTime;
                dateTimePickerDateTime.Value = _contract.DateTime != DateTime.MinValue ? _contract.DateTime : dateTimePickerDateTime.MinDate;
                dateTimePickerDateTime.Checked = _contract.DateTime != DateTime.MinValue;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsEdit(System.Guid defaultTestId) {
            var service = new CrudeDefaultTestServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultTestId(defaultTestId);
                textBoxSystemName.Text = _contract.SystemName;
                textBoxTestArea.Text = _contract.TestArea;
                textBoxTestSubArea.Text = _contract.TestSubArea;
                textBoxTestAddress.Text = _contract.TestAddress;
                dateTimePickerDateTime.Value = _contract.DateTime != DateTime.MinValue ? _contract.DateTime : dateTimePickerDateTime.MinDate;
                dateTimePickerDateTime.Checked = _contract.DateTime != DateTime.MinValue;

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
            var service = new CrudeDefaultTestServiceClient();
            try {
                _contract.SystemName = textBoxSystemName.Text;
                _contract.TestArea = textBoxTestArea.Text;
                _contract.TestSubArea = textBoxTestSubArea.Text;
                _contract.TestAddress = textBoxTestAddress.Text;
                _contract.DateTime = dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue;

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
