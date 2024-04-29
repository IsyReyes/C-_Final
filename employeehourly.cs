using System;
using System.Collections.Generic;

public class EmployeeCalculator{

public static void CalculateHourlyWage() {
    const int regularHours = 40;
    const int overtimeMultiplier = 2;

    Console.WriteLine("Hola, bienvenido a la calculadora de sueldo. Por favor ingresa tu número de empleado a continuación:");
    int employeeNumber = SafeReadInt("Número de empleado:");

    Console.WriteLine("Gracias, ahora por favor ingresa el número de horas que has trabajado:");
    int workedHours = SafeReadInt("Número de horas trabajadas:");

    Console.WriteLine($"¡Excelente! tu número de empleado es {employeeNumber} y has trabajado {workedHours} horas.");
    Console.WriteLine("Por favor indica cuál es tu salario por hora a continuación:");
    
    int hourlyWage = SafeReadInt("Salario por hora:");

    int salary = CalculateSalary(workedHours, hourlyWage, regularHours, overtimeMultiplier);
    Console.WriteLine("Tu sueldo será de " + salary);
}

private static int SafeReadInt(string prompt) {
    int input;
    while (!int.TryParse(Console.ReadLine(), out input)) {
        Console.WriteLine("Por favor ingresa un número válido.");
        Console.WriteLine(prompt);
    }
    return input;
}

private static int CalculateSalary(int workedHours, int hourlyWage, int regularHours, int overtimeMultiplier) {
    if (workedHours <= regularHours) {
        return workedHours * hourlyWage;
    } else {
        int regularPay = regularHours * hourlyWage;
        int extraHours = (workedHours - regularHours);
        int overtimePay = extraHours * hourlyWage * overtimeMultiplier;
        return regularPay + overtimePay;
    }
}

}