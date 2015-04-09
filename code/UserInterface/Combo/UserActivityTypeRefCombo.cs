using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class UserActivityTypeRefCombo : UserControl {
        
        public UserActivityTypeRefCombo() {
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
                CrudeUserActivityTypeRefService userActivityTypeRef = null;

                try {
                    userActivityTypeRef = new CrudeUserActivityTypeRefService();
                    CrudeUserActivityTypeRefContract[] contracts = userActivityTypeRef.FetchAll();

                    cboRef.DataSource = contracts;
                    cboRef.DisplayMember = "UserActivityTypeName";
                    cboRef.ValueMember = "UserActivityTypeRcd";
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {
                    if (userActivityTypeRef != null) userActivityTypeRef.Close();
                }
            }
        }
    }
}
