/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:26:27 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  docLink: http://sql2x.org/documentationLink/d8f07424-3438-4ff9-8853-3976c1227bad
namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/9dd1c3bf-68b5-40b4-868a-735ee7394422
    public partial class CrudeProductAttributeUnitRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeProductAttributeUnitRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductAttributeUnitRef();
            this.AcceptButton = buttonCrudeProductAttributeUnitRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeProductAttributeUnitRef();

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
        private void buttonCrudeProductAttributeUnitRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductAttributeUnitRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductAttributeUnitRef.CurrentRow.Cells["ProductAttributeUnitRcd"].Value,_userId);
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
        private void buttonCrudeProductAttributeUnitRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductAttributeUnitRefEdit();
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
        private void dataGridViewCrudeProductAttributeUnitRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductAttributeUnitRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductAttributeUnitRef.CurrentRow.Cells["ProductAttributeUnitRcd"].Value,_userId);
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
        private void buttonCrudeProductAttributeUnitRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductAttributeUnitRef();
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
        public void RefreshCrudeProductAttributeUnitRef() {
            var productAttributeUnitRef = new CrudeProductAttributeUnitRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productAttributeUnitRef.FetchWithFilter(
                             textBoxProductAttributeUnit.Text
                            ,textBoxProductAttributeUnitName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductAttributeUnitRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductAttributeUnitRef.DataSource = bindingSource;
                dataGridViewCrudeProductAttributeUnitRef.AutoResizeColumns();
                dataGridViewCrudeProductAttributeUnitRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productAttributeUnitRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeProductAttributeUnitRef() {
            try {
                dataGridViewCrudeProductAttributeUnitRef.Columns.Clear();
                dataGridViewCrudeProductAttributeUnitRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductAttributeUnitRef.Columns.Add("ProductAttributeUnitName","Product Attribute Unit Name");
                dataGridViewCrudeProductAttributeUnitRef.Columns["ProductAttributeUnitName"].DataPropertyName = "ProductAttributeUnitName";
                dataGridViewCrudeProductAttributeUnitRef.Columns.Add("ProductAttributeUnitRcd","Product Attribute Unit");
                dataGridViewCrudeProductAttributeUnitRef.Columns["ProductAttributeUnitRcd"].DataPropertyName = "ProductAttributeUnitRcd";
                dataGridViewCrudeProductAttributeUnitRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductAttributeUnitRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductAttributeUnitRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductAttributeUnitRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductAttributeUnitRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductAttributeUnitRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
