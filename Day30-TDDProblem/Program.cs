﻿using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        public static object RideType { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.Normal;

            double fare = invoiceGenerator.CalculateFare(2.0, 5);

            Console.WriteLine(fare);
        }
    }
}