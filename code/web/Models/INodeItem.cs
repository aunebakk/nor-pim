using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCJsTree.Models
{
    public interface INodeItem
    {
        List<INodeItem> Nodes { get; set; }
    }
}
