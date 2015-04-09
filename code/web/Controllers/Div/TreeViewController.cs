using MVCJsTree.Models;
using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace MVCJsTree.Controllers {
    public class TreeViewController : Controller {

        void AddCategory(   CrudeProductCategoryContract[] productCategoryContracts,
                            ListItem node,
                            Guid productCategoryParentId
                            ) {
            foreach (CrudeProductCategoryContract contractChild in productCategoryContracts) {
                // exclude parent
                if (contractChild.ProductCategoryId == contractChild.ProductCategoryParentId)
                    continue;

                if (contractChild.ProductCategoryParentId == productCategoryParentId) {
                    ListItem newNode = 
                        new ListItem(   contractChild.ProductCategoryName, 
                                        contractChild.ProductCategoryId.ToString()
                                        );
                    node.Nodes.Add(newNode);

                    AddCategory(productCategoryContracts,
                                newNode,
                                contractChild.ProductCategoryId
                                );
                }
            }
        }

        public ActionResult Index() {

            var productCategory = new norpim.BusinessLogicLayer.CrudeProductCategoryService();

            var treeView = new TreeView();

            var treeNode = new TreeNode();
            var rootNode = new ListItem("Root node 1", "node1");

            var dataJsTree = new DataJsTree();
            dataJsTree.Icon = "glyphicon glyphicon-leaf";
            dataJsTree.Opened = false;

            try { 
                //CrudeProductCategoryContract[] productCategoryContracts = productCategory.FetchBySystemOwnerId(_systemOwnerId);
                
                CrudeProductCategoryContract[] productCategoryContracts = productCategory.FetchAll();

                foreach (norpim.BusinessLogicLayer.CrudeProductCategoryContract productCategoryContract in productCategoryContracts) {
                    // first level is it's own parent
                    if (productCategoryContract.ProductCategoryId != productCategoryContract.ProductCategoryParentId)
                        continue;

                    var firstLevel = 
                        new ListItem(
                            productCategoryContract.ProductCategoryName, 
                            productCategoryContract.ProductCategoryName + "Node", 
                            className: "jstree-closed", 
                            dataJsTree: dataJsTree
                            );
                    rootNode.Nodes.Add(firstLevel);

                    AddCategory(    productCategoryContracts,
                                    firstLevel,
                                    productCategoryContract.ProductCategoryId
                                    );
                }
                
            } catch {
                // error handling?
            } finally {
                productCategory.Close();
            }

            treeNode.ListItems.Add(rootNode);
            treeView.Nodes.Add(treeNode);

            return View(treeView);
        }

        public ActionResult Index2() {
            var productSearchByName = new norpim.BusinessLogicLayer.ProductSearchService();
            norpim.BusinessLogicLayer.ProductSearchByNameContract[] contract = null;

            try { 
                contract = productSearchByName.ProductSearchByName("666"); // ViewBag.TextArea1);
                ViewBag.TextArea1 = contract[0].ProductName;
            } catch (Exception ex) {
                ViewBag.TextArea1 = ex.Message;
            } finally {
                productSearchByName.Close();
            }

            var treeView = new TreeView();

            var treeNode = new TreeNode();
            var rootNode = new ListItem("Root node 1", "node1");

            var dataJsTree = new DataJsTree();
            dataJsTree.Icon = "glyphicon glyphicon-leaf";
            dataJsTree.Opened = true;

            var fruitNode = new ListItem("Fruits", "fruitsNode", className: "jstree-open", dataJsTree: dataJsTree);
            var vegetableNode = new ListItem("Vegetables", "vegetablesNode", className: "");
            var appleNode = new ListItem("Apples", "applesNode", className: "");
            var broccoliNode = new ListItem("Broccoli", "broccoliNode", className: "");
            var carrotNode = new ListItem("Carrots", "carrotNode", className: "");
            var lettuceNode = new ListItem("Lettuces", "lettuceNode", className: "");
            var romaineNode = new ListItem("Romaine", "romaineNode", className: "");
            var iceBurgNode = new ListItem("IceBurg", "iceBurgNode", className: "");
            var butterheadNode = new ListItem("Butterhead", "butterheadNode", className: "");

            //fruitNode.Nodes.Add(new ListItem("Oranges", "orange"));
            fruitNode.Nodes.Add(new ListItem(contract[0].ProductName, "orange"));
            fruitNode.Nodes.Add(new ListItem("Pineapples", "pineapple"));

            appleNode.Nodes.Add(new ListItem("Macintosh", "Macintosh"));

            fruitNode.Nodes.Add(appleNode);

            lettuceNode.Nodes.Add(romaineNode);
            lettuceNode.Nodes.Add(iceBurgNode);
            lettuceNode.Nodes.Add(butterheadNode);

            vegetableNode.Nodes.Add(broccoliNode);
            vegetableNode.Nodes.Add(carrotNode);
            vegetableNode.Nodes.Add(lettuceNode);

            rootNode.Nodes.Add(fruitNode);
            rootNode.Nodes.Add(vegetableNode);

            treeNode.ListItems.Add(rootNode);
            treeView.Nodes.Add(treeNode);
   
            return View(treeView);
        }
	}
}