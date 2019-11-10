using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WorkOrderCreator.ReturnObject;

namespace WorkOrderCreator.BusinessObjects.Tests
{
    [TestClass()]
    public class BO_WorkOrderHeaderTests
    {
        BO_WorkOrderHeader bo = new BO_WorkOrderHeader();
        DataValidatorReturn dvr = new DataValidatorReturn();

        [TestMethod()]
        public void Find_Zero_Work_Order_Number_Test()
        {
            string expected = "Zero Value for Parameter Name: Work Order Number.";
            string actual = "";

            dvr = bo.Find(0);
            actual = dvr.ReturnText;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Find_Invalid_Work_Order_Number_Test()
        {
            string expected = "Work Order Not Found.";
            string actual = "";

            dvr = bo.Find(1);
            actual = dvr.ReturnText;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Find_Valid_Work_Order_Number_Test()
        {
            string expected = "1 Work Order Found.";
            string actual = "";

            dvr = bo.Find(1);
            actual = dvr.ReturnText;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Create_Valid_Work_Order_Test()
        {
            string expected = "Work Order #5 Added to the Database.";
            string actual = "";

            dvr = bo.Create(5, "CBE");
            actual = dvr.ReturnText;

            Assert.AreEqual(expected, actual);
        }
    }
}