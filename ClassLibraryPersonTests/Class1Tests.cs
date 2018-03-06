using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPerson.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod]
        public void AddTest()
        {
            Assert.AreEqual(9, Class1.Add(4, 5));

        }
    }
}