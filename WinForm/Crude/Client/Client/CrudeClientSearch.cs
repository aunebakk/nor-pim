/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 4:09:32 PM
  From Machine: DESKTOP-742U247
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
    public partial class CrudeClientSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private string _clientTypeRcd;
        
        private string _clientNationalityRcd;
        
        private string _clientGenderRcd;
        
        private string _clientTitleRcd;
        
        private System.Guid _clientAddressId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeClientSearch() {
            InitializeComponent();
            InitializeGridCrudeClient();
            this.AcceptButton = buttonCrudeClientSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(string clientTypeRcd, string clientNationalityRcd, string clientGenderRcd, string clientTitleRcd, System.Guid clientAddressId, System.Guid userId) {
            try {
                _clientTypeRcd = clientTypeRcd;
                _clientNationalityRcd = clientNationalityRcd;
                _clientGenderRcd = clientGenderRcd;
                _clientTitleRcd = clientTitleRcd;
                _clientAddressId = clientAddressId;
                _userId = userId;

                RefreshCrudeClient();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeClientEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClient.CurrentRow.Cells["ClientId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeClientAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientEdit();
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
        private void dataGridViewCrudeClient_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClient.CurrentRow.Cells["ClientId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeClientSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClient();
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
        public void RefreshCrudeClient() {
            var client = new CrudeClientServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = client.FetchWithFilter(
                             Guid.Empty
                            ,clientTypeRefCombo.Text
                            ,clientNationalityRefCombo.Text
                            ,clientGenderRefCombo.Text
                            ,clientTitleRefCombo.Text
                            ,Guid.Empty
                            ,textBoxFirstName.Text
                            ,textBoxMiddleName.Text
                            ,textBoxLastName.Text
                            ,null
                            ,textBoxImageBlobFilename.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClient.AutoGenerateColumns = false;
                dataGridViewCrudeClient.DataSource = bindingSource;
                dataGridViewCrudeClient.AutoResizeColumns();
                dataGridViewCrudeClient.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                client.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeClient() {
            try {
                dataGridViewCrudeClient.Columns.Clear();
                dataGridViewCrudeClient.AutoGenerateColumns = false;
                dataGridViewCrudeClient.Columns.Add("FirstName","First Name");
                dataGridViewCrudeClient.Columns["FirstName"].DataPropertyName = "FirstName";
                dataGridViewCrudeClient.Columns.Add("MiddleName","Middle Name");
                dataGridViewCrudeClient.Columns["MiddleName"].DataPropertyName = "MiddleName";
                dataGridViewCrudeClient.Columns.Add("LastName","Last Name");
                dataGridViewCrudeClient.Columns["LastName"].DataPropertyName = "LastName";
                dataGridViewCrudeClient.Columns.Add("ClientTypeRcd","Client Type");
                dataGridViewCrudeClient.Columns["ClientTypeRcd"].DataPropertyName = "ClientTypeRcd";
                dataGridViewCrudeClient.Columns.Add("ClientNationalityRcd","Client Nationality");
                dataGridViewCrudeClient.Columns["ClientNationalityRcd"].DataPropertyName = "ClientNationalityRcd";
                dataGridViewCrudeClient.Columns.Add("ClientGenderRcd","Client Gender");
                dataGridViewCrudeClient.Columns["ClientGenderRcd"].DataPropertyName = "ClientGenderRcd";
                dataGridViewCrudeClient.Columns.Add("ClientTitleRcd","Client Title");
                dataGridViewCrudeClient.Columns["ClientTitleRcd"].DataPropertyName = "ClientTitleRcd";
                dataGridViewCrudeClient.Columns.Add("ImageBlobFilename","Image Blob Filename");
                dataGridViewCrudeClient.Columns["ImageBlobFilename"].DataPropertyName = "ImageBlobFilename";
                dataGridViewCrudeClient.Columns.Add("Image","Image");
                dataGridViewCrudeClient.Columns["Image"].DataPropertyName = "Image";
                dataGridViewCrudeClient.Columns["Image"].Visible = false;
                dataGridViewCrudeClient.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClient.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClient.Columns.Add("ClientId","Client");
                dataGridViewCrudeClient.Columns["ClientId"].DataPropertyName = "ClientId";
                dataGridViewCrudeClient.Columns["ClientId"].Visible = false;
                dataGridViewCrudeClient.Columns.Add("ClientAddressId","Client Address");
                dataGridViewCrudeClient.Columns["ClientAddressId"].DataPropertyName = "ClientAddressId";
                dataGridViewCrudeClient.Columns["ClientAddressId"].Visible = false;
                dataGridViewCrudeClient.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClient.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClient.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
