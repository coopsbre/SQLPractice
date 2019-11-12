using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkOrderCreator.ReturnObject;

namespace WorkOrderCreator.BusinessObjects.Tests
{
    [TestClass()]
    public class BO_SourceScriptHdrTests
    {
        [TestMethod()]
        public void FindTest()
        {
            string actual = "1 Source Script Headers Found.";
            string expected = string.Empty;

            BO_SourceScriptHdr bo_SourceScriptHdr = new BO_SourceScriptHdr();
            DataValidatorReturn dvr = bo_SourceScriptHdr.Find(2);

            expected = dvr.ReturnText;

            Assert.AreEqual(expected, actual);
        }
    }
}