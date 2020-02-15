/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:40:38 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialPaymentCardSearch : Form {
        
        private string _financialCardTypeRcd;
        
        private System.Guid _userId;
        
        private System.Guid _financialCurrencyId;
        
        public CrudeFinancialPaymentCardSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialPaymentCard();
            this.AcceptButton = buttonCrudeFinancialPaymentCardSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string financialCardTypeRcd, System.Guid userId, System.Guid financialCurrencyId) {
            try {
                _financialCardTypeRcd = financialCardTypeRcd;
                _userId = userId;
                _financialCurrencyId = financialCurrencyId;
                RefreshCrudeFinancialPaymentCard();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentCardEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentCardEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialPaymentCard.CurrentRow.Cells["FinancialPaymentCardId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentCardAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentCardEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialPaymentCard_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentCardEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialPaymentCard.CurrentRow.Cells["FinancialPaymentCardId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentCardSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialPaymentCard();
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
        
        public void RefreshCrudeFinancialPaymentCard() {
            var financialPaymentCard = new CrudeFinancialPaymentCardServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialPaymentCard.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,textBoxCardNumber.Text
                            ,textBoxNameOnCard.Text
                            ,maskedTextBoxExpiryYear.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxExpiryYear.Text)
                            ,maskedTextBoxExpiryMonth.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxExpiryMonth.Text)
                            ,financialCardTypeRefCombo.Text
                            ,maskedTextBoxCardVerificationValue.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxCardVerificationValue.Text)
                            ,maskedTextBoxIssuedMonth.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxIssuedMonth.Text)
                            ,maskedTextBoxIssuedYear.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxIssuedYear.Text)
                            ,textBoxAddressVerificationCode.Text
                            ,maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text)
                            ,Guid.Empty
                            );
                dataGridViewCrudeFinancialPaymentCard.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialPaymentCard.DataSource = bindingSource;
                dataGridViewCrudeFinancialPaymentCard.AutoResizeColumns();
                dataGridViewCrudeFinancialPaymentCard.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialPaymentCard.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialPaymentCard() {
            try {
                dataGridViewCrudeFinancialPaymentCard.Columns.Clear();
                dataGridViewCrudeFinancialPaymentCard.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("CardNumber","Card Number");
                dataGridViewCrudeFinancialPaymentCard.Columns["CardNumber"].DataPropertyName = "CardNumber";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("NameOnCard","Name On Card");
                dataGridViewCrudeFinancialPaymentCard.Columns["NameOnCard"].DataPropertyName = "NameOnCard";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("FinancialCardTypeRcd","Financial Card Type");
                dataGridViewCrudeFinancialPaymentCard.Columns["FinancialCardTypeRcd"].DataPropertyName = "FinancialCardTypeRcd";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("AddressVerificationCode","Address Verification Code");
                dataGridViewCrudeFinancialPaymentCard.Columns["AddressVerificationCode"].DataPropertyName = "AddressVerificationCode";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("ExpiryYear","Expiry Year");
                dataGridViewCrudeFinancialPaymentCard.Columns["ExpiryYear"].DataPropertyName = "ExpiryYear";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("ExpiryMonth","Expiry Month");
                dataGridViewCrudeFinancialPaymentCard.Columns["ExpiryMonth"].DataPropertyName = "ExpiryMonth";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("CardVerificationValue","Card Verification Value");
                dataGridViewCrudeFinancialPaymentCard.Columns["CardVerificationValue"].DataPropertyName = "CardVerificationValue";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("IssuedMonth","Issued Month");
                dataGridViewCrudeFinancialPaymentCard.Columns["IssuedMonth"].DataPropertyName = "IssuedMonth";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("IssuedYear","Issued Year");
                dataGridViewCrudeFinancialPaymentCard.Columns["IssuedYear"].DataPropertyName = "IssuedYear";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("Amount","Amount");
                dataGridViewCrudeFinancialPaymentCard.Columns["Amount"].DataPropertyName = "Amount";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialPaymentCard.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("FinancialPaymentCardId","Financial Payment Card");
                dataGridViewCrudeFinancialPaymentCard.Columns["FinancialPaymentCardId"].DataPropertyName = "FinancialPaymentCardId";
                dataGridViewCrudeFinancialPaymentCard.Columns["FinancialPaymentCardId"].Visible = false;
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeFinancialPaymentCard.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeFinancialPaymentCard.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeFinancialPaymentCard.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialPaymentCard.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialPaymentCard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialPaymentCard.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
