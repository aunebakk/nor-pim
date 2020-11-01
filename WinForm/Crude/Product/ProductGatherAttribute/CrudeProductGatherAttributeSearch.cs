/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 4:28:20 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    public partial class CrudeProductGatherAttributeSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private string _productGatherAttributeTypeRcd;
        
        private System.Guid _productGatherKeyId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductGatherAttributeSearch() {
            InitializeComponent();
            InitializeGridCrudeProductGatherAttribute();
            this.AcceptButton = buttonCrudeProductGatherAttributeSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
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
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // refresh the grid
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
