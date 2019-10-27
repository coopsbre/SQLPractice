using System;
using System.Collections.Generic;
using System.Linq;

namespace ClientProcesses
{
    public class BO_FileHdr
    {
        public DataValidatorReturn DVR = new DataValidatorReturn();
        public List<BO_FunctionalDescription> FunctionDescriptionList = new List<BO_FunctionalDescription>();

        public DataValidatorReturn Find(int workOrderNumber)
        {
            List<FileHdr> fileHdrList;

            try
            {
                using (var context = new WorkOrderLogEntities())
                {
                    fileHdrList = context.FileHdrs.Where(x => x.WOHdrID == workOrderNumber).ToList();
                }

                if (fileHdrList.Any())
                {
                    DVR.ReturnType = fileHdrList;
                    DVR.IsValid = true;
                    DVR.ReturnText = fileHdrList.Count().ToString() + " File Header's Found.";
                }
                else
                {
                    DVR.ReturnType = fileHdrList;
                    DVR.IsValid = false;
                    DVR.ReturnText = "Empty FileHdrList.";
                }
            }
            catch (Exception exception)
            {
                DVR.IsValid = false;
                DVR.ReturnText = exception.Message;
            }

            return DVR;
        }
    }
}
