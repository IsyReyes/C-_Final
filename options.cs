using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Options {
  
  public static void printOptions(){

    Console.WriteLine("¿Qué quieres hacer ahora mismo?");
    Console.WriteLine("1. Suma de dos números");
    Console.WriteLine("2. Suma de tres números");
    Console.WriteLine("3. Multicálculo para 4 números");
    

    SwitchManager switchManager = new SwitchManager();
    switchManager.switchSelect();
  }

}