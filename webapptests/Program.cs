/****************************************************************
* WebAppUtils   - A support file for Selenium Frameworks
* Module        - This is the utils file, partial class same as on main
* Author        - Louie Wilson - gluefish@gmail.com
* Date          - 9/10/15 
*               - Output to visual file such as Excel or html
* Update 9-14   - Routine to output html file and display it
*               - Generate a unique test ID for file name
*               - Generate a folder for day's tests
*****************************************************************/
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

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
            //writeWeb();
            //string xlp = curdir() + "\\webapptests.xlsx";
            //openXL(xlp);

            //closeXL();
                //Initialize variables, set up the outfiles
                apppath = curdir();
            appname = curname();
            xlname = appname + ".xlsx";
            xlpath = apppath + "\\" + xlname;
            logname = appname + ".log";
            mkdir("results");
            curpath = "results\\" + dtstring() + "-" + appname;
            webfile = appname + ".html";
            mkdir(curpath);
            webpath = curpath + "\\" + webfile;
            logpath = curpath + "\\" + logname;

            // Fetch the variables from the Excel sheet
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

            //Start browser & test sequence
            w("  Open browser");
            d = new FirefoxDriver();
            w("  Navigate to the login screen");
            go (targetURL);

            //Run the tests - as indicated in the Excel sheet
            exec(test);

            //Close and clean up browser stuff
            w("Clean up");
            d.Close();
            w("END");

            //Output results to web page and display it
            writeHTML(webpath);
            string webspec = apppath + "/" + webpath;
            startOut(webspec);
        }

    }
}
