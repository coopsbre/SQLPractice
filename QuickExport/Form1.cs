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

            List<Activity> la = new List<Activity>();
            Activity a = new Activity();
            a.ActivityNumber = 1;
            a.ActivityName = txtFD1.Text;
            a.ActivityType = ActivityType.Claim; 

            la.Add(a);
            a = new Activity();
            a.ActivityNumber = 2;
            a.ActivityName = txtFD2.Text;
            a.ActivityType = ActivityType.Transaction;

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
    }
}
