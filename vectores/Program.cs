using System;

static class Program{

static void Main(string[] args)
{
        LlenarVector(10);
}
static void LlenarVector(int cantidad)
{
    int[] vector = new int[cantidad];
    int numero = 1;

    for (int i = 0; i < cantidad; i++)
    {
        while (!esPar(numero))
        {
            numero++;
        }
        vector[i] = numero;
        numero++;
    }
    imprimirVector(vector);
}
static bool esPar(int numero){
    if ((numero % 2)==1){
        return true;
    }
    else{
        return false;
    }


}

static void imprimirVector(int[] vector)
{
    foreach(int elemento in vector)
    {
        Console.Write(elemento + " ");
    }
    Console.WriteLine();
}

}
