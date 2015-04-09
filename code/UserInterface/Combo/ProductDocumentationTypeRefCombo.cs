using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class ProductDocumentationTypeRefCombo : UserControl {
        
        public ProductDocumentationTypeRefCombo() {
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
                CrudeProductDocumentationTypeRefService productDocumentationTypeRef = null;

                try {
                    productDocumentationTypeRef = new CrudeProductDocumentationTypeRefService();
                    CrudeProductDocumentationTypeRefContract[] contracts = productDocumentationTypeRef.FetchAll();

                    cboRef.DataSource = contracts;
                    cboRef.DisplayMember = "ProductDocumentationTypeName";
                    cboRef.ValueMember = "ProductDocumentationTypeRcd";
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {
                    if (productDocumentationTypeRef != null) productDocumentationTypeRef.Close();
                }
            }
        }
    }
}
