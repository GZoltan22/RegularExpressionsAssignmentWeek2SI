using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpressions.Tests
{
    [TestClass()]
    public class ValidationTests
    {
        [TestMethod()]
        public void phoneNumberValidationTest()
        {
            string name = "Gathy";
            Validation v = new Validation();

            
            Assert.AreEqual(true, v.phoneNumberValidation(name));
        }
    }
}