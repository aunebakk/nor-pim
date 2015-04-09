using System;
using System.ComponentModel;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class ProductCategoryPicker : UserControl {
        
        private System.Guid _productCategoryId;
        
        public ProductCategoryPicker() {
           InitializeComponent();
        }
        
        public System.Guid SelectedValue {
            get {
                return _productCategoryId;
            }
            set {
                if (!DesignMode) {
                    _productCategoryId = value;
                    var productCategory = new CrudeProductCategoryService();
                    try {
                        CrudeProductCategoryContract contract = productCategory.FetchByProductCategoryId(_productCategoryId);
                        if (contract != null) {
                            txtProductCategoryName.Text = contract.ProductCategoryName;
                            txtProductCategoryCode.Text = contract.ProductCategoryCode;
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    } finally {
                        if (productCategory != null) productCategory.Close();
                    }
                };
            }
        }
        
        private void txtProductCategoryCode_Validating(object sender, CancelEventArgs e) {
            if (!DesignMode) {
                // empty picker on no code
                if (txtProductCategoryCode.Text == String.Empty) {
                    _productCategoryId = Guid.Empty;
                    txtProductCategoryName.Text = string.Empty;
                    txtProductCategoryCode.Text = string.Empty;
                    return;
                }

                CrudeProductCategoryService productCategory = null;

                try {
                    productCategory = new CrudeProductCategoryService();
                    CrudeProductCategoryContract contract = productCategory.FetchByProductCategoryCode(txtProductCategoryCode.Text);

                    if (contract != null) {
                        txtProductCategoryCode.Text = contract.ProductCategoryCode;
                        txtProductCategoryName.Text = contract.ProductCategoryName;
                        _productCategoryId = contract.ProductCategoryId;
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {
                    if (productCategory != null) productCategory.Close();
                }
            }
        }
    }
}
