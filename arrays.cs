using System;
using System.Collections.Generic;

public class Arrays{

    public static void ArrayEvensAndOdds()
    {
        int[] numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

        int evenCount = 0;
        int oddCount = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }


        int[] evens = new int[evenCount]; //this shit is inside the [] and not the {}, careful here! evenCount and oddCount are defining the array LENGTH, not its contents.
        int[] odds = new int[oddCount]; //so every single index here will go by default to 0.


        int evenIndex = 0;
        int oddIndex = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evens[evenIndex++] = number; //we make another foreach here, iterating through each number, this time saving the ACTUAL number on the next index spot available for evens and odds. This can only be done after the length has been defined
            }//evenIndex and oddIndex are tracking here the next index available and they assign data into it, equal to the number
            else
            {
                odds[oddIndex++] = number;
            }
        }

        Console.WriteLine("Pares: " + string.Join(", ", evens));
        Console.WriteLine("Impares: " + string.Join(", ", odds));
    }

    public static void ShiftArrays()
    {
        List<int> numbers = new List<int>(); //esto tiene q ser dinámico por la condición impuesta (0 o 30, lo q pase primero), por eso usamos list y no array
        Console.WriteLine("Enter up to 30 numbers. Enter '0' to stop.");
        
        while (true)
        {
            int input = int.Parse(Console.ReadLine());
            
            if (input == 0 || numbers.Count == 30) //aquí ta la condición, si algo de esto pasa, esto se detiene y deja de agregar
            {
                break;
            }
            
            numbers.Add(input); //esto es lo q agrega elementos a la lista
        }
        
        int[] array = numbers.ToArray(); //aquí lo convertimos a array ya q todo está contado
        
        if (array.Length > 0) //verificamos que no se haya puesto 0 desde el inicio, que existan datos en el array
        {
            int last = array[array.Length - 1]; //definimos la posición del último índice, que es igual a la longitud del array, -1
            for (int i = array.Length - 1; i > 0; i--) //aquí seteamos esto p/que funcione 1 sola vez, por eso dice i>0, el loop empieza con int i = array.Length - 1, que es el último índice del array, el i-- resta el índice
            {
                array[i] = array[i - 1]; // y lo que hace es esto, toma cada elemento de el array que se llama array(los elementos vienen entre las [ ]), y les hace un -1, para bajarlos
            }
            array[0] = last; // Pone el primer elemento en la última posición, que definimos anteriormente
        }
        
        Console.WriteLine("Shifted Array:");
        foreach (int num in array)
        {
            Console.WriteLine(num);
        }
    }

    public static void ArrayComparison()
    {
        int[] array = new int[100];
        Random rand = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(1, 101);  // pone números random del 1 al 100 dentro de un nuevo array, .Next es para q no se salga de lo que tú le digas entre los paréntesis como sus argumentos
        }

        int firstHalfSum = 0;//1era mitad
        int secondHalfSum = 0;//2da mitad

        // calc la suma de la 1era mitad
        for (int i = 0; i < array.Length / 2; i++)//hace el for HASTA el total del arreglo /2, o sea la primeramitad
        {
            firstHalfSum += array[i];
        }
        Console.WriteLine(firstHalfSum);

        // calc la suma de la 2da mitad
        for (int i = array.Length / 2; i < array.Length; i++) //EMPIEZA el for en la mitad, y lo hace hasta el final, o sea la segunda mitad
        {
            secondHalfSum += array[i];
        }
        Console.WriteLine(secondHalfSum);


        // compara las sumas y te da los resultados
        //TENKIU TENKIUU
        if (firstHalfSum > secondHalfSum)
        {
            Console.WriteLine("La suma de la primera mitad del arreglo es mayor a la de la segunda mitad.");
        }
        else if (firstHalfSum < secondHalfSum)
        {
            Console.WriteLine("La suma de la primera mitad del arreglo es menor a la de la segunda mitad.");
        }
        else
        {
            Console.WriteLine("La suma de las dos mitades es igual");
        }
    }

    public static void ArrayMaxMin(){

        int[] array = new int[100];
        Random rand = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(1, 15000);
        }

        Console.WriteLine("Array: " + string.Join(", ", array));

        int min = array[0];
        int max = array[0];

        for (int i = 0; i < array.Length; i++){
            if (array[i] > max){
                max = array[i];
            }
            if (array[i] < min){
                min = array[i];
            }
        }
            Console.WriteLine("El número mayor es: " + max);
            Console.WriteLine("El número menor es: " + min);
    }


}