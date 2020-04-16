/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:31:21 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderLineEdit : Form {
        
        private CrudeFinancialOrderLineContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialOrderLineEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialOrderLineContract();
                _isNew = true;
                this.Text += " - Not Savable (FinancialOrder,Product,User,FinancialCurrency Missing)";
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
                _contract = new CrudeFinancialOrderLineContract();
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
        
        public void ShowAsAddByFinancialOrder(System.Guid financialOrderId) {
            try {
                _contract = new CrudeFinancialOrderLineContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialOrderId = financialOrderId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByProduct(System.Guid productId) {
            try {
                _contract = new CrudeFinancialOrderLineContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductId = productId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByFinancialUnitOfMeasurement(string financialUnitOfMeasurementRcd) {
            try {
                _contract = new CrudeFinancialOrderLineContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialUnitOfMeasurementRcd = financialUnitOfMeasurementRcd;
                financialUnitOfMeasurementRefCombo.Text = _contract.FinancialUnitOfMeasurementRcd != null ? _contract.FinancialUnitOfMeasurementRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByFinancialCurrency(System.Guid financialCurrencyId) {
            try {
                _contract = new CrudeFinancialOrderLineContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialCurrencyId = financialCurrencyId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(System.Guid financialOrderId, System.Guid productId, System.Guid userId, string comment, int lineNumber, string financialUnitOfMeasurementRcd, int quantityNumber, System.Guid financialCurrencyId, decimal amount) {
            try {
                _contract = new CrudeFinancialOrderLineContract();
                _isNew = true;
                _contract.FinancialOrderId = financialOrderId;
                _contract.ProductId = productId;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.Comment = comment;
                textBoxComment.Text = _contract.Comment;
                _contract.LineNumber = lineNumber;
                maskedTextBoxLineNumber.Text = _contract.LineNumber.ToString();
                _contract.FinancialUnitOfMeasurementRcd = financialUnitOfMeasurementRcd;
                financialUnitOfMeasurementRefCombo.Text = _contract.FinancialUnitOfMeasurementRcd != null ? _contract.FinancialUnitOfMeasurementRcd : String.Empty;
                _contract.QuantityNumber = quantityNumber;
                maskedTextBoxQuantityNumber.Text = _contract.QuantityNumber.ToString();
                _contract.FinancialCurrencyId = financialCurrencyId;
                _contract.Amount = amount;
                maskedTextBoxAmount.Text = _contract.Amount.ToString();

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsEdit(System.Guid financialOrderLineId) {
            var service = new CrudeFinancialOrderLineServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialOrderLineId(financialOrderLineId);
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                textBoxComment.Text = _contract.Comment;
                maskedTextBoxLineNumber.Text = _contract.LineNumber.ToString();
                financialUnitOfMeasurementRefCombo.Text = _contract.FinancialUnitOfMeasurementRcd != null ? _contract.FinancialUnitOfMeasurementRcd : String.Empty;
                maskedTextBoxQuantityNumber.Text = _contract.QuantityNumber.ToString();
                maskedTextBoxAmount.Text = _contract.Amount.ToString();

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
            var service = new CrudeFinancialOrderLineServiceClient();
            try {
                _contract.Comment = textBoxComment.Text;
                _contract.LineNumber = maskedTextBoxLineNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxLineNumber.Text);
                _contract.FinancialUnitOfMeasurementRcd = financialUnitOfMeasurementRefCombo.Text;
                _contract.QuantityNumber = maskedTextBoxQuantityNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxQuantityNumber.Text);
                _contract.Amount = maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text);

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
