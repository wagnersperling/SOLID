﻿using OCP_ExtensionMethods.Extensions;
using System;

namespace OCP_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto(
                1,
                "Caneta",
                "Caneta Esferográfica azul",
                2.00M,
                3.40M,
                100,
                true
                );

            Console.WriteLine($"Produto = {produto1.Nome} Lucro = {produto1.MargemLucro()}");

            Console.ReadLine();
        }
    }
}
