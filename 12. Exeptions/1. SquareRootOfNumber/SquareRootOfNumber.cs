using System;

class SquareRootOfNumber
{
    static void Main()
    {
        try
        {
            Console.Write("Enter number for calculating its square root: ");
            uint num = uint.Parse(Console.ReadLine());
            Console.WriteLine("The square root of the number {0} is {1:F2}.", num, Math.Sqrt(num));
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid Number.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Number.");
        }
        finally
        {
            Console.WriteLine("Good bye.");
        }
    }
}
