using System;
static class Program{
    static void Main(string[] args)
    {
        contarespacio();
        //int[,] numeros = GenerarMatrizPatron(5, 5);
        //ImprimirMatriz(numeros);
        //contarPalabras();
        //filtrarDigitosImpares(123456);
        //contarVocales();
      //filtrarDigitoPrimo(123456789);

    }
    //impar
static void filtrarDigitosImpares(int numero)
{
    int resultado = 0;
    int potencia = 1;

    while (numero != 0)
    {
        int digito = numero % 10;

        if (digito % 3 == 0)
        {
            resultado += digito * potencia;
            potencia *= 10;
        }

        numero /= 10;
    }

    Console.WriteLine( + resultado);
}

//numeros pares
static void filtrarDigitosPares(int numero)
{
    int resultado = 0;
    int potencia = 1;

    while (numero != 0)
    {
        int digito = numero % 10;

        if (digito % 2 == 0) // Verificar si el dígito es par
        {
            resultado += digito * potencia;
            potencia *= 10;
        }

        numero /= 10;
    }

    Console.WriteLine( + resultado);

}
//primos

static void filtrarDigitoPrimo(int numero)
{
    int resultado = 0;
    int potencia = 1;

    while (numero != 0)
    {
        int digito = numero % 10;

        if (esPrimo(digito)) 
        {
            resultado += digito * potencia;
            potencia *= 10;
        }

        numero /= 10;
    
    }
    Console.WriteLine( + resultado);
    
    }
    static bool esPrimo(int numero){

        if(numero <= 1){
            return false;
        }
        for(int i = 2; i * i <= numero; i++){
            if(numero % i == 0 ){
                return false;
            }
        }
        return true;

    }

//contar vocales
 static void contarVocales()
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine().ToLower(); 

            int contadorVocales = 0;

            foreach (char letra in palabra)
            {
                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                {
                    contadorVocales++;
                }
            }

            Console.WriteLine("La palabra ingresada tiene " + contadorVocales + " vocales.");

}
//Contar cuantos espacios tiene una oracióN
static void contarPalabras()
        {
            Console.Write("Ingrese una oración: ");
            string oracion = Console.ReadLine();

            int contadorPalabras = 0;
            bool enPalabra = false;

            foreach (char caracter in oracion)
            {
                if (char.IsLetter(caracter))
                {
                    if (!enPalabra)
                    {
                        contadorPalabras++;
                        enPalabra = true;
                    }
                }
                else
                {
                    enPalabra = false;
                }
            }

            Console.WriteLine(contadorPalabras);
        }

//cpntar espacio
static void contarespacio()
        {
            Console.Write("Ingrese una oración: ");
            string palabra = Console.ReadLine().ToLower();
            int ConteoVocales  = 0;

         for (int i = 0; i < palabra.Length; i++)
            {
                if(" ".Contains(palabra[i])) 
                {
                    ConteoVocales++;
                }
            }
            Console.WriteLine("la cantidad de espacio es de " + ConteoVocales);
            Console.ReadLine();

        }


//matris
static int[,] GenerarMatrizPatron(int filas, int columnas)
 {
    int[,] matriz = new int[filas, columnas];
    
    for (int f = 0; f < filas; f++)
 {
        for (int c = 0; c < columnas; c++)
        {
        matriz[f, c] = (f + 1) * (c + 1);
        }
 }
 return matriz;

 }
 static void ImprimirMatriz<T>(T[,] matriz)
        {
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.Write(matriz[fila, columna] + "\t");
                }
                Console.WriteLine();
            }        
}






}
