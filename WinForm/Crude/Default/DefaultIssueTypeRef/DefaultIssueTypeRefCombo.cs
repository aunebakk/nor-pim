/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 4:25:07 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateComboStyle1
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.UserInterface {

    // this ComboBox UserControl class is used to consume Crude SOAP Services through a WCF Proxy Client
    public partial class DefaultIssueTypeRefCombo : UserControl {
        
        // Constructs the control with an empty ComboBox
        public DefaultIssueTypeRefCombo() {
           InitializeComponent();
        }
        
        // get or sets the current combobox row
        public override string Text {
            get {
                System.String selectedValue = String.Empty;
                try { 
                    selectedValue = cboRef.SelectedValue.ToString();
                } catch {}
                return selectedValue;
            }
            set {
                PopulateCombo();
                cboRef.SelectedValue = value;;
            }
        }
        
        // event for when a new item is selected in the ComboBox
        public event EventHandler Picked;
        
        // populates the ComboBox with all rows from the SOAP service
        private void cboRef_Click(object sender, EventArgs e) {
            PopulateCombo();
        }
        
        // trigger Picked event when selected row in the ComboBox changes
        private void cboRef_SelectedIndexChanged(object sender, EventArgs e) {
            if (cboRef.SelectedValue != null && this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        // fetch all rows from the SOAP layer and populate the ComboBox with it
        public void PopulateCombo() {
            if (!DesignMode && cboRef.DataSource == null) {
                CrudeDefaultIssueTypeRefServiceClient defaultIssueTypeRef = null;

                try {
                    defaultIssueTypeRef = new CrudeDefaultIssueTypeRefServiceClient();
                    List<CrudeDefaultIssueTypeRefContract> contracts = defaultIssueTypeRef.FetchAll();

                    cboRef.DataSource = contracts;
                    cboRef.DisplayMember = "DefaultIssueTypeName";
                    cboRef.ValueMember = "DefaultIssueTypeRcd";
                } catch (Exception ex) {
                    // MessageBox.Show(ex.Message);
                } finally {
                    if (defaultIssueTypeRef != null) defaultIssueTypeRef.Close();
                }
            }
        }
    }
}
