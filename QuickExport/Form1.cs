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
            p.ActivityName = this.txtActivityName.Text;
            DataValidatorReturn dvr = p.HandleExportFileCreation();

            List<Process_File> processList = dvr.ReturnType as List<Process_File>;

            foreach (Process_File pf in processList)
            {
                if (resultText == "")
                {
                    resultText = pf.ResultText;
                }
                else
                {
                    resultText = resultText + Environment.NewLine + pf.ResultText;
                }
                
            }

            this.txtResults.Text = resultText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
