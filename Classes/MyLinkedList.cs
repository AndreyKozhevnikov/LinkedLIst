using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInkedList.Classes {
    public class MyLinkedList {
        public Node Head{ get; set; }
        public void AddNode(string data) {
            var _node = new Node(data);
            if(Head != null) {
                _node.NextNode = Head;
            }
            Head = _node;

        }
    }
}
