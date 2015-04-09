using norpim.BusinessLogicLayer;
using System;
using System.Text;
using System.Windows.Forms;

namespace norpim.UserInterface {

    public partial class Engine : Form {
        private Guid _userId;

        public Engine() {
            InitializeComponent();
        }

        public void Show(Guid userId) {
            _userId = userId;

            base.Show();
        }

        private void buttonGather_Click(object sender, EventArgs e) {
            // start the gather service
            var gather = new norpim.BusinessLogicLayer.Other.GatherServiceClient();

            try { 
                gather.Start(_userId);
            } catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            } finally {
                gather.Close();
            }
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

        private void buttonTest_Click(object sender, EventArgs e) {
            // clean slate
            var categoryServiceClient = new norpim.BusinessLogicLayer.Other.ProductCategoryServiceClient();

            if (MessageBox.Show("Are you sure?", 
                                "All categories will disappear", 
                                MessageBoxButtons.YesNo
                                ) == System.Windows.Forms.DialogResult.No) 
                return;

            try {
                categoryServiceClient.CleanSlate(   Singleton.Instance.UserId
                                                    );

                Log("Categories invalidated");

                // add categories ( note, using default system owner here, not the newly created one )
                var productCategoryServiceClient = new norpim.BusinessLogicLayer.Other.ProductCategoryServiceClient();
                var productServiceClient = new norpim.BusinessLogicLayer.Other.ProductServiceClient();
                var productIdentifierServiceClient = new CrudeProductIdentifierService();
    
                for (int countMain = 1; countMain < 5; countMain++) {
                    Guid categoryMainId = 
                        productCategoryServiceClient.ProductCategoryAdd(
                            "mc" + countMain.ToString(),
                            countMain.ToString() + " " + FakeLatin(5 + countMain),
                            Guid.Empty,
                            countMain,
                            _userId
                            );
                    
                    Log("main cat: " + countMain.ToString());

                    for (int countSub = 1; countSub < 10; countSub++) {
                        Guid productCategorySubId = 
                            productCategoryServiceClient.ProductCategoryAdd(
                                "sc" + countMain.ToString() + "_" + countSub.ToString(),
                                countMain.ToString() + countSub.ToString() + " > " + FakeLatin(countSub + 3),
                                categoryMainId,
                                countMain,
                                _userId
                                );

                        Log("sub cat: " + countSub.ToString());

                        // add products
                        for (int countProduct = 1; countProduct < 5; countProduct++) {
                            Guid productId = productServiceClient.ProductAdd(
                                    productCategorySubId,
                                    "product.. " + countMain.ToString() 
                                                 + countSub.ToString() 
                                                 + countProduct.ToString(),
                                    _userId
                                    );
                            
                            // add identifier
                            var productIdentifierContract = new CrudeProductIdentifierContract();

                            productIdentifierContract.ProductIdentifierId = Guid.NewGuid();
                            productIdentifierContract.ProductId = productId;
                            productIdentifierContract.ProductIdentifierRcd = ProductIdentifierRef.HN;

                            productIdentifierContract.Identifier = "6 " + countMain.ToString() 
                                                                 + countSub.ToString() 
                                                                 + countProduct.ToString();

                            productIdentifierContract.DateTime = DateTime.UtcNow;
                            productIdentifierContract.UserId = _userId;
                            productIdentifierServiceClient.Insert(productIdentifierContract);
                        }
                    }
                }

                productIdentifierServiceClient.Close();
                productServiceClient.Close();
                productCategoryServiceClient.Close();

                // fetch products for category
                // expose
            } catch (Exception ex) {
                Error(ex);
            } finally {
                categoryServiceClient.Close();
            }
        }

        private string FakeLatin(int wordCount) {
            string[] dictionary = "lorem ipsum dolor sit amet consectetuer adipiscing elit sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat ut wisi enim ad minim veniam quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi Ut wisi enim ad minim veniam quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi".Split(' ');
            StringBuilder words = new StringBuilder();
            Random rand = null;
            string paragraph = string.Empty;
 
            rand = new Random(DateTime.Now.Millisecond);
 
            for (int n = 0; n < wordCount; n++)
                words.AppendFormat("{0} ", dictionary[rand.Next(0, dictionary.Length)]);
 
            paragraph = words.ToString();
            paragraph = string.Format("{0}{1}.", char.ToUpperInvariant(paragraph[0]), paragraph.Substring(1).TrimEnd());
 
            return paragraph;
        }

    }
}
