using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {
    public partial class MDIParent : Form {
        private int childFormNumber = 0;

        public MDIParent() {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e) {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK) {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK) {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e) {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e) {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (Form childForm in MdiChildren) {
                childForm.Close();
            }
        }

        private void crudeCartProductToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeCartProductSearch child = new CrudeCartProductSearch();
            child.Show(this);
        }
        private void crudeCartProductPriceToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeCartProductPriceSearch child = new CrudeCartProductPriceSearch();
            child.Show(this);
        }
        private void crudeClientToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeClientSearch child = new CrudeClientSearch();
            child.Show(this);
        }
        private void crudeClientAddressToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeClientAddressSearch child = new CrudeClientAddressSearch();
            child.Show(this);
        }
        private void crudeClientContactMethodToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeClientContactMethodSearch child = new CrudeClientContactMethodSearch();
            child.Show(this);
        }
        private void crudeClientDocumentToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeClientDocumentSearch child = new CrudeClientDocumentSearch();
            child.Show(this);
        }
        private void crudeClientEventToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeClientEventSearch child = new CrudeClientEventSearch();
            child.Show(this);
        }
        private void crudeClientIdentifierToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeClientIdentifierSearch child = new CrudeClientIdentifierSearch();
            child.Show(this);
        }
        private void crudeClientLinkToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeClientLinkSearch child = new CrudeClientLinkSearch();
            child.Show(this);
        }
        private void crudeDefaultChangeLogToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeDefaultChangeLogSearch child = new CrudeDefaultChangeLogSearch();
            child.Show(this);
        }
        private void crudeDefaultErrorToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeDefaultErrorSearch child = new CrudeDefaultErrorSearch();
            child.Show(this);
        }
        private void crudeDefaultIssueToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeDefaultIssueSearch child = new CrudeDefaultIssueSearch();
            child.Show(this);
        }
        private void crudeDefaultPerformanceIssueToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeDefaultPerformanceIssueSearch child = new CrudeDefaultPerformanceIssueSearch();
            child.Show(this);
        }
        private void crudeDefaultPerformanceTimeToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeDefaultPerformanceTimeSearch child = new CrudeDefaultPerformanceTimeSearch();
            child.Show(this);
        }
        private void crudeDefaultPerformanceTimeRollupToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeDefaultPerformanceTimeRollupSearch child = new CrudeDefaultPerformanceTimeRollupSearch();
            child.Show(this);
        }
        private void crudeDefaultResourceMeasurementToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeDefaultResourceMeasurementSearch child = new CrudeDefaultResourceMeasurementSearch();
            child.Show(this);
        }
        private void crudeDefaultRuleToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeDefaultRuleSearch child = new CrudeDefaultRuleSearch();
            child.Show(this);
        }
        private void crudeDefaultSystemReferenceTableToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeDefaultSystemReferenceTableSearch child = new CrudeDefaultSystemReferenceTableSearch();
            child.Show(this);
        }
        private void crudeDefaultSystemSettingToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeDefaultSystemSettingSearch child = new CrudeDefaultSystemSettingSearch();
            child.Show(this);
        }
        private void crudeDefaultTestToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeDefaultTestSearch child = new CrudeDefaultTestSearch();
            child.Show(this);
        }
        private void crudeDefaultTestRunToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeDefaultTestRunSearch child = new CrudeDefaultTestRunSearch();
            child.Show(this);
        }
        private void crudeDefaultUserToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeDefaultUserSearch child = new CrudeDefaultUserSearch();
            child.Show(this);
        }
        private void crudeDefaultUserActivityToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeDefaultUserActivitySearch child = new CrudeDefaultUserActivitySearch();
            child.Show(this);
        }
        private void crudeDefaultVersionToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeDefaultVersionSearch child = new CrudeDefaultVersionSearch();
            child.Show(this);
        }
        private void crudeFinancialCurrencyToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeFinancialCurrencySearch child = new CrudeFinancialCurrencySearch();
            child.Show(this);
        }
        private void crudeFinancialOrderToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeFinancialOrderSearch child = new CrudeFinancialOrderSearch();
            child.Show(this);
        }
        private void crudeProductToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductSearch child = new CrudeProductSearch();
            child.Show(this);
        }
        private void crudeProductAttributeToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductAttributeSearch child = new CrudeProductAttributeSearch();
            child.Show(this);
        }
        private void crudeProductCategoryToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductCategorySearch child = new CrudeProductCategorySearch();
            child.Show(this);
        }
        private void crudeProductCategoryDocumentationToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductCategoryDocumentationSearch child = new CrudeProductCategoryDocumentationSearch();
            child.Show(this);
        }
        private void crudeProductCategoryImageToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductCategoryImageSearch child = new CrudeProductCategoryImageSearch();
            child.Show(this);
        }
        private void crudeProductCategoryMappingToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductCategoryMappingSearch child = new CrudeProductCategoryMappingSearch();
            child.Show(this);
        }
        private void crudeProductChangeSetToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductChangeSetSearch child = new CrudeProductChangeSetSearch();
            child.Show(this);
        }
        private void crudeProductDocumentationToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductDocumentationSearch child = new CrudeProductDocumentationSearch();
            child.Show(this);
        }
        private void crudeProductExposeToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductExposeSearch child = new CrudeProductExposeSearch();
            child.Show(this);
        }
        private void crudeProductExposePlanToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductExposePlanSearch child = new CrudeProductExposePlanSearch();
            child.Show(this);
        }
        private void crudeProductExposeSetToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductExposeSetSearch child = new CrudeProductExposeSetSearch();
            child.Show(this);
        }
        private void crudeProductExposedSelectionToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductExposedSelectionSearch child = new CrudeProductExposedSelectionSearch();
            child.Show(this);
        }
        private void crudeProductFieldSetToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductFieldSetSearch child = new CrudeProductFieldSetSearch();
            child.Show(this);
        }
        private void crudeProductFieldSetMappingToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductFieldSetMappingSearch child = new CrudeProductFieldSetMappingSearch();
            child.Show(this);
        }
        private void crudeProductGatherToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductGatherSearch child = new CrudeProductGatherSearch();
            child.Show(this);
        }
        private void crudeProductGatherAttributeToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductGatherAttributeSearch child = new CrudeProductGatherAttributeSearch();
            child.Show(this);
        }
        private void crudeProductGatherKeyToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductGatherKeySearch child = new CrudeProductGatherKeySearch();
            child.Show(this);
        }
        private void crudeProductGatherSourceToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductGatherSourceSearch child = new CrudeProductGatherSourceSearch();
            child.Show(this);
        }
        private void crudeProductIdentifierToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductIdentifierSearch child = new CrudeProductIdentifierSearch();
            child.Show(this);
        }
        private void crudeProductImageToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductImageSearch child = new CrudeProductImageSearch();
            child.Show(this);
        }
        private void crudeProductInfoToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductInfoSearch child = new CrudeProductInfoSearch();
            child.Show(this);
        }
        private void crudeProductSupplierToolStripMenuItem_Click(object sender, EventArgs e) {
            CrudeProductSupplierSearch child = new CrudeProductSupplierSearch();
            child.Show(this);
        }
    }
}
