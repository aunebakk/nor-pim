using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Net;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
            Size = new System.Drawing.Size(1024, 568);
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

        private void FormOpened(string formName) {
            Log("open form: " + formName);

            if (Singleton.Instance.UserId == Guid.Empty) {
                MessageBox.Show("Please log in");
                return;
            }

            DefaultUserActivityServiceClient activity = new DefaultUserActivityServiceClient();
            try {
                activity.AddActivityAsync(Singleton.Instance.UserId,
                                            DefaultUserActivityTypeRef.FormOpened,
                                            formName,
                                            Dns.GetHostName()
                                            );
            } catch {
            } finally {
                activity.Close();
            }

        }

        public void ShowUserInfo() {
            FormOpened("ShowUserInfo");

            CrudeDefaultUserServiceClient service = new CrudeDefaultUserServiceClient();

            try {
                CrudeDefaultUserContract contract = service.FetchByDefaultUserId(Singleton.Instance.UserId);

                Text = "nor-port: User code: " + contract.DefaultUserCode
                        + ", Name: " + contract.DefaultUserName;

                Log(Text);

            } catch {
                throw;
            } finally {
                service.Close();
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) {
            Close();
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

        private void userToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeDefaultUserSearch");

                CrudeDefaultUserSearch mdiChild = new CrudeDefaultUserSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, Singleton.Instance.UserId);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            Refresh();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            FormOpened("AboutBox");

            AboutBox newChild = new AboutBox();
            newChild.Show();
        }

        private void Main_Shown(object sender, EventArgs e) {
            Singleton.Instance.LoginShow(this);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e) {

            // todo, validate net connection first!
            Log("Closing main form");
            if (Singleton.Instance.UserId == Guid.Empty) {
                return;
            }

            try {
                DefaultUserActivityServiceClient activity = new DefaultUserActivityServiceClient();
                activity.AddActivityAsync(Singleton.Instance.UserId,
                                            DefaultUserActivityTypeRef.Logout,
                                            e.CloseReason.ToString(),
                                            Dns.GetHostName()
                                            );
                activity.Close();
            } catch {
                // never mind, just close
            } finally {
                // never mind, just close
            }
        }

        private void referenceToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("DefaultSystemReferenceTableSearch");

                DefaultSystemReferenceTableSearch mdiChild = new DefaultSystemReferenceTableSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeDefaultSystemSettingSearch");

                CrudeDefaultSystemSettingSearch mdiChild = new CrudeDefaultSystemSettingSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, Singleton.Instance.UserId);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productCategoryToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeProductCategorySearch");

                CrudeProductCategorySearch mdiChild = new CrudeProductCategorySearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void userActivityToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("DefaultUserActivityRecentSearch");

                DefaultUserActivityRecentSearch mdiChild = new DefaultUserActivityRecentSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void activityOverviewToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("LogCountMonth");

                DefaultStatisticsByMonthSearch mdiChild = new DefaultStatisticsByMonthSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void generalStatisticsToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("Statistics");

                Statistics mdiChild = new Statistics();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void errorLogToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeDefaultErrorSearch");

                CrudeDefaultErrorSearch mdiChild = new CrudeDefaultErrorSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, string.Empty, Singleton.Instance.UserId);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void changeLogToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeDefaultChangeLogSearch");

                CrudeDefaultChangeLogSearch mdiChild = new CrudeDefaultChangeLogSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, Singleton.Instance.UserId, Guid.Empty);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void issueToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeDefaultIssueSearch");

                CrudeDefaultIssueSearch mdiChild = new CrudeDefaultIssueSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, string.Empty, Guid.Empty, Singleton.Instance.UserId);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void errorRuleToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeDefaultRuleSearch");

                CrudeDefaultRuleSearch mdiChild = new CrudeDefaultRuleSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, Singleton.Instance.UserId);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void currencyToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeFinancialCurrencySearch");

                CrudeFinancialCurrencySearch mdiChild = new CrudeFinancialCurrencySearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("ClientSearch");

                CrudeClientSearch mdiChild = new CrudeClientSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, string.Empty, string.Empty, string.Empty, Guid.Empty, Singleton.Instance.UserId);

            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeProductSearch");

                CrudeProductSearch mdiChild = new CrudeProductSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Guid.Empty, Singleton.Instance.UserId);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productCategoryToolStripMenuItem_Click_1(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeProductCategorySearch");

                CrudeProductCategorySearch mdiChild = new CrudeProductCategorySearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Guid.Empty, Guid.Empty, Singleton.Instance.UserId);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productCategoryImageToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeProductCategoryImageSearch");

                CrudeProductCategoryImageSearch mdiChild = new CrudeProductCategoryImageSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, Guid.Empty, Singleton.Instance.UserId);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productPreviewToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("ProductPreview");

                ProductPreview mdiChild = new ProductPreview();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productWhiteboardToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("ProductWhiteboard");

                ProductWhiteboard mdiChild = new ProductWhiteboard();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void selectedToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeCartProductSearch");

                CrudeCartProductSearch mdiChild = new CrudeCartProductSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Guid.Empty, Guid.Empty, Guid.Empty, Singleton.Instance.UserId);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e) {

        }
    }
}
