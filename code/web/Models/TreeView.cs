using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCJsTree.Models
{
    public class TreeView
    {
        public TreeView()
        {
            this.Nodes = new List<TreeNode>();
        }

        public List<TreeNode> Nodes { get; set; }
    }
}