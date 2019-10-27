using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ClientProcesses
{
    public partial class Form4 : DevComponents.DotNetBar.OfficeForm
    {
        public Form4()
        {
            InitializeComponent();
            InitialiazeControls();
        }

        public void InitialiazeControls()
        {
            this.cboFileDelimiter.SelectedIndex = 1;
            this.cboFileGrouping.SelectedIndex = 0;
            this.cboFilesProduced.SelectedIndex = 0;
            BO_FileHdr bo_fileHdr = new BO_FileHdr();
            DataValidatorReturn dvr = bo_fileHdr.Find(1123);

            List<FileHdr> fileHdrList = dvr.ReturnType as List<FileHdr>;
            this.superGridControl1.PrimaryGrid.DataSource = fileHdrList;

            
        }
    }
}