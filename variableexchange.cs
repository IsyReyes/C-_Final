using System;
using System.Collections.Generic;
using ConsoleTables;

public class VariableExchange{



    public static void ExchangeVariable(){

    int exchangeContainer;

    Console.WriteLine("Vamos a intercambiar los valores de una variable a otra");

    int variable1 = ErrorHandler.SafeParseInt("Ingresa el valor numérico entero de la primera variable:");

    int variable2 = ErrorHandler.SafeParseInt("Ingresa el valor numérico entero de la segunda variable:");

    var table1 = new ConsoleTable("Variable 1", "Variable 2");
    table1.AddRow(variable1, variable2);
    table1.Write(Format.Alternative);

    Console.WriteLine("Generando intercambio de variables...");

    exchangeContainer = variable1;

    variable1 = variable2;
    variable2 = exchangeContainer;

    var table2 = new ConsoleTable("Variable 1", "Variable 2");
    table2.AddRow(variable1, variable2);
    table2.Write(Format.Alternative);

    Console.WriteLine("Intercambio completado.");

    }

}