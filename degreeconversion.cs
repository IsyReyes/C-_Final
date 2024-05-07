using System;
using System.Collections.Generic;
using ConsoleTables;

public class Degrees{

    public static void ConvertDegrees(){

        Console.WriteLine("Vamos a convertir los grados de celsius a ferenheit!");

        int celsius = ErrorHandler.SafeParseInt("Por favor ingresa los grados a convertir:");
        int farenheit = celsius  * 9/5 + 32;

        var table = new ConsoleTable("Celsius", "Farenheit");
        table.AddRow(celsius, farenheit);
        table.Write(Format.Alternative);
    }

}