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
    Console.WriteLine("Elige escribiendo el número de la tarea a realizar.");  
    Console.WriteLine("lista de tareas:");

    //instantiate options and print them
    Options options = new Options();
    Options.printOptions();
  }

}