using System;
using System.Collections.Generic;
using ConsoleTables;

public class PassOrFail{

    public static void AcademicCheck(){
        int grade1;
        int grade2;
        int grade3;
        int average;
        string status;

        grade1 = ErrorHandler.SafeParseInt("Bienvenido a la calculadora de promedio. Por favor ingresa tu primera calificación:");

        grade2 = ErrorHandler.SafeParseInt("Gracias, ahora ingresa tu segunda calificación:");

        grade3 = ErrorHandler.SafeParseInt("Muy bien, ahora ingresa tu tercera calificación:");

        average = (grade1+grade2+grade3)/3;

        if (average >= 70){
            status = "aprobado";
        }else{
            status = "reprobado";
        }

        var table = new ConsoleTable("Promedio", "Estatus");
        table.AddRow(average, status);
        table.Write(Format.Alternative);

    }
}