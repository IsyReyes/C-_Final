using System;
using System.Collections.Generic;
using ConsoleTables;

public class Loops{

    public static void PositivesOnly(){

        Console.WriteLine("Vamos a verificar si tus números son positivos");

        for (int i = 1; i <= 10; i++){

            int num = ErrorHandler.SafeParseInt("Por favor ingresa el número:");

            if (num >= 0){
                var table = new ConsoleTable("Confirmación");
                table.AddRow($"El número {num} es positivo.");
                table.Write(Format.Alternative);
            }else{
                var table = new ConsoleTable("Error");
                table.AddRow($"El número {num} es negativo.");
                table.Write(Format.Alternative);

            }
        }
    }

    public static void Multiply(){

        int num = ErrorHandler.SafeParseInt("¡Bienvenido a la multiplicadora 3000! Por favor ingresa un número para obtener su tabla de multiplicar:");

        var table2 = new ConsoleTable("Multiplicador", "Resultado");
        for (int i = 1; i <= 10; i++){

            int multiplied = num * i;
            table2.AddRow(i, multiplied);
        }
        table2.Write(Format.Alternative);
    }

    public static void GetFactorial(){

        int num = ErrorHandler.SafeParseInt("Vamos a sacar el factorial. Por favor ingresa un número:");
        int factorial = 1;

        for (int i = 1; i <= num; i++) {
            factorial *= i;
        }

        var table = new ConsoleTable("Número", "Factorial");
        table.AddRow(num, factorial);
        table.Write(Format.Alternative);
    }

    public static void GetHighest() {
        int highestNumber = 0;

        Console.WriteLine("Hola, vamos a buscar el número más grande!");

        for (int i = 1; i <= 20; i++) { 

            int inputNumber = ErrorHandler.SafeParseInt("Por favor ingresa un número:"); 

            if (inputNumber > highestNumber) { 
                highestNumber = inputNumber;
            }
        }

        var table = new ConsoleTable("Número Mayor");
        table.AddRow(highestNumber);
        table.Write(Format.Alternative);
    }

    public static void EvenOrOdd() {
        int sumEven = 0;
        int sumOdd = 0;
        //this if else condition checks if numbers are evens or odds by setting the modular as the condition.
        for (int i = 300; i <= 555; i++) {
            if (i % 2 == 0) {
                sumEven += i;
            } else {
                sumOdd += i;
            }
        }

        var table = new ConsoleTable("Suma Pares", "Suma Impares");
        table.AddRow(sumEven, sumOdd);
        table.Write(Format.Alternative);
    }

    public static void Fibonacci(){

        double r1 = 1;
        double r2 = 1;

        var table = new ConsoleTable("Número", "Fibonacci");
        table.AddRow(1, r1);
        table.AddRow(2, r2);


        Console.WriteLine("1: " + r1);
        Console.WriteLine("2: " + r2); 

        for (int i = 3; i <= 30; i++){
            double nextFibonacci = r1 + r2;

            table.AddRow(i, nextFibonacci);

            r1 = r2; 
            r2 = nextFibonacci;
        }
        table.Write(Format.Alternative);

    }

    public static void BelongsToFibonacci() {

        int num = ErrorHandler.SafeParseInt("Verifiquemos si tu número pertenece a la serie de Fibonacci. A continuación por favor ingresa el número:");

        int check1 = 5 * num * num + 4;
        int check2 = 5 * num * num - 4;

        bool IsPerfectSquare(int x) {
            int s = (int)Math.Sqrt(x);
            return s * s == x;
        }

        if (IsPerfectSquare(check1) || IsPerfectSquare(check2)) {
            var table = new ConsoleTable("Positivo");
            table.AddRow($"{num} pertenece a la serie de Fibonacci.");
            table.Write(Format.Alternative);
        } else {
            var table = new ConsoleTable("Negativo");
            table.AddRow($"{num} no pertenece a la serie de Fibonacci.");
            table.Write(Format.Alternative);        }
    }
}