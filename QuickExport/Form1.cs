using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClientProcesses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
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
            //  a.ActivityName = txtFD1.Text;
            a.enum_ActivityType = Enum_ActivityType.Transaction;
            //  a.ActivityType = ActivityType.Claim; 

            la.Add(a);
            a = new BO_WorkOrderDetail();
            a.ItemNumber = 2;
            //a.ActivityName = txtFD2.Text;
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

            //this.txtResults.Text = resultText;
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
            //  a.Description = txtFD1.Text;

            la.Add(a);
            a = new BO_FunctionalDescription();
            a.FDNumber = 2;
            //  a.Description = txtFD2.Text;

            la.Add(a);

            prcupdate.RunProcess(la, this.txtClientCode.Text, txtWONumber.Text);
        }

        private void txtWONumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtClientCode_Leave(object sender, EventArgs e)
        {
            BO_Client bO_Client = new BO_Client();
            var client = bO_Client.Find(this.txtClientCode.Text);
            if (client.IsValid == false)
            {
                MessageBox.Show(client.ReturnText);
                this.btnAddClient.Visible = true;
            }
            else
            {
                this.btnAddClient.Visible = false;

            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {

        }

        private void txtWONumber_Leave(object sender, EventArgs e)
        {
            /* BO_WorkOrderHeader bo_WorkOrderHeader = new BO_WorkOrderHeader();
             var workOrderHeader = bo_WorkOrderHeader.Find(Convert.ToInt32(this.txtWONumber.Text));
             if (workOrderHeader.IsValid == true)
             {
                 MessageBox.Show(workOrderHeader.ReturnText);

             }
             else
             {
                 this.btnAddClient.Visible = false;

             }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                tabControl1.TabPages.Remove(tabPage);
            }

            for (int numTabs = 1; numTabs <= numericUpDown1.Value; numTabs++)
            {
                TabPage tp = new TabPage("FD " + numTabs.ToString());
                tabControl1.TabPages.Add(tp);
                uc_FunctionalDescription uc_FunctionalDescription = new uc_FunctionalDescription();
                uc_FunctionalDescription.Visible = true;
                tp.Controls.Add(uc_FunctionalDescription);
            }

            tabControl1.Visible = true;
        }
    }
}
