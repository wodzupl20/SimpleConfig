using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleConfig.Common;

namespace SimpleConfig.Tests
{
    /// <summary>
    /// Test for file save config
    /// </summary>
    [TestClass]
    public class InitTest
    {
        /// <summary>
        /// Check if interfase is not null and are same
        /// </summary>
        [TestMethod]
        public void Init()
        {
            Assert.IsNotNull(SimpleConfig.Init(),"SimpleConfig.Init() != null library returns interface");
            Assert.AreEqual(SimpleConfig.Init(), SimpleConfig.Init(), "Interfaces are not the same");
        }
        /// <summary>
        /// Test type of file on init should be file and init app data else NONE
        /// </summary>
        [TestMethod]
        public void SourFromFile()
        {
            Assert.IsTrue(SimpleConfig.Init().TypeOfConfig == SourceType.File, "Init source should be file");
        }
    }
}
