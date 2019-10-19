using System.IO;

namespace ClientProcesses
{
    public class Process_File
    {
        public string ClientFolder { get; set; }
        public string SourceFolder { get; set; }
        public string SourceClient { get; set; }
        public string SourceFile { get; set; }

        public Process_File(string clientFolder)
        {
            ClientFolder = clientFolder;
            SourceFolder = "c:\\ProMasterExpress\\";
            SourceClient = "INL";
        }

        public string FileName { get; set; }
        public string ResultText { get; set; }
        public string Identifier { get; set; }
        public string SourceFileName { get; set; }

        public DataValidatorReturn CopySourceFileToClientDirectory(string clienCode, string clientFileName)
        {
            DataValidatorReturn dvr = new DataValidatorReturn();
            string content = string.Empty;

            if (clientFileName.Contains("ExportValidate"))
            {
                SourceFile = SourceFolder + "dbo." + SourceClient + "ExportValidate" + ".sql";
            }
            else if (clientFileName.Contains("07_Tables"))
            {
                SourceFile = SourceFolder + SourceClient + "_" + "07" + "_" + "Tables.sql";
            }

            if (File.Exists(SourceFile))
            {
                content = File.ReadAllText(SourceFile);
                content = content.Replace(SourceClient, clienCode);
                File.AppendAllText(clientFileName, content);
            }

            return dvr;
        }
    }
}
