using System;
using System.Collections.Generic;

public class Sums {

	private int num1 = 0;
	private int num2 = 0;

    public void TwoNumbers (){
    	Console.WriteLine("Por favor ingresa tu primer número");
		num1 = Convert.ToInt32(Console.ReadLine());
    	Console.WriteLine("Por favor ingresa tu segundo número");
		num2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Gracias, la suma de estos dos números es " + (num1 + num2));
    }

}