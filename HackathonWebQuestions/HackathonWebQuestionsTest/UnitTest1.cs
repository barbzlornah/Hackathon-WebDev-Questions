using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace HackathonWebQuestionsTest
{
    [TestClass]
    public class UnitTest1
    {
       
        public bool Is { get; private set; }
        public object A { get; private set; }
        public object B { get; private set; }
        public object C { get; private set; }
        public object D { get; private set; }
        public object LList { get; private set; }

        [TestMethod]
        public void TestMethod1()
        {
            LinkedList LList=new LinkedList();
        }

    [SetUp]
        public void init()
        {
            LinkedList LList = new LinkedList();
        }

        [Test]
        public void canAccessSizeOfLinkedList()
        {
            Assert.Equals(IList.getSize(), Is.Equals(0));
        }

        [Test]
        public void canInsertAtBeginningOfLinkedList()
        {
            LList.insert(A, B);
            Assert.Equals(LList[A], Is.Equals(1));
        }
        [Test]
        public void canDeleteFromBeginningofLinkedList()
        {
            LList.insert(A, B);
            LList.insert(B, C);
            LList.insert(C, D);
            LList.delete(0);
            Assert.Equals(LList.getSize(), Is.Equals(C));
            Assert.Equals(LList[A], Is.Equals(C));
        }

        [Test]
        public void canDeleteFromMiddleOfLinkedList()
        {
            LList.insert(A, B);
            LList.insert(B, C);
            LList.insert(C, D);
            LList.delete(B);
            Assert.Equals(LList.getSize(), Is.Equals(C));
            Assert.Equals(LList[B], Is.Equals(C));
        }

    }
}

