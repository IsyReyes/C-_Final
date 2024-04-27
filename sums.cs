using System;

public class Sums
{
    private int num1 = 0;
    private int num2 = 0;
    private int num3 = 0;

//taking  error handler out of loops 
    private static bool ErrorHandling(bool isNumber)
    {
        if (!isNumber)
        {
            Console.WriteLine("Se detectó una respuesta que no es válida, intentemos de nuevo desde el inicio, recuerda usar solo números.");
            return true;
        }
        return false;
    }

    public void TwoNumbers()
    {
        while (true)
        {
            Console.WriteLine("Por favor ingresa tu primer número");
            if (ErrorHandling(int.TryParse(Console.ReadLine(), out num1)))
                continue;

            Console.WriteLine("Por favor ingresa tu segundo número");
            if (ErrorHandling(int.TryParse(Console.ReadLine(), out num2)))
                continue;

            Console.WriteLine("Gracias, la suma de estos dos números es " + (num1 + num2));
            break; // Break the loop on success
        }
    }

    public void ThreeNumbers()
    {
        while (true)
        {
            Console.WriteLine("Por favor ingresa tu primer número");
            if (ErrorHandling(int.TryParse(Console.ReadLine(), out num1)))
                continue;

            Console.WriteLine("Por favor ingresa tu segundo número");
            if (ErrorHandling(int.TryParse(Console.ReadLine(), out num2)))
                continue;

            Console.WriteLine("Por favor ingresa tu tercer número");
            if (ErrorHandling(int.TryParse(Console.ReadLine(), out num3)))
                continue;

            Console.WriteLine("Gracias, la suma de estos tres números es " + (num1 + num2 + num3));
            break; // Break the loop on success
        }
    }
}

//check overloads to make possible sums with different argument numbers