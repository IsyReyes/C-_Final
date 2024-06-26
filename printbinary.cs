using System;
using System.Text;
using System.Collections.Generic;
using ConsoleTables;

public class Binary{

    public static void PrintBinary(){
        double decimalNumber = ErrorHandler.SafeParseDouble("Por favor, ingresa un número decimal para convertirlo a binario:");
        string binaryNumber = ConvertDecimalToBinary(decimalNumber);  // decimal handler for binary conversion
        Console.WriteLine($"El número {decimalNumber} en binario es: {binaryNumber}");  // printing non binary

        var table = new ConsoleTable("Número Decimal", "Número Binario");
        table.AddRow(decimalNumber, binaryNumber);
        table.Write(Format.Alternative);
    }

    private static string ConvertDecimalToBinary(double decimalNumber)
    {
        int integralPart = (int)decimalNumber;
        double fractionalPart = decimalNumber - integralPart;
        string integralBinary = Convert.ToString(integralPart, 2);
        string fractionalBinary = ConvertFractionalToBinary(fractionalPart);
        
        return fractionalBinary == "0" ? integralBinary : $"{integralBinary}.{fractionalBinary}";
    }

    private static string ConvertFractionalToBinary(double fractionalPart)
    {
        StringBuilder binary = new StringBuilder();
        double frac = fractionalPart;
        int safetyNet = 20;  // Limits the length of the binary fraction to prevent infinite loops

        while (frac > 0 && safetyNet-- > 0)
        {
            double r = frac * 2;
            if (r >= 1)
            {
                binary.Append("1");
                frac = r - 1;
            }
            else
            {
                binary.Append("0");
                frac = r;
            }
        }
        return binary.ToString() == "" ? "0" : binary.ToString();
    }

}