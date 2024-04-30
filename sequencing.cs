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
}