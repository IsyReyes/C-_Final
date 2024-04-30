using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

public class SequenceOfActions{


    public static void SequenceUntil23() {
        int num = 1;
        bool incrementByFour = true;

        do {
            Console.Write(num);
            int nextIncrement = incrementByFour ? 4 : 2;

            if (num + nextIncrement > 23) {
                break;
            }

            Console.Write(", ");
            num += nextIncrement;
            incrementByFour = !incrementByFour;

        } while (num <= 23);

        Console.WriteLine();
    }

    public static void SequenceAddEvens(){

        int addBox = 0;

        for (int i = 1; i <= 100; i++){

            if (i % 2 == 0){ 
            addBox += i;
            }
        }

        Console.WriteLine($"La suma total de números pares es: {addBox}");

    }



}