using System;

public class Program
{
    public static void Main()
    {
        string texto = "hola como estas tu";

        string[] oraciones = texto.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string oracion in oraciones)
        {
            string oracionAlReves = VoltearLetras(oracion);
            Console.WriteLine(oracionAlReves);
        }
        //VoltearLetras()
        /*Console.WriteLine("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());
        
        int nuevoNumero = VoltearDigito(numero);
        
        Console.WriteLine(nuevoNumero);
        */
    }
/*
static int RotarDigito(int numero)
{
   
    string numeroString = numero.ToString();
    
    string ultimosDigitos = numeroString.Substring(numeroString.Length - 2);
    string nuevoNumeroString = ultimosDigitos + numeroString.Substring(0, numeroString.Length - 2);
    
    int nuevoNumero = int.Parse(nuevoNumeroString);
    
    return nuevoNumero;
}

poner el del medio al inicio
static int RotarDigito(int numero)
{

    string numeroString = numero.ToString();
  
    int indiceMedio = numeroString.Length / 2;
    char digitoMedio = numeroString[indiceMedio];
    string nuevoNumeroString = digitoMedio + numeroString.Substring(0, indiceMedio) + numeroString.Substring(indiceMedio + 1);
    int nuevoNumero = int.Parse(nuevoNumeroString);
    return nuevoNumero;
}

static int RotarDigito(int numero)
{
    int numeroInvertido = 0;
    while (numero > 0)
    {
        int digito = numero % 10;
        numeroInvertido = (numeroInvertido * 10) + digito;
        numero /= 10;
    }
    return numeroInvertido

}

static int VoltearDigito(int numero)
{
    // Convertimos el número a una cadena para manipular sus dígitos
    string numeroString = numero.ToString();
  
    string nuevoNumeroString = "";
    for (int i = numeroString.Length - 1; i >= 0; i--)
    {
        nuevoNumeroString += numeroString[i];
    }
    // Convertimos la cadena resultante de nuevo a un número
    int nuevoNumero = int.Parse(nuevoNumeroString);
    return nuevoNumero;
}
*/
static string VoltearLetras(string oracion)
    {
        // Dividir la oración en palabras utilizando los espacios como delimitadores
        string[] palabras = oracion.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string resultado = "";

        // Voltear las letras de cada palabra
        foreach (string palabra in palabras)
        {
            char[] letras = palabra.ToCharArray();
            Array.Reverse(letras);
            resultado += new string(letras) + " ";
        }

        return resultado.Trim();
    }

}



