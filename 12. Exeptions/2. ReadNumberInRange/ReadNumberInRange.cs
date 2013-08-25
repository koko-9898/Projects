using System;

class ReadNumberInRange
{
    public static void ReadNumber(int start, int end)
    {
        try
        {
            int num = int.Parse(Console.ReadLine());

            if (num < start || num > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                Console.WriteLine("The number {0} is valid.", num);
            }
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The number is out of range.");
        }
        catch
        {
            Console.WriteLine("Unhandled exeption.");
        }
    }

    static void Main()
    {
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            int randomNumberStart = rnd.Next(2, 100);
            int randomNumberEnd = rnd.Next(randomNumberStart, 100);

            Console.Write("The entered number must be within the range [{0}, {1}]: ",
                randomNumberStart, randomNumberEnd);

            ReadNumber(randomNumberStart, randomNumberEnd);
            Console.WriteLine();
        }
    }
}
