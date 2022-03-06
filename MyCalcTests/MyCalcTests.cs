using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyСalculatio;

namespace MyCalcTests
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void TestMethodTest()
        {
            //arrange 
            int x = 10; int y = 20; int expected = 30;
            //ast

            MyCalc c = new MyCalc(); 
            int actual = c.sum(x, y);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod1()
        {
            int a=1, b=4, x=3, c=2;
            int expected = 12;
            MyCalc m = new MyCalc();
            int actual = m.F(a,b,x,c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = 10, b = 4, x = 0, c = 2;
            int expected = 5;
            MyCalc m = new MyCalc();
            int actual = m.F(a, b, x, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int a = 1, b = 4, x = 3, c = 0;
            int expected = -12;
            MyCalc m = new MyCalc();
            int actual = m.F(a, b, x, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int a = 1, b = 4, x = 0, c = 0;
            int expected = 30;
            MyCalc m = new MyCalc();
            int actual = m.F(a, b, x, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int a = 0, b = 4, x = 0, c = 50;
            int expected = 30;
            MyCalc m = new MyCalc();
            int actual = m.F(a, b, x, c);
            Assert.AreEqual(expected, actual);
        }
    }
}
