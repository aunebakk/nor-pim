/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:50:06 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateWithDurianGenerator.UsingWinForm
*/
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductInfoEdit : Form {
        
        private CrudeProductInfoContract _contract;
        
        private Boolean _isNew;
        
        public ProductInfoEdit() {
            InitializeComponent();
            InitializeGridProductInfo();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductInfoContract();
            _isNew = true;
            this.Text += " - Not Savable (Product,User Missing)";
            RefreshProductInfo();
            Show();
        }
        
        public void ShowAsAddByRules(System.Guid userId) {
            _contract = new CrudeProductInfoContract();
            _isNew = true;
            _contract.UserId = userId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshProductInfo();
            Show();
        }
        
        public void ShowAsAddByProduct(System.Guid productId) {
            _contract = new CrudeProductInfoContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.ProductId = productId;

            RefreshProductInfo();
            Show();
        }
        
        public void ShowAsAddByProductInfo(string productInfoRcd) {
            _contract = new CrudeProductInfoContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.ProductInfoRcd = productInfoRcd;
            productInfoRefCombo.Text = _contract.ProductInfoRcd != null ? _contract.ProductInfoRcd : String.Empty;

            RefreshProductInfo();
            Show();
        }
        
        public void ShowAsAdd(System.Guid productId, string productInfoRcd, string productInfoValue, System.Guid userId) {
            _contract = new CrudeProductInfoContract();
            _isNew = true;
            _contract.ProductId = productId;
            _contract.ProductInfoRcd = productInfoRcd;
            productInfoRefCombo.Text = _contract.ProductInfoRcd != null ? _contract.ProductInfoRcd : String.Empty;
            _contract.ProductInfoValue = productInfoValue;
            textBoxProductInfoValue.Text = _contract.ProductInfoValue;
            _contract.UserId = userId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshProductInfo();
            Show();
        }
        
        public void ShowAsEdit(System.Guid productInfoId) {
            var service = new CrudeProductInfoServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductInfoId(productInfoId);
                productInfoRefCombo.Text = _contract.ProductInfoRcd != null ? _contract.ProductInfoRcd : String.Empty;
                textBoxProductInfoValue.Text = _contract.ProductInfoValue;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                RefreshProductInfo();
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeProductInfoServiceClient();
            try {
                _contract.ProductInfoRcd = productInfoRefCombo.Text;
                _contract.ProductInfoValue = textBoxProductInfoValue.Text;

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
        
        private void buttonProductInfoSearch_Click(object sender, EventArgs e) {
            RefreshProductInfo();
        }
        
        private void buttonProductInfoEdit_Click(object sender, EventArgs e) {
        }
        
        private void buttonProductInfoAdd_Click(object sender, EventArgs e) {
            RefreshProductInfo();
        }
        
        private void dataGridViewProductInfo_DoubleClick(object sender, EventArgs e) {
            var editForm = new ProductInfoEdit();
            editForm.MdiParent = this.MdiParent;

        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        public void RefreshProductInfo() {

        }
        
        private void InitializeGridProductInfo() {
            dataGridViewProductInfo.Columns.Clear();
            dataGridViewProductInfo.AutoGenerateColumns = false;
            dataGridViewProductInfo.Columns.Add("ExtensionData", "");
            dataGridViewProductInfo.Columns["ExtensionData"].Visible = false;

            dataGridViewProductInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductInfo.AutoResizeColumns();
        }
    }
}
