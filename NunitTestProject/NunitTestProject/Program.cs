using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace NunitTestProject
{
    
    public class Program
    {
        [Test]
            public void TestAddition()
            {
                int num1 = 5; int num2 = 3;
                int result = num1 + num2;
                Assert.AreEqual(8, result);
            }
            [Test]
            public void TestMultiplication() { int num1 = 5; int num2 = 3; int result = num1 * num2; Assert.AreEqual(15, result); }
            [Test]
            public void TestSubtaction() { int num1 = 5; int num2 = 2; int result = num1 - num2; Assert.AreEqual(3, result); }
        

        static void Main(string[] args)
        {
            
        }
    }
}
