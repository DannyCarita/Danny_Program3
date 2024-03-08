
using System;
static class Program
{
static void Main(string[] args)
    {
        rotar();
        Console.ReadLine();
    }

    static void rotar()
    {
        string numero = Console.ReadLine();
        
        char ultimo = numero[0];
        char penultimo = numero[1];

        string resto = numero.Substring(2, numero.Length - 2);

        string resultado = resto + penultimo + ultimo;

        Console.WriteLine(resultado);
    }

}