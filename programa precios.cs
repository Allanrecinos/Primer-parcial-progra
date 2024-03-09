using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido a la calculadora de precios");

        double[] precios = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Ingrese el precio del producto {i + 1}: ");
            precios[i] = Convert.ToDouble(Console.ReadLine());

            if (precios[i] > 100.00)
            {
                double descuento = CalcularDescuento(precios[i]);
                precios[i] -= descuento;
            }
        }

        double totalBruto = 0;
        foreach (double precio in precios)
        {
            totalBruto += precio;
        }

        Console.WriteLine($"El total de la compra bruto es: {totalBruto:C}");

        double descuentoTotal = CalcularDescuentoTotal(precios);
        Console.WriteLine($"El monto que te ahorras por los descuentos es: {descuentoTotal:C}");
    }

    static double CalcularDescuento(double precio)
    {
        return precio * 0.15;
    }

    static double CalcularDescuentoTotal(double[] precios)
    {
        double totalSinDescuento = 0;
        foreach (double precio in precios)
        {
            totalSinDescuento += precio;
        }

        double totalConDescuento = 0;
        foreach (double precio in precios)
        {
            if (precio > 100.00)
            {
                totalConDescuento += precio - (precio * 0.15);
            }
            else
            {
                totalConDescuento += precio;
            }
        }

        return totalSinDescuento - totalConDescuento;
    }
}