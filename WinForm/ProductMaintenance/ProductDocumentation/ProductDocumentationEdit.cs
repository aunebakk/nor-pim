/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 4:20:12 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateWithDurianGenerator.UsingWinForm
*/
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductDocumentationEdit : Form {
        
        private CrudeProductDocumentationContract _contract;
        
        private Boolean _isNew;
        
        public ProductDocumentationEdit() {
            InitializeComponent();
            InitializeGridProductDocumentation();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductDocumentationContract();
            _isNew = true;
            this.Text += " - Not Savable (Product,User Missing)";
            RefreshProductDocumentation();
            Show();
        }
        
        public void ShowAsAddByRules(System.Guid userId) {
            _contract = new CrudeProductDocumentationContract();
            _isNew = true;
            _contract.UserId = userId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshProductDocumentation();
            Show();
        }
        
        public void ShowAsAddByProductDocumentationTypeAndDocumentation(string productDocumentationTypeRcd, string documentation) {
            _contract = new CrudeProductDocumentationContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.ProductDocumentationTypeRcd = productDocumentationTypeRcd;
            productDocumentationTypeRefCombo.Text = _contract.ProductDocumentationTypeRcd != null ? _contract.ProductDocumentationTypeRcd : String.Empty;
            _contract.Documentation = documentation;
            textBoxDocumentation.Text = _contract.Documentation;

            RefreshProductDocumentation();
            Show();
        }
        
        public void ShowAsAddByProduct(System.Guid productId) {
            _contract = new CrudeProductDocumentationContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.ProductId = productId;

            RefreshProductDocumentation();
            Show();
        }
        
        public void ShowAsAdd(System.Guid productId, string productDocumentationTypeRcd, string documentation, System.Guid userId) {
            _contract = new CrudeProductDocumentationContract();
            _isNew = true;
            _contract.ProductId = productId;
            _contract.ProductDocumentationTypeRcd = productDocumentationTypeRcd;
            productDocumentationTypeRefCombo.Text = _contract.ProductDocumentationTypeRcd != null ? _contract.ProductDocumentationTypeRcd : String.Empty;
            _contract.Documentation = documentation;
            textBoxDocumentation.Text = _contract.Documentation;
            _contract.UserId = userId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshProductDocumentation();
            Show();
        }
        
        public void ShowAsEdit(System.Guid productDocumentationId) {
            var service = new CrudeProductDocumentationServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductDocumentationId(productDocumentationId);
                productDocumentationTypeRefCombo.Text = _contract.ProductDocumentationTypeRcd != null ? _contract.ProductDocumentationTypeRcd : String.Empty;
                textBoxDocumentation.Text = _contract.Documentation;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                RefreshProductDocumentation();
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeProductDocumentationServiceClient();
            try {
                _contract.ProductDocumentationTypeRcd = productDocumentationTypeRefCombo.Text;
                _contract.Documentation = textBoxDocumentation.Text;

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
        
        private void buttonProductDocumentationSearch_Click(object sender, EventArgs e) {
            RefreshProductDocumentation();
        }
        
        private void buttonProductDocumentationEdit_Click(object sender, EventArgs e) {
        }
        
        private void buttonProductDocumentationAdd_Click(object sender, EventArgs e) {
            RefreshProductDocumentation();
        }
        
        private void dataGridViewProductDocumentation_DoubleClick(object sender, EventArgs e) {
            var editForm = new ProductDocumentationEdit();
            editForm.MdiParent = this.MdiParent;

        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        public void RefreshProductDocumentation() {

        }
        
        private void InitializeGridProductDocumentation() {
            dataGridViewProductDocumentation.Columns.Clear();
            dataGridViewProductDocumentation.AutoGenerateColumns = false;
            dataGridViewProductDocumentation.Columns.Add("ExtensionData", "");
            dataGridViewProductDocumentation.Columns["ExtensionData"].Visible = false;

            dataGridViewProductDocumentation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductDocumentation.AutoResizeColumns();
        }
    }
}
