using System;
using System.Globalization;

namespace Exercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1

            int numero = int.Parse(Console.ReadLine());

            if(numero < 0)
            {
                Console.WriteLine("NEGATIVO");
            } else
            {
                Console.WriteLine("NAO NEGATIVO");
            }

            // Exercício 2
             Console.WriteLine("Ex. 2");
             numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            } else
            {
                Console.WriteLine("IMPAR");
            }

            // Exercício 3

            string[] valores = Console.ReadLine().Split(' ');
            int val1 = int.Parse(valores[0]);
            int val2 = int.Parse(valores[1]);
            int maior = 0;
            int menor = 0;

            if(val1 > val2)
            {
                maior = val1;
                menor = val2;
            } else
            {
                maior = val2;
                menor = val1;
            }

            if((maior % menor) == 0)
            {
                Console.WriteLine("Sao Multiplos");
            } else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

            // Exercicio 4
            string[] valores1 = Console.ReadLine().Split(' ');
            int val11 = int.Parse(valores1[0]);
            int val21 = int.Parse(valores1[1]);

            int tempo = 0;

            if (val11 < val21)
            {
                tempo = val21 - val11;
            } else if (val11 > val21)
            {
                tempo = (24 - val11) + val21;
            }

            if (tempo == 0)
            {
                tempo = 24;
            }

            Console.WriteLine($"O JOGO DUROU {tempo} HORA(S)");

            // Exercicio 5
            double[] products = { 4.00, 4.50, 5.00, 2.00, 1.50 };
            string[] lanche = Console.ReadLine().Split(' ');

            int codigo = int.Parse(lanche[0]);
            int qtd = int.Parse(lanche[1]);

            double total = products[codigo - 1] * qtd;

            Console.WriteLine($"Total: R$ {total:F2}");

            // Exercicio 6
            double valor = 0;
            valor = double.Parse(Console.ReadLine());
            if (valor < 0.0 || valor > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if(valor<= 25) {
                Console.WriteLine("Intervalo [0, 25]");
            } else if (valor <= 50)
            {
                Console.WriteLine("Intervalo [25, 50]");
            }
            else if (valor <= 75)
            {
                Console.WriteLine("Intervalo [50, 75]");
            }
            else if (valor > 75)
            {
                Console.WriteLine("Intervalo [75, 100]");
            }

            // Exercicio 7

            string[] coords = Console.ReadLine().Split(' ');
            float x = float.Parse(coords[0]);
            float y = float.Parse(coords[2]);

            if(x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            } else if (x == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (y == 0 )
            {
                Console.WriteLine("Eixo Y");
            } else if(x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }

            double salary = double.Parse(Console.ReadLine());
            double imposto = 0;
            if(salary <= 2000.00)
            {
                imposto = 0;
            } else if(salary <= 3000.00)
            {
                imposto = (salary - 2000) * 0.08;
            } else if(salary <= 4500)
            {
                imposto = (salary - 3000) * 0.18 + 80;
            } else if (salary > 4500) {
                imposto = (salary - 4500) * 0.28 + 270 + 80;
            }

            if(imposto == 0)
            {
                Console.WriteLine("Isento");
            } else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

        }

       
    }
}
