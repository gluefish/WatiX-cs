using System.IO;

namespace WebTest
{
    public partial class Program
    {
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
