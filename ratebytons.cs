using System;

public class TonsCalculator {

    public static void TonsRate() {
        const int basePrice = 52;
        const int excedentPrice = 35;
        const int baseTons = 10;
        int tons;
        int total;

        Console.WriteLine("Bienvenido a la calculadora de precio por tonelada. A continuación ingresa el número de toneladas a calcular:");
        
        if (!int.TryParse(Console.ReadLine(), out tons) || tons < 0) {
            Console.WriteLine("Por favor, ingresa un número válido de toneladas (no negativas).");
            return;
        }

        if (tons <= baseTons) {
            total = tons * basePrice;
        } else {
            total = (baseTons * basePrice) + ((tons - baseTons) * excedentPrice);
        }

        Console.WriteLine($"Tu precio total sería de: ${total:N2}");
    }
}