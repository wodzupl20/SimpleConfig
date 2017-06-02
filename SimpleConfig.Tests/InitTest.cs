using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        public void SoureFromFile()
        {
            
        }
    }
}
