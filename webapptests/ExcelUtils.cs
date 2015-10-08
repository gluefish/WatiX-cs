using Excel = Microsoft.Office.Interop.Excel;

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
            xla = new Excel.Application();
            xlw = xla.Workbooks.Open(xlp);
            xls = xlw.Sheets[1];
            xlr = xls.UsedRange;
        }

        public static string getXLCell(int r, int c)
        {
            string x = xlr.Cells[r, c].Value;
            return x;
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
