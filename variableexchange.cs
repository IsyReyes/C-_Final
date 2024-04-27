using System;
using System.Collections.Generic;

public class VariableExchange{



public static void ExchangeVariable(){

int variable1;
int variable2;
int exchangeContainer;

Console.WriteLine("Vamos a intercambiar los valores de una variable a otra");
Console.WriteLine("Ingresa el valor numérico entero de la primera variable:");
variable1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresa el valor numérico entero de la segunda variable:");
variable2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("En este momento la primera variable vale " + variable1 + " y la segunda variable vale " + variable2);

Console.WriteLine("Generando intercambio de variables");

exchangeContainer = variable1;

variable1 = variable2;
variable2 = exchangeContainer;


Console.WriteLine("En este momento la primera variable vale " + variable1 + " y la segunda variable vale " + variable2);
Console.WriteLine("Intercambio generado correctamente.");



}

}