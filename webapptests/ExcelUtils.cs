using Excel = Microsoft.Office.Interop.Excel;
using System;

namespace WebTest
{
    public partial class Program
    {
        public static Excel.Application xla;
        public static Excel.Range xlr;
        public static Excel.Workbook xlw;
        public static Excel.Worksheet xls;

        public static void openXL(string xlp)
        {
            try { 
            xla = new Excel.Application();
            xlw = xla.Workbooks.Open(xlp);
            xls = xlw.Sheets[1];
            xlr = xls.UsedRange;
            }
            catch (Exception e)
            {
                w("    FAIL: " + e.ToString());
            }
        
    }

        public static string getXLCell(int r, int c)
        {
            try { 
            string x = xlr.Cells[r, c].Value;
            return x;
            }
            catch (Exception e)
            {
                w("    FAIL: " + e.ToString());
                return "";
            }
        }

        public static string getXLParm(string parm)
        {
            for (int r = 2; r <= 20; r++)
             {
                if (xlr.Cells[r, 1].Value == parm)
                {
                    w("    " + parm + " = " + xlr.Cells[r, 2].Value);
                    return xlr.Cells[r, 2].Value;
                }
             }
             return "";
        }

        public static void closeXL()
        {
            xlw.Close();
            xla.Quit();
        } 
        
    }
}
