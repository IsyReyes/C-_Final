using System;
using System.Collections.Generic;

public class Loops{

    public static void PositivesOnly(){

        Console.WriteLine("Vamos a verificar si tus números son positivos");

        for (int i = 1; i <= 10; i++){
            Console.WriteLine("Por favor ingresa el número:");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0){
                Console.WriteLine(num);
            }else{
                Console.WriteLine("El número es negativo, es imposible imprimirlo.");
            }
        }
    }

    public static void Multiply(){
        Console.WriteLine("¡Bienvenido a la multiplicadora 3000! Por favor ingresa un número para obtener su tabla de multiplicar:");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++){

            int multiplied = num * i;
            Console.WriteLine($"{num} * {i} = {multiplied}");
        }
    }

    public static void GetFactorial(){
        Console.WriteLine("Vamos a sacar el factorial. Por favor ingresa un número:");
        int num = Convert.ToInt32(Console.ReadLine());
        int factorial = 1;

        for (int i = 1; i <= num; i++) {
            factorial *= i;
        }

Console.WriteLine($"El factorial de {num} es {factorial}");
    }

    public static void GetHighest(){

            int highestNumber = 0;
            int inputNumber = 0;

        Console.WriteLine("Hola, vamos a buscar el número más grande!");
        
        for (int i = 1; i == 20; i++){
            Console.WriteLine("Por favor ingresa el número:");
            
            
            
            inputNumber = Convert.ToInt32(Console.ReadLine());

            if (inputNumber >= highestNumber){
                highestNumber = inputNumber;
            }
        }

        Console.WriteLine($"El número más alto es {highestNumber}");

    }
}