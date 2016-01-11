using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace pdm2xml
{
    class ExcelTreatment
    {
        public string sFilePath;
        
        private void getColumnValues(string sWorksheetName, string sColumn, int iFirstLine)
        {
            using (SpreadsheetDocument oSdmDoc = SpreadsheetDocument.Open(sSdmFilePath, false))
            {
                IEnumerable<Sheet> oPagesheet = oSdmDoc.WorkbookPart.Workbook.Descendants<Sheet>().Where(s => s.Name == "Pages");
                if (oPagesheet.Count() == 0)
                {
                    // The specified worksheet does not exist.
                    return;
                }

            }
        }
    }
}
