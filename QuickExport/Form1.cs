using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProcesses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resultText = string.Empty;

            Process_Export p = new Process_Export();
            p.ClientCode = this.txtClientCode.Text;
            p.ClientFolder = "C:\\TestClient";
            p.WorkOrderNumber = txtWONumber.Text;

            List<BO_WorkOrderDetail> la = new List<BO_WorkOrderDetail>();
            BO_WorkOrderDetail a = new BO_WorkOrderDetail();
            a.ItemNumber = 1;
            a.ActivityName = txtFD1.Text;
            a.enum_ActivityType = Enum_ActivityType.Transaction;
          //  a.ActivityType = ActivityType.Claim; 

            la.Add(a);
            a = new BO_WorkOrderDetail();
            a.ItemNumber = 2;
            a.ActivityName = txtFD2.Text;
            a.enum_ActivityType = Enum_ActivityType.Claim;
            //a.ActivityType = ActivityType.Transaction;

            la.Add(a);

            p.ActivityList = la;

            DataValidatorReturn dvr = p.HandleExportFileCreation();

            //List<Process_File> processList = dvr.ReturnType as List<Process_File>;

            //foreach (Process_File pf in processList)
            //{
            //    if (resultText == "")
            //    {
            //        resultText = pf.ResultText;
            //    }
            //    else
            //    {
            //        resultText = resultText + Environment.NewLine + pf.ResultText;
            //    }
                
            //}

            this.txtResults.Text = resultText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PRC_Export_Update prcupdate = new PRC_Export_Update();


            List<BO_FunctionalDescription> la = new List<BO_FunctionalDescription>();
            BO_FunctionalDescription a = new BO_FunctionalDescription();
            a.FDNumber = 1;
            a.Description = txtFD1.Text;
            
            la.Add(a);
            a = new BO_FunctionalDescription();
            a.FDNumber = 2;
            a.Description = txtFD2.Text;
            
            la.Add(a);

            prcupdate.RunProcess(la,this.txtClientCode.Text, txtWONumber.Text);
        }
    }
}
