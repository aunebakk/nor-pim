using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {
    public partial class MDIParent : Form {
        private int childFormNumber = 0;

        public MDIParent () {
            InitializeComponent ();
        }

        private void ShowNewForm ( object sender , EventArgs e ) {
            Form childForm = new Form ();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show ();
        }

        private void OpenFile ( object sender , EventArgs e ) {
            OpenFileDialog openFileDialog = new OpenFileDialog ();
            openFileDialog.InitialDirectory = Environment.GetFolderPath ( Environment.SpecialFolder.Personal );
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if ( openFileDialog.ShowDialog ( this ) == DialogResult.OK ) {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click ( object sender , EventArgs e ) {
            SaveFileDialog saveFileDialog = new SaveFileDialog ();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath ( Environment.SpecialFolder.Personal );
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if ( saveFileDialog.ShowDialog ( this ) == DialogResult.OK ) {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click ( object sender , EventArgs e ) {
            this.Close ();
        }

        private void CutToolStripMenuItem_Click ( object sender , EventArgs e ) {
        }

        private void CopyToolStripMenuItem_Click ( object sender , EventArgs e ) {
        }

        private void PasteToolStripMenuItem_Click ( object sender , EventArgs e ) {
        }

        private void ToolBarToolStripMenuItem_Click ( object sender , EventArgs e ) {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click ( object sender , EventArgs e ) {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click ( object sender , EventArgs e ) {
            LayoutMdi ( MdiLayout.Cascade );
        }

        private void TileVerticalToolStripMenuItem_Click ( object sender , EventArgs e ) {
            LayoutMdi ( MdiLayout.TileVertical );
        }

        private void TileHorizontalToolStripMenuItem_Click ( object sender , EventArgs e ) {
            LayoutMdi ( MdiLayout.TileHorizontal );
        }

        private void ArrangeIconsToolStripMenuItem_Click ( object sender , EventArgs e ) {
            LayoutMdi ( MdiLayout.ArrangeIcons );
        }

        private void CloseAllToolStripMenuItem_Click ( object sender , EventArgs e ) {
            foreach ( Form childForm in MdiChildren ) {
                childForm.Close ();
            }
        }

        private void crudeCartProductToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeCartProductSearch ();
            child.Show ( this );
        }
        private void crudeCartProductPriceToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeCartProductPriceSearch ();
            child.Show ( this );
        }
        private void crudeClientToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeClientSearch ();
            child.Show ( this );
        }
        private void crudeClientAddressToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeClientAddressSearch ();
            child.Show ( this );
        }
        private void crudeClientContactMethodToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeClientContactMethodSearch ();
            child.Show ( this );
        }
        private void crudeClientDocumentToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeClientDocumentSearch ();
            child.Show ( this );
        }
        private void crudeClientEventToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeClientEventSearch ();
            child.Show ( this );
        }
        private void crudeClientIdentifierToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeClientIdentifierSearch ();
            child.Show ( this );
        }
        private void crudeClientLinkToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeClientLinkSearch ();
            child.Show ( this );
        }
        private void crudeDefaultChangeLogToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultChangeLogSearch ();
            child.Show ( this );
        }
        private void crudeDefaultErrorToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultErrorSearch ();
            child.Show ( this );
        }
        private void crudeDefaultIssueToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultIssueSearch ();
            child.Show ( this );
        }
        private void crudeDefaultPerformanceIssueToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultPerformanceIssueSearch ();
            child.Show ( this );
        }
        private void crudeDefaultPerformanceTimeToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultPerformanceTimeSearch ();
            child.Show ( this );
        }
        private void crudeDefaultPerformanceTimeRollupToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultPerformanceTimeRollupSearch ();
            child.Show ( this );
        }
        private void crudeDefaultResourceMeasurementToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultResourceMeasurementSearch ();
            child.Show ( this );
        }
        private void crudeDefaultRuleToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultRuleSearch ();
            child.Show ( this );
        }
        private void crudeDefaultSystemReferenceTableToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultSystemReferenceTableSearch ();
            child.Show ( this );
        }
        private void crudeDefaultSystemSettingToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultSystemSettingSearch ();
            child.Show ( this );
        }
        private void crudeDefaultTestToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultTestSearch ();
            child.Show ( this );
        }
        private void crudeDefaultTestRunToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultTestRunSearch ();
            child.Show ( this );
        }
        private void crudeDefaultUserToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultUserSearch ();
            child.Show ( this );
        }
        private void crudeDefaultUserActivityToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultUserActivitySearch ();
            child.Show ( this );
        }
        private void crudeDefaultVersionToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultVersionSearch ();
            child.Show ( this );
        }
        private void crudeFinancialAdjustmentToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialAdjustmentSearch ();
            child.Show ( this );
        }
        private void crudeFinancialCompanyToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialCompanySearch ();
            child.Show ( this );
        }
        private void crudeFinancialCostcentreToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialCostcentreSearch ();
            child.Show ( this );
        }
        private void crudeFinancialCouponToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialCouponSearch ();
            child.Show ( this );
        }
        private void crudeFinancialCurrencyToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialCurrencySearch ();
            child.Show ( this );
        }
        private void crudeFinancialFeeToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialFeeSearch ();
            child.Show ( this );
        }
        private void crudeFinancialOrderToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialOrderSearch ();
            child.Show ( this );
        }
        private void crudeFinancialOrderEventToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialOrderEventSearch ();
            child.Show ( this );
        }
        private void crudeFinancialOrderIdentifierToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialOrderIdentifierSearch ();
            child.Show ( this );
        }
        private void crudeFinancialOrderLineToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialOrderLineSearch ();
            child.Show ( this );
        }
        private void crudeFinancialOrderTransactionToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialOrderTransactionSearch ();
            child.Show ( this );
        }
        private void crudeFinancialPaymentToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialPaymentSearch ();
            child.Show ( this );
        }
        private void crudeFinancialPaymentAccountingToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialPaymentAccountingSearch ();
            child.Show ( this );
        }
        private void crudeFinancialPaymentBankToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialPaymentBankSearch ();
            child.Show ( this );
        }
        private void crudeFinancialPaymentCardToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialPaymentCardSearch ();
            child.Show ( this );
        }
        private void crudeFinancialPaymentCashToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialPaymentCashSearch ();
            child.Show ( this );
        }
        private void crudeFinancialPaymentCouponToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialPaymentCouponSearch ();
            child.Show ( this );
        }
        private void crudeFinancialPaymentVoucherToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialPaymentVoucherSearch ();
            child.Show ( this );
        }
        private void crudeFinancialTaxToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialTaxSearch ();
            child.Show ( this );
        }
        private void crudeFinancialVoucherToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialVoucherSearch ();
            child.Show ( this );
        }
        private void crudeLocationAddressToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeLocationAddressSearch ();
            child.Show ( this );
        }
        private void crudeLocationCityToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeLocationCitySearch ();
            child.Show ( this );
        }
        private void crudeLocationCountryToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeLocationCountrySearch ();
            child.Show ( this );
        }
        private void crudeProductToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductSearch ();
            child.Show ( this );
        }
        private void crudeProductAttributeToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductAttributeSearch ();
            child.Show ( this );
        }
        private void crudeProductCategoryToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductCategorySearch ();
            child.Show ( this );
        }
        private void crudeProductCategoryDocumentationToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductCategoryDocumentationSearch ();
            child.Show ( this );
        }
        private void crudeProductCategoryImageToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductCategoryImageSearch ();
            child.Show ( this );
        }
        private void crudeProductCategoryMappingToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductCategoryMappingSearch ();
            child.Show ( this );
        }
        private void crudeProductChangeSetToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductChangeSetSearch ();
            child.Show ( this );
        }
        private void crudeProductDocumentationToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductDocumentationSearch ();
            child.Show ( this );
        }
        private void crudeProductExposeToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductExposeSearch ();
            child.Show ( this );
        }
        private void crudeProductExposePlanToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductExposePlanSearch ();
            child.Show ( this );
        }
        private void crudeProductExposeSetToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductExposeSetSearch ();
            child.Show ( this );
        }
        private void crudeProductExposedSelectionToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductExposedSelectionSearch ();
            child.Show ( this );
        }
        private void crudeProductFieldSetToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductFieldSetSearch ();
            child.Show ( this );
        }
        private void crudeProductFieldSetMappingToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductFieldSetMappingSearch ();
            child.Show ( this );
        }
        private void crudeProductGatherToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductGatherSearch ();
            child.Show ( this );
        }
        private void crudeProductGatherAttributeToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductGatherAttributeSearch ();
            child.Show ( this );
        }
        private void crudeProductGatherKeyToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductGatherKeySearch ();
            child.Show ( this );
        }
        private void crudeProductGatherSourceToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductGatherSourceSearch ();
            child.Show ( this );
        }
        private void crudeProductIdentifierToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductIdentifierSearch ();
            child.Show ( this );
        }
        private void crudeProductImageToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductImageSearch ();
            child.Show ( this );
        }
        private void crudeProductInfoToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductInfoSearch ();
            child.Show ( this );
        }
        private void crudeProductSupplierToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductSupplierSearch ();
            child.Show ( this );
        }
    }
}
