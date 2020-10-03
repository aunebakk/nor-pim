/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/3/2020 3:48:32 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    public partial class CrudeProductGatherEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        private CrudeProductGatherContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductGatherEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductGatherContract();
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
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAddByRules(System.Guid userId) {
            try {
                _contract = new CrudeProductGatherContract();
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
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd(System.DateTime startDateTime, System.DateTime finishDateTime, System.Guid userId) {
            try {
                _contract = new CrudeProductGatherContract();
                _isNew = true;
                _contract.StartDateTime = startDateTime;
                dateTimePickerStartDateTime.Value = _contract.StartDateTime != DateTime.MinValue ? _contract.StartDateTime : dateTimePickerStartDateTime.MinDate;
                dateTimePickerStartDateTime.Checked = _contract.StartDateTime != DateTime.MinValue;
                _contract.FinishDateTime = finishDateTime;
                dateTimePickerFinishDateTime.Value = _contract.FinishDateTime != DateTime.MinValue ? _contract.FinishDateTime : dateTimePickerFinishDateTime.MinDate;
                dateTimePickerFinishDateTime.Checked = _contract.FinishDateTime != DateTime.MinValue;
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
        
        // shows the form in edit modus
        public void ShowAsEdit(System.Guid productGatherId) {
            var service = new CrudeProductGatherServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductGatherId(productGatherId);
                dateTimePickerStartDateTime.Value = _contract.StartDateTime != DateTime.MinValue ? _contract.StartDateTime : dateTimePickerStartDateTime.MinDate;
                dateTimePickerStartDateTime.Checked = _contract.StartDateTime != DateTime.MinValue;
                dateTimePickerFinishDateTime.Value = _contract.FinishDateTime != DateTime.MinValue ? _contract.FinishDateTime : dateTimePickerFinishDateTime.MinDate;
                dateTimePickerFinishDateTime.Checked = _contract.FinishDateTime != DateTime.MinValue;
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
        
        // saves the form
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeProductGatherServiceClient();
            try {
                _contract.StartDateTime = dateTimePickerStartDateTime.Checked ? Convert.ToDateTime(dateTimePickerStartDateTime.Value): DateTime.MinValue;
                _contract.FinishDateTime = dateTimePickerFinishDateTime.Checked ? Convert.ToDateTime(dateTimePickerFinishDateTime.Value): DateTime.MinValue;

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
        
        // closes the form
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
