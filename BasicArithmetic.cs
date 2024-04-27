using System;
using System.Runtime.CompilerServices;

public class BasicArithmetic
{
    private int num1 = 0;
    private int num2 = 0;
    private int num3 = 0;
    private int num4 = 0;


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

//Sum of two numbers 
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

//Sum of three numbers
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

//sum, substrac, product and division 
    public void multiCalculate(){
        Console.WriteLine("Acabas de accesar a la multicalculadora. Tomaremos 4 números y obtendremos la suma, resta, producto y divisón de estos.");

        while (true) {
            Console.WriteLine("Por favor ingresa tu primer número");
            if (ErrorHandling(int.TryParse(Console.ReadLine(), out num1)))
                continue;

            Console.WriteLine("Por favor ingresa tu segundo número");
            if (ErrorHandling(int.TryParse(Console.ReadLine(), out num2)))
                continue;

            Console.WriteLine("Por favor ingresa tu tercer número");
            if (ErrorHandling(int.TryParse(Console.ReadLine(), out num3)))
                continue;

            Console.WriteLine("Por favor ingresa tu cuarto número");
            if (ErrorHandling(int.TryParse(Console.ReadLine(), out num4)))
                continue;

            Console.WriteLine("Gracias, la suma de estos cuatro números es " + (num1 + num2 + num3 + num4));
            Console.WriteLine("Gracias, la resta de estos cuatro números es " + (num1 - num2 - num3 - num4));
            Console.WriteLine("El producto de estos números es " + (num1 * num2 * num3 * num4));
            try{
            Console.WriteLine("La divisón de estos números es " + (num1 / num2 / num3 / num4)); 
            }
            catch (DivideByZeroException) {
                Console.WriteLine("Se intento dividir por 0, lo que podría resultar en paradojas matemáticas. Ignorando proceso.");
                break;
            }
        break;
        }
    }

//area of a triangle
    public static void TriangleArea(){
        int triangleBase;
        int triangleHeight;

        Console.WriteLine("Muy bien, calculalremos el area de un triángulo. Para esto por favor indica cuál es la base, y la altura a continuación.");
        Console.WriteLine("Ingresa la base:");
        triangleBase = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa la altura:");
        triangleHeight = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Gracias. El área del tríangulo es " + (triangleBase * triangleHeight / 2));
    }

    //number of seconds in given days
    public static void SecondsInADay(){
        int secondsInADay = 86400;
        int numberOfDays;

        Console.WriteLine("Perfecto, vamos a calcular cuántos segundos hay en un número determinado de días. Por favor ingresa el número de días a continuación.");
        Console.WriteLine("Número de días:");
        numberOfDays = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("El número de segundos en " + numberOfDays + " día/s son " + (numberOfDays * secondsInADay));
    }



}