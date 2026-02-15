using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter an integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter a decimal: ");
            decimal num2 = decimal.Parse(Console.ReadLine());

            Console.Write("Enter a boolean (true/false): ");
            bool val = bool.Parse(Console.ReadLine());

            Console.WriteLine($"You entered {num1}, {num2}, and {val}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("FormatException: input was not in a correct format.");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unhandled exception: {ex.GetType().Name} - {ex.Message}");
        }
    }
}
