using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ClientProcesses
{
    public class BO_WorkOrderHeader
    {
        public DataValidatorReturn DVR = new DataValidatorReturn();
        public List<BO_FunctionalDescription> FunctionDescriptionList = new List<BO_FunctionalDescription>(); 

        public DataValidatorReturn Create(string clientCode, string workOrderNumber)
        {
            try
            {
                using (var context = new WorkOrderLogEntities())
                {
                    WorkOrderHeader woh = new WorkOrderHeader();
                    woh.ClientCode = clientCode;
                    woh.WOHdrID = Convert.ToInt32(workOrderNumber);
                    woh.CreatedDate = System.DateTime.Now;
                    
                    TestPlanFile tpf = new TestPlanFile();

                    // Create a new folder under c:\screenshots\
                    tpf.FileName = "Test Plan " + workOrderNumber + ".txt";
                    var fileCreation = File.Create("c:\\Screenshots\\" + tpf.FileName);
                    fileCreation.Close();
                    var folderCreation = Directory.CreateDirectory("c:\\Screenshots\\" + workOrderNumber + " " + clientCode);

                    // Under the folder creation need to create 
                    if (FunctionDescriptionList.Any())
                    {
                        foreach (BO_FunctionalDescription bo_fd in FunctionDescriptionList)
                        {
                            folderCreation.CreateSubdirectory("FD" + bo_fd.FDNumber.ToString() + ". " + bo_fd.Description);
                        }
                    }

                    context.TestPlanFiles.Add(tpf);

                    woh.TestPlanFile = tpf;

                    context.WorkOrderHeaders.Add(woh);

                    context.SaveChanges();
                    DVR.IsValid = true;
                    DVR.ReturnType = woh;
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
