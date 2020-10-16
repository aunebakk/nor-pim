/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 5:53:17 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Windows.Forms;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    public partial class CrudeDefaultErrorLayerRefSearch : Form {

        // the following fields holds initial state for foreign key's
        private System.Guid _defaultUserId;

        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultErrorLayerRefSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultErrorLayerRef();
            AcceptButton = buttonCrudeDefaultErrorLayerRefSearch;
            CancelButton = buttonClose;
        }

        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;

                RefreshCrudeDefaultErrorLayerRef();

                base.Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeDefaultErrorLayerRefEdit_Click(object sender, EventArgs e) {
            try {
                CrudeDefaultErrorLayerRefEdit editForm = new CrudeDefaultErrorLayerRefEdit();
                editForm.MdiParent = MdiParent;
                editForm.ShowAsEdit((string)dataGridViewCrudeDefaultErrorLayerRef.CurrentRow.Cells["DefaultErrorLayerRcd"].Value, _defaultUserId);
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows a form for adding more rows
        private void buttonCrudeDefaultErrorLayerRefAdd_Click(object sender, EventArgs e) {
            try {
                CrudeDefaultErrorLayerRefEdit editForm = new CrudeDefaultErrorLayerRefEdit();
                editForm.MdiParent = MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows the detailed version of the selected grid row, in edit modus
        private void dataGridViewCrudeDefaultErrorLayerRef_DoubleClick(object sender, EventArgs e) {
            try {
                CrudeDefaultErrorLayerRefEdit editForm = new CrudeDefaultErrorLayerRefEdit();
                editForm.MdiParent = MdiParent;
                editForm.ShowAsEdit((string)dataGridViewCrudeDefaultErrorLayerRef.CurrentRow.Cells["DefaultErrorLayerRcd"].Value, _defaultUserId);
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // does a search based on the filter and populates the grid
        private void buttonCrudeDefaultErrorLayerRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultErrorLayerRef();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // closes the form
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        // refresh the grid
        public void RefreshCrudeDefaultErrorLayerRef() {
            CrudeDefaultErrorLayerRefServiceClient defaultErrorLayerRef = new CrudeDefaultErrorLayerRefServiceClient();

            try {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = defaultErrorLayerRef.FetchWithFilter(
                             textBoxDefaultErrorLayer.Text
                            , textBoxDefaultErrorLayerName.Text
                            , Guid.Empty
                            , DateTime.MinValue
                            );
                dataGridViewCrudeDefaultErrorLayerRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultErrorLayerRef.DataSource = bindingSource;
                dataGridViewCrudeDefaultErrorLayerRef.AutoResizeColumns();
                dataGridViewCrudeDefaultErrorLayerRef.Refresh();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            } finally {
                defaultErrorLayerRef.Close();
            }
        }

        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeDefaultErrorLayerRef() {
            try {
                dataGridViewCrudeDefaultErrorLayerRef.Columns.Clear();
                dataGridViewCrudeDefaultErrorLayerRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultErrorLayerRef.Columns.Add("DefaultErrorLayerName", "Default Error Layer Name");
                dataGridViewCrudeDefaultErrorLayerRef.Columns["DefaultErrorLayerName"].DataPropertyName = "DefaultErrorLayerName";
                dataGridViewCrudeDefaultErrorLayerRef.Columns.Add("DefaultErrorLayerRcd", "Default Error Layer");
                dataGridViewCrudeDefaultErrorLayerRef.Columns["DefaultErrorLayerRcd"].DataPropertyName = "DefaultErrorLayerRcd";
                dataGridViewCrudeDefaultErrorLayerRef.Columns.Add("DateTime", "Date Time");
                dataGridViewCrudeDefaultErrorLayerRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultErrorLayerRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultErrorLayerRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultErrorLayerRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultErrorLayerRef.AutoResizeColumns();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }
    }
}
