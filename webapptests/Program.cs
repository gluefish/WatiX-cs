/**Program.cs****************************************************
* WebAppUtils   - A support file for Selenium Frameworks
* Module        - This is the Program file, partial class same as on main
* Author        - Louie Wilson - gluefish@gmail.com
* Date          - 9/10/15 
*               - Output to visual file such as Excel or html
*****************************************************************/
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace WebTest
{
    public partial class Program
    {
        public static IWebDriver d;
        public static string inifile, targetURL, uid, uname, pid, pw, submitid;
        public static  int outlevel;

        public static string webpath, webfile, datestring, pr, logpath;
        public static string test, apppath, appname, xlname, xlPath, xlpath, logname, curpath ;

        static void Main(string[] args)
        {
            w("START");

            w("  Initialize variables, set up outfiles");
            apppath = curdir();
            appname = curname();
            xlname = appname + ".xls";
            xlpath = apppath + "\\" + xlname;
            logname = appname + ".log";
            mkdir("results");
            curpath = "results\\" + dtstring() + "-" + appname;
            webfile = appname + ".html";
            mkdir(curpath);
            webpath = curpath + "\\" + webfile;
            logpath = curpath + "\\" + logname;

            w("  Fetch variables from the Excel sheet");
            openXL(xlpath);
            targetURL = getXLParm("targetURL");
            uid = getXLParm("uid");
            uname = getXLParm("uname");
            pid = getXLParm("pid");
            pw = getXLParm("pword");
            submitid = getXLParm("submitID");
            webfile = getXLParm("webfile");
            test = getXLParm("test");
            webfile = datestring + "-" + webfile;
            closeXL();

            //w("  Open browser");
            //d = new FirefoxDriver();
            d = new ChromeDriver();

            w("  Navigate to the login screen");
            go (targetURL);

            w("  Run the tests - as indicated in the Excel sheet");
            exec(test);

            //Close and clean up browser stuff
            w("Clean up");
            d.Close();
            w("END");

            //Output results to web page and display it
            writeHTML(webpath);
            string webspec = apppath + "/" + webpath;
            startIE(webspec);
        }

    }
}
