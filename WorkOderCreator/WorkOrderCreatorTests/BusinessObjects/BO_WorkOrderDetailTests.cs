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
    public class BO_WorkOrderDetailTests
    {
        DataValidatorReturn dvr = new DataValidatorReturn();
        BO_WorkOrderDetail bo_WorkOrderDetail = new BO_WorkOrderDetail();

        [TestMethod()]
        public void FindTest()
        {
            string expected = "1 Work Order Details Found.";
            string actual = "";

            dvr = bo_WorkOrderDetail.Find(1, 1, 1);
            actual = dvr.ReturnText;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CreateTest()
        {
            string expected = "1 Work Order Details Found.";
            string actual = "";

            dvr = bo_WorkOrderDetail.Create(1,2,3);
            actual = dvr.ReturnText;

            Assert.AreEqual(expected, actual);
        }
    }
}