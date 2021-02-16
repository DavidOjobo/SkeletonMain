using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstQuality
    {
        [TestMethod]
        public void TInstanceOK()
        {
            //creates instance of class
            clsQuality QualityControl = new clsQuality();
            //tests to see if it exists
            Assert.IsNotNull(QualityControl);
        }
    }
}
