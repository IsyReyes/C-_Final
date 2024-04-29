using System;
using System.Collections.Generic;

public class ReturnMissing{

    public static void getAngles(){
        int total = 180;
        int angleA;
        int angleB;

        Console.WriteLine("Vamos a determinar el valor de un tercer ángulo en un triángulo. Por favor ingresa los dos ámgulos que ya conoces.");
        Console.WriteLine("Primer ángulo:");
        angleA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Segundo ángulo:");
        angleB = Convert.ToInt32(Console.ReadLine());

        if (angleA + angleB > total){
            Console.WriteLine("Esto no es un triángulo.");
        }else { 
            Console.WriteLine("El ángulo faltante es " + (total - angleA - angleB));
        }
    }

    public static void MissingMoney(){
        int xHowMany;
        int yHowMany;
        int zHowMany;

        Console.WriteLine("Vamos a hacer una operación con valores predefinidos para saber cuánto dinero tiene Juan.");
        Console.WriteLine("Puedes elegir cuántos billetes de 200, de 100 y 50 tendrá.");

        Console.WriteLine("Por favor ingresa cuantos billetes de 200 tiene Juan");
        xHowMany = Convert.ToInt32(Console.ReadLine()) * 200;

        Console.WriteLine("Por favor ingresa cuantos billetes de 100 tiene Juan");
        yHowMany = Convert.ToInt32(Console.ReadLine()) * 100;

        Console.WriteLine("Por favor ingresa cuantos billetes de 50 tiene Juan");
        zHowMany = Convert.ToInt32(Console.ReadLine()) * 50;

        Console.WriteLine("Gracias, el total de dinero que Juant tiene es " + (xHowMany + yHowMany + zHowMany));


    }
}