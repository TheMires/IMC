﻿using System;

namespace IMC_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float altura;
            float peso;
            float imc;

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua altura: ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso: ");
            peso = float.Parse(Console.ReadLine());

            imc = (peso / (altura * altura));

            Console.WriteLine(nome + ", seu IMC é: " + imc);
        }
    }
}