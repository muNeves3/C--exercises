using System;

namespace ExerciciosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 1
            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"SOMA = {n1 + n2}");

            // Exericio 2
            Console.Write("Digite um número: ");
            double raio = double.Parse(Console.ReadLine());
            double area = Math.Pow(raio, 2) * 3.14159;
            Console.WriteLine($"A={area:F4}");

            // Exercicio 3
            Console.Write("Digite um número: ");
            int n11 = int.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            int n12 = int.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            int n13 = int.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            int n14 = int.Parse(Console.ReadLine());

            int diff = (n11 * n12 - n13 * n14);
            Console.WriteLine($"DIFRENÇA = {diff}");

            // Exercicio 4
            Console.Write("Digite o código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite as horas: ");
            float horas = float.Parse(Console.ReadLine());
            Console.Write("Digite o pagamento por hora: ");
            float salario = float.Parse(Console.ReadLine());
            float salarioFinal = salario * horas;
            Console.WriteLine($"NUMBER = {codigo}");
            Console.WriteLine($"SALARY = U$ {salarioFinal:F2}");

            // Exercicio 5
            Console.Write("Digite o código da peca: ");
            int peca = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero peca: ");
            float numero = float.Parse(Console.ReadLine());
            Console.Write("Digite opreco: ");
            float preco = float.Parse(Console.ReadLine());

            Console.Write("Digite o código da peca: ");
            int peca1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero peca: ");
            float numero2 = float.Parse(Console.ReadLine());
            Console.Write("Digite opreco: ");
            float preco3 = float.Parse(Console.ReadLine());

            float valor = (numero * preco) + (numero2 * preco3);
            Console.WriteLine($"VALOR A PAGAR: R$ {valor:F2}");

            // Exercicio 6
            double a, b, c, triangle, circulo, trapezio, quadrado, retangulo;

            string[] valores = Console.ReadLine().Split(' ');

             a = double.Parse(valores[0]);
             b = double.Parse(valores[1]);
             c = double.Parse(valores[2]);

             triangle = a * c / 2 ;
             circulo = (c * c) * 3.14159 ;
             trapezio = (a + b) * c / 2 ;
             quadrado = b * b ;
             retangulo = a * b ;

            Console.WriteLine($"TRAINGULO: {triangle:F3}");
            Console.WriteLine($"CIRCULO: {circulo:F3}");
            Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
            Console.WriteLine($"QUADRADO: {quadrado:F3}");
            Console.WriteLine($"RETANGULO: {retangulo:F3}");
        }
    }
}
