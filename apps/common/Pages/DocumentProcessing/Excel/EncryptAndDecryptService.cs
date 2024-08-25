using Syncfusion.XlsIO;

namespace shared.Pages.DocumentProcessing.Excel
{
    public class EncryptAndDecryptService(Dictionary<string, MemoryStream> fileData)
    {
        /// <summary>
        /// Encrypt or Decrypt an Excel document
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream? EncryptAndDecryptXlsIo(string button, string version)
        {
            if (button == "Encrypt Document")
            {
                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine
                using ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2016;

                //Opening the Existing Worksheet from a Workbook
                IWorkbook workbook = application.Workbooks.Open(fileData["encrypt.xlsx"]);

                //Encrypt the workbook with password
                workbook.PasswordToOpen = "PASSWORD";

                if (version == "XLS")
                    workbook.Version = ExcelVersion.Excel97to2003;

                //Save the document as a stream and return the stream
                MemoryStream? stream = new MemoryStream();
                //Save the created Excel document to MemoryStream
                workbook.SaveAs(stream);
                return stream;
            }
            else
            {
                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine
                using ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2016;

                //Opening the encrypted Workbook
                IWorkbook workbook = application.Workbooks.Open(fileData["encrypted-workbook.xlsx"], ExcelParseOptions.Default, true, "PASSWORD");

                //Modify the decrypted document
                workbook.Worksheets[0].Range["B2"].Text = "Demo for workbook decryption with Essential XlsIO";
                workbook.Worksheets[0].Range["B5"].Text = "This document is decrypted using password 'PASSWORD'.";

                workbook.PasswordToOpen = "";

                if (version == "XLS")
                    workbook.Version = ExcelVersion.Excel97to2003;

                //Save the document as a stream and return the stream
                MemoryStream? stream = new MemoryStream();
                workbook.SaveAs(stream);
                return stream;
            }
        }
        #region HelperMethod
        public void Close()
        {
            foreach (KeyValuePair<string, MemoryStream> item in fileData)
            {
                item.Value.Dispose();
            }
            fileData.Clear();
        }
        #endregion
    }
}
