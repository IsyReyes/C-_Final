using System;
using System.Runtime.CompilerServices;
using ConsoleTables;

public class BasicArithmetic
{

//Sum of two numbers 
    public static void TwoNumbers()
    {

        int num1 = ErrorHandler.SafeParseInt("Por favor ingresa tu primer número");

        int num2 = ErrorHandler.SafeParseInt("Por favor ingresa tu segundo número");

        var table = new ConsoleTable("1er Número", "2do Número", "Suma");
        table.AddRow(num1, num2, num1+num2);
        table.Write(Format.Alternative);
    }

    public static void ThreeNumbers()
    {

        int num1 = ErrorHandler.SafeParseInt("Por favor ingresa tu primer número");

        int num2 = ErrorHandler.SafeParseInt("Por favor ingresa tu segundo número");

        int num3 = ErrorHandler.SafeParseInt("Por favor ingresa tu tercer número");

        int sum = num1 + num2 + num3;

        var table = new ConsoleTable("1er Número", "2do Número", "3er Número", "Suma");
        table.AddRow(num1, num2, num3, sum);
        table.Write(Format.Alternative);

    }

    public  static void multiCalculate(){
        Console.WriteLine("Acabas de accesar a la multicalculadora. Tomaremos 4 números y obtendremos la suma, resta, producto y divisón de estos.");

        int num1 = ErrorHandler.SafeParseInt("Por favor ingresa tu primer número");

        int num2 = ErrorHandler.SafeParseInt("Por favor ingresa tu segundo número");

        int num3 = ErrorHandler.SafeParseInt("Por favor ingresa tu tercer número");

        int num4 = ErrorHandler.SafeParseInt("Por favor ingresa tu cuarto número");

        int sum  = num1 + num2 + num3 + num4;
        int difference = num1 - num2 - num3 - num4;
        int product = num1 * num2 * num3 * num4;
        string division = DivisionHandler(num1, num2, num3, num4);

        var table = new ConsoleTable("1er Número", "2do Número", "3er Número", "4to Número", "Suma", "Resta", "Multiplicación", "División");
        table.AddRow(num1, num2, num3, num4, sum, difference, product, division);
        table.Write(Format.Alternative);

    }


    public static void TriangleArea(){

        Console.WriteLine("Muy bien, calculalremos el area de un triángulo. Para esto por favor indica cuál es la base, y la altura a continuación.");
        int triangleBase = ErrorHandler.SafeParseInt("Ingresa la base");
        int triangleHeight = ErrorHandler.SafeParseInt("Ingresa la altura");

        int area = triangleBase * triangleHeight / 2;

        var table = new ConsoleTable("Base", "Altura", "Área");
        table.AddRow(triangleBase, triangleHeight, area);
        table.Write(Format.Alternative);
    }


    public static void SecondsInADay(){
        int secondsInADay = 86400;

        Console.WriteLine("Perfecto, vamos a calcular cuántos segundos hay en un número determinado de días. Por favor ingresa el número de días a continuación.");
        int numberOfDays = ErrorHandler.SafeParseInt("Número de días:");

        var table = new ConsoleTable("Días", "Segundos");
        table.AddRow(numberOfDays, secondsInADay * numberOfDays);
        table.Write(Format.Alternative);

    }


    //Div error handler
    private static string DivisionHandler(int num1, int num2, int num3, int num4) {
        try{
        double result =  (double)num1 / num2 / num3 / num4;
        return result.ToString("N2");
        }
        catch (DivideByZeroException) {
            return "Se intento dividir por 0, lo que podría resultar en paradojas matemáticas. Ignorando proceso.";
        }
    }

}