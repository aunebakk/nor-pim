using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCJsTree.Models
{
    public class DataJsTree
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public bool Opened { get; set; }
        public bool Selected { get; set; }
        public bool Disabled { get; set; }
    }
}