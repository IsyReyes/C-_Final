using System;
using System.Collections.Generic;
using System.Globalization;
using ConsoleTables;

public class Arrays{

    private static Random rand = new Random();

    public static void ArrayEvensAndOdds(){
        int[] numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

        int evenCount = 0;
        int oddCount = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            } 
        }

        int[] evens = numbers.Where(n => n % 2 == 0).ToArray();
        int[] odds = numbers.Where(n => n % 2 != 0).ToArray();

        var table = new ConsoleTable("Números Pares", "Números Impares");
        int maxRows = Math.Max(evens.Length, odds.Length);
        for (int i = 0; i < maxRows; i++)
        {
            string even = i < evens.Length ? evens[i].ToString() : "";
            string odd = i < odds.Length ? odds[i].ToString() : "";
            table.AddRow(even, odd);
        }
        table.Write(Format.Alternative);
    }

    public static void ShiftArrays(){
        List<int> numbers = new List<int>();
        Console.WriteLine("Ingresa hasta 30 números o ingresa un 0 para continuar.");

        while (true)
        {
            int input = int.Parse(Console.ReadLine());
            
            if (input == 0 || numbers.Count == 30)
            {
                break;
            }

            numbers.Add(input);
        }
        
        int[] array = numbers.ToArray();

        ShiftRight(array);

        var table = new ConsoleTable("Array Recorrido");
        foreach (int num in array)
        {

            string shiftedArray= Convert.ToString(num);
            table.AddRow(shiftedArray);
        }
        table.Write(Format.Alternative);
    }

    public static void ArrayComparison(){

        int[] array = GenerateRandomArray(100, 1, 101);


        int firstHalfSum = SumArrayPart(array, 0, array.Length / 2);
        int secondHalfSum = SumArrayPart(array, array.Length / 2, array.Length);


        var table = new ConsoleTable("Suma 1era Mitad", "Suma 2da Mitad", "Mitad Ganadora");
        if (firstHalfSum > secondHalfSum){
            table.AddRow(firstHalfSum, secondHalfSum, "La suma de la primera mitad del arreglo es mayor a la de la segunda mitad.");
        }else if (firstHalfSum < secondHalfSum){
            table.AddRow(firstHalfSum, secondHalfSum, "La suma de la primera mitad del arreglo es menor a la de la segunda mitad.");
        }else{
            table.AddRow(firstHalfSum, secondHalfSum, "La suma de las dos mitades es igual");}
        table.Write(Format.Alternative);
    }

    public static void ArrayMaxMin(){

        int[] array = GenerateRandomArray(100, 1, 15000);

        Console.WriteLine("Array: " + string.Join(", ", array));

        int min = array[0];
        int max = array[0];

        for (int i = 0; i < array.Length; i++){
            if (array[i] > max){
                max = array[i];
            }
            if (array[i] < min){
                min = array[i];
            }
        }

        var table = new ConsoleTable("Número Mayor", "Número Menor");
        table.AddRow($"El número mayor es {max}", $"El número menor es {min}");
        table.Write(Format.Alternative);
    }

    public static void ArrayABC() {
        int[] arrayA = GenerateRandomArray(20, 1, 500);
        int[] arrayB = GenerateRandomArray(20, 1, 500);

        int[] arrayC = new int[20];


        for (int i = 0; i < arrayA.Length; i++) {
            arrayC[i] = arrayA[i] + arrayB[arrayB.Length - 1 - i];
        }

        var table = new ConsoleTable("Index", "A", "B", "A + B");
        for (int i = 0; i < arrayA.Length; i++) {
            table.AddRow(i, arrayA[i], arrayB[arrayB.Length - 1 - i], arrayC[i]);
        }
        table.Write(Format.Alternative);
}

    public static void ArrayAverage(){

        int[] array = GenerateRandomArray(100, 1, 101);

        int addingUp = 0;

        foreach (int num in array){
            addingUp+=num;
        }

        double average = addingUp / (double)array.Length;

        var table = new ConsoleTable("Total", "Promedio");
        table.AddRow(addingUp,average);
        table.Write(Format.Alternative);

    }


    private static int[] GenerateRandomArray(int length, int minValue, int maxValue){
        int[] array = new int[length];
        for (int i = 0; i < array.Length; i++){
            array[i] = rand.Next(minValue, maxValue);
        }
        return array;
    }

    private static int SumArrayPart(int[] array, int startIndex, int endIndex){
        int sum = 0;
        for (int i = startIndex; i < endIndex; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    // This method performs a right circular shift on an array. It temporarily stores the last element of the array,
    // then shifts all elements one position to the right in a backward loop, and finally places the originally last element into the first position.
    // The operation is performed only if the array is non-empty to avoid unnecessary processing and potential errors with empty arrays.
    private static void ShiftRight(int[] array){
        if (array.Length > 0)
        {
            int last = array[array.Length - 1]; // Temporarily store the last element
            for (int i = array.Length - 1; i > 0; i--){
                array[i] = array[i - 1]; // Move each element one position to the right
            }
            array[0] = last; // Set the first element to the originally last element
        }
    }
}