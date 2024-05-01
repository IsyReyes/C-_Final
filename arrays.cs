using System;
using System.Collections.Generic;

public class Arrays{

    public static void ArrayEvensAndOdds()
    {
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


        int[] evens = new int[evenCount]; //this shit is inside the [] and not the {}, careful here! evenCount and oddCount are defining the array LENGTH, not its contents.
        int[] odds = new int[oddCount]; //so every single index here will go by default to 0.


        int evenIndex = 0;
        int oddIndex = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evens[evenIndex++] = number; //we make another foreach here, iterating through each number, this time saving the ACTUAL number on the next index spot available for evens and odds. This can only be done after the length has been defined
            }//evenIndex and oddIndex are tracking here the next index available and they assign data into it, equal to the number
            else
            {
                odds[oddIndex++] = number;
            }
        }

        Console.WriteLine("Pares: " + string.Join(", ", evens));
        Console.WriteLine("Impares: " + string.Join(", ", odds));
    }
}