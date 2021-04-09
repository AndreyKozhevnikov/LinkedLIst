using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInkedList.Classes {
    [DebuggerDisplay("{Data}")]
    public class Node {
        public Node(string _data) {
            Data = _data;
        }

        public string Data{ get; set; }
        public Node NextNode{ get; set; }
    }
}
