/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:04:16 PM
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
    public partial class CrudeClientAddressSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private string _clientAddressTypeRcd;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeClientAddressSearch() {
            InitializeComponent();
            InitializeGridCrudeClientAddress();
            this.AcceptButton = buttonCrudeClientAddressSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(string clientAddressTypeRcd, System.Guid userId) {
            try {
                _clientAddressTypeRcd = clientAddressTypeRcd;
                _userId = userId;

                RefreshCrudeClientAddress();

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
        private void buttonCrudeClientAddressEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientAddressEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientAddress.CurrentRow.Cells["ClientAddressId"].Value);
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
        private void buttonCrudeClientAddressAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientAddressEdit();
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
        private void dataGridViewCrudeClientAddress_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientAddressEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientAddress.CurrentRow.Cells["ClientAddressId"].Value);
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
        private void buttonCrudeClientAddressSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientAddress();
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
        public void RefreshCrudeClientAddress() {
            var clientAddress = new CrudeClientAddressServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientAddress.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,clientAddressTypeRefCombo.Text
                            ,textBoxAddressLineOneName.Text
                            ,textBoxAddressLineTwoName.Text
                            ,textBoxAddressLineThreeName.Text
                            ,textBoxCityName.Text
                            ,textBoxStreetName.Text
                            ,textBoxStateName.Text
                            ,textBoxDistrictName.Text
                            ,textBoxProvinceName.Text
                            ,textBoxZipCode.Text
                            ,textBoxPoBox.Text
                            ,textBoxComment.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientAddress.AutoGenerateColumns = false;
                dataGridViewCrudeClientAddress.DataSource = bindingSource;
                dataGridViewCrudeClientAddress.AutoResizeColumns();
                dataGridViewCrudeClientAddress.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientAddress.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeClientAddress() {
            try {
                dataGridViewCrudeClientAddress.Columns.Clear();
                dataGridViewCrudeClientAddress.AutoGenerateColumns = false;
                dataGridViewCrudeClientAddress.Columns.Add("AddressLineOneName","Address Line One Name");
                dataGridViewCrudeClientAddress.Columns["AddressLineOneName"].DataPropertyName = "AddressLineOneName";
                dataGridViewCrudeClientAddress.Columns.Add("AddressLineTwoName","Address Line Two Name");
                dataGridViewCrudeClientAddress.Columns["AddressLineTwoName"].DataPropertyName = "AddressLineTwoName";
                dataGridViewCrudeClientAddress.Columns.Add("AddressLineThreeName","Address Line Three Name");
                dataGridViewCrudeClientAddress.Columns["AddressLineThreeName"].DataPropertyName = "AddressLineThreeName";
                dataGridViewCrudeClientAddress.Columns.Add("CityName","City Name");
                dataGridViewCrudeClientAddress.Columns["CityName"].DataPropertyName = "CityName";
                dataGridViewCrudeClientAddress.Columns.Add("StreetName","Street Name");
                dataGridViewCrudeClientAddress.Columns["StreetName"].DataPropertyName = "StreetName";
                dataGridViewCrudeClientAddress.Columns.Add("StateName","State Name");
                dataGridViewCrudeClientAddress.Columns["StateName"].DataPropertyName = "StateName";
                dataGridViewCrudeClientAddress.Columns.Add("DistrictName","District Name");
                dataGridViewCrudeClientAddress.Columns["DistrictName"].DataPropertyName = "DistrictName";
                dataGridViewCrudeClientAddress.Columns.Add("ProvinceName","Province Name");
                dataGridViewCrudeClientAddress.Columns["ProvinceName"].DataPropertyName = "ProvinceName";
                dataGridViewCrudeClientAddress.Columns.Add("ClientAddressTypeRcd","Client Address Type");
                dataGridViewCrudeClientAddress.Columns["ClientAddressTypeRcd"].DataPropertyName = "ClientAddressTypeRcd";
                dataGridViewCrudeClientAddress.Columns.Add("ZipCode","Zip Code");
                dataGridViewCrudeClientAddress.Columns["ZipCode"].DataPropertyName = "ZipCode";
                dataGridViewCrudeClientAddress.Columns.Add("PoBox","Po Box");
                dataGridViewCrudeClientAddress.Columns["PoBox"].DataPropertyName = "PoBox";
                dataGridViewCrudeClientAddress.Columns.Add("Comment","Comment");
                dataGridViewCrudeClientAddress.Columns["Comment"].DataPropertyName = "Comment";
                dataGridViewCrudeClientAddress.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientAddress.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientAddress.Columns.Add("ClientAddressId","Client Address");
                dataGridViewCrudeClientAddress.Columns["ClientAddressId"].DataPropertyName = "ClientAddressId";
                dataGridViewCrudeClientAddress.Columns["ClientAddressId"].Visible = false;
                dataGridViewCrudeClientAddress.Columns.Add("ClientId","Client");
                dataGridViewCrudeClientAddress.Columns["ClientId"].DataPropertyName = "ClientId";
                dataGridViewCrudeClientAddress.Columns["ClientId"].Visible = false;
                dataGridViewCrudeClientAddress.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientAddress.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientAddress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientAddress.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
