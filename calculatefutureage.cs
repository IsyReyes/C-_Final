using System;
using System.Collections.Generic;

public class calculateAge{

    public static void AgeInFuture(){
        int currentYear = DateTime.Now.Year;
        int currentAge;
        int yearToCalculate;

        Console.WriteLine("Para saber cuántos años tendrás en el futuro, por favor ingresa tu edad actual a continaución:");

        currentAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Muy bien, ahora ingresa un año en el futuro para saber cuántos años tendrás entonces");
        yearToCalculate = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Excelente, para el año " + yearToCalculate + " tendrás " + (currentAge + (yearToCalculate-currentYear)));

    }
}