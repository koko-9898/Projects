using System;
using System.IO;
using System.Security;

class ReadFile
{
    static void Main()
    {
        ReadingAFile();
    }

    private static void ReadingAFile()
    {
        try
        {
            string fileName = @"..\..\TextFile1.txt";
            string text = File.ReadAllText(fileName);
            Console.WriteLine(text);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("ReadAllText method cannot use null as parameter.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("You should enter correct file name in ReadAllText method.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The path you've entered is too long.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory of the file is not found.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You don't have access to this file.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found.");
        }
        catch (NotSupportedException nse)
        {
            Console.WriteLine(nse.Message);
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
        catch (SecurityException se)
        {
            Console.WriteLine(se.Message);
        }
    }
}
