using System;
using System.IO;

namespace WebTest
{
    public partial class Program
    {
        public static void writeHTMLFromTextFile(string textfile)
        {
            //open a new html file with the filename stub + .html
            //open the textfile for a read
            //read the first line
            //create a table of its contents
            //loop through the rest of the lines
            //create a table and rows of the test results
            //on the last line, create a table of results
            //write the rows
            //write the footer
            //save to the local drive and close the html file and text file
            //open up the browser with the html file
        }

        public static void writeHTML(string filename)
        {
            string pagename = curdir() + "/" + filename;
            w(pagename);
            StreamWriter sw = File.AppendText(pagename);
            sw.Write(pageHeader());
            sw.WriteLine(tablerow());
            sw.Write(pageFooter());
            sw.Close();
        }
        
        public static void writeWeb()
        {
            //This method depends on a specific output format on TestOutput.txt

            // //Read the TestOutput.txt document into memory.
            // //int ll = File.ReadAllLines("TestOutput.txt").Length;

            //Open the output for the html file with same name as the text file
            StreamWriter sw = new StreamWriter("TestOutput.html");

            //write the html header
            sw.WriteLine("<!DOCTYPE html>");
            sw.WriteLine("<html>\n  <head>\n  </head>\n  <body>");

            //write the lines of the body, from the text file
            string l;
            using (StreamReader sr = new StreamReader("TestOutput.txt"))
            {
                l = sr.ReadLine();
                // Table for test suite information
                sw.WriteLine("    <table border=\"1\" style=\"width:100%; color:white\"><tr><td align=\"center\" bgcolor=\"blue\"><h2><c>" + l + "</c></h2></td></tr></table>");
                int testno = 1;
                while (!sr.EndOfStream)
                {
                    l = sr.ReadLine();
                    if (l.Contains("==="))
                    {
                        //sw.WriteLine("");
                    }
                    else if (l.Contains("TEST:"))
                    {
                        if (testno == 1)
                        {
                            sw.WriteLine("    </table>");
                        }
                        sw.WriteLine("    <br/>");
                        sw.WriteLine("    <table  border=\"1\" style=\"width: 100 % \"><tr><td>" + l + "</td></tr></table>");
                        sw.WriteLine("    <table  border=\"1\" style=\"width: 100% \">");
                    }
                    else
                    {
                        if (l.Length > 0)
                        {
                            String[] lll = l.Split(' ');
                            sw.WriteLine("    <tr><td>" + lll[0] + "</td>");
                            string l2 = l.Replace(lll[0], "");
                            l2 = l2.Replace(" -- Pass", "");
                            l2 = l2.Replace(" -- Fail", "");
                            sw.WriteLine("    <td>" + l2 + "</td>");
                            if (l.Contains("Pass")) sw.WriteLine("  <td bgcolor = \"lightgreen\">PASS</td>");
                            if (l.Contains("Fail")) sw.WriteLine("  <td bgcolor = \"pink\">FAIL</td>");
                            if (l.Contains("Skip")) sw.WriteLine("  <td bgcolor = \"lightgray\">SKIPPED</td>");
                        }
                    }
                }
            }

            //write the html footer and close the page
            sw.WriteLine("    </table>");
            sw.WriteLine("  <\n/body>\n</html>");
            sw.Close();
        }

        public static string pageFooter()
        {
            string pf;
            pf = "\n</body>\n</html>\n";
            return pf;
        }

        public static string pageHeader()
        {
            string ph;
            ph = "<html>\n<head>"
                + "\n</head>\n<body>"
                + "\n<h1>TEST AUTOMATION RESULT</h1>"
                + "\n<table border=\"1\" style=\"width: 100 % \">"
                + "\n<tr><td>Test Run Name:</td><td>Date:</td><td>Time:</td></tr>"
                + "\n<tr><td>" + appname + "</td><td>" + System.DateTime.Now.ToString("MM/dd/yy") + "</td><td>" + System.DateTime.Now.ToString("hh:mm:ss") + "</td></tr>"
                + "\n</table>\n";
            return ph;
        }

        public static string tablerow()
        {
            //string pr;
            pr = "<table border=\"1\" style=\"width: 100 % \">";
            pr += "<tr style=\"background-color:black; color:white\"><th>Test No.</th><th>Time</th><th>Test Name</th><th>Test Description</th><th>Test Result</th></tr>";

            pr += "<tr><td>Test1</td>";
            pr += "<td>16:09:00</td>";
            pr += "<td>Login</td>";
            pr += "<td>Using a valid user name and password, user is able to log into the system</td>";
            pr += "<td style=\"background-color:green; color:white\"><b>PASS</b></td></tr>";

            pr += "</table>";
            return pr;
        }

    }
}
