using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using ConsoleTables;

public class SequenceOfActions{


    public static void SequenceUntil23() {
        int num = 1;
        bool incrementByFour = true;

        var table = new ConsoleTable("Secuencia Hasta 23");

        do {
            table.AddRow(num);

            int nextIncrement = incrementByFour ? 4 : 2;

            if (num + nextIncrement > 23) {
                break;
            }

            num += nextIncrement;
            incrementByFour = !incrementByFour; //make it once, then ignore changing flag, repeat.

        } while (num <= 23);
        table.Write(Format.Alternative);
    }

    public static void SequenceAddEvensDoWhile() {
        int addBox = 0;  
        int i = 1;

        do {
            if (i % 2 == 0) {
                addBox += i;
            }
            i++;  
        } while (i <= 100);

        Console.WriteLine($"La suma total de números pares es: {addBox}");
    }

    public static void InvertNumber()
    {
        Console.WriteLine("Por favor, ingresa un número para invertir:");
        int num = Convert.ToInt32(Console.ReadLine());
        int invertedNumber = 0;

        do
        {
            int digit = num % 10;
            invertedNumber = invertedNumber * 10 + digit;
            num /= 10;
        } while (num > 0);

        Console.WriteLine($"El número invertido es: {invertedNumber}");
    }

    public static void FibonacciUntil10k()
    {
        int a = 0;
        int b = 1;
        int addBox = 0;

        for (int nextFibonacci = a + b; nextFibonacci <= 10000; nextFibonacci = a + b)
        {
            a = b;  // Avanza al siguiente término
            b = nextFibonacci;  // Establece el nuevo término de Fibonacci

            if (nextFibonacci >= 100 && nextFibonacci <= 10000)
            {
                addBox += nextFibonacci;  // Suma solo los términos que están dentro del rango
            }
        }

        Console.WriteLine($"La suma de los términos de la serie de Fibonacci entre 100 y 10,000 es: {addBox}");
    }

}