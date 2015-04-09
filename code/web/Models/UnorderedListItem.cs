using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCJsTree.Models
{
    /// <summary>
    /// We don't use this one as of now. It's a placeholder for future development.
    /// </summary>
    public class UnorderedListItem: INodeItem
    {
        public string Id { get; set; }
        public string Class { get; set; }
        public string Name { get; set; }

        public UnorderedListItem()
        {
            Nodes = new List<INodeItem>();
        }

        public List<INodeItem> Nodes { get; set; }
    }
}