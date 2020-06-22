using NUnit.Framework;
using System;
using System.IO;

namespace Test_HelloWorld
{
    public class Tests
    {


        [SetUp]
        public void Setup()
        {
            HelloWorldUserEB.Program.keyPressed = ConsoleKey.Enter;
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test_HelloWorld()
        {
            string expected = "Hello World!";
            var sw = new StringWriter();
            Console.SetOut(sw);
            HelloWorldUserEB.Program.Main();

            var result = sw.ToString().Trim();
            Assert.AreEqual(expected, result);
            // citation: https://docs.google.com/document/d/1n6xVp-L6HJCccjl3KqCAkLAqnWtxM6AXj2PSPkZ0JTQ/edit#
            // Used this pre-written unit test code to help speed the work process 
        }
    }
}
