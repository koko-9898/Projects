using System;
using System.Net;

class DownlaodFile
{
    static void Main()
    {
        ReadAndDownloadFile();
    }

    private static void ReadAndDownloadFile()
    {
        WebClient wc = new WebClient();
        try
        {
            string link = @"http://www.devbg.org/img/Logo-BASD.jpg";
            wc.DownloadFile(link, "../../pic.jpg");
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine(ane.Message);
        }
        catch (WebException we)
        {
            Console.WriteLine(we.Message);
        }
        catch (NotSupportedException nse)
        {
            Console.WriteLine(nse.Message);
        }
        finally
        {
            wc.Dispose();
        }
    }
}
