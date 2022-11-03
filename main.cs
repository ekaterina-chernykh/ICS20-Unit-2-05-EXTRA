// Created by: Ekaterina
// Created on: Oct 2022
//
// This program calculates area of a triangle

using System;

class Program
{
    public static void Main(string[] args)
    {
        const Decimal TAX_RATE = (Decimal)0.18;
        const Decimal FULL_RATE = (Decimal)1;

        // This function accepts user input
        decimal worked;
        decimal rate;
        decimal pay;
        decimal tax;

        Console.WriteLine("This program calculates the pay and tax");
        Console.WriteLine(" ");

        Console.WriteLine("Please enter your emoployment information: ");
        Console.Write("Number of hours worked: ");
        worked = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Hourly rate: $");
        rate = Convert.ToDecimal(Console.ReadLine());

        pay = (worked * rate) * (FULL_RATE - TAX_RATE);
        tax = (worked * rate) * TAX_RATE;

        Console.WriteLine(" ");
        Console.WriteLine("Your pay will be: $" + pay.ToString("0.00"));
        Console.WriteLine("The govenment will take $" + tax.ToString("0.00"));

        Console.WriteLine("\nDone.");
    }
}