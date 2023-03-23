using System;
using System.Collections.Generic;
using System.Text;

namespace Intensivo.Ejercicios
{
    public class EjericiosIF
    {

        //Algoritmo que pida dos números e indique si el primero es mayor que el segundo o no.
        public void NumeroMayor()
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

        //Algoritmo que pida un número y diga si es positivo, negativo o 0.
        public void PositivoNegativo()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("***Numero Positivo, Negativo ó 0********");
            Console.WriteLine("****************************************");
            Console.WriteLine("Por favor escriba el número.");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine($"El número: {numero} es un número Positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine($"El número: {numero} es un número Negativo");
            }
            else
            {
                Console.WriteLine($"El número: {numero} es 0");
            }

        }

        //Escribe un programa que lea un número e indique si es par o impar.
        public void ParImpar()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("***Numero Paró Impar********");
            Console.WriteLine("****************************");
            Console.WriteLine("Por favor escriba el número.");
            int numero = Convert.ToInt32(Console.ReadLine());

            double result = numero % 2;

            if (result == 0)
            {
                Console.WriteLine($"El número: {numero} es un número Par");
            }
            else
            {
                Console.WriteLine($"El número: {numero} es un número Impar");
            }
        }
    }
}
