﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/22/2020 9:24:32 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductCategoryDocumentationTypeRefEdit : Form {
        
        private CrudeProductCategoryDocumentationTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeProductCategoryDocumentationTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductCategoryDocumentationTypeRefContract();
                _isNew = true;
                this.Text += " - Not Savable (User Missing)";
                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByRules(System.Guid userId) {
            try {
                _contract = new CrudeProductCategoryDocumentationTypeRefContract();
                _isNew = true;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(string productCategoryDocumentationTypeRcd, string productCategoryDocumentationTypeName, System.Guid userId) {
            try {
                _contract = new CrudeProductCategoryDocumentationTypeRefContract();
                _isNew = true;
                _contract.ProductCategoryDocumentationTypeRcd = productCategoryDocumentationTypeRcd;
                textBoxProductCategoryDocumentationType.Text = _contract.ProductCategoryDocumentationTypeRcd;
                _contract.ProductCategoryDocumentationTypeName = productCategoryDocumentationTypeName;
                textBoxProductCategoryDocumentationTypeName.Text = _contract.ProductCategoryDocumentationTypeName;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsEdit(string productCategoryDocumentationTypeRcd, System.Guid userId) {
            var service = new CrudeProductCategoryDocumentationTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductCategoryDocumentationTypeRcd(productCategoryDocumentationTypeRcd);
                textBoxProductCategoryDocumentationType.Text = _contract.ProductCategoryDocumentationTypeRcd;
                textBoxProductCategoryDocumentationTypeName.Text = _contract.ProductCategoryDocumentationTypeName;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                service.Close();
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeProductCategoryDocumentationTypeRefServiceClient();
            try {
                _contract.ProductCategoryDocumentationTypeRcd = textBoxProductCategoryDocumentationType.Text;
                _contract.ProductCategoryDocumentationTypeName = textBoxProductCategoryDocumentationTypeName.Text;

                if (_isNew)
                    service.Insert(_contract);
                else
                    service.Update(_contract);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                service.Close();
            }

            Close();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
