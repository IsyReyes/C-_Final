using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Options {
  
  public static void printOptions(){

    Console.WriteLine("¿Qué quieres hacer ahora mismo?");
    Console.WriteLine("1. Suma de dos números");
    Console.WriteLine("2. Suma de tres números");

    SwitchManager switchManager = new SwitchManager();
    switchManager.switchSelect();
  }

}