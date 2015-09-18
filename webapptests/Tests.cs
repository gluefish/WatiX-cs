using System;

namespace WebTest
{
    public partial class Program
    {

        public static void Login()
        {
            w("  Enter login name and id and submitting");
            type(uid, uname);
            type(pid, pw);
            click(submitid);

            w("  Set an implicit timeout");
            timeout(60);

            w("  Wait for target page... ");
            w("  Look for a target link");
            try
            {
                click("logout");
                w("PASS");
            }
            catch (Exception)
            {
                w("FAIL");
            }


        }

    }
}
