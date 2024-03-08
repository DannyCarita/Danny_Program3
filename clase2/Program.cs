
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
//sacar el promedio de 3 notas
/*
int valor1 = 10;
int valor =suma_numeros(1, 2, 3);
int num1 = 2;
int num2 = 6;
int num3 = 5;

Console.WriteLine("cambio aqui");


Console.WriteLine(valor);
Console.ReadLine();
}
static int suma_numeros(int numero1, int numero2, int numero3)
{
    int respuesta=0;
    respuesta = numero1 + numero2 + numero3;
    return respuesta;
}

int mayor = num1;
if(num2 > mayor)
{
    mayor = num2;
}
if(num3 > mayor)
{
    mayor = num3;
}
Console.WriteLine(mayor);
*/