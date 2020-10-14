/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 2:56:42 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateWithDurianGenerator.UsingWinForm
*/
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductAttributeEdit : Form {
        
        private CrudeProductAttributeContract _contract;
        
        private Boolean _isNew;
        
        public ProductAttributeEdit() {
            InitializeComponent();
            InitializeGridProductAttribute();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductAttributeContract();
            _isNew = true;
            this.Text += " - Not Savable (Product,User Missing)";
            RefreshProductAttribute();
            Show();
        }
        
        public void ShowAsAddByRules(System.Guid userId) {
            _contract = new CrudeProductAttributeContract();
            _isNew = true;
            _contract.UserId = userId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshProductAttribute();
            Show();
        }
        
        public void ShowAsAddByProduct(System.Guid productId) {
            _contract = new CrudeProductAttributeContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.ProductId = productId;

            RefreshProductAttribute();
            Show();
        }
        
        public void ShowAsAddByProductAttribute(string productAttributeRcd) {
            _contract = new CrudeProductAttributeContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.ProductAttributeRcd = productAttributeRcd;
            productAttributeRefCombo.Text = _contract.ProductAttributeRcd != null ? _contract.ProductAttributeRcd : String.Empty;

            RefreshProductAttribute();
            Show();
        }
        
        public void ShowAsAddByProductAttributeUnit(string productAttributeUnitRcd) {
            _contract = new CrudeProductAttributeContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.ProductAttributeUnitRcd = productAttributeUnitRcd;
            productAttributeUnitRefCombo.Text = _contract.ProductAttributeUnitRcd != null ? _contract.ProductAttributeUnitRcd : String.Empty;

            RefreshProductAttribute();
            Show();
        }
        
        public void ShowAsAdd(System.Guid productId, string productAttributeRcd, string productAttributeUnitRcd, string value, System.Guid userId) {
            _contract = new CrudeProductAttributeContract();
            _isNew = true;
            _contract.ProductId = productId;
            _contract.ProductAttributeRcd = productAttributeRcd;
            productAttributeRefCombo.Text = _contract.ProductAttributeRcd != null ? _contract.ProductAttributeRcd : String.Empty;
            _contract.ProductAttributeUnitRcd = productAttributeUnitRcd;
            productAttributeUnitRefCombo.Text = _contract.ProductAttributeUnitRcd != null ? _contract.ProductAttributeUnitRcd : String.Empty;
            _contract.Value = value;
            textBoxValue.Text = _contract.Value;
            _contract.UserId = userId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshProductAttribute();
            Show();
        }
        
        public void ShowAsEdit(System.Guid productAttributeId) {
            var service = new CrudeProductAttributeServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductAttributeId(productAttributeId);
                productAttributeRefCombo.Text = _contract.ProductAttributeRcd != null ? _contract.ProductAttributeRcd : String.Empty;
                productAttributeUnitRefCombo.Text = _contract.ProductAttributeUnitRcd != null ? _contract.ProductAttributeUnitRcd : String.Empty;
                textBoxValue.Text = _contract.Value;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                RefreshProductAttribute();
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeProductAttributeServiceClient();
            try {
                _contract.ProductAttributeRcd = productAttributeRefCombo.Text;
                _contract.ProductAttributeUnitRcd = productAttributeUnitRefCombo.Text;
                _contract.Value = textBoxValue.Text;

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
        
        private void buttonProductAttributeSearch_Click(object sender, EventArgs e) {
            RefreshProductAttribute();
        }
        
        private void buttonProductAttributeEdit_Click(object sender, EventArgs e) {
        }
        
        private void buttonProductAttributeAdd_Click(object sender, EventArgs e) {
            RefreshProductAttribute();
        }
        
        private void dataGridViewProductAttribute_DoubleClick(object sender, EventArgs e) {
            var editForm = new ProductAttributeEdit();
            editForm.MdiParent = this.MdiParent;

        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        public void RefreshProductAttribute() {

        }
        
        private void InitializeGridProductAttribute() {
            dataGridViewProductAttribute.Columns.Clear();
            dataGridViewProductAttribute.AutoGenerateColumns = false;
            dataGridViewProductAttribute.Columns.Add("ExtensionData", "");
            dataGridViewProductAttribute.Columns["ExtensionData"].Visible = false;

            dataGridViewProductAttribute.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductAttribute.AutoResizeColumns();
        }
    }
}
