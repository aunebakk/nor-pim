using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCJsTree.Models
{
    public class ListItemAHref
    {
        public string Href { get; set; }
        public string Class { get; set; }

        public ListItemAHref(string href="#", string cssClass = "")
        {
            this.Href = href;
            this.Class = cssClass;
        }
    }
}