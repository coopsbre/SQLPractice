using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.Editors;

namespace ClientProcesses
{
    public partial class Form4 : DevComponents.DotNetBar.OfficeForm
    {
        public List<DTO_FileHdr> dtoFileHdrList;
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
            
            

            dtoFileHdrList = new List<DTO_FileHdr>();

            

            
        }

        private void labelX15_Click(object sender, EventArgs e)
        {

        }

        private void wizardPage4_NextButtonClick(object sender, CancelEventArgs e)
        {
            DTO_FileHdr dTO_FileHdr = new DTO_FileHdr()
            {
                FileProduceTypeId = this.cboFileDelimiter.SelectedText,
                ActivityName = "Export CBA to Westpac",
                HeaderFields = Convert.ToInt32(this.nUpHeaderFields.Value),
                TaxFields = Convert.ToInt32(this.nUpTaxFields.Value),
                ClearingFields = Convert.ToInt32(this.nUpClearingFields.Value),
                InterCompanyFields = Convert.ToInt32(this.nUpICClearingFields.Value)

            };

            dtoFileHdrList.Add(dTO_FileHdr);

            this.superGridControl1.PrimaryGrid.DataSource = dtoFileHdrList;
        }

        private void wizardPage3_NextButtonClick(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void wizardPage1_NextButtonClick(object sender, CancelEventArgs e)
        {
           
        }

        private void wizard1_NextButtonClick(object sender, CancelEventArgs e)
        {
            if (this.wizard1.SelectedPageIndex == 1)
            {
                ComboItem cboFileProduceType = this.cboFilesProduced.SelectedItem as ComboItem;
                ComboItem cboFileDelimiter = this.cboFileDelimiter.SelectedItem as ComboItem;

                DTO_FileHdr dTO_FileHdr = new DTO_FileHdr()
                {
                    FileProduceTypeId = cboFileProduceType.Text.ToUpper(),
                    FileDelimiterId = cboFileDelimiter.Text.ToUpper(),
                    ActivityName = "Export CBA Test to Fred",
                    HeaderFields = Convert.ToInt32(this.nUpHeaderFields.Value),
                    TaxFields = Convert.ToInt32(this.nUpTaxFields.Value),
                    PostingFields = Convert.ToInt32(this.nUpPostingFields.Value),
                    ClearingFields = Convert.ToInt32(this.nUpClearingFields.Value),
                    InterCompanyFields = Convert.ToInt32(this.nUpICClearingFields.Value)

                };

                dtoFileHdrList.Add(dTO_FileHdr);

                this.superGridControl1.PrimaryGrid.DataSource = dtoFileHdrList;
            }
        }
    }
}