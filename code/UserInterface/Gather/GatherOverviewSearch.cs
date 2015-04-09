using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class GatherOverviewSearch : Form {
        
        public GatherOverviewSearch() {
           InitializeComponent();
           InitializeGridGatherOverview();
           this.AcceptButton = btnSearch;
           this.CancelButton = btnClose;
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            GatherSearchService gatherOverview = new GatherSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = gatherOverview.GatherOverview();
                gridGatherOverview.AutoGenerateColumns = true;
                gridGatherOverview.DataSource = bindingSource;
                gridGatherOverview.AutoResizeColumns();
                gridGatherOverview.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                gatherOverview.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void InitializeGridGatherOverview() {
            gridGatherOverview.Columns.Clear();
            gridGatherOverview.AutoGenerateColumns = false;
            gridGatherOverview.Columns.Add("ProductGatherId","Product Gather Id");
            gridGatherOverview.Columns.Add("StartDateTime","Start Date Time");
            gridGatherOverview.Columns.Add("FinishDateTime","Finish Date Time");
            gridGatherOverview.Columns.Add("ProductGatherSourceTypeRcd","Product Gather Source Type");
            gridGatherOverview.Columns.Add("ProductGatherSourceTypeName","Product Gather Source Type Name");
            gridGatherOverview.Columns.Add("KeyCount","Key Count");
            gridGatherOverview.Columns.Add("UserName","User Name");
            gridGatherOverview.Columns.Add("DateTime","Date Time");
            gridGatherOverview.Columns.Add("ExtensionData", "");
            gridGatherOverview.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in gridGatherOverview.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            gridGatherOverview.AutoResizeColumns();
        }

        private void buttonChangedProducts_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;

            var mdiChild = new GatherProductDetailsSearch();
            mdiChild.MdiParent = this.MdiParent;
            Singleton.Instance.CheckForm(mdiChild);
            mdiChild.Show();

            Cursor.Current = Cursors.Default;
        }
    }
}
