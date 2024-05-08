using System;

public static class ErrorHandler
{

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

    public static double SafeParseDouble(string prompt)
    {
        double result;
        do
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            if (double.TryParse(input, out result))
            {
                return result;
            }
            Console.WriteLine("Por favor introduce un carácter válido. Esta entrada solo acepta números ennteros o decimales.");
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
            Console.WriteLine("El nombre no puede estar vacío. Por favor introduce una cadena de carácteres válidos.");
        } while (true);
    }

}
