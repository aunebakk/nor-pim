using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class SystemSettingRefCombo : UserControl {
        
        public SystemSettingRefCombo() {
           InitializeComponent();
        }
        
        public override String Text {
            get {
                if (cboRef.SelectedValue != null)
                    return cboRef.SelectedValue.ToString();
                else
                    return string.Empty;
            }
            set {
                PopulateCombo();
                cboRef.SelectedValue = value;;
            }
        }
        
        private void cboRef_Click(object sender, EventArgs e) {
            PopulateCombo();
        }
        
        private void PopulateCombo() {
            if (!DesignMode && cboRef.DataSource == null) {
                CrudeSystemSettingRefService systemSettingRef = null;

                try {
                    systemSettingRef = new CrudeSystemSettingRefService();
                    CrudeSystemSettingRefContract[] contracts = systemSettingRef.FetchAll();

                    cboRef.DataSource = contracts;
                    cboRef.DisplayMember = "SystemSettingName";
                    cboRef.ValueMember = "SystemSettingRcd";
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {
                    if (systemSettingRef != null) systemSettingRef.Close();
                }
            }
        }
    }
}
