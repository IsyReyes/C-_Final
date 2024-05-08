using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Options {

	public static void printOptions(){

		Console.WriteLine("¿Qué quieres hacer ahora mismo?");
		Console.WriteLine("1. Suma de dos números.");//done
		Console.WriteLine("2. Suma de tres números.");//done
		Console.WriteLine("3. Multicálculo para 4 números.");//done
		Console.WriteLine("4. Calcular la base de un triángulo.");//done
		Console.WriteLine("5. Calcular cuántos segundos hay en X número de días.");//done
		Console.WriteLine("6. Intercambiar los valores de dos variables.");//done
		Console.WriteLine("7. Buscar el ángulo faltante de un triángulo.");
		Console.WriteLine("8. Convertir grados de Celsius a Farenheit.");//done
		Console.WriteLine("9. Operación con variables predefinidas, dale dinero a Juan.");//done
		Console.WriteLine("10. Calcular tu edad hasta el año 2030");//done
		Console.WriteLine("11. Realizar la ecuación cuadrática con coeficientes predefinidos.");//done
		Console.WriteLine("12. Obtener tu sueldo por hora.");//done
		Console.WriteLine("13. Calcular costo por traslado de toneladas.");//done, but not very modular
		Console.WriteLine("14. Saber si estás aprobado o reprobado.");//done
        Console.WriteLine("15. Calcular descuento por artículo.");//done
        Console.WriteLine("16. Calcular total a pagar por camisas.");//done
        Console.WriteLine("17. Calcular descuento en supermercado.");//done
		Console.WriteLine("18. Imprimir números solo si son positivos con un loop.");//done
		Console.WriteLine("19. Obtén la tabla de multiplicar de un número.");//done
		Console.WriteLine("20. Obtener el factorial de un número.");//done
		Console.WriteLine("21. Imprimir el número más grande entre varios inputs.");//done
		Console.WriteLine("22. Imprimir la suma de números pares en impares entre el 300 y 555.");//done
		Console.WriteLine("23. Imprimir los primeros 30 números en la serie de Fibonacci.");//done
		Console.WriteLine("24. Verificar si un número pertenece a la serie de Fibonacci.");//done
		Console.WriteLine("25. Imprimir una escalerita perrona con una altura que tú elijas!!");//done
		Console.WriteLine("26. Imprimir una secuencia de números hasta el 23.");//done
		Console.WriteLine("27. Sumar todos los número pares entre el 1 y el 100.");//done
		Console.WriteLine("28. Inivierte un número positivo.");//done
		Console.WriteLine("29. Sumar los números de Fibonacci entre el 100 y el 10000.");//done
		Console.WriteLine("30. Convertir un número decimal en binario.");//done
		Console.WriteLine("31. Meter pares e impares en arreglos separados.");//done
		Console.WriteLine("32. Recorrer los elementos de un arreglo de N longitud un índice hacia la derecha.");//done
		Console.WriteLine("33. Comparar las dos mitades de un arreglo haciendo una suma de cada una.");//done
		Console.WriteLine("34. Crear un array con 100 valores random, y luego encontrar el mayor y el menor.");//done
		Console.WriteLine("35. Sumar el 1er índice de un arreglo A con un arreglo B, metiendo el resultado en un arreglo C.");//done
		Console.WriteLine("36. Obtener el promerio de un arreglo de 100 elementos del tipo int.");//done
		Console.WriteLine("0. Ingresa 0 para salir.");











		Console.WriteLine("Salir. Escribe Salir para terminar el programa.");

		SwitchManager switchManager = new SwitchManager();
		switchManager.switchSelect();
	}
}