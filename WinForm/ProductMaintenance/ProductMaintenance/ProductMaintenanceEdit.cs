/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:15:42 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateWithDurianGenerator.UsingWinForm
*/
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/3d7a6660-be53-41aa-8f9d-7504e6026105
    public partial class ProductMaintenanceEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a5a
        private CrudeProductContract _contract;
        
        // true if form is in New modus, else Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a5b
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/e6bf67b2-7eb4-4882-bf12-aa5ae6eec6bf
        public ProductMaintenanceEdit() {
            InitializeComponent();
            InitializeGridProductMaintenance();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // bring up add form for ProductMaintenance
        // links:
        //  docLink: http://sql2x.org/documentationLink/c0944961-8179-40a2-a561-c8873b691f2c
        public void ShowAsAdd() {
            _contract = new CrudeProductContract();
            _isNew = true;
            this.Text += " - Not Savable (User Missing)";
            RefreshProductMaintenance();
            Show();
        }
        
        // bring up add form for ProductMaintenance with rules
        // links:
        //  docLink: http://sql2x.org/documentationLink/6018e96e-28a1-4df4-879b-01a6bda81cc7
        public void ShowAsAddByRules(System.Guid userId) {
            _contract = new CrudeProductContract();
            _isNew = true;
            _contract.UserId = userId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshProductMaintenance();
            Show();
        }
        
        // bring up add form for ProductMaintenance by foreign key ProductBecame
        // links:
        //  docLink: http://sql2x.org/documentationLink/2461e69c-dd05-47db-8f32-27ac1641a8d9
        public void ShowAsAddByProductBecame(System.Guid productBecameId) {
            _contract = new CrudeProductContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.ProductBecameId = productBecameId;

            RefreshProductMaintenance();
            Show();
        }
        
        // bring up add form for ProductMaintenance
        // links:
        //  docLink: http://sql2x.org/documentationLink/8568fd9a-b807-4aad-ac74-7826975e3241
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
        
        // bring up edit form for ProductMaintenance
        // links:
        //  docLink: http://sql2x.org/documentationLink/d7ff032d-3bcf-438f-9850-900ca0ebca98
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
        
        // save and close ProductMaintenance
        // links:
        //  docLink: http://sql2x.org/documentationLink/d71519ff-fa27-4f64-9194-56886e4070ba
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
        
        // search ProductMaintenance
        // links:
        //  docLink: http://sql2x.org/documentationLink/80a1bfbb-de84-4829-b248-3618a1657aae
        private void buttonProductMaintenanceSearch_Click(object sender, EventArgs e) {
            RefreshProductMaintenance();
        }
        
        // bring up edit form for ProductMaintenance
        // links:
        //  docLink: http://sql2x.org/documentationLink/634a3333-2588-4ce9-a69e-146e6db06604
        private void buttonProductMaintenanceEdit_Click(object sender, EventArgs e) {
            // no code because ChildDefinition is missing
        }
        
        // bring up add form for ProductMaintenance
        // links:
        //  docLink: http://sql2x.org/documentationLink/8a47adae-c002-48ab-8926-9daa6f237b92
        private void buttonProductMaintenanceAdd_Click(object sender, EventArgs e) {
            // no code because ChildDefinition is missing
        }
        
        // bring up edit form for ProductMaintenance
        // links:
        //  docLink: http://sql2x.org/documentationLink/a0d70634-76b1-43a0-bf41-c77b3ab4107f
        private void dataGridViewProductMaintenance_DoubleClick(object sender, EventArgs e) {
            var editForm = new ProductMaintenanceEdit();
            editForm.MdiParent = this.MdiParent;
            // no code because ChildDefinition is missing
        }
        
        // close form for ProductMaintenance
        // links:
        //  docLink: http://sql2x.org/documentationLink/6cba4762-d598-4fc1-a165-225b3b86183f
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // refresh ProductMaintenance's
        // links:
        //  docLink: http://sql2x.org/documentationLink/40b9491c-7991-43e7-9e8d-06181fd0a7c6
        public void RefreshProductMaintenance() {
            // no code because ChildDefinition is missing}
        }
        
        // initialize grid for ProductMaintenance
        // links:
        //  docLink: http://sql2x.org/documentationLink/680c9cdb-dd8c-46bb-bb39-82bc124ebf5b
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
