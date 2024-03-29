﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd.Tests
{
    [TestClass()]
    public class YipYopTests
    {
        YipYop yipyop = new YipYop();

        [TestMethod()]
        public void ConfirmGenerateReturn1()
        {
            Assert.AreEqual("1", yipyop.generate(1, 1), "ko pour 1");
        }
        [TestMethod()]
        public void ConfirmGenerateReturn2()
        {
            Assert.AreEqual("2", yipyop.generate(2 , 2), "ko pour 2");
        }

        [TestMethod()]
        public void ConfirmGenerateReturn3()
        {
            Assert.AreEqual("yop", yipyop.generate(3,3), "ko pour 3");
        }
        [TestMethod()]
        public void ConfirmGenerateReturn5()
        {
            Assert.AreEqual("yip", yipyop.generate(5,5), "ko pour 5");
        }
        [TestMethod()]
        public void ConfirmGenerateReturn6()
        {
            Assert.AreEqual("yop", yipyop.generate(6,6), "ko pour 6");
        }
        [TestMethod()]
        public void ConfirmGenerateReturn10()
        {
            Assert.AreEqual("yip", yipyop.generate(10,10), "ko pour 10");
        }
        [TestMethod()]
        public void ConfirmGenerateReturn15()
        {
            Assert.AreEqual("yipyop", yipyop.generate(15,15), "ko pour 15");
        }
        [TestMethod()]
        public void ConfirmGenerateReturn12()
        {
            Assert.AreEqual("12", yipyop.generate(1, 2), "ko pour 1-2");
        }
        [TestMethod()]
        public void ConfirmGenerateReturn12yop()
        {
            Assert.AreEqual("12yop", yipyop.generate(1, 3), "ko pour 1-2-yop");
        }

    }
}