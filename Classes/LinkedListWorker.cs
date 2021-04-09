using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInkedList.Classes {
    public class LinkedListWorker {
        public void PrintLinkedList(MyLinkedList list) {
            var node = list.Head;
            while(node != null) {
                Console.WriteLine(node.Data);
                node = node.NextNode;
            }
        }
        public string GetString(MyLinkedList list) {
            List<string> res = new List<string>();
            var currentNode = list.Head;

            while(currentNode != null) {
                res.Add(currentNode.Data);
                currentNode = currentNode.NextNode;
            }
            if(res.Count == 0) {
                return null;
            }
            var st = string.Join("-", res);
            return st;
        }
        public void ReverseList(MyLinkedList list) {
            Node tempNextNode = null;
            Node currentNode = list.Head;
            while(currentNode != null) {
                var tmp = currentNode.NextNode;
                currentNode.NextNode = tempNextNode;
                tempNextNode = currentNode;
                currentNode = tmp;
            }
            list.Head = tempNextNode;
        }

        public void ReverseListRecursive(MyLinkedList list) {
            list.Head = RecursiveCore(list.Head);
        }
        Node RecursiveCore(Node firstNode) {
            if(firstNode == null || firstNode.NextNode == null) {
                return firstNode;
            }
            var rest = RecursiveCore(firstNode.NextNode);
            firstNode.NextNode.NextNode = firstNode;
            firstNode.NextNode = null;
            return rest;
        }
    }
}
