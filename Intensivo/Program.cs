using Intensivo.Ejercicios;
using System;

namespace Intensivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Tipos de datos númericos
            //int numeroEntero = 10;
            //double numeroDouble = 12.52;
            //float numeroFloat = 14;
            //decimal numeroDecimal = 16;


            ////tipo de datos texto
            //string tipoTexto = "Hola mundo del gallinero x2";

            ////Tipos boleanos
            //bool resultado = false;//true

            //Console.WriteLine(tipoTexto);
            //int resultaMultiplicacion = numeroEntero * 50;

            //string forma_1 = "Resultado: " + resultaMultiplicacion;
            //Console.WriteLine(forma_1);

            //string forma_2 = $"Resultado: {resultaMultiplicacion}";
            //Console.WriteLine(forma_2);

            //NumeroMayor();


            EjericiosIF objEjercicio= new EjericiosIF();
            objEjercicio.ParImpar();
        }


        //Algoritmo que pida dos números e indique si el primero es mayor que el segundo o no.
        private static void NumeroMayor()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("***Numero Mayor********");
            Console.WriteLine("***********************");
            Console.WriteLine("Por favor escriba el número 1.");
            int numero_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor escriba el número 2.");
            int numero_2 = Convert.ToInt32(Console.ReadLine());

            if (numero_1 > numero_2)
            {
                Console.WriteLine("Felicidades, el número 1, es mayor que el número 2");
                Console.WriteLine("");
                Console.WriteLine($"Felicidades, el número: {numero_1}, es mayor que el número: {numero_2}");
            }
            else
            {
                Console.WriteLine("No se cumplió la condición, el número 2 es mayor que el número 1");
                Console.WriteLine("");
                Console.WriteLine($"No se cumplió la condición, el número: {numero_2}, es mayor que el número: {numero_1}");
            }
        }
    
        
    
    }
}
