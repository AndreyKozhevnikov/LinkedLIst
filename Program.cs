using LInkedList.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInkedList {
    class Program {
        static void Main(string[] args) {
            var list = new MyLinkedList();
            list.AddNode("3");
            list.AddNode("4");
            list.AddNode("5");
            var worker = new LinkedListWorker();
            worker.PrintLinkedList(list);
            worker.ReverseList(list);
            worker.PrintLinkedList(list);
            Console.ReadLine();
        }

       
    }
}
