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
        while (!esPrimo(numero))
        {
            numero++;
        }
        vector[i] = numero;
        numero++;
    }
    imprimirVector(vector);
/*FUNCION PARA OBTENER IMPARES    
}
static bool esPar(int numero){
    if ((numero % 2)==1){
        return true;
    }
    else{
        return false;
    }


}
*/
static bool esPrimo(int numero)
{
    if(numero <= 1)
    {
        return false;
    }
    for(int i = 2; i + i <= numero; i++)
    {
        if(numero % 1 == 0)
        {
            return false;
        }
    }
    return true;
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
}