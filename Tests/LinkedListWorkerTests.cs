using LInkedList.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInkedList.Tests {
    [TestFixture]
    class LinkedListWorkerTests {
        MyLinkedList PrepareList() {
            var list = new MyLinkedList();
            list.AddNode("3");
            list.AddNode("4");
            list.AddNode("5");
            return list;
        }
        [Test]
        public void ReverseList() {
            //arrange
            var list = PrepareList();
            var worker = new LinkedListWorker();
            //act
            worker.ReverseList(list);
            var res = worker.GetString(list);
            //assert
            Assert.AreEqual("3-4-5", res);
        }
        [Test]
        public void ReverseList_null() {
            //arrange
            var list = new MyLinkedList();
            var worker = new LinkedListWorker();
            //act
            worker.ReverseList(list);
            var res = worker.GetString(list);
            //assert
            Assert.AreEqual(null, res);
        }
        [Test]
        public void ReverseList_1() {
            //arrange
            var list = new MyLinkedList();
            list.AddNode("4");
            var worker = new LinkedListWorker();
            //act
            worker.ReverseList(list);
            var res = worker.GetString(list);
            //assert
            Assert.AreEqual("4", res);
        }

        [Test]
        public void ReverseListRecursive() {
            //arrange
            var list = PrepareList();
            var worker = new LinkedListWorker();
            //act
            worker.ReverseListRecursive(list);
            var res = worker.GetString(list);
            //assert
            Assert.AreEqual("3-4-5", res);
        }
        [Test]
        public void ReverseListRecursive_simple() {
            //arrange
            var list = new MyLinkedList();
            list.AddNode("3");
            list.AddNode("4");
            var worker = new LinkedListWorker();
            //act
            worker.ReverseListRecursive(list);
            var res = worker.GetString(list);
            //assert
            Assert.AreEqual("3-4", res);
        }
        [Test]
        public void ReverseListRecursive_null() {
            //arrange
            var list = new MyLinkedList();
            var worker = new LinkedListWorker();
            //act
            worker.ReverseListRecursive(list);
            var res = worker.GetString(list);
            //assert
            Assert.AreEqual(null, res);
        }
        [Test]
        public void ReverseListRecursive_1() {
            //arrange
            var list = new MyLinkedList();
            list.AddNode("4");
            var worker = new LinkedListWorker();
            //act
            worker.ReverseListRecursive(list);
            var res = worker.GetString(list);
            //assert
            Assert.AreEqual("4", res);
        }

        [Test]
        public void GetString() {
            //arrange
            var list = PrepareList();


            var worker = new LinkedListWorker();
            //act
            var st = worker.GetString(list);

            //assert
            Assert.AreEqual("5-4-3", st);
        }
        [Test]
        public void GetString_1() {
            //arrange
            var list = new MyLinkedList();
            list.AddNode("3");


            var worker = new LinkedListWorker();
            //act
            var st = worker.GetString(list);

            //assert
            Assert.AreEqual("3", st);
        }
        [Test]
        public void GetString_null() {
            //arrange
            var list = new MyLinkedList();


            var worker = new LinkedListWorker();
            //act
            var st = worker.GetString(list);

            //assert
            Assert.AreEqual(null, st);


        }
    }
}
