﻿/*
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
    public partial class CrudeClientTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeClientTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientTypeRef();
            this.AcceptButton = buttonCrudeClientTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeClientTypeRef();

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
        private void buttonCrudeClientTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientTypeRef.CurrentRow.Cells["ClientTypeRcd"].Value,_userId);
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
        private void buttonCrudeClientTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientTypeRefEdit();
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
        private void dataGridViewCrudeClientTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientTypeRef.CurrentRow.Cells["ClientTypeRcd"].Value,_userId);
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
        private void buttonCrudeClientTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientTypeRef();
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
        public void RefreshCrudeClientTypeRef() {
            var clientTypeRef = new CrudeClientTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientTypeRef.FetchWithFilter(
                             textBoxClientType.Text
                            ,textBoxClientTypeName.Text
                            ,textBoxClientTypeDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientTypeRef.DataSource = bindingSource;
                dataGridViewCrudeClientTypeRef.AutoResizeColumns();
                dataGridViewCrudeClientTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeClientTypeRef() {
            try {
                dataGridViewCrudeClientTypeRef.Columns.Clear();
                dataGridViewCrudeClientTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientTypeRef.Columns.Add("ClientTypeName","Client Type Name");
                dataGridViewCrudeClientTypeRef.Columns["ClientTypeName"].DataPropertyName = "ClientTypeName";
                dataGridViewCrudeClientTypeRef.Columns.Add("ClientTypeRcd","Client Type");
                dataGridViewCrudeClientTypeRef.Columns["ClientTypeRcd"].DataPropertyName = "ClientTypeRcd";
                dataGridViewCrudeClientTypeRef.Columns.Add("ClientTypeDescription","Client Type Description");
                dataGridViewCrudeClientTypeRef.Columns["ClientTypeDescription"].DataPropertyName = "ClientTypeDescription";
                dataGridViewCrudeClientTypeRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientTypeRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientTypeRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientTypeRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
