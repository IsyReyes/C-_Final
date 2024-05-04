using System;
using System.Collections.Generic;
using ConsoleTables;

public class Initializer {
//This class serves as a launcher for the program, initiating the switch manager. 
	public static void Main(string[] args) {

		Console.WriteLine("Inicializando programa.");

		SayHi sayHi = new SayHi();
		sayHi.Salute();

	}
}

