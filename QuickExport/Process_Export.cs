using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientProcesses
{
    public class Process_Export
    {
        public string ClientCode { get; set; }
        public string ActivityName { get; set; }
        public List<Activity> ActivityList = new List<Activity>();
        public string WorkOrderNumber { get; set; }
        public string ClientFolder { get; set; }
        public string SourceFolder { get; set; }
        public string File_SP_Name { get; set; }
        public string File_CreateTable_Name { get; set; }
        public string File_Activity_Name { get; set; }
        public string File_FileActivity_Name { get; set; }
        public string File_SqlActions_Name { get; set; }
        public string File_Activity_Source_Name { get; set; }
        public string File_Validate_Name { get; set; }
        public string DatabaseOwner = "dbo.";
        public string FilePostFix = ".sql";
        public string UnderScore = "_";

       

        public DataValidatorReturn HandleExportFileCreation()
        {
            // Step 1: Check if folder exists and if doesn't create it.
            DataValidatorReturn dvr = new DataValidatorReturn();

            if (DirectoryExists().IsValid == false)
            {
                CreateDirectory();
            }

            using (var context = new WorkOrderLogEntities())
            {
                WorkOrderHeader woh = new WorkOrderHeader();
                woh.ClientCode = ClientCode;
                woh.WOHdrID = Convert.ToInt32(WorkOrderNumber);
                woh.CreatedDate = System.DateTime.Now;
                context.WorkOrderHeaders.Add(woh);

                context.SaveChanges();
            }

            // Step 2: Loop through all the activities.
            foreach (Activity a in ActivityList)
            {
                // Step 2 set up all names etc.
                List<Process_File> listProcesses = new List<Process_File>();

                listProcesses.Add(new Process_File(ClientFolder) { FileName = ClientFolder + "\\" + GenerateActivitySPFileName(a.ActivityName) + ".sql", Identifier = "Activity SP" });
                listProcesses.Add(new Process_File(ClientFolder) { FileName = ClientFolder + "\\" + GenerateActivityTableFileName() + ".sql", Identifier = "Activity Tables File" });
                listProcesses.Add(new Process_File(ClientFolder) { FileName = ClientFolder + "\\" + GenerateActivityValidateFileName() + ".sql", Identifier = "Activity Validate File" });
                listProcesses.Add(new Process_File(ClientFolder) { FileName = ClientFolder + "\\" + GenerateActivityFileName(a.ActivityName) + ".sql", Identifier = "Activity File Name" });
                listProcesses.Add(new Process_File(ClientFolder) { FileName = ClientFolder + "\\" + GenerateSqlActionsFileName(a.ActivityName) + ".sql", Identifier = "Activity Sql Actions File" });
                listProcesses.Add(new Process_File(ClientFolder) { FileName = ClientFolder + "\\" + GenerateSourceFileName(a.ActivityName) + ".sql", Identifier = "Activity Source File" });

                // Step 3 Loop through all the filenames and start generating if required.
                foreach (Process_File p in listProcesses)
                {
                    if (!File.Exists(p.FileName))
                    {
                        var fileCreation = File.CreateText(p.FileName);
                        fileCreation.Close();

                        p.ResultText = p.FileName + " Created Successfully.";

                        // Step 4 If Creating for the first time then copy from a source file. 
                        p.CopySourceFileToClientDirectory(ClientCode, p.FileName);

                    }
                    else
                    {
                        p.ResultText = p.FileName + " Already Exists.";
                    }
                }

                using (var context = new WorkOrderLogEntities())
                {
                    WorkOrderDetail wod = new WorkOrderDetail();
                    wod.FDDescription = a.ActivityName;
                    wod.FDNo = a.ActivityNumber;
                    wod.WOHdrID = Convert.ToInt32(WorkOrderNumber);
                    context.WorkOrderDetails.Add(wod);

                    context.SaveChanges();
                }
            }
            // Step 4 Need to write to the WorkOrderHeader table if not already. 
           

            dvr.ReturnType = ActivityList;
            
            return dvr;
        }

        public string GenerateActivitySPFileName(string activityName)
        {
            return DatabaseOwner + ClientCode + activityName.Replace(" ","");
        }

        public string GenerateActivityTableFileName()
        {
            //Generate the file Name.
            return File_CreateTable_Name = ClientCode + UnderScore + "07" + UnderScore + "Tables";
            
        }

        public string GenerateActivityValidateFileName()
        {
            //Generate the File Name.
            return DatabaseOwner + ClientCode + "ExportValidate"; 
        }

        public string GenerateActivityFileName(string activityName)
        {
            //Generate the File Name.
            File_FileActivity_Name = ClientCode + UnderScore + activityName + UnderScore + "activity";
            File_FileActivity_Name = File_FileActivity_Name.Replace(" ", UnderScore);

            return File_FileActivity_Name;
        }

        public string GenerateSqlActionsFileName(string activityName)
        {
            File_SqlActions_Name = ClientCode + UnderScore + activityName + UnderScore + "sqlactions";
            File_SqlActions_Name = File_SqlActions_Name.Replace(" ", UnderScore);
            //Generate the File Name.
            return File_SqlActions_Name;
           
        }

        public string GenerateSourceFileName(string activityName)
        {
            //Generate the File Name.
            File_Activity_Source_Name = ClientCode + UnderScore + activityName + UnderScore + "source";
            File_Activity_Source_Name = File_Activity_Source_Name.Replace(" ", UnderScore);
            return File_Activity_Source_Name;
        }

        public DataValidatorReturn DirectoryExists()
        {
            DataValidatorReturn dvr = new DataValidatorReturn();

            if (Directory.Exists(ClientFolder))
            {
                dvr.IsValid = true;
                dvr.ReturnText = ClientFolder + "Exists.";
            }

            return dvr;
        }

        public DataValidatorReturn CreateDirectory()
        {
            DataValidatorReturn dvr = new DataValidatorReturn(); 

            try
            {
                Directory.CreateDirectory(ClientFolder);
            }
            catch (Exception exception)
            {
                dvr.IsValid = false;
                dvr.ErrorText = exception.Message;
                dvr.ReturnType = exception;
            }

            return dvr;
        }

        public DataValidatorReturn FileExists()
        {
            DataValidatorReturn dvr = new DataValidatorReturn();

            if (File.Exists(ClientFolder))
            {
                dvr.IsValid = true;
                dvr.ReturnText = ClientFolder + "Exists.";
            }

            return dvr;
        }


        public DataValidatorReturn CreateFile(string fileName)
        {
            string fullFileName = string.Empty; 

            DataValidatorReturn dvr = new DataValidatorReturn();

            fullFileName = ClientFolder + "\\" + fileName + FilePostFix; 

            if (File.Exists(fullFileName))
            {
                // File exists don't create.
                dvr.ReturnText = "File: " + fileName + " Already Exists.";
                dvr.IsValid = false;
            }
            else
            {
                //Doesnt exist, create a new one.
                try
                {
                    File.CreateText(fileName);
                    dvr.ReturnText = "File: " + fileName + " Created Successfully.";
                    dvr.IsValid = true;
                }
                catch (Exception exception)
                {
                    dvr.ErrorText = exception.Message;
                    dvr.IsValid = false;
                }
            }

            return dvr;
        }
    }
}
