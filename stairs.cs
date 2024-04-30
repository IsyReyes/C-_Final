using System;
using System.Collections.Generic;

public class CoolStair{


    public static void LeftSideStair(){

        Console.WriteLine("Vamos a crear una escalerita perrona! Por favor ingresa la altura de tu escalerita:");
        int height = Convert.ToInt32(Console.ReadLine());

        for (int i=1;i <= height; i++){
            for (int j = 1; j <= i; j++){
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }

}