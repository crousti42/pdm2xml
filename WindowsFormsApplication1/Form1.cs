using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        OpenFileDialog oOfd = new OpenFileDialog();
        FolderBrowserDialog oFbd = new FolderBrowserDialog();

        private String sSdmFilePath = "";
        private String sPdmFilePath = "";
        private String sContextVarFilePath = "";
        private String sReturnPath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void logThis(string sTextToDisplay)
        {
            consoleRchTxtBx.Text += sTextToDisplay;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void activateGeneratorBtn()
        {
            if ((sSdmFilePath != "") && (sPdmFilePath != "") && (sContextVarFilePath != "") && (sReturnPath != ""))
            {
                generatePdmBtn.Enabled = true;
            }
        }

        private void openSdmBtn_Click(object sender, EventArgs e)
        {
            oOfd.Filter = "Excel|*.xls;*.xlsx";
            if (oOfd.ShowDialog() == DialogResult.OK)
            {
                openSdmTxtBx.Text = oOfd.FileName;
                sSdmFilePath = oOfd.FileName;
            }
            activateGeneratorBtn();

        }

        private void openPdmBtn_Click(object sender, EventArgs e)
        {
            oOfd.Filter = "Excel|*.xls;*.xlsx";
            if (oOfd.ShowDialog() == DialogResult.OK)
            {
                openPdmTxtBx.Text = oOfd.FileName;
                sPdmFilePath = oOfd.FileName;
            }
            activateGeneratorBtn();
        }

        private void openContextVarBtn_Click(object sender, EventArgs e)
        {
            oOfd.Filter = "Excel|*.xls;*.xlsx";
            if (oOfd.ShowDialog() == DialogResult.OK)
            {
                openContextVarTxtBx.Text = oOfd.FileName;
                sContextVarFilePath = oOfd.FileName;
            }
            activateGeneratorBtn();
        }

        private void openResultPdmBtn_Click(object sender, EventArgs e)
        {
            if (oFbd.ShowDialog() == DialogResult.OK)
            {
                openResultPdmTxtBx.Text = oFbd.SelectedPath;
                sReturnPath = oFbd.SelectedPath;
            }
            activateGeneratorBtn();
        }

        // Genere le nouveau fichier PDM
        private void generatePdmBtn_Click(object sender, EventArgs e)
        {
            pdm2xml.ExcelTreatment oSdm;

            oSdm.sFilePath = sSdmFilePath;
        }
    }
}
