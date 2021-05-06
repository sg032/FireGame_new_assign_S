using Microsoft.VisualStudio.TestTools.UnitTesting;
using FireGame_new_assign_S;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGame_new_assign_S.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            fireSetting fireSetting = new fireSetting();
            if (fireSetting.set() != 3)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod()]
        public void Form2Test()
        {
            fireSetting fireSetting = new fireSetting();
            if (fireSetting.setup() != 3)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}