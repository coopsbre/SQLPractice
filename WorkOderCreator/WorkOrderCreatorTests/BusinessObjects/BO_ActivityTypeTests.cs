using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkOrderCreator.ReturnObject;

namespace WorkOrderCreator.BusinessObjects.Tests
{
    [TestClass()]
    public class BO_ActivityTypeTests
    {
        BO_ActivityType bO_ActivityType = new BO_ActivityType();

        [TestMethod()]
        public void FindTest()
        {
            string expected = "1 Activity Type Found.";
            string actual = string.Empty;

            DataValidatorReturn dvr = bO_ActivityType.Find("CLAIM");

            actual = dvr.ReturnText;

            Assert.AreEqual(expected, actual);
        }
    }
}