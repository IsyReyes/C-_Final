using System;
using System.Collections.Generic;

public class Promos
{
    public static void PrintDiscount()
    {
        Console.WriteLine("Vamos a revisar tu descuento! Introduce el nombre del artículo:");
        string articleName = Console.ReadLine();

        Console.WriteLine("Introduce la clave del artículo (01 para 10% o 02 para 20% de descuento):");
        string key = Console.ReadLine();

        Console.WriteLine("Introduce el precio original del artículo:");
        double originalPrice = Convert.ToDouble(Console.ReadLine());

        double discount = 0;
        if (key == "01")
            discount = originalPrice * 0.10;
        else if (key == "02")
            discount = originalPrice * 0.20;

        double discountedPrice = originalPrice - discount;

        Console.WriteLine($"Artículo: {articleName}");
        Console.WriteLine($"Clave: {key}");
        Console.WriteLine($"Precio Original: ${originalPrice}");
        Console.WriteLine($"Precio con Descuento: ${discountedPrice}");
    }

    public static void ShirtsTotal()
    {
        Console.WriteLine("Introduce la cantidad de camisas que deseas comprar:");
        int shirtsAmount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el precio por camisa:");
        double shirtPrice = Convert.ToDouble(Console.ReadLine());

        double total = shirtPrice * shirtsAmount;
        double discount = (shirtsAmount >= 3) ? total * 0.20 : total * 0.10;

        double discountedTotal = total - discount;

        Console.WriteLine($"Total camisas: {shirtsAmount}");
        Console.WriteLine($"Precio por camisa: ${shirtPrice}");
        Console.WriteLine($"Total sin descuento: ${total}");
        Console.WriteLine($"Total con descuento: ${discountedTotal}");
    }

    public static void SupermarketDiscounts()
    {
        Console.WriteLine("¡Bienvenido a la ruleta de descuentos! Introduce el total de tu compra:");
        double totalPurchase = Convert.ToDouble(Console.ReadLine());

        //(menor a 74 para 15% de descuento, 74 o más para 20%)
        Console.WriteLine("¡Introduce un número aleatorio para ganar un descuento!:");
        int randomNumber = Convert.ToInt32(Console.ReadLine());

        double discountPercentage = randomNumber < 74 ? 0.15 : 0.20;
        double discount = totalPurchase * discountPercentage;
        double discountedTotal = totalPurchase - discount;

        Console.WriteLine($"Número escogido: {randomNumber}");
        Console.WriteLine($"Total de la compra: ${totalPurchase}");
        Console.WriteLine($"Descuento aplicado: ${discount}, felicidades!");
        Console.WriteLine($"Total con descuento: ${discountedTotal}");
    }
}