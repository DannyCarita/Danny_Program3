using System;

static class Program
{
        static void Main(string[] args)
        {
        /*    
        //vector de numeros
        int[] numeros = new int[] {1, 2, 3, 4, 5, };

        //vector de letras
        int[] letras = new char[] {'a', 'b', 'c', 'd', 'e' };

        //vecotres de palabras
        int[] palabras = new string[] {"hola", "mundo", "es", "genial" };

        //generar un vector vacio
        int[] vacio = new int[10];
        Console.WriteLine("\nvector vacio:");
        imprimirVector(vacio);
        */
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8 };
        cambiodedatos();

        int temp = cambio [3];
        cambio[3] = cambio [2];
        cambio[2] = temp;
        Console.WriteLine("\n Vector con posicion intercambiada; ");
        imprimirVector(cambio);

        }
        
        static void imprimirVector(int[] vector)
        {
            string vectorString = "";
            foreach(int elemento in vector) 
            {
                vectorString = vectorString + elemento + " ";
            }
            Console.WriteLine(vectorString);

        }
        static void cambiodedatos()
        {
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8 };
        imprimirVector(numeros);

        numeros[2] = 100;
        imprimirVector(numeros);
        //tareas viernes
        }
        

} 


