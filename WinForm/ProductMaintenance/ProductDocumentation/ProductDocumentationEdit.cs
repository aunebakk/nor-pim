/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:15:49 PM
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
    public partial class ProductDocumentationEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a5a
        private CrudeProductDocumentationContract _contract;
        
        // true if form is in New modus, else Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a5b
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/e6bf67b2-7eb4-4882-bf12-aa5ae6eec6bf
        public ProductDocumentationEdit() {
            InitializeComponent();
            InitializeGridProductDocumentation();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // bring up add form for ProductDocumentation
        // links:
        //  docLink: http://sql2x.org/documentationLink/c0944961-8179-40a2-a561-c8873b691f2c
        public void ShowAsAdd() {
            _contract = new CrudeProductDocumentationContract();
            _isNew = true;
            this.Text += " - Not Savable (Product,User Missing)";
            RefreshProductDocumentation();
            Show();
        }
        
        // bring up add form for ProductDocumentation with rules
        // links:
        //  docLink: http://sql2x.org/documentationLink/6018e96e-28a1-4df4-879b-01a6bda81cc7
        public void ShowAsAddByRules(System.Guid userId) {
            _contract = new CrudeProductDocumentationContract();
            _isNew = true;
            _contract.UserId = userId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshProductDocumentation();
            Show();
        }
        
        // bring up add form for ProductDocumentation by foreign key ProductDocumentationTypeAndDocumentation
        // links:
        //  docLink: http://sql2x.org/documentationLink/2461e69c-dd05-47db-8f32-27ac1641a8d9
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
        
        // bring up add form for ProductDocumentation by foreign key Product
        // links:
        //  docLink: http://sql2x.org/documentationLink/2461e69c-dd05-47db-8f32-27ac1641a8d9
        public void ShowAsAddByProduct(System.Guid productId) {
            _contract = new CrudeProductDocumentationContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.ProductId = productId;

            RefreshProductDocumentation();
            Show();
        }
        
        // bring up add form for ProductDocumentation
        // links:
        //  docLink: http://sql2x.org/documentationLink/8568fd9a-b807-4aad-ac74-7826975e3241
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
        
        // bring up edit form for ProductDocumentation
        // links:
        //  docLink: http://sql2x.org/documentationLink/d7ff032d-3bcf-438f-9850-900ca0ebca98
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
        
        // save and close ProductDocumentation
        // links:
        //  docLink: http://sql2x.org/documentationLink/d71519ff-fa27-4f64-9194-56886e4070ba
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
        
        // search ProductDocumentation
        // links:
        //  docLink: http://sql2x.org/documentationLink/80a1bfbb-de84-4829-b248-3618a1657aae
        private void buttonProductDocumentationSearch_Click(object sender, EventArgs e) {
            RefreshProductDocumentation();
        }
        
        // bring up edit form for ProductDocumentation
        // links:
        //  docLink: http://sql2x.org/documentationLink/634a3333-2588-4ce9-a69e-146e6db06604
        private void buttonProductDocumentationEdit_Click(object sender, EventArgs e) {
            // no code because ChildDefinition is missing
        }
        
        // bring up add form for ProductDocumentation
        // links:
        //  docLink: http://sql2x.org/documentationLink/8a47adae-c002-48ab-8926-9daa6f237b92
        private void buttonProductDocumentationAdd_Click(object sender, EventArgs e) {
            // no code because ChildDefinition is missing
        }
        
        // bring up edit form for ProductDocumentation
        // links:
        //  docLink: http://sql2x.org/documentationLink/a0d70634-76b1-43a0-bf41-c77b3ab4107f
        private void dataGridViewProductDocumentation_DoubleClick(object sender, EventArgs e) {
            var editForm = new ProductDocumentationEdit();
            editForm.MdiParent = this.MdiParent;
            // no code because ChildDefinition is missing
        }
        
        // close form for ProductDocumentation
        // links:
        //  docLink: http://sql2x.org/documentationLink/6cba4762-d598-4fc1-a165-225b3b86183f
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // refresh ProductDocumentation's
        // links:
        //  docLink: http://sql2x.org/documentationLink/40b9491c-7991-43e7-9e8d-06181fd0a7c6
        public void RefreshProductDocumentation() {
            // no code because ChildDefinition is missing}
        }
        
        // initialize grid for ProductDocumentation
        // links:
        //  docLink: http://sql2x.org/documentationLink/680c9cdb-dd8c-46bb-bb39-82bc124ebf5b
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
