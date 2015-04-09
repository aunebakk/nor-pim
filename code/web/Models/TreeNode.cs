using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCJsTree.Models
{
    public class TreeNode
    {
        public TreeNode()
        {
            ListItems = new List<INodeItem>();
        }

        public List<INodeItem> ListItems { get; set; }
    }
}