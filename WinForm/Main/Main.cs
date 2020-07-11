using System;
using System.Net;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface
{
    public partial class Main : Form
    {
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

        void FormOpened(string formName) {
            Log("open form: " + formName);

            if ( Singleton.Instance.UserId == Guid.Empty ) {
                MessageBox.Show("Please log in");
                return;
            }

            var activity = new DefaultUserActivityServiceClient();
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

            var service = new CrudeDefaultUserServiceClient();

            try {
                var contract = service.FetchByDefaultUserId(Singleton.Instance.UserId);

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
            foreach ( Form childForm in MdiChildren ) {
                childForm.Close();
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeDefaultUserSearch");

                var mdiChild = new CrudeDefaultUserSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, Singleton.Instance.UserId);
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            this.Refresh();
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
            if ( Singleton.Instance.UserId == Guid.Empty )
                return;

            try {
                var activity = new DefaultUserActivityServiceClient();
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

                var mdiChild = new DefaultSystemReferenceTableSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeDefaultSystemSettingSearch");

                var mdiChild = new CrudeDefaultSystemSettingSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, Singleton.Instance.UserId);
            } catch ( Exception ex ) {
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
                mdiChild.Show();
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void userActivityToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("DefaultUserActivityRecentSearch");

                var mdiChild = new DefaultUserActivityRecentSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void activityOverviewToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("LogCountMonth");

                var mdiChild = new DefaultStatisticsByMonthSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void generalStatisticsToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("Statistics");

                var mdiChild = new Statistics();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void errorLogToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeDefaultErrorSearch");

                var mdiChild = new CrudeDefaultErrorSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, string.Empty, Singleton.Instance.UserId);
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void changeLogToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeDefaultChangeLogSearch");

                var mdiChild = new CrudeDefaultChangeLogSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, Singleton.Instance.UserId, Guid.Empty);
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void issueToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeDefaultIssueSearch");

                var mdiChild = new CrudeDefaultIssueSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, string.Empty, Guid.Empty, Singleton.Instance.UserId);
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void errorRuleToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeDefaultRuleSearch");

                var mdiChild = new CrudeDefaultRuleSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, Singleton.Instance.UserId);
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void currencyToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeFinancialCurrencySearch");

                var mdiChild = new CrudeFinancialCurrencySearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened ( "ClientSearch" );

                var mdiChild = new CrudeClientSearch ();
                CheckForm ( mdiChild );
                mdiChild.MdiParent = this;
                mdiChild.Show ( string.Empty, string.Empty , string.Empty , string.Empty , Guid.Empty, Singleton.Instance.UserId );

            } catch ( Exception ex ) {
                Error ( ex );
            }
            Cursor.Current = Cursors.Default;
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeProductSearch");

                var mdiChild = new CrudeProductSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Guid.Empty, Singleton.Instance.UserId);
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productCategoryToolStripMenuItem_Click_1(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeProductCategorySearch");

                var mdiChild = new CrudeProductCategorySearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Guid.Empty, Guid.Empty, Singleton.Instance.UserId);
            } catch ( Exception ex ) {
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
                mdiChild.Show( string.Empty , Guid.Empty, Singleton.Instance.UserId );
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productPreviewToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("ProductPreview");

                var mdiChild = new ProductPreview();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void productWhiteboardToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("ProductWhiteboard");

                var mdiChild = new ProductWhiteboard();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void orderToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened ( "CrudeFinancialOrderSearch" );

                var mdiChild = new CrudeFinancialOrderSearch ();
                CheckForm ( mdiChild );
                mdiChild.MdiParent = this;
                mdiChild.Show (Singleton.Instance.UserId);
            } catch ( Exception ex ) {
                Error ( ex );
            }
            Cursor.Current = Cursors.Default;
        }

        private void cartToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened ( "CrudeCartProductSearch" );

                var mdiChild = new CrudeCartProductSearch ();
                CheckForm ( mdiChild );
                mdiChild.MdiParent = this;
                mdiChild.Show (Guid.Empty, Guid.Empty , Guid.Empty , Singleton.Instance.UserId );
            } catch ( Exception ex ) {
                Error ( ex );
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
