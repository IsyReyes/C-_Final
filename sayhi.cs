using System;
using System.Collections.Generic;

public class SayHi{

	public string username = " ";

		public void Salute(){
		Console.WriteLine("Hola! Te doy la bienvenida al Chatbot de primer semestre.");
		Console.WriteLine("Aquí encontrarás un recuento delos ejercicios que hemos hecho hasta ahora ");
		Console.WriteLine("Por favor ingresa tu nombre: ");

		username  = Console.ReadLine();

		Console.WriteLine("Gracias " + username + ", a continuación te presentaré una serie de opciones que podrás elegir para realizar diferentes tareas");

		//print options(referr to Options class)
		Options.printOptions();
	}
}