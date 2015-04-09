using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCJsTree.Models
{
    public class ListItem : INodeItem
    {
        public string Id { get; set; }
        public string Parent { get; set; }
        public string Class { get; set; }
        public string Text { get; set; }
        public ListItemAHref Href { get; set; }
        public DataJsTree DataJsTree { get; set; }
        public List<INodeItem> Nodes { get; set; }
      
        public ListItem(string text,
                        string id = "",
                        string parent = "#",
                        string className ="",
                        ListItemAHref ahref = null,
                        DataJsTree dataJsTree=null)
        {
            if (id != null)
                this.Id = id;

            this.Parent = parent;
            this.Text = text;
            this.Class = className;

            if (ahref != null)
                this.Href = ahref;
            else
                this.Href = new ListItemAHref();

            if (dataJsTree != null)
                this.DataJsTree = dataJsTree;
            else
                this.DataJsTree = new DataJsTree();

            Nodes = new List<INodeItem>();
        }
    }
}