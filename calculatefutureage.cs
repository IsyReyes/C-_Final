using System;
using System.Collections.Generic;
using ConsoleTables;

public class calculateAge{

    public static void AgeInFuture(){

        int currentYear = DateTime.Now.Year;

        int currentAge = ErrorHandler.SafeParseInt("Para saber cuántos años tendrás en el futuro, por favor ingresa tu edad actual a continaución:");

        Console.WriteLine("Muy bien, ahora ingresa un año en el futuro para saber cuántos años tendrás entonces");
        int yearToCalculate = ErrorHandler.SafeParseInt("Muy bien, ahora ingresa un año en el futuro para saber cuántos años tendrás entonces");
        int futureAge = currentAge + (yearToCalculate-currentYear);

        var table = new ConsoleTable("Año Actual", "Año a Calcular", "Edad Futura");
        table.AddRow(currentYear, yearToCalculate, futureAge);
        table.Write(Format.Alternative);
    }
}