﻿/****************************************************************
* WebAppUtils   - A support file for Selenium Frameworks
* Module        - This is the utils file, partial class same as on main
* Author        - Louie Wilson - gluefish@gmail.com
* Date          - 9/10/15 
* Purpose       - Keyword driven test harness; uses Selenium WebDriver
*               - Parameters fetched from ini file generated by Excel file
*               - Test results stored to .log file and html
*               - Output to visual file such as Excel or html
* Update 9-14   - Routine to output html file and display it
*               - Generate a unique test ID for file name
*               - Generate a folder for day's tests
*****************************************************************/

using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Excel = Microsoft.Office.Interop.Excel;

namespace WebTest
{
    public partial class Program
    {
        public static IWebDriver d;
        public static string inifile;
        public static string targetURL;
        public static string uid;
        public static string uname;
        public static string pid;
        public static string pw;
        public static string submitid;
        public static  int outlevel;

        public static Excel.Application xla;
        public static Excel.Range xlr;
        public static Excel.Workbook xlw;
        public static Excel.Worksheet xls;
        public static string xlPath;
        public static string webpath;
        public static string webfile;
        public static string datestring;
        public static string pr;
        public static string test;
        static void Main(string[] args)
        {
            //Initialize variables
            string apppath;
            apppath = curdir();
            xlPath = apppath + "\\webapptest.xls";
            Console.Out.WriteLine(timeStamp());

            //fetch values from Excel sheet
            openXL(xlPath);
            write2log("webtest.log", "FKF Login");
            w("START.");
            inifile = "testparms.ini";
            w("Testing Login");
            targetURL = getXLParm("targetURL");
            uid = getXLParm("uid");
            uname = getXLParm("uname");
            pid = getXLParm("pid");
            pw = getXLParm("pword");
            submitid = getXLParm("submitid");
            webfile = getXLParm("webfile");
            test = getXLParm("test");
            datestring = dtstring();
            webfile = datestring + "-" + webfile;
            w(webfile);
            webpath = apppath + "\\" + webfile;

            closeXL();
            mkdir("testing123");

            //Start browser & test sequence
            w("  Open browser");
            d = new FirefoxDriver();

            w("  Navigate to the login screen");
            go (targetURL);

            exec(test);
            /*string test1 = "Login";
            m = t.GetMethod(test1);
            m.Invoke(o, null);
            //Login();*/

            //Close and clean up browser stuff
            w("Clean up");
            d.Close();

            w("END");

            //Output results to web page and display it
            writeHTML(webfile);
            startOut(webpath);
        }
    }
}
