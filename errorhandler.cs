using System;

public static class ErrorHandler
{
    //This method utilizes TryParse to make sure the input can be converted succesfully to an integer, used later in the switch cases.
    public static int SafeParseInt(string prompt)
    {
        int result;
        do
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            if (int.TryParse(input, out result))
            {
                return result;
            }
            Console.WriteLine("Por favor introduce un carácter válido. Esta entrada solo acepta números.");
        } while (true);
    }

    public static string RequiredString(string prompt)
    {
        string result;
        do
        {
            Console.WriteLine(prompt);
            result = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(result))
            {
                return result;
            }
            Console.WriteLine("Input cannot be empty. Please enter a valid string.");
        } while (true);
    }

}
