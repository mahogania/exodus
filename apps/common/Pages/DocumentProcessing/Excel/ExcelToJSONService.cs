using Syncfusion.XlsIO;

namespace shared.Pages.DocumentProcessing.Excel
{
    public class ExcelToJsonService
    {
        private readonly Dictionary<string, MemoryStream> _fileDataValue;
        public ExcelToJsonService(Dictionary<string, MemoryStream> fileData)
        {
            _fileDataValue = fileData;
        }

        /// <summary>
        /// Convert the Excel document to JSON
        /// </summary>
        /// <returns>Return the JSON document as stream</returns>
        public MemoryStream? ExcelToJsonXlsIo(string button, string option, bool isSchema)
        {
            if (button == "Input Document")
            {
                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine
                using ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2016;

                //Opening the encrypted Workbook
                IWorkbook workbook = application.Workbooks.Open(_fileDataValue["excel-to-json.xlsx"], ExcelParseOptions.Default);

                //Save the document as a stream and return the stream
                MemoryStream? stream = new MemoryStream();
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
                IWorkbook workbook = application.Workbooks.Open(_fileDataValue["excel-to-json.xlsx"], ExcelParseOptions.Default);

                //Accessing first worksheet in the workbook
                IWorksheet worksheet = workbook.Worksheets[0];

                IRange range = worksheet.Range["A2:B10"];

                //Save the document as a stream and return the stream
                MemoryStream? stream = new MemoryStream();
                if (option == "Workbook")
                    workbook.SaveAsJson(stream, isSchema);
                else if (option == "Worksheet")
                    workbook.SaveAsJson(stream, worksheet, isSchema);
                else if (option == "Range")
                    workbook.SaveAsJson(stream, range, isSchema);
                return stream;
            }
        }
        #region HelperMethod
        public void Close()
        {
            foreach (KeyValuePair<string, MemoryStream> item in _fileDataValue)
            {
                item.Value.Dispose();
            }
            _fileDataValue.Clear();
        }
        #endregion
    }
}
