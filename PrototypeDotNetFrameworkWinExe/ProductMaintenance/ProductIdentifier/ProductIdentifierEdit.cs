/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:46:27 PM
  Template: sql2x.TemplateWithDurianGenerator.UsingWinForm
*/
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductIdentifierEdit : Form {
        
        private CrudeProductIdentifierContract _contract;
        
        private Boolean _isNew;
        
        public ProductIdentifierEdit() {
            InitializeComponent();
            InitializeGridProductIdentifier();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductIdentifierContract();
            _isNew = true;
            this.Text += " - Not Savable (Product,User Missing)";
            RefreshProductIdentifier();
            Show();
        }
        
        public void ShowAsAddByRules(System.Guid userId) {
            _contract = new CrudeProductIdentifierContract();
            _isNew = true;
            _contract.UserId = userId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshProductIdentifier();
            Show();
        }
        
        public void ShowAsAddByProductAndProductIdentifierAndIdentifier(System.Guid productId, string productIdentifierRcd, string identifier) {
            _contract = new CrudeProductIdentifierContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.ProductId = productId;
            _contract.ProductIdentifierRcd = productIdentifierRcd;
            productIdentifierRefCombo.Text = _contract.ProductIdentifierRcd != null ? _contract.ProductIdentifierRcd : String.Empty;
            _contract.Identifier = identifier;
            textBoxIdentifier.Text = _contract.Identifier;

            RefreshProductIdentifier();
            Show();
        }
        
        public void ShowAsAddByProduct(System.Guid productId) {
            _contract = new CrudeProductIdentifierContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.ProductId = productId;

            RefreshProductIdentifier();
            Show();
        }
        
        public void ShowAsAdd(System.Guid productId, string productIdentifierRcd, string identifier, System.Guid userId) {
            _contract = new CrudeProductIdentifierContract();
            _isNew = true;
            _contract.ProductId = productId;
            _contract.ProductIdentifierRcd = productIdentifierRcd;
            productIdentifierRefCombo.Text = _contract.ProductIdentifierRcd != null ? _contract.ProductIdentifierRcd : String.Empty;
            _contract.Identifier = identifier;
            textBoxIdentifier.Text = _contract.Identifier;
            _contract.UserId = userId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshProductIdentifier();
            Show();
        }
        
        public void ShowAsEdit(System.Guid productIdentifierId) {
            var service = new CrudeProductIdentifierServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductIdentifierId(productIdentifierId);
                productIdentifierRefCombo.Text = _contract.ProductIdentifierRcd != null ? _contract.ProductIdentifierRcd : String.Empty;
                textBoxIdentifier.Text = _contract.Identifier;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                RefreshProductIdentifier();
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeProductIdentifierServiceClient();
            try {
                _contract.ProductIdentifierRcd = productIdentifierRefCombo.Text;
                _contract.Identifier = textBoxIdentifier.Text;

                if (_isNew)
                    service.Insert(_contract);
                else
                    service.Update(_contract);
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }

            Close();
        }
        
        private void buttonProductIdentifierSearch_Click(object sender, EventArgs e) {
            RefreshProductIdentifier();
        }
        
        private void buttonProductIdentifierEdit_Click(object sender, EventArgs e) {
        }
        
        private void buttonProductIdentifierAdd_Click(object sender, EventArgs e) {
            RefreshProductIdentifier();
        }
        
        private void dataGridViewProductIdentifier_DoubleClick(object sender, EventArgs e) {
            var editForm = new ProductIdentifierEdit();
            editForm.MdiParent = this.MdiParent;

        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        public void RefreshProductIdentifier() {

        }
        
        private void InitializeGridProductIdentifier() {
            dataGridViewProductIdentifier.Columns.Clear();
            dataGridViewProductIdentifier.AutoGenerateColumns = false;
            dataGridViewProductIdentifier.Columns.Add("ExtensionData", "");
            dataGridViewProductIdentifier.Columns["ExtensionData"].Visible = false;

            dataGridViewProductIdentifier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductIdentifier.AutoResizeColumns();
        }
    }
}
