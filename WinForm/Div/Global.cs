using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace SolutionNorSolutionPim.ProxyLayer { }
namespace SolutionNorSolutionPim.UserInterface {
    public sealed class Singleton {
        private static Singleton _instance = null;
        private static readonly object _padlock = new object();

        public List<CrudeDefaultSystemSettingContract> _systemSettings { get; set; }

        private Login _login;

        public Guid UserId { get; set; }

        public Guid FinancialCurrencyId { get; set; }

        public void LoginShow(Main parent) {
            _login = new Login(parent);
            _login.MdiParent = parent;
            _login.Show();
        }

        public void Log(string message) {
            _login.Log(message);
        }

        public void LogToTop() {
            _login.Focus();
            Application.DoEvents();
        }

        public void Error(string caller, Exception ex) {
            try {
                Log("Exception in " + caller + ": outer: " + ex.Message);
                if (ex.InnerException != null) {
                    Log("Exception in " + caller + ": inner: " + ex.InnerException.Message);
                }
            } catch { }
        }

        public void Error(Exception ex) {
            try {
                Log("Exception: " + ex.Message);
                if (ex.InnerException != null) {
                    Log("Exception inner: " + ex.InnerException.Message);
                }
            } catch { }
        }

        public string SystemSetting(string systemSettingRcd) {
            try {
                foreach (CrudeDefaultSystemSettingContract setting in _systemSettings) {
                    if (setting.DefaultSystemSettingRcd == systemSettingRcd) {
                        return setting.DefaultSystemSettingValue;
                    }
                }
            } catch { }

            return string.Empty;
        }

        public void RefreshSystemSettings() {
            // get system setting
            try {
                CrudeDefaultSystemSettingServiceClient setting = new CrudeDefaultSystemSettingServiceClient();
                _systemSettings = setting.FetchAll();
            } catch { }

            // get default currency
            //string defaultCurrency = SystemSetting(DefaultC.BookingCurrency);
            //CrudeFinancialCurrencyContract crudeFinancialCurrencyContract = 
            //    new CrudeFinancialCurrencyServiceClient().
            //        FetchByFinancialCurrencyTypeCode(defaultCurrency);

            //if ( crudeFinancialCurrencyContract != null ) {
            //    FinancialCurrencyId = crudeFinancialCurrencyContract.FinancialCurrencyId;
            //}
        }

        private Singleton() { }

        public static Singleton Instance {
            get {
                lock (_padlock) {
                    if (_instance == null) {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }

        public void CheckForm(Form client) {
            //if ( SystemSetting(DefaultSystemSettingRef.DarkColorScheme) == "1" ) {
            //    client.BackColor = System.Drawing.Color.DimGray;
            //    client.ForeColor = System.Drawing.Color.WhiteSmoke;
            //    TraverseControls(client.Controls);
            //}
        }

        private void TraverseControls(Control.ControlCollection controls) {
            foreach (Control control in controls) {
                switch (control.GetType().ToString()) {
                    case "System.Windows.Forms.TextBox":
                        control.BackColor = Color.DimGray;
                        control.ForeColor = Color.WhiteSmoke;
                        TextBox tb = (TextBox)control;
                        break;
                    case "System.Windows.Forms.Label":
                        control.BackColor = Color.DimGray;
                        control.ForeColor = Color.WhiteSmoke;
                        break;
                    case "System.Windows.Forms.DataGridView":
                        control.BackColor = Color.DimGray;
                        control.ForeColor = Color.WhiteSmoke;
                        DataGridView dgv = (DataGridView)control;
                        dgv.DefaultCellStyle.BackColor = Color.DimGray;
                        dgv.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;
                        dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.WhiteSmoke;
                        dgv.BorderStyle = BorderStyle.None;
                        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray;
                        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
                        dgv.DefaultCellStyle.SelectionBackColor = Color.Black;
                        dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                        dgv.EnableHeadersVisualStyles = false;
                        dgv.RowHeadersVisible = false;
                        break;
                    case "System.Windows.Forms.Button":
                        control.ForeColor = Color.DimGray;
                        break;
                    case "System.Windows.Forms.TabPage":
                        control.BackColor = Color.DimGray;
                        control.ForeColor = Color.WhiteSmoke;
                        TabPage tp = (TabPage)control;
                        tp.BorderStyle = BorderStyle.None;
                        break;
                    case "System.Windows.Forms.DateTimePicker":
                        control.ForeColor = Color.WhiteSmoke;
                        DateTimePicker dtp = (DateTimePicker)control;
                        dtp.CalendarMonthBackground = Color.DimGray;
                        break;
                    case "System.Windows.Forms.TabControl":
                        control.BackColor = Color.DimGray;
                        control.ForeColor = Color.WhiteSmoke;
                        TabControl tc = (TabControl)control;
                        break;
                    default:
                        control.BackColor = Color.DimGray;
                        control.ForeColor = Color.WhiteSmoke;
                        break;
                }
                TraverseControls(control.Controls);
            }
        }

    }
}
