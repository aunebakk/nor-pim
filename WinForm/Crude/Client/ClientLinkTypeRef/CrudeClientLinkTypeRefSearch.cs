/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:26:25 AM
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
    public partial class CrudeClientLinkTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeClientLinkTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientLinkTypeRef();
            this.AcceptButton = buttonCrudeClientLinkTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeClientLinkTypeRef();

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
        private void buttonCrudeClientLinkTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientLinkTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientLinkTypeRef.CurrentRow.Cells["ClientLinkTypeRcd"].Value,_userId);
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
        private void buttonCrudeClientLinkTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientLinkTypeRefEdit();
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
        private void dataGridViewCrudeClientLinkTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientLinkTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientLinkTypeRef.CurrentRow.Cells["ClientLinkTypeRcd"].Value,_userId);
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
        private void buttonCrudeClientLinkTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientLinkTypeRef();
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
        public void RefreshCrudeClientLinkTypeRef() {
            var clientLinkTypeRef = new CrudeClientLinkTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientLinkTypeRef.FetchWithFilter(
                             textBoxClientLinkType.Text
                            ,textBoxClientLinkTypeName.Text
                            ,textBoxClientLinkTypeDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientLinkTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientLinkTypeRef.DataSource = bindingSource;
                dataGridViewCrudeClientLinkTypeRef.AutoResizeColumns();
                dataGridViewCrudeClientLinkTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientLinkTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeClientLinkTypeRef() {
            try {
                dataGridViewCrudeClientLinkTypeRef.Columns.Clear();
                dataGridViewCrudeClientLinkTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("ClientLinkTypeName","Client Link Type Name");
                dataGridViewCrudeClientLinkTypeRef.Columns["ClientLinkTypeName"].DataPropertyName = "ClientLinkTypeName";
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("ClientLinkTypeRcd","Client Link Type");
                dataGridViewCrudeClientLinkTypeRef.Columns["ClientLinkTypeRcd"].DataPropertyName = "ClientLinkTypeRcd";
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("ClientLinkTypeDescription","Client Link Type Description");
                dataGridViewCrudeClientLinkTypeRef.Columns["ClientLinkTypeDescription"].DataPropertyName = "ClientLinkTypeDescription";
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientLinkTypeRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientLinkTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientLinkTypeRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientLinkTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientLinkTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientLinkTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
