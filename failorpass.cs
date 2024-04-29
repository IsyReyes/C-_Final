using System;
using System.Collections.Generic;

public class PassOrFail{

    public static void AcademicCheck(){
        int grade1;
        int grade2;
        int grade3;
        int average;
        string status;

        Console.WriteLine("Bienvenido a la calculadora de promedio. Por favir ingresa tu primera calificación:");
        grade1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Gracias, ahora ingresa tu segunda calificación:");
        grade2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Muy bien, ahora ingresa tu tercera calificación:");
        grade3 = Convert.ToInt32(Console.ReadLine());

        average = (grade1+grade2+grade3)/3;

        if (average >= 70){
            status = "aprobado";
        }else{
            status = "reprobado";
        }

        Console.WriteLine($"Gracias, tu promedio es: {average}. Estás {status}.");

    }
}