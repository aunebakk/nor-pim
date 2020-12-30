/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:04:20 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  client winform layer: https://docs.microsoft.com/en-us/dotnet/framework/winforms/
//  docLink: http://sql2x.org/documentationLink/d8f07424-3438-4ff9-8853-3976c1227bad
namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/9dd1c3bf-68b5-40b4-868a-735ee7394422
    public partial class CrudeProductGatherAttributeSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private string _productGatherAttributeTypeRcd;
        
        private System.Guid _productGatherKeyId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeProductGatherAttributeSearch() {
            InitializeComponent();
            InitializeGridCrudeProductGatherAttribute();
            this.AcceptButton = buttonCrudeProductGatherAttributeSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(string productGatherAttributeTypeRcd, System.Guid productGatherKeyId, System.Guid userId) {
            try {
                _productGatherAttributeTypeRcd = productGatherAttributeTypeRcd;
                _productGatherKeyId = productGatherKeyId;
                _userId = userId;

                RefreshCrudeProductGatherAttribute();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/c778f8fe-1b09-4755-891f-f9d3126d1b85
        private void buttonCrudeProductGatherAttributeEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherAttributeEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGatherAttribute.CurrentRow.Cells["ProductGatherAttributeId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/499f894b-7c95-446b-be0a-57fd47b768e3
        private void buttonCrudeProductGatherAttributeAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherAttributeEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/b9e26c97-bd6d-404a-80ad-d252a24c6fe8
        private void dataGridViewCrudeProductGatherAttribute_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherAttributeEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGatherAttribute.CurrentRow.Cells["ProductGatherAttributeId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        // links:
        //  docLink: http://sql2x.org/documentationLink/4c1fe3ad-84a0-4295-bd83-73d9e9afe750
        private void buttonCrudeProductGatherAttributeSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductGatherAttribute();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // closes the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/6b990ce5-1c34-4759-bffd-659ae312004d
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // refresh the grid
        // links:
        //  docLink: http://sql2x.org/documentationLink/a90065e7-8ace-4de7-9367-d4653a7c637f
        public void RefreshCrudeProductGatherAttribute() {
            var productGatherAttribute = new CrudeProductGatherAttributeServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productGatherAttribute.FetchWithFilter(
                             Guid.Empty
                            ,textBoxProductGatherAttributeValue.Text
                            ,productGatherAttributeTypeRefCombo.Text
                            ,Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductGatherAttribute.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherAttribute.DataSource = bindingSource;
                dataGridViewCrudeProductGatherAttribute.AutoResizeColumns();
                dataGridViewCrudeProductGatherAttribute.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productGatherAttribute.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeProductGatherAttribute() {
            try {
                dataGridViewCrudeProductGatherAttribute.Columns.Clear();
                dataGridViewCrudeProductGatherAttribute.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherAttribute.Columns.Add("ProductGatherAttributeValue","Product Gather Attribute Value");
                dataGridViewCrudeProductGatherAttribute.Columns["ProductGatherAttributeValue"].DataPropertyName = "ProductGatherAttributeValue";
                dataGridViewCrudeProductGatherAttribute.Columns.Add("ProductGatherAttributeTypeRcd","Product Gather Attribute Type");
                dataGridViewCrudeProductGatherAttribute.Columns["ProductGatherAttributeTypeRcd"].DataPropertyName = "ProductGatherAttributeTypeRcd";
                dataGridViewCrudeProductGatherAttribute.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductGatherAttribute.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductGatherAttribute.Columns.Add("ProductGatherAttributeId","Product Gather Attribute");
                dataGridViewCrudeProductGatherAttribute.Columns["ProductGatherAttributeId"].DataPropertyName = "ProductGatherAttributeId";
                dataGridViewCrudeProductGatherAttribute.Columns["ProductGatherAttributeId"].Visible = false;
                dataGridViewCrudeProductGatherAttribute.Columns.Add("ProductGatherKeyId","Product Gather Key");
                dataGridViewCrudeProductGatherAttribute.Columns["ProductGatherKeyId"].DataPropertyName = "ProductGatherKeyId";
                dataGridViewCrudeProductGatherAttribute.Columns["ProductGatherKeyId"].Visible = false;
                dataGridViewCrudeProductGatherAttribute.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductGatherAttribute.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductGatherAttribute.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductGatherAttribute.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
