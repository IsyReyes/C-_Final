using System;
using System.Collections.Generic;
using ConsoleTables;

public class Promos
{
    public static void PrintDiscount()
    {
        string articleName = ErrorHandler.RequiredString("Vamos a revisar tu descuento! Introduce el nombre del artículo:");

        int key = ErrorHandler.VerifyKey("Introduce la clave del artículo. La clave puede ser 01 o 02");

        double originalPrice = ErrorHandler.SafeParseDouble("Introduce el precio original del artículo:");

        double discount = 0;

            if (key == 01)
                discount = originalPrice * 0.10;
            else if (key == 02)
                discount = originalPrice * 0.20;

        double discountedPrice = originalPrice - discount;

        var table = new ConsoleTable("Artículo", "Clave", "Precio Original", "Precio Con Descuento");
        table.AddRow(articleName, key, originalPrice, discountedPrice);
        table.Write(Format.Alternative);

    }

    public static void ShirtsTotal()
    {
        int shirtsAmount = ErrorHandler.SafeParseInt("Introduce la cantidad de camisas que deseas comprar:");

        double shirtPrice = ErrorHandler.SafeParseDouble("Introduce el precio por camisa:");

        double total = shirtPrice * shirtsAmount;
        double discount = (shirtsAmount >= 3) ? total * 0.20 : total * 0.10;

        double discountedTotal = total - discount;

        var table = new ConsoleTable("Número de Camisas", "Precio Individual", "Total", "Total con Descuento");
        table.AddRow(shirtsAmount, shirtPrice, total, discountedTotal);
        table.Write(Format.Alternative);
    }

    public static void SupermarketDiscounts()
    {
        double totalPurchase = ErrorHandler.SafeParseDouble("¡Bienvenido a la ruleta de descuentos! Introduce el total de tu compra:");

        int randomNumber = ErrorHandler.SafeParseInt("¡Introduce un número aleatorio para ganar un descuento!:");

        double discountPercentage = randomNumber < 74 ? 0.15 : 0.20;
        double discount = totalPurchase * discountPercentage;
        double discountedTotal = totalPurchase - discount;

        var table = new ConsoleTable("Número de la Suerte", "Total", "Total Con Descuento", "Total Descontado");
        table.AddRow(randomNumber, totalPurchase, Math.Round(discountedTotal, 2), Math.Round(discount, 2));
        table.Write(Format.Alternative);
    }


}