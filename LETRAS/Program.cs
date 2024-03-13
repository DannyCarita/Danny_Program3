using System;

static class Program{

static void Main(string[] args)
{
       string palabra = Console.ReadLine();
       LlenarVectorString(palabra);


}
static void LlenarVectorString(string palabra)
{
    char[] letras = new char[palabra.Length];

    for (int i = 0; i < palabra.Length; i++)
    {
        letras[i] = palabra[i];
    }
    imprimirVector(letras);
}

static void imprimirVector(char[] letras)
    {
        foreach (char letra in letras)
        {
            Console.Write(letra + " " );
        }

}
}