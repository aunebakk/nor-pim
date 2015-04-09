using System;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;
using norpim.BusinessLogicLayer.Other;

namespace norpim.UserInterface {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();           
        }

        private void Log(string message) {
            Singleton.Instance.Log(message);
        }

        private void Error(Exception ex) {
            Singleton.Instance.Error(ex);
        }

        private void CheckForm(Form form) {
            Singleton.Instance.CheckForm(form);
        }

        void FormOpened(string formName) {
            Log("open form: " + formName);

            if (Singleton.Instance.UserId == Guid.Empty) {
                MessageBox.Show("Please log in");
                return;
            }


            var activity = new ActivityServiceClient();
            try { 
                activity.AddActivity(   Singleton.Instance.UserId, 
                                        UserActivityTypeRef.FormOpened, 
                                        formName
                                        );
            } catch {
            } finally {
                activity.Close();
            }
            
        }

        public void ShowUserInfo() {
            FormOpened("ShowUserInfo");

            var service = new CrudeUserService();
            
            try {
                var contract = service.FetchByUserId(Singleton.Instance.UserId);

                Text = "norpim: User code: " + contract.UserCode 
                        + ", Name: " + contract.UserName;

                Log(Text);

            } catch {
                throw;
            } finally {
                service.Close();
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
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

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductSearch");

                var mdiChild = new CrudeProductSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeUserSearch");

                var mdiChild = new CrudeUserSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productAttributesToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductAttributeSearch");

                var mdiChild = new CrudeProductAttributeSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productIdentifierToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductIdentifierSearch");

                var mdiChild = new CrudeProductIdentifierSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;        }

        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            this.Refresh();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            FormOpened("AboutBox");

            AboutBox newChild = new AboutBox();
            newChild.Show();
        }

        private void toolStripButtonGather_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("GatherOverviewSearch");

                var mdiChild = new GatherOverviewSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void toolStripButtonOrganize_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("ProductWhiteboard");

                var mdiChild = new ProductWhiteboard();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductImageSearch");

                var mdiChild = new CrudeProductImageSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;        }

        private void Main_Shown(object sender, EventArgs e) {
            Singleton.Instance.LoginShow(this);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e) {

            // todo, validate net connection first!
            Log("Closing main form");
            if (Singleton.Instance.UserId == Guid.Empty)
                return;

            try {
                var activity = new ActivityServiceClient();
                activity.AddActivity(   Singleton.Instance.UserId, 
                                        UserActivityTypeRef.Logout, 
                                        e.CloseReason.ToString()
                                        );
                activity.Close();
            } catch {
                // never mind, just close
            } finally {
                // never mind, just close
            }
        }

        private void activityLogToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeUserActivitySearch");

                var mdiChild = new CrudeUserActivitySearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void toolStripMenuItemGatherStart_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("Engine");

                var mdiChild = new Engine();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void toolStripButtonChangeSet_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductChangeSetSearch");

                var mdiChild = new CrudeProductChangeSetSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void toolStripButtonExpose_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("ExposeProductDetailsSearch");

                var mdiChild = new ExposeProductDetailsSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void referenceToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("SystemReferenceTableSearch");

                var mdiChild = new SystemReferenceTableSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e) {
            Singleton.Instance.LoginShow(this);
            Log("log started");
        }

        private void cleanSlateToolStripMenuItem_Click(object sender, EventArgs e) {
            var categoryServiceClient = new ProductCategoryServiceClient();
            if (MessageBox.Show("Are you sure?", 
                                "All categories will disappear", 
                                MessageBoxButtons.YesNo
                                ) == System.Windows.Forms.DialogResult.Yes) {
                try {
                    categoryServiceClient.CleanSlate(   Singleton.Instance.UserId
                                                        );
                    Log("Categories invalidated");
                } catch (Exception ex) {
                    Error(ex);
                } finally {
                    categoryServiceClient.Close();
                }
            }
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("Statistics");

                var mdiChild = new Statistics();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void configureToolStripMenuItem1_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductExposePlanSearch");

                var mdiChild = new CrudeProductExposePlanSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productCategoryToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductCategorySearch");

                var mdiChild = new CrudeProductCategorySearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productCategoryDocumentationToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductCategoryDocumentationSearch");

                var mdiChild = new CrudeProductCategoryDocumentationSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productCategoryImageToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductCategoryImageSearch");

                var mdiChild = new CrudeProductCategoryImageSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productCategoryMappingToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductCategoryMappingSearch");

                var mdiChild = new CrudeProductCategoryMappingSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productInfoToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductInfoSearch");

                var mdiChild = new CrudeProductInfoSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productDocumentationToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductDocumentationSearch");

                var mdiChild = new CrudeProductDocumentationSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productSupplierToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductSupplierSearch");

                var mdiChild = new CrudeProductSupplierSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productExposeSetToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductExposeSearch");

                var mdiChild = new CrudeProductExposeSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productExposeSetToolStripMenuItem1_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductExposeSetSearch");

                var mdiChild = new CrudeProductExposeSetSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productExposeToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductExposedSelectionSearch");

                var mdiChild = new CrudeProductExposedSelectionSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductGatherSourceSearch");

                var mdiChild = new CrudeProductGatherSourceSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productGatherToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductGatherSearch");

                var mdiChild = new CrudeProductGatherSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productGatherKeyToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductGatherKeySearch");

                var mdiChild = new CrudeProductGatherKeySearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productGatherAttributeToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductGatherAttributeSearch");

                var mdiChild = new CrudeProductGatherAttributeSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productChangeSetToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductChangeSetSearch");

                var mdiChild = new CrudeProductChangeSetSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeSystemSettingSearch");

                var mdiChild = new CrudeSystemSettingSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productFieldSetToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductFieldSetSearch");

                var mdiChild = new CrudeProductFieldSetSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productFieldSetMappingToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("CrudeProductFieldSetMappingSearch");

                var mdiChild = new CrudeProductFieldSetMappingSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void toolStripButtonPreview_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("ProductPreview");

                var mdiChild = new norpim.UserInterface.ProductPreview();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);

            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void logCountMonthToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try { 
                FormOpened("LogCountMonth");

                var mdiChild = new ProductStatisticsByMonthSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) { 
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
