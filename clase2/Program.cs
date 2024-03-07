using System;
static class suma
{
static void Main(string[]args)
{
/*    
int valor1 = 10;
int valor =suma_numeros(1, 2, 3);*/
int num1 = 2;
int num2 = 6;
int num3 = 5;


/*
Console.WriteLine(valor);
Console.ReadLine();
}
static int suma_numeros(int numero1, int numero2, int numero3)
{
    int respuesta=0;
    respuesta = numero1 + numero2 + numero3;

    return respuesta;
}

*/
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
}

}