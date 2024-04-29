using System;
using System.Collections.Generic;

public class TonsCalculator{

    public static void TonsRate(){
        int tons;
        int basePrice = 52;
        int excedentPrice = 35;
        int baseTons = 10;
        int total;

        Console.WriteLine("Bienvenido a la calculadora de precio por tonelada. A continuación ingresa el número de toneladas a calcular:");
        tons = Convert.ToInt32(Console.ReadLine());

        if (tons <= 10){
            total = tons * basePrice;
        }else{ 
            total = (baseTons * basePrice) + ((tons - baseTons) * excedentPrice);
        }

        Console.WriteLine("Tu precio total sería de: $" + total);
    }
}