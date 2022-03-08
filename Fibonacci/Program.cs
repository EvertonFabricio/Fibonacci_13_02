using System;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ant = 0, atual = 1, fib = 0, i = 0;


            Console.WriteLine("Digite um número inteiro e positivo: ");
            int parada = int.Parse(Console.ReadLine());

            while (i < parada)
            {
                Console.Write($"{fib}, ");
                ant = atual;
                atual = fib;
                fib = atual + ant;


                i++;
            }
        }
    }
}
