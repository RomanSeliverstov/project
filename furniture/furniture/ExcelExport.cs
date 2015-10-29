using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;

namespace furniture
{
    class ExcelExport
    {
        Microsoft.Office.Interop.Excel.Application xlApp;
        Microsoft.Office.Interop.Excel.Worksheet xlSheet;
        Microsoft.Office.Interop.Excel.Range xlSheetRange;
        
        public void export(DataTable dt) {

           
            xlApp = new Excel.Application();
            xlApp.Visible = true;

            try
            {
                
                xlApp.Workbooks.Add(Type.Missing);
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;
                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                xlSheet.Name = "Итог";
                int collInd = 0;
                int rowInd = 0;
                string data = "";

                
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data = dt.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[1, i + 1] = data;
                    xlSheetRange = xlSheet.get_Range("A1:Z1", Type.Missing);
                    xlSheetRange.WrapText = true;
                    xlSheetRange.Font.Bold = true;
                }

                
                for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                    {
                        data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }

              
                xlSheetRange = xlSheet.UsedRange;
                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                
            }
            finally
            {
                xlApp.Visible = true;
                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;

     
            }
        
        
        }
    
    }

}
