using System;
using System.Collections.Generic;

public class Angles{

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
}