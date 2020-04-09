/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:35:12 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialCouponTypeRefEdit : Form {
        
        private CrudeFinancialCouponTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialCouponTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialCouponTypeRefContract();
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
                _contract = new CrudeFinancialCouponTypeRefContract();
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
        
        public void ShowAsAdd(string financialCouponTypeRcd, string financialCouponTypeName, System.Guid userId) {
            try {
                _contract = new CrudeFinancialCouponTypeRefContract();
                _isNew = true;
                _contract.FinancialCouponTypeRcd = financialCouponTypeRcd;
                textBoxFinancialCouponType.Text = _contract.FinancialCouponTypeRcd;
                _contract.FinancialCouponTypeName = financialCouponTypeName;
                textBoxFinancialCouponTypeName.Text = _contract.FinancialCouponTypeName;
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
        
        public void ShowAsEdit(string financialCouponTypeRcd, System.Guid userId) {
            var service = new CrudeFinancialCouponTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialCouponTypeRcd(financialCouponTypeRcd);
                textBoxFinancialCouponType.Text = _contract.FinancialCouponTypeRcd;
                textBoxFinancialCouponTypeName.Text = _contract.FinancialCouponTypeName;
                _contract.UserId = userId;
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
            var service = new CrudeFinancialCouponTypeRefServiceClient();
            try {
                _contract.FinancialCouponTypeRcd = textBoxFinancialCouponType.Text;
                _contract.FinancialCouponTypeName = textBoxFinancialCouponTypeName.Text;

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
