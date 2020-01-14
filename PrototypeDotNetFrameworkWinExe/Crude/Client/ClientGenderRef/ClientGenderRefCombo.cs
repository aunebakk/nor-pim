/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:58:17 PM
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

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ClientGenderRefCombo : UserControl {
        
        public ClientGenderRefCombo() {
           InitializeComponent();
        }
        
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
        
        public event EventHandler Picked;
        
        private void cboRef_Click(object sender, EventArgs e) {
            PopulateCombo();
        }
        
        private void cboRef_SelectedIndexChanged(object sender, EventArgs e) {
            if (cboRef.SelectedValue != null && this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void PopulateCombo() {
            if (!DesignMode && cboRef.DataSource == null) {
                CrudeClientGenderRefServiceClient clientGenderRef = null;

                try {
                    clientGenderRef = new CrudeClientGenderRefServiceClient();
                    List<CrudeClientGenderRefContract> contracts = clientGenderRef.FetchAll();

                    cboRef.DataSource = contracts;
                    cboRef.DisplayMember = "ClientGenderName";
                    cboRef.ValueMember = "ClientGenderRcd";
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {
                    if (clientGenderRef != null) clientGenderRef.Close();
                }
            }
        }
    }
}
