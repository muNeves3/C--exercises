using System;
using System.Globalization;

namespace Exercicios4
{
    class Program
    {
        static void Main(string[] args)
        {
             int x = int.Parse(Console.ReadLine());
            // leituraImpares(x);
            // leituraIntervalo(x);
            // MediaPonderada(x);
            // Divisao(x);
            // Fatorial(x);
            // Divisores(x);
            // Multiplicadores(x);
        }

        static void leituraImpares (int x)
        {
            if(x < 1 || x > 100)
            {
                Console.WriteLine("Digite um número de 1 até 100");
                x = int.Parse(Console.ReadLine());
            }

            for(int i = 1; i <= x; i++)
            {
                int impar;
                if(x % i != 0)
                {
                    impar = i;
                    Console.WriteLine(impar);
                }
            }
        }
        static void leituraIntervalo (int n)
        {
                int inVal = 0;
                int outVal = 0;

            for(int i = 1; i <= n; i++)
            {
                int valores = int.Parse(Console.ReadLine());
                if(valores >= 10 && valores <= 20)
                {
                    inVal++;
                } else
                {
                    outVal++;
                }
            }
            Console.WriteLine($"{inVal} in \n{outVal} out");
        }
        static void MediaPonderada (int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                float media = (float.Parse(valores[0]) * 2 + float.Parse(valores[1]) * 3 + float.Parse(valores[2]) * 5) / 10;

                Console.WriteLine($"{media:F1}");
            }
        }
        static void Divisao (int n)
        {  

            for(int i = 1; i <= n; i ++)
            {
                string[] pares = Console.ReadLine().Split(' ');
                if (float.Parse(pares[1]) == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine($"{float.Parse(pares[0]) / float.Parse(pares[1]):F1}");
                }
            }
        }
        static void Fatorial (int n)
        {
            int fatorial = n;
            if(n == 0)
            {
                Console.WriteLine("1");
                return;
            }

            for(int i = 1; i <= n; i ++) 
            {
                fatorial *= (n - i);
                if((n - i) == 1)
                {
                    Console.WriteLine(fatorial);
                }
            }
        }
        static void Divisores (int n)
        {
            for(int i = 1; i <= n; i ++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Multiplicadores (int n)
        {
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }
        }
    }
}
