using System;
using System.Collections.Generic;

public class Degrees{

    public static void ConvertDegrees(){

        int celsius;

        Console.WriteLine("Vamos a convertir los grados de celsius a ferenheit!");
        Console.WriteLine("Por favor ingresa los grados a convertir:");

        celsius = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Los grados en farenheit son " + (celsius  * 9/5 + 32)+ ".");
    }

}