/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/30/2020 4:47:30 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateWithDurianGenerator.UsingWinForm
*/
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductMaintenanceEdit : Form {
        
        private CrudeProductContract _contract;
        
        private Boolean _isNew;
        
        public ProductMaintenanceEdit() {
            InitializeComponent();
            InitializeGridProductMaintenance();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductContract();
            _isNew = true;
            this.Text += " - Not Savable (User Missing)";
            RefreshProductMaintenance();
            Show();
        }
        
        public void ShowAsAddByRules(System.Guid userId) {
            _contract = new CrudeProductContract();
            _isNew = true;
            _contract.UserId = userId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshProductMaintenance();
            Show();
        }
        
        public void ShowAsAddByProductBecame(System.Guid productBecameId) {
            _contract = new CrudeProductContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.ProductBecameId = productBecameId;

            RefreshProductMaintenance();
            Show();
        }
        
        public void ShowAsAdd(System.Guid productBecameId, string productName, string stateRcd, System.Guid userId) {
            _contract = new CrudeProductContract();
            _isNew = true;
            _contract.ProductBecameId = productBecameId;
            _contract.ProductName = productName;
            textBoxProductName.Text = _contract.ProductName;
            _contract.StateRcd = stateRcd;
            textBoxState.Text = _contract.StateRcd;
            _contract.UserId = userId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshProductMaintenance();
            Show();
        }
        
        public void ShowAsEdit(System.Guid productId) {
            var service = new CrudeProductServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductId(productId);
                textBoxProductName.Text = _contract.ProductName;
                textBoxState.Text = _contract.StateRcd;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                RefreshProductMaintenance();
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeProductServiceClient();
            try {
                _contract.ProductName = textBoxProductName.Text;
                _contract.StateRcd = textBoxState.Text;

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
        
        private void buttonProductMaintenanceSearch_Click(object sender, EventArgs e) {
            RefreshProductMaintenance();
        }
        
        private void buttonProductMaintenanceEdit_Click(object sender, EventArgs e) {
        }
        
        private void buttonProductMaintenanceAdd_Click(object sender, EventArgs e) {
            RefreshProductMaintenance();
        }
        
        private void dataGridViewProductMaintenance_DoubleClick(object sender, EventArgs e) {
            var editForm = new ProductMaintenanceEdit();
            editForm.MdiParent = this.MdiParent;

        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        public void RefreshProductMaintenance() {

        }
        
        private void InitializeGridProductMaintenance() {
            dataGridViewProductMaintenance.Columns.Clear();
            dataGridViewProductMaintenance.AutoGenerateColumns = false;
            dataGridViewProductMaintenance.Columns.Add("ExtensionData", "");
            dataGridViewProductMaintenance.Columns["ExtensionData"].Visible = false;

            dataGridViewProductMaintenance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductMaintenance.AutoResizeColumns();
        }
    }
}
