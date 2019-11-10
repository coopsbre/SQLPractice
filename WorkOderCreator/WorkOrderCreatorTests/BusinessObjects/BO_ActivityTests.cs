using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkOrderCreator.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkOrderCreator.ReturnObject;

namespace WorkOrderCreator.BusinessObjects.Tests
{
    [TestClass()]
    public class BO_ActivityTests
    {
        public BO_Activity bO_Activity = new BO_Activity();
        public DataValidatorReturn dvr = new DataValidatorReturn();

        [TestMethod()]
        public void FindTest_By_ActivityID()
        {
            string expected = "1 Activity Found.";
            string actual = string.Empty;

            dvr = bO_Activity.Find(1);
            actual = dvr.ReturnText;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindTest_By_ActivityDescription()
        {
            string expected = "1 Activity Found.";
            string actual = string.Empty;

            dvr = bO_Activity.Find("Export Card To Westpac");
            actual = dvr.ReturnText;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Create_Empty_Activity_Test()
        {
            string expected = "Empty Parameter Name: Activity";
            string actual = "";

            dvr = bO_Activity.Create("", 2);
            actual = dvr.ReturnText;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void Create_Activity_With_Invalid_ActivityTypeID_Test()
        {
            string expected = "Activity Type Not Found.";
            string actual = "";

            dvr = bO_Activity.Create("This is a test", 300);
            actual = dvr.ReturnText;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void Create_New_Activity_Test()
        {
            string expected = "Activity: " + "Fred" + " Added to the Database.";
            string actual = "";

            dvr = bO_Activity.Create("Fred", 2);
            actual = dvr.ReturnText;

            Assert.AreEqual(expected, actual);

        }

    }
}