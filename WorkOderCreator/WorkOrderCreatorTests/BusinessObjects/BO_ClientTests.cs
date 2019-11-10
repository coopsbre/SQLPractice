using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using WorkOrderCreator.ReturnObject;

namespace WorkOrderCreator.BusinessObjects.Tests
{
    [TestClass()]
    public class BO_ClientTests
    {
        public BO_Client bO_Client = new BO_Client();

        [TestMethod()]
        public void Find_WhenClient_Exists_Test()
        {
            string expected = "1 Client Found.";
            string actual = string.Empty;
            DataValidatorReturn dvr = bO_Client.Find("IBV");
            actual = dvr.ReturnText;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void Find_WhenClient_DoesntExist_Test()
        {
            string expected = "ZZL Not Found.";
            string actual = string.Empty;

            DataValidatorReturn dvr = bO_Client.Find("ZZL");
            actual = dvr.ReturnText;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void Find_When_No_Client_Given_Test()
        {
            string expected = "No ClientCode given.";
            string actual = string.Empty;

            DataValidatorReturn dvr = bO_Client.Find("");
            actual = dvr.ReturnText;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void Create_When_No_Client_Given_Test()
        {
            string expected = "No ClientCode given.";
            string actual = string.Empty;

            DataValidatorReturn dvr = bO_Client.Create("", "");
            actual = dvr.ReturnText;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Create_When_No_Folder_Given_Test()
        {
            string expected = "No ClientFolder given.";
            string actual = string.Empty;

            DataValidatorReturn dvr = bO_Client.Create("ABC", "");
            actual = dvr.ReturnText;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Create_When_ClientAlreadyExists_Test()
        {
            string expected = "IBV already exists.";
            string actual = string.Empty;

            DataValidatorReturn dvr = bO_Client.Create("IBV", "a");
            actual = dvr.ReturnText;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void Create_When_NoClientFolderExists_Test()
        {
            string expected = "a does not exist.";
            string actual = string.Empty;

            DataValidatorReturn dvr = bO_Client.Create("ZZF", "a");
            actual = dvr.ReturnText;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void DeleteTest()
        {
            string expected = "";
            string actual = string.Empty;

            DataValidatorReturn dvr = bO_Client.Delete("IBV");
            actual = dvr.ReturnText;
            Assert.AreEqual(expected, actual);


        }

        [TestMethod()]
        public void Delete_With_Empty_ClientCode_Test()
        {
            string expected = "No ClientCode given.";
            string actual = string.Empty;

            DataValidatorReturn dvr = bO_Client.Delete("");
            actual = dvr.ReturnText;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Delete_With_Invalid_ClientCode_Test()
        {
            string expected = "IBV not found.";
            string actual = string.Empty;

            DataValidatorReturn dvr = bO_Client.Delete("IBV");
            actual = dvr.ReturnText;
            Assert.AreEqual(expected, actual);
        }
    }
}