using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraLineal
{
    internal class Program
    {
        static int EncontrarSumaPares(List<int> lista)
        {
            int suma = 0;
            foreach (int numero in lista)
            {
                if (numero % 2 == 0)
                {
                    suma += numero;
                }
            }
            return suma;
        }

        static void ImprimirLista(List<int> lista)
        {
            foreach (int numero in lista)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            
        }
        static void Main(string[] args)
        {
            // Crear una lista de números enteros
            List<int> numeros = new List<int> { 12, 45, 78, 23, 56, 89, 34, 67 };

            // Encontrar la suma de los números pares en la lista
            int sumaPares = EncontrarSumaPares(numeros);

            // Imprimir el resultado
            Console.WriteLine("Lista de números:");
            ImprimirLista(numeros);
            Console.WriteLine($"La suma de los números pares en la lista es: {sumaPares}");
            Console.ReadKey();
        }

       
    }
}




