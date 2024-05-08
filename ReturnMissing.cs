using System;
using System.Collections.Generic;
using ConsoleTables;

public class ReturnMissing{

    public static void getAngles(){

        int total = 180;

        Console.WriteLine("Vamos a determinar el valor de un tercer ángulo en un triángulo. Por favor ingresa los dos ámgulos que ya conoces.");

        int angleA = ErrorHandler.SafeParseInt("Primer ángulo:");

        int angleB = ErrorHandler.SafeParseInt("Segundo ángulo:");

        int missingAngle = total - angleA - angleB;

        if (angleA + angleB > total){
            var table = new ConsoleTable("Esto no es un triángulo.");
            table.Write(Format.Alternative);
        }else { 
            var table = new ConsoleTable("Primer Ángulo", "Segundo Ángulo", "Ángulo Faltante");
            table.AddRow(angleA, angleB, missingAngle);
            table.Write(Format.Alternative);
        }
    }

    public static void MissingMoney(){

        Console.WriteLine("Vamos a hacer una operación con valores predefinidos para saber cuánto dinero tiene Juan.");
        Console.WriteLine("Puedes elegir cuántos billetes de 200, de 100 y 50 tendrá.");

        int xHowMany = ErrorHandler.SafeParseInt("Por favor ingresa cuantos billetes de 200 tiene Juan") * 200;

        int yHowMany = ErrorHandler.SafeParseInt("Por favor ingresa cuantos billetes de 100 tiene Juan") * 100;

        int zHowMany = ErrorHandler.SafeParseInt("Por favor ingresa cuantos billetes de 50 tiene Juan") * 50;

        int total = xHowMany + yHowMany + zHowMany;

        var table = new ConsoleTable("Total Billetes 200", "Total Billetes 100", "Total Billetes 50", "Total General");
        table.AddRow(xHowMany, yHowMany, zHowMany, total);
        table.Write(Format.Alternative);
    }
}